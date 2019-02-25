namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeError : StripeEntity<StripeError>
    {
        /*
         * For regular API errors:
         */

        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("decline_code")]
        public string DeclineCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("param")]
        public string Parameter { get; set; }

        [JsonProperty("type")]
        public string ErrorType { get; set; }

        /*
         * For OAuth Errors:
         */

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
