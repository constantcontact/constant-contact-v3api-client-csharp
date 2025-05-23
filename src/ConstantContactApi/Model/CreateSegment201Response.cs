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
    /// CreateSegment201Response
    /// </summary>
    [DataContract(Name = "createSegment_201_response")]
    public partial class CreateSegment201Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegment201Response" /> class.
        /// </summary>
        /// <param name="name">The segment&#39;s unique descriptive name..</param>
        /// <param name="segmentCriteria">The segment&#39;s contact selection criteria formatted as single-string escaped JSON..</param>
        public CreateSegment201Response(string name = default(string), string segmentCriteria = default(string))
        {
            this.Name = name;
            this.SegmentCriteria = segmentCriteria;
        }

        /// <summary>
        /// The segment&#39;s unique descriptive name.
        /// </summary>
        /// <value>The segment&#39;s unique descriptive name.</value>
        /// <example>Re-engage contacts who did not open the last 5 email campaign activities.</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The segment&#39;s contact selection criteria formatted as single-string escaped JSON.
        /// </summary>
        /// <value>The segment&#39;s contact selection criteria formatted as single-string escaped JSON.</value>
        /// <example>{&quot;version&quot;:&quot;1.0.0&quot;,&quot;criteria&quot;:{&quot;type&quot;:&quot;and&quot;,&quot;group&quot;:[{&quot;source&quot;:&quot;tracking&quot;,&quot;field&quot;:&quot;not_opened&quot;,&quot;op&quot;:&quot;contains-any&quot;,&quot;const_value&quot;:&quot;last-n-campaigns&quot;,&quot;param&quot;:&quot;5&quot;}]}}</example>
        [DataMember(Name = "segment_criteria", EmitDefaultValue = false)]
        public string SegmentCriteria { get; set; }

        /// <summary>
        /// The system generated number that uniquely identifies the segment.
        /// </summary>
        /// <value>The system generated number that uniquely identifies the segment.</value>
        /// <example>14</example>
        [DataMember(Name = "segment_id", EmitDefaultValue = false)]
        public int SegmentId { get; private set; }

        /// <summary>
        /// Returns false as SegmentId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSegmentId()
        {
            return false;
        }
        /// <summary>
        /// The system generated date and time (ISO-8601) that the segment was created.
        /// </summary>
        /// <value>The system generated date and time (ISO-8601) that the segment was created.</value>
        /// <example>2019-04-25T11:08Z</example>
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
        /// The system generated date and time (ISO-8601) that the segment&#39;s &lt;code&gt;name&lt;/code&gt; or &lt;code&gt; segment_criteria&lt;/code&gt; was last updated.
        /// </summary>
        /// <value>The system generated date and time (ISO-8601) that the segment&#39;s &lt;code&gt;name&lt;/code&gt; or &lt;code&gt; segment_criteria&lt;/code&gt; was last updated.</value>
        /// <example>2019-04-25T11:08Z</example>
        [DataMember(Name = "edited_at", EmitDefaultValue = false)]
        public DateTime EditedAt { get; private set; }

        /// <summary>
        /// Returns false as EditedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEditedAt()
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
            sb.Append("class CreateSegment201Response {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SegmentCriteria: ").Append(SegmentCriteria).Append("\n");
            sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EditedAt: ").Append(EditedAt).Append("\n");
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
            // SegmentCriteria (string) maxLength
            if (this.SegmentCriteria != null && this.SegmentCriteria.Length > 20000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SegmentCriteria, length must be less than 20000.", new [] { "SegmentCriteria" });
            }

            yield break;
        }
    }

}
