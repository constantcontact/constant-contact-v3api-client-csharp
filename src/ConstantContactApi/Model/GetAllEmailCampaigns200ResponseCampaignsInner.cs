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
    /// GetAllEmailCampaigns200ResponseCampaignsInner
    /// </summary>
    [DataContract(Name = "getAllEmailCampaigns_200_response_campaigns_inner")]
    public partial class GetAllEmailCampaigns200ResponseCampaignsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllEmailCampaigns200ResponseCampaignsInner" /> class.
        /// </summary>
        /// <param name="campaignId">The unique ID used to identify the email campaign (UUID format)..</param>
        /// <param name="currentStatus">The current status of the email campaign. Valid values are: &lt;ul&gt;   &lt;li&gt;Draft — An email campaign that you have created but have not sent to contacts.&lt;/li&gt;   &lt;li&gt;Scheduled — An email campaign that you have scheduled for Constant Contact to send to contacts.&lt;/li&gt;   &lt;li&gt;Executing — An email campaign that Constant Contact is currently sending to contacts. Email campaign activities are only in this status briefly.&lt;/li&gt;   &lt;li&gt;Done — An email campaign that you successfully sent to contacts.&lt;/li&gt;   &lt;li&gt;Error — An email campaign activity that encountered an error.&lt;/li&gt;   &lt;li&gt;Removed — An email campaign that a user deleted. Users can view and restore deleted emails through the UI.&lt;/li&gt; &lt;/ul&gt; .</param>
        /// <param name="name">The descriptive name the user provides to identify this campaign. Campaign names must be unique for each account ID..</param>
        /// <param name="type">Identifies the type of campaign that you select when creating the campaign. Newsletter and Custom Code email campaigns are the primary types..</param>
        /// <param name="typeCode">The code used to identify the email campaign &#x60;type&#x60;. &lt;ul&gt;   &lt;li&gt; 1  (Default) &lt;/li&gt;   &lt;li&gt; 2  (Bulk Email) &lt;/li&gt;   &lt;li&gt; 10 (Newsletter) &lt;/li&gt;   &lt;li&gt; 11 (Announcement) &lt;/li&gt;   &lt;li&gt; 12 (Product/Service News) &lt;/li&gt;   &lt;li&gt; 14 (Business Letter) &lt;/li&gt;   &lt;li&gt; 15 (Card) &lt;/li&gt;   &lt;li&gt; 16 (Press release)&lt;/li&gt;   &lt;li&gt; 17 (Flyer) &lt;/li&gt;   &lt;li&gt; 18 (Feedback Request) &lt;/li&gt;   &lt;li&gt; 19 (Ratings and Reviews) &lt;/li&gt;   &lt;li&gt; 20 (Event Announcement) &lt;/li&gt;   &lt;li&gt; 21 (Simple Coupon) &lt;/li&gt;   &lt;li&gt; 22 (Sale Promotion) &lt;/li&gt;   &lt;li&gt; 23 (Product Promotion) &lt;/li&gt;   &lt;li&gt; 24 (Membership Drive) &lt;/li&gt;   &lt;li&gt; 25 (Fundraiser) &lt;/li&gt;   &lt;li&gt; 26 (Custom Code Email)&lt;/li&gt;   &lt;li&gt; 57 (A/B Test)&lt;/li&gt; &lt;/ul&gt; .</param>
        public GetAllEmailCampaigns200ResponseCampaignsInner(string campaignId = default(string), string currentStatus = default(string), string name = default(string), string type = default(string), int typeCode = default(int))
        {
            this.CampaignId = campaignId;
            this.CurrentStatus = currentStatus;
            this.Name = name;
            this.Type = type;
            this.TypeCode = typeCode;
        }

        /// <summary>
        /// The unique ID used to identify the email campaign (UUID format).
        /// </summary>
        /// <value>The unique ID used to identify the email campaign (UUID format).</value>
        /// <example>8987dc1a-48ef-433a-b836-7ca4f9aa3481</example>
        [DataMember(Name = "campaign_id", EmitDefaultValue = false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// The system generated date and time that this email campaign was created. This string is readonly and is in ISO-8601 format.
        /// </summary>
        /// <value>The system generated date and time that this email campaign was created. This string is readonly and is in ISO-8601 format.</value>
        /// <example>2018-02-06T22:09:15Z</example>
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
        /// The current status of the email campaign. Valid values are: &lt;ul&gt;   &lt;li&gt;Draft — An email campaign that you have created but have not sent to contacts.&lt;/li&gt;   &lt;li&gt;Scheduled — An email campaign that you have scheduled for Constant Contact to send to contacts.&lt;/li&gt;   &lt;li&gt;Executing — An email campaign that Constant Contact is currently sending to contacts. Email campaign activities are only in this status briefly.&lt;/li&gt;   &lt;li&gt;Done — An email campaign that you successfully sent to contacts.&lt;/li&gt;   &lt;li&gt;Error — An email campaign activity that encountered an error.&lt;/li&gt;   &lt;li&gt;Removed — An email campaign that a user deleted. Users can view and restore deleted emails through the UI.&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        /// <value>The current status of the email campaign. Valid values are: &lt;ul&gt;   &lt;li&gt;Draft — An email campaign that you have created but have not sent to contacts.&lt;/li&gt;   &lt;li&gt;Scheduled — An email campaign that you have scheduled for Constant Contact to send to contacts.&lt;/li&gt;   &lt;li&gt;Executing — An email campaign that Constant Contact is currently sending to contacts. Email campaign activities are only in this status briefly.&lt;/li&gt;   &lt;li&gt;Done — An email campaign that you successfully sent to contacts.&lt;/li&gt;   &lt;li&gt;Error — An email campaign activity that encountered an error.&lt;/li&gt;   &lt;li&gt;Removed — An email campaign that a user deleted. Users can view and restore deleted emails through the UI.&lt;/li&gt; &lt;/ul&gt; </value>
        /// <example>Draft</example>
        [DataMember(Name = "current_status", EmitDefaultValue = false)]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// The descriptive name the user provides to identify this campaign. Campaign names must be unique for each account ID.
        /// </summary>
        /// <value>The descriptive name the user provides to identify this campaign. Campaign names must be unique for each account ID.</value>
        /// <example>December Newsletter for Dog Lovers</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Identifies the type of campaign that you select when creating the campaign. Newsletter and Custom Code email campaigns are the primary types.
        /// </summary>
        /// <value>Identifies the type of campaign that you select when creating the campaign. Newsletter and Custom Code email campaigns are the primary types.</value>
        /// <example>NEWSLETTER</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The code used to identify the email campaign &#x60;type&#x60;. &lt;ul&gt;   &lt;li&gt; 1  (Default) &lt;/li&gt;   &lt;li&gt; 2  (Bulk Email) &lt;/li&gt;   &lt;li&gt; 10 (Newsletter) &lt;/li&gt;   &lt;li&gt; 11 (Announcement) &lt;/li&gt;   &lt;li&gt; 12 (Product/Service News) &lt;/li&gt;   &lt;li&gt; 14 (Business Letter) &lt;/li&gt;   &lt;li&gt; 15 (Card) &lt;/li&gt;   &lt;li&gt; 16 (Press release)&lt;/li&gt;   &lt;li&gt; 17 (Flyer) &lt;/li&gt;   &lt;li&gt; 18 (Feedback Request) &lt;/li&gt;   &lt;li&gt; 19 (Ratings and Reviews) &lt;/li&gt;   &lt;li&gt; 20 (Event Announcement) &lt;/li&gt;   &lt;li&gt; 21 (Simple Coupon) &lt;/li&gt;   &lt;li&gt; 22 (Sale Promotion) &lt;/li&gt;   &lt;li&gt; 23 (Product Promotion) &lt;/li&gt;   &lt;li&gt; 24 (Membership Drive) &lt;/li&gt;   &lt;li&gt; 25 (Fundraiser) &lt;/li&gt;   &lt;li&gt; 26 (Custom Code Email)&lt;/li&gt;   &lt;li&gt; 57 (A/B Test)&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        /// <value>The code used to identify the email campaign &#x60;type&#x60;. &lt;ul&gt;   &lt;li&gt; 1  (Default) &lt;/li&gt;   &lt;li&gt; 2  (Bulk Email) &lt;/li&gt;   &lt;li&gt; 10 (Newsletter) &lt;/li&gt;   &lt;li&gt; 11 (Announcement) &lt;/li&gt;   &lt;li&gt; 12 (Product/Service News) &lt;/li&gt;   &lt;li&gt; 14 (Business Letter) &lt;/li&gt;   &lt;li&gt; 15 (Card) &lt;/li&gt;   &lt;li&gt; 16 (Press release)&lt;/li&gt;   &lt;li&gt; 17 (Flyer) &lt;/li&gt;   &lt;li&gt; 18 (Feedback Request) &lt;/li&gt;   &lt;li&gt; 19 (Ratings and Reviews) &lt;/li&gt;   &lt;li&gt; 20 (Event Announcement) &lt;/li&gt;   &lt;li&gt; 21 (Simple Coupon) &lt;/li&gt;   &lt;li&gt; 22 (Sale Promotion) &lt;/li&gt;   &lt;li&gt; 23 (Product Promotion) &lt;/li&gt;   &lt;li&gt; 24 (Membership Drive) &lt;/li&gt;   &lt;li&gt; 25 (Fundraiser) &lt;/li&gt;   &lt;li&gt; 26 (Custom Code Email)&lt;/li&gt;   &lt;li&gt; 57 (A/B Test)&lt;/li&gt; &lt;/ul&gt; </value>
        /// <example>10</example>
        [DataMember(Name = "type_code", EmitDefaultValue = false)]
        public int TypeCode { get; set; }

        /// <summary>
        /// The system generated date and time showing when the campaign was last updated. This string is read only and is in ISO-8601 format.
        /// </summary>
        /// <value>The system generated date and time showing when the campaign was last updated. This string is read only and is in ISO-8601 format.</value>
        /// <example>2018-06-27T10:28:09Z</example>
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
            sb.Append("class GetAllEmailCampaigns200ResponseCampaignsInner {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrentStatus: ").Append(CurrentStatus).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 80.", new [] { "Name" });
            }

            yield break;
        }
    }

}
