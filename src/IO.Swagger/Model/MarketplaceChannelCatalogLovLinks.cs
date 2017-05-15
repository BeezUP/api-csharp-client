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
    /// Indicates the List Of Values related to the marketplace
    /// </summary>
    [DataContract]
    public partial class MarketplaceChannelCatalogLovLinks :  IEquatable<MarketplaceChannelCatalogLovLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalogLovLinks" /> class.
        /// </summary>
        /// <param name="ShippingMethodLOV">ShippingMethodLOV.</param>
        /// <param name="CarrierCodeLOV">CarrierCodeLOV.</param>
        /// <param name="CancelationReasonCodeLOV">CancelationReasonCodeLOV.</param>
        /// <param name="RefundReasonCodeLOV">RefundReasonCodeLOV.</param>
        public MarketplaceChannelCatalogLovLinks(BeezUPCommonLOVLink3 ShippingMethodLOV = default(BeezUPCommonLOVLink3), BeezUPCommonLOVLink3 CarrierCodeLOV = default(BeezUPCommonLOVLink3), BeezUPCommonLOVLink3 CancelationReasonCodeLOV = default(BeezUPCommonLOVLink3), BeezUPCommonLOVLink3 RefundReasonCodeLOV = default(BeezUPCommonLOVLink3))
        {
            this.ShippingMethodLOV = ShippingMethodLOV;
            this.CarrierCodeLOV = CarrierCodeLOV;
            this.CancelationReasonCodeLOV = CancelationReasonCodeLOV;
            this.RefundReasonCodeLOV = RefundReasonCodeLOV;
        }
        
        /// <summary>
        /// Gets or Sets ShippingMethodLOV
        /// </summary>
        [DataMember(Name="shippingMethodLOV", EmitDefaultValue=false)]
        public BeezUPCommonLOVLink3 ShippingMethodLOV { get; set; }
        /// <summary>
        /// Gets or Sets CarrierCodeLOV
        /// </summary>
        [DataMember(Name="carrierCodeLOV", EmitDefaultValue=false)]
        public BeezUPCommonLOVLink3 CarrierCodeLOV { get; set; }
        /// <summary>
        /// Gets or Sets CancelationReasonCodeLOV
        /// </summary>
        [DataMember(Name="cancelationReasonCodeLOV", EmitDefaultValue=false)]
        public BeezUPCommonLOVLink3 CancelationReasonCodeLOV { get; set; }
        /// <summary>
        /// Gets or Sets RefundReasonCodeLOV
        /// </summary>
        [DataMember(Name="refundReasonCodeLOV", EmitDefaultValue=false)]
        public BeezUPCommonLOVLink3 RefundReasonCodeLOV { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceChannelCatalogLovLinks {\n");
            sb.Append("  ShippingMethodLOV: ").Append(ShippingMethodLOV).Append("\n");
            sb.Append("  CarrierCodeLOV: ").Append(CarrierCodeLOV).Append("\n");
            sb.Append("  CancelationReasonCodeLOV: ").Append(CancelationReasonCodeLOV).Append("\n");
            sb.Append("  RefundReasonCodeLOV: ").Append(RefundReasonCodeLOV).Append("\n");
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
            return this.Equals(obj as MarketplaceChannelCatalogLovLinks);
        }

        /// <summary>
        /// Returns true if MarketplaceChannelCatalogLovLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketplaceChannelCatalogLovLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceChannelCatalogLovLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShippingMethodLOV == other.ShippingMethodLOV ||
                    this.ShippingMethodLOV != null &&
                    this.ShippingMethodLOV.Equals(other.ShippingMethodLOV)
                ) && 
                (
                    this.CarrierCodeLOV == other.CarrierCodeLOV ||
                    this.CarrierCodeLOV != null &&
                    this.CarrierCodeLOV.Equals(other.CarrierCodeLOV)
                ) && 
                (
                    this.CancelationReasonCodeLOV == other.CancelationReasonCodeLOV ||
                    this.CancelationReasonCodeLOV != null &&
                    this.CancelationReasonCodeLOV.Equals(other.CancelationReasonCodeLOV)
                ) && 
                (
                    this.RefundReasonCodeLOV == other.RefundReasonCodeLOV ||
                    this.RefundReasonCodeLOV != null &&
                    this.RefundReasonCodeLOV.Equals(other.RefundReasonCodeLOV)
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
                if (this.ShippingMethodLOV != null)
                    hash = hash * 59 + this.ShippingMethodLOV.GetHashCode();
                if (this.CarrierCodeLOV != null)
                    hash = hash * 59 + this.CarrierCodeLOV.GetHashCode();
                if (this.CancelationReasonCodeLOV != null)
                    hash = hash * 59 + this.CancelationReasonCodeLOV.GetHashCode();
                if (this.RefundReasonCodeLOV != null)
                    hash = hash * 59 + this.RefundReasonCodeLOV.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
