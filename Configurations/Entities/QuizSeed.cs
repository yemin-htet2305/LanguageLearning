using LanguageLearning.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LanguageLearning.Configurations.Entities
{
    public class QuizSeed : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasData(
                new Quiz
                {
                    Id = 1,
                    Title = "Basic English/ Greetings Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 2,
                    Title = "Basic English/ Body Parts Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 17,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 3,
                    Title = "Basic English/ Sports Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 18,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 4,
                    Title = "Basic Spanish/ Greetings Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 5,
                    Title = "Basic Spanish/ Body Parts Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 6,
                    Title = "Basic Spanish/ Sports Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 12,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 7,
                    Title = "Basic French/ Greetings Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 8,
                    Title = "Basic French/ Body Parts Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 14,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 9,
                    Title = "Basic French/ Sports Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 15,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 10,
                    Title = "Basic Italian/ Greetings Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 28,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 11,
                    Title = "Basic Italian/ Body Parts Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 29,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 12,
                    Title = "Basic Italian/ Sports Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 30,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 13,
                    Title = "Basic German/ Greetings Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 14,
                    Title = "Basic German/ Body Parts Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 15,
                    Title = "Basic German/ Sports Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 16,
                    Title = "Basic Japanese/ Greetings Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 31,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 17,
                    Title = "Basic Japanese/ Body Parts Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 32,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quiz
                {
                    Id = 18,
                    Title = "Basic Japanese/ Sports Vocabulary Quiz",
                    IsCompleted = false,
                    LessonId = 33,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}