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
    /// GetTag200Response
    /// </summary>
    [DataContract(Name = "getTag_200_response")]
    public partial class GetTag200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTag200Response" /> class.
        /// </summary>
        /// <param name="tagId">The ID that uniquely identifies a tag (UUID format).</param>
        /// <param name="name">The unique tag name..</param>
        public GetTag200Response(Guid tagId = default(Guid), string name = default(string))
        {
            this.TagId = tagId;
            this.Name = name;
        }

        /// <summary>
        /// The ID that uniquely identifies a tag (UUID format)
        /// </summary>
        /// <value>The ID that uniquely identifies a tag (UUID format)</value>
        /// <example>3fa85f64-5717-4562-b3fc-2c963f66afa6</example>
        [DataMember(Name = "tag_id", EmitDefaultValue = false)]
        public Guid TagId { get; set; }

        /// <summary>
        /// The unique tag name.
        /// </summary>
        /// <value>The unique tag name.</value>
        /// <example>Gold card member</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The total number of contacts who are assigned this tag.
        /// </summary>
        /// <value>The total number of contacts who are assigned this tag.</value>
        /// <example>325</example>
        [DataMember(Name = "contacts_count", EmitDefaultValue = false)]
        public int ContactsCount { get; private set; }

        /// <summary>
        /// Returns false as ContactsCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContactsCount()
        {
            return false;
        }
        /// <summary>
        /// The system generated date and time when the tag was created (ISO-8601 format).
        /// </summary>
        /// <value>The system generated date and time when the tag was created (ISO-8601 format).</value>
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
        /// The system generated date and time when the tag was last updated (ISO-8601 format).
        /// </summary>
        /// <value>The system generated date and time when the tag was last updated (ISO-8601 format).</value>
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
        /// The source used to tag contacts.
        /// </summary>
        /// <value>The source used to tag contacts.</value>
        /// <example>ESTY</example>
        [DataMember(Name = "tag_source", EmitDefaultValue = false)]
        public string TagSource { get; private set; }

        /// <summary>
        /// Returns false as TagSource should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTagSource()
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
            sb.Append("class GetTag200Response {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactsCount: ").Append(ContactsCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  TagSource: ").Append(TagSource).Append("\n");
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
