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
    /// The channel column configuration. The BeezUP Column Name is optional. If the BeezUP column is mapped we will indicate the data type and column importance of the BeezUP column.
    /// </summary>
    [DataContract]
    public partial class ChannelColumnConfiguration :  IEquatable<ChannelColumnConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelColumnConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelColumnConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelColumnConfiguration" /> class.
        /// </summary>
        /// <param name="ColumnImportance">ColumnImportance (required).</param>
        /// <param name="ColumnDataType">ColumnDataType (required).</param>
        /// <param name="BeezUPColumnName">BeezUPColumnName.</param>
        public ChannelColumnConfiguration(BeezUPCommonColumnImportance ColumnImportance = default(BeezUPCommonColumnImportance), BeezUPCommonColumnDataType ColumnDataType = default(BeezUPCommonColumnDataType), BeezUPCommonBeezUPColumnName BeezUPColumnName = default(BeezUPCommonBeezUPColumnName))
        {
            // to ensure "ColumnImportance" is required (not null)
            if (ColumnImportance == null)
            {
                throw new InvalidDataException("ColumnImportance is a required property for ChannelColumnConfiguration and cannot be null");
            }
            else
            {
                this.ColumnImportance = ColumnImportance;
            }
            // to ensure "ColumnDataType" is required (not null)
            if (ColumnDataType == null)
            {
                throw new InvalidDataException("ColumnDataType is a required property for ChannelColumnConfiguration and cannot be null");
            }
            else
            {
                this.ColumnDataType = ColumnDataType;
            }
            this.BeezUPColumnName = BeezUPColumnName;
        }
        
        /// <summary>
        /// Gets or Sets ColumnImportance
        /// </summary>
        [DataMember(Name="columnImportance", EmitDefaultValue=false)]
        public BeezUPCommonColumnImportance ColumnImportance { get; set; }
        /// <summary>
        /// Gets or Sets ColumnDataType
        /// </summary>
        [DataMember(Name="columnDataType", EmitDefaultValue=false)]
        public BeezUPCommonColumnDataType ColumnDataType { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPColumnName
        /// </summary>
        [DataMember(Name="beezUPColumnName", EmitDefaultValue=false)]
        public BeezUPCommonBeezUPColumnName BeezUPColumnName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelColumnConfiguration {\n");
            sb.Append("  ColumnImportance: ").Append(ColumnImportance).Append("\n");
            sb.Append("  ColumnDataType: ").Append(ColumnDataType).Append("\n");
            sb.Append("  BeezUPColumnName: ").Append(BeezUPColumnName).Append("\n");
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
            return this.Equals(obj as ChannelColumnConfiguration);
        }

        /// <summary>
        /// Returns true if ChannelColumnConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelColumnConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelColumnConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ColumnImportance == other.ColumnImportance ||
                    this.ColumnImportance != null &&
                    this.ColumnImportance.Equals(other.ColumnImportance)
                ) && 
                (
                    this.ColumnDataType == other.ColumnDataType ||
                    this.ColumnDataType != null &&
                    this.ColumnDataType.Equals(other.ColumnDataType)
                ) && 
                (
                    this.BeezUPColumnName == other.BeezUPColumnName ||
                    this.BeezUPColumnName != null &&
                    this.BeezUPColumnName.Equals(other.BeezUPColumnName)
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
                if (this.ColumnImportance != null)
                    hash = hash * 59 + this.ColumnImportance.GetHashCode();
                if (this.ColumnDataType != null)
                    hash = hash * 59 + this.ColumnDataType.GetHashCode();
                if (this.BeezUPColumnName != null)
                    hash = hash * 59 + this.BeezUPColumnName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
