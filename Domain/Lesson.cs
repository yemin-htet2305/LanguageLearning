namespace LanguageLearning.Domain
{
    public class Lesson: BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int DifficultyLvl { get; set; }

        // Foreign Key
        public int LanguageId { get; set; }

    }
}
