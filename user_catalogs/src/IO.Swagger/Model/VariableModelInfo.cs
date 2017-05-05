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
    /// Internal usage: Old offer type. Describe the fix and variable model information
    /// </summary>
    [DataContract]
    public partial class VariableModelInfo :  IEquatable<VariableModelInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableModelInfo" /> class.
        /// </summary>
        /// <param name="ClickIncludedAndVariablePrices">Click included with variable pricing information.</param>
        /// <param name="OverflowClickCount">The overflow click count.</param>
        /// <param name="OverflowClickPrice">The overflow click price.</param>
        public VariableModelInfo(List<ClickIncludedAndVariablePrice> ClickIncludedAndVariablePrices = default(List<ClickIncludedAndVariablePrice>), int? OverflowClickCount = default(int?), double? OverflowClickPrice = default(double?))
        {
            this.ClickIncludedAndVariablePrices = ClickIncludedAndVariablePrices;
            this.OverflowClickCount = OverflowClickCount;
            this.OverflowClickPrice = OverflowClickPrice;
        }
        
        /// <summary>
        /// Click included with variable pricing information
        /// </summary>
        /// <value>Click included with variable pricing information</value>
        [DataMember(Name="clickIncludedAndVariablePrices", EmitDefaultValue=false)]
        public List<ClickIncludedAndVariablePrice> ClickIncludedAndVariablePrices { get; set; }
        /// <summary>
        /// The overflow click count
        /// </summary>
        /// <value>The overflow click count</value>
        [DataMember(Name="overflowClickCount", EmitDefaultValue=false)]
        public int? OverflowClickCount { get; set; }
        /// <summary>
        /// The overflow click price
        /// </summary>
        /// <value>The overflow click price</value>
        [DataMember(Name="overflowClickPrice", EmitDefaultValue=false)]
        public double? OverflowClickPrice { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableModelInfo {\n");
            sb.Append("  ClickIncludedAndVariablePrices: ").Append(ClickIncludedAndVariablePrices).Append("\n");
            sb.Append("  OverflowClickCount: ").Append(OverflowClickCount).Append("\n");
            sb.Append("  OverflowClickPrice: ").Append(OverflowClickPrice).Append("\n");
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
            return this.Equals(obj as VariableModelInfo);
        }

        /// <summary>
        /// Returns true if VariableModelInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of VariableModelInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableModelInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClickIncludedAndVariablePrices == other.ClickIncludedAndVariablePrices ||
                    this.ClickIncludedAndVariablePrices != null &&
                    this.ClickIncludedAndVariablePrices.SequenceEqual(other.ClickIncludedAndVariablePrices)
                ) && 
                (
                    this.OverflowClickCount == other.OverflowClickCount ||
                    this.OverflowClickCount != null &&
                    this.OverflowClickCount.Equals(other.OverflowClickCount)
                ) && 
                (
                    this.OverflowClickPrice == other.OverflowClickPrice ||
                    this.OverflowClickPrice != null &&
                    this.OverflowClickPrice.Equals(other.OverflowClickPrice)
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
                if (this.ClickIncludedAndVariablePrices != null)
                    hash = hash * 59 + this.ClickIncludedAndVariablePrices.GetHashCode();
                if (this.OverflowClickCount != null)
                    hash = hash * 59 + this.OverflowClickCount.GetHashCode();
                if (this.OverflowClickPrice != null)
                    hash = hash * 59 + this.OverflowClickPrice.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
