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
    /// Indicates the differents actions you can do on a channel product
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogProductInfoLinks :  IEquatable<ChannelCatalogProductInfoLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogProductInfoLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogProductInfoLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogProductInfoLinks" /> class.
        /// </summary>
        /// <param name="_Override">_Override (required).</param>
        /// <param name="Disable">Disable.</param>
        /// <param name="Reenable">Reenable.</param>
        public ChannelCatalogProductInfoLinks(BeezUPCommonLink2 _Override = default(BeezUPCommonLink2), BeezUPCommonLink2 Disable = default(BeezUPCommonLink2), BeezUPCommonLink2 Reenable = default(BeezUPCommonLink2))
        {
            // to ensure "_Override" is required (not null)
            if (_Override == null)
            {
                throw new InvalidDataException("_Override is a required property for ChannelCatalogProductInfoLinks and cannot be null");
            }
            else
            {
                this._Override = _Override;
            }
            this.Disable = Disable;
            this.Reenable = Reenable;
        }
        
        /// <summary>
        /// Gets or Sets _Override
        /// </summary>
        [DataMember(Name="override", EmitDefaultValue=false)]
        public BeezUPCommonLink2 _Override { get; set; }
        /// <summary>
        /// Gets or Sets Disable
        /// </summary>
        [DataMember(Name="disable", EmitDefaultValue=false)]
        public BeezUPCommonLink2 Disable { get; set; }
        /// <summary>
        /// Gets or Sets Reenable
        /// </summary>
        [DataMember(Name="reenable", EmitDefaultValue=false)]
        public BeezUPCommonLink2 Reenable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogProductInfoLinks {\n");
            sb.Append("  _Override: ").Append(_Override).Append("\n");
            sb.Append("  Disable: ").Append(Disable).Append("\n");
            sb.Append("  Reenable: ").Append(Reenable).Append("\n");
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
            return this.Equals(obj as ChannelCatalogProductInfoLinks);
        }

        /// <summary>
        /// Returns true if ChannelCatalogProductInfoLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogProductInfoLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogProductInfoLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Override == other._Override ||
                    this._Override != null &&
                    this._Override.Equals(other._Override)
                ) && 
                (
                    this.Disable == other.Disable ||
                    this.Disable != null &&
                    this.Disable.Equals(other.Disable)
                ) && 
                (
                    this.Reenable == other.Reenable ||
                    this.Reenable != null &&
                    this.Reenable.Equals(other.Reenable)
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
                if (this._Override != null)
                    hash = hash * 59 + this._Override.GetHashCode();
                if (this.Disable != null)
                    hash = hash * 59 + this.Disable.GetHashCode();
                if (this.Reenable != null)
                    hash = hash * 59 + this.Reenable.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
