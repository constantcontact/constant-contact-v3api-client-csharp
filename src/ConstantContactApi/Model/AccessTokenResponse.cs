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
    /// AccessTokenResponse
    /// </summary>
    [DataContract(Name = "AccessTokenResponse")]
    public partial class AccessTokenResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        /// <param name="accessToken">A JWT bearer access token that can be used to access the public API..</param>
        /// <param name="tokenType">The type of token..</param>
        /// <param name="expiresIn">Timestamp that the token will expire in seconds after the UNIX epoch..</param>
        /// <param name="scope">Space delimited list of scopes granted to the access token..</param>
        /// <param name="refreshToken">Contains a token you can use to refresh the bearer access token..</param>
        /// <param name="idToken">A JWT token that contains information about user authentication..</param>
        public AccessTokenResponse(string accessToken = default(string), string tokenType = default(string), int expiresIn = default(int), string scope = default(string), string refreshToken = default(string), string idToken = default(string))
        {
            this.AccessToken = accessToken;
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.Scope = scope;
            this.RefreshToken = refreshToken;
            this.IdToken = idToken;
        }

        /// <summary>
        /// A JWT bearer access token that can be used to access the public API.
        /// </summary>
        /// <value>A JWT bearer access token that can be used to access the public API.</value>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The type of token.
        /// </summary>
        /// <value>The type of token.</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Timestamp that the token will expire in seconds after the UNIX epoch.
        /// </summary>
        /// <value>Timestamp that the token will expire in seconds after the UNIX epoch.</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Space delimited list of scopes granted to the access token.
        /// </summary>
        /// <value>Space delimited list of scopes granted to the access token.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Contains a token you can use to refresh the bearer access token.
        /// </summary>
        /// <value>Contains a token you can use to refresh the bearer access token.</value>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// A JWT token that contains information about user authentication.
        /// </summary>
        /// <value>A JWT token that contains information about user authentication.</value>
        [DataMember(Name = "id_token", EmitDefaultValue = false)]
        public string IdToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
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
