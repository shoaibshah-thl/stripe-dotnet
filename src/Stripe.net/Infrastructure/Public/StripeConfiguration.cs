namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Global configuration class for Stripe.net settings.
    /// </summary>
    public static class StripeConfiguration
    {
        private static string apiKey;

        static StripeConfiguration()
        {
            StripeNetVersion = new AssemblyName(typeof(Requestor).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        /// <summary>API version used by Stripe.net.</summary>
        public static string ApiVersion => "2019-02-19";

        /// <summary>Default base URL for Stripe's API.</summary>
        public static string DefaultApiBase => "https://api.stripe.com";

        /// <summary>Default base URL for Stripe's OAuth API.</summary>
        public static string DefaultConnectBase => "https://connect.stripe.com";

        /// <summary>Default base URL for Stripe's Files API.</summary>
        public static string DefaultFilesBase => "https://files.stripe.com";

        /// <summary>Default timespan before the request times out.</summary>
        public static TimeSpan DefaultHttpTimeout => new TimeSpan(80 * TimeSpan.TicksPerSecond);

        /// <summary>Gets or sets the base URL for Stripe's API.</summary>
        public static string ApiBase { get; set; } = DefaultApiBase;

#if NET45 || NETSTANDARD2_0
        /// <summary>Gets or sets the API key.</summary>
        /// <remarks>
        /// You can also set the API key using the <c>StripeApiKey</c> key in
        /// <see cref="System.Configuration.ConfigurationManager.AppSettings"/>.
        /// </remarks>
#else
        /// <summary>Gets or sets the API key.</summary>
#endif
        public static string ApiKey
        {
            get
            {
#if NET45 || NETSTANDARD2_0
                if (string.IsNullOrEmpty(apiKey))
                {
                    apiKey = System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"];
                }
#endif
                return apiKey;
            }

            set
            {
                apiKey = value;
            }
        }

        /// <summary>Gets or sets the base URL for Stripe's OAuth API.</summary>
        public static string ConnectBase { get; set; } = DefaultConnectBase;

        /// <summary>Gets or sets the base URL for Stripe's Files API.</summary>
        public static string FilesBase { get; set; } = DefaultFilesBase;

        /// <summary>Gets or sets a custom <see cref="HttpMessageHandler"/>.</summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; }

        /// <summary>Gets or sets the timespan to wait before the request times out.</summary>
        public static TimeSpan HttpTimeout { get; set; } = DefaultHttpTimeout;

        /// <summary>
        /// Gets or sets the settings used for deserializing JSON objects returned by Stripe's API.
        /// It is highly recommended you do not change these settings, as doing so can produce
        /// unexpected results. If you do change these settings, make sure that
        /// <see cref="Stripe.Infrastructure.StripeObjectConverter"/> is among the converters,
        /// otherwise Stripe.net will no longer be able to deserialize polymorphic resources
        /// represented by interfaces (e.g. <see cref="IPaymentSource"/>).
        /// </summary>
        public static JsonSerializerSettings SerializerSettings { get; set; } = DefaultSerializerSettings();

        /// <summary>Gets the version of the Stripe.net client library.</summary>
        public static string StripeNetVersion { get; }

        /// <summary>
        /// Gets or sets the timespan to wait before the request times out.
        /// This property is deprecated and will be removed in a future version, please use the
        /// <see cref="HttpTimeout"/> property instead.
        /// </summary>
        // TODO: remove this property in a future major version
        [Obsolete("Use StripeConfiguration.HttpTimeout instead.")]
        public static TimeSpan? HttpTimeSpan
        {
            get { return HttpTimeout; }
            set { HttpTimeout = value ?? DefaultHttpTimeout; }
        }

        /// <summary>
        /// Returns a new instance of <see cref="Newtonsoft.Json.JsonSerializerSettings"/> with
        /// the default settings used by Stripe.net.
        /// </summary>
        /// <returns>A <see cref="Newtonsoft.Json.JsonSerializerSettings"/> instance.</returns>
        public static JsonSerializerSettings DefaultSerializerSettings()
        {
            return new JsonSerializerSettings
            {
                Converters = new List<JsonConverter>
                {
                    new StripeObjectConverter(),
                },
                DateParseHandling = DateParseHandling.None,
            };
        }

        // TODO: remove everything below this in a future major version

        /// <summary>
        /// Sets the base URL.for Stripe's API.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ApiBase"/> property setter instead.
        /// </summary>
        /// <param name="baseUrl">Base URL.for Stripe's API.</param>
        [Obsolete("Use StripeConfiguration.ApiBase getter instead.")]
        public static void SetApiBase(string baseUrl)
        {
            ApiBase = baseUrl;
        }

        /// <summary>
        /// Sets the API key.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ApiKey"/> property setter instead.
        /// </summary>
        /// <param name="newApiKey">API key.</param>
        [Obsolete("Use StripeConfiguration.ApiKey setter instead.")]
        public static void SetApiKey(string newApiKey)
        {
            ApiKey = newApiKey;
        }

        /// <summary>
        /// Sets the base URL.for Stripe's OAuth API.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ConnectBase"/> property setter instead.
        /// </summary>
        /// <param name="baseUrl">Base URL.for Stripe's OAuth API.</param>
        [Obsolete("Use StripeConfiguration.ConnectBase setter instead.")]
        public static void SetConnectBase(string baseUrl)
        {
            ConnectBase = baseUrl;
        }

        /// <summary>
        /// Sets the base URL.for Stripe's Files API.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="FilesBase"/> property setter instead.
        /// </summary>
        /// <param name="baseUrl">Base URL.for Stripe's Files API.</param>
        [Obsolete("Use StripeConfiguration.FilesBase setter instead.")]
        public static void SetFilesBase(string baseUrl)
        {
            FilesBase = baseUrl;
        }
    }
}
