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
    /// ProfilePictureInfoResponse
    /// </summary>
    [DataContract]
    public partial class ProfilePictureInfoResponse :  IEquatable<ProfilePictureInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePictureInfoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfilePictureInfoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePictureInfoResponse" /> class.
        /// </summary>
        /// <param name="ProfilePictureInfo">ProfilePictureInfo (required).</param>
        /// <param name="Links">Links (required).</param>
        public ProfilePictureInfoResponse(ProfilePictureInfoWithDefault ProfilePictureInfo = default(ProfilePictureInfoWithDefault), ProfilePictureInfoResponseLinks Links = default(ProfilePictureInfoResponseLinks))
        {
            // to ensure "ProfilePictureInfo" is required (not null)
            if (ProfilePictureInfo == null)
            {
                throw new InvalidDataException("ProfilePictureInfo is a required property for ProfilePictureInfoResponse and cannot be null");
            }
            else
            {
                this.ProfilePictureInfo = ProfilePictureInfo;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for ProfilePictureInfoResponse and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
        }
        
        /// <summary>
        /// Gets or Sets ProfilePictureInfo
        /// </summary>
        [DataMember(Name="profilePictureInfo", EmitDefaultValue=false)]
        public ProfilePictureInfoWithDefault ProfilePictureInfo { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ProfilePictureInfoResponseLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfilePictureInfoResponse {\n");
            sb.Append("  ProfilePictureInfo: ").Append(ProfilePictureInfo).Append("\n");
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
            return this.Equals(obj as ProfilePictureInfoResponse);
        }

        /// <summary>
        /// Returns true if ProfilePictureInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfilePictureInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfilePictureInfoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProfilePictureInfo == other.ProfilePictureInfo ||
                    this.ProfilePictureInfo != null &&
                    this.ProfilePictureInfo.Equals(other.ProfilePictureInfo)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.ProfilePictureInfo != null)
                    hash = hash * 59 + this.ProfilePictureInfo.GetHashCode();
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
