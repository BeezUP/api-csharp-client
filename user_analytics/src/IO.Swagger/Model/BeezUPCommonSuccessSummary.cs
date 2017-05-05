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
    /// BeezUPCommonSuccessSummary
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonSuccessSummary :  IEquatable<BeezUPCommonSuccessSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonSuccessSummary" /> class.
        /// </summary>
        /// <param name="SuccessCode">SuccessCode.</param>
        /// <param name="SuccessMessage">SuccessMessage.</param>
        /// <param name="SuccessArguments">SuccessArguments.</param>
        /// <param name="PropertyName">PropertyName.</param>
        /// <param name="PropertyValue">PropertyValue.</param>
        /// <param name="ObjectName">ObjectName.</param>
        public BeezUPCommonSuccessSummary(string SuccessCode = default(string), string SuccessMessage = default(string), Dictionary<string, string> SuccessArguments = default(Dictionary<string, string>), string PropertyName = default(string), string PropertyValue = default(string), string ObjectName = default(string))
        {
            this.SuccessCode = SuccessCode;
            this.SuccessMessage = SuccessMessage;
            this.SuccessArguments = SuccessArguments;
            this.PropertyName = PropertyName;
            this.PropertyValue = PropertyValue;
            this.ObjectName = ObjectName;
        }
        
        /// <summary>
        /// Gets or Sets SuccessCode
        /// </summary>
        [DataMember(Name="successCode", EmitDefaultValue=false)]
        public string SuccessCode { get; set; }
        /// <summary>
        /// Gets or Sets SuccessMessage
        /// </summary>
        [DataMember(Name="successMessage", EmitDefaultValue=false)]
        public string SuccessMessage { get; set; }
        /// <summary>
        /// Gets or Sets SuccessArguments
        /// </summary>
        [DataMember(Name="successArguments", EmitDefaultValue=false)]
        public Dictionary<string, string> SuccessArguments { get; set; }
        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name="propertyName", EmitDefaultValue=false)]
        public string PropertyName { get; set; }
        /// <summary>
        /// Gets or Sets PropertyValue
        /// </summary>
        [DataMember(Name="propertyValue", EmitDefaultValue=false)]
        public string PropertyValue { get; set; }
        /// <summary>
        /// Gets or Sets ObjectName
        /// </summary>
        [DataMember(Name="objectName", EmitDefaultValue=false)]
        public string ObjectName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonSuccessSummary {\n");
            sb.Append("  SuccessCode: ").Append(SuccessCode).Append("\n");
            sb.Append("  SuccessMessage: ").Append(SuccessMessage).Append("\n");
            sb.Append("  SuccessArguments: ").Append(SuccessArguments).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
            sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
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
            return this.Equals(obj as BeezUPCommonSuccessSummary);
        }

        /// <summary>
        /// Returns true if BeezUPCommonSuccessSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonSuccessSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonSuccessSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SuccessCode == other.SuccessCode ||
                    this.SuccessCode != null &&
                    this.SuccessCode.Equals(other.SuccessCode)
                ) && 
                (
                    this.SuccessMessage == other.SuccessMessage ||
                    this.SuccessMessage != null &&
                    this.SuccessMessage.Equals(other.SuccessMessage)
                ) && 
                (
                    this.SuccessArguments == other.SuccessArguments ||
                    this.SuccessArguments != null &&
                    this.SuccessArguments.SequenceEqual(other.SuccessArguments)
                ) && 
                (
                    this.PropertyName == other.PropertyName ||
                    this.PropertyName != null &&
                    this.PropertyName.Equals(other.PropertyName)
                ) && 
                (
                    this.PropertyValue == other.PropertyValue ||
                    this.PropertyValue != null &&
                    this.PropertyValue.Equals(other.PropertyValue)
                ) && 
                (
                    this.ObjectName == other.ObjectName ||
                    this.ObjectName != null &&
                    this.ObjectName.Equals(other.ObjectName)
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
                if (this.SuccessCode != null)
                    hash = hash * 59 + this.SuccessCode.GetHashCode();
                if (this.SuccessMessage != null)
                    hash = hash * 59 + this.SuccessMessage.GetHashCode();
                if (this.SuccessArguments != null)
                    hash = hash * 59 + this.SuccessArguments.GetHashCode();
                if (this.PropertyName != null)
                    hash = hash * 59 + this.PropertyName.GetHashCode();
                if (this.PropertyValue != null)
                    hash = hash * 59 + this.PropertyValue.GetHashCode();
                if (this.ObjectName != null)
                    hash = hash * 59 + this.ObjectName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
