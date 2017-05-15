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
    /// ChannelCatalogCategoryMappings
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogCategoryMappings :  IEquatable<ChannelCatalogCategoryMappings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogCategoryMappings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogCategoryMappings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogCategoryMappings" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="_ChannelCatalogCategoryMappings">_ChannelCatalogCategoryMappings (required).</param>
        public ChannelCatalogCategoryMappings(List<BeezUPCommonLink2> Links = default(List<BeezUPCommonLink2>), List<ChannelCatalogCategoryMappingInfo> _ChannelCatalogCategoryMappings = default(List<ChannelCatalogCategoryMappingInfo>))
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for ChannelCatalogCategoryMappings and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            // to ensure "_ChannelCatalogCategoryMappings" is required (not null)
            if (_ChannelCatalogCategoryMappings == null)
            {
                throw new InvalidDataException("_ChannelCatalogCategoryMappings is a required property for ChannelCatalogCategoryMappings and cannot be null");
            }
            else
            {
                this._ChannelCatalogCategoryMappings = _ChannelCatalogCategoryMappings;
            }
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<BeezUPCommonLink2> Links { get; set; }
        /// <summary>
        /// Gets or Sets _ChannelCatalogCategoryMappings
        /// </summary>
        [DataMember(Name="channelCatalogCategoryMappings", EmitDefaultValue=false)]
        public List<ChannelCatalogCategoryMappingInfo> _ChannelCatalogCategoryMappings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogCategoryMappings {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _ChannelCatalogCategoryMappings: ").Append(_ChannelCatalogCategoryMappings).Append("\n");
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
            return this.Equals(obj as ChannelCatalogCategoryMappings);
        }

        /// <summary>
        /// Returns true if ChannelCatalogCategoryMappings instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogCategoryMappings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogCategoryMappings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) && 
                (
                    this._ChannelCatalogCategoryMappings == other._ChannelCatalogCategoryMappings ||
                    this._ChannelCatalogCategoryMappings != null &&
                    this._ChannelCatalogCategoryMappings.SequenceEqual(other._ChannelCatalogCategoryMappings)
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
                if (this._ChannelCatalogCategoryMappings != null)
                    hash = hash * 59 + this._ChannelCatalogCategoryMappings.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
