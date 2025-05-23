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
    /// ContactsCounts
    /// </summary>
    [DataContract(Name = "ContactsCounts")]
    public partial class ContactsCounts : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsCounts" /> class.
        /// </summary>
        /// <param name="total">Total number of contacts for the account..</param>
        /// <param name="varExplicit">Total number of contacts explicitly confirmed. Consent is obtained when you explicitly ask your potential contacts for permission to send the email (for example, using a sign-up form) and they agree. After you obtain express consent, it is good forever or until the contact opts out..</param>
        /// <param name="varImplicit">Total number of contacts implicitly confirmed. Consent is inferred based on actions, such as having an existing business relationship (making a purchase or donation, for example). In order to maintain implied consent to comply with CASL a contact must take a business action with you at least once every two years. Under CAN-Spam there is no need to maintain implied consent, it is assumed until the receiver indicates they no longer wish to receive messages..</param>
        /// <param name="pending">Total number of contacts pending confirmation. Consent is requested and pending confirmation from the contact..</param>
        /// <param name="unsubscribed">Total number of unsubscribed contacts. Consent is revoked when a contact has unsubscribed..</param>
        /// <param name="newSubscriber">Total number of newly subscribed contacts..</param>
        public ContactsCounts(int total = default(int), int varExplicit = default(int), int varImplicit = default(int), int pending = default(int), int unsubscribed = default(int), int newSubscriber = default(int))
        {
            this.Total = total;
            this.VarExplicit = varExplicit;
            this.VarImplicit = varImplicit;
            this.Pending = pending;
            this.Unsubscribed = unsubscribed;
            this.NewSubscriber = newSubscriber;
        }

        /// <summary>
        /// Total number of contacts for the account.
        /// </summary>
        /// <value>Total number of contacts for the account.</value>
        /// <example>72</example>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Total number of contacts explicitly confirmed. Consent is obtained when you explicitly ask your potential contacts for permission to send the email (for example, using a sign-up form) and they agree. After you obtain express consent, it is good forever or until the contact opts out.
        /// </summary>
        /// <value>Total number of contacts explicitly confirmed. Consent is obtained when you explicitly ask your potential contacts for permission to send the email (for example, using a sign-up form) and they agree. After you obtain express consent, it is good forever or until the contact opts out.</value>
        /// <example>10</example>
        [DataMember(Name = "explicit", EmitDefaultValue = false)]
        public int VarExplicit { get; set; }

        /// <summary>
        /// Total number of contacts implicitly confirmed. Consent is inferred based on actions, such as having an existing business relationship (making a purchase or donation, for example). In order to maintain implied consent to comply with CASL a contact must take a business action with you at least once every two years. Under CAN-Spam there is no need to maintain implied consent, it is assumed until the receiver indicates they no longer wish to receive messages.
        /// </summary>
        /// <value>Total number of contacts implicitly confirmed. Consent is inferred based on actions, such as having an existing business relationship (making a purchase or donation, for example). In order to maintain implied consent to comply with CASL a contact must take a business action with you at least once every two years. Under CAN-Spam there is no need to maintain implied consent, it is assumed until the receiver indicates they no longer wish to receive messages.</value>
        /// <example>20</example>
        [DataMember(Name = "implicit", EmitDefaultValue = false)]
        public int VarImplicit { get; set; }

        /// <summary>
        /// Total number of contacts pending confirmation. Consent is requested and pending confirmation from the contact.
        /// </summary>
        /// <value>Total number of contacts pending confirmation. Consent is requested and pending confirmation from the contact.</value>
        /// <example>30</example>
        [DataMember(Name = "pending", EmitDefaultValue = false)]
        public int Pending { get; set; }

        /// <summary>
        /// Total number of unsubscribed contacts. Consent is revoked when a contact has unsubscribed.
        /// </summary>
        /// <value>Total number of unsubscribed contacts. Consent is revoked when a contact has unsubscribed.</value>
        /// <example>12</example>
        [DataMember(Name = "unsubscribed", EmitDefaultValue = false)]
        public int Unsubscribed { get; set; }

        /// <summary>
        /// Total number of newly subscribed contacts.
        /// </summary>
        /// <value>Total number of newly subscribed contacts.</value>
        /// <example>1</example>
        [DataMember(Name = "new_subscriber", EmitDefaultValue = false)]
        public int NewSubscriber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactsCounts {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  VarExplicit: ").Append(VarExplicit).Append("\n");
            sb.Append("  VarImplicit: ").Append(VarImplicit).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Unsubscribed: ").Append(Unsubscribed).Append("\n");
            sb.Append("  NewSubscriber: ").Append(NewSubscriber).Append("\n");
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
