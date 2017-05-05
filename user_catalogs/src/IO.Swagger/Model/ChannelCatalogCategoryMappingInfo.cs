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
    /// ChannelCatalogCategoryMappingInfo
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogCategoryMappingInfo :  IEquatable<ChannelCatalogCategoryMappingInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogCategoryMappingInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogCategoryMappingInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogCategoryMappingInfo" /> class.
        /// </summary>
        /// <param name="CatalogCategoryPath">CatalogCategoryPath (required).</param>
        /// <param name="ChannelCategoryPath">ChannelCategoryPath (required).</param>
        /// <param name="CostValue">In case of CPC_ByCategory or CPA_ByCategory cost type, you have to indicate the cost value..</param>
        /// <param name="Links">Links (required).</param>
        public ChannelCatalogCategoryMappingInfo(BeezUPCommonCatalogCategoryPath CatalogCategoryPath = default(BeezUPCommonCatalogCategoryPath), BeezUPCommonChannelCategoryPath ChannelCategoryPath = default(BeezUPCommonChannelCategoryPath), decimal? CostValue = default(decimal?), List<BeezUPCommonLink2> Links = default(List<BeezUPCommonLink2>))
        {
            // to ensure "CatalogCategoryPath" is required (not null)
            if (CatalogCategoryPath == null)
            {
                throw new InvalidDataException("CatalogCategoryPath is a required property for ChannelCatalogCategoryMappingInfo and cannot be null");
            }
            else
            {
                this.CatalogCategoryPath = CatalogCategoryPath;
            }
            // to ensure "ChannelCategoryPath" is required (not null)
            if (ChannelCategoryPath == null)
            {
                throw new InvalidDataException("ChannelCategoryPath is a required property for ChannelCatalogCategoryMappingInfo and cannot be null");
            }
            else
            {
                this.ChannelCategoryPath = ChannelCategoryPath;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for ChannelCatalogCategoryMappingInfo and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this.CostValue = CostValue;
        }
        
        /// <summary>
        /// Gets or Sets CatalogCategoryPath
        /// </summary>
        [DataMember(Name="catalogCategoryPath", EmitDefaultValue=false)]
        public BeezUPCommonCatalogCategoryPath CatalogCategoryPath { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryPath
        /// </summary>
        [DataMember(Name="channelCategoryPath", EmitDefaultValue=false)]
        public BeezUPCommonChannelCategoryPath ChannelCategoryPath { get; set; }
        /// <summary>
        /// In case of CPC_ByCategory or CPA_ByCategory cost type, you have to indicate the cost value.
        /// </summary>
        /// <value>In case of CPC_ByCategory or CPA_ByCategory cost type, you have to indicate the cost value.</value>
        [DataMember(Name="costValue", EmitDefaultValue=false)]
        public decimal? CostValue { get; set; }
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
            sb.Append("class ChannelCatalogCategoryMappingInfo {\n");
            sb.Append("  CatalogCategoryPath: ").Append(CatalogCategoryPath).Append("\n");
            sb.Append("  ChannelCategoryPath: ").Append(ChannelCategoryPath).Append("\n");
            sb.Append("  CostValue: ").Append(CostValue).Append("\n");
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
            return this.Equals(obj as ChannelCatalogCategoryMappingInfo);
        }

        /// <summary>
        /// Returns true if ChannelCatalogCategoryMappingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogCategoryMappingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogCategoryMappingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogCategoryPath == other.CatalogCategoryPath ||
                    this.CatalogCategoryPath != null &&
                    this.CatalogCategoryPath.Equals(other.CatalogCategoryPath)
                ) && 
                (
                    this.ChannelCategoryPath == other.ChannelCategoryPath ||
                    this.ChannelCategoryPath != null &&
                    this.ChannelCategoryPath.Equals(other.ChannelCategoryPath)
                ) && 
                (
                    this.CostValue == other.CostValue ||
                    this.CostValue != null &&
                    this.CostValue.Equals(other.CostValue)
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
                if (this.CatalogCategoryPath != null)
                    hash = hash * 59 + this.CatalogCategoryPath.GetHashCode();
                if (this.ChannelCategoryPath != null)
                    hash = hash * 59 + this.ChannelCategoryPath.GetHashCode();
                if (this.CostValue != null)
                    hash = hash * 59 + this.CostValue.GetHashCode();
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