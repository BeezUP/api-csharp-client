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
    /// BeezUPCommonErrorSummary
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonErrorSummary :  IEquatable<BeezUPCommonErrorSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonErrorSummary" /> class.
        /// </summary>
        /// <param name="UtcDate">UtcDate.</param>
        /// <param name="ErrorGuid">ErrorGuid.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="TechnicalErrorMessage">TechnicalErrorMessage.</param>
        /// <param name="ExceptionDetail">ExceptionDetail.</param>
        /// <param name="ErrorArguments">ErrorArguments.</param>
        /// <param name="PropertyName">PropertyName.</param>
        /// <param name="PropertyValue">PropertyValue.</param>
        /// <param name="ObjectName">ObjectName.</param>
        /// <param name="Source">Source.</param>
        public BeezUPCommonErrorSummary(DateTime? UtcDate = default(DateTime?), Guid? ErrorGuid = default(Guid?), string ErrorCode = default(string), string ErrorMessage = default(string), string TechnicalErrorMessage = default(string), BeezUPCommonExceptionDetail ExceptionDetail = default(BeezUPCommonExceptionDetail), Dictionary<string, string> ErrorArguments = default(Dictionary<string, string>), string PropertyName = default(string), string PropertyValue = default(string), string ObjectName = default(string), string Source = default(string))
        {
            this.UtcDate = UtcDate;
            this.ErrorGuid = ErrorGuid;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.TechnicalErrorMessage = TechnicalErrorMessage;
            this.ExceptionDetail = ExceptionDetail;
            this.ErrorArguments = ErrorArguments;
            this.PropertyName = PropertyName;
            this.PropertyValue = PropertyValue;
            this.ObjectName = ObjectName;
            this.Source = Source;
        }
        
        /// <summary>
        /// Gets or Sets UtcDate
        /// </summary>
        [DataMember(Name="utcDate", EmitDefaultValue=false)]
        public DateTime? UtcDate { get; set; }
        /// <summary>
        /// Gets or Sets ErrorGuid
        /// </summary>
        [DataMember(Name="errorGuid", EmitDefaultValue=false)]
        public Guid? ErrorGuid { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Gets or Sets TechnicalErrorMessage
        /// </summary>
        [DataMember(Name="technicalErrorMessage", EmitDefaultValue=false)]
        public string TechnicalErrorMessage { get; set; }
        /// <summary>
        /// Gets or Sets ExceptionDetail
        /// </summary>
        [DataMember(Name="exceptionDetail", EmitDefaultValue=false)]
        public BeezUPCommonExceptionDetail ExceptionDetail { get; set; }
        /// <summary>
        /// Gets or Sets ErrorArguments
        /// </summary>
        [DataMember(Name="errorArguments", EmitDefaultValue=false)]
        public Dictionary<string, string> ErrorArguments { get; set; }
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
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonErrorSummary {\n");
            sb.Append("  UtcDate: ").Append(UtcDate).Append("\n");
            sb.Append("  ErrorGuid: ").Append(ErrorGuid).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  TechnicalErrorMessage: ").Append(TechnicalErrorMessage).Append("\n");
            sb.Append("  ExceptionDetail: ").Append(ExceptionDetail).Append("\n");
            sb.Append("  ErrorArguments: ").Append(ErrorArguments).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
            sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as BeezUPCommonErrorSummary);
        }

        /// <summary>
        /// Returns true if BeezUPCommonErrorSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonErrorSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonErrorSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UtcDate == other.UtcDate ||
                    this.UtcDate != null &&
                    this.UtcDate.Equals(other.UtcDate)
                ) && 
                (
                    this.ErrorGuid == other.ErrorGuid ||
                    this.ErrorGuid != null &&
                    this.ErrorGuid.Equals(other.ErrorGuid)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.TechnicalErrorMessage == other.TechnicalErrorMessage ||
                    this.TechnicalErrorMessage != null &&
                    this.TechnicalErrorMessage.Equals(other.TechnicalErrorMessage)
                ) && 
                (
                    this.ExceptionDetail == other.ExceptionDetail ||
                    this.ExceptionDetail != null &&
                    this.ExceptionDetail.Equals(other.ExceptionDetail)
                ) && 
                (
                    this.ErrorArguments == other.ErrorArguments ||
                    this.ErrorArguments != null &&
                    this.ErrorArguments.SequenceEqual(other.ErrorArguments)
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
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                if (this.UtcDate != null)
                    hash = hash * 59 + this.UtcDate.GetHashCode();
                if (this.ErrorGuid != null)
                    hash = hash * 59 + this.ErrorGuid.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.TechnicalErrorMessage != null)
                    hash = hash * 59 + this.TechnicalErrorMessage.GetHashCode();
                if (this.ExceptionDetail != null)
                    hash = hash * 59 + this.ExceptionDetail.GetHashCode();
                if (this.ErrorArguments != null)
                    hash = hash * 59 + this.ErrorArguments.GetHashCode();
                if (this.PropertyName != null)
                    hash = hash * 59 + this.PropertyName.GetHashCode();
                if (this.PropertyValue != null)
                    hash = hash * 59 + this.PropertyValue.GetHashCode();
                if (this.ObjectName != null)
                    hash = hash * 59 + this.ObjectName.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
