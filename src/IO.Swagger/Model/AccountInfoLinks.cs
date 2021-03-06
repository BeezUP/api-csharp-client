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
    /// The different actions you can make on this account
    /// </summary>
    [DataContract]
    public partial class AccountInfoLinks :  IEquatable<AccountInfoLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfoLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountInfoLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfoLinks" /> class.
        /// </summary>
        /// <param name="SavePersonalInfo">SavePersonalInfo (required).</param>
        /// <param name="ChangePassword">ChangePassword (required).</param>
        /// <param name="SaveCompanyInfo">SaveCompanyInfo (required).</param>
        /// <param name="GetProfilePictureInfo">GetProfilePictureInfo (required).</param>
        /// <param name="SaveProfilePictureInfo">SaveProfilePictureInfo (required).</param>
        /// <param name="GetCreditCardInfo">GetCreditCardInfo (required).</param>
        /// <param name="SaveCreditCardInfo">SaveCreditCardInfo (required).</param>
        public AccountInfoLinks(LinksSavePersonalInfoLink SavePersonalInfo = default(LinksSavePersonalInfoLink), LinksChangePasswordLink ChangePassword = default(LinksChangePasswordLink), LinksSaveCompanyInfoLink SaveCompanyInfo = default(LinksSaveCompanyInfoLink), LinksGetProfilePictureInfoLink GetProfilePictureInfo = default(LinksGetProfilePictureInfoLink), LinksSaveProfilePictureInfoLink SaveProfilePictureInfo = default(LinksSaveProfilePictureInfoLink), LinksGetCreditCardInfoLink GetCreditCardInfo = default(LinksGetCreditCardInfoLink), LinksSaveCreditCardInfoLink SaveCreditCardInfo = default(LinksSaveCreditCardInfoLink))
        {
            // to ensure "SavePersonalInfo" is required (not null)
            if (SavePersonalInfo == null)
            {
                throw new InvalidDataException("SavePersonalInfo is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.SavePersonalInfo = SavePersonalInfo;
            }
            // to ensure "ChangePassword" is required (not null)
            if (ChangePassword == null)
            {
                throw new InvalidDataException("ChangePassword is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.ChangePassword = ChangePassword;
            }
            // to ensure "SaveCompanyInfo" is required (not null)
            if (SaveCompanyInfo == null)
            {
                throw new InvalidDataException("SaveCompanyInfo is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.SaveCompanyInfo = SaveCompanyInfo;
            }
            // to ensure "GetProfilePictureInfo" is required (not null)
            if (GetProfilePictureInfo == null)
            {
                throw new InvalidDataException("GetProfilePictureInfo is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.GetProfilePictureInfo = GetProfilePictureInfo;
            }
            // to ensure "SaveProfilePictureInfo" is required (not null)
            if (SaveProfilePictureInfo == null)
            {
                throw new InvalidDataException("SaveProfilePictureInfo is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.SaveProfilePictureInfo = SaveProfilePictureInfo;
            }
            // to ensure "GetCreditCardInfo" is required (not null)
            if (GetCreditCardInfo == null)
            {
                throw new InvalidDataException("GetCreditCardInfo is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.GetCreditCardInfo = GetCreditCardInfo;
            }
            // to ensure "SaveCreditCardInfo" is required (not null)
            if (SaveCreditCardInfo == null)
            {
                throw new InvalidDataException("SaveCreditCardInfo is a required property for AccountInfoLinks and cannot be null");
            }
            else
            {
                this.SaveCreditCardInfo = SaveCreditCardInfo;
            }
        }
        
        /// <summary>
        /// Gets or Sets SavePersonalInfo
        /// </summary>
        [DataMember(Name="savePersonalInfo", EmitDefaultValue=false)]
        public LinksSavePersonalInfoLink SavePersonalInfo { get; set; }
        /// <summary>
        /// Gets or Sets ChangePassword
        /// </summary>
        [DataMember(Name="changePassword", EmitDefaultValue=false)]
        public LinksChangePasswordLink ChangePassword { get; set; }
        /// <summary>
        /// Gets or Sets SaveCompanyInfo
        /// </summary>
        [DataMember(Name="saveCompanyInfo", EmitDefaultValue=false)]
        public LinksSaveCompanyInfoLink SaveCompanyInfo { get; set; }
        /// <summary>
        /// Gets or Sets GetProfilePictureInfo
        /// </summary>
        [DataMember(Name="getProfilePictureInfo", EmitDefaultValue=false)]
        public LinksGetProfilePictureInfoLink GetProfilePictureInfo { get; set; }
        /// <summary>
        /// Gets or Sets SaveProfilePictureInfo
        /// </summary>
        [DataMember(Name="saveProfilePictureInfo", EmitDefaultValue=false)]
        public LinksSaveProfilePictureInfoLink SaveProfilePictureInfo { get; set; }
        /// <summary>
        /// Gets or Sets GetCreditCardInfo
        /// </summary>
        [DataMember(Name="getCreditCardInfo", EmitDefaultValue=false)]
        public LinksGetCreditCardInfoLink GetCreditCardInfo { get; set; }
        /// <summary>
        /// Gets or Sets SaveCreditCardInfo
        /// </summary>
        [DataMember(Name="saveCreditCardInfo", EmitDefaultValue=false)]
        public LinksSaveCreditCardInfoLink SaveCreditCardInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfoLinks {\n");
            sb.Append("  SavePersonalInfo: ").Append(SavePersonalInfo).Append("\n");
            sb.Append("  ChangePassword: ").Append(ChangePassword).Append("\n");
            sb.Append("  SaveCompanyInfo: ").Append(SaveCompanyInfo).Append("\n");
            sb.Append("  GetProfilePictureInfo: ").Append(GetProfilePictureInfo).Append("\n");
            sb.Append("  SaveProfilePictureInfo: ").Append(SaveProfilePictureInfo).Append("\n");
            sb.Append("  GetCreditCardInfo: ").Append(GetCreditCardInfo).Append("\n");
            sb.Append("  SaveCreditCardInfo: ").Append(SaveCreditCardInfo).Append("\n");
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
            return this.Equals(obj as AccountInfoLinks);
        }

        /// <summary>
        /// Returns true if AccountInfoLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountInfoLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInfoLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SavePersonalInfo == other.SavePersonalInfo ||
                    this.SavePersonalInfo != null &&
                    this.SavePersonalInfo.Equals(other.SavePersonalInfo)
                ) && 
                (
                    this.ChangePassword == other.ChangePassword ||
                    this.ChangePassword != null &&
                    this.ChangePassword.Equals(other.ChangePassword)
                ) && 
                (
                    this.SaveCompanyInfo == other.SaveCompanyInfo ||
                    this.SaveCompanyInfo != null &&
                    this.SaveCompanyInfo.Equals(other.SaveCompanyInfo)
                ) && 
                (
                    this.GetProfilePictureInfo == other.GetProfilePictureInfo ||
                    this.GetProfilePictureInfo != null &&
                    this.GetProfilePictureInfo.Equals(other.GetProfilePictureInfo)
                ) && 
                (
                    this.SaveProfilePictureInfo == other.SaveProfilePictureInfo ||
                    this.SaveProfilePictureInfo != null &&
                    this.SaveProfilePictureInfo.Equals(other.SaveProfilePictureInfo)
                ) && 
                (
                    this.GetCreditCardInfo == other.GetCreditCardInfo ||
                    this.GetCreditCardInfo != null &&
                    this.GetCreditCardInfo.Equals(other.GetCreditCardInfo)
                ) && 
                (
                    this.SaveCreditCardInfo == other.SaveCreditCardInfo ||
                    this.SaveCreditCardInfo != null &&
                    this.SaveCreditCardInfo.Equals(other.SaveCreditCardInfo)
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
                if (this.SavePersonalInfo != null)
                    hash = hash * 59 + this.SavePersonalInfo.GetHashCode();
                if (this.ChangePassword != null)
                    hash = hash * 59 + this.ChangePassword.GetHashCode();
                if (this.SaveCompanyInfo != null)
                    hash = hash * 59 + this.SaveCompanyInfo.GetHashCode();
                if (this.GetProfilePictureInfo != null)
                    hash = hash * 59 + this.GetProfilePictureInfo.GetHashCode();
                if (this.SaveProfilePictureInfo != null)
                    hash = hash * 59 + this.SaveProfilePictureInfo.GetHashCode();
                if (this.GetCreditCardInfo != null)
                    hash = hash * 59 + this.GetCreditCardInfo.GetHashCode();
                if (this.SaveCreditCardInfo != null)
                    hash = hash * 59 + this.SaveCreditCardInfo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
