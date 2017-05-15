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
    /// The CSV file description
    /// </summary>
    [DataContract]
    public partial class InputFileReadCsvConfiguration :  IEquatable<InputFileReadCsvConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileReadCsvConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputFileReadCsvConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputFileReadCsvConfiguration" /> class.
        /// </summary>
        /// <param name="HasHeaderRecord">Indicate if the csv file contains the column name at the first row (required) (default to true).</param>
        /// <param name="IgnoreHeaderRecord">Indicate if the importation should not use the csv column name from the file (required) (default to false).</param>
        /// <param name="CsvSeparator">Indicate the separator of the values in the CSV file. Generally \&quot;;\&quot; (required) (default to &quot;;&quot;).</param>
        /// <param name="CsvTextQualifier">Indicate the text qualifier of the CSV file. Generally the value is \&quot; (required) (default to &quot;&quot;&quot;).</param>
        public InputFileReadCsvConfiguration(bool? HasHeaderRecord = true, bool? IgnoreHeaderRecord = false, string CsvSeparator = ";", string CsvTextQualifier = """)
        {
            // to ensure "HasHeaderRecord" is required (not null)
            if (HasHeaderRecord == null)
            {
                throw new InvalidDataException("HasHeaderRecord is a required property for InputFileReadCsvConfiguration and cannot be null");
            }
            else
            {
                this.HasHeaderRecord = HasHeaderRecord;
            }
            // to ensure "IgnoreHeaderRecord" is required (not null)
            if (IgnoreHeaderRecord == null)
            {
                throw new InvalidDataException("IgnoreHeaderRecord is a required property for InputFileReadCsvConfiguration and cannot be null");
            }
            else
            {
                this.IgnoreHeaderRecord = IgnoreHeaderRecord;
            }
            // to ensure "CsvSeparator" is required (not null)
            if (CsvSeparator == null)
            {
                throw new InvalidDataException("CsvSeparator is a required property for InputFileReadCsvConfiguration and cannot be null");
            }
            else
            {
                this.CsvSeparator = CsvSeparator;
            }
            // to ensure "CsvTextQualifier" is required (not null)
            if (CsvTextQualifier == null)
            {
                throw new InvalidDataException("CsvTextQualifier is a required property for InputFileReadCsvConfiguration and cannot be null");
            }
            else
            {
                this.CsvTextQualifier = CsvTextQualifier;
            }
        }
        
        /// <summary>
        /// Indicate if the csv file contains the column name at the first row
        /// </summary>
        /// <value>Indicate if the csv file contains the column name at the first row</value>
        [DataMember(Name="hasHeaderRecord", EmitDefaultValue=false)]
        public bool? HasHeaderRecord { get; set; }
        /// <summary>
        /// Indicate if the importation should not use the csv column name from the file
        /// </summary>
        /// <value>Indicate if the importation should not use the csv column name from the file</value>
        [DataMember(Name="ignoreHeaderRecord", EmitDefaultValue=false)]
        public bool? IgnoreHeaderRecord { get; set; }
        /// <summary>
        /// Indicate the separator of the values in the CSV file. Generally \&quot;;\&quot;
        /// </summary>
        /// <value>Indicate the separator of the values in the CSV file. Generally \&quot;;\&quot;</value>
        [DataMember(Name="csvSeparator", EmitDefaultValue=false)]
        public string CsvSeparator { get; set; }
        /// <summary>
        /// Indicate the text qualifier of the CSV file. Generally the value is \&quot;
        /// </summary>
        /// <value>Indicate the text qualifier of the CSV file. Generally the value is \&quot;</value>
        [DataMember(Name="csvTextQualifier", EmitDefaultValue=false)]
        public string CsvTextQualifier { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputFileReadCsvConfiguration {\n");
            sb.Append("  HasHeaderRecord: ").Append(HasHeaderRecord).Append("\n");
            sb.Append("  IgnoreHeaderRecord: ").Append(IgnoreHeaderRecord).Append("\n");
            sb.Append("  CsvSeparator: ").Append(CsvSeparator).Append("\n");
            sb.Append("  CsvTextQualifier: ").Append(CsvTextQualifier).Append("\n");
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
            return this.Equals(obj as InputFileReadCsvConfiguration);
        }

        /// <summary>
        /// Returns true if InputFileReadCsvConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of InputFileReadCsvConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputFileReadCsvConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HasHeaderRecord == other.HasHeaderRecord ||
                    this.HasHeaderRecord != null &&
                    this.HasHeaderRecord.Equals(other.HasHeaderRecord)
                ) && 
                (
                    this.IgnoreHeaderRecord == other.IgnoreHeaderRecord ||
                    this.IgnoreHeaderRecord != null &&
                    this.IgnoreHeaderRecord.Equals(other.IgnoreHeaderRecord)
                ) && 
                (
                    this.CsvSeparator == other.CsvSeparator ||
                    this.CsvSeparator != null &&
                    this.CsvSeparator.Equals(other.CsvSeparator)
                ) && 
                (
                    this.CsvTextQualifier == other.CsvTextQualifier ||
                    this.CsvTextQualifier != null &&
                    this.CsvTextQualifier.Equals(other.CsvTextQualifier)
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
                if (this.HasHeaderRecord != null)
                    hash = hash * 59 + this.HasHeaderRecord.GetHashCode();
                if (this.IgnoreHeaderRecord != null)
                    hash = hash * 59 + this.IgnoreHeaderRecord.GetHashCode();
                if (this.CsvSeparator != null)
                    hash = hash * 59 + this.CsvSeparator.GetHashCode();
                if (this.CsvTextQualifier != null)
                    hash = hash * 59 + this.CsvTextQualifier.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
