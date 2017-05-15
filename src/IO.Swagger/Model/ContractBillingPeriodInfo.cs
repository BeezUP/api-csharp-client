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
    /// Describe the billing period information related to the offer.
    /// </summary>
    [DataContract]
    public partial class ContractBillingPeriodInfo :  IEquatable<ContractBillingPeriodInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractBillingPeriodInfo" /> class.
        /// </summary>
        /// <param name="AmountBillingPeriodDiscount">The amount discounted related to the billing period.</param>
        /// <param name="BillingPeriodPercentDiscount">The discount percent related to the billing period.</param>
        /// <param name="BillingPeriodInMonth">BillingPeriodInMonth.</param>
        public ContractBillingPeriodInfo(double? AmountBillingPeriodDiscount = default(double?), double? BillingPeriodPercentDiscount = default(double?), BillingPeriodInMonth BillingPeriodInMonth = default(BillingPeriodInMonth))
        {
            this.AmountBillingPeriodDiscount = AmountBillingPeriodDiscount;
            this.BillingPeriodPercentDiscount = BillingPeriodPercentDiscount;
            this.BillingPeriodInMonth = BillingPeriodInMonth;
        }
        
        /// <summary>
        /// The amount discounted related to the billing period
        /// </summary>
        /// <value>The amount discounted related to the billing period</value>
        [DataMember(Name="amountBillingPeriodDiscount", EmitDefaultValue=false)]
        public double? AmountBillingPeriodDiscount { get; set; }
        /// <summary>
        /// The discount percent related to the billing period
        /// </summary>
        /// <value>The discount percent related to the billing period</value>
        [DataMember(Name="billingPeriodPercentDiscount", EmitDefaultValue=false)]
        public double? BillingPeriodPercentDiscount { get; set; }
        /// <summary>
        /// Gets or Sets BillingPeriodInMonth
        /// </summary>
        [DataMember(Name="billingPeriodInMonth", EmitDefaultValue=false)]
        public BillingPeriodInMonth BillingPeriodInMonth { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractBillingPeriodInfo {\n");
            sb.Append("  AmountBillingPeriodDiscount: ").Append(AmountBillingPeriodDiscount).Append("\n");
            sb.Append("  BillingPeriodPercentDiscount: ").Append(BillingPeriodPercentDiscount).Append("\n");
            sb.Append("  BillingPeriodInMonth: ").Append(BillingPeriodInMonth).Append("\n");
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
            return this.Equals(obj as ContractBillingPeriodInfo);
        }

        /// <summary>
        /// Returns true if ContractBillingPeriodInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractBillingPeriodInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractBillingPeriodInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountBillingPeriodDiscount == other.AmountBillingPeriodDiscount ||
                    this.AmountBillingPeriodDiscount != null &&
                    this.AmountBillingPeriodDiscount.Equals(other.AmountBillingPeriodDiscount)
                ) && 
                (
                    this.BillingPeriodPercentDiscount == other.BillingPeriodPercentDiscount ||
                    this.BillingPeriodPercentDiscount != null &&
                    this.BillingPeriodPercentDiscount.Equals(other.BillingPeriodPercentDiscount)
                ) && 
                (
                    this.BillingPeriodInMonth == other.BillingPeriodInMonth ||
                    this.BillingPeriodInMonth != null &&
                    this.BillingPeriodInMonth.Equals(other.BillingPeriodInMonth)
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
                if (this.AmountBillingPeriodDiscount != null)
                    hash = hash * 59 + this.AmountBillingPeriodDiscount.GetHashCode();
                if (this.BillingPeriodPercentDiscount != null)
                    hash = hash * 59 + this.BillingPeriodPercentDiscount.GetHashCode();
                if (this.BillingPeriodInMonth != null)
                    hash = hash * 59 + this.BillingPeriodInMonth.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
