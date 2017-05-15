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
    /// ProductFilters
    /// </summary>
    [DataContract]
    public partial class ProductFilters :  IEquatable<ProductFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFilters" /> class.
        /// </summary>
        /// <param name="Sku">The product sku filter.</param>
        /// <param name="Title">The product title filter.</param>
        /// <param name="AdditionalProductFilters">AdditionalProductFilters.</param>
        public ProductFilters(string Sku = default(string), string Title = default(string), List<ReportProductFilter> AdditionalProductFilters = default(List<ReportProductFilter>))
        {
            this.Sku = Sku;
            this.Title = Title;
            this.AdditionalProductFilters = AdditionalProductFilters;
        }
        
        /// <summary>
        /// The product sku filter
        /// </summary>
        /// <value>The product sku filter</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// The product title filter
        /// </summary>
        /// <value>The product title filter</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets AdditionalProductFilters
        /// </summary>
        [DataMember(Name="additionalProductFilters", EmitDefaultValue=false)]
        public List<ReportProductFilter> AdditionalProductFilters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductFilters {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AdditionalProductFilters: ").Append(AdditionalProductFilters).Append("\n");
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
            return this.Equals(obj as ProductFilters);
        }

        /// <summary>
        /// Returns true if ProductFilters instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductFilters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.AdditionalProductFilters == other.AdditionalProductFilters ||
                    this.AdditionalProductFilters != null &&
                    this.AdditionalProductFilters.SequenceEqual(other.AdditionalProductFilters)
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
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.AdditionalProductFilters != null)
                    hash = hash * 59 + this.AdditionalProductFilters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
