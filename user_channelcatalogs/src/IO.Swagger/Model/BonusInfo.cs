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
    /// BonusInfo
    /// </summary>
    [DataContract]
    public partial class BonusInfo :  IEquatable<BonusInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BonusInfo" /> class.
        /// </summary>
        /// <param name="BonusType">BonusType.</param>
        /// <param name="Amount">Amount.</param>
        public BonusInfo(BonusType BonusType = default(BonusType), double? Amount = default(double?))
        {
            this.BonusType = BonusType;
            this.Amount = Amount;
        }
        
        /// <summary>
        /// Gets or Sets BonusType
        /// </summary>
        [DataMember(Name="bonusType", EmitDefaultValue=false)]
        public BonusType BonusType { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BonusInfo {\n");
            sb.Append("  BonusType: ").Append(BonusType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(obj as BonusInfo);
        }

        /// <summary>
        /// Returns true if BonusInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BonusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BonusInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BonusType == other.BonusType ||
                    this.BonusType != null &&
                    this.BonusType.Equals(other.BonusType)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
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
                if (this.BonusType != null)
                    hash = hash * 59 + this.BonusType.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}