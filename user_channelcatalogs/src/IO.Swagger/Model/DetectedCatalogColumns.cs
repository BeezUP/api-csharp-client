/* 
 * Catalogs
 *
 * This API allows you to manage your catalogs
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
    /// The list of detected catalog column
    /// </summary>
    [DataContract]
    public partial class DetectedCatalogColumns :  IEquatable<DetectedCatalogColumns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedCatalogColumns" /> class.
        /// </summary>
        /// <param name="_DetectedCatalogColumns">Contains all deteted catalog columns.</param>
        public DetectedCatalogColumns(List<DetectedCatalogColumn> _DetectedCatalogColumns = default(List<DetectedCatalogColumn>))
        {
            this._DetectedCatalogColumns = _DetectedCatalogColumns;
        }
        
        /// <summary>
        /// Contains all deteted catalog columns
        /// </summary>
        /// <value>Contains all deteted catalog columns</value>
        [DataMember(Name="detectedCatalogColumns", EmitDefaultValue=false)]
        public List<DetectedCatalogColumn> _DetectedCatalogColumns { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedCatalogColumns {\n");
            sb.Append("  _DetectedCatalogColumns: ").Append(_DetectedCatalogColumns).Append("\n");
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
            return this.Equals(obj as DetectedCatalogColumns);
        }

        /// <summary>
        /// Returns true if DetectedCatalogColumns instances are equal
        /// </summary>
        /// <param name="other">Instance of DetectedCatalogColumns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedCatalogColumns other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._DetectedCatalogColumns == other._DetectedCatalogColumns ||
                    this._DetectedCatalogColumns != null &&
                    this._DetectedCatalogColumns.SequenceEqual(other._DetectedCatalogColumns)
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
                if (this._DetectedCatalogColumns != null)
                    hash = hash * 59 + this._DetectedCatalogColumns.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}