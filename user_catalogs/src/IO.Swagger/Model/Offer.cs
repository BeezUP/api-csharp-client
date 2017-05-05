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
    /// Offer
    /// </summary>
    [DataContract]
    public partial class Offer :  IEquatable<Offer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Offer" /> class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="Info">Info.</param>
        /// <param name="Links">Links.</param>
        public Offer(OfferContent Content = default(OfferContent), BeezUPCommonInfoSummaries Info = default(BeezUPCommonInfoSummaries), OfferLinks Links = default(OfferLinks))
        {
            this.Content = Content;
            this.Info = Info;
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public OfferContent Content { get; set; }
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public BeezUPCommonInfoSummaries Info { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public OfferLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Offer {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as Offer);
        }

        /// <summary>
        /// Returns true if Offer instances are equal
        /// </summary>
        /// <param name="other">Instance of Offer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Offer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
