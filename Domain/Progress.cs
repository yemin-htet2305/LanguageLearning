namespace LanguageLearning.Domain
{
    public class Progress: BaseDomainModel
    {
        public float ProgressPer {  get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletedDate {  get; set; }

        //ForeignKey
        public int LessonId {  get; set; }
        public string? UserId {  get; set; }
    }
}
