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
    /// AutomaticTransitionInfos
    /// </summary>
    [DataContract]
    public partial class AutomaticTransitionInfos :  IEquatable<AutomaticTransitionInfos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticTransitionInfos" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutomaticTransitionInfos() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticTransitionInfos" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="_AutomaticTransitionInfos">_AutomaticTransitionInfos.</param>
        public AutomaticTransitionInfos(AutomaticTransitionInfosLinks Links = default(AutomaticTransitionInfosLinks), List<AutomaticTransitionInfo> _AutomaticTransitionInfos = default(List<AutomaticTransitionInfo>))
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for AutomaticTransitionInfos and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this._AutomaticTransitionInfos = _AutomaticTransitionInfos;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public AutomaticTransitionInfosLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets _AutomaticTransitionInfos
        /// </summary>
        [DataMember(Name="automaticTransitionInfos", EmitDefaultValue=false)]
        public List<AutomaticTransitionInfo> _AutomaticTransitionInfos { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticTransitionInfos {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _AutomaticTransitionInfos: ").Append(_AutomaticTransitionInfos).Append("\n");
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
            return this.Equals(obj as AutomaticTransitionInfos);
        }

        /// <summary>
        /// Returns true if AutomaticTransitionInfos instances are equal
        /// </summary>
        /// <param name="other">Instance of AutomaticTransitionInfos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticTransitionInfos other)
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
                    this._AutomaticTransitionInfos == other._AutomaticTransitionInfos ||
                    this._AutomaticTransitionInfos != null &&
                    this._AutomaticTransitionInfos.SequenceEqual(other._AutomaticTransitionInfos)
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
                if (this._AutomaticTransitionInfos != null)
                    hash = hash * 59 + this._AutomaticTransitionInfos.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
