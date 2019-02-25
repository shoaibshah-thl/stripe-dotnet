namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCard : StripeEntity
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("checks")]
        public PaymentMethodCardCardChecks Checks { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("three_d_secure_usage")]
        public PaymentMethodCardThreeDSecureUsage ThreeDSecureUsage { get; set; }

        [JsonProperty("wallet")]
        public PaymentMethodCardWallet Wallet { get; set; }
    }
}
