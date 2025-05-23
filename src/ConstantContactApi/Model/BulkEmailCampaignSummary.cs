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
    /// BulkEmailCampaignSummary
    /// </summary>
    [DataContract(Name = "BulkEmailCampaignSummary")]
    public partial class BulkEmailCampaignSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkEmailCampaignSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkEmailCampaignSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkEmailCampaignSummary" /> class.
        /// </summary>
        /// <param name="campaignId">The ID that uniquely identifies an email campaign. (required).</param>
        /// <param name="campaignType">Identifies the email campaign type. (required).</param>
        /// <param name="lastSentDate">The date and time that the email campaign was last sent. (required).</param>
        /// <param name="uniqueCounts">uniqueCounts (required).</param>
        public BulkEmailCampaignSummary(string campaignId = default(string), string campaignType = default(string), DateTime lastSentDate = default(DateTime), GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInnerUniqueCounts uniqueCounts = default(GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInnerUniqueCounts))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException("campaignId is a required property for BulkEmailCampaignSummary and cannot be null");
            }
            this.CampaignId = campaignId;
            // to ensure "campaignType" is required (not null)
            if (campaignType == null)
            {
                throw new ArgumentNullException("campaignType is a required property for BulkEmailCampaignSummary and cannot be null");
            }
            this.CampaignType = campaignType;
            this.LastSentDate = lastSentDate;
            // to ensure "uniqueCounts" is required (not null)
            if (uniqueCounts == null)
            {
                throw new ArgumentNullException("uniqueCounts is a required property for BulkEmailCampaignSummary and cannot be null");
            }
            this.UniqueCounts = uniqueCounts;
        }

        /// <summary>
        /// The ID that uniquely identifies an email campaign.
        /// </summary>
        /// <value>The ID that uniquely identifies an email campaign.</value>
        /// <example>82ee2c37-c8f8-4974-9560-ef93ad51d58z</example>
        [DataMember(Name = "campaign_id", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Identifies the email campaign type.
        /// </summary>
        /// <value>Identifies the email campaign type.</value>
        /// <example>Newsletter</example>
        [DataMember(Name = "campaign_type", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignType { get; set; }

        /// <summary>
        /// The date and time that the email campaign was last sent.
        /// </summary>
        /// <value>The date and time that the email campaign was last sent.</value>
        /// <example>2019-04-25T11:08Z</example>
        [DataMember(Name = "last_sent_date", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LastSentDate { get; set; }

        /// <summary>
        /// Gets or Sets UniqueCounts
        /// </summary>
        [DataMember(Name = "unique_counts", IsRequired = true, EmitDefaultValue = true)]
        public GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInnerUniqueCounts UniqueCounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkEmailCampaignSummary {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CampaignType: ").Append(CampaignType).Append("\n");
            sb.Append("  LastSentDate: ").Append(LastSentDate).Append("\n");
            sb.Append("  UniqueCounts: ").Append(UniqueCounts).Append("\n");
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
