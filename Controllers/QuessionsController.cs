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
    public class QuessionsController : ControllerBase
    {
        private readonly LanguageLearningContext _context;

        public QuessionsController(LanguageLearningContext context)
        {
            _context = context;
        }

        // GET: api/Quessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quession>>> GetQuession()
        {
            return await _context.Quession.ToListAsync();
        }

        // GET: api/Quessions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quession>> GetQuession(int id)
        {
            var quession = await _context.Quession.FindAsync(id);

            if (quession == null)
            {
                return NotFound();
            }

            return quession;
        }

        // PUT: api/Quessions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuession(int id, Quession quession)
        {
            if (id != quession.Id)
            {
                return BadRequest();
            }

            _context.Entry(quession).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuessionExists(id))
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

        // POST: api/Quessions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Quession>> PostQuession(Quession quession)
        {
            _context.Quession.Add(quession);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuession", new { id = quession.Id }, quession);
        }

        // DELETE: api/Quessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuession(int id)
        {
            var quession = await _context.Quession.FindAsync(id);
            if (quession == null)
            {
                return NotFound();
            }

            _context.Quession.Remove(quession);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuessionExists(int id)
        {
            return _context.Quession.Any(e => e.Id == id);
        }
    }
}
