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
    /// Provides SMS consent details.
    /// </summary>
    [DataContract(Name = "getContactById_200_response_sms_channel_sms_channel_consents_inner")]
    public partial class GetContactById200ResponseSmsChannelSmsChannelConsentsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactById200ResponseSmsChannelSmsChannelConsentsInner" /> class.
        /// </summary>
        /// <param name="smsConsentPermission">Identifies the current permission status for the SMS channel..</param>
        /// <param name="consentType">consentType.</param>
        /// <param name="advertisedFrequency">The numeric used to set how often to send SMS advertisements during a specified time interval (&lt;code&gt;advertised_interval&lt;/code&gt;). For example, if the &lt;code&gt;advertised_frequency&lt;/code&gt; is set to &lt;code&gt;2&lt;/code&gt; and the  &lt;code&gt;advertised_interval&lt;/code&gt; is set to &lt;code&gt;monthly&lt;/code&gt;, the contact can receive up to two advertisements per month..</param>
        /// <param name="advertisedInterval">Identifies the unit of time used by Constant Contact to send SMS advertisements as a string enum. For example, if the &lt;code&gt;advertised_frequency&lt;/code&gt; is set to &lt;code&gt;2&lt;/code&gt; and the &lt;code&gt;advertised_interval&lt;/code&gt; is set to &lt;code&gt;monthly&lt;/code&gt;, the contact can receive up to two advertisements per month..</param>
        public GetContactById200ResponseSmsChannelSmsChannelConsentsInner(string smsConsentPermission = default(string), string consentType = default(string), string advertisedFrequency = default(string), string advertisedInterval = default(string))
        {
            this.SmsConsentPermission = smsConsentPermission;
            this.ConsentType = consentType;
            this.AdvertisedFrequency = advertisedFrequency;
            this.AdvertisedInterval = advertisedInterval;
        }

        /// <summary>
        /// Identifies the current permission status for the SMS channel.
        /// </summary>
        /// <value>Identifies the current permission status for the SMS channel.</value>
        /// <example>explicit</example>
        [DataMember(Name = "sms_consent_permission", EmitDefaultValue = false)]
        public string SmsConsentPermission { get; set; }

        /// <summary>
        /// Gets or Sets ConsentType
        /// </summary>
        /// <example>promotional_sms</example>
        [DataMember(Name = "consent_type", EmitDefaultValue = false)]
        public string ConsentType { get; set; }

        /// <summary>
        /// Date and time, in ISO-8601 format, that the contact subscribed/opted-in to receiving SMS from the account. Displays only if the contact subscribes/opts-in. System generated.
        /// </summary>
        /// <value>Date and time, in ISO-8601 format, that the contact subscribed/opted-in to receiving SMS from the account. Displays only if the contact subscribes/opts-in. System generated.</value>
        /// <example>2016-01-23T13:48:44.108Z</example>
        [DataMember(Name = "opt_in_date", EmitDefaultValue = false)]
        public DateTime OptInDate { get; private set; }

        /// <summary>
        /// Returns false as OptInDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOptInDate()
        {
            return false;
        }
        /// <summary>
        /// Date and time, in ISO-8601 format, that the contact unsubscribed/opted-out of receiving SMS from the account. Displays only if the contact unsubscribed/opted-out. System generated.
        /// </summary>
        /// <value>Date and time, in ISO-8601 format, that the contact unsubscribed/opted-out of receiving SMS from the account. Displays only if the contact unsubscribed/opted-out. System generated.</value>
        /// <example>2016-01-23T13:48:44.108Z</example>
        [DataMember(Name = "opt_out_date", EmitDefaultValue = false)]
        public DateTime OptOutDate { get; private set; }

        /// <summary>
        /// Returns false as OptOutDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOptOutDate()
        {
            return false;
        }
        /// <summary>
        /// The numeric used to set how often to send SMS advertisements during a specified time interval (&lt;code&gt;advertised_interval&lt;/code&gt;). For example, if the &lt;code&gt;advertised_frequency&lt;/code&gt; is set to &lt;code&gt;2&lt;/code&gt; and the  &lt;code&gt;advertised_interval&lt;/code&gt; is set to &lt;code&gt;monthly&lt;/code&gt;, the contact can receive up to two advertisements per month.
        /// </summary>
        /// <value>The numeric used to set how often to send SMS advertisements during a specified time interval (&lt;code&gt;advertised_interval&lt;/code&gt;). For example, if the &lt;code&gt;advertised_frequency&lt;/code&gt; is set to &lt;code&gt;2&lt;/code&gt; and the  &lt;code&gt;advertised_interval&lt;/code&gt; is set to &lt;code&gt;monthly&lt;/code&gt;, the contact can receive up to two advertisements per month.</value>
        /// <example>1</example>
        [DataMember(Name = "advertised_frequency", EmitDefaultValue = false)]
        public string AdvertisedFrequency { get; set; }

        /// <summary>
        /// Identifies the unit of time used by Constant Contact to send SMS advertisements as a string enum. For example, if the &lt;code&gt;advertised_frequency&lt;/code&gt; is set to &lt;code&gt;2&lt;/code&gt; and the &lt;code&gt;advertised_interval&lt;/code&gt; is set to &lt;code&gt;monthly&lt;/code&gt;, the contact can receive up to two advertisements per month.
        /// </summary>
        /// <value>Identifies the unit of time used by Constant Contact to send SMS advertisements as a string enum. For example, if the &lt;code&gt;advertised_frequency&lt;/code&gt; is set to &lt;code&gt;2&lt;/code&gt; and the &lt;code&gt;advertised_interval&lt;/code&gt; is set to &lt;code&gt;monthly&lt;/code&gt;, the contact can receive up to two advertisements per month.</value>
        /// <example>monthly</example>
        [DataMember(Name = "advertised_interval", EmitDefaultValue = false)]
        public string AdvertisedInterval { get; set; }

        /// <summary>
        /// Date and time that the SMS stats were created, in ISO-8601 format. System generated.
        /// </summary>
        /// <value>Date and time that the SMS stats were created, in ISO-8601 format. System generated.</value>
        /// <example>2016-01-23T13:48:44.108Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Date and time that the SMS stats were updated, in ISO-8601 format. System generated.
        /// </summary>
        /// <value>Date and time that the SMS stats were updated, in ISO-8601 format. System generated.</value>
        /// <example>2016-01-23T13:48:44.108Z</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetContactById200ResponseSmsChannelSmsChannelConsentsInner {\n");
            sb.Append("  SmsConsentPermission: ").Append(SmsConsentPermission).Append("\n");
            sb.Append("  ConsentType: ").Append(ConsentType).Append("\n");
            sb.Append("  OptInDate: ").Append(OptInDate).Append("\n");
            sb.Append("  OptOutDate: ").Append(OptOutDate).Append("\n");
            sb.Append("  AdvertisedFrequency: ").Append(AdvertisedFrequency).Append("\n");
            sb.Append("  AdvertisedInterval: ").Append(AdvertisedInterval).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
