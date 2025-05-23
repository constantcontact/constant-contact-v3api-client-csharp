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
    /// The physical address for the organization that is sending the email campaign. Constant Contact displays this information to contacts in the email message footer. If you do not include a physical address in the email campaign activity, Constant Contact will use the physical address information saved for the Constant Contact user account.
    /// </summary>
    [DataContract(Name = "createEmailCampaign_request_email_campaign_activities_inner_physical_address_in_footer")]
    public partial class CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter" /> class.
        /// </summary>
        /// <param name="addressLine1">Line 1 of the organization&#39;s street address. (required).</param>
        /// <param name="addressLine2">Line 2 of the organization&#39;s street address..</param>
        /// <param name="addressLine3">Line 3 of the organization&#39;s street address..</param>
        /// <param name="addressOptional">An optional address field for the organization. Only &lt;code&gt;format_type&lt;/code&gt; 3, 4, and 5 can use this property..</param>
        /// <param name="city">The city where the organization sending the email campaign is located..</param>
        /// <param name="countryCode">The uppercase two letter &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-1&#39; target&#x3D;&#39;_blank&#39;&gt;ISO 3166-1 code&lt;/a&gt; for the organization&#39;s country. (required).</param>
        /// <param name="organizationName">The name of the organization that is sending the email campaign. (required).</param>
        /// <param name="postalCode">The postal code address (ZIP code) of the organization..</param>
        /// <param name="stateCode">The uppercase two letter &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-1&#39; target&#x3D;&#39;_blank&#39;&gt;ISO 3166-1 code&lt;/a&gt; for the organization&#39;s state. This property is required if the &lt;code&gt;country_code&lt;/code&gt; is US (United States)..</param>
        /// <param name="stateNonUsName">The full state name for a &lt;code&gt;state_code&lt;/code&gt; that is outside the United States. This property is not read only..</param>
        public CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter(string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressOptional = default(string), string city = default(string), string countryCode = default(string), string organizationName = default(string), string postalCode = default(string), string stateCode = default(string), string stateNonUsName = default(string))
        {
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new ArgumentNullException("addressLine1 is a required property for CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter and cannot be null");
            }
            this.AddressLine1 = addressLine1;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "organizationName" is required (not null)
            if (organizationName == null)
            {
                throw new ArgumentNullException("organizationName is a required property for CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter and cannot be null");
            }
            this.OrganizationName = organizationName;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressOptional = addressOptional;
            this.City = city;
            this.PostalCode = postalCode;
            this.StateCode = stateCode;
            this.StateNonUsName = stateNonUsName;
        }

        /// <summary>
        /// Line 1 of the organization&#39;s street address.
        /// </summary>
        /// <value>Line 1 of the organization&#39;s street address.</value>
        /// <example>123 Maple Street</example>
        [DataMember(Name = "address_line1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Line 2 of the organization&#39;s street address.
        /// </summary>
        /// <value>Line 2 of the organization&#39;s street address.</value>
        /// <example>Unit 1</example>
        [DataMember(Name = "address_line2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Line 3 of the organization&#39;s street address.
        /// </summary>
        /// <value>Line 3 of the organization&#39;s street address.</value>
        [DataMember(Name = "address_line3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// An optional address field for the organization. Only &lt;code&gt;format_type&lt;/code&gt; 3, 4, and 5 can use this property.
        /// </summary>
        /// <value>An optional address field for the organization. Only &lt;code&gt;format_type&lt;/code&gt; 3, 4, and 5 can use this property.</value>
        /// <example>Near Boston Fire Station</example>
        [DataMember(Name = "address_optional", EmitDefaultValue = false)]
        public string AddressOptional { get; set; }

        /// <summary>
        /// The city where the organization sending the email campaign is located.
        /// </summary>
        /// <value>The city where the organization sending the email campaign is located.</value>
        /// <example>Boston</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The uppercase two letter &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-1&#39; target&#x3D;&#39;_blank&#39;&gt;ISO 3166-1 code&lt;/a&gt; for the organization&#39;s country.
        /// </summary>
        /// <value>The uppercase two letter &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-1&#39; target&#x3D;&#39;_blank&#39;&gt;ISO 3166-1 code&lt;/a&gt; for the organization&#39;s country.</value>
        /// <example>US</example>
        [DataMember(Name = "country_code", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The full name of the country where the organization sending the email is located. Automatically generated using the &lt;code&gt;country_code&lt;/code&gt;.
        /// </summary>
        /// <value>The full name of the country where the organization sending the email is located. Automatically generated using the &lt;code&gt;country_code&lt;/code&gt;.</value>
        /// <example>United States</example>
        [DataMember(Name = "country_name", EmitDefaultValue = false)]
        public string CountryName { get; private set; }

        /// <summary>
        /// Returns false as CountryName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCountryName()
        {
            return false;
        }
        /// <summary>
        /// The name of the organization that is sending the email campaign.
        /// </summary>
        /// <value>The name of the organization that is sending the email campaign.</value>
        /// <example>Jake Dodge&#39;s Pancakes</example>
        [DataMember(Name = "organization_name", IsRequired = true, EmitDefaultValue = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// The postal code address (ZIP code) of the organization.
        /// </summary>
        /// <value>The postal code address (ZIP code) of the organization.</value>
        /// <example>02451</example>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The uppercase two letter &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-1&#39; target&#x3D;&#39;_blank&#39;&gt;ISO 3166-1 code&lt;/a&gt; for the organization&#39;s state. This property is required if the &lt;code&gt;country_code&lt;/code&gt; is US (United States).
        /// </summary>
        /// <value>The uppercase two letter &lt;a href&#x3D;&#39;https://en.wikipedia.org/wiki/ISO_3166-1&#39; target&#x3D;&#39;_blank&#39;&gt;ISO 3166-1 code&lt;/a&gt; for the organization&#39;s state. This property is required if the &lt;code&gt;country_code&lt;/code&gt; is US (United States).</value>
        /// <example>MA</example>
        [DataMember(Name = "state_code", EmitDefaultValue = false)]
        public string StateCode { get; set; }

        /// <summary>
        /// The full state name for a &lt;code&gt;state_code&lt;/code&gt; that is inside the United States. Automatically generated using the &lt;code&gt;state_code&lt;/code&gt;.
        /// </summary>
        /// <value>The full state name for a &lt;code&gt;state_code&lt;/code&gt; that is inside the United States. Automatically generated using the &lt;code&gt;state_code&lt;/code&gt;.</value>
        [DataMember(Name = "state_name", EmitDefaultValue = false)]
        public string StateName { get; private set; }

        /// <summary>
        /// Returns false as StateName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStateName()
        {
            return false;
        }
        /// <summary>
        /// The full state name for a &lt;code&gt;state_code&lt;/code&gt; that is outside the United States. This property is not read only.
        /// </summary>
        /// <value>The full state name for a &lt;code&gt;state_code&lt;/code&gt; that is outside the United States. This property is not read only.</value>
        /// <example>Victoria</example>
        [DataMember(Name = "state_non_us_name", EmitDefaultValue = false)]
        public string StateNonUsName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressOptional: ").Append(AddressOptional).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  StateNonUsName: ").Append(StateNonUsName).Append("\n");
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
