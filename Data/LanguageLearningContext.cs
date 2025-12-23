using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LanguageLearning.Domain;

namespace LanguageLearning.Data
{
    public class LanguageLearningContext : DbContext
    {
        public LanguageLearningContext (DbContextOptions<LanguageLearningContext> options)
            : base(options)
        {
        }

        public DbSet<LanguageLearning.Domain.Language> Language { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Lesson> Lesson { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.LessonContent> LessonContent { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Plan> Plan { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Progress> Progress { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Quession> Quession { get; set; } = default!;
        public DbSet<LanguageLearning.Domain.Quiz> Quiz { get; set; } = default!;
    }
}
