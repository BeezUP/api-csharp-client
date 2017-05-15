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
    /// PublicChannelIndexLinks
    /// </summary>
    [DataContract]
    public partial class PublicChannelIndexLinks :  IEquatable<PublicChannelIndexLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicChannelIndexLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="ChannelCountryLov">ChannelCountryLov.</param>
        /// <param name="ChannelTypeLov">ChannelTypeLov.</param>
        public PublicChannelIndexLinks(LinksGetChannelsIndexLink Self = default(LinksGetChannelsIndexLink), LinksGetPublicListOfValuesLink ChannelCountryLov = default(LinksGetPublicListOfValuesLink), LinksGetPublicListOfValuesLink ChannelTypeLov = default(LinksGetPublicListOfValuesLink))
        {
            this.Self = Self;
            this.ChannelCountryLov = ChannelCountryLov;
            this.ChannelTypeLov = ChannelTypeLov;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public LinksGetChannelsIndexLink Self { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCountryLov
        /// </summary>
        [DataMember(Name="channelCountryLov", EmitDefaultValue=false)]
        public LinksGetPublicListOfValuesLink ChannelCountryLov { get; set; }
        /// <summary>
        /// Gets or Sets ChannelTypeLov
        /// </summary>
        [DataMember(Name="channelTypeLov", EmitDefaultValue=false)]
        public LinksGetPublicListOfValuesLink ChannelTypeLov { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicChannelIndexLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  ChannelCountryLov: ").Append(ChannelCountryLov).Append("\n");
            sb.Append("  ChannelTypeLov: ").Append(ChannelTypeLov).Append("\n");
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
            return this.Equals(obj as PublicChannelIndexLinks);
        }

        /// <summary>
        /// Returns true if PublicChannelIndexLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PublicChannelIndexLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicChannelIndexLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.ChannelCountryLov == other.ChannelCountryLov ||
                    this.ChannelCountryLov != null &&
                    this.ChannelCountryLov.Equals(other.ChannelCountryLov)
                ) && 
                (
                    this.ChannelTypeLov == other.ChannelTypeLov ||
                    this.ChannelTypeLov != null &&
                    this.ChannelTypeLov.Equals(other.ChannelTypeLov)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.ChannelCountryLov != null)
                    hash = hash * 59 + this.ChannelCountryLov.GetHashCode();
                if (this.ChannelTypeLov != null)
                    hash = hash * 59 + this.ChannelTypeLov.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
