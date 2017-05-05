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
    /// Products
    /// </summary>
    [DataContract]
    public partial class Products :  IEquatable<Products>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Products" /> class.
        /// </summary>
        /// <param name="_Products">_Products.</param>
        public Products(List<Product> _Products = default(List<Product>))
        {
            this._Products = _Products;
        }
        
        /// <summary>
        /// Gets or Sets _Products
        /// </summary>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public List<Product> _Products { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Products {\n");
            sb.Append("  _Products: ").Append(_Products).Append("\n");
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
            return this.Equals(obj as Products);
        }

        /// <summary>
        /// Returns true if Products instances are equal
        /// </summary>
        /// <param name="other">Instance of Products to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Products other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Products == other._Products ||
                    this._Products != null &&
                    this._Products.SequenceEqual(other._Products)
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
                if (this._Products != null)
                    hash = hash * 59 + this._Products.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
