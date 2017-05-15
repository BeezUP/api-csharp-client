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
    /// The XML file description
    /// </summary>
    [DataContract]
    public partial class InputFileReadXmlConfiguration :  IEquatable<InputFileReadXmlConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileReadXmlConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputFileReadXmlConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileReadXmlConfiguration" /> class.
        /// </summary>
        /// <param name="UseXmlAttributes">Indicate if the importation should take in account the attribute in the xml nodes. (required).</param>
        /// <param name="FlattenXmlChildElements">Indicate if the children xml nodes should be flatten with there parent to take in account the sub node values. (required).</param>
        public InputFileReadXmlConfiguration(bool? UseXmlAttributes = default(bool?), bool? FlattenXmlChildElements = default(bool?))
        {
            // to ensure "UseXmlAttributes" is required (not null)
            if (UseXmlAttributes == null)
            {
                throw new InvalidDataException("UseXmlAttributes is a required property for InputFileReadXmlConfiguration and cannot be null");
            }
            else
            {
                this.UseXmlAttributes = UseXmlAttributes;
            }
            // to ensure "FlattenXmlChildElements" is required (not null)
            if (FlattenXmlChildElements == null)
            {
                throw new InvalidDataException("FlattenXmlChildElements is a required property for InputFileReadXmlConfiguration and cannot be null");
            }
            else
            {
                this.FlattenXmlChildElements = FlattenXmlChildElements;
            }
        }
        
        /// <summary>
        /// Indicate if the importation should take in account the attribute in the xml nodes.
        /// </summary>
        /// <value>Indicate if the importation should take in account the attribute in the xml nodes.</value>
        [DataMember(Name="useXmlAttributes", EmitDefaultValue=false)]
        public bool? UseXmlAttributes { get; set; }
        /// <summary>
        /// Indicate if the children xml nodes should be flatten with there parent to take in account the sub node values.
        /// </summary>
        /// <value>Indicate if the children xml nodes should be flatten with there parent to take in account the sub node values.</value>
        [DataMember(Name="flattenXmlChildElements", EmitDefaultValue=false)]
        public bool? FlattenXmlChildElements { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputFileReadXmlConfiguration {\n");
            sb.Append("  UseXmlAttributes: ").Append(UseXmlAttributes).Append("\n");
            sb.Append("  FlattenXmlChildElements: ").Append(FlattenXmlChildElements).Append("\n");
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
            return this.Equals(obj as InputFileReadXmlConfiguration);
        }

        /// <summary>
        /// Returns true if InputFileReadXmlConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of InputFileReadXmlConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputFileReadXmlConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UseXmlAttributes == other.UseXmlAttributes ||
                    this.UseXmlAttributes != null &&
                    this.UseXmlAttributes.Equals(other.UseXmlAttributes)
                ) && 
                (
                    this.FlattenXmlChildElements == other.FlattenXmlChildElements ||
                    this.FlattenXmlChildElements != null &&
                    this.FlattenXmlChildElements.Equals(other.FlattenXmlChildElements)
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
                if (this.UseXmlAttributes != null)
                    hash = hash * 59 + this.UseXmlAttributes.GetHashCode();
                if (this.FlattenXmlChildElements != null)
                    hash = hash * 59 + this.FlattenXmlChildElements.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
