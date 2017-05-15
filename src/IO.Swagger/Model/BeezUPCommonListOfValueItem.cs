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
    /// This object is used by LOV apis
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonListOfValueItem :  IEquatable<BeezUPCommonListOfValueItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonListOfValueItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonListOfValueItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonListOfValueItem" /> class.
        /// </summary>
        /// <param name="Position">Position.</param>
        /// <param name="CodeIdentifier">CodeIdentifier (required).</param>
        /// <param name="TranslationText">TranslationText.</param>
        /// <param name="IntIdentifier">IntIdentifier (required).</param>
        public BeezUPCommonListOfValueItem(int? Position = default(int?), string CodeIdentifier = default(string), string TranslationText = default(string), int? IntIdentifier = default(int?))
        {
            // to ensure "CodeIdentifier" is required (not null)
            if (CodeIdentifier == null)
            {
                throw new InvalidDataException("CodeIdentifier is a required property for BeezUPCommonListOfValueItem and cannot be null");
            }
            else
            {
                this.CodeIdentifier = CodeIdentifier;
            }
            // to ensure "IntIdentifier" is required (not null)
            if (IntIdentifier == null)
            {
                throw new InvalidDataException("IntIdentifier is a required property for BeezUPCommonListOfValueItem and cannot be null");
            }
            else
            {
                this.IntIdentifier = IntIdentifier;
            }
            this.Position = Position;
            this.TranslationText = TranslationText;
        }
        
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }
        /// <summary>
        /// Gets or Sets CodeIdentifier
        /// </summary>
        [DataMember(Name="codeIdentifier", EmitDefaultValue=false)]
        public string CodeIdentifier { get; set; }
        /// <summary>
        /// Gets or Sets TranslationText
        /// </summary>
        [DataMember(Name="translationText", EmitDefaultValue=false)]
        public string TranslationText { get; set; }
        /// <summary>
        /// Gets or Sets IntIdentifier
        /// </summary>
        [DataMember(Name="intIdentifier", EmitDefaultValue=false)]
        public int? IntIdentifier { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonListOfValueItem {\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  CodeIdentifier: ").Append(CodeIdentifier).Append("\n");
            sb.Append("  TranslationText: ").Append(TranslationText).Append("\n");
            sb.Append("  IntIdentifier: ").Append(IntIdentifier).Append("\n");
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
            return this.Equals(obj as BeezUPCommonListOfValueItem);
        }

        /// <summary>
        /// Returns true if BeezUPCommonListOfValueItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonListOfValueItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonListOfValueItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.CodeIdentifier == other.CodeIdentifier ||
                    this.CodeIdentifier != null &&
                    this.CodeIdentifier.Equals(other.CodeIdentifier)
                ) && 
                (
                    this.TranslationText == other.TranslationText ||
                    this.TranslationText != null &&
                    this.TranslationText.Equals(other.TranslationText)
                ) && 
                (
                    this.IntIdentifier == other.IntIdentifier ||
                    this.IntIdentifier != null &&
                    this.IntIdentifier.Equals(other.IntIdentifier)
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
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.CodeIdentifier != null)
                    hash = hash * 59 + this.CodeIdentifier.GetHashCode();
                if (this.TranslationText != null)
                    hash = hash * 59 + this.TranslationText.GetHashCode();
                if (this.IntIdentifier != null)
                    hash = hash * 59 + this.IntIdentifier.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
