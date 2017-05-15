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
    /// The action links
    /// </summary>
    [DataContract]
    public partial class InlineResponse409Links :  IEquatable<InlineResponse409Links>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse409Links" /> class.
        /// </summary>
        /// <param name="CurrentImportation">CurrentImportation.</param>
        public InlineResponse409Links(LinksImportationGetImportationMonitoringLink CurrentImportation = default(LinksImportationGetImportationMonitoringLink))
        {
            this.CurrentImportation = CurrentImportation;
        }
        
        /// <summary>
        /// Gets or Sets CurrentImportation
        /// </summary>
        [DataMember(Name="currentImportation", EmitDefaultValue=false)]
        public LinksImportationGetImportationMonitoringLink CurrentImportation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse409Links {\n");
            sb.Append("  CurrentImportation: ").Append(CurrentImportation).Append("\n");
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
            return this.Equals(obj as InlineResponse409Links);
        }

        /// <summary>
        /// Returns true if InlineResponse409Links instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse409Links to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse409Links other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentImportation == other.CurrentImportation ||
                    this.CurrentImportation != null &&
                    this.CurrentImportation.Equals(other.CurrentImportation)
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
                if (this.CurrentImportation != null)
                    hash = hash * 59 + this.CurrentImportation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
