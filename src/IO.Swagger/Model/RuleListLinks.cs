/* 
 * BeezUP API
 *
 * This is the RESTful API of BeezUP which allows you to manage everything related to BeezUP
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
    /// Links to know if the user can create a rule or run all rules
    /// </summary>
    [DataContract]
    public partial class RuleListLinks :  IEquatable<RuleListLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleListLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Create">Create.</param>
        /// <param name="History">History.</param>
        /// <param name="Run">Run.</param>
        public RuleListLinks(DefinitionslinksGetRulesLink Self = default(DefinitionslinksGetRulesLink), DefinitionslinksCreateRuleLink Create = default(DefinitionslinksCreateRuleLink), DefinitionslinksGetRulesExecutionsLink History = default(DefinitionslinksGetRulesExecutionsLink), DefinitionslinksRunRulesLink Run = default(DefinitionslinksRunRulesLink))
        {
            this.Self = Self;
            this.Create = Create;
            this.History = History;
            this.Run = Run;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public DefinitionslinksGetRulesLink Self { get; set; }
        /// <summary>
        /// Gets or Sets Create
        /// </summary>
        [DataMember(Name="create", EmitDefaultValue=false)]
        public DefinitionslinksCreateRuleLink Create { get; set; }
        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history", EmitDefaultValue=false)]
        public DefinitionslinksGetRulesExecutionsLink History { get; set; }
        /// <summary>
        /// Gets or Sets Run
        /// </summary>
        [DataMember(Name="run", EmitDefaultValue=false)]
        public DefinitionslinksRunRulesLink Run { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleListLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  Run: ").Append(Run).Append("\n");
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
            return this.Equals(obj as RuleListLinks);
        }

        /// <summary>
        /// Returns true if RuleListLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleListLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleListLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Create == other.Create ||
                    this.Create != null &&
                    this.Create.Equals(other.Create)
                ) && 
                (
                    this.History == other.History ||
                    this.History != null &&
                    this.History.Equals(other.History)
                ) && 
                (
                    this.Run == other.Run ||
                    this.Run != null &&
                    this.Run.Equals(other.Run)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Create != null)
                    hash = hash * 59 + this.Create.GetHashCode();
                if (this.History != null)
                    hash = hash * 59 + this.History.GetHashCode();
                if (this.Run != null)
                    hash = hash * 59 + this.Run.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
