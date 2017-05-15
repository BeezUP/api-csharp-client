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
    /// StandardOffers
    /// </summary>
    [DataContract]
    public partial class StandardOffers :  IEquatable<StandardOffers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardOffers" /> class.
        /// </summary>
        /// <param name="Offers">All standard offers.</param>
        /// <param name="Functionalities">All functionalities....</param>
        public StandardOffers(List<StandardOffer> Offers = default(List<StandardOffer>), List<Functionality> Functionalities = default(List<Functionality>))
        {
            this.Offers = Offers;
            this.Functionalities = Functionalities;
        }
        
        /// <summary>
        /// All standard offers
        /// </summary>
        /// <value>All standard offers</value>
        [DataMember(Name="offers", EmitDefaultValue=false)]
        public List<StandardOffer> Offers { get; set; }
        /// <summary>
        /// All functionalities...
        /// </summary>
        /// <value>All functionalities...</value>
        [DataMember(Name="functionalities", EmitDefaultValue=false)]
        public List<Functionality> Functionalities { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardOffers {\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
            sb.Append("  Functionalities: ").Append(Functionalities).Append("\n");
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
            return this.Equals(obj as StandardOffers);
        }

        /// <summary>
        /// Returns true if StandardOffers instances are equal
        /// </summary>
        /// <param name="other">Instance of StandardOffers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardOffers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Offers == other.Offers ||
                    this.Offers != null &&
                    this.Offers.SequenceEqual(other.Offers)
                ) && 
                (
                    this.Functionalities == other.Functionalities ||
                    this.Functionalities != null &&
                    this.Functionalities.SequenceEqual(other.Functionalities)
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
                if (this.Offers != null)
                    hash = hash * 59 + this.Offers.GetHashCode();
                if (this.Functionalities != null)
                    hash = hash * 59 + this.Functionalities.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
