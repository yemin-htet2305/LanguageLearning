namespace LanguageLearning.Domain
{
    public class Payment: BaseDomainModel
    {
        public float Amount {  get; set; }
        public string? Method { get; set; }
        public string? Status { get; set; }
    }
}
