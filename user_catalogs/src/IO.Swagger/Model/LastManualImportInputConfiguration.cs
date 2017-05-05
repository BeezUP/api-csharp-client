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
    /// Last manual import input configuration
    /// </summary>
    [DataContract]
    public partial class LastManualImportInputConfiguration :  IEquatable<LastManualImportInputConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastManualImportInputConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LastManualImportInputConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LastManualImportInputConfiguration" /> class.
        /// </summary>
        /// <param name="Input">Input (required).</param>
        public LastManualImportInputConfiguration(InputConfiguration Input = default(InputConfiguration))
        {
            // to ensure "Input" is required (not null)
            if (Input == null)
            {
                throw new InvalidDataException("Input is a required property for LastManualImportInputConfiguration and cannot be null");
            }
            else
            {
                this.Input = Input;
            }
        }
        
        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public InputConfiguration Input { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LastManualImportInputConfiguration {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
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
            return this.Equals(obj as LastManualImportInputConfiguration);
        }

        /// <summary>
        /// Returns true if LastManualImportInputConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of LastManualImportInputConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LastManualImportInputConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
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
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}