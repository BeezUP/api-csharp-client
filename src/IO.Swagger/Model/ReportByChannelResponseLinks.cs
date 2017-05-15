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
    /// ReportByChannelResponseLinks
    /// </summary>
    [DataContract]
    public partial class ReportByChannelResponseLinks :  IEquatable<ReportByChannelResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByChannelResponseLinks" /> class.
        /// </summary>
        /// <param name="EnableAllProducts">EnableAllProducts.</param>
        /// <param name="DisableAllProducts">DisableAllProducts.</param>
        public ReportByChannelResponseLinks(LinksOptimiseLink EnableAllProducts = default(LinksOptimiseLink), LinksOptimiseLink DisableAllProducts = default(LinksOptimiseLink))
        {
            this.EnableAllProducts = EnableAllProducts;
            this.DisableAllProducts = DisableAllProducts;
        }
        
        /// <summary>
        /// Gets or Sets EnableAllProducts
        /// </summary>
        [DataMember(Name="enableAllProducts", EmitDefaultValue=false)]
        public LinksOptimiseLink EnableAllProducts { get; set; }
        /// <summary>
        /// Gets or Sets DisableAllProducts
        /// </summary>
        [DataMember(Name="disableAllProducts", EmitDefaultValue=false)]
        public LinksOptimiseLink DisableAllProducts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportByChannelResponseLinks {\n");
            sb.Append("  EnableAllProducts: ").Append(EnableAllProducts).Append("\n");
            sb.Append("  DisableAllProducts: ").Append(DisableAllProducts).Append("\n");
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
            return this.Equals(obj as ReportByChannelResponseLinks);
        }

        /// <summary>
        /// Returns true if ReportByChannelResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportByChannelResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportByChannelResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnableAllProducts == other.EnableAllProducts ||
                    this.EnableAllProducts != null &&
                    this.EnableAllProducts.Equals(other.EnableAllProducts)
                ) && 
                (
                    this.DisableAllProducts == other.DisableAllProducts ||
                    this.DisableAllProducts != null &&
                    this.DisableAllProducts.Equals(other.DisableAllProducts)
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
                if (this.EnableAllProducts != null)
                    hash = hash * 59 + this.EnableAllProducts.GetHashCode();
                if (this.DisableAllProducts != null)
                    hash = hash * 59 + this.DisableAllProducts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
