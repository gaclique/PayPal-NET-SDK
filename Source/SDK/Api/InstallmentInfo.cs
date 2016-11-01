//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    ///  A resource representing installment information available for a transaction
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class InstallmentInfo : PayPalSerializableObject
    {
        /// <summary>
        /// Installment id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installment_id")]
        public string installment_id { get; set; }

        /// <summary>
        /// Credit card network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "network")]
        public string network { get; set; }

        /// <summary>
        /// Credit card issuer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuer")]
        public string issuer { get; set; }

        /// <summary>
        /// List of available installment options and the cost associated with each one.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installment_options")]
        public List<InstallmentOption> installment_options { get; set; }
    }
}
