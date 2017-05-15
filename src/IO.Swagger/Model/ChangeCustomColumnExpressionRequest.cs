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
    /// The request message to change the custom column expression
    /// </summary>
    [DataContract]
    public partial class ChangeCustomColumnExpressionRequest :  IEquatable<ChangeCustomColumnExpressionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeCustomColumnExpressionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeCustomColumnExpressionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeCustomColumnExpressionRequest" /> class.
        /// </summary>
        /// <param name="EncryptedExpression">EncryptedExpression (required).</param>
        /// <param name="EncryptedBlocklyExpression">EncryptedBlocklyExpression (required).</param>
        public ChangeCustomColumnExpressionRequest(EncryptedExpression EncryptedExpression = default(EncryptedExpression), EncryptedBlocklyExpression EncryptedBlocklyExpression = default(EncryptedBlocklyExpression))
        {
            // to ensure "EncryptedExpression" is required (not null)
            if (EncryptedExpression == null)
            {
                throw new InvalidDataException("EncryptedExpression is a required property for ChangeCustomColumnExpressionRequest and cannot be null");
            }
            else
            {
                this.EncryptedExpression = EncryptedExpression;
            }
            // to ensure "EncryptedBlocklyExpression" is required (not null)
            if (EncryptedBlocklyExpression == null)
            {
                throw new InvalidDataException("EncryptedBlocklyExpression is a required property for ChangeCustomColumnExpressionRequest and cannot be null");
            }
            else
            {
                this.EncryptedBlocklyExpression = EncryptedBlocklyExpression;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeCustomColumnExpressionRequest {\n");
            sb.Append("  EncryptedExpression: ").Append(EncryptedExpression).Append("\n");
            sb.Append("  EncryptedBlocklyExpression: ").Append(EncryptedBlocklyExpression).Append("\n");
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
            return this.Equals(obj as ChangeCustomColumnExpressionRequest);
        }

        /// <summary>
        /// Returns true if ChangeCustomColumnExpressionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangeCustomColumnExpressionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeCustomColumnExpressionRequest other)
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
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
