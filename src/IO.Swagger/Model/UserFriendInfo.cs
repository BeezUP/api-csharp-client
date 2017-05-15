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
    /// UserFriendInfo
    /// </summary>
    [DataContract]
    public partial class UserFriendInfo :  IEquatable<UserFriendInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFriendInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserFriendInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFriendInfo" /> class.
        /// </summary>
        /// <param name="UserId">Your friend&#39;s user id (required).</param>
        /// <param name="LastName">Your friend&#39;s user last name (required).</param>
        /// <param name="FirstName">Your friend&#39;s user first name (required).</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="ProfilePictureUrl">ProfilePictureUrl.</param>
        /// <param name="CountryIsoCodeAlpha3">CountryIsoCodeAlpha3 (required).</param>
        /// <param name="Company">Your friend&#39;s user company name (required).</param>
        /// <param name="WhatIDo">Your friend&#39;s user occupation in his company (required).</param>
        public UserFriendInfo(string UserId = default(string), string LastName = default(string), string FirstName = default(string), FriendEmail Email = default(FriendEmail), FriendProfilePictureUrl ProfilePictureUrl = default(FriendProfilePictureUrl), FriendCountryIsoCodeAlpha3 CountryIsoCodeAlpha3 = default(FriendCountryIsoCodeAlpha3), string Company = default(string), string WhatIDo = default(string))
        {
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "CountryIsoCodeAlpha3" is required (not null)
            if (CountryIsoCodeAlpha3 == null)
            {
                throw new InvalidDataException("CountryIsoCodeAlpha3 is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.CountryIsoCodeAlpha3 = CountryIsoCodeAlpha3;
            }
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            // to ensure "WhatIDo" is required (not null)
            if (WhatIDo == null)
            {
                throw new InvalidDataException("WhatIDo is a required property for UserFriendInfo and cannot be null");
            }
            else
            {
                this.WhatIDo = WhatIDo;
            }
            this.ProfilePictureUrl = ProfilePictureUrl;
        }
        
        /// <summary>
        /// Your friend&#39;s user id
        /// </summary>
        /// <value>Your friend&#39;s user id</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Your friend&#39;s user last name
        /// </summary>
        /// <value>Your friend&#39;s user last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Your friend&#39;s user first name
        /// </summary>
        /// <value>Your friend&#39;s user first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public FriendEmail Email { get; set; }
        /// <summary>
        /// Gets or Sets ProfilePictureUrl
        /// </summary>
        [DataMember(Name="profilePictureUrl", EmitDefaultValue=false)]
        public FriendProfilePictureUrl ProfilePictureUrl { get; set; }
        /// <summary>
        /// Gets or Sets CountryIsoCodeAlpha3
        /// </summary>
        [DataMember(Name="countryIsoCodeAlpha3", EmitDefaultValue=false)]
        public FriendCountryIsoCodeAlpha3 CountryIsoCodeAlpha3 { get; set; }
        /// <summary>
        /// Your friend&#39;s user company name
        /// </summary>
        /// <value>Your friend&#39;s user company name</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
        /// <summary>
        /// Your friend&#39;s user occupation in his company
        /// </summary>
        /// <value>Your friend&#39;s user occupation in his company</value>
        [DataMember(Name="whatIDo", EmitDefaultValue=false)]
        public string WhatIDo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserFriendInfo {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ProfilePictureUrl: ").Append(ProfilePictureUrl).Append("\n");
            sb.Append("  CountryIsoCodeAlpha3: ").Append(CountryIsoCodeAlpha3).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  WhatIDo: ").Append(WhatIDo).Append("\n");
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
            return this.Equals(obj as UserFriendInfo);
        }

        /// <summary>
        /// Returns true if UserFriendInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserFriendInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserFriendInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ProfilePictureUrl == other.ProfilePictureUrl ||
                    this.ProfilePictureUrl != null &&
                    this.ProfilePictureUrl.Equals(other.ProfilePictureUrl)
                ) && 
                (
                    this.CountryIsoCodeAlpha3 == other.CountryIsoCodeAlpha3 ||
                    this.CountryIsoCodeAlpha3 != null &&
                    this.CountryIsoCodeAlpha3.Equals(other.CountryIsoCodeAlpha3)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.WhatIDo == other.WhatIDo ||
                    this.WhatIDo != null &&
                    this.WhatIDo.Equals(other.WhatIDo)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ProfilePictureUrl != null)
                    hash = hash * 59 + this.ProfilePictureUrl.GetHashCode();
                if (this.CountryIsoCodeAlpha3 != null)
                    hash = hash * 59 + this.CountryIsoCodeAlpha3.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.WhatIDo != null)
                    hash = hash * 59 + this.WhatIDo.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
