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
    /// The request message to get products based on these filters
    /// </summary>
    [DataContract]
    public partial class GetProductsRequest :  IEquatable<GetProductsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductsRequest" /> class.
        /// </summary>
        /// <param name="Sku">Search for products containing this SKU (merchant product dentifier)..</param>
        /// <param name="Title">Search for products containing this title.</param>
        /// <param name="CategoryPath">CategoryPath.</param>
        public GetProductsRequest(string Sku = default(string), string Title = default(string), BeezUPCommonCatalogCategoryPath CategoryPath = default(BeezUPCommonCatalogCategoryPath))
        {
            this.Sku = Sku;
            this.Title = Title;
            this.CategoryPath = CategoryPath;
        }
        
        /// <summary>
        /// Search for products containing this SKU (merchant product dentifier).
        /// </summary>
        /// <value>Search for products containing this SKU (merchant product dentifier).</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// Search for products containing this title
        /// </summary>
        /// <value>Search for products containing this title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets CategoryPath
        /// </summary>
        [DataMember(Name="categoryPath", EmitDefaultValue=false)]
        public BeezUPCommonCatalogCategoryPath CategoryPath { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProductsRequest {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CategoryPath: ").Append(CategoryPath).Append("\n");
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
            return this.Equals(obj as GetProductsRequest);
        }

        /// <summary>
        /// Returns true if GetProductsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GetProductsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProductsRequest other)
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
                    this.CategoryPath == other.CategoryPath ||
                    this.CategoryPath != null &&
                    this.CategoryPath.Equals(other.CategoryPath)
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
                if (this.CategoryPath != null)
                    hash = hash * 59 + this.CategoryPath.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
