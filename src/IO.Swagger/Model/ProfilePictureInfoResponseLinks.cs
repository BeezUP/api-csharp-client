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
    /// ProfilePictureInfoResponseLinks
    /// </summary>
    [DataContract]
    public partial class ProfilePictureInfoResponseLinks :  IEquatable<ProfilePictureInfoResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePictureInfoResponseLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfilePictureInfoResponseLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilePictureInfoResponseLinks" /> class.
        /// </summary>
        /// <param name="Self">Self (required).</param>
        /// <param name="Save">Save (required).</param>
        public ProfilePictureInfoResponseLinks(LinksGetProfilePictureInfoLink Self = default(LinksGetProfilePictureInfoLink), LinksSaveProfilePictureInfoLink Save = default(LinksSaveProfilePictureInfoLink))
        {
            // to ensure "Self" is required (not null)
            if (Self == null)
            {
                throw new InvalidDataException("Self is a required property for ProfilePictureInfoResponseLinks and cannot be null");
            }
            else
            {
                this.Self = Self;
            }
            // to ensure "Save" is required (not null)
            if (Save == null)
            {
                throw new InvalidDataException("Save is a required property for ProfilePictureInfoResponseLinks and cannot be null");
            }
            else
            {
                this.Save = Save;
            }
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public LinksGetProfilePictureInfoLink Self { get; set; }
        /// <summary>
        /// Gets or Sets Save
        /// </summary>
        [DataMember(Name="save", EmitDefaultValue=false)]
        public LinksSaveProfilePictureInfoLink Save { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfilePictureInfoResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
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
            return this.Equals(obj as ProfilePictureInfoResponseLinks);
        }

        /// <summary>
        /// Returns true if ProfilePictureInfoResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfilePictureInfoResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfilePictureInfoResponseLinks other)
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
                    this.Save == other.Save ||
                    this.Save != null &&
                    this.Save.Equals(other.Save)
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
                if (this.Save != null)
                    hash = hash * 59 + this.Save.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}