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
    /// Describe the bonus information related to your current contract.
    /// </summary>
    [DataContract]
    public partial class ContractBonusInfo :  IEquatable<ContractBonusInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractBonusInfo" /> class.
        /// </summary>
        /// <param name="Bonuses">Bonuses.</param>
        public ContractBonusInfo(List<BonusInfo> Bonuses = default(List<BonusInfo>))
        {
            this.Bonuses = Bonuses;
        }
        
        /// <summary>
        /// Gets or Sets Bonuses
        /// </summary>
        [DataMember(Name="bonuses", EmitDefaultValue=false)]
        public List<BonusInfo> Bonuses { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractBonusInfo {\n");
            sb.Append("  Bonuses: ").Append(Bonuses).Append("\n");
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
            return this.Equals(obj as ContractBonusInfo);
        }

        /// <summary>
        /// Returns true if ContractBonusInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractBonusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractBonusInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bonuses == other.Bonuses ||
                    this.Bonuses != null &&
                    this.Bonuses.SequenceEqual(other.Bonuses)
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
                if (this.Bonuses != null)
                    hash = hash * 59 + this.Bonuses.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
