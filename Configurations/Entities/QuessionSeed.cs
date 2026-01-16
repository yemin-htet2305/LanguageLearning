using LanguageLearning.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LanguageLearning.Configurations.Entities
{
    public class QuessionSeed : IEntityTypeConfiguration<Quession>
    {
        public void Configure(EntityTypeBuilder<Quession> builder)
        {
            builder.HasData(
                new Quession
                {
                    Id = 1,
                    Text = "What is the capital of England?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Landon",
                    OptD = "Rome",
                    CorrrectAnswer = "C",
                    QuizId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 2,
                    Text = "What is the capital of England?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Landon",
                    OptD = "Rome",
                    CorrrectAnswer = "C",
                    QuizId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 3,
                    Text = "What is the capital of England?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Landon",
                    OptD = "Rome",
                    CorrrectAnswer = "C",
                    QuizId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 4,
                    Text = "What is the capital of Spain?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "B",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 5,
                    Text = "What is the capital of Spain?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "B",
                    QuizId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 6,
                    Text = "What is the capital of Spain?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "B",
                    QuizId = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 7,
                    Text = "What is the capital of France?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "C",
                    QuizId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 8,
                    Text = "What is the capital of France?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "C",
                    QuizId = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 9,
                    Text = "What is the capital of France?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "C",
                    QuizId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 10,
                    Text = "What is the capital of Italy?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "D",
                    QuizId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 11,
                    Text = "What is the capital of Italy?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "D",
                    QuizId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 12,
                    Text = "What is the capital of Italy?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "D",
                    QuizId = 12,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 13,
                    Text = "What is the capital of Germany?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "A",
                    QuizId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 14,
                    Text = "What is the capital of Germany?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "A",
                    QuizId = 14,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 15,
                    Text = "What is the capital of Germany?",
                    OptA = "Berlin",
                    OptB = "Madrid",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "A",
                    QuizId = 15,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 16,
                    Text = "What is the capital of Japan?",
                    OptA = "Berlin",
                    OptB = "Tokyo",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "B",
                    QuizId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 17,
                    Text = "What is the capital of Japan?",
                    OptA = "Berlin",
                    OptB = "Tokyo",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "B",
                    QuizId = 17,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Quession
                {
                    Id = 18,
                    Text = "What is the capital of Japan?",
                    OptA = "Berlin",
                    OptB = "Tokyo",
                    OptC = "Paris",
                    OptD = "Rome",
                    CorrrectAnswer = "B",
                    QuizId = 18,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}