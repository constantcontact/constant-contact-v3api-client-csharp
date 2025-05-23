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
    /// CreateCSVImportActivity201ResponseStatus
    /// </summary>
    [DataContract(Name = "createCSVImportActivity_201_response_status")]
    public partial class CreateCSVImportActivity201ResponseStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCSVImportActivity201ResponseStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public CreateCSVImportActivity201ResponseStatus()
        {
        }

        /// <summary>
        /// The total number of rows, including the header row, in the import file.
        /// </summary>
        /// <value>The total number of rows, including the header row, in the import file.</value>
        /// <example>87</example>
        [DataMember(Name = "items_total_count", EmitDefaultValue = false)]
        public int ItemsTotalCount { get; private set; }

        /// <summary>
        /// Returns false as ItemsTotalCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeItemsTotalCount()
        {
            return false;
        }
        /// <summary>
        /// The total number of contacts in the import file.
        /// </summary>
        /// <value>The total number of contacts in the import file.</value>
        /// <example>20</example>
        [DataMember(Name = "person_count", EmitDefaultValue = false)]
        public int PersonCount { get; private set; }

        /// <summary>
        /// Returns false as PersonCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePersonCount()
        {
            return false;
        }
        /// <summary>
        /// The number of non-correctable errors encountered during the file import.
        /// </summary>
        /// <value>The number of non-correctable errors encountered during the file import.</value>
        /// <example>1</example>
        [DataMember(Name = "error_count", EmitDefaultValue = false)]
        public int ErrorCount { get; private set; }

        /// <summary>
        /// Returns false as ErrorCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeErrorCount()
        {
            return false;
        }
        /// <summary>
        /// The number of correctable errors. Correctable errors are: invalid email address format, birthday or anniversary format error, or does not have minimal contact information (no name or email address). Correctable errors are available in the product UI to correct.
        /// </summary>
        /// <value>The number of correctable errors. Correctable errors are: invalid email address format, birthday or anniversary format error, or does not have minimal contact information (no name or email address). Correctable errors are available in the product UI to correct.</value>
        /// <example>1</example>
        [DataMember(Name = "correctable_count", EmitDefaultValue = false)]
        public int CorrectableCount { get; private set; }

        /// <summary>
        /// Returns false as CorrectableCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCorrectableCount()
        {
            return false;
        }
        /// <summary>
        /// The number of previously unsubscribed contacts in the import - they cannot be added to a list.
        /// </summary>
        /// <value>The number of previously unsubscribed contacts in the import - they cannot be added to a list.</value>
        /// <example>1</example>
        [DataMember(Name = "cannot_add_to_list_count", EmitDefaultValue = false)]
        public int CannotAddToListCount { get; private set; }

        /// <summary>
        /// Returns false as CannotAddToListCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCannotAddToListCount()
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
            sb.Append("class CreateCSVImportActivity201ResponseStatus {\n");
            sb.Append("  ItemsTotalCount: ").Append(ItemsTotalCount).Append("\n");
            sb.Append("  PersonCount: ").Append(PersonCount).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  CorrectableCount: ").Append(CorrectableCount).Append("\n");
            sb.Append("  CannotAddToListCount: ").Append(CannotAddToListCount).Append("\n");
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
