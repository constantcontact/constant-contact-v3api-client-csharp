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
    /// CreateTagDeleteActivityRequest
    /// </summary>
    [DataContract(Name = "createTagDeleteActivity_request")]
    public partial class CreateTagDeleteActivityRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTagDeleteActivityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTagDeleteActivityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTagDeleteActivityRequest" /> class.
        /// </summary>
        /// <param name="tagIds">The tag IDs (&lt;code&gt;tag_ids&lt;/code&gt;) to delete. (required).</param>
        public CreateTagDeleteActivityRequest(List<Guid> tagIds = default(List<Guid>))
        {
            // to ensure "tagIds" is required (not null)
            if (tagIds == null)
            {
                throw new ArgumentNullException("tagIds is a required property for CreateTagDeleteActivityRequest and cannot be null");
            }
            this.TagIds = tagIds;
        }

        /// <summary>
        /// The tag IDs (&lt;code&gt;tag_ids&lt;/code&gt;) to delete.
        /// </summary>
        /// <value>The tag IDs (&lt;code&gt;tag_ids&lt;/code&gt;) to delete.</value>
        [DataMember(Name = "tag_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> TagIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTagDeleteActivityRequest {\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
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
