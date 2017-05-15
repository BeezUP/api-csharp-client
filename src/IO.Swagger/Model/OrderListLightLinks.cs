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
    /// OrderListLightLinks
    /// </summary>
    [DataContract]
    public partial class OrderListLightLinks :  IEquatable<OrderListLightLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderListLightLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderListLightLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderListLightLinks" /> class.
        /// </summary>
        /// <param name="Harvest">Harvest (required).</param>
        /// <param name="SetMerchantInfos">SetMerchantInfos (required).</param>
        /// <param name="ClearMerchantInfos">ClearMerchantInfos (required).</param>
        /// <param name="Export">Export (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="Self">Self (required).</param>
        public OrderListLightLinks(LinksHarvestAllLink Harvest = default(LinksHarvestAllLink), LinksSetMerchantOrderInfoListLink SetMerchantInfos = default(LinksSetMerchantOrderInfoListLink), LinksClearMerchantOrderInfoListLink ClearMerchantInfos = default(LinksClearMerchantOrderInfoListLink), LinksExportOrdersLink Export = default(LinksExportOrdersLink), LinksGetMarketplaceAccountsSynchronizationLink Status = default(LinksGetMarketplaceAccountsSynchronizationLink), LinksGetOrderListLightLink Self = default(LinksGetOrderListLightLink))
        {
            // to ensure "Harvest" is required (not null)
            if (Harvest == null)
            {
                throw new InvalidDataException("Harvest is a required property for OrderListLightLinks and cannot be null");
            }
            else
            {
                this.Harvest = Harvest;
            }
            // to ensure "SetMerchantInfos" is required (not null)
            if (SetMerchantInfos == null)
            {
                throw new InvalidDataException("SetMerchantInfos is a required property for OrderListLightLinks and cannot be null");
            }
            else
            {
                this.SetMerchantInfos = SetMerchantInfos;
            }
            // to ensure "ClearMerchantInfos" is required (not null)
            if (ClearMerchantInfos == null)
            {
                throw new InvalidDataException("ClearMerchantInfos is a required property for OrderListLightLinks and cannot be null");
            }
            else
            {
                this.ClearMerchantInfos = ClearMerchantInfos;
            }
            // to ensure "Export" is required (not null)
            if (Export == null)
            {
                throw new InvalidDataException("Export is a required property for OrderListLightLinks and cannot be null");
            }
            else
            {
                this.Export = Export;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for OrderListLightLinks and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Self" is required (not null)
            if (Self == null)
            {
                throw new InvalidDataException("Self is a required property for OrderListLightLinks and cannot be null");
            }
            else
            {
                this.Self = Self;
            }
        }
        
        /// <summary>
        /// Gets or Sets Harvest
        /// </summary>
        [DataMember(Name="harvest", EmitDefaultValue=false)]
        public LinksHarvestAllLink Harvest { get; set; }
        /// <summary>
        /// Gets or Sets SetMerchantInfos
        /// </summary>
        [DataMember(Name="setMerchantInfos", EmitDefaultValue=false)]
        public LinksSetMerchantOrderInfoListLink SetMerchantInfos { get; set; }
        /// <summary>
        /// Gets or Sets ClearMerchantInfos
        /// </summary>
        [DataMember(Name="clearMerchantInfos", EmitDefaultValue=false)]
        public LinksClearMerchantOrderInfoListLink ClearMerchantInfos { get; set; }
        /// <summary>
        /// Gets or Sets Export
        /// </summary>
        [DataMember(Name="export", EmitDefaultValue=false)]
        public LinksExportOrdersLink Export { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public LinksGetMarketplaceAccountsSynchronizationLink Status { get; set; }
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public LinksGetOrderListLightLink Self { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderListLightLinks {\n");
            sb.Append("  Harvest: ").Append(Harvest).Append("\n");
            sb.Append("  SetMerchantInfos: ").Append(SetMerchantInfos).Append("\n");
            sb.Append("  ClearMerchantInfos: ").Append(ClearMerchantInfos).Append("\n");
            sb.Append("  Export: ").Append(Export).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(obj as OrderListLightLinks);
        }

        /// <summary>
        /// Returns true if OrderListLightLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderListLightLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderListLightLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Harvest == other.Harvest ||
                    this.Harvest != null &&
                    this.Harvest.Equals(other.Harvest)
                ) && 
                (
                    this.SetMerchantInfos == other.SetMerchantInfos ||
                    this.SetMerchantInfos != null &&
                    this.SetMerchantInfos.Equals(other.SetMerchantInfos)
                ) && 
                (
                    this.ClearMerchantInfos == other.ClearMerchantInfos ||
                    this.ClearMerchantInfos != null &&
                    this.ClearMerchantInfos.Equals(other.ClearMerchantInfos)
                ) && 
                (
                    this.Export == other.Export ||
                    this.Export != null &&
                    this.Export.Equals(other.Export)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
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
                if (this.Harvest != null)
                    hash = hash * 59 + this.Harvest.GetHashCode();
                if (this.SetMerchantInfos != null)
                    hash = hash * 59 + this.SetMerchantInfos.GetHashCode();
                if (this.ClearMerchantInfos != null)
                    hash = hash * 59 + this.ClearMerchantInfos.GetHashCode();
                if (this.Export != null)
                    hash = hash * 59 + this.Export.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
