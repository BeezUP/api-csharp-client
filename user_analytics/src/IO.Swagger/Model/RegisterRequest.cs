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
    /// RegisterRequest
    /// </summary>
    [DataContract]
    public partial class RegisterRequest :  IEquatable<RegisterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest" /> class.
        /// </summary>
        /// <param name="Email">Your email. We refuse disposable email. (required).</param>
        /// <param name="Password">The password you want to use for your new account. \\ The password length must be greater or equals to 6 and lower or equals to 128. \\ The password must contains at least one number and one special character  (required).</param>
        /// <param name="CultureName">Can be null. Default: en-GB. The culture name you want to use. FYI. \\ The email activation will use this culture. .</param>
        /// <param name="CommercialOwnerUserId">The user id of your commercial in BeezUP..</param>
        public RegisterRequest(string Email = default(string), string Password = default(string), string CultureName = default(string), Guid? CommercialOwnerUserId = default(Guid?))
        {
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for RegisterRequest and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for RegisterRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.CultureName = CultureName;
            this.CommercialOwnerUserId = CommercialOwnerUserId;
        }
        
        /// <summary>
        /// Your email. We refuse disposable email.
        /// </summary>
        /// <value>Your email. We refuse disposable email.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The password you want to use for your new account. \\ The password length must be greater or equals to 6 and lower or equals to 128. \\ The password must contains at least one number and one special character 
        /// </summary>
        /// <value>The password you want to use for your new account. \\ The password length must be greater or equals to 6 and lower or equals to 128. \\ The password must contains at least one number and one special character </value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Can be null. Default: en-GB. The culture name you want to use. FYI. \\ The email activation will use this culture. 
        /// </summary>
        /// <value>Can be null. Default: en-GB. The culture name you want to use. FYI. \\ The email activation will use this culture. </value>
        [DataMember(Name="cultureName", EmitDefaultValue=false)]
        public string CultureName { get; set; }
        /// <summary>
        /// The user id of your commercial in BeezUP.
        /// </summary>
        /// <value>The user id of your commercial in BeezUP.</value>
        [DataMember(Name="commercialOwnerUserId", EmitDefaultValue=false)]
        public Guid? CommercialOwnerUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  CommercialOwnerUserId: ").Append(CommercialOwnerUserId).Append("\n");
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
            return this.Equals(obj as RegisterRequest);
        }

        /// <summary>
        /// Returns true if RegisterRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.CultureName == other.CultureName ||
                    this.CultureName != null &&
                    this.CultureName.Equals(other.CultureName)
                ) && 
                (
                    this.CommercialOwnerUserId == other.CommercialOwnerUserId ||
                    this.CommercialOwnerUserId != null &&
                    this.CommercialOwnerUserId.Equals(other.CommercialOwnerUserId)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.CultureName != null)
                    hash = hash * 59 + this.CultureName.GetHashCode();
                if (this.CommercialOwnerUserId != null)
                    hash = hash * 59 + this.CommercialOwnerUserId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
