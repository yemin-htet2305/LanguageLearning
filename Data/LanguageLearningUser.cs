using Microsoft.AspNetCore.Identity;

namespace LanguageLearning.Data
{
  
    public class LanguageLearningUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
