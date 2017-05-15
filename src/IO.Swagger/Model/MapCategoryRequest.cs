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
    /// The request message to make a mapping between catalog category path and a channel category path
    /// </summary>
    [DataContract]
    public partial class MapCategoryRequest :  IEquatable<MapCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapCategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MapCategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapCategoryRequest" /> class.
        /// </summary>
        /// <param name="OverrideSubCategoryMappings">Great feature! In case of mapping to parent channel category, you can ask to override the mapping of all sub channel category to this catalog category path (required).</param>
        /// <param name="AutoMapNewSubCategories">Great feature! In case of mapping to parent catalog category, you can ask to automatically map new sub catalog category in the next importation to this channel category path. (required).</param>
        /// <param name="ChannelCatalogCategoryMapping">ChannelCatalogCategoryMapping (required).</param>
        public MapCategoryRequest(bool? OverrideSubCategoryMappings = default(bool?), bool? AutoMapNewSubCategories = default(bool?), ChannelCatalogCategoryMapping ChannelCatalogCategoryMapping = default(ChannelCatalogCategoryMapping))
        {
            // to ensure "OverrideSubCategoryMappings" is required (not null)
            if (OverrideSubCategoryMappings == null)
            {
                throw new InvalidDataException("OverrideSubCategoryMappings is a required property for MapCategoryRequest and cannot be null");
            }
            else
            {
                this.OverrideSubCategoryMappings = OverrideSubCategoryMappings;
            }
            // to ensure "AutoMapNewSubCategories" is required (not null)
            if (AutoMapNewSubCategories == null)
            {
                throw new InvalidDataException("AutoMapNewSubCategories is a required property for MapCategoryRequest and cannot be null");
            }
            else
            {
                this.AutoMapNewSubCategories = AutoMapNewSubCategories;
            }
            // to ensure "ChannelCatalogCategoryMapping" is required (not null)
            if (ChannelCatalogCategoryMapping == null)
            {
                throw new InvalidDataException("ChannelCatalogCategoryMapping is a required property for MapCategoryRequest and cannot be null");
            }
            else
            {
                this.ChannelCatalogCategoryMapping = ChannelCatalogCategoryMapping;
            }
        }
        
        /// <summary>
        /// Great feature! In case of mapping to parent channel category, you can ask to override the mapping of all sub channel category to this catalog category path
        /// </summary>
        /// <value>Great feature! In case of mapping to parent channel category, you can ask to override the mapping of all sub channel category to this catalog category path</value>
        [DataMember(Name="overrideSubCategoryMappings", EmitDefaultValue=false)]
        public bool? OverrideSubCategoryMappings { get; set; }
        /// <summary>
        /// Great feature! In case of mapping to parent catalog category, you can ask to automatically map new sub catalog category in the next importation to this channel category path.
        /// </summary>
        /// <value>Great feature! In case of mapping to parent catalog category, you can ask to automatically map new sub catalog category in the next importation to this channel category path.</value>
        [DataMember(Name="autoMapNewSubCategories", EmitDefaultValue=false)]
        public bool? AutoMapNewSubCategories { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCatalogCategoryMapping
        /// </summary>
        [DataMember(Name="channelCatalogCategoryMapping", EmitDefaultValue=false)]
        public ChannelCatalogCategoryMapping ChannelCatalogCategoryMapping { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MapCategoryRequest {\n");
            sb.Append("  OverrideSubCategoryMappings: ").Append(OverrideSubCategoryMappings).Append("\n");
            sb.Append("  AutoMapNewSubCategories: ").Append(AutoMapNewSubCategories).Append("\n");
            sb.Append("  ChannelCatalogCategoryMapping: ").Append(ChannelCatalogCategoryMapping).Append("\n");
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
            return this.Equals(obj as MapCategoryRequest);
        }

        /// <summary>
        /// Returns true if MapCategoryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MapCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapCategoryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OverrideSubCategoryMappings == other.OverrideSubCategoryMappings ||
                    this.OverrideSubCategoryMappings != null &&
                    this.OverrideSubCategoryMappings.Equals(other.OverrideSubCategoryMappings)
                ) && 
                (
                    this.AutoMapNewSubCategories == other.AutoMapNewSubCategories ||
                    this.AutoMapNewSubCategories != null &&
                    this.AutoMapNewSubCategories.Equals(other.AutoMapNewSubCategories)
                ) && 
                (
                    this.ChannelCatalogCategoryMapping == other.ChannelCatalogCategoryMapping ||
                    this.ChannelCatalogCategoryMapping != null &&
                    this.ChannelCatalogCategoryMapping.Equals(other.ChannelCatalogCategoryMapping)
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
                if (this.OverrideSubCategoryMappings != null)
                    hash = hash * 59 + this.OverrideSubCategoryMappings.GetHashCode();
                if (this.AutoMapNewSubCategories != null)
                    hash = hash * 59 + this.AutoMapNewSubCategories.GetHashCode();
                if (this.ChannelCatalogCategoryMapping != null)
                    hash = hash * 59 + this.ChannelCatalogCategoryMapping.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
