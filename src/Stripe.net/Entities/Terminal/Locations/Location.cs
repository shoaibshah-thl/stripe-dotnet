namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Location : StripeEntity<Location>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}
