/* 
 * BeezUP API
 *
 * This is the RESTful API of BeezUP which allows you to manage everything related to BeezUP
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
    /// Describe the basic information related to an order. All properties with the prefix order_ are translated in the list of values /user/lov/OrderMetaInfoOrderDetails
    /// </summary>
    [DataContract]
    public partial class OrderHeader :  IEquatable<OrderHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderHeader" /> class.
        /// </summary>
        /// <param name="MarketplaceTechnicalCode">MarketplaceTechnicalCode (required).</param>
        /// <param name="AccountId">AccountId (required).</param>
        /// <param name="BeezUPOrderId">BeezUPOrderId (required).</param>
        /// <param name="BeezUPOrderUrl">BeezUPOrderUrl.</param>
        /// <param name="MarketplaceBusinessCode">MarketplaceBusinessCode (required).</param>
        /// <param name="OrderMarketplaceOrderId">OrderMarketplaceOrderId (required).</param>
        /// <param name="OrderStatusBeezUPOrderStatus">OrderStatusBeezUPOrderStatus (required).</param>
        /// <param name="OrderStatusMarketplaceOrderStatus">OrderStatusMarketplaceOrderStatus.</param>
        /// <param name="OrderMerchantOrderId">OrderMerchantOrderId.</param>
        /// <param name="OrderMerchantECommerceSoftwareName">OrderMerchantECommerceSoftwareName.</param>
        /// <param name="OrderMerchantECommerceSoftwareVersion">OrderMerchantECommerceSoftwareVersion.</param>
        /// <param name="OrderPurchaseUtcDate">The purchase date of this order (required).</param>
        /// <param name="OrderLastModificationUtcDate">The last modification UTC date done by BeezUP of this order. (required).</param>
        /// <param name="OrderMarketplaceLastModificationUtcDate">The last modification UTC date done by the marketplace on this order. (required).</param>
        /// <param name="OrderBuyerName">OrderBuyerName.</param>
        /// <param name="OrderTotalPrice">The total price of this order (corresponding to the amount paid by the customer).</param>
        /// <param name="OrderCurrencyCode">OrderCurrencyCode.</param>
        /// <param name="Processing">Processing (required).</param>
        /// <param name="ETag">ETag value to identify the order. For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (required).</param>
        /// <param name="Links">Links (required).</param>
        public OrderHeader(MarketplaceTechnicalCode MarketplaceTechnicalCode = default(MarketplaceTechnicalCode), AccountId AccountId = default(AccountId), BeezUPOrderId BeezUPOrderId = default(BeezUPOrderId), BeezUPCommonHttpUrl BeezUPOrderUrl = default(BeezUPCommonHttpUrl), MarketplaceBusinessCode MarketplaceBusinessCode = default(MarketplaceBusinessCode), MarketplaceOrderId OrderMarketplaceOrderId = default(MarketplaceOrderId), BeezUPOrderStatus OrderStatusBeezUPOrderStatus = default(BeezUPOrderStatus), MarketplaceOrderStatus OrderStatusMarketplaceOrderStatus = default(MarketplaceOrderStatus), OrderMerchantOrderId OrderMerchantOrderId = default(OrderMerchantOrderId), OrderMerchantECommerceSoftwareName OrderMerchantECommerceSoftwareName = default(OrderMerchantECommerceSoftwareName), OrderMerchantECommerceSoftwareVersion OrderMerchantECommerceSoftwareVersion = default(OrderMerchantECommerceSoftwareVersion), DateTime? OrderPurchaseUtcDate = default(DateTime?), DateTime? OrderLastModificationUtcDate = default(DateTime?), DateTime? OrderMarketplaceLastModificationUtcDate = default(DateTime?), OrderBuyerName OrderBuyerName = default(OrderBuyerName), decimal? OrderTotalPrice = default(decimal?), BeezUPCommonCurrencyCode OrderCurrencyCode = default(BeezUPCommonCurrencyCode), Processing Processing = default(Processing), string ETag = default(string), List<BeezUPCommonLink2> Links = default(List<BeezUPCommonLink2>))
        {
            // to ensure "MarketplaceTechnicalCode" is required (not null)
            if (MarketplaceTechnicalCode == null)
            {
                throw new InvalidDataException("MarketplaceTechnicalCode is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.MarketplaceTechnicalCode = MarketplaceTechnicalCode;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "BeezUPOrderId" is required (not null)
            if (BeezUPOrderId == null)
            {
                throw new InvalidDataException("BeezUPOrderId is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.BeezUPOrderId = BeezUPOrderId;
            }
            // to ensure "MarketplaceBusinessCode" is required (not null)
            if (MarketplaceBusinessCode == null)
            {
                throw new InvalidDataException("MarketplaceBusinessCode is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.MarketplaceBusinessCode = MarketplaceBusinessCode;
            }
            // to ensure "OrderMarketplaceOrderId" is required (not null)
            if (OrderMarketplaceOrderId == null)
            {
                throw new InvalidDataException("OrderMarketplaceOrderId is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.OrderMarketplaceOrderId = OrderMarketplaceOrderId;
            }
            // to ensure "OrderStatusBeezUPOrderStatus" is required (not null)
            if (OrderStatusBeezUPOrderStatus == null)
            {
                throw new InvalidDataException("OrderStatusBeezUPOrderStatus is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.OrderStatusBeezUPOrderStatus = OrderStatusBeezUPOrderStatus;
            }
            // to ensure "OrderPurchaseUtcDate" is required (not null)
            if (OrderPurchaseUtcDate == null)
            {
                throw new InvalidDataException("OrderPurchaseUtcDate is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.OrderPurchaseUtcDate = OrderPurchaseUtcDate;
            }
            // to ensure "OrderLastModificationUtcDate" is required (not null)
            if (OrderLastModificationUtcDate == null)
            {
                throw new InvalidDataException("OrderLastModificationUtcDate is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.OrderLastModificationUtcDate = OrderLastModificationUtcDate;
            }
            // to ensure "OrderMarketplaceLastModificationUtcDate" is required (not null)
            if (OrderMarketplaceLastModificationUtcDate == null)
            {
                throw new InvalidDataException("OrderMarketplaceLastModificationUtcDate is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.OrderMarketplaceLastModificationUtcDate = OrderMarketplaceLastModificationUtcDate;
            }
            // to ensure "Processing" is required (not null)
            if (Processing == null)
            {
                throw new InvalidDataException("Processing is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.Processing = Processing;
            }
            // to ensure "ETag" is required (not null)
            if (ETag == null)
            {
                throw new InvalidDataException("ETag is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.ETag = ETag;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for OrderHeader and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this.BeezUPOrderUrl = BeezUPOrderUrl;
            this.OrderStatusMarketplaceOrderStatus = OrderStatusMarketplaceOrderStatus;
            this.OrderMerchantOrderId = OrderMerchantOrderId;
            this.OrderMerchantECommerceSoftwareName = OrderMerchantECommerceSoftwareName;
            this.OrderMerchantECommerceSoftwareVersion = OrderMerchantECommerceSoftwareVersion;
            this.OrderBuyerName = OrderBuyerName;
            this.OrderTotalPrice = OrderTotalPrice;
            this.OrderCurrencyCode = OrderCurrencyCode;
        }
        
        /// <summary>
        /// Gets or Sets MarketplaceTechnicalCode
        /// </summary>
        [DataMember(Name="marketplaceTechnicalCode", EmitDefaultValue=false)]
        public MarketplaceTechnicalCode MarketplaceTechnicalCode { get; set; }
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public AccountId AccountId { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPOrderId
        /// </summary>
        [DataMember(Name="beezUPOrderId", EmitDefaultValue=false)]
        public BeezUPOrderId BeezUPOrderId { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPOrderUrl
        /// </summary>
        [DataMember(Name="beezUPOrderUrl", EmitDefaultValue=false)]
        public BeezUPCommonHttpUrl BeezUPOrderUrl { get; set; }
        /// <summary>
        /// Gets or Sets MarketplaceBusinessCode
        /// </summary>
        [DataMember(Name="marketplaceBusinessCode", EmitDefaultValue=false)]
        public MarketplaceBusinessCode MarketplaceBusinessCode { get; set; }
        /// <summary>
        /// Gets or Sets OrderMarketplaceOrderId
        /// </summary>
        [DataMember(Name="order_MarketplaceOrderId", EmitDefaultValue=false)]
        public MarketplaceOrderId OrderMarketplaceOrderId { get; set; }
        /// <summary>
        /// Gets or Sets OrderStatusBeezUPOrderStatus
        /// </summary>
        [DataMember(Name="order_Status_BeezUPOrderStatus", EmitDefaultValue=false)]
        public BeezUPOrderStatus OrderStatusBeezUPOrderStatus { get; set; }
        /// <summary>
        /// Gets or Sets OrderStatusMarketplaceOrderStatus
        /// </summary>
        [DataMember(Name="order_Status_MarketplaceOrderStatus", EmitDefaultValue=false)]
        public MarketplaceOrderStatus OrderStatusMarketplaceOrderStatus { get; set; }
        /// <summary>
        /// Gets or Sets OrderMerchantOrderId
        /// </summary>
        [DataMember(Name="order_MerchantOrderId", EmitDefaultValue=false)]
        public OrderMerchantOrderId OrderMerchantOrderId { get; set; }
        /// <summary>
        /// Gets or Sets OrderMerchantECommerceSoftwareName
        /// </summary>
        [DataMember(Name="order_MerchantECommerceSoftwareName", EmitDefaultValue=false)]
        public OrderMerchantECommerceSoftwareName OrderMerchantECommerceSoftwareName { get; set; }
        /// <summary>
        /// Gets or Sets OrderMerchantECommerceSoftwareVersion
        /// </summary>
        [DataMember(Name="order_MerchantECommerceSoftwareVersion", EmitDefaultValue=false)]
        public OrderMerchantECommerceSoftwareVersion OrderMerchantECommerceSoftwareVersion { get; set; }
        /// <summary>
        /// The purchase date of this order
        /// </summary>
        /// <value>The purchase date of this order</value>
        [DataMember(Name="order_PurchaseUtcDate", EmitDefaultValue=false)]
        public DateTime? OrderPurchaseUtcDate { get; set; }
        /// <summary>
        /// The last modification UTC date done by BeezUP of this order.
        /// </summary>
        /// <value>The last modification UTC date done by BeezUP of this order.</value>
        [DataMember(Name="order_LastModificationUtcDate", EmitDefaultValue=false)]
        public DateTime? OrderLastModificationUtcDate { get; set; }
        /// <summary>
        /// The last modification UTC date done by the marketplace on this order.
        /// </summary>
        /// <value>The last modification UTC date done by the marketplace on this order.</value>
        [DataMember(Name="order_MarketplaceLastModificationUtcDate", EmitDefaultValue=false)]
        public DateTime? OrderMarketplaceLastModificationUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets OrderBuyerName
        /// </summary>
        [DataMember(Name="order_Buyer_Name", EmitDefaultValue=false)]
        public OrderBuyerName OrderBuyerName { get; set; }
        /// <summary>
        /// The total price of this order (corresponding to the amount paid by the customer)
        /// </summary>
        /// <value>The total price of this order (corresponding to the amount paid by the customer)</value>
        [DataMember(Name="order_TotalPrice", EmitDefaultValue=false)]
        public decimal? OrderTotalPrice { get; set; }
        /// <summary>
        /// Gets or Sets OrderCurrencyCode
        /// </summary>
        [DataMember(Name="order_CurrencyCode", EmitDefaultValue=false)]
        public BeezUPCommonCurrencyCode OrderCurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets Processing
        /// </summary>
        [DataMember(Name="processing", EmitDefaultValue=false)]
        public Processing Processing { get; set; }
        /// <summary>
        /// ETag value to identify the order. For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3 
        /// </summary>
        /// <value>ETag value to identify the order. For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3 </value>
        [DataMember(Name="eTag", EmitDefaultValue=false)]
        public string ETag { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<BeezUPCommonLink2> Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderHeader {\n");
            sb.Append("  MarketplaceTechnicalCode: ").Append(MarketplaceTechnicalCode).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  BeezUPOrderId: ").Append(BeezUPOrderId).Append("\n");
            sb.Append("  BeezUPOrderUrl: ").Append(BeezUPOrderUrl).Append("\n");
            sb.Append("  MarketplaceBusinessCode: ").Append(MarketplaceBusinessCode).Append("\n");
            sb.Append("  OrderMarketplaceOrderId: ").Append(OrderMarketplaceOrderId).Append("\n");
            sb.Append("  OrderStatusBeezUPOrderStatus: ").Append(OrderStatusBeezUPOrderStatus).Append("\n");
            sb.Append("  OrderStatusMarketplaceOrderStatus: ").Append(OrderStatusMarketplaceOrderStatus).Append("\n");
            sb.Append("  OrderMerchantOrderId: ").Append(OrderMerchantOrderId).Append("\n");
            sb.Append("  OrderMerchantECommerceSoftwareName: ").Append(OrderMerchantECommerceSoftwareName).Append("\n");
            sb.Append("  OrderMerchantECommerceSoftwareVersion: ").Append(OrderMerchantECommerceSoftwareVersion).Append("\n");
            sb.Append("  OrderPurchaseUtcDate: ").Append(OrderPurchaseUtcDate).Append("\n");
            sb.Append("  OrderLastModificationUtcDate: ").Append(OrderLastModificationUtcDate).Append("\n");
            sb.Append("  OrderMarketplaceLastModificationUtcDate: ").Append(OrderMarketplaceLastModificationUtcDate).Append("\n");
            sb.Append("  OrderBuyerName: ").Append(OrderBuyerName).Append("\n");
            sb.Append("  OrderTotalPrice: ").Append(OrderTotalPrice).Append("\n");
            sb.Append("  OrderCurrencyCode: ").Append(OrderCurrencyCode).Append("\n");
            sb.Append("  Processing: ").Append(Processing).Append("\n");
            sb.Append("  ETag: ").Append(ETag).Append("\n");
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
            return this.Equals(obj as OrderHeader);
        }

        /// <summary>
        /// Returns true if OrderHeader instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderHeader other)
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
                    this.BeezUPOrderId == other.BeezUPOrderId ||
                    this.BeezUPOrderId != null &&
                    this.BeezUPOrderId.Equals(other.BeezUPOrderId)
                ) && 
                (
                    this.BeezUPOrderUrl == other.BeezUPOrderUrl ||
                    this.BeezUPOrderUrl != null &&
                    this.BeezUPOrderUrl.Equals(other.BeezUPOrderUrl)
                ) && 
                (
                    this.MarketplaceBusinessCode == other.MarketplaceBusinessCode ||
                    this.MarketplaceBusinessCode != null &&
                    this.MarketplaceBusinessCode.Equals(other.MarketplaceBusinessCode)
                ) && 
                (
                    this.OrderMarketplaceOrderId == other.OrderMarketplaceOrderId ||
                    this.OrderMarketplaceOrderId != null &&
                    this.OrderMarketplaceOrderId.Equals(other.OrderMarketplaceOrderId)
                ) && 
                (
                    this.OrderStatusBeezUPOrderStatus == other.OrderStatusBeezUPOrderStatus ||
                    this.OrderStatusBeezUPOrderStatus != null &&
                    this.OrderStatusBeezUPOrderStatus.Equals(other.OrderStatusBeezUPOrderStatus)
                ) && 
                (
                    this.OrderStatusMarketplaceOrderStatus == other.OrderStatusMarketplaceOrderStatus ||
                    this.OrderStatusMarketplaceOrderStatus != null &&
                    this.OrderStatusMarketplaceOrderStatus.Equals(other.OrderStatusMarketplaceOrderStatus)
                ) && 
                (
                    this.OrderMerchantOrderId == other.OrderMerchantOrderId ||
                    this.OrderMerchantOrderId != null &&
                    this.OrderMerchantOrderId.Equals(other.OrderMerchantOrderId)
                ) && 
                (
                    this.OrderMerchantECommerceSoftwareName == other.OrderMerchantECommerceSoftwareName ||
                    this.OrderMerchantECommerceSoftwareName != null &&
                    this.OrderMerchantECommerceSoftwareName.Equals(other.OrderMerchantECommerceSoftwareName)
                ) && 
                (
                    this.OrderMerchantECommerceSoftwareVersion == other.OrderMerchantECommerceSoftwareVersion ||
                    this.OrderMerchantECommerceSoftwareVersion != null &&
                    this.OrderMerchantECommerceSoftwareVersion.Equals(other.OrderMerchantECommerceSoftwareVersion)
                ) && 
                (
                    this.OrderPurchaseUtcDate == other.OrderPurchaseUtcDate ||
                    this.OrderPurchaseUtcDate != null &&
                    this.OrderPurchaseUtcDate.Equals(other.OrderPurchaseUtcDate)
                ) && 
                (
                    this.OrderLastModificationUtcDate == other.OrderLastModificationUtcDate ||
                    this.OrderLastModificationUtcDate != null &&
                    this.OrderLastModificationUtcDate.Equals(other.OrderLastModificationUtcDate)
                ) && 
                (
                    this.OrderMarketplaceLastModificationUtcDate == other.OrderMarketplaceLastModificationUtcDate ||
                    this.OrderMarketplaceLastModificationUtcDate != null &&
                    this.OrderMarketplaceLastModificationUtcDate.Equals(other.OrderMarketplaceLastModificationUtcDate)
                ) && 
                (
                    this.OrderBuyerName == other.OrderBuyerName ||
                    this.OrderBuyerName != null &&
                    this.OrderBuyerName.Equals(other.OrderBuyerName)
                ) && 
                (
                    this.OrderTotalPrice == other.OrderTotalPrice ||
                    this.OrderTotalPrice != null &&
                    this.OrderTotalPrice.Equals(other.OrderTotalPrice)
                ) && 
                (
                    this.OrderCurrencyCode == other.OrderCurrencyCode ||
                    this.OrderCurrencyCode != null &&
                    this.OrderCurrencyCode.Equals(other.OrderCurrencyCode)
                ) && 
                (
                    this.Processing == other.Processing ||
                    this.Processing != null &&
                    this.Processing.Equals(other.Processing)
                ) && 
                (
                    this.ETag == other.ETag ||
                    this.ETag != null &&
                    this.ETag.Equals(other.ETag)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
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
                if (this.BeezUPOrderId != null)
                    hash = hash * 59 + this.BeezUPOrderId.GetHashCode();
                if (this.BeezUPOrderUrl != null)
                    hash = hash * 59 + this.BeezUPOrderUrl.GetHashCode();
                if (this.MarketplaceBusinessCode != null)
                    hash = hash * 59 + this.MarketplaceBusinessCode.GetHashCode();
                if (this.OrderMarketplaceOrderId != null)
                    hash = hash * 59 + this.OrderMarketplaceOrderId.GetHashCode();
                if (this.OrderStatusBeezUPOrderStatus != null)
                    hash = hash * 59 + this.OrderStatusBeezUPOrderStatus.GetHashCode();
                if (this.OrderStatusMarketplaceOrderStatus != null)
                    hash = hash * 59 + this.OrderStatusMarketplaceOrderStatus.GetHashCode();
                if (this.OrderMerchantOrderId != null)
                    hash = hash * 59 + this.OrderMerchantOrderId.GetHashCode();
                if (this.OrderMerchantECommerceSoftwareName != null)
                    hash = hash * 59 + this.OrderMerchantECommerceSoftwareName.GetHashCode();
                if (this.OrderMerchantECommerceSoftwareVersion != null)
                    hash = hash * 59 + this.OrderMerchantECommerceSoftwareVersion.GetHashCode();
                if (this.OrderPurchaseUtcDate != null)
                    hash = hash * 59 + this.OrderPurchaseUtcDate.GetHashCode();
                if (this.OrderLastModificationUtcDate != null)
                    hash = hash * 59 + this.OrderLastModificationUtcDate.GetHashCode();
                if (this.OrderMarketplaceLastModificationUtcDate != null)
                    hash = hash * 59 + this.OrderMarketplaceLastModificationUtcDate.GetHashCode();
                if (this.OrderBuyerName != null)
                    hash = hash * 59 + this.OrderBuyerName.GetHashCode();
                if (this.OrderTotalPrice != null)
                    hash = hash * 59 + this.OrderTotalPrice.GetHashCode();
                if (this.OrderCurrencyCode != null)
                    hash = hash * 59 + this.OrderCurrencyCode.GetHashCode();
                if (this.Processing != null)
                    hash = hash * 59 + this.Processing.GetHashCode();
                if (this.ETag != null)
                    hash = hash * 59 + this.ETag.GetHashCode();
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
