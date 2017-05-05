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
    /// The request message to unmap a catalog category path to a channel category path
    /// </summary>
    [DataContract]
    public partial class UnmapCategoryRequest :  IEquatable<UnmapCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnmapCategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnmapCategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnmapCategoryRequest" /> class.
        /// </summary>
        /// <param name="CatalogCategoryPath">CatalogCategoryPath (required).</param>
        public UnmapCategoryRequest(BeezUPCommonCatalogCategoryPath CatalogCategoryPath = default(BeezUPCommonCatalogCategoryPath))
        {
            // to ensure "CatalogCategoryPath" is required (not null)
            if (CatalogCategoryPath == null)
            {
                throw new InvalidDataException("CatalogCategoryPath is a required property for UnmapCategoryRequest and cannot be null");
            }
            else
            {
                this.CatalogCategoryPath = CatalogCategoryPath;
            }
        }
        
        /// <summary>
        /// Gets or Sets CatalogCategoryPath
        /// </summary>
        [DataMember(Name="catalogCategoryPath", EmitDefaultValue=false)]
        public BeezUPCommonCatalogCategoryPath CatalogCategoryPath { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnmapCategoryRequest {\n");
            sb.Append("  CatalogCategoryPath: ").Append(CatalogCategoryPath).Append("\n");
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
            return this.Equals(obj as UnmapCategoryRequest);
        }

        /// <summary>
        /// Returns true if UnmapCategoryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UnmapCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnmapCategoryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogCategoryPath == other.CatalogCategoryPath ||
                    this.CatalogCategoryPath != null &&
                    this.CatalogCategoryPath.Equals(other.CatalogCategoryPath)
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
                if (this.CatalogCategoryPath != null)
                    hash = hash * 59 + this.CatalogCategoryPath.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
