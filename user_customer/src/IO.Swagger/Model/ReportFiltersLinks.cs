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
    /// ReportFiltersLinks
    /// </summary>
    [DataContract]
    public partial class ReportFiltersLinks :  IEquatable<ReportFiltersLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportFiltersLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Save">Save.</param>
        public ReportFiltersLinks(LinksGetReportFiltersLink Self = default(LinksGetReportFiltersLink), LinksSaveReportFilterLink Save = default(LinksSaveReportFilterLink))
        {
            this.Self = Self;
            this.Save = Save;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public LinksGetReportFiltersLink Self { get; set; }
        /// <summary>
        /// Gets or Sets Save
        /// </summary>
        [DataMember(Name="save", EmitDefaultValue=false)]
        public LinksSaveReportFilterLink Save { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportFiltersLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
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
            return this.Equals(obj as ReportFiltersLinks);
        }

        /// <summary>
        /// Returns true if ReportFiltersLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportFiltersLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportFiltersLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Save == other.Save ||
                    this.Save != null &&
                    this.Save.Equals(other.Save)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Save != null)
                    hash = hash * 59 + this.Save.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
