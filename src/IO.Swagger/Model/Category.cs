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
    /// The catalog category
    /// </summary>
    [DataContract]
    public partial class Category :  IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Category() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="CategoryId">CategoryId (required).</param>
        /// <param name="CategoryPath">CategoryPath (required).</param>
        public Category(BeezUPCommonCatalogCategoryId CategoryId = default(BeezUPCommonCatalogCategoryId), BeezUPCommonCatalogCategoryPath CategoryPath = default(BeezUPCommonCatalogCategoryPath))
        {
            // to ensure "CategoryId" is required (not null)
            if (CategoryId == null)
            {
                throw new InvalidDataException("CategoryId is a required property for Category and cannot be null");
            }
            else
            {
                this.CategoryId = CategoryId;
            }
            // to ensure "CategoryPath" is required (not null)
            if (CategoryPath == null)
            {
                throw new InvalidDataException("CategoryPath is a required property for Category and cannot be null");
            }
            else
            {
                this.CategoryPath = CategoryPath;
            }
        }
        
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public BeezUPCommonCatalogCategoryId CategoryId { get; set; }
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
            sb.Append("class Category {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
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
            return this.Equals(obj as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="other">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
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
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
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
