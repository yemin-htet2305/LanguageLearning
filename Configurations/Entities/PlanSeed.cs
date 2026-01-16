using LanguageLearning.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LanguageLearning.Configurations.Entities
{
    public class PlanSeed : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasData(
                new Plan
                {
                    Id = 1,
                    Name = "Free",
                    Price = 0,
                    BillingCycle = "No Need",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Plan
                {
                    Id = 2,
                    Name = "Premium",
                    Price = 225,
                    BillingCycle = "6 Month",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Plan
                {
                    Id = 3,
                    Name = "Premium Pro",
                    Price = 399,
                    BillingCycle = "Annual",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                }
                );
        }
    }
}
