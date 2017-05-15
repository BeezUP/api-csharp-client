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
    /// Describe a BeezUP column
    /// </summary>
    [DataContract]
    public partial class BeezUPColumnConfiguration :  IEquatable<BeezUPColumnConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPColumnConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPColumnConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPColumnConfiguration" /> class.
        /// </summary>
        /// <param name="BeezUPColumnName">BeezUPColumnName (required).</param>
        /// <param name="Unique">/!\\ ONLY AVAILABLE ON CATALOG COLUMN NOT ON CUSTOM COLUMNS!!  If true, an error happen at the second occurence of the same value for this column  This information will be used during the importation process and later for mapping proposal (default to false).</param>
        /// <param name="ColumnImportance">ColumnImportance (required).</param>
        /// <param name="ColumnDataType">ColumnDataType.</param>
        /// <param name="CanBeTruncated">CanBeTruncated.</param>
        /// <param name="DisplayGroupName">DisplayGroupName (required).</param>
        /// <param name="Description">Describe the BeezUP column.</param>
        public BeezUPColumnConfiguration(BeezUPCommonBeezUPColumnName BeezUPColumnName = default(BeezUPCommonBeezUPColumnName), bool? Unique = false, BeezUPCommonColumnImportance ColumnImportance = default(BeezUPCommonColumnImportance), BeezUPCommonColumnDataType ColumnDataType = default(BeezUPCommonColumnDataType), CanBeTruncated CanBeTruncated = default(CanBeTruncated), DisplayGroupName DisplayGroupName = default(DisplayGroupName), string Description = default(string))
        {
            // to ensure "BeezUPColumnName" is required (not null)
            if (BeezUPColumnName == null)
            {
                throw new InvalidDataException("BeezUPColumnName is a required property for BeezUPColumnConfiguration and cannot be null");
            }
            else
            {
                this.BeezUPColumnName = BeezUPColumnName;
            }
            // to ensure "ColumnImportance" is required (not null)
            if (ColumnImportance == null)
            {
                throw new InvalidDataException("ColumnImportance is a required property for BeezUPColumnConfiguration and cannot be null");
            }
            else
            {
                this.ColumnImportance = ColumnImportance;
            }
            // to ensure "DisplayGroupName" is required (not null)
            if (DisplayGroupName == null)
            {
                throw new InvalidDataException("DisplayGroupName is a required property for BeezUPColumnConfiguration and cannot be null");
            }
            else
            {
                this.DisplayGroupName = DisplayGroupName;
            }
            // use default value if no "Unique" provided
            if (Unique == null)
            {
                this.Unique = false;
            }
            else
            {
                this.Unique = Unique;
            }
            this.ColumnDataType = ColumnDataType;
            this.CanBeTruncated = CanBeTruncated;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets BeezUPColumnName
        /// </summary>
        [DataMember(Name="beezUPColumnName", EmitDefaultValue=false)]
        public BeezUPCommonBeezUPColumnName BeezUPColumnName { get; set; }
        /// <summary>
        /// /!\\ ONLY AVAILABLE ON CATALOG COLUMN NOT ON CUSTOM COLUMNS!!  If true, an error happen at the second occurence of the same value for this column  This information will be used during the importation process and later for mapping proposal
        /// </summary>
        /// <value>/!\\ ONLY AVAILABLE ON CATALOG COLUMN NOT ON CUSTOM COLUMNS!!  If true, an error happen at the second occurence of the same value for this column  This information will be used during the importation process and later for mapping proposal</value>
        [DataMember(Name="unique", EmitDefaultValue=false)]
        public bool? Unique { get; set; }
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
        /// Gets or Sets CanBeTruncated
        /// </summary>
        [DataMember(Name="canBeTruncated", EmitDefaultValue=false)]
        public CanBeTruncated CanBeTruncated { get; set; }
        /// <summary>
        /// Gets or Sets DisplayGroupName
        /// </summary>
        [DataMember(Name="displayGroupName", EmitDefaultValue=false)]
        public DisplayGroupName DisplayGroupName { get; set; }
        /// <summary>
        /// Describe the BeezUP column
        /// </summary>
        /// <value>Describe the BeezUP column</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPColumnConfiguration {\n");
            sb.Append("  BeezUPColumnName: ").Append(BeezUPColumnName).Append("\n");
            sb.Append("  Unique: ").Append(Unique).Append("\n");
            sb.Append("  ColumnImportance: ").Append(ColumnImportance).Append("\n");
            sb.Append("  ColumnDataType: ").Append(ColumnDataType).Append("\n");
            sb.Append("  CanBeTruncated: ").Append(CanBeTruncated).Append("\n");
            sb.Append("  DisplayGroupName: ").Append(DisplayGroupName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as BeezUPColumnConfiguration);
        }

        /// <summary>
        /// Returns true if BeezUPColumnConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPColumnConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPColumnConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BeezUPColumnName == other.BeezUPColumnName ||
                    this.BeezUPColumnName != null &&
                    this.BeezUPColumnName.Equals(other.BeezUPColumnName)
                ) && 
                (
                    this.Unique == other.Unique ||
                    this.Unique != null &&
                    this.Unique.Equals(other.Unique)
                ) && 
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
                    this.CanBeTruncated == other.CanBeTruncated ||
                    this.CanBeTruncated != null &&
                    this.CanBeTruncated.Equals(other.CanBeTruncated)
                ) && 
                (
                    this.DisplayGroupName == other.DisplayGroupName ||
                    this.DisplayGroupName != null &&
                    this.DisplayGroupName.Equals(other.DisplayGroupName)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.BeezUPColumnName != null)
                    hash = hash * 59 + this.BeezUPColumnName.GetHashCode();
                if (this.Unique != null)
                    hash = hash * 59 + this.Unique.GetHashCode();
                if (this.ColumnImportance != null)
                    hash = hash * 59 + this.ColumnImportance.GetHashCode();
                if (this.ColumnDataType != null)
                    hash = hash * 59 + this.ColumnDataType.GetHashCode();
                if (this.CanBeTruncated != null)
                    hash = hash * 59 + this.CanBeTruncated.GetHashCode();
                if (this.DisplayGroupName != null)
                    hash = hash * 59 + this.DisplayGroupName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
