using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LanguageLearning.Data;
using LanguageLearning.Domain;

namespace LanguageLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonContentsController : ControllerBase
    {
        private readonly LanguageLearningContext _context;

        public LessonContentsController(LanguageLearningContext context)
        {
            _context = context;
        }

        // GET: api/LessonContents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LessonContent>>> GetLessonContent()
        {
            return await _context.LessonContent.ToListAsync();
        }

        // GET: api/LessonContents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LessonContent>> GetLessonContent(int id)
        {
            var lessonContent = await _context.LessonContent.FindAsync(id);

            if (lessonContent == null)
            {
                return NotFound();
            }

            return lessonContent;
        }

        // PUT: api/LessonContents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLessonContent(int id, LessonContent lessonContent)
        {
            if (id != lessonContent.Id)
            {
                return BadRequest();
            }

            _context.Entry(lessonContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonContentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LessonContents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LessonContent>> PostLessonContent(LessonContent lessonContent)
        {
            _context.LessonContent.Add(lessonContent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLessonContent", new { id = lessonContent.Id }, lessonContent);
        }

        // DELETE: api/LessonContents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLessonContent(int id)
        {
            var lessonContent = await _context.LessonContent.FindAsync(id);
            if (lessonContent == null)
            {
                return NotFound();
            }

            _context.LessonContent.Remove(lessonContent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LessonContentExists(int id)
        {
            return _context.LessonContent.Any(e => e.Id == id);
        }
    }
}
