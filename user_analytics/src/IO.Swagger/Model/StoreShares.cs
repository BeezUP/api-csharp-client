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
    /// StoreShares
    /// </summary>
    [DataContract]
    public partial class StoreShares :  IEquatable<StoreShares>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreShares" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoreShares() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreShares" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Shares">Shares (required).</param>
        public StoreShares(StoreSharesLinks Links = default(StoreSharesLinks), List<StoreShare> Shares = default(List<StoreShare>))
        {
            // to ensure "Shares" is required (not null)
            if (Shares == null)
            {
                throw new InvalidDataException("Shares is a required property for StoreShares and cannot be null");
            }
            else
            {
                this.Shares = Shares;
            }
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public StoreSharesLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Shares
        /// </summary>
        [DataMember(Name="shares", EmitDefaultValue=false)]
        public List<StoreShare> Shares { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreShares {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
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
            return this.Equals(obj as StoreShares);
        }

        /// <summary>
        /// Returns true if StoreShares instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreShares to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreShares other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Shares == other.Shares ||
                    this.Shares != null &&
                    this.Shares.SequenceEqual(other.Shares)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Shares != null)
                    hash = hash * 59 + this.Shares.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}