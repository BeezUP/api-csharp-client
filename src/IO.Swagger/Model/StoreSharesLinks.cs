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
    /// StoreSharesLinks
    /// </summary>
    [DataContract]
    public partial class StoreSharesLinks :  IEquatable<StoreSharesLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSharesLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoreSharesLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSharesLinks" /> class.
        /// </summary>
        /// <param name="Share">Share (required).</param>
        public StoreSharesLinks(LinksShareLink Share = default(LinksShareLink))
        {
            // to ensure "Share" is required (not null)
            if (Share == null)
            {
                throw new InvalidDataException("Share is a required property for StoreSharesLinks and cannot be null");
            }
            else
            {
                this.Share = Share;
            }
        }
        
        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public LinksShareLink Share { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreSharesLinks {\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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
            return this.Equals(obj as StoreSharesLinks);
        }

        /// <summary>
        /// Returns true if StoreSharesLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreSharesLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreSharesLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Share == other.Share ||
                    this.Share != null &&
                    this.Share.Equals(other.Share)
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
                if (this.Share != null)
                    hash = hash * 59 + this.Share.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
