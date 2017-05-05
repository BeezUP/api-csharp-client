/* 
 * Marketplaces - Orders
 *
 * The features exposed in this API are centered around managing Orders harvested from your configured marketplaces.\\ This includes: - fetching current information (as known by BeezUP) for a single or multiple Orders, - requesting Order harvest to synchronize your marketplaces and BeezUP accounts, - changing BeezUP data and requesting changes to your marketplaces (accepting, shipping, etc), - configuring automatic changes to marketplace based our newly fetched data, - creating and exporting reports for your Orders. 
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
    /// BeezUPCommonInfoSummaries
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonInfoSummaries :  IEquatable<BeezUPCommonInfoSummaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonInfoSummaries" /> class.
        /// </summary>
        /// <param name="Successes">Successes.</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="Warnings">Warnings.</param>
        /// <param name="Informations">Informations.</param>
        public BeezUPCommonInfoSummaries(List<BeezUPCommonSuccessSummary> Successes = default(List<BeezUPCommonSuccessSummary>), List<BeezUPCommonErrorSummary> Errors = default(List<BeezUPCommonErrorSummary>), List<BeezUPCommonWarningSummary> Warnings = default(List<BeezUPCommonWarningSummary>), List<BeezUPCommonInfoSummary> Informations = default(List<BeezUPCommonInfoSummary>))
        {
            this.Successes = Successes;
            this.Errors = Errors;
            this.Warnings = Warnings;
            this.Informations = Informations;
        }
        
        /// <summary>
        /// Gets or Sets Successes
        /// </summary>
        [DataMember(Name="successes", EmitDefaultValue=false)]
        public List<BeezUPCommonSuccessSummary> Successes { get; set; }
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<BeezUPCommonErrorSummary> Errors { get; set; }
        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<BeezUPCommonWarningSummary> Warnings { get; set; }
        /// <summary>
        /// Gets or Sets Informations
        /// </summary>
        [DataMember(Name="informations", EmitDefaultValue=false)]
        public List<BeezUPCommonInfoSummary> Informations { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonInfoSummaries {\n");
            sb.Append("  Successes: ").Append(Successes).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Informations: ").Append(Informations).Append("\n");
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
            return this.Equals(obj as BeezUPCommonInfoSummaries);
        }

        /// <summary>
        /// Returns true if BeezUPCommonInfoSummaries instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonInfoSummaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonInfoSummaries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Successes == other.Successes ||
                    this.Successes != null &&
                    this.Successes.SequenceEqual(other.Successes)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Warnings == other.Warnings ||
                    this.Warnings != null &&
                    this.Warnings.SequenceEqual(other.Warnings)
                ) && 
                (
                    this.Informations == other.Informations ||
                    this.Informations != null &&
                    this.Informations.SequenceEqual(other.Informations)
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
                if (this.Successes != null)
                    hash = hash * 59 + this.Successes.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Warnings != null)
                    hash = hash * 59 + this.Warnings.GetHashCode();
                if (this.Informations != null)
                    hash = hash * 59 + this.Informations.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
