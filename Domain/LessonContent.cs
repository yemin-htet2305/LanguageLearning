namespace LanguageLearning.Domain
{
    public class LessonContent: BaseDomainModel
    {
        public string? ContentType {  get; set; }
        public int PositionOrder {  get; set; }
        
        //ForeignKey
        public int LessonId { get; set; }

    }
}
