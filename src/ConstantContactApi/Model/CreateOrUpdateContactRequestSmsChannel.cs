/*
 * Constant Contact API v3
 *
 * Swagger build version 3.0.62
 *
 * The version of the OpenAPI document: 1.0.193
 * Contact: webservices@constantcontact.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ConstantContactApi.Client.OpenAPIDateConverter;

namespace ConstantContactApi.Model
{
    /// <summary>
    /// The contact&#39;s SMS details.
    /// </summary>
    [DataContract(Name = "createOrUpdateContact_request_sms_channel")]
    public partial class CreateOrUpdateContactRequestSmsChannel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateContactRequestSmsChannel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrUpdateContactRequestSmsChannel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateContactRequestSmsChannel" /> class.
        /// </summary>
        /// <param name="smsAddress">The contact&#39;s SMS-capable phone number, excluding the country code. (required).</param>
        /// <param name="dialCode">The dial code the country uses. For example, use &lt;code&gt;1&lt;/code&gt; for the United States dial code. (required).</param>
        /// <param name="countryCode">The two-digit code that identifies the country. (required).</param>
        /// <param name="smsChannelConsents">The consents provided for the SMS Channel. (required).</param>
        public CreateOrUpdateContactRequestSmsChannel(string smsAddress = default(string), string dialCode = default(string), string countryCode = default(string), List<CreateOrUpdateContactRequestSmsChannelSmsChannelConsentsInner> smsChannelConsents = default(List<CreateOrUpdateContactRequestSmsChannelSmsChannelConsentsInner>))
        {
            // to ensure "smsAddress" is required (not null)
            if (smsAddress == null)
            {
                throw new ArgumentNullException("smsAddress is a required property for CreateOrUpdateContactRequestSmsChannel and cannot be null");
            }
            this.SmsAddress = smsAddress;
            // to ensure "dialCode" is required (not null)
            if (dialCode == null)
            {
                throw new ArgumentNullException("dialCode is a required property for CreateOrUpdateContactRequestSmsChannel and cannot be null");
            }
            this.DialCode = dialCode;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for CreateOrUpdateContactRequestSmsChannel and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "smsChannelConsents" is required (not null)
            if (smsChannelConsents == null)
            {
                throw new ArgumentNullException("smsChannelConsents is a required property for CreateOrUpdateContactRequestSmsChannel and cannot be null");
            }
            this.SmsChannelConsents = smsChannelConsents;
        }

        /// <summary>
        /// The contact&#39;s SMS-capable phone number, excluding the country code.
        /// </summary>
        /// <value>The contact&#39;s SMS-capable phone number, excluding the country code.</value>
        /// <example>7815551212</example>
        [DataMember(Name = "sms_address", IsRequired = true, EmitDefaultValue = true)]
        public string SmsAddress { get; set; }

        /// <summary>
        /// The dial code the country uses. For example, use &lt;code&gt;1&lt;/code&gt; for the United States dial code.
        /// </summary>
        /// <value>The dial code the country uses. For example, use &lt;code&gt;1&lt;/code&gt; for the United States dial code.</value>
        /// <example>1</example>
        [DataMember(Name = "dial_code", IsRequired = true, EmitDefaultValue = true)]
        public string DialCode { get; set; }

        /// <summary>
        /// The two-digit code that identifies the country.
        /// </summary>
        /// <value>The two-digit code that identifies the country.</value>
        /// <example>US</example>
        [DataMember(Name = "country_code", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The consents provided for the SMS Channel.
        /// </summary>
        /// <value>The consents provided for the SMS Channel.</value>
        [DataMember(Name = "sms_channel_consents", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateOrUpdateContactRequestSmsChannelSmsChannelConsentsInner> SmsChannelConsents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrUpdateContactRequestSmsChannel {\n");
            sb.Append("  SmsAddress: ").Append(SmsAddress).Append("\n");
            sb.Append("  DialCode: ").Append(DialCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  SmsChannelConsents: ").Append(SmsChannelConsents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
