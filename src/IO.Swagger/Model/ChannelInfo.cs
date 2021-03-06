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
    /// ChannelInfo
    /// </summary>
    [DataContract]
    public partial class ChannelInfo :  IEquatable<ChannelInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelInfo" /> class.
        /// </summary>
        /// <param name="Name">The channel name (required).</param>
        /// <param name="HomeUrl">The channel home url (required).</param>
        /// <param name="LogoUrl">The channel logo url (required).</param>
        /// <param name="Types">The type list related to a channel (required).</param>
        public ChannelInfo(string Name = default(string), string HomeUrl = default(string), string LogoUrl = default(string), List<string> Types = default(List<string>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ChannelInfo and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "HomeUrl" is required (not null)
            if (HomeUrl == null)
            {
                throw new InvalidDataException("HomeUrl is a required property for ChannelInfo and cannot be null");
            }
            else
            {
                this.HomeUrl = HomeUrl;
            }
            // to ensure "LogoUrl" is required (not null)
            if (LogoUrl == null)
            {
                throw new InvalidDataException("LogoUrl is a required property for ChannelInfo and cannot be null");
            }
            else
            {
                this.LogoUrl = LogoUrl;
            }
            // to ensure "Types" is required (not null)
            if (Types == null)
            {
                throw new InvalidDataException("Types is a required property for ChannelInfo and cannot be null");
            }
            else
            {
                this.Types = Types;
            }
        }
        
        /// <summary>
        /// The channel name
        /// </summary>
        /// <value>The channel name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The channel home url
        /// </summary>
        /// <value>The channel home url</value>
        [DataMember(Name="homeUrl", EmitDefaultValue=false)]
        public string HomeUrl { get; set; }
        /// <summary>
        /// The channel logo url
        /// </summary>
        /// <value>The channel logo url</value>
        [DataMember(Name="logoUrl", EmitDefaultValue=false)]
        public string LogoUrl { get; set; }
        /// <summary>
        /// The type list related to a channel
        /// </summary>
        /// <value>The type list related to a channel</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HomeUrl: ").Append(HomeUrl).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(obj as ChannelInfo);
        }

        /// <summary>
        /// Returns true if ChannelInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.HomeUrl == other.HomeUrl ||
                    this.HomeUrl != null &&
                    this.HomeUrl.Equals(other.HomeUrl)
                ) && 
                (
                    this.LogoUrl == other.LogoUrl ||
                    this.LogoUrl != null &&
                    this.LogoUrl.Equals(other.LogoUrl)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.HomeUrl != null)
                    hash = hash * 59 + this.HomeUrl.GetHashCode();
                if (this.LogoUrl != null)
                    hash = hash * 59 + this.LogoUrl.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
