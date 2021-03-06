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
    /// The channel catalog marketplace settings
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogMarketplaceSettings :  IEquatable<ChannelCatalogMarketplaceSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogMarketplaceSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogMarketplaceSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogMarketplaceSettings" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="Settings">Settings (required).</param>
        public ChannelCatalogMarketplaceSettings(ChannelCatalogMarketplaceSettingsLinks Links = default(ChannelCatalogMarketplaceSettingsLinks), List<ChannelCatalogMarketplaceSetting> Settings = default(List<ChannelCatalogMarketplaceSetting>))
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for ChannelCatalogMarketplaceSettings and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            // to ensure "Settings" is required (not null)
            if (Settings == null)
            {
                throw new InvalidDataException("Settings is a required property for ChannelCatalogMarketplaceSettings and cannot be null");
            }
            else
            {
                this.Settings = Settings;
            }
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ChannelCatalogMarketplaceSettingsLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<ChannelCatalogMarketplaceSetting> Settings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogMarketplaceSettings {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(obj as ChannelCatalogMarketplaceSettings);
        }

        /// <summary>
        /// Returns true if ChannelCatalogMarketplaceSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogMarketplaceSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogMarketplaceSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(other.Settings)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
