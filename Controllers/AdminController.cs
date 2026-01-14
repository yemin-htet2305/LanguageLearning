using LanguageLearning.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LanguageLearning.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<LanguageLearningUser> userManager;
        public AdminController(UserManager<LanguageLearningUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> ListUsers()
        {
            var users = await userManager.Users.ToListAsync();
            return View(users);
        }
    }
}
