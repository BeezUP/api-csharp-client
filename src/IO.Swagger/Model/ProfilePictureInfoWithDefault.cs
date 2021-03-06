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
    /// ProfilePictureInfoWithDefault
    /// </summary>
    [DataContract]
    public partial class ProfilePictureInfoWithDefault :  IEquatable<ProfilePictureInfoWithDefault>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePictureInfoWithDefault" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfilePictureInfoWithDefault() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePictureInfoWithDefault" /> class.
        /// </summary>
        /// <param name="ProfilePictureUrl">ProfilePictureUrl.</param>
        /// <param name="ProfilePictureSelected">ProfilePictureSelected (required).</param>
        /// <param name="InitialsProfilePictureUrl">InitialsProfilePictureUrl (required).</param>
        /// <param name="GravatarProfilePictureUrl">GravatarProfilePictureUrl (required).</param>
        public ProfilePictureInfoWithDefault(ProfilePictureUrl ProfilePictureUrl = default(ProfilePictureUrl), ProfilePictureSelected ProfilePictureSelected = default(ProfilePictureSelected), InitialsProfilePictureUrl InitialsProfilePictureUrl = default(InitialsProfilePictureUrl), GravatarProfilePictureUrl GravatarProfilePictureUrl = default(GravatarProfilePictureUrl))
        {
            // to ensure "ProfilePictureSelected" is required (not null)
            if (ProfilePictureSelected == null)
            {
                throw new InvalidDataException("ProfilePictureSelected is a required property for ProfilePictureInfoWithDefault and cannot be null");
            }
            else
            {
                this.ProfilePictureSelected = ProfilePictureSelected;
            }
            // to ensure "InitialsProfilePictureUrl" is required (not null)
            if (InitialsProfilePictureUrl == null)
            {
                throw new InvalidDataException("InitialsProfilePictureUrl is a required property for ProfilePictureInfoWithDefault and cannot be null");
            }
            else
            {
                this.InitialsProfilePictureUrl = InitialsProfilePictureUrl;
            }
            // to ensure "GravatarProfilePictureUrl" is required (not null)
            if (GravatarProfilePictureUrl == null)
            {
                throw new InvalidDataException("GravatarProfilePictureUrl is a required property for ProfilePictureInfoWithDefault and cannot be null");
            }
            else
            {
                this.GravatarProfilePictureUrl = GravatarProfilePictureUrl;
            }
            this.ProfilePictureUrl = ProfilePictureUrl;
        }
        
        /// <summary>
        /// Gets or Sets ProfilePictureUrl
        /// </summary>
        [DataMember(Name="profilePictureUrl", EmitDefaultValue=false)]
        public ProfilePictureUrl ProfilePictureUrl { get; set; }
        /// <summary>
        /// Gets or Sets ProfilePictureSelected
        /// </summary>
        [DataMember(Name="profilePictureSelected", EmitDefaultValue=false)]
        public ProfilePictureSelected ProfilePictureSelected { get; set; }
        /// <summary>
        /// Gets or Sets InitialsProfilePictureUrl
        /// </summary>
        [DataMember(Name="initialsProfilePictureUrl", EmitDefaultValue=false)]
        public InitialsProfilePictureUrl InitialsProfilePictureUrl { get; set; }
        /// <summary>
        /// Gets or Sets GravatarProfilePictureUrl
        /// </summary>
        [DataMember(Name="gravatarProfilePictureUrl", EmitDefaultValue=false)]
        public GravatarProfilePictureUrl GravatarProfilePictureUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfilePictureInfoWithDefault {\n");
            sb.Append("  ProfilePictureUrl: ").Append(ProfilePictureUrl).Append("\n");
            sb.Append("  ProfilePictureSelected: ").Append(ProfilePictureSelected).Append("\n");
            sb.Append("  InitialsProfilePictureUrl: ").Append(InitialsProfilePictureUrl).Append("\n");
            sb.Append("  GravatarProfilePictureUrl: ").Append(GravatarProfilePictureUrl).Append("\n");
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
            return this.Equals(obj as ProfilePictureInfoWithDefault);
        }

        /// <summary>
        /// Returns true if ProfilePictureInfoWithDefault instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfilePictureInfoWithDefault to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfilePictureInfoWithDefault other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProfilePictureUrl == other.ProfilePictureUrl ||
                    this.ProfilePictureUrl != null &&
                    this.ProfilePictureUrl.Equals(other.ProfilePictureUrl)
                ) && 
                (
                    this.ProfilePictureSelected == other.ProfilePictureSelected ||
                    this.ProfilePictureSelected != null &&
                    this.ProfilePictureSelected.Equals(other.ProfilePictureSelected)
                ) && 
                (
                    this.InitialsProfilePictureUrl == other.InitialsProfilePictureUrl ||
                    this.InitialsProfilePictureUrl != null &&
                    this.InitialsProfilePictureUrl.Equals(other.InitialsProfilePictureUrl)
                ) && 
                (
                    this.GravatarProfilePictureUrl == other.GravatarProfilePictureUrl ||
                    this.GravatarProfilePictureUrl != null &&
                    this.GravatarProfilePictureUrl.Equals(other.GravatarProfilePictureUrl)
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
                if (this.ProfilePictureUrl != null)
                    hash = hash * 59 + this.ProfilePictureUrl.GetHashCode();
                if (this.ProfilePictureSelected != null)
                    hash = hash * 59 + this.ProfilePictureSelected.GetHashCode();
                if (this.InitialsProfilePictureUrl != null)
                    hash = hash * 59 + this.InitialsProfilePictureUrl.GetHashCode();
                if (this.GravatarProfilePictureUrl != null)
                    hash = hash * 59 + this.GravatarProfilePictureUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
