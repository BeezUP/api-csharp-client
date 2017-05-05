/* 
 * Analytics
 *
 * This API will help you to manage the tracking of your clicks and your sales, get reporting on this trackings and put in place rules based on this reporting to automatically optimize your channel catalogs. \\ Also, you will be able to consult the rule execution reporting. 
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
    /// BeezUPCommonWarningSummary
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonWarningSummary :  IEquatable<BeezUPCommonWarningSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonWarningSummary" /> class.
        /// </summary>
        /// <param name="TechnicalErrorMessage">TechnicalErrorMessage.</param>
        /// <param name="WarningMessage">WarningMessage.</param>
        /// <param name="WarningCode">WarningCode.</param>
        /// <param name="WarningArguments">WarningArguments.</param>
        public BeezUPCommonWarningSummary(string TechnicalErrorMessage = default(string), string WarningMessage = default(string), string WarningCode = default(string), Dictionary<string, string> WarningArguments = default(Dictionary<string, string>))
        {
            this.TechnicalErrorMessage = TechnicalErrorMessage;
            this.WarningMessage = WarningMessage;
            this.WarningCode = WarningCode;
            this.WarningArguments = WarningArguments;
        }
        
        /// <summary>
        /// Gets or Sets TechnicalErrorMessage
        /// </summary>
        [DataMember(Name="technicalErrorMessage", EmitDefaultValue=false)]
        public string TechnicalErrorMessage { get; set; }
        /// <summary>
        /// Gets or Sets WarningMessage
        /// </summary>
        [DataMember(Name="warningMessage", EmitDefaultValue=false)]
        public string WarningMessage { get; set; }
        /// <summary>
        /// Gets or Sets WarningCode
        /// </summary>
        [DataMember(Name="warningCode", EmitDefaultValue=false)]
        public string WarningCode { get; set; }
        /// <summary>
        /// Gets or Sets WarningArguments
        /// </summary>
        [DataMember(Name="warningArguments", EmitDefaultValue=false)]
        public Dictionary<string, string> WarningArguments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonWarningSummary {\n");
            sb.Append("  TechnicalErrorMessage: ").Append(TechnicalErrorMessage).Append("\n");
            sb.Append("  WarningMessage: ").Append(WarningMessage).Append("\n");
            sb.Append("  WarningCode: ").Append(WarningCode).Append("\n");
            sb.Append("  WarningArguments: ").Append(WarningArguments).Append("\n");
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
            return this.Equals(obj as BeezUPCommonWarningSummary);
        }

        /// <summary>
        /// Returns true if BeezUPCommonWarningSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonWarningSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonWarningSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TechnicalErrorMessage == other.TechnicalErrorMessage ||
                    this.TechnicalErrorMessage != null &&
                    this.TechnicalErrorMessage.Equals(other.TechnicalErrorMessage)
                ) && 
                (
                    this.WarningMessage == other.WarningMessage ||
                    this.WarningMessage != null &&
                    this.WarningMessage.Equals(other.WarningMessage)
                ) && 
                (
                    this.WarningCode == other.WarningCode ||
                    this.WarningCode != null &&
                    this.WarningCode.Equals(other.WarningCode)
                ) && 
                (
                    this.WarningArguments == other.WarningArguments ||
                    this.WarningArguments != null &&
                    this.WarningArguments.SequenceEqual(other.WarningArguments)
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
                if (this.TechnicalErrorMessage != null)
                    hash = hash * 59 + this.TechnicalErrorMessage.GetHashCode();
                if (this.WarningMessage != null)
                    hash = hash * 59 + this.WarningMessage.GetHashCode();
                if (this.WarningCode != null)
                    hash = hash * 59 + this.WarningCode.GetHashCode();
                if (this.WarningArguments != null)
                    hash = hash * 59 + this.WarningArguments.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
