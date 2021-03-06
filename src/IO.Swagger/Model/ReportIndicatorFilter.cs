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
    /// ReportIndicatorFilter
    /// </summary>
    [DataContract]
    public partial class ReportIndicatorFilter :  IEquatable<ReportIndicatorFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportIndicatorFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportIndicatorFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportIndicatorFilter" /> class.
        /// </summary>
        /// <param name="Indicator">Indicator (required).</param>
        /// <param name="OperatorName">OperatorName (required).</param>
        /// <param name="Value">Indicates the filter value to apply on this indicator (required).</param>
        public ReportIndicatorFilter(PerformanceIndicatorType Indicator = default(PerformanceIndicatorType), ReportIndicatorFilterOperatorName OperatorName = default(ReportIndicatorFilterOperatorName), decimal? Value = default(decimal?))
        {
            // to ensure "Indicator" is required (not null)
            if (Indicator == null)
            {
                throw new InvalidDataException("Indicator is a required property for ReportIndicatorFilter and cannot be null");
            }
            else
            {
                this.Indicator = Indicator;
            }
            // to ensure "OperatorName" is required (not null)
            if (OperatorName == null)
            {
                throw new InvalidDataException("OperatorName is a required property for ReportIndicatorFilter and cannot be null");
            }
            else
            {
                this.OperatorName = OperatorName;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for ReportIndicatorFilter and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
        }
        
        /// <summary>
        /// Gets or Sets Indicator
        /// </summary>
        [DataMember(Name="indicator", EmitDefaultValue=false)]
        public PerformanceIndicatorType Indicator { get; set; }
        /// <summary>
        /// Gets or Sets OperatorName
        /// </summary>
        [DataMember(Name="operatorName", EmitDefaultValue=false)]
        public ReportIndicatorFilterOperatorName OperatorName { get; set; }
        /// <summary>
        /// Indicates the filter value to apply on this indicator
        /// </summary>
        /// <value>Indicates the filter value to apply on this indicator</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportIndicatorFilter {\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  OperatorName: ").Append(OperatorName).Append("\n");
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
            return this.Equals(obj as ReportIndicatorFilter);
        }

        /// <summary>
        /// Returns true if ReportIndicatorFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportIndicatorFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportIndicatorFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Indicator == other.Indicator ||
                    this.Indicator != null &&
                    this.Indicator.Equals(other.Indicator)
                ) && 
                (
                    this.OperatorName == other.OperatorName ||
                    this.OperatorName != null &&
                    this.OperatorName.Equals(other.OperatorName)
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
                if (this.Indicator != null)
                    hash = hash * 59 + this.Indicator.GetHashCode();
                if (this.OperatorName != null)
                    hash = hash * 59 + this.OperatorName.GetHashCode();
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
