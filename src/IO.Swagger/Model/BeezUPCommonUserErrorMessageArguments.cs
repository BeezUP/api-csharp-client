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
    /// BeezUPCommonUserErrorMessageArguments
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonUserErrorMessageArguments :  IEquatable<BeezUPCommonUserErrorMessageArguments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonUserErrorMessageArguments" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonUserErrorMessageArguments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonUserErrorMessageArguments" /> class.
        /// </summary>
        /// <param name="Name">The key of the parameter (required).</param>
        /// <param name="Value">The value of the parameter. Depending to the type. (required).</param>
        public BeezUPCommonUserErrorMessageArguments(string Name = default(string), Object Value = default(Object))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BeezUPCommonUserErrorMessageArguments and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for BeezUPCommonUserErrorMessageArguments and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
        }
        
        /// <summary>
        /// The key of the parameter
        /// </summary>
        /// <value>The key of the parameter</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The value of the parameter. Depending to the type.
        /// </summary>
        /// <value>The value of the parameter. Depending to the type.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonUserErrorMessageArguments {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as BeezUPCommonUserErrorMessageArguments);
        }

        /// <summary>
        /// Returns true if BeezUPCommonUserErrorMessageArguments instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonUserErrorMessageArguments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonUserErrorMessageArguments other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
