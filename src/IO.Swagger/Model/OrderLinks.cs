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
    /// OrderLinks
    /// </summary>
    [DataContract]
    public partial class OrderLinks :  IEquatable<OrderLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLinks" /> class.
        /// </summary>
        /// <param name="Self">Self (required).</param>
        /// <param name="History">History (required).</param>
        /// <param name="Harvest">Harvest (required).</param>
        /// <param name="SetMerchantInfo">SetMerchantInfo (required).</param>
        /// <param name="ClearMerchantInfo">ClearMerchantInfo (required).</param>
        public OrderLinks(LinksGetOrderLink Self = default(LinksGetOrderLink), LinksGetOrderHistoryLink History = default(LinksGetOrderHistoryLink), LinksHarvestOrderLink Harvest = default(LinksHarvestOrderLink), LinksSetMerchantOrderInfoLink SetMerchantInfo = default(LinksSetMerchantOrderInfoLink), LinksClearMerchantOrderInfoLink ClearMerchantInfo = default(LinksClearMerchantOrderInfoLink))
        {
            // to ensure "Self" is required (not null)
            if (Self == null)
            {
                throw new InvalidDataException("Self is a required property for OrderLinks and cannot be null");
            }
            else
            {
                this.Self = Self;
            }
            // to ensure "History" is required (not null)
            if (History == null)
            {
                throw new InvalidDataException("History is a required property for OrderLinks and cannot be null");
            }
            else
            {
                this.History = History;
            }
            // to ensure "Harvest" is required (not null)
            if (Harvest == null)
            {
                throw new InvalidDataException("Harvest is a required property for OrderLinks and cannot be null");
            }
            else
            {
                this.Harvest = Harvest;
            }
            // to ensure "SetMerchantInfo" is required (not null)
            if (SetMerchantInfo == null)
            {
                throw new InvalidDataException("SetMerchantInfo is a required property for OrderLinks and cannot be null");
            }
            else
            {
                this.SetMerchantInfo = SetMerchantInfo;
            }
            // to ensure "ClearMerchantInfo" is required (not null)
            if (ClearMerchantInfo == null)
            {
                throw new InvalidDataException("ClearMerchantInfo is a required property for OrderLinks and cannot be null");
            }
            else
            {
                this.ClearMerchantInfo = ClearMerchantInfo;
            }
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public LinksGetOrderLink Self { get; set; }
        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name="history", EmitDefaultValue=false)]
        public LinksGetOrderHistoryLink History { get; set; }
        /// <summary>
        /// Gets or Sets Harvest
        /// </summary>
        [DataMember(Name="harvest", EmitDefaultValue=false)]
        public LinksHarvestOrderLink Harvest { get; set; }
        /// <summary>
        /// Gets or Sets SetMerchantInfo
        /// </summary>
        [DataMember(Name="setMerchantInfo", EmitDefaultValue=false)]
        public LinksSetMerchantOrderInfoLink SetMerchantInfo { get; set; }
        /// <summary>
        /// Gets or Sets ClearMerchantInfo
        /// </summary>
        [DataMember(Name="clearMerchantInfo", EmitDefaultValue=false)]
        public LinksClearMerchantOrderInfoLink ClearMerchantInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  Harvest: ").Append(Harvest).Append("\n");
            sb.Append("  SetMerchantInfo: ").Append(SetMerchantInfo).Append("\n");
            sb.Append("  ClearMerchantInfo: ").Append(ClearMerchantInfo).Append("\n");
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
            return this.Equals(obj as OrderLinks);
        }

        /// <summary>
        /// Returns true if OrderLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.History == other.History ||
                    this.History != null &&
                    this.History.Equals(other.History)
                ) && 
                (
                    this.Harvest == other.Harvest ||
                    this.Harvest != null &&
                    this.Harvest.Equals(other.Harvest)
                ) && 
                (
                    this.SetMerchantInfo == other.SetMerchantInfo ||
                    this.SetMerchantInfo != null &&
                    this.SetMerchantInfo.Equals(other.SetMerchantInfo)
                ) && 
                (
                    this.ClearMerchantInfo == other.ClearMerchantInfo ||
                    this.ClearMerchantInfo != null &&
                    this.ClearMerchantInfo.Equals(other.ClearMerchantInfo)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.History != null)
                    hash = hash * 59 + this.History.GetHashCode();
                if (this.Harvest != null)
                    hash = hash * 59 + this.Harvest.GetHashCode();
                if (this.SetMerchantInfo != null)
                    hash = hash * 59 + this.SetMerchantInfo.GetHashCode();
                if (this.ClearMerchantInfo != null)
                    hash = hash * 59 + this.ClearMerchantInfo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
