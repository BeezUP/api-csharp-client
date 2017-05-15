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
    /// The publication history for an account
    /// </summary>
    [DataContract]
    public partial class AccountPublications :  IEquatable<AccountPublications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPublications" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountPublications() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPublications" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="Publications">The recent publications for the requested account (required).</param>
        public AccountPublications(AccountPublicationsLinks Links = default(AccountPublicationsLinks), List<PublicationReporting> Publications = default(List<PublicationReporting>))
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for AccountPublications and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            // to ensure "Publications" is required (not null)
            if (Publications == null)
            {
                throw new InvalidDataException("Publications is a required property for AccountPublications and cannot be null");
            }
            else
            {
                this.Publications = Publications;
            }
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public AccountPublicationsLinks Links { get; set; }
        /// <summary>
        /// The recent publications for the requested account
        /// </summary>
        /// <value>The recent publications for the requested account</value>
        [DataMember(Name="publications", EmitDefaultValue=false)]
        public List<PublicationReporting> Publications { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPublications {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Publications: ").Append(Publications).Append("\n");
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
            return this.Equals(obj as AccountPublications);
        }

        /// <summary>
        /// Returns true if AccountPublications instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPublications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPublications other)
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
                    this.Publications == other.Publications ||
                    this.Publications != null &&
                    this.Publications.SequenceEqual(other.Publications)
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
                if (this.Publications != null)
                    hash = hash * 59 + this.Publications.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
