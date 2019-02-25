namespace StripeTests
{
    using System.Collections.Generic;
    using Stripe;
    using Stripe.Infrastructure.Extensions;
    using Xunit;

    public class PlanCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeTiersProperly()
        {
            var options = new PlanCreateOptions
            {
                Tiers = new List<PlanTierOptions>
                {
                    new PlanTierOptions
                    {
                        UnitAmount = 1000,
                        UpTo = new PlanTierOptions.UpToBound
                        {
                            Bound = 10
                        }
                    },
                    new PlanTierOptions
                    {
                        UnitAmount = 2000,
                        UpTo = new PlanTierOptions.UpToInf()
                    }
                },
            };

            Assert.Equal(
                "tiers[0][unit_amount]=1000&tiers[0][up_to]=10&" +
                "tiers[1][unit_amount]=2000&tiers[1][up_to]=inf",
                options.ToQueryString());
        }
    }
}
