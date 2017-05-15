/* 
 * BeezUP API
 *
 * # The REST API of BeezUP system ## Overview The REST APIs provide programmatic access to read and write BeezUP data.  Basically, with this API you will be able to do everything like you were with your browser on https://go.beezup.com !  The main features are: - Register and manage your account - Create and manage and share your stores with your friends/co-workers. - Import your product catalog and schedule the auto importation - Search the channels your want to use - Configure your channels for your catalogs to export your product information:     - cost and general settings     - category and columns mappings     - your will be able to create and manage your custom column     - put in place exlusion filters based on simple conditions on your product data     - override product values     - get product vision for a channel catalog scope - Analyze and optimize your performance of your catalogs on all yours channels with different type of reportings by day, channel, category and by product. - Automatize your optimisation by using rules! - And of course... Manage your orders harvested from all your marketplaces:     - Synchronize your orders in an uniformized way     - Get the available actions and update the order status - ...and more!  ## Authentication credentials The public API with the base path **_/v2/public** have been put in place to give you an entry point to our system for the user registration, login and lost password. The public API does not require any credentials. We give you the some public list of values and public channels for our public commercial web site [www.beezup.com](http://www.beezup.com).  The user API with the base path **_/v2/user** requires a token which is available on this page: https://go.beezup.com/Account/MyAccount  ## Things to keep in mind ### API Rate Limits - The BeezUP REST API is limited to 100 calls/minute.  ### Media type The default media type for requests and responses is application/json. Where noted, some operations support other content types. If no additional content type is mentioned for a specific operation, then the media type is application/json.  ### Required content type The required and default encoding for the request and responses is UTF8.  ### Required date time format All our date time are formatted in ISO 8601 format: 2014-06-24T16:25:00Z.  ### Base URL The Base URL of the BeezUP API Order Management REST API conforms to the following template.  https://api.beezup.com  All URLs returned by the BeezUP API are relative to this base URL, and all requests to the REST API must use this base URL template.  You can test our API on https://api-docs.beezup.com/swagger-ui\\ You can contact us on [gitter, #BeezUP/API](https://gitter.im/beezUP/API) 
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
    /// Describe the conditions of a contract
    /// </summary>
    [DataContract]
    public partial class ContractInfo :  IEquatable<ContractInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractInfo" /> class.
        /// </summary>
        /// <param name="TrialPeriodInMonth">The trial period in month.</param>
        /// <param name="BillingPeriodPercentDiscount">The percent discount related to the billing period.</param>
        /// <param name="DiscountDurationInMonth">The discount duration in month.</param>
        /// <param name="PercentDiscount">The percent of the discount.</param>
        /// <param name="OfferId">OfferId.</param>
        /// <param name="StoreCount">StoreCount.</param>
        /// <param name="StartUtcDate">The start date of your contract.</param>
        /// <param name="CommitmentCalculatedFinishUtcDate">The calculated end date of commitment.</param>
        /// <param name="BillingPeriodInMonth">The billing period in month.</param>
        /// <param name="FixedPrice">The fixed price of your contract.</param>
        /// <param name="OfferName">The offer name based on /offers.</param>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="ContractId">ContractId.</param>
        /// <param name="CommitmentPeriodInMonth">The commitment period in month.</param>
        /// <param name="ClickIncluded">The click included.</param>
        /// <param name="AdditionalClickPrice">Additional click price.</param>
        /// <param name="IpUserCreation">The IP of the user who creates the contract.</param>
        /// <param name="IpUserModification">The IP of the user who modified the contract.</param>
        /// <param name="FixedAndVariableClickInfo">FixedAndVariableClickInfo.</param>
        /// <param name="VariableModelInfo">VariableModelInfo.</param>
        /// <param name="IsCommitmentRenewalAutomatically">Is commitment is automatically renewed.</param>
        /// <param name="DiscountEndUtcDate">The end of your discount.</param>
        /// <param name="IsModifiableContract">Is the contract is modifiable ?.</param>
        public ContractInfo(int? TrialPeriodInMonth = default(int?), double? BillingPeriodPercentDiscount = default(double?), int? DiscountDurationInMonth = default(int?), double? PercentDiscount = default(double?), OfferId OfferId = default(OfferId), StoreCount StoreCount = default(StoreCount), DateTime? StartUtcDate = default(DateTime?), DateTime? CommitmentCalculatedFinishUtcDate = default(DateTime?), int? BillingPeriodInMonth = default(int?), double? FixedPrice = default(double?), string OfferName = default(string), BeezUPCommonCurrencyCode CurrencyCode = default(BeezUPCommonCurrencyCode), ContractId ContractId = default(ContractId), int? CommitmentPeriodInMonth = default(int?), int? ClickIncluded = default(int?), double? AdditionalClickPrice = default(double?), string IpUserCreation = default(string), string IpUserModification = default(string), FixedAndVariableClickModelInfo FixedAndVariableClickInfo = default(FixedAndVariableClickModelInfo), VariableModelInfo VariableModelInfo = default(VariableModelInfo), bool? IsCommitmentRenewalAutomatically = default(bool?), DateTime? DiscountEndUtcDate = default(DateTime?), bool? IsModifiableContract = default(bool?))
        {
            this.TrialPeriodInMonth = TrialPeriodInMonth;
            this.BillingPeriodPercentDiscount = BillingPeriodPercentDiscount;
            this.DiscountDurationInMonth = DiscountDurationInMonth;
            this.PercentDiscount = PercentDiscount;
            this.OfferId = OfferId;
            this.StoreCount = StoreCount;
            this.StartUtcDate = StartUtcDate;
            this.CommitmentCalculatedFinishUtcDate = CommitmentCalculatedFinishUtcDate;
            this.BillingPeriodInMonth = BillingPeriodInMonth;
            this.FixedPrice = FixedPrice;
            this.OfferName = OfferName;
            this.CurrencyCode = CurrencyCode;
            this.ContractId = ContractId;
            this.CommitmentPeriodInMonth = CommitmentPeriodInMonth;
            this.ClickIncluded = ClickIncluded;
            this.AdditionalClickPrice = AdditionalClickPrice;
            this.IpUserCreation = IpUserCreation;
            this.IpUserModification = IpUserModification;
            this.FixedAndVariableClickInfo = FixedAndVariableClickInfo;
            this.VariableModelInfo = VariableModelInfo;
            this.IsCommitmentRenewalAutomatically = IsCommitmentRenewalAutomatically;
            this.DiscountEndUtcDate = DiscountEndUtcDate;
            this.IsModifiableContract = IsModifiableContract;
        }
        
        /// <summary>
        /// The trial period in month
        /// </summary>
        /// <value>The trial period in month</value>
        [DataMember(Name="trialPeriodInMonth", EmitDefaultValue=false)]
        public int? TrialPeriodInMonth { get; set; }
        /// <summary>
        /// The percent discount related to the billing period
        /// </summary>
        /// <value>The percent discount related to the billing period</value>
        [DataMember(Name="billingPeriodPercentDiscount", EmitDefaultValue=false)]
        public double? BillingPeriodPercentDiscount { get; set; }
        /// <summary>
        /// The discount duration in month
        /// </summary>
        /// <value>The discount duration in month</value>
        [DataMember(Name="discountDurationInMonth", EmitDefaultValue=false)]
        public int? DiscountDurationInMonth { get; set; }
        /// <summary>
        /// The percent of the discount
        /// </summary>
        /// <value>The percent of the discount</value>
        [DataMember(Name="percentDiscount", EmitDefaultValue=false)]
        public double? PercentDiscount { get; set; }
        /// <summary>
        /// Gets or Sets OfferId
        /// </summary>
        [DataMember(Name="offerId", EmitDefaultValue=false)]
        public OfferId OfferId { get; set; }
        /// <summary>
        /// Gets or Sets StoreCount
        /// </summary>
        [DataMember(Name="storeCount", EmitDefaultValue=false)]
        public StoreCount StoreCount { get; set; }
        /// <summary>
        /// The start date of your contract
        /// </summary>
        /// <value>The start date of your contract</value>
        [DataMember(Name="startUtcDate", EmitDefaultValue=false)]
        public DateTime? StartUtcDate { get; set; }
        /// <summary>
        /// The calculated end date of commitment
        /// </summary>
        /// <value>The calculated end date of commitment</value>
        [DataMember(Name="commitmentCalculatedFinishUtcDate", EmitDefaultValue=false)]
        public DateTime? CommitmentCalculatedFinishUtcDate { get; set; }
        /// <summary>
        /// The billing period in month
        /// </summary>
        /// <value>The billing period in month</value>
        [DataMember(Name="billingPeriodInMonth", EmitDefaultValue=false)]
        public int? BillingPeriodInMonth { get; set; }
        /// <summary>
        /// The fixed price of your contract
        /// </summary>
        /// <value>The fixed price of your contract</value>
        [DataMember(Name="fixedPrice", EmitDefaultValue=false)]
        public double? FixedPrice { get; set; }
        /// <summary>
        /// The offer name based on /offers
        /// </summary>
        /// <value>The offer name based on /offers</value>
        [DataMember(Name="offerName", EmitDefaultValue=false)]
        public string OfferName { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public BeezUPCommonCurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets ContractId
        /// </summary>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public ContractId ContractId { get; set; }
        /// <summary>
        /// The commitment period in month
        /// </summary>
        /// <value>The commitment period in month</value>
        [DataMember(Name="commitmentPeriodInMonth", EmitDefaultValue=false)]
        public int? CommitmentPeriodInMonth { get; set; }
        /// <summary>
        /// The click included
        /// </summary>
        /// <value>The click included</value>
        [DataMember(Name="clickIncluded", EmitDefaultValue=false)]
        public int? ClickIncluded { get; set; }
        /// <summary>
        /// Additional click price
        /// </summary>
        /// <value>Additional click price</value>
        [DataMember(Name="additionalClickPrice", EmitDefaultValue=false)]
        public double? AdditionalClickPrice { get; set; }
        /// <summary>
        /// The IP of the user who creates the contract
        /// </summary>
        /// <value>The IP of the user who creates the contract</value>
        [DataMember(Name="ipUserCreation", EmitDefaultValue=false)]
        public string IpUserCreation { get; set; }
        /// <summary>
        /// The IP of the user who modified the contract
        /// </summary>
        /// <value>The IP of the user who modified the contract</value>
        [DataMember(Name="ipUserModification", EmitDefaultValue=false)]
        public string IpUserModification { get; set; }
        /// <summary>
        /// Gets or Sets FixedAndVariableClickInfo
        /// </summary>
        [DataMember(Name="fixedAndVariableClickInfo", EmitDefaultValue=false)]
        public FixedAndVariableClickModelInfo FixedAndVariableClickInfo { get; set; }
        /// <summary>
        /// Gets or Sets VariableModelInfo
        /// </summary>
        [DataMember(Name="variableModelInfo", EmitDefaultValue=false)]
        public VariableModelInfo VariableModelInfo { get; set; }
        /// <summary>
        /// Is commitment is automatically renewed
        /// </summary>
        /// <value>Is commitment is automatically renewed</value>
        [DataMember(Name="isCommitmentRenewalAutomatically", EmitDefaultValue=false)]
        public bool? IsCommitmentRenewalAutomatically { get; set; }
        /// <summary>
        /// The end of your discount
        /// </summary>
        /// <value>The end of your discount</value>
        [DataMember(Name="discountEndUtcDate", EmitDefaultValue=false)]
        public DateTime? DiscountEndUtcDate { get; set; }
        /// <summary>
        /// Is the contract is modifiable ?
        /// </summary>
        /// <value>Is the contract is modifiable ?</value>
        [DataMember(Name="isModifiableContract", EmitDefaultValue=false)]
        public bool? IsModifiableContract { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContractInfo {\n");
            sb.Append("  TrialPeriodInMonth: ").Append(TrialPeriodInMonth).Append("\n");
            sb.Append("  BillingPeriodPercentDiscount: ").Append(BillingPeriodPercentDiscount).Append("\n");
            sb.Append("  DiscountDurationInMonth: ").Append(DiscountDurationInMonth).Append("\n");
            sb.Append("  PercentDiscount: ").Append(PercentDiscount).Append("\n");
            sb.Append("  OfferId: ").Append(OfferId).Append("\n");
            sb.Append("  StoreCount: ").Append(StoreCount).Append("\n");
            sb.Append("  StartUtcDate: ").Append(StartUtcDate).Append("\n");
            sb.Append("  CommitmentCalculatedFinishUtcDate: ").Append(CommitmentCalculatedFinishUtcDate).Append("\n");
            sb.Append("  BillingPeriodInMonth: ").Append(BillingPeriodInMonth).Append("\n");
            sb.Append("  FixedPrice: ").Append(FixedPrice).Append("\n");
            sb.Append("  OfferName: ").Append(OfferName).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  CommitmentPeriodInMonth: ").Append(CommitmentPeriodInMonth).Append("\n");
            sb.Append("  ClickIncluded: ").Append(ClickIncluded).Append("\n");
            sb.Append("  AdditionalClickPrice: ").Append(AdditionalClickPrice).Append("\n");
            sb.Append("  IpUserCreation: ").Append(IpUserCreation).Append("\n");
            sb.Append("  IpUserModification: ").Append(IpUserModification).Append("\n");
            sb.Append("  FixedAndVariableClickInfo: ").Append(FixedAndVariableClickInfo).Append("\n");
            sb.Append("  VariableModelInfo: ").Append(VariableModelInfo).Append("\n");
            sb.Append("  IsCommitmentRenewalAutomatically: ").Append(IsCommitmentRenewalAutomatically).Append("\n");
            sb.Append("  DiscountEndUtcDate: ").Append(DiscountEndUtcDate).Append("\n");
            sb.Append("  IsModifiableContract: ").Append(IsModifiableContract).Append("\n");
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
            return this.Equals(obj as ContractInfo);
        }

        /// <summary>
        /// Returns true if ContractInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ContractInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TrialPeriodInMonth == other.TrialPeriodInMonth ||
                    this.TrialPeriodInMonth != null &&
                    this.TrialPeriodInMonth.Equals(other.TrialPeriodInMonth)
                ) && 
                (
                    this.BillingPeriodPercentDiscount == other.BillingPeriodPercentDiscount ||
                    this.BillingPeriodPercentDiscount != null &&
                    this.BillingPeriodPercentDiscount.Equals(other.BillingPeriodPercentDiscount)
                ) && 
                (
                    this.DiscountDurationInMonth == other.DiscountDurationInMonth ||
                    this.DiscountDurationInMonth != null &&
                    this.DiscountDurationInMonth.Equals(other.DiscountDurationInMonth)
                ) && 
                (
                    this.PercentDiscount == other.PercentDiscount ||
                    this.PercentDiscount != null &&
                    this.PercentDiscount.Equals(other.PercentDiscount)
                ) && 
                (
                    this.OfferId == other.OfferId ||
                    this.OfferId != null &&
                    this.OfferId.Equals(other.OfferId)
                ) && 
                (
                    this.StoreCount == other.StoreCount ||
                    this.StoreCount != null &&
                    this.StoreCount.Equals(other.StoreCount)
                ) && 
                (
                    this.StartUtcDate == other.StartUtcDate ||
                    this.StartUtcDate != null &&
                    this.StartUtcDate.Equals(other.StartUtcDate)
                ) && 
                (
                    this.CommitmentCalculatedFinishUtcDate == other.CommitmentCalculatedFinishUtcDate ||
                    this.CommitmentCalculatedFinishUtcDate != null &&
                    this.CommitmentCalculatedFinishUtcDate.Equals(other.CommitmentCalculatedFinishUtcDate)
                ) && 
                (
                    this.BillingPeriodInMonth == other.BillingPeriodInMonth ||
                    this.BillingPeriodInMonth != null &&
                    this.BillingPeriodInMonth.Equals(other.BillingPeriodInMonth)
                ) && 
                (
                    this.FixedPrice == other.FixedPrice ||
                    this.FixedPrice != null &&
                    this.FixedPrice.Equals(other.FixedPrice)
                ) && 
                (
                    this.OfferName == other.OfferName ||
                    this.OfferName != null &&
                    this.OfferName.Equals(other.OfferName)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.ContractId == other.ContractId ||
                    this.ContractId != null &&
                    this.ContractId.Equals(other.ContractId)
                ) && 
                (
                    this.CommitmentPeriodInMonth == other.CommitmentPeriodInMonth ||
                    this.CommitmentPeriodInMonth != null &&
                    this.CommitmentPeriodInMonth.Equals(other.CommitmentPeriodInMonth)
                ) && 
                (
                    this.ClickIncluded == other.ClickIncluded ||
                    this.ClickIncluded != null &&
                    this.ClickIncluded.Equals(other.ClickIncluded)
                ) && 
                (
                    this.AdditionalClickPrice == other.AdditionalClickPrice ||
                    this.AdditionalClickPrice != null &&
                    this.AdditionalClickPrice.Equals(other.AdditionalClickPrice)
                ) && 
                (
                    this.IpUserCreation == other.IpUserCreation ||
                    this.IpUserCreation != null &&
                    this.IpUserCreation.Equals(other.IpUserCreation)
                ) && 
                (
                    this.IpUserModification == other.IpUserModification ||
                    this.IpUserModification != null &&
                    this.IpUserModification.Equals(other.IpUserModification)
                ) && 
                (
                    this.FixedAndVariableClickInfo == other.FixedAndVariableClickInfo ||
                    this.FixedAndVariableClickInfo != null &&
                    this.FixedAndVariableClickInfo.Equals(other.FixedAndVariableClickInfo)
                ) && 
                (
                    this.VariableModelInfo == other.VariableModelInfo ||
                    this.VariableModelInfo != null &&
                    this.VariableModelInfo.Equals(other.VariableModelInfo)
                ) && 
                (
                    this.IsCommitmentRenewalAutomatically == other.IsCommitmentRenewalAutomatically ||
                    this.IsCommitmentRenewalAutomatically != null &&
                    this.IsCommitmentRenewalAutomatically.Equals(other.IsCommitmentRenewalAutomatically)
                ) && 
                (
                    this.DiscountEndUtcDate == other.DiscountEndUtcDate ||
                    this.DiscountEndUtcDate != null &&
                    this.DiscountEndUtcDate.Equals(other.DiscountEndUtcDate)
                ) && 
                (
                    this.IsModifiableContract == other.IsModifiableContract ||
                    this.IsModifiableContract != null &&
                    this.IsModifiableContract.Equals(other.IsModifiableContract)
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
                if (this.TrialPeriodInMonth != null)
                    hash = hash * 59 + this.TrialPeriodInMonth.GetHashCode();
                if (this.BillingPeriodPercentDiscount != null)
                    hash = hash * 59 + this.BillingPeriodPercentDiscount.GetHashCode();
                if (this.DiscountDurationInMonth != null)
                    hash = hash * 59 + this.DiscountDurationInMonth.GetHashCode();
                if (this.PercentDiscount != null)
                    hash = hash * 59 + this.PercentDiscount.GetHashCode();
                if (this.OfferId != null)
                    hash = hash * 59 + this.OfferId.GetHashCode();
                if (this.StoreCount != null)
                    hash = hash * 59 + this.StoreCount.GetHashCode();
                if (this.StartUtcDate != null)
                    hash = hash * 59 + this.StartUtcDate.GetHashCode();
                if (this.CommitmentCalculatedFinishUtcDate != null)
                    hash = hash * 59 + this.CommitmentCalculatedFinishUtcDate.GetHashCode();
                if (this.BillingPeriodInMonth != null)
                    hash = hash * 59 + this.BillingPeriodInMonth.GetHashCode();
                if (this.FixedPrice != null)
                    hash = hash * 59 + this.FixedPrice.GetHashCode();
                if (this.OfferName != null)
                    hash = hash * 59 + this.OfferName.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.ContractId != null)
                    hash = hash * 59 + this.ContractId.GetHashCode();
                if (this.CommitmentPeriodInMonth != null)
                    hash = hash * 59 + this.CommitmentPeriodInMonth.GetHashCode();
                if (this.ClickIncluded != null)
                    hash = hash * 59 + this.ClickIncluded.GetHashCode();
                if (this.AdditionalClickPrice != null)
                    hash = hash * 59 + this.AdditionalClickPrice.GetHashCode();
                if (this.IpUserCreation != null)
                    hash = hash * 59 + this.IpUserCreation.GetHashCode();
                if (this.IpUserModification != null)
                    hash = hash * 59 + this.IpUserModification.GetHashCode();
                if (this.FixedAndVariableClickInfo != null)
                    hash = hash * 59 + this.FixedAndVariableClickInfo.GetHashCode();
                if (this.VariableModelInfo != null)
                    hash = hash * 59 + this.VariableModelInfo.GetHashCode();
                if (this.IsCommitmentRenewalAutomatically != null)
                    hash = hash * 59 + this.IsCommitmentRenewalAutomatically.GetHashCode();
                if (this.DiscountEndUtcDate != null)
                    hash = hash * 59 + this.DiscountEndUtcDate.GetHashCode();
                if (this.IsModifiableContract != null)
                    hash = hash * 59 + this.IsModifiableContract.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
