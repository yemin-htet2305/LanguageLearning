namespace LanguageLearning.Domain
{
    public class Quiz: BaseDomainModel
    {
        public string? Title {  get; set; }
        public bool IsCompleted {  get; set; }

        //ForeignKey
        public int LessonId {  get; set; }

    }
}
