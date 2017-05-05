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
    /// TrackedOrderProduct
    /// </summary>
    [DataContract]
    public partial class TrackedOrderProduct :  IEquatable<TrackedOrderProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedOrderProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackedOrderProduct() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedOrderProduct" /> class.
        /// </summary>
        /// <param name="ProductId">The product identifier (required).</param>
        /// <param name="ProductSku">The product SKU (required).</param>
        /// <param name="ProductTitle">The product tile (required).</param>
        /// <param name="ProductImageUrl">The product image Url (required).</param>
        /// <param name="ProductActive">Indicates if the product still exists in your catalog (required).</param>
        /// <param name="UnitPrice">The product&#39;s unit price related to this order (required).</param>
        /// <param name="Quantity">Indicate the product&#39;s quantity ordered. (required).</param>
        /// <param name="Margin">Indicate the product&#39;s margin related to this order. (required).</param>
        public TrackedOrderProduct(string ProductId = default(string), string ProductSku = default(string), string ProductTitle = default(string), string ProductImageUrl = default(string), bool? ProductActive = default(bool?), decimal? UnitPrice = default(decimal?), decimal? Quantity = default(decimal?), decimal? Margin = default(decimal?))
        {
            // to ensure "ProductId" is required (not null)
            if (ProductId == null)
            {
                throw new InvalidDataException("ProductId is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.ProductId = ProductId;
            }
            // to ensure "ProductSku" is required (not null)
            if (ProductSku == null)
            {
                throw new InvalidDataException("ProductSku is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.ProductSku = ProductSku;
            }
            // to ensure "ProductTitle" is required (not null)
            if (ProductTitle == null)
            {
                throw new InvalidDataException("ProductTitle is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.ProductTitle = ProductTitle;
            }
            // to ensure "ProductImageUrl" is required (not null)
            if (ProductImageUrl == null)
            {
                throw new InvalidDataException("ProductImageUrl is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.ProductImageUrl = ProductImageUrl;
            }
            // to ensure "ProductActive" is required (not null)
            if (ProductActive == null)
            {
                throw new InvalidDataException("ProductActive is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.ProductActive = ProductActive;
            }
            // to ensure "UnitPrice" is required (not null)
            if (UnitPrice == null)
            {
                throw new InvalidDataException("UnitPrice is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.UnitPrice = UnitPrice;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "Margin" is required (not null)
            if (Margin == null)
            {
                throw new InvalidDataException("Margin is a required property for TrackedOrderProduct and cannot be null");
            }
            else
            {
                this.Margin = Margin;
            }
        }
        
        /// <summary>
        /// The product identifier
        /// </summary>
        /// <value>The product identifier</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }
        /// <summary>
        /// The product SKU
        /// </summary>
        /// <value>The product SKU</value>
        [DataMember(Name="productSku", EmitDefaultValue=false)]
        public string ProductSku { get; set; }
        /// <summary>
        /// The product tile
        /// </summary>
        /// <value>The product tile</value>
        [DataMember(Name="productTitle", EmitDefaultValue=false)]
        public string ProductTitle { get; set; }
        /// <summary>
        /// The product image Url
        /// </summary>
        /// <value>The product image Url</value>
        [DataMember(Name="productImageUrl", EmitDefaultValue=false)]
        public string ProductImageUrl { get; set; }
        /// <summary>
        /// Indicates if the product still exists in your catalog
        /// </summary>
        /// <value>Indicates if the product still exists in your catalog</value>
        [DataMember(Name="productActive", EmitDefaultValue=false)]
        public bool? ProductActive { get; set; }
        /// <summary>
        /// The product&#39;s unit price related to this order
        /// </summary>
        /// <value>The product&#39;s unit price related to this order</value>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public decimal? UnitPrice { get; set; }
        /// <summary>
        /// Indicate the product&#39;s quantity ordered.
        /// </summary>
        /// <value>Indicate the product&#39;s quantity ordered.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// Indicate the product&#39;s margin related to this order.
        /// </summary>
        /// <value>Indicate the product&#39;s margin related to this order.</value>
        [DataMember(Name="margin", EmitDefaultValue=false)]
        public decimal? Margin { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackedOrderProduct {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductSku: ").Append(ProductSku).Append("\n");
            sb.Append("  ProductTitle: ").Append(ProductTitle).Append("\n");
            sb.Append("  ProductImageUrl: ").Append(ProductImageUrl).Append("\n");
            sb.Append("  ProductActive: ").Append(ProductActive).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
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
            return this.Equals(obj as TrackedOrderProduct);
        }

        /// <summary>
        /// Returns true if TrackedOrderProduct instances are equal
        /// </summary>
        /// <param name="other">Instance of TrackedOrderProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedOrderProduct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.ProductSku == other.ProductSku ||
                    this.ProductSku != null &&
                    this.ProductSku.Equals(other.ProductSku)
                ) && 
                (
                    this.ProductTitle == other.ProductTitle ||
                    this.ProductTitle != null &&
                    this.ProductTitle.Equals(other.ProductTitle)
                ) && 
                (
                    this.ProductImageUrl == other.ProductImageUrl ||
                    this.ProductImageUrl != null &&
                    this.ProductImageUrl.Equals(other.ProductImageUrl)
                ) && 
                (
                    this.ProductActive == other.ProductActive ||
                    this.ProductActive != null &&
                    this.ProductActive.Equals(other.ProductActive)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
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
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.ProductSku != null)
                    hash = hash * 59 + this.ProductSku.GetHashCode();
                if (this.ProductTitle != null)
                    hash = hash * 59 + this.ProductTitle.GetHashCode();
                if (this.ProductImageUrl != null)
                    hash = hash * 59 + this.ProductImageUrl.GetHashCode();
                if (this.ProductActive != null)
                    hash = hash * 59 + this.ProductActive.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}