namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsPayoutsSchedule : StripeEntity<AccountSettingsPayoutsSchedule>
    {
        /// <summary>
        /// The number of days charges for the account will be held before being paid out.
        /// </summary>
        [JsonProperty("delay_days")]
        public long DelayDays { get; set; }

        /// <summary>
        /// How frequently funds will be paid out. One of <code>manual</code> (payouts only created
        /// via API call), <code>daily</code>, <code>weekly</code>, or <code>monthly</code>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The day of the month funds will be paid out. Only shown if interval is
        /// <code>monthly</code>. Payouts scheduled between the 29th and 31st of the month are sent
        /// on the last day of shorter months.
        /// </summary>
        [JsonProperty("monthly_anchor")]
        public long MonthlyAnchor { get; set; }

        /// <summary>
        /// The day of the week funds will be paid out, of the style ‘monday’, ‘tuesday’, etc.
        /// Only shown if interval is <code>weekly</code>.
        /// </summary>
        [JsonProperty("weekly_anchor")]
        public string WeeklyAnchor { get; set; }
    }
}
