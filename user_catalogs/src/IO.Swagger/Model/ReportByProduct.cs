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
    /// ReportByProduct
    /// </summary>
    [DataContract]
    public partial class ReportByProduct :  IEquatable<ReportByProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportByProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByProduct" /> class.
        /// </summary>
        /// <param name="Product">Product (required).</param>
        /// <param name="EnabledOnChannelCount">The count of channel where this product is enabled (required).</param>
        /// <param name="ChannelCount">The channel count where this product can be enabled (required).</param>
        /// <param name="ClickCount">The click count for this product (required).</param>
        /// <param name="Cost">The cost for this product (required).</param>
        /// <param name="OrderCount">The order count for this product (required).</param>
        /// <param name="TurnOver">The Turnover for this product (required).</param>
        /// <param name="Margin">The margin for this product (required).</param>
        /// <param name="PerformanceIndicator">The performance indicator based on the performance indicator formula indicated in the request for this product (required).</param>
        /// <param name="Links">The action list on this product (required).</param>
        public ReportByProduct(BeezUPCommonProductBasicInfo Product = default(BeezUPCommonProductBasicInfo), int? EnabledOnChannelCount = default(int?), int? ChannelCount = default(int?), int? ClickCount = default(int?), decimal? Cost = default(decimal?), int? OrderCount = default(int?), decimal? TurnOver = default(decimal?), decimal? Margin = default(decimal?), decimal? PerformanceIndicator = default(decimal?), List<BeezUPCommonLink2> Links = default(List<BeezUPCommonLink2>))
        {
            // to ensure "Product" is required (not null)
            if (Product == null)
            {
                throw new InvalidDataException("Product is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.Product = Product;
            }
            // to ensure "EnabledOnChannelCount" is required (not null)
            if (EnabledOnChannelCount == null)
            {
                throw new InvalidDataException("EnabledOnChannelCount is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.EnabledOnChannelCount = EnabledOnChannelCount;
            }
            // to ensure "ChannelCount" is required (not null)
            if (ChannelCount == null)
            {
                throw new InvalidDataException("ChannelCount is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.ChannelCount = ChannelCount;
            }
            // to ensure "ClickCount" is required (not null)
            if (ClickCount == null)
            {
                throw new InvalidDataException("ClickCount is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.ClickCount = ClickCount;
            }
            // to ensure "Cost" is required (not null)
            if (Cost == null)
            {
                throw new InvalidDataException("Cost is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.Cost = Cost;
            }
            // to ensure "OrderCount" is required (not null)
            if (OrderCount == null)
            {
                throw new InvalidDataException("OrderCount is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.OrderCount = OrderCount;
            }
            // to ensure "TurnOver" is required (not null)
            if (TurnOver == null)
            {
                throw new InvalidDataException("TurnOver is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.TurnOver = TurnOver;
            }
            // to ensure "Margin" is required (not null)
            if (Margin == null)
            {
                throw new InvalidDataException("Margin is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.Margin = Margin;
            }
            // to ensure "PerformanceIndicator" is required (not null)
            if (PerformanceIndicator == null)
            {
                throw new InvalidDataException("PerformanceIndicator is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.PerformanceIndicator = PerformanceIndicator;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for ReportByProduct and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
        }
        
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public BeezUPCommonProductBasicInfo Product { get; set; }
        /// <summary>
        /// The count of channel where this product is enabled
        /// </summary>
        /// <value>The count of channel where this product is enabled</value>
        [DataMember(Name="enabledOnChannelCount", EmitDefaultValue=false)]
        public int? EnabledOnChannelCount { get; set; }
        /// <summary>
        /// The channel count where this product can be enabled
        /// </summary>
        /// <value>The channel count where this product can be enabled</value>
        [DataMember(Name="channelCount", EmitDefaultValue=false)]
        public int? ChannelCount { get; set; }
        /// <summary>
        /// The click count for this product
        /// </summary>
        /// <value>The click count for this product</value>
        [DataMember(Name="clickCount", EmitDefaultValue=false)]
        public int? ClickCount { get; set; }
        /// <summary>
        /// The cost for this product
        /// </summary>
        /// <value>The cost for this product</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal? Cost { get; set; }
        /// <summary>
        /// The order count for this product
        /// </summary>
        /// <value>The order count for this product</value>
        [DataMember(Name="orderCount", EmitDefaultValue=false)]
        public int? OrderCount { get; set; }
        /// <summary>
        /// The Turnover for this product
        /// </summary>
        /// <value>The Turnover for this product</value>
        [DataMember(Name="turnOver", EmitDefaultValue=false)]
        public decimal? TurnOver { get; set; }
        /// <summary>
        /// The margin for this product
        /// </summary>
        /// <value>The margin for this product</value>
        [DataMember(Name="margin", EmitDefaultValue=false)]
        public decimal? Margin { get; set; }
        /// <summary>
        /// The performance indicator based on the performance indicator formula indicated in the request for this product
        /// </summary>
        /// <value>The performance indicator based on the performance indicator formula indicated in the request for this product</value>
        [DataMember(Name="performanceIndicator", EmitDefaultValue=false)]
        public decimal? PerformanceIndicator { get; set; }
        /// <summary>
        /// The action list on this product
        /// </summary>
        /// <value>The action list on this product</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<BeezUPCommonLink2> Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportByProduct {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  EnabledOnChannelCount: ").Append(EnabledOnChannelCount).Append("\n");
            sb.Append("  ChannelCount: ").Append(ChannelCount).Append("\n");
            sb.Append("  ClickCount: ").Append(ClickCount).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  TurnOver: ").Append(TurnOver).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  PerformanceIndicator: ").Append(PerformanceIndicator).Append("\n");
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
            return this.Equals(obj as ReportByProduct);
        }

        /// <summary>
        /// Returns true if ReportByProduct instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportByProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportByProduct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.EnabledOnChannelCount == other.EnabledOnChannelCount ||
                    this.EnabledOnChannelCount != null &&
                    this.EnabledOnChannelCount.Equals(other.EnabledOnChannelCount)
                ) && 
                (
                    this.ChannelCount == other.ChannelCount ||
                    this.ChannelCount != null &&
                    this.ChannelCount.Equals(other.ChannelCount)
                ) && 
                (
                    this.ClickCount == other.ClickCount ||
                    this.ClickCount != null &&
                    this.ClickCount.Equals(other.ClickCount)
                ) && 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.OrderCount == other.OrderCount ||
                    this.OrderCount != null &&
                    this.OrderCount.Equals(other.OrderCount)
                ) && 
                (
                    this.TurnOver == other.TurnOver ||
                    this.TurnOver != null &&
                    this.TurnOver.Equals(other.TurnOver)
                ) && 
                (
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
                ) && 
                (
                    this.PerformanceIndicator == other.PerformanceIndicator ||
                    this.PerformanceIndicator != null &&
                    this.PerformanceIndicator.Equals(other.PerformanceIndicator)
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
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.EnabledOnChannelCount != null)
                    hash = hash * 59 + this.EnabledOnChannelCount.GetHashCode();
                if (this.ChannelCount != null)
                    hash = hash * 59 + this.ChannelCount.GetHashCode();
                if (this.ClickCount != null)
                    hash = hash * 59 + this.ClickCount.GetHashCode();
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                if (this.OrderCount != null)
                    hash = hash * 59 + this.OrderCount.GetHashCode();
                if (this.TurnOver != null)
                    hash = hash * 59 + this.TurnOver.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
                if (this.PerformanceIndicator != null)
                    hash = hash * 59 + this.PerformanceIndicator.GetHashCode();
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
