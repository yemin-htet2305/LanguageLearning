namespace LanguageLearning.Domain
{
    public class Plan: BaseDomainModel
    {
        public string? Name {  get; set; }
        public float Price { get; set; }
        public string? BillingCycle { get; set; }
    }
}
