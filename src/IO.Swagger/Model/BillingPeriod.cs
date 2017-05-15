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
    /// BillingPeriod
    /// </summary>
    [DataContract]
    public partial class BillingPeriod :  IEquatable<BillingPeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingPeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPeriod" /> class.
        /// </summary>
        /// <param name="BillingPeriodInMonth">The billing period in month (required).</param>
        /// <param name="DiscountPercentage">The discount percentage related to this billing period (required).</param>
        public BillingPeriod(int? BillingPeriodInMonth = default(int?), double? DiscountPercentage = default(double?))
        {
            // to ensure "BillingPeriodInMonth" is required (not null)
            if (BillingPeriodInMonth == null)
            {
                throw new InvalidDataException("BillingPeriodInMonth is a required property for BillingPeriod and cannot be null");
            }
            else
            {
                this.BillingPeriodInMonth = BillingPeriodInMonth;
            }
            // to ensure "DiscountPercentage" is required (not null)
            if (DiscountPercentage == null)
            {
                throw new InvalidDataException("DiscountPercentage is a required property for BillingPeriod and cannot be null");
            }
            else
            {
                this.DiscountPercentage = DiscountPercentage;
            }
        }
        
        /// <summary>
        /// The billing period in month
        /// </summary>
        /// <value>The billing period in month</value>
        [DataMember(Name="billingPeriodInMonth", EmitDefaultValue=false)]
        public int? BillingPeriodInMonth { get; set; }
        /// <summary>
        /// The discount percentage related to this billing period
        /// </summary>
        /// <value>The discount percentage related to this billing period</value>
        [DataMember(Name="discountPercentage", EmitDefaultValue=false)]
        public double? DiscountPercentage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPeriod {\n");
            sb.Append("  BillingPeriodInMonth: ").Append(BillingPeriodInMonth).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
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
            return this.Equals(obj as BillingPeriod);
        }

        /// <summary>
        /// Returns true if BillingPeriod instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPeriod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingPeriodInMonth == other.BillingPeriodInMonth ||
                    this.BillingPeriodInMonth != null &&
                    this.BillingPeriodInMonth.Equals(other.BillingPeriodInMonth)
                ) && 
                (
                    this.DiscountPercentage == other.DiscountPercentage ||
                    this.DiscountPercentage != null &&
                    this.DiscountPercentage.Equals(other.DiscountPercentage)
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
                if (this.BillingPeriodInMonth != null)
                    hash = hash * 59 + this.BillingPeriodInMonth.GetHashCode();
                if (this.DiscountPercentage != null)
                    hash = hash * 59 + this.DiscountPercentage.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
