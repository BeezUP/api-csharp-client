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
    /// Describe the way you have to follow to get access to the LOV
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonLOVLink3 :  IEquatable<BeezUPCommonLOVLink3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLOVLink3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonLOVLink3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLOVLink3" /> class.
        /// </summary>
        /// <param name="Href">Indicate the uri to the list of value (required).</param>
        /// <param name="Method">Method.</param>
        public BeezUPCommonLOVLink3(string Href = default(string), BeezUPCommonHttpMethod Method = default(BeezUPCommonHttpMethod))
        {
            // to ensure "Href" is required (not null)
            if (Href == null)
            {
                throw new InvalidDataException("Href is a required property for BeezUPCommonLOVLink3 and cannot be null");
            }
            else
            {
                this.Href = Href;
            }
            this.Method = Method;
        }
        
        /// <summary>
        /// Indicate the uri to the list of value
        /// </summary>
        /// <value>Indicate the uri to the list of value</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public BeezUPCommonHttpMethod Method { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonLOVLink3 {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(obj as BeezUPCommonLOVLink3);
        }

        /// <summary>
        /// Returns true if BeezUPCommonLOVLink3 instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonLOVLink3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonLOVLink3 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
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
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
