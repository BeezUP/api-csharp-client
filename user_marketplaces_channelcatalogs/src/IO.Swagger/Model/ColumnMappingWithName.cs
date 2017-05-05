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
    /// ColumnMappingWithName
    /// </summary>
    [DataContract]
    public partial class ColumnMappingWithName :  IEquatable<ColumnMappingWithName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMappingWithName" /> class.
        /// </summary>
        /// <param name="ChannelColumnId">ChannelColumnId.</param>
        /// <param name="ChannelCategoryPath">ChannelCategoryPath.</param>
        /// <param name="CatalogColumnId">CatalogColumnId.</param>
        /// <param name="ChannelColumnName">ChannelColumnName.</param>
        /// <param name="CatalogColumnName">CatalogColumnName.</param>
        public ColumnMappingWithName(BeezUPCommonChannelColumnId ChannelColumnId = default(BeezUPCommonChannelColumnId), BeezUPCommonChannelCategoryPath ChannelCategoryPath = default(BeezUPCommonChannelCategoryPath), BeezUPCommonCatalogColumnId CatalogColumnId = default(BeezUPCommonCatalogColumnId), BeezUPCommonChannelColumnName ChannelColumnName = default(BeezUPCommonChannelColumnName), BeezUPCommonCatalogColumnUserName CatalogColumnName = default(BeezUPCommonCatalogColumnUserName))
        {
            this.ChannelColumnId = ChannelColumnId;
            this.ChannelCategoryPath = ChannelCategoryPath;
            this.CatalogColumnId = CatalogColumnId;
            this.ChannelColumnName = ChannelColumnName;
            this.CatalogColumnName = CatalogColumnName;
        }
        
        /// <summary>
        /// Gets or Sets ChannelColumnId
        /// </summary>
        [DataMember(Name="channelColumnId", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnId ChannelColumnId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryPath
        /// </summary>
        [DataMember(Name="channelCategoryPath", EmitDefaultValue=false)]
        public BeezUPCommonChannelCategoryPath ChannelCategoryPath { get; set; }
        /// <summary>
        /// Gets or Sets CatalogColumnId
        /// </summary>
        [DataMember(Name="catalogColumnId", EmitDefaultValue=false)]
        public BeezUPCommonCatalogColumnId CatalogColumnId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelColumnName
        /// </summary>
        [DataMember(Name="channelColumnName", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnName ChannelColumnName { get; set; }
        /// <summary>
        /// Gets or Sets CatalogColumnName
        /// </summary>
        [DataMember(Name="catalogColumnName", EmitDefaultValue=false)]
        public BeezUPCommonCatalogColumnUserName CatalogColumnName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnMappingWithName {\n");
            sb.Append("  ChannelColumnId: ").Append(ChannelColumnId).Append("\n");
            sb.Append("  ChannelCategoryPath: ").Append(ChannelCategoryPath).Append("\n");
            sb.Append("  CatalogColumnId: ").Append(CatalogColumnId).Append("\n");
            sb.Append("  ChannelColumnName: ").Append(ChannelColumnName).Append("\n");
            sb.Append("  CatalogColumnName: ").Append(CatalogColumnName).Append("\n");
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
            return this.Equals(obj as ColumnMappingWithName);
        }

        /// <summary>
        /// Returns true if ColumnMappingWithName instances are equal
        /// </summary>
        /// <param name="other">Instance of ColumnMappingWithName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColumnMappingWithName other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelColumnId == other.ChannelColumnId ||
                    this.ChannelColumnId != null &&
                    this.ChannelColumnId.Equals(other.ChannelColumnId)
                ) && 
                (
                    this.ChannelCategoryPath == other.ChannelCategoryPath ||
                    this.ChannelCategoryPath != null &&
                    this.ChannelCategoryPath.Equals(other.ChannelCategoryPath)
                ) && 
                (
                    this.CatalogColumnId == other.CatalogColumnId ||
                    this.CatalogColumnId != null &&
                    this.CatalogColumnId.Equals(other.CatalogColumnId)
                ) && 
                (
                    this.ChannelColumnName == other.ChannelColumnName ||
                    this.ChannelColumnName != null &&
                    this.ChannelColumnName.Equals(other.ChannelColumnName)
                ) && 
                (
                    this.CatalogColumnName == other.CatalogColumnName ||
                    this.CatalogColumnName != null &&
                    this.CatalogColumnName.Equals(other.CatalogColumnName)
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
                if (this.ChannelColumnId != null)
                    hash = hash * 59 + this.ChannelColumnId.GetHashCode();
                if (this.ChannelCategoryPath != null)
                    hash = hash * 59 + this.ChannelCategoryPath.GetHashCode();
                if (this.CatalogColumnId != null)
                    hash = hash * 59 + this.CatalogColumnId.GetHashCode();
                if (this.ChannelColumnName != null)
                    hash = hash * 59 + this.ChannelColumnName.GetHashCode();
                if (this.CatalogColumnName != null)
                    hash = hash * 59 + this.CatalogColumnName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
