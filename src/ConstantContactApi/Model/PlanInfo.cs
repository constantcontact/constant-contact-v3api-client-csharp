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
    /// Specifies the type of billing plan and the billing date to use for a client account.
    /// </summary>
    [DataContract(Name = "PlanInfo")]
    public partial class PlanInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanInfo" /> class.
        /// </summary>
        /// <param name="planType">Use this property to update the client account billing plan to a different billing plan. After changing the &lt;code&gt;plan_type&lt;/code&gt; from &lt;code&gt;TRIAL&lt;/code&gt; to any other billing plan type, you cannot change it back to &lt;code&gt;TRIAL&lt;/code&gt;.   &lt;ul&gt;     &lt;li&gt;&lt;code&gt;TRIAL&lt;/code&gt;: A non-billable account with an expiration date that allows clients to try Constant Contact product features.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;GOLD&lt;/code&gt;: A billable client account plan.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;SILVER&lt;/code&gt;: A billable client account plan.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;BRONZE&lt;/code&gt;: A billable client account plan.&lt;/li&gt;   &lt;/ul&gt;.</param>
        /// <param name="planGroupId">Updates an existing client account billing plan group to a new billing plan group. If you don&#39;t know the &#x60;plan_group_id&#x60; to use, contact our API support team..</param>
        /// <param name="billingDayOfMonth">This property is required if a client account is not set up to use single billing. You can choose to enter a specific day of the month or accept the default value, which is the day on which the &lt;code&gt;plan_type&lt;/code&gt; value changes from a &lt;code&gt;TRIAL&lt;/code&gt; plan to a different &lt;code&gt;plan_type&lt;/code&gt;. For trial accounts, the value defaults to null. You can only change the &lt;code&gt;billing_day_of_month&lt;/code&gt; when changing the &lt;code&gt;plan_type&lt;/code&gt; value from &lt;code&gt;TRIAL&lt;/code&gt; to a different &lt;code&gt;plan_type&lt;/code&gt;, otherwise the value you enter is ignored..</param>
        public PlanInfo(string planType = default(string), int planGroupId = default(int), int billingDayOfMonth = default(int))
        {
            this.PlanType = planType;
            this.PlanGroupId = planGroupId;
            this.BillingDayOfMonth = billingDayOfMonth;
        }

        /// <summary>
        /// Use this property to update the client account billing plan to a different billing plan. After changing the &lt;code&gt;plan_type&lt;/code&gt; from &lt;code&gt;TRIAL&lt;/code&gt; to any other billing plan type, you cannot change it back to &lt;code&gt;TRIAL&lt;/code&gt;.   &lt;ul&gt;     &lt;li&gt;&lt;code&gt;TRIAL&lt;/code&gt;: A non-billable account with an expiration date that allows clients to try Constant Contact product features.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;GOLD&lt;/code&gt;: A billable client account plan.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;SILVER&lt;/code&gt;: A billable client account plan.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;BRONZE&lt;/code&gt;: A billable client account plan.&lt;/li&gt;   &lt;/ul&gt;
        /// </summary>
        /// <value>Use this property to update the client account billing plan to a different billing plan. After changing the &lt;code&gt;plan_type&lt;/code&gt; from &lt;code&gt;TRIAL&lt;/code&gt; to any other billing plan type, you cannot change it back to &lt;code&gt;TRIAL&lt;/code&gt;.   &lt;ul&gt;     &lt;li&gt;&lt;code&gt;TRIAL&lt;/code&gt;: A non-billable account with an expiration date that allows clients to try Constant Contact product features.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;GOLD&lt;/code&gt;: A billable client account plan.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;SILVER&lt;/code&gt;: A billable client account plan.&lt;/li&gt;      &lt;li&gt;&lt;code&gt;BRONZE&lt;/code&gt;: A billable client account plan.&lt;/li&gt;   &lt;/ul&gt;</value>
        /// <example>GOLD</example>
        [DataMember(Name = "plan_type", EmitDefaultValue = false)]
        public string PlanType { get; set; }

        /// <summary>
        /// Updates an existing client account billing plan group to a new billing plan group. If you don&#39;t know the &#x60;plan_group_id&#x60; to use, contact our API support team.
        /// </summary>
        /// <value>Updates an existing client account billing plan group to a new billing plan group. If you don&#39;t know the &#x60;plan_group_id&#x60; to use, contact our API support team.</value>
        /// <example>152</example>
        [DataMember(Name = "plan_group_id", EmitDefaultValue = false)]
        public int PlanGroupId { get; set; }

        /// <summary>
        /// This property is required if a client account is not set up to use single billing. You can choose to enter a specific day of the month or accept the default value, which is the day on which the &lt;code&gt;plan_type&lt;/code&gt; value changes from a &lt;code&gt;TRIAL&lt;/code&gt; plan to a different &lt;code&gt;plan_type&lt;/code&gt;. For trial accounts, the value defaults to null. You can only change the &lt;code&gt;billing_day_of_month&lt;/code&gt; when changing the &lt;code&gt;plan_type&lt;/code&gt; value from &lt;code&gt;TRIAL&lt;/code&gt; to a different &lt;code&gt;plan_type&lt;/code&gt;, otherwise the value you enter is ignored.
        /// </summary>
        /// <value>This property is required if a client account is not set up to use single billing. You can choose to enter a specific day of the month or accept the default value, which is the day on which the &lt;code&gt;plan_type&lt;/code&gt; value changes from a &lt;code&gt;TRIAL&lt;/code&gt; plan to a different &lt;code&gt;plan_type&lt;/code&gt;. For trial accounts, the value defaults to null. You can only change the &lt;code&gt;billing_day_of_month&lt;/code&gt; when changing the &lt;code&gt;plan_type&lt;/code&gt; value from &lt;code&gt;TRIAL&lt;/code&gt; to a different &lt;code&gt;plan_type&lt;/code&gt;, otherwise the value you enter is ignored.</value>
        /// <example>15</example>
        [DataMember(Name = "billing_day_of_month", EmitDefaultValue = false)]
        public int BillingDayOfMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlanInfo {\n");
            sb.Append("  PlanType: ").Append(PlanType).Append("\n");
            sb.Append("  PlanGroupId: ").Append(PlanGroupId).Append("\n");
            sb.Append("  BillingDayOfMonth: ").Append(BillingDayOfMonth).Append("\n");
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
