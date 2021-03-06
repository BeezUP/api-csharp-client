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
    /// Describe the input configuration
    /// </summary>
    [DataContract]
    public partial class InputConfiguration :  IEquatable<InputConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputConfiguration" /> class.
        /// </summary>
        /// <param name="TransformFileUrl">Can be null. Use to transform multiple files with an XSLT file..</param>
        /// <param name="Files">The list of files to get and read (required).</param>
        public InputConfiguration(string TransformFileUrl = default(string), List<InputFileConfiguration> Files = default(List<InputFileConfiguration>))
        {
            // to ensure "Files" is required (not null)
            if (Files == null)
            {
                throw new InvalidDataException("Files is a required property for InputConfiguration and cannot be null");
            }
            else
            {
                this.Files = Files;
            }
            this.TransformFileUrl = TransformFileUrl;
        }
        
        /// <summary>
        /// Can be null. Use to transform multiple files with an XSLT file.
        /// </summary>
        /// <value>Can be null. Use to transform multiple files with an XSLT file.</value>
        [DataMember(Name="transformFileUrl", EmitDefaultValue=false)]
        public string TransformFileUrl { get; set; }
        /// <summary>
        /// The list of files to get and read
        /// </summary>
        /// <value>The list of files to get and read</value>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<InputFileConfiguration> Files { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputConfiguration {\n");
            sb.Append("  TransformFileUrl: ").Append(TransformFileUrl).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
            return this.Equals(obj as InputConfiguration);
        }

        /// <summary>
        /// Returns true if InputConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of InputConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransformFileUrl == other.TransformFileUrl ||
                    this.TransformFileUrl != null &&
                    this.TransformFileUrl.Equals(other.TransformFileUrl)
                ) && 
                (
                    this.Files == other.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(other.Files)
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
                if (this.TransformFileUrl != null)
                    hash = hash * 59 + this.TransformFileUrl.GetHashCode();
                if (this.Files != null)
                    hash = hash * 59 + this.Files.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
