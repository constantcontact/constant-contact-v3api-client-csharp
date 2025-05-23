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
    /// GetEmailCampaignXrefs200Response
    /// </summary>
    [DataContract(Name = "getEmailCampaignXrefs_200_response")]
    public partial class GetEmailCampaignXrefs200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailCampaignXrefs200Response" /> class.
        /// </summary>
        /// <param name="xrefs">An array of objects that contain a &lt;code&gt;v2_email_campaign_id&lt;/code&gt; cross-referenced with a V3 &lt;code&gt;campaign_id&lt;/code&gt; and a V3 &lt;code&gt;campaign_activity_id&lt;/code&gt; value..</param>
        public GetEmailCampaignXrefs200Response(List<GetEmailCampaignXrefs200ResponseXrefsInner> xrefs = default(List<GetEmailCampaignXrefs200ResponseXrefsInner>))
        {
            this.Xrefs = xrefs;
        }

        /// <summary>
        /// An array of objects that contain a &lt;code&gt;v2_email_campaign_id&lt;/code&gt; cross-referenced with a V3 &lt;code&gt;campaign_id&lt;/code&gt; and a V3 &lt;code&gt;campaign_activity_id&lt;/code&gt; value.
        /// </summary>
        /// <value>An array of objects that contain a &lt;code&gt;v2_email_campaign_id&lt;/code&gt; cross-referenced with a V3 &lt;code&gt;campaign_id&lt;/code&gt; and a V3 &lt;code&gt;campaign_activity_id&lt;/code&gt; value.</value>
        [DataMember(Name = "xrefs", EmitDefaultValue = false)]
        public List<GetEmailCampaignXrefs200ResponseXrefsInner> Xrefs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEmailCampaignXrefs200Response {\n");
            sb.Append("  Xrefs: ").Append(Xrefs).Append("\n");
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
