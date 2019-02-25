namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplicationFeeRefund : StripeEntity<ApplicationFeeRefund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Balance Transaction
        [JsonIgnore]
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            get
            {
                return this.BalanceTransaction ?? (object)this.BalanceTransactionId;
            }

            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Fee
        [JsonIgnore]
        public string FeeId { get; set; }

        [JsonIgnore]
        public ApplicationFee Fee { get; set; }

        [JsonProperty("fee")]
        internal object InternalFee
        {
            get
            {
                return this.Fee ?? (object)this.FeeId;
            }

            set
            {
                StringOrObject<ApplicationFee>.Map(value, s => this.FeeId = s, o => this.Fee = o);
            }
        }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
