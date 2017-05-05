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
    /// ChannelCatalogMarketplacePropertyGroup
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogMarketplacePropertyGroup :  IEquatable<ChannelCatalogMarketplacePropertyGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogMarketplacePropertyGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogMarketplacePropertyGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogMarketplacePropertyGroup" /> class.
        /// </summary>
        /// <param name="DisplayGroupCode">Indicate the code identifier of the group (required).</param>
        /// <param name="DisplayGroupPosition">Indicate the position of the group (required).</param>
        /// <param name="Properties">Properties (required).</param>
        public ChannelCatalogMarketplacePropertyGroup(string DisplayGroupCode = default(string), int? DisplayGroupPosition = default(int?), List<ChannelCatalogMarketplaceProperty> Properties = default(List<ChannelCatalogMarketplaceProperty>))
        {
            // to ensure "DisplayGroupCode" is required (not null)
            if (DisplayGroupCode == null)
            {
                throw new InvalidDataException("DisplayGroupCode is a required property for ChannelCatalogMarketplacePropertyGroup and cannot be null");
            }
            else
            {
                this.DisplayGroupCode = DisplayGroupCode;
            }
            // to ensure "DisplayGroupPosition" is required (not null)
            if (DisplayGroupPosition == null)
            {
                throw new InvalidDataException("DisplayGroupPosition is a required property for ChannelCatalogMarketplacePropertyGroup and cannot be null");
            }
            else
            {
                this.DisplayGroupPosition = DisplayGroupPosition;
            }
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for ChannelCatalogMarketplacePropertyGroup and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
        }
        
        /// <summary>
        /// Indicate the code identifier of the group
        /// </summary>
        /// <value>Indicate the code identifier of the group</value>
        [DataMember(Name="displayGroupCode", EmitDefaultValue=false)]
        public string DisplayGroupCode { get; set; }
        /// <summary>
        /// Indicate the position of the group
        /// </summary>
        /// <value>Indicate the position of the group</value>
        [DataMember(Name="displayGroupPosition", EmitDefaultValue=false)]
        public int? DisplayGroupPosition { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<ChannelCatalogMarketplaceProperty> Properties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogMarketplacePropertyGroup {\n");
            sb.Append("  DisplayGroupCode: ").Append(DisplayGroupCode).Append("\n");
            sb.Append("  DisplayGroupPosition: ").Append(DisplayGroupPosition).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as ChannelCatalogMarketplacePropertyGroup);
        }

        /// <summary>
        /// Returns true if ChannelCatalogMarketplacePropertyGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogMarketplacePropertyGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogMarketplacePropertyGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayGroupCode == other.DisplayGroupCode ||
                    this.DisplayGroupCode != null &&
                    this.DisplayGroupCode.Equals(other.DisplayGroupCode)
                ) && 
                (
                    this.DisplayGroupPosition == other.DisplayGroupPosition ||
                    this.DisplayGroupPosition != null &&
                    this.DisplayGroupPosition.Equals(other.DisplayGroupPosition)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.DisplayGroupCode != null)
                    hash = hash * 59 + this.DisplayGroupCode.GetHashCode();
                if (this.DisplayGroupPosition != null)
                    hash = hash * 59 + this.DisplayGroupPosition.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // DisplayGroupPosition (int?) minimum
            if(this.DisplayGroupPosition < (int?)1)
            {
                yield return new ValidationResult("Invalid value for DisplayGroupPosition, must be a value greater than or equal to 1.", new [] { "DisplayGroupPosition" });
            }

            yield break;
        }
    }

}
