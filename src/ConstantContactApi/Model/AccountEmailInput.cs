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
    /// AccountEmailInput
    /// </summary>
    [DataContract(Name = "AccountEmailInput")]
    public partial class AccountEmailInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEmailInput" /> class.
        /// </summary>
        /// <param name="emailAddress">The new email address you want to add to a Constant Contact account..</param>
        public AccountEmailInput(string emailAddress = default(string))
        {
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// The new email address you want to add to a Constant Contact account.
        /// </summary>
        /// <value>The new email address you want to add to a Constant Contact account.</value>
        /// <example>dlang@example.com</example>
        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountEmailInput {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 80.", new [] { "EmailAddress" });
            }

            yield break;
        }
    }

}
