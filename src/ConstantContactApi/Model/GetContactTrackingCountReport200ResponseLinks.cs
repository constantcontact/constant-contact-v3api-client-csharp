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
    /// The next link if more summaries of activities are available.
    /// </summary>
    [DataContract(Name = "getContactTrackingCountReport_200_response__links")]
    public partial class GetContactTrackingCountReport200ResponseLinks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactTrackingCountReport200ResponseLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetContactTrackingCountReport200ResponseLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactTrackingCountReport200ResponseLinks" /> class.
        /// </summary>
        /// <param name="next">next (required).</param>
        public GetContactTrackingCountReport200ResponseLinks(GetContactTrackingReport200ResponseLinksNext next = default(GetContactTrackingReport200ResponseLinksNext))
        {
            // to ensure "next" is required (not null)
            if (next == null)
            {
                throw new ArgumentNullException("next is a required property for GetContactTrackingCountReport200ResponseLinks and cannot be null");
            }
            this.Next = next;
        }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", IsRequired = true, EmitDefaultValue = true)]
        public GetContactTrackingReport200ResponseLinksNext Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetContactTrackingCountReport200ResponseLinks {\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
