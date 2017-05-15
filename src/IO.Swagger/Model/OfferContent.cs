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
    /// OfferContent
    /// </summary>
    [DataContract]
    public partial class OfferContent :  IEquatable<OfferContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferContent" /> class.
        /// </summary>
        /// <param name="PreviousFixPeriodInvoiceProrataInfo">PreviousFixPeriodInvoiceProrataInfo (required).</param>
        /// <param name="ContractBillingPeriodInfo">ContractBillingPeriodInfo (required).</param>
        /// <param name="ContractClickInfo">ContractClickInfo (required).</param>
        /// <param name="ContractCommitmentInfo">ContractCommitmentInfo (required).</param>
        /// <param name="ContractDiscountInfo">ContractDiscountInfo (required).</param>
        /// <param name="ContractMoneyInfo">ContractMoneyInfo (required).</param>
        /// <param name="ContractStoreInfo">ContractStoreInfo (required).</param>
        /// <param name="ContractBonusInfo">ContractBonusInfo (required).</param>
        /// <param name="ContractTerminationReasonType">ContractTerminationReasonType.</param>
        /// <param name="ContractTerminationReason">ContractTerminationReason.</param>
        /// <param name="NotifyVatExemption">Internal usage: Indicates if we have to notify you about VAT exemption. (required).</param>
        public OfferContent(PreviousFixPeriodInvoiceProrataInfo PreviousFixPeriodInvoiceProrataInfo = default(PreviousFixPeriodInvoiceProrataInfo), ContractBillingPeriodInfo ContractBillingPeriodInfo = default(ContractBillingPeriodInfo), ContractClickInfo ContractClickInfo = default(ContractClickInfo), ContractCommitmentInfo ContractCommitmentInfo = default(ContractCommitmentInfo), ContractDiscountInfo ContractDiscountInfo = default(ContractDiscountInfo), ContractMoneyInfo ContractMoneyInfo = default(ContractMoneyInfo), ContractStoreInfo ContractStoreInfo = default(ContractStoreInfo), ContractBonusInfo ContractBonusInfo = default(ContractBonusInfo), ContractTerminationReasonType ContractTerminationReasonType = default(ContractTerminationReasonType), ContractTerminationReason ContractTerminationReason = default(ContractTerminationReason), bool? NotifyVatExemption = default(bool?))
        {
            // to ensure "PreviousFixPeriodInvoiceProrataInfo" is required (not null)
            if (PreviousFixPeriodInvoiceProrataInfo == null)
            {
                throw new InvalidDataException("PreviousFixPeriodInvoiceProrataInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.PreviousFixPeriodInvoiceProrataInfo = PreviousFixPeriodInvoiceProrataInfo;
            }
            // to ensure "ContractBillingPeriodInfo" is required (not null)
            if (ContractBillingPeriodInfo == null)
            {
                throw new InvalidDataException("ContractBillingPeriodInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractBillingPeriodInfo = ContractBillingPeriodInfo;
            }
            // to ensure "ContractClickInfo" is required (not null)
            if (ContractClickInfo == null)
            {
                throw new InvalidDataException("ContractClickInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractClickInfo = ContractClickInfo;
            }
            // to ensure "ContractCommitmentInfo" is required (not null)
            if (ContractCommitmentInfo == null)
            {
                throw new InvalidDataException("ContractCommitmentInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractCommitmentInfo = ContractCommitmentInfo;
            }
            // to ensure "ContractDiscountInfo" is required (not null)
            if (ContractDiscountInfo == null)
            {
                throw new InvalidDataException("ContractDiscountInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractDiscountInfo = ContractDiscountInfo;
            }
            // to ensure "ContractMoneyInfo" is required (not null)
            if (ContractMoneyInfo == null)
            {
                throw new InvalidDataException("ContractMoneyInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractMoneyInfo = ContractMoneyInfo;
            }
            // to ensure "ContractStoreInfo" is required (not null)
            if (ContractStoreInfo == null)
            {
                throw new InvalidDataException("ContractStoreInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractStoreInfo = ContractStoreInfo;
            }
            // to ensure "ContractBonusInfo" is required (not null)
            if (ContractBonusInfo == null)
            {
                throw new InvalidDataException("ContractBonusInfo is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.ContractBonusInfo = ContractBonusInfo;
            }
            // to ensure "NotifyVatExemption" is required (not null)
            if (NotifyVatExemption == null)
            {
                throw new InvalidDataException("NotifyVatExemption is a required property for OfferContent and cannot be null");
            }
            else
            {
                this.NotifyVatExemption = NotifyVatExemption;
            }
            this.ContractTerminationReasonType = ContractTerminationReasonType;
            this.ContractTerminationReason = ContractTerminationReason;
        }
        
        /// <summary>
        /// Gets or Sets PreviousFixPeriodInvoiceProrataInfo
        /// </summary>
        [DataMember(Name="previousFixPeriodInvoiceProrataInfo", EmitDefaultValue=false)]
        public PreviousFixPeriodInvoiceProrataInfo PreviousFixPeriodInvoiceProrataInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractBillingPeriodInfo
        /// </summary>
        [DataMember(Name="contractBillingPeriodInfo", EmitDefaultValue=false)]
        public ContractBillingPeriodInfo ContractBillingPeriodInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractClickInfo
        /// </summary>
        [DataMember(Name="contractClickInfo", EmitDefaultValue=false)]
        public ContractClickInfo ContractClickInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractCommitmentInfo
        /// </summary>
        [DataMember(Name="contractCommitmentInfo", EmitDefaultValue=false)]
        public ContractCommitmentInfo ContractCommitmentInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractDiscountInfo
        /// </summary>
        [DataMember(Name="contractDiscountInfo", EmitDefaultValue=false)]
        public ContractDiscountInfo ContractDiscountInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractMoneyInfo
        /// </summary>
        [DataMember(Name="contractMoneyInfo", EmitDefaultValue=false)]
        public ContractMoneyInfo ContractMoneyInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractStoreInfo
        /// </summary>
        [DataMember(Name="contractStoreInfo", EmitDefaultValue=false)]
        public ContractStoreInfo ContractStoreInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractBonusInfo
        /// </summary>
        [DataMember(Name="contractBonusInfo", EmitDefaultValue=false)]
        public ContractBonusInfo ContractBonusInfo { get; set; }
        /// <summary>
        /// Gets or Sets ContractTerminationReasonType
        /// </summary>
        [DataMember(Name="contractTerminationReasonType", EmitDefaultValue=false)]
        public ContractTerminationReasonType ContractTerminationReasonType { get; set; }
        /// <summary>
        /// Gets or Sets ContractTerminationReason
        /// </summary>
        [DataMember(Name="contractTerminationReason", EmitDefaultValue=false)]
        public ContractTerminationReason ContractTerminationReason { get; set; }
        /// <summary>
        /// Internal usage: Indicates if we have to notify you about VAT exemption.
        /// </summary>
        /// <value>Internal usage: Indicates if we have to notify you about VAT exemption.</value>
        [DataMember(Name="notifyVatExemption", EmitDefaultValue=false)]
        public bool? NotifyVatExemption { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferContent {\n");
            sb.Append("  PreviousFixPeriodInvoiceProrataInfo: ").Append(PreviousFixPeriodInvoiceProrataInfo).Append("\n");
            sb.Append("  ContractBillingPeriodInfo: ").Append(ContractBillingPeriodInfo).Append("\n");
            sb.Append("  ContractClickInfo: ").Append(ContractClickInfo).Append("\n");
            sb.Append("  ContractCommitmentInfo: ").Append(ContractCommitmentInfo).Append("\n");
            sb.Append("  ContractDiscountInfo: ").Append(ContractDiscountInfo).Append("\n");
            sb.Append("  ContractMoneyInfo: ").Append(ContractMoneyInfo).Append("\n");
            sb.Append("  ContractStoreInfo: ").Append(ContractStoreInfo).Append("\n");
            sb.Append("  ContractBonusInfo: ").Append(ContractBonusInfo).Append("\n");
            sb.Append("  ContractTerminationReasonType: ").Append(ContractTerminationReasonType).Append("\n");
            sb.Append("  ContractTerminationReason: ").Append(ContractTerminationReason).Append("\n");
            sb.Append("  NotifyVatExemption: ").Append(NotifyVatExemption).Append("\n");
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
            return this.Equals(obj as OfferContent);
        }

        /// <summary>
        /// Returns true if OfferContent instances are equal
        /// </summary>
        /// <param name="other">Instance of OfferContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreviousFixPeriodInvoiceProrataInfo == other.PreviousFixPeriodInvoiceProrataInfo ||
                    this.PreviousFixPeriodInvoiceProrataInfo != null &&
                    this.PreviousFixPeriodInvoiceProrataInfo.Equals(other.PreviousFixPeriodInvoiceProrataInfo)
                ) && 
                (
                    this.ContractBillingPeriodInfo == other.ContractBillingPeriodInfo ||
                    this.ContractBillingPeriodInfo != null &&
                    this.ContractBillingPeriodInfo.Equals(other.ContractBillingPeriodInfo)
                ) && 
                (
                    this.ContractClickInfo == other.ContractClickInfo ||
                    this.ContractClickInfo != null &&
                    this.ContractClickInfo.Equals(other.ContractClickInfo)
                ) && 
                (
                    this.ContractCommitmentInfo == other.ContractCommitmentInfo ||
                    this.ContractCommitmentInfo != null &&
                    this.ContractCommitmentInfo.Equals(other.ContractCommitmentInfo)
                ) && 
                (
                    this.ContractDiscountInfo == other.ContractDiscountInfo ||
                    this.ContractDiscountInfo != null &&
                    this.ContractDiscountInfo.Equals(other.ContractDiscountInfo)
                ) && 
                (
                    this.ContractMoneyInfo == other.ContractMoneyInfo ||
                    this.ContractMoneyInfo != null &&
                    this.ContractMoneyInfo.Equals(other.ContractMoneyInfo)
                ) && 
                (
                    this.ContractStoreInfo == other.ContractStoreInfo ||
                    this.ContractStoreInfo != null &&
                    this.ContractStoreInfo.Equals(other.ContractStoreInfo)
                ) && 
                (
                    this.ContractBonusInfo == other.ContractBonusInfo ||
                    this.ContractBonusInfo != null &&
                    this.ContractBonusInfo.Equals(other.ContractBonusInfo)
                ) && 
                (
                    this.ContractTerminationReasonType == other.ContractTerminationReasonType ||
                    this.ContractTerminationReasonType != null &&
                    this.ContractTerminationReasonType.Equals(other.ContractTerminationReasonType)
                ) && 
                (
                    this.ContractTerminationReason == other.ContractTerminationReason ||
                    this.ContractTerminationReason != null &&
                    this.ContractTerminationReason.Equals(other.ContractTerminationReason)
                ) && 
                (
                    this.NotifyVatExemption == other.NotifyVatExemption ||
                    this.NotifyVatExemption != null &&
                    this.NotifyVatExemption.Equals(other.NotifyVatExemption)
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
                if (this.PreviousFixPeriodInvoiceProrataInfo != null)
                    hash = hash * 59 + this.PreviousFixPeriodInvoiceProrataInfo.GetHashCode();
                if (this.ContractBillingPeriodInfo != null)
                    hash = hash * 59 + this.ContractBillingPeriodInfo.GetHashCode();
                if (this.ContractClickInfo != null)
                    hash = hash * 59 + this.ContractClickInfo.GetHashCode();
                if (this.ContractCommitmentInfo != null)
                    hash = hash * 59 + this.ContractCommitmentInfo.GetHashCode();
                if (this.ContractDiscountInfo != null)
                    hash = hash * 59 + this.ContractDiscountInfo.GetHashCode();
                if (this.ContractMoneyInfo != null)
                    hash = hash * 59 + this.ContractMoneyInfo.GetHashCode();
                if (this.ContractStoreInfo != null)
                    hash = hash * 59 + this.ContractStoreInfo.GetHashCode();
                if (this.ContractBonusInfo != null)
                    hash = hash * 59 + this.ContractBonusInfo.GetHashCode();
                if (this.ContractTerminationReasonType != null)
                    hash = hash * 59 + this.ContractTerminationReasonType.GetHashCode();
                if (this.ContractTerminationReason != null)
                    hash = hash * 59 + this.ContractTerminationReason.GetHashCode();
                if (this.NotifyVatExemption != null)
                    hash = hash * 59 + this.NotifyVatExemption.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
