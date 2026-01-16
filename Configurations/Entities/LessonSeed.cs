using LanguageLearning.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LanguageLearning.Configurations.Entities
{
    public class LessonSeed : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasData(
                new Lesson
                {
                    Id = 1,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//brazilian
                },
                new Lesson
                {
                    Id = 2,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 3,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 4,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//mandarin
                },
                new Lesson
                {
                    Id = 5,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 6,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 7,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//German
                },
                new Lesson
                {
                    Id = 8,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 9,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 10,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//Spanish
                },
                new Lesson
                {
                    Id = 11,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 12,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 13,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//French
                },
                new Lesson
                {
                    Id = 14,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 15,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 16,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//english
                },
                new Lesson
                {
                    Id = 17,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 18,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 19,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//greece
                },
                new Lesson
                {
                    Id = 20,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 21,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 22,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 8 ,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//Indonesian
                },
                new Lesson
                {
                    Id = 23,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 24,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 25,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//indian
                },
                new Lesson
                {
                    Id = 26,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 27,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 28,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//italian
                },
                new Lesson
                {
                    Id = 29,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 30,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 31,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//japanese
                },
                new Lesson
                {
                    Id = 32,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 33,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 34,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 12,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//korean
                },
                new Lesson
                {
                    Id = 35,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 12,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 36,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 12,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 37,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//mongolian
                },
                new Lesson
                {
                    Id = 38,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 39,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 40,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 14,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//portuguese
                },
                new Lesson
                {
                    Id = 41,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 14,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 42,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 14,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 43,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 15,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//russian
                },
                new Lesson
                {
                    Id = 44,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 15,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 45,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 15,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 46,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//vietnamese
                },
                new Lesson
                {
                    Id = 47,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 48,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 49,
                    Title = "Basic Greetings",
                    Description = "Learn how to greet people in different situations.",
                    DifficultyLvl = 1,
                    LanguageId = 17,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//myanmar
                },
                new Lesson
                {
                    Id = 50,
                    Title = "Body Parts",
                    Description = "Familiarize body parts.",
                    DifficultyLvl = 1,
                    LanguageId = 17,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Lesson
                {
                    Id = 51,
                    Title = "Sports",
                    Description = "Familiarize many sports.",
                    DifficultyLvl = 2,
                    LanguageId = 17,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}