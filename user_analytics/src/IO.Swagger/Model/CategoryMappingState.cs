/* 
 * Channel Catalogs
 *
 * This api allows you to manage your channel catalogs.   A channel catalog is an association between your store and a channel.  You will be able to: - map your catalog colums to channel columns. - map your catalog categories to the channel categories and define a cost of this category - configure the general and cost settings of the channel - enable or disable a channel - exclude products using filters for a channel - override product values for a channel - disable or reenable a product on a channel 
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
    /// The category mapping state of the channel catalog
    /// </summary>
    [DataContract]
    public partial class CategoryMappingState :  IEquatable<CategoryMappingState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryMappingState" /> class.
        /// </summary>
        /// <param name="Status">Status.</param>
        /// <param name="UncategorizedProductCount">Indicates the uncategorized product count.</param>
        /// <param name="CategorizedWithoutCostProductCount">Indicates the categorized product count without cost defined on the category.</param>
        public CategoryMappingState(CategoryMappingStatus Status = default(CategoryMappingStatus), int? UncategorizedProductCount = default(int?), int? CategorizedWithoutCostProductCount = default(int?))
        {
            this.Status = Status;
            this.UncategorizedProductCount = UncategorizedProductCount;
            this.CategorizedWithoutCostProductCount = CategorizedWithoutCostProductCount;
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public CategoryMappingStatus Status { get; set; }
        /// <summary>
        /// Indicates the uncategorized product count
        /// </summary>
        /// <value>Indicates the uncategorized product count</value>
        [DataMember(Name="uncategorizedProductCount", EmitDefaultValue=false)]
        public int? UncategorizedProductCount { get; set; }
        /// <summary>
        /// Indicates the categorized product count without cost defined on the category
        /// </summary>
        /// <value>Indicates the categorized product count without cost defined on the category</value>
        [DataMember(Name="categorizedWithoutCostProductCount", EmitDefaultValue=false)]
        public int? CategorizedWithoutCostProductCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryMappingState {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UncategorizedProductCount: ").Append(UncategorizedProductCount).Append("\n");
            sb.Append("  CategorizedWithoutCostProductCount: ").Append(CategorizedWithoutCostProductCount).Append("\n");
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
            return this.Equals(obj as CategoryMappingState);
        }

        /// <summary>
        /// Returns true if CategoryMappingState instances are equal
        /// </summary>
        /// <param name="other">Instance of CategoryMappingState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryMappingState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UncategorizedProductCount == other.UncategorizedProductCount ||
                    this.UncategorizedProductCount != null &&
                    this.UncategorizedProductCount.Equals(other.UncategorizedProductCount)
                ) && 
                (
                    this.CategorizedWithoutCostProductCount == other.CategorizedWithoutCostProductCount ||
                    this.CategorizedWithoutCostProductCount != null &&
                    this.CategorizedWithoutCostProductCount.Equals(other.CategorizedWithoutCostProductCount)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.UncategorizedProductCount != null)
                    hash = hash * 59 + this.UncategorizedProductCount.GetHashCode();
                if (this.CategorizedWithoutCostProductCount != null)
                    hash = hash * 59 + this.CategorizedWithoutCostProductCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
