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
    /// The message request for the change user column name
    /// </summary>
    [DataContract]
    public partial class ChangeUserColumnNameRequest :  IEquatable<ChangeUserColumnNameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeUserColumnNameRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeUserColumnNameRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeUserColumnNameRequest" /> class.
        /// </summary>
        /// <param name="UserColumName">UserColumName (required).</param>
        public ChangeUserColumnNameRequest(UserColumName UserColumName = default(UserColumName))
        {
            // to ensure "UserColumName" is required (not null)
            if (UserColumName == null)
            {
                throw new InvalidDataException("UserColumName is a required property for ChangeUserColumnNameRequest and cannot be null");
            }
            else
            {
                this.UserColumName = UserColumName;
            }
        }
        
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
            sb.Append("class ChangeUserColumnNameRequest {\n");
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
            return this.Equals(obj as ChangeUserColumnNameRequest);
        }

        /// <summary>
        /// Returns true if ChangeUserColumnNameRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangeUserColumnNameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeUserColumnNameRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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