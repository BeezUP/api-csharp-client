/* 
 * BeezUP API
 *
 * This API will allow you to create your account and to get your tokens. \\ If you lost your password, you have an operation to get it back. 
 *
 * OpenAPI spec version: 2.0
 * Contact: support@beezup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Links to retrieve/action on this rule execution
    /// </summary>
    [DataContract]
    public partial class RuleExecutionReportingLinks :  IEquatable<RuleExecutionReportingLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleExecutionReportingLinks" /> class.
        /// </summary>
        /// <param name="Rule">Rule.</param>
        public RuleExecutionReportingLinks(LinksGetRuleLink Rule = default(LinksGetRuleLink))
        {
            this.Rule = Rule;
        }
        
        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name="rule", EmitDefaultValue=false)]
        public LinksGetRuleLink Rule { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleExecutionReportingLinks {\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RuleExecutionReportingLinks);
        }

        /// <summary>
        /// Returns true if RuleExecutionReportingLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleExecutionReportingLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleExecutionReportingLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rule == other.Rule ||
                    this.Rule != null &&
                    this.Rule.Equals(other.Rule)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Rule != null)
                    hash = hash * 59 + this.Rule.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
