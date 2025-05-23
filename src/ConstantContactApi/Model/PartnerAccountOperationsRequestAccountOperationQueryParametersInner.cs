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
    /// PartnerAccountOperationsRequestAccountOperationQueryParametersInner
    /// </summary>
    [DataContract(Name = "PartnerAccountOperationsRequest_account_operation_query_parameters_inner")]
    public partial class PartnerAccountOperationsRequestAccountOperationQueryParametersInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerAccountOperationsRequestAccountOperationQueryParametersInner" /> class.
        /// </summary>
        /// <param name="queryParamKey">The name of the query parameter..</param>
        /// <param name="queryParamValue">The value of the query parameter..</param>
        public PartnerAccountOperationsRequestAccountOperationQueryParametersInner(string queryParamKey = default(string), string queryParamValue = default(string))
        {
            this.QueryParamKey = queryParamKey;
            this.QueryParamValue = queryParamValue;
        }

        /// <summary>
        /// The name of the query parameter.
        /// </summary>
        /// <value>The name of the query parameter.</value>
        /// <example>include</example>
        [DataMember(Name = "query_param_key", EmitDefaultValue = false)]
        public string QueryParamKey { get; set; }

        /// <summary>
        /// The value of the query parameter.
        /// </summary>
        /// <value>The value of the query parameter.</value>
        /// <example>list_memberships</example>
        [DataMember(Name = "query_param_value", EmitDefaultValue = false)]
        public string QueryParamValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartnerAccountOperationsRequestAccountOperationQueryParametersInner {\n");
            sb.Append("  QueryParamKey: ").Append(QueryParamKey).Append("\n");
            sb.Append("  QueryParamValue: ").Append(QueryParamValue).Append("\n");
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
