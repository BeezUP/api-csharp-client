/* 
 * Public - Security
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
    /// ClickIncludedAndVariablePrice
    /// </summary>
    [DataContract]
    public partial class ClickIncludedAndVariablePrice :  IEquatable<ClickIncludedAndVariablePrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClickIncludedAndVariablePrice" /> class.
        /// </summary>
        /// <param name="ClickIncluded">Click included.</param>
        /// <param name="VariablePrice">The pricing applied for this range.</param>
        public ClickIncludedAndVariablePrice(int? ClickIncluded = default(int?), double? VariablePrice = default(double?))
        {
            this.ClickIncluded = ClickIncluded;
            this.VariablePrice = VariablePrice;
        }
        
        /// <summary>
        /// Click included
        /// </summary>
        /// <value>Click included</value>
        [DataMember(Name="clickIncluded", EmitDefaultValue=false)]
        public int? ClickIncluded { get; set; }
        /// <summary>
        /// The pricing applied for this range
        /// </summary>
        /// <value>The pricing applied for this range</value>
        [DataMember(Name="variablePrice", EmitDefaultValue=false)]
        public double? VariablePrice { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickIncludedAndVariablePrice {\n");
            sb.Append("  ClickIncluded: ").Append(ClickIncluded).Append("\n");
            sb.Append("  VariablePrice: ").Append(VariablePrice).Append("\n");
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
            return this.Equals(obj as ClickIncludedAndVariablePrice);
        }

        /// <summary>
        /// Returns true if ClickIncludedAndVariablePrice instances are equal
        /// </summary>
        /// <param name="other">Instance of ClickIncludedAndVariablePrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClickIncludedAndVariablePrice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClickIncluded == other.ClickIncluded ||
                    this.ClickIncluded != null &&
                    this.ClickIncluded.Equals(other.ClickIncluded)
                ) && 
                (
                    this.VariablePrice == other.VariablePrice ||
                    this.VariablePrice != null &&
                    this.VariablePrice.Equals(other.VariablePrice)
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
                if (this.ClickIncluded != null)
                    hash = hash * 59 + this.ClickIncluded.GetHashCode();
                if (this.VariablePrice != null)
                    hash = hash * 59 + this.VariablePrice.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
