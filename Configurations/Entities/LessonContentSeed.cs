using LanguageLearning.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LanguageLearning.Configurations.Entities
{
    public class LessonContentSeed : IEntityTypeConfiguration<LessonContent>
    {
        public void Configure(EntityTypeBuilder<LessonContent> builder)
        {
            builder.HasData(
                new LessonContent
                {
                    Id = 1,
                    ContentType = "Greetings.jpg",
                    ContentText = "Welcome to Lesson 1: Introduction to Language Learning.",
                    LessonId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//englsih
                },
                new LessonContent
                {
                    Id = 2,
                    ContentType = "BodyParts.jpg",
                    ContentText = "In this lesson, we will cover the body parts of human beings.",
                    LessonId = 17,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//english
                },
                new LessonContent
                {
                    Id = 3,
                    ContentType = "Sports.jpg",
                    ContentText = "Welcome to Lesson 2: Many kind of sports.",
                    LessonId = 18,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//english
                },
                new LessonContent
                {
                    Id = 4,
                    ContentType = "Greetings.jpg",
                    ContentText = "Welcome to Lesson 1: Introduction to Language Learning.",
                    LessonId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//spanish
                },
                new LessonContent
                {
                    Id = 5,
                    ContentType = "BodyParts.jpg",
                    ContentText = "In this lesson, we will cover the body parts of human beings.",
                    LessonId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//spanish
                },
                new LessonContent
                {
                    Id = 6,
                    ContentType = "Sports.jpg",
                    ContentText = "Welcome to Lesson 2: Many kind of sports.",
                    LessonId = 12,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//spanish
                },
                new LessonContent
                {
                    Id = 7,
                    ContentType = "Greetings.jpg",
                    ContentText = "Welcome to Lesson 1: Introduction to Language Learning.",
                    LessonId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//french
                },
                new LessonContent
                {
                    Id = 8,
                    ContentType = "BodyParts.jpg",
                    ContentText = "In this lesson, we will cover the body parts of human beings.",
                    LessonId = 14,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//french
                },
                new LessonContent
                {
                    Id = 9,
                    ContentType = "Sports.jpg",
                    ContentText = "Welcome to Lesson 2: Many kind of sports.",
                    LessonId = 15,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//french
                },
                new LessonContent
                {
                    Id = 10,
                    ContentType = "Greetings.jpg",
                    ContentText = "Welcome to Lesson 1: Introduction to Language Learning.",
                    LessonId = 28,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//italian
                },
                new LessonContent
                {
                    Id = 11,
                    ContentType = "BodyParts.jpg",
                    ContentText = "In this lesson, we will cover the body parts of human beings.",
                    LessonId = 29,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//italian
                },
                new LessonContent
                {
                    Id = 12,
                    ContentType = "Sports.jpg",
                    ContentText = "Welcome to Lesson 2: Many kind of sports.",
                    LessonId = 30,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//italian
                },
                new LessonContent
                {
                    Id = 13,
                    ContentType = "Greetings.jpg",
                    ContentText = "Welcome to Lesson 1: Introduction to Language Learning.",
                    LessonId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//german
                },
                new LessonContent
                {
                    Id = 14,
                    ContentType = "BodyParts.jpg",
                    ContentText = "In this lesson, we will cover the body parts of human beings.",
                    LessonId = 8,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//german
                },
                new LessonContent
                {
                    Id = 15,
                    ContentType = "Sports.jpg",
                    ContentText = "Welcome to Lesson 2: Many kind of sports.",
                    LessonId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//german
                },
                new LessonContent
                {
                    Id = 16,
                    ContentType = "Greetings.jpg",
                    ContentText = "Welcome to Lesson 1: Introduction to Language Learning.",
                    LessonId = 31,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//janpanese
                },
                new LessonContent
                {
                    Id = 17,
                    ContentType = "BodyParts.jpg",
                    ContentText = "In this lesson, we will cover the body parts of human beings.",
                    LessonId = 32,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//japanese
                },
                new LessonContent
                {
                    Id = 18,
                    ContentType = "Sports.jpg",
                    ContentText = "Welcome to Lesson 2: Many kind of sports.",
                    LessonId = 33,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"//japanese
                }

            );
        }
    }
}