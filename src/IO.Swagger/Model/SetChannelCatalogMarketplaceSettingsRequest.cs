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
    /// The channel catalog marketplace settings to save
    /// </summary>
    [DataContract]
    public partial class SetChannelCatalogMarketplaceSettingsRequest :  IEquatable<SetChannelCatalogMarketplaceSettingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetChannelCatalogMarketplaceSettingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetChannelCatalogMarketplaceSettingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetChannelCatalogMarketplaceSettingsRequest" /> class.
        /// </summary>
        /// <param name="Settings">Settings (required).</param>
        public SetChannelCatalogMarketplaceSettingsRequest(ChannelCatalogMarketplaceSettingArray Settings = default(ChannelCatalogMarketplaceSettingArray))
        {
            // to ensure "Settings" is required (not null)
            if (Settings == null)
            {
                throw new InvalidDataException("Settings is a required property for SetChannelCatalogMarketplaceSettingsRequest and cannot be null");
            }
            else
            {
                this.Settings = Settings;
            }
        }
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public ChannelCatalogMarketplaceSettingArray Settings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetChannelCatalogMarketplaceSettingsRequest {\n");
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
            return this.Equals(obj as SetChannelCatalogMarketplaceSettingsRequest);
        }

        /// <summary>
        /// Returns true if SetChannelCatalogMarketplaceSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SetChannelCatalogMarketplaceSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetChannelCatalogMarketplaceSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
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
