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
    /// Describe the store information related to the offer.
    /// </summary>
    [DataContract]
    public partial class ContractStoreInfo :  IEquatable<ContractStoreInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractStoreInfo" /> class.
        /// </summary>
        /// <param name="StoreCount">StoreCount.</param>
        /// <param name="MaxStoreCount">The maximum store count related to the offer..</param>
        /// <param name="MinStoreCount">The minimum store count related to the offer..</param>
        /// <param name="OwnedStoreCount">The owned store count..</param>
        /// <param name="AdditionalStorePrice">The additional store price..</param>
        /// <param name="StoreIncluded">The store count included in the offer..</param>
        public ContractStoreInfo(StoreCount StoreCount = default(StoreCount), int? MaxStoreCount = default(int?), int? MinStoreCount = default(int?), int? OwnedStoreCount = default(int?), double? AdditionalStorePrice = default(double?), int? StoreIncluded = default(int?))
        {
            this.StoreCount = StoreCount;
            this.MaxStoreCount = MaxStoreCount;
            this.MinStoreCount = MinStoreCount;
            this.OwnedStoreCount = OwnedStoreCount;
            this.AdditionalStorePrice = AdditionalStorePrice;
            this.StoreIncluded = StoreIncluded;
        }
        
        /// <summary>
        /// Gets or Sets StoreCount
        /// </summary>
        [DataMember(Name="storeCount", EmitDefaultValue=false)]
        public StoreCount StoreCount { get; set; }
        /// <summary>
        /// The maximum store count related to the offer.
        /// </summary>
        /// <value>The maximum store count related to the offer.</value>
        [DataMember(Name="maxStoreCount", EmitDefaultValue=false)]
        public int? MaxStoreCount { get; set; }
        /// <summary>
        /// The minimum store count related to the offer.
        /// </summary>
        /// <value>The minimum store count related to the offer.</value>
        [DataMember(Name="minStoreCount", EmitDefaultValue=false)]
        public int? MinStoreCount { get; set; }
        /// <summary>
        /// The owned store count.
        /// </summary>
        /// <value>The owned store count.</value>
        [DataMember(Name="ownedStoreCount", EmitDefaultValue=false)]
        public int? OwnedStoreCount { get; set; }
        /// <summary>
        /// The additional store price.
        /// </summary>
        /// <value>The additional store price.</value>
        [DataMember(Name="additionalStorePrice", EmitDefaultValue=false)]
        public double? AdditionalStorePrice { get; set; }
        /// <summary>
        /// The store count included in the offer.
        /// </summary>
        /// <value>The store count included in the offer.</value>
        [DataMember(Name="storeIncluded", EmitDefaultValue=false)]
        public int? StoreIncluded { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractStoreInfo {\n");
            sb.Append("  StoreCount: ").Append(StoreCount).Append("\n");
            sb.Append("  MaxStoreCount: ").Append(MaxStoreCount).Append("\n");
            sb.Append("  MinStoreCount: ").Append(MinStoreCount).Append("\n");
            sb.Append("  OwnedStoreCount: ").Append(OwnedStoreCount).Append("\n");
            sb.Append("  AdditionalStorePrice: ").Append(AdditionalStorePrice).Append("\n");
            sb.Append("  StoreIncluded: ").Append(StoreIncluded).Append("\n");
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
            return this.Equals(obj as ContractStoreInfo);
        }

        /// <summary>
        /// Returns true if ContractStoreInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractStoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractStoreInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StoreCount == other.StoreCount ||
                    this.StoreCount != null &&
                    this.StoreCount.Equals(other.StoreCount)
                ) && 
                (
                    this.MaxStoreCount == other.MaxStoreCount ||
                    this.MaxStoreCount != null &&
                    this.MaxStoreCount.Equals(other.MaxStoreCount)
                ) && 
                (
                    this.MinStoreCount == other.MinStoreCount ||
                    this.MinStoreCount != null &&
                    this.MinStoreCount.Equals(other.MinStoreCount)
                ) && 
                (
                    this.OwnedStoreCount == other.OwnedStoreCount ||
                    this.OwnedStoreCount != null &&
                    this.OwnedStoreCount.Equals(other.OwnedStoreCount)
                ) && 
                (
                    this.AdditionalStorePrice == other.AdditionalStorePrice ||
                    this.AdditionalStorePrice != null &&
                    this.AdditionalStorePrice.Equals(other.AdditionalStorePrice)
                ) && 
                (
                    this.StoreIncluded == other.StoreIncluded ||
                    this.StoreIncluded != null &&
                    this.StoreIncluded.Equals(other.StoreIncluded)
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
                if (this.StoreCount != null)
                    hash = hash * 59 + this.StoreCount.GetHashCode();
                if (this.MaxStoreCount != null)
                    hash = hash * 59 + this.MaxStoreCount.GetHashCode();
                if (this.MinStoreCount != null)
                    hash = hash * 59 + this.MinStoreCount.GetHashCode();
                if (this.OwnedStoreCount != null)
                    hash = hash * 59 + this.OwnedStoreCount.GetHashCode();
                if (this.AdditionalStorePrice != null)
                    hash = hash * 59 + this.AdditionalStorePrice.GetHashCode();
                if (this.StoreIncluded != null)
                    hash = hash * 59 + this.StoreIncluded.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
