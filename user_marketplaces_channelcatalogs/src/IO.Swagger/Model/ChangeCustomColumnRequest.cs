/* 
 * Catalogs
 *
 * This API allows you to manage your catalogs
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
    /// The message request to change a custom column expression an user name
    /// </summary>
    [DataContract]
    public partial class ChangeCustomColumnRequest :  IEquatable<ChangeCustomColumnRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeCustomColumnRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeCustomColumnRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeCustomColumnRequest" /> class.
        /// </summary>
        /// <param name="EncryptedExpression">EncryptedExpression (required).</param>
        /// <param name="EncryptedBlocklyExpression">EncryptedBlocklyExpression (required).</param>
        /// <param name="UserColumName">UserColumName (required).</param>
        public ChangeCustomColumnRequest(EncryptedExpression EncryptedExpression = default(EncryptedExpression), EncryptedBlocklyExpression EncryptedBlocklyExpression = default(EncryptedBlocklyExpression), UserColumName UserColumName = default(UserColumName))
        {
            // to ensure "EncryptedExpression" is required (not null)
            if (EncryptedExpression == null)
            {
                throw new InvalidDataException("EncryptedExpression is a required property for ChangeCustomColumnRequest and cannot be null");
            }
            else
            {
                this.EncryptedExpression = EncryptedExpression;
            }
            // to ensure "EncryptedBlocklyExpression" is required (not null)
            if (EncryptedBlocklyExpression == null)
            {
                throw new InvalidDataException("EncryptedBlocklyExpression is a required property for ChangeCustomColumnRequest and cannot be null");
            }
            else
            {
                this.EncryptedBlocklyExpression = EncryptedBlocklyExpression;
            }
            // to ensure "UserColumName" is required (not null)
            if (UserColumName == null)
            {
                throw new InvalidDataException("UserColumName is a required property for ChangeCustomColumnRequest and cannot be null");
            }
            else
            {
                this.UserColumName = UserColumName;
            }
        }
        
        /// <summary>
        /// Gets or Sets EncryptedExpression
        /// </summary>
        [DataMember(Name="encryptedExpression", EmitDefaultValue=false)]
        public EncryptedExpression EncryptedExpression { get; set; }
        /// <summary>
        /// Gets or Sets EncryptedBlocklyExpression
        /// </summary>
        [DataMember(Name="encryptedBlocklyExpression", EmitDefaultValue=false)]
        public EncryptedBlocklyExpression EncryptedBlocklyExpression { get; set; }
        /// <summary>
        /// Gets or Sets UserColumName
        /// </summary>
        [DataMember(Name="userColumName", EmitDefaultValue=false)]
        public UserColumName UserColumName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeCustomColumnRequest {\n");
            sb.Append("  EncryptedExpression: ").Append(EncryptedExpression).Append("\n");
            sb.Append("  EncryptedBlocklyExpression: ").Append(EncryptedBlocklyExpression).Append("\n");
            sb.Append("  UserColumName: ").Append(UserColumName).Append("\n");
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
            return this.Equals(obj as ChangeCustomColumnRequest);
        }

        /// <summary>
        /// Returns true if ChangeCustomColumnRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangeCustomColumnRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeCustomColumnRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EncryptedExpression == other.EncryptedExpression ||
                    this.EncryptedExpression != null &&
                    this.EncryptedExpression.Equals(other.EncryptedExpression)
                ) && 
                (
                    this.EncryptedBlocklyExpression == other.EncryptedBlocklyExpression ||
                    this.EncryptedBlocklyExpression != null &&
                    this.EncryptedBlocklyExpression.Equals(other.EncryptedBlocklyExpression)
                ) && 
                (
                    this.UserColumName == other.UserColumName ||
                    this.UserColumName != null &&
                    this.UserColumName.Equals(other.UserColumName)
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
                if (this.EncryptedExpression != null)
                    hash = hash * 59 + this.EncryptedExpression.GetHashCode();
                if (this.EncryptedBlocklyExpression != null)
                    hash = hash * 59 + this.EncryptedBlocklyExpression.GetHashCode();
                if (this.UserColumName != null)
                    hash = hash * 59 + this.UserColumName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}