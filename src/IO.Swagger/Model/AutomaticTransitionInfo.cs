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
    /// AutomaticTransitionInfo
    /// </summary>
    [DataContract]
    public partial class AutomaticTransitionInfo :  IEquatable<AutomaticTransitionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticTransitionInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutomaticTransitionInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticTransitionInfo" /> class.
        /// </summary>
        /// <param name="MarketplaceTechnicalCode">MarketplaceTechnicalCode (required).</param>
        /// <param name="AccountId">AccountId (required).</param>
        /// <param name="OrderStatusTransitionId">OrderStatusTransitionId (required).</param>
        /// <param name="Enabled">Enabled (required).</param>
        /// <param name="MarketplaceBusinessCode">MarketplaceBusinessCode (required).</param>
        /// <param name="BeezUPOrderStatus">BeezUPOrderStatus (required).</param>
        /// <param name="BusinessOperationType">BusinessOperationType (required).</param>
        /// <param name="Links">Links.</param>
        public AutomaticTransitionInfo(BeezUPCommonMarketplaceTechnicalCode MarketplaceTechnicalCode = default(BeezUPCommonMarketplaceTechnicalCode), AccountId AccountId = default(AccountId), int? OrderStatusTransitionId = default(int?), bool? Enabled = default(bool?), BeezUPCommonMarketplaceBusinessCode MarketplaceBusinessCode = default(BeezUPCommonMarketplaceBusinessCode), BeezUPOrderStatus BeezUPOrderStatus = default(BeezUPOrderStatus), BusinessOperationType BusinessOperationType = default(BusinessOperationType), AutomaticTransitionInfoLinks Links = default(AutomaticTransitionInfoLinks))
        {
            // to ensure "MarketplaceTechnicalCode" is required (not null)
            if (MarketplaceTechnicalCode == null)
            {
                throw new InvalidDataException("MarketplaceTechnicalCode is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.MarketplaceTechnicalCode = MarketplaceTechnicalCode;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "OrderStatusTransitionId" is required (not null)
            if (OrderStatusTransitionId == null)
            {
                throw new InvalidDataException("OrderStatusTransitionId is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.OrderStatusTransitionId = OrderStatusTransitionId;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            // to ensure "MarketplaceBusinessCode" is required (not null)
            if (MarketplaceBusinessCode == null)
            {
                throw new InvalidDataException("MarketplaceBusinessCode is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.MarketplaceBusinessCode = MarketplaceBusinessCode;
            }
            // to ensure "BeezUPOrderStatus" is required (not null)
            if (BeezUPOrderStatus == null)
            {
                throw new InvalidDataException("BeezUPOrderStatus is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.BeezUPOrderStatus = BeezUPOrderStatus;
            }
            // to ensure "BusinessOperationType" is required (not null)
            if (BusinessOperationType == null)
            {
                throw new InvalidDataException("BusinessOperationType is a required property for AutomaticTransitionInfo and cannot be null");
            }
            else
            {
                this.BusinessOperationType = BusinessOperationType;
            }
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets MarketplaceTechnicalCode
        /// </summary>
        [DataMember(Name="marketplaceTechnicalCode", EmitDefaultValue=false)]
        public BeezUPCommonMarketplaceTechnicalCode MarketplaceTechnicalCode { get; set; }
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public AccountId AccountId { get; set; }
        /// <summary>
        /// Gets or Sets OrderStatusTransitionId
        /// </summary>
        [DataMember(Name="orderStatusTransitionId", EmitDefaultValue=false)]
        public int? OrderStatusTransitionId { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets MarketplaceBusinessCode
        /// </summary>
        [DataMember(Name="marketplaceBusinessCode", EmitDefaultValue=false)]
        public BeezUPCommonMarketplaceBusinessCode MarketplaceBusinessCode { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPOrderStatus
        /// </summary>
        [DataMember(Name="beezUPOrderStatus", EmitDefaultValue=false)]
        public BeezUPOrderStatus BeezUPOrderStatus { get; set; }
        /// <summary>
        /// Gets or Sets BusinessOperationType
        /// </summary>
        [DataMember(Name="businessOperationType", EmitDefaultValue=false)]
        public BusinessOperationType BusinessOperationType { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public AutomaticTransitionInfoLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticTransitionInfo {\n");
            sb.Append("  MarketplaceTechnicalCode: ").Append(MarketplaceTechnicalCode).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  OrderStatusTransitionId: ").Append(OrderStatusTransitionId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MarketplaceBusinessCode: ").Append(MarketplaceBusinessCode).Append("\n");
            sb.Append("  BeezUPOrderStatus: ").Append(BeezUPOrderStatus).Append("\n");
            sb.Append("  BusinessOperationType: ").Append(BusinessOperationType).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as AutomaticTransitionInfo);
        }

        /// <summary>
        /// Returns true if AutomaticTransitionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AutomaticTransitionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticTransitionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MarketplaceTechnicalCode == other.MarketplaceTechnicalCode ||
                    this.MarketplaceTechnicalCode != null &&
                    this.MarketplaceTechnicalCode.Equals(other.MarketplaceTechnicalCode)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.OrderStatusTransitionId == other.OrderStatusTransitionId ||
                    this.OrderStatusTransitionId != null &&
                    this.OrderStatusTransitionId.Equals(other.OrderStatusTransitionId)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.MarketplaceBusinessCode == other.MarketplaceBusinessCode ||
                    this.MarketplaceBusinessCode != null &&
                    this.MarketplaceBusinessCode.Equals(other.MarketplaceBusinessCode)
                ) && 
                (
                    this.BeezUPOrderStatus == other.BeezUPOrderStatus ||
                    this.BeezUPOrderStatus != null &&
                    this.BeezUPOrderStatus.Equals(other.BeezUPOrderStatus)
                ) && 
                (
                    this.BusinessOperationType == other.BusinessOperationType ||
                    this.BusinessOperationType != null &&
                    this.BusinessOperationType.Equals(other.BusinessOperationType)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.MarketplaceTechnicalCode != null)
                    hash = hash * 59 + this.MarketplaceTechnicalCode.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.OrderStatusTransitionId != null)
                    hash = hash * 59 + this.OrderStatusTransitionId.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.MarketplaceBusinessCode != null)
                    hash = hash * 59 + this.MarketplaceBusinessCode.GetHashCode();
                if (this.BeezUPOrderStatus != null)
                    hash = hash * 59 + this.BeezUPOrderStatus.GetHashCode();
                if (this.BusinessOperationType != null)
                    hash = hash * 59 + this.BusinessOperationType.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
