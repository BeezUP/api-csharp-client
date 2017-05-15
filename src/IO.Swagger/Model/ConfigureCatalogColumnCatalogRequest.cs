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
    /// The request to configure a catalog column
    /// </summary>
    [DataContract]
    public partial class ConfigureCatalogColumnCatalogRequest :  IEquatable<ConfigureCatalogColumnCatalogRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureCatalogColumnCatalogRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigureCatalogColumnCatalogRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureCatalogColumnCatalogRequest" /> class.
        /// </summary>
        /// <param name="CatalogColumn">CatalogColumn (required).</param>
        public ConfigureCatalogColumnCatalogRequest(CatalogColumn CatalogColumn = default(CatalogColumn))
        {
            // to ensure "CatalogColumn" is required (not null)
            if (CatalogColumn == null)
            {
                throw new InvalidDataException("CatalogColumn is a required property for ConfigureCatalogColumnCatalogRequest and cannot be null");
            }
            else
            {
                this.CatalogColumn = CatalogColumn;
            }
        }
        
        /// <summary>
        /// Gets or Sets CatalogColumn
        /// </summary>
        [DataMember(Name="catalogColumn", EmitDefaultValue=false)]
        public CatalogColumn CatalogColumn { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigureCatalogColumnCatalogRequest {\n");
            sb.Append("  CatalogColumn: ").Append(CatalogColumn).Append("\n");
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
            return this.Equals(obj as ConfigureCatalogColumnCatalogRequest);
        }

        /// <summary>
        /// Returns true if ConfigureCatalogColumnCatalogRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigureCatalogColumnCatalogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigureCatalogColumnCatalogRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogColumn == other.CatalogColumn ||
                    this.CatalogColumn != null &&
                    this.CatalogColumn.Equals(other.CatalogColumn)
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
                if (this.CatalogColumn != null)
                    hash = hash * 59 + this.CatalogColumn.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
