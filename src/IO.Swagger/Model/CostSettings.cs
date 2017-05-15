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
    /// Depending to the cost type you will have to define a cost value.
    /// </summary>
    [DataContract]
    public partial class CostSettings :  IEquatable<CostSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CostSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CostSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CostSettings" /> class.
        /// </summary>
        /// <param name="CostType">CostType (required).</param>
        /// <param name="GlobalCostValue">In case of global cost type, you have to indicate the cost value..</param>
        public CostSettings(CostType CostType = default(CostType), decimal? GlobalCostValue = default(decimal?))
        {
            // to ensure "CostType" is required (not null)
            if (CostType == null)
            {
                throw new InvalidDataException("CostType is a required property for CostSettings and cannot be null");
            }
            else
            {
                this.CostType = CostType;
            }
            this.GlobalCostValue = GlobalCostValue;
        }
        
        /// <summary>
        /// Gets or Sets CostType
        /// </summary>
        [DataMember(Name="costType", EmitDefaultValue=false)]
        public CostType CostType { get; set; }
        /// <summary>
        /// In case of global cost type, you have to indicate the cost value.
        /// </summary>
        /// <value>In case of global cost type, you have to indicate the cost value.</value>
        [DataMember(Name="globalCostValue", EmitDefaultValue=false)]
        public decimal? GlobalCostValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CostSettings {\n");
            sb.Append("  CostType: ").Append(CostType).Append("\n");
            sb.Append("  GlobalCostValue: ").Append(GlobalCostValue).Append("\n");
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
            return this.Equals(obj as CostSettings);
        }

        /// <summary>
        /// Returns true if CostSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of CostSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CostType == other.CostType ||
                    this.CostType != null &&
                    this.CostType.Equals(other.CostType)
                ) && 
                (
                    this.GlobalCostValue == other.GlobalCostValue ||
                    this.GlobalCostValue != null &&
                    this.GlobalCostValue.Equals(other.GlobalCostValue)
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
                if (this.CostType != null)
                    hash = hash * 59 + this.CostType.GetHashCode();
                if (this.GlobalCostValue != null)
                    hash = hash * 59 + this.GlobalCostValue.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
