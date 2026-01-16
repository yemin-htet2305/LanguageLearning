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
// ===================== GREETINGS =====================
new LessonContent { Id = 1, ContentType = "Greetings.jpg", ContentText = "Good Morning", LessonId = 16, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 2, ContentType = "Greetings.jpg", ContentText = "Buenos días", LessonId = 10, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 3, ContentType = "Greetings.jpg", ContentText = "Bonjour", LessonId = 13, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 4, ContentType = "Greetings.jpg", ContentText = "Buongiorno", LessonId = 28, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 5, ContentType = "Greetings.jpg", ContentText = "Guten Morgen", LessonId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 6, ContentType = "Greetings.jpg", ContentText = "おはようございます", LessonId = 31, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

new LessonContent { Id = 7, ContentType = "Greetings_2.jpg", ContentText = "Good Afternoon", LessonId = 16, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 8, ContentType = "Greetings_2.jpg", ContentText = "Buenas tardes", LessonId = 10, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 9, ContentType = "Greetings_2.jpg", ContentText = "Bon après-midi", LessonId = 13, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 10, ContentType = "Greetings_2.jpg", ContentText = "Buon pomeriggio", LessonId = 28, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 11, ContentType = "Greetings_2.jpg", ContentText = "Guten Nachmittag", LessonId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 12, ContentType = "Greetings_2.jpg", ContentText = "こんにちは", LessonId = 31, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

new LessonContent { Id = 13, ContentType = "Greetings_3.jpg", ContentText = "Good Night", LessonId = 16, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 14, ContentType = "Greetings_3.jpg", ContentText = "Buenas noches", LessonId = 10, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 15, ContentType = "Greetings_3.jpg", ContentText = "Bonne nuit", LessonId = 13, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 16, ContentType = "Greetings_3.jpg", ContentText = "Buona notte", LessonId = 28, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 17, ContentType = "Greetings_3.jpg", ContentText = "Gute Nacht", LessonId = 7, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 18, ContentType = "Greetings_3.jpg", ContentText = "おやすみなさい", LessonId = 31, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

// ===================== BODY PARTS =====================
new LessonContent { Id = 19, ContentType = "body.jpg", ContentText = "Head", LessonId = 17, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 20, ContentType = "body.jpg", ContentText = "Cabeza", LessonId = 11, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 21, ContentType = "body.jpg", ContentText = "Tête", LessonId = 14, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 22, ContentType = "body.jpg", ContentText = "Testa", LessonId = 29, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 23, ContentType = "body.jpg", ContentText = "Kopf", LessonId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 24, ContentType = "body.jpg", ContentText = "頭", LessonId = 32, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

new LessonContent { Id = 25, ContentType = "body2.jpg", ContentText = "Hand", LessonId = 17, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 26, ContentType = "body2.jpg", ContentText = "Mano", LessonId = 11, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 27, ContentType = "body2.jpg", ContentText = "Main", LessonId = 14, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 28, ContentType = "body2.jpg", ContentText = "Mano", LessonId = 29, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 29, ContentType = "body2.jpg", ContentText = "Hand", LessonId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 30, ContentType = "body2.jpg", ContentText = "手", LessonId = 32, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

new LessonContent { Id = 31, ContentType = "body3.jpg", ContentText = "Leg", LessonId = 17, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 32, ContentType = "body3.jpg", ContentText = "Pierna", LessonId = 11, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 33, ContentType = "body3.jpg", ContentText = "Jambe", LessonId = 14, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 34, ContentType = "body3.jpg", ContentText = "Gamba", LessonId = 29, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 35, ContentType = "body3.jpg", ContentText = "Bein", LessonId = 8, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 36, ContentType = "body3.jpg", ContentText = "足", LessonId = 32, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

// ===================== SPORTS =====================
new LessonContent { Id = 37, ContentType = "sport.jpg", ContentText = "Football", LessonId = 18, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 38, ContentType = "sport.jpg", ContentText = "Fútbol", LessonId = 12, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 39, ContentType = "sport.jpg", ContentText = "Football", LessonId = 15, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 40, ContentType = "sport.jpg", ContentText = "Calcio", LessonId = 30, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 41, ContentType = "sport.jpg", ContentText = "Fußball", LessonId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 42, ContentType = "sport.jpg", ContentText = "サッカー", LessonId = 33, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

new LessonContent { Id = 43, ContentType = "sport2.jpg", ContentText = "Basketball", LessonId = 18, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 44, ContentType = "sport2.jpg", ContentText = "Baloncesto", LessonId = 12, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 45, ContentType = "sport2.jpg", ContentText = "Basketball", LessonId = 15, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 46, ContentType = "sport2.jpg", ContentText = "Pallacanestro", LessonId = 30, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 47, ContentType = "sport2.jpg", ContentText = "Basketball", LessonId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 48, ContentType = "sport2.jpg", ContentText = "バスケットボール", LessonId = 33, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

new LessonContent { Id = 49, ContentType = "sport3.jpg", ContentText = "Golf", LessonId = 18, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 50, ContentType = "sport3.jpg", ContentText = "Golf", LessonId = 12, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 51, ContentType = "sport3.jpg", ContentText = "Golf", LessonId = 15, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 52, ContentType = "sport3.jpg", ContentText = "Golf", LessonId = 30, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 53, ContentType = "sport3.jpg", ContentText = "Golf", LessonId = 9, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
new LessonContent { Id = 54, ContentType = "sport3.jpg", ContentText = "ゴルフ", LessonId = 33, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" }

            );
        }
    }
}