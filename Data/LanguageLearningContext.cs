using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LanguageLearning.Data;
using LanguageLearning.Configurations.Entities;

namespace LanguageLearning.Data
{
    public class LanguageLearningContext(DbContextOptions<LanguageLearningContext> options) : IdentityDbContext<LanguageLearningUser>(options)
    {

        public DbSet<LanguageLearning.Domain.Language> Language { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Lesson> Lesson { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.LessonContent> LessonContent { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Plan> Plan { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Progress> Progress { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Quession> Quession { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Quiz> Quiz { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new LanguageSeed());
            builder.ApplyConfiguration(new LessonSeed());
            builder.ApplyConfiguration(new LessonContentSeed());
            builder.ApplyConfiguration(new QuizSeed());
            builder.ApplyConfiguration(new QuessionSeed());
            builder.ApplyConfiguration(new PlanSeed());

        }
    }
}
