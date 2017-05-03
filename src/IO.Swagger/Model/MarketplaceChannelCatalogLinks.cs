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
    /// Indicate the actions you can do on a channel catalog. If the settings are valid, you will be able to access to the publication history.
    /// </summary>
    [DataContract]
    public partial class MarketplaceChannelCatalogLinks :  IEquatable<MarketplaceChannelCatalogLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalogLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarketplaceChannelCatalogLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalogLinks" /> class.
        /// </summary>
        /// <param name="Properties">Properties (required).</param>
        /// <param name="Settings">Settings (required).</param>
        /// <param name="Publications">Publications.</param>
        public MarketplaceChannelCatalogLinks(LinksGetChannelCatalogMarketplacePropertiesLink Properties = default(LinksGetChannelCatalogMarketplacePropertiesLink), LinksGetChannelCatalogMarketplaceSettingsLink Settings = default(LinksGetChannelCatalogMarketplaceSettingsLink), LinksGetPublicationsLink Publications = default(LinksGetPublicationsLink))
        {
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for MarketplaceChannelCatalogLinks and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
            // to ensure "Settings" is required (not null)
            if (Settings == null)
            {
                throw new InvalidDataException("Settings is a required property for MarketplaceChannelCatalogLinks and cannot be null");
            }
            else
            {
                this.Settings = Settings;
            }
            this.Publications = Publications;
        }
        
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public LinksGetChannelCatalogMarketplacePropertiesLink Properties { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public LinksGetChannelCatalogMarketplaceSettingsLink Settings { get; set; }
        /// <summary>
        /// Gets or Sets Publications
        /// </summary>
        [DataMember(Name="publications", EmitDefaultValue=false)]
        public LinksGetPublicationsLink Publications { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceChannelCatalogLinks {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Publications: ").Append(Publications).Append("\n");
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
            return this.Equals(obj as MarketplaceChannelCatalogLinks);
        }

        /// <summary>
        /// Returns true if MarketplaceChannelCatalogLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketplaceChannelCatalogLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceChannelCatalogLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.Publications == other.Publications ||
                    this.Publications != null &&
                    this.Publications.Equals(other.Publications)
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
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.Publications != null)
                    hash = hash * 59 + this.Publications.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
