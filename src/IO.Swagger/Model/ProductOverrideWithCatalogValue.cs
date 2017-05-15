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
    /// ProductOverrideWithCatalogValue
    /// </summary>
    [DataContract]
    public partial class ProductOverrideWithCatalogValue :  IEquatable<ProductOverrideWithCatalogValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOverrideWithCatalogValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductOverrideWithCatalogValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOverrideWithCatalogValue" /> class.
        /// </summary>
        /// <param name="_Override">The overrided product value (required).</param>
        /// <param name="CatalogValue">The catalog product value.</param>
        public ProductOverrideWithCatalogValue(string _Override = default(string), string CatalogValue = default(string))
        {
            // to ensure "_Override" is required (not null)
            if (_Override == null)
            {
                throw new InvalidDataException("_Override is a required property for ProductOverrideWithCatalogValue and cannot be null");
            }
            else
            {
                this._Override = _Override;
            }
            this.CatalogValue = CatalogValue;
        }
        
        /// <summary>
        /// The overrided product value
        /// </summary>
        /// <value>The overrided product value</value>
        [DataMember(Name="override", EmitDefaultValue=false)]
        public string _Override { get; set; }
        /// <summary>
        /// The catalog product value
        /// </summary>
        /// <value>The catalog product value</value>
        [DataMember(Name="catalogValue", EmitDefaultValue=false)]
        public string CatalogValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductOverrideWithCatalogValue {\n");
            sb.Append("  _Override: ").Append(_Override).Append("\n");
            sb.Append("  CatalogValue: ").Append(CatalogValue).Append("\n");
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
            return this.Equals(obj as ProductOverrideWithCatalogValue);
        }

        /// <summary>
        /// Returns true if ProductOverrideWithCatalogValue instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductOverrideWithCatalogValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOverrideWithCatalogValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Override == other._Override ||
                    this._Override != null &&
                    this._Override.Equals(other._Override)
                ) && 
                (
                    this.CatalogValue == other.CatalogValue ||
                    this.CatalogValue != null &&
                    this.CatalogValue.Equals(other.CatalogValue)
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
                if (this._Override != null)
                    hash = hash * 59 + this._Override.GetHashCode();
                if (this.CatalogValue != null)
                    hash = hash * 59 + this.CatalogValue.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
