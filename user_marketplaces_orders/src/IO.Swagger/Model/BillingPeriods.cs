/* 
 * Customer
 *
 * This API will gives you the ability to : - manage your account - manage your stores - shares your stores with your friends - manage your contracts - access to your invoices 
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
    /// BillingPeriods
    /// </summary>
    [DataContract]
    public partial class BillingPeriods :  IEquatable<BillingPeriods>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPeriods" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingPeriods() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPeriods" /> class.
        /// </summary>
        /// <param name="_BillingPeriods">The billing period list (required).</param>
        public BillingPeriods(List<BillingPeriod> _BillingPeriods = default(List<BillingPeriod>))
        {
            // to ensure "_BillingPeriods" is required (not null)
            if (_BillingPeriods == null)
            {
                throw new InvalidDataException("_BillingPeriods is a required property for BillingPeriods and cannot be null");
            }
            else
            {
                this._BillingPeriods = _BillingPeriods;
            }
        }
        
        /// <summary>
        /// The billing period list
        /// </summary>
        /// <value>The billing period list</value>
        [DataMember(Name="billingPeriods", EmitDefaultValue=false)]
        public List<BillingPeriod> _BillingPeriods { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPeriods {\n");
            sb.Append("  _BillingPeriods: ").Append(_BillingPeriods).Append("\n");
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
            return this.Equals(obj as BillingPeriods);
        }

        /// <summary>
        /// Returns true if BillingPeriods instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPeriods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPeriods other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._BillingPeriods == other._BillingPeriods ||
                    this._BillingPeriods != null &&
                    this._BillingPeriods.SequenceEqual(other._BillingPeriods)
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
                if (this._BillingPeriods != null)
                    hash = hash * 59 + this._BillingPeriods.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
