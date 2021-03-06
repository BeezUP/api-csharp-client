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
    /// The object which contains the category list
    /// </summary>
    [DataContract]
    public partial class Categories :  IEquatable<Categories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Categories" /> class.
        /// </summary>
        /// <param name="_Categories">The category list.</param>
        public Categories(List<Category> _Categories = default(List<Category>))
        {
            this._Categories = _Categories;
        }
        
        /// <summary>
        /// The category list
        /// </summary>
        /// <value>The category list</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> _Categories { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Categories {\n");
            sb.Append("  _Categories: ").Append(_Categories).Append("\n");
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
            return this.Equals(obj as Categories);
        }

        /// <summary>
        /// Returns true if Categories instances are equal
        /// </summary>
        /// <param name="other">Instance of Categories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Categories other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Categories == other._Categories ||
                    this._Categories != null &&
                    this._Categories.SequenceEqual(other._Categories)
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
                if (this._Categories != null)
                    hash = hash * 59 + this._Categories.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
