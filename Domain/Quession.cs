namespace LanguageLearning.Domain
{
    public class Quession:BaseDomainModel
    {
        public string? Text {  get; set; }
        public string? OptA { get; set; }
        public string? OptB { get; set; }
        public string? OptC { get; set; }
        public string? OptD { get; set; }
        public string? CorrrectAnswer { get; set; }

        //ForeignKey
        public int QuizId {  get; set; }
    }
}
