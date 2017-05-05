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
    /// ReportByChannelLinks
    /// </summary>
    [DataContract]
    public partial class ReportByChannelLinks :  IEquatable<ReportByChannelLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByChannelLinks" /> class.
        /// </summary>
        /// <param name="EnableProducts">EnableProducts.</param>
        /// <param name="DisableProducts">DisableProducts.</param>
        public ReportByChannelLinks(LinksOptimiseByChannelLink EnableProducts = default(LinksOptimiseByChannelLink), LinksOptimiseByChannelLink DisableProducts = default(LinksOptimiseByChannelLink))
        {
            this.EnableProducts = EnableProducts;
            this.DisableProducts = DisableProducts;
        }
        
        /// <summary>
        /// Gets or Sets EnableProducts
        /// </summary>
        [DataMember(Name="enableProducts", EmitDefaultValue=false)]
        public LinksOptimiseByChannelLink EnableProducts { get; set; }
        /// <summary>
        /// Gets or Sets DisableProducts
        /// </summary>
        [DataMember(Name="disableProducts", EmitDefaultValue=false)]
        public LinksOptimiseByChannelLink DisableProducts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportByChannelLinks {\n");
            sb.Append("  EnableProducts: ").Append(EnableProducts).Append("\n");
            sb.Append("  DisableProducts: ").Append(DisableProducts).Append("\n");
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
            return this.Equals(obj as ReportByChannelLinks);
        }

        /// <summary>
        /// Returns true if ReportByChannelLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportByChannelLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportByChannelLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnableProducts == other.EnableProducts ||
                    this.EnableProducts != null &&
                    this.EnableProducts.Equals(other.EnableProducts)
                ) && 
                (
                    this.DisableProducts == other.DisableProducts ||
                    this.DisableProducts != null &&
                    this.DisableProducts.Equals(other.DisableProducts)
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
                if (this.EnableProducts != null)
                    hash = hash * 59 + this.EnableProducts.GetHashCode();
                if (this.DisableProducts != null)
                    hash = hash * 59 + this.DisableProducts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
