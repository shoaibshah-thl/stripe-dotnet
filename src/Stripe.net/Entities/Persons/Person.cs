namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Person : StripeEntity<Person>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account the person is associated with.
        /// </summary>
        [JsonProperty("account")]
        public string AccountId { get; set; }

        /// <summary>
        /// The person’s address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The Kana variation of the person’s address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapan AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person’s address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapan AddressKanji { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The person’s date of birth.
        /// </summary>
        [JsonProperty("dob")]
        public Dob Dob { get; set; }

        /// <summary>
        /// The person’s email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The person’s first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Kana variation of the person’s first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person’s first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// The person’s gender (International regulations require either “male” or “female”).
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Whether the person’s id_number was provided.
        /// </summary>
        [JsonProperty("id_number_provider")]
        public bool IdNumberProvided { get; set; }

        /// <summary>
        /// The person’s last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The Kana variation of the person’s last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the person’s last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        /// <summary>
        /// The person’s maiden name.
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The person’s phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Describes the person’s relationship to the account.
        /// </summary>
        [JsonProperty("relationship")]
        public PersonRelationship Relationship { get; set; }

        /// <summary>
        /// Information about the requirements for this person, including what information needs to
        /// be collected, and by when.
        /// </summary>
        [JsonProperty("requirements")]
        public PersonRequirements Requirements { get; set; }

        /// <summary>
        /// Whether the last 4 digits of this person’s SSN have been provided.
        /// </summary>
        [JsonProperty("ssn_last_4_provided")]
        public bool SsnLast4Provided { get; set; }

        /// <summary>
        /// The persons’s verification status.
        /// </summary>
        [JsonProperty("verification")]
        public PersonVerification Verification { get; set; }
    }
}
