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
    /// The list of Order report exportations
    /// </summary>
    [DataContract]
    public partial class OrderExportations :  IEquatable<OrderExportations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExportations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderExportations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExportations" /> class.
        /// </summary>
        /// <param name="PaginationResult">PaginationResult (required).</param>
        /// <param name="Exportations">Exportations (required).</param>
        public OrderExportations(BeezUPCommonPaginationResult PaginationResult = default(BeezUPCommonPaginationResult), List<OrderExportationReporting> Exportations = default(List<OrderExportationReporting>))
        {
            // to ensure "PaginationResult" is required (not null)
            if (PaginationResult == null)
            {
                throw new InvalidDataException("PaginationResult is a required property for OrderExportations and cannot be null");
            }
            else
            {
                this.PaginationResult = PaginationResult;
            }
            // to ensure "Exportations" is required (not null)
            if (Exportations == null)
            {
                throw new InvalidDataException("Exportations is a required property for OrderExportations and cannot be null");
            }
            else
            {
                this.Exportations = Exportations;
            }
        }
        
        /// <summary>
        /// Gets or Sets PaginationResult
        /// </summary>
        [DataMember(Name="paginationResult", EmitDefaultValue=false)]
        public BeezUPCommonPaginationResult PaginationResult { get; set; }
        /// <summary>
        /// Gets or Sets Exportations
        /// </summary>
        [DataMember(Name="exportations", EmitDefaultValue=false)]
        public List<OrderExportationReporting> Exportations { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderExportations {\n");
            sb.Append("  PaginationResult: ").Append(PaginationResult).Append("\n");
            sb.Append("  Exportations: ").Append(Exportations).Append("\n");
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
            return this.Equals(obj as OrderExportations);
        }

        /// <summary>
        /// Returns true if OrderExportations instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderExportations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderExportations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaginationResult == other.PaginationResult ||
                    this.PaginationResult != null &&
                    this.PaginationResult.Equals(other.PaginationResult)
                ) && 
                (
                    this.Exportations == other.Exportations ||
                    this.Exportations != null &&
                    this.Exportations.SequenceEqual(other.Exportations)
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
                if (this.PaginationResult != null)
                    hash = hash * 59 + this.PaginationResult.GetHashCode();
                if (this.Exportations != null)
                    hash = hash * 59 + this.Exportations.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
