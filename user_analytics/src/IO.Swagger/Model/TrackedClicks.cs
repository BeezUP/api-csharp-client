/* 
 * Analytics
 *
 * This API will help you to manage the tracking of your clicks and your sales, get reporting on this trackings and put in place rules based on this reporting to automatically optimize your channel catalogs. \\ Also, you will be able to consult the rule execution reporting. 
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
    /// TrackedClicks
    /// </summary>
    [DataContract]
    public partial class TrackedClicks :  IEquatable<TrackedClicks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedClicks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackedClicks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedClicks" /> class.
        /// </summary>
        /// <param name="Clicks">Clicks (required).</param>
        public TrackedClicks(List<TrackedClick> Clicks = default(List<TrackedClick>))
        {
            // to ensure "Clicks" is required (not null)
            if (Clicks == null)
            {
                throw new InvalidDataException("Clicks is a required property for TrackedClicks and cannot be null");
            }
            else
            {
                this.Clicks = Clicks;
            }
        }
        
        /// <summary>
        /// Gets or Sets Clicks
        /// </summary>
        [DataMember(Name="clicks", EmitDefaultValue=false)]
        public List<TrackedClick> Clicks { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackedClicks {\n");
            sb.Append("  Clicks: ").Append(Clicks).Append("\n");
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
            return this.Equals(obj as TrackedClicks);
        }

        /// <summary>
        /// Returns true if TrackedClicks instances are equal
        /// </summary>
        /// <param name="other">Instance of TrackedClicks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedClicks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Clicks == other.Clicks ||
                    this.Clicks != null &&
                    this.Clicks.SequenceEqual(other.Clicks)
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
                if (this.Clicks != null)
                    hash = hash * 59 + this.Clicks.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
