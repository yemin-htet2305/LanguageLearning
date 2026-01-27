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
                new Quession { Id = 1, Text = "How to say Good Morning in English", OptA = "Buenos días", OptB = "おはようございます", OptC = "Good Morning", OptD = "Guten Morgen", CorrrectAnswer = "C", QuizId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 2, Text = "How to say football?", OptA = "fútbol", OptB = "サッカー", OptC = "Fußball", OptD = "football", CorrrectAnswer = "D", QuizId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 3, Text = "Head in English", OptA = "cabeza", OptB = "tête", OptC = "頭", OptD = "Head", CorrrectAnswer = "D", QuizId = 1, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 4, Text = "How to say Good Morning in English", OptA = "Buenos días", OptB = "おはようございます", OptC = "Good Morning", OptD = "Guten Morgen", CorrrectAnswer = "C", QuizId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 5, Text = "How to say football?", OptA = "fútbol", OptB = "サッカー", OptC = "Fußball", OptD = "football", CorrrectAnswer = "D", QuizId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 6, Text = "Head in English", OptA = "cabeza", OptB = "tête", OptC = "頭", OptD = "Head", CorrrectAnswer = "D", QuizId = 2, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 7, Text = "How to say Good Morning in English", OptA = "Buenos días", OptB = "おはようございます", OptC = "Good Morning", OptD = "Guten Morgen", CorrrectAnswer = "C", QuizId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 8, Text = "How to say football?", OptA = "fútbol", OptB = "サッカー", OptC = "Fußball", OptD = "football", CorrrectAnswer = "D", QuizId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession { Id = 9, Text = "Head in English", OptA = "cabeza", OptB = "tête", OptC = "頭", OptD = "Head", CorrrectAnswer = "D", QuizId = 3, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Quession
                 {
                     Id = 10,
                     Text = "How to say Good Morning in Spanish",
                     OptA = "Bonjour",
                     OptB = "おはようございます",
                     OptC = "Buenos días",
                     OptD = "Guten Morgen",
                     CorrrectAnswer = "C",
                     QuizId = 4,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
               new Quession
                {
                    Id = 11,
                    Text = "Head in Spanish",
                    OptA = "tête",
                    OptB = "頭",
                    OptC = "Kopf",
                    OptD = "cabeza",
                    CorrrectAnswer = "D",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
                {
                    Id = 12,
                    Text = "How to say football in Spanish",
                    OptA = "football",
                    OptB = "サッカー",
                    OptC = "Fußball",
                    OptD = "fútbol",
                    CorrrectAnswer = "D",
                    QuizId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
               {
                   Id = 13,
                   Text = "How to say Good Morning in Spanish",
                   OptA = "Bonjour",
                   OptB = "おはようございます",
                   OptC = "Buenos días",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "C",
                   QuizId = 5,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 14,
                   Text = "Head in Spanish",
                   OptA = "tête",
                   OptB = "頭",
                   OptC = "Kopf",
                   OptD = "cabeza",
                   CorrrectAnswer = "D",
                   QuizId = 5,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 15,
                   Text = "How to say football in Spanish",
                   OptA = "football",
                   OptB = "サッカー",
                   OptC = "Fußball",
                   OptD = "fútbol",
                   CorrrectAnswer = "D",
                   QuizId = 5,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 16,
                   Text = "How to say Good Morning in Spanish",
                   OptA = "Bonjour",
                   OptB = "おはようございます",
                   OptC = "Buenos días",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "C",
                   QuizId = 6,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 17,
                   Text = "Head in Spanish",
                   OptA = "tête",
                   OptB = "頭",
                   OptC = "Kopf",
                   OptD = "cabeza",
                   CorrrectAnswer = "D",
                   QuizId = 6,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 18,
                   Text = "How to say football in Spanish",
                   OptA = "football",
                   OptB = "サッカー",
                   OptC = "Fußball",
                   OptD = "fútbol",
                   CorrrectAnswer = "D",
                   QuizId = 6,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 19,
                   Text = "How to say Good Morning in French",
                   OptA = "Buenos días",
                   OptB = "Bonjour",
                   OptC = "おはようございます",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "B",
                   QuizId = 7,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
                {
                    Id = 20,
                    Text = "Head in French",
                    OptA = "cabeza",
                    OptB = "Kopf",
                    OptC = "tête",
                    OptD = "頭",
                    CorrrectAnswer = "C",
                    QuizId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
                {
                    Id = 21,
                    Text = "How to say football in French",
                    OptA = "football",
                    OptB = "サッカー",
                    OptC = "fútbol",
                    OptD = "Fußball",
                    CorrrectAnswer = "A",
                    QuizId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
               {
                   Id = 22,
                   Text = "How to say Good Morning in French",
                   OptA = "Buenos días",
                   OptB = "Bonjour",
                   OptC = "おはようございます",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "B",
                   QuizId = 8,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 23,
                   Text = "Head in French",
                   OptA = "cabeza",
                   OptB = "Kopf",
                   OptC = "tête",
                   OptD = "頭",
                   CorrrectAnswer = "C",
                   QuizId = 8,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 24,
                   Text = "How to say football in French",
                   OptA = "football",
                   OptB = "サッカー",
                   OptC = "fútbol",
                   OptD = "Fußball",
                   CorrrectAnswer = "A",
                   QuizId = 8,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 25,
                   Text = "How to say Good Morning in French",
                   OptA = "Buenos días",
                   OptB = "Bonjour",
                   OptC = "おはようございます",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "B",
                   QuizId = 9,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 26,
                   Text = "Head in French",
                   OptA = "cabeza",
                   OptB = "Kopf",
                   OptC = "tête",
                   OptD = "頭",
                   CorrrectAnswer = "C",
                   QuizId = 9,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 27,
                   Text = "How to say football in French",
                   OptA = "football",
                   OptB = "サッカー",
                   OptC = "fútbol",
                   OptD = "Fußball",
                   CorrrectAnswer = "A",
                   QuizId = 9,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 28,
                   Text = "How to say Good Morning in Italian",
                   OptA = "Buongiorno",
                   OptB = "Bonjour",
                   OptC = "Buenos días",
                   OptD = "おはようございます",
                   CorrrectAnswer = "A",
                   QuizId = 10,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
                {
                    Id = 29,
                    Text = "Head in Italian",
                    OptA = "tête",
                    OptB = "testa",
                    OptC = "頭",
                    OptD = "Kopf",
                    CorrrectAnswer = "B",
                    QuizId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
                {
                    Id = 30,
                    Text = "How to say football in Italian",
                    OptA = "Fußball",
                    OptB = "football",
                    OptC = "calcio",
                    OptD = "サッカー",
                    CorrrectAnswer = "C",
                    QuizId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
               {
                   Id = 31,
                   Text = "How to say Good Morning in Italian",
                   OptA = "Buongiorno",
                   OptB = "Bonjour",
                   OptC = "Buenos días",
                   OptD = "おはようございます",
                   CorrrectAnswer = "A",
                   QuizId = 11,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 32,
                   Text = "Head in Italian",
                   OptA = "tête",
                   OptB = "testa",
                   OptC = "頭",
                   OptD = "Kopf",
                   CorrrectAnswer = "B",
                   QuizId = 11,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 33,
                   Text = "How to say football in Italian",
                   OptA = "Fußball",
                   OptB = "football",
                   OptC = "calcio",
                   OptD = "サッカー",
                   CorrrectAnswer = "C",
                   QuizId = 11,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 34,
                   Text = "How to say Good Morning in Italian",
                   OptA = "Buongiorno",
                   OptB = "Bonjour",
                   OptC = "Buenos días",
                   OptD = "おはようございます",
                   CorrrectAnswer = "A",
                   QuizId = 12,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 35,
                   Text = "Head in Italian",
                   OptA = "tête",
                   OptB = "testa",
                   OptC = "頭",
                   OptD = "Kopf",
                   CorrrectAnswer = "B",
                   QuizId = 12,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 36,
                   Text = "How to say football in Italian",
                   OptA = "Fußball",
                   OptB = "football",
                   OptC = "calcio",
                   OptD = "サッカー",
                   CorrrectAnswer = "C",
                   QuizId = 12,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 37,
                   Text = "How to say Good Morning in German",
                   OptA = "Bonjour",
                   OptB = "Guten Morgen",
                   OptC = "Buenos días",
                   OptD = "おはようございます",
                   CorrrectAnswer = "B",
                   QuizId = 13,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
                {
                    Id = 38,
                    Text = "Head in German",
                    OptA = "cabeza",
                    OptB = "頭",
                    OptC = "Kopf",
                    OptD = "tête",
                    CorrrectAnswer = "C",
                    QuizId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
                {
                    Id = 39,
                    Text = "How to say football in German",
                    OptA = "football",
                    OptB = "サッカー",
                    OptC = "fútbol",
                    OptD = "Fußball",
                    CorrrectAnswer = "D",
                    QuizId = 13,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
               {
                   Id = 40,
                   Text = "How to say Good Morning in German",
                   OptA = "Bonjour",
                   OptB = "Guten Morgen",
                   OptC = "Buenos días",
                   OptD = "おはようございます",
                   CorrrectAnswer = "B",
                   QuizId = 14,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 41,
                   Text = "Head in German",
                   OptA = "cabeza",
                   OptB = "頭",
                   OptC = "Kopf",
                   OptD = "tête",
                   CorrrectAnswer = "C",
                   QuizId = 14,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 42,
                   Text = "How to say football in German",
                   OptA = "football",
                   OptB = "サッカー",
                   OptC = "fútbol",
                   OptD = "Fußball",
                   CorrrectAnswer = "D",
                   QuizId = 14,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 43,
                   Text = "How to say Good Morning in German",
                   OptA = "Bonjour",
                   OptB = "Guten Morgen",
                   OptC = "Buenos días",
                   OptD = "おはようございます",
                   CorrrectAnswer = "B",
                   QuizId = 15,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 44,
                   Text = "Head in German",
                   OptA = "cabeza",
                   OptB = "頭",
                   OptC = "Kopf",
                   OptD = "tête",
                   CorrrectAnswer = "C",
                   QuizId = 15,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 45,
                   Text = "How to say football in German",
                   OptA = "football",
                   OptB = "サッカー",
                   OptC = "fútbol",
                   OptD = "Fußball",
                   CorrrectAnswer = "D",
                   QuizId = 15,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 46,
                   Text = "How to say Good Morning in Japanese",
                   OptA = "Bonjour",
                   OptB = "Buenos días",
                   OptC = "おはようございます",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "C",
                   QuizId = 16,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
                {
                    Id = 47,
                    Text = "Head in Japanese",
                    OptA = "tête",
                    OptB = "Kopf",
                    OptC = "cabeza",
                    OptD = "頭",
                    CorrrectAnswer = "D",
                    QuizId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
                {
                    Id = 48,
                    Text = "How to say football in Japanese",
                    OptA = "football",
                    OptB = "Fußball",
                    OptC = "サッカー",
                    OptD = "fútbol",
                    CorrrectAnswer = "C",
                    QuizId = 16,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
               {
                   Id = 49,
                   Text = "How to say Good Morning in Japanese",
                   OptA = "Bonjour",
                   OptB = "Buenos días",
                   OptC = "おはようございます",
                   OptD = "Guten Morgen",
                   CorrrectAnswer = "C",
                   QuizId = 17,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 50,
                   Text = "Head in Japanese",
                   OptA = "tête",
                   OptB = "Kopf",
                   OptC = "cabeza",
                   OptD = "頭",
                   CorrrectAnswer = "D",
                   QuizId = 17,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 51,
                   Text = "How to say football in Japanese",
                   OptA = "football",
                   OptB = "Fußball",
                   OptC = "サッカー",
                   OptD = "fútbol",
                   CorrrectAnswer = "C",
                   QuizId = 17,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
                new Quession
                {
                    Id = 52,
                    Text = "How to say Good Morning in Japanese",
                    OptA = "Bonjour",
                    OptB = "Buenos días",
                    OptC = "おはようございます",
                    OptD = "Guten Morgen",
                    CorrrectAnswer = "C",
                    QuizId = 18,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
               new Quession
               {
                   Id = 53,
                   Text = "Head in Japanese",
                   OptA = "tête",
                   OptB = "Kopf",
                   OptC = "cabeza",
                   OptD = "頭",
                   CorrrectAnswer = "D",
                   QuizId = 18,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Quession
               {
                   Id = 54,
                   Text = "How to say football in Japanese",
                   OptA = "football",
                   OptB = "Fußball",
                   OptC = "サッカー",
                   OptD = "fútbol",
                   CorrrectAnswer = "C",
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