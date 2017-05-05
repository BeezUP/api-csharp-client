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
    /// LoginRequest
    /// </summary>
    [DataContract]
    public partial class LoginRequest :  IEquatable<LoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoginRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRequest" /> class.
        /// </summary>
        /// <param name="Login">Login (required).</param>
        /// <param name="Password">Your password (required).</param>
        public LoginRequest(BeezUPCommonEmail Login = default(BeezUPCommonEmail), string Password = default(string))
        {
            // to ensure "Login" is required (not null)
            if (Login == null)
            {
                throw new InvalidDataException("Login is a required property for LoginRequest and cannot be null");
            }
            else
            {
                this.Login = Login;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for LoginRequest and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
        }
        
        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public BeezUPCommonEmail Login { get; set; }
        /// <summary>
        /// Your password
        /// </summary>
        /// <value>Your password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginRequest {\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(obj as LoginRequest);
        }

        /// <summary>
        /// Returns true if LoginRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
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
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}