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
    /// The custom column configuration
    /// </summary>
    [DataContract]
    public partial class CustomColumn :  IEquatable<CustomColumn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColumn" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="UserColumName">UserColumName (required).</param>
        /// <param name="Configuration">Configuration (required).</param>
        public CustomColumn(ColumnId Id = default(ColumnId), UserColumName UserColumName = default(UserColumName), ColumnConfiguration Configuration = default(ColumnConfiguration))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for CustomColumn and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "UserColumName" is required (not null)
            if (UserColumName == null)
            {
                throw new InvalidDataException("UserColumName is a required property for CustomColumn and cannot be null");
            }
            else
            {
                this.UserColumName = UserColumName;
            }
            // to ensure "Configuration" is required (not null)
            if (Configuration == null)
            {
                throw new InvalidDataException("Configuration is a required property for CustomColumn and cannot be null");
            }
            else
            {
                this.Configuration = Configuration;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ColumnId Id { get; set; }
        /// <summary>
        /// Gets or Sets UserColumName
        /// </summary>
        [DataMember(Name="userColumName", EmitDefaultValue=false)]
        public UserColumName UserColumName { get; set; }
        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public ColumnConfiguration Configuration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomColumn {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserColumName: ").Append(UserColumName).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
            return this.Equals(obj as CustomColumn);
        }

        /// <summary>
        /// Returns true if CustomColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomColumn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UserColumName == other.UserColumName ||
                    this.UserColumName != null &&
                    this.UserColumName.Equals(other.UserColumName)
                ) && 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.Equals(other.Configuration)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UserColumName != null)
                    hash = hash * 59 + this.UserColumName.GetHashCode();
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
