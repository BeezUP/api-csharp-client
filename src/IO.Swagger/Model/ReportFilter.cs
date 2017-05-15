/* 
 * Public - Security
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
    /// ReportFilter
    /// </summary>
    [DataContract]
    public partial class ReportFilter :  IEquatable<ReportFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportFilter" /> class.
        /// </summary>
        /// <param name="ReportFilterId">Report filter identifier (required).</param>
        /// <param name="ReportFilterName">Report filter name (required).</param>
        /// <param name="Parameters">Parameters (required).</param>
        /// <param name="Links">Links.</param>
        public ReportFilter(string ReportFilterId = default(string), string ReportFilterName = default(string), ReportFilterParameters Parameters = default(ReportFilterParameters), ReportFilterLinks Links = default(ReportFilterLinks))
        {
            // to ensure "ReportFilterId" is required (not null)
            if (ReportFilterId == null)
            {
                throw new InvalidDataException("ReportFilterId is a required property for ReportFilter and cannot be null");
            }
            else
            {
                this.ReportFilterId = ReportFilterId;
            }
            // to ensure "ReportFilterName" is required (not null)
            if (ReportFilterName == null)
            {
                throw new InvalidDataException("ReportFilterName is a required property for ReportFilter and cannot be null");
            }
            else
            {
                this.ReportFilterName = ReportFilterName;
            }
            // to ensure "Parameters" is required (not null)
            if (Parameters == null)
            {
                throw new InvalidDataException("Parameters is a required property for ReportFilter and cannot be null");
            }
            else
            {
                this.Parameters = Parameters;
            }
            this.Links = Links;
        }
        
        /// <summary>
        /// Report filter identifier
        /// </summary>
        /// <value>Report filter identifier</value>
        [DataMember(Name="reportFilterId", EmitDefaultValue=false)]
        public string ReportFilterId { get; set; }
        /// <summary>
        /// Report filter name
        /// </summary>
        /// <value>Report filter name</value>
        [DataMember(Name="reportFilterName", EmitDefaultValue=false)]
        public string ReportFilterName { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public ReportFilterParameters Parameters { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ReportFilterLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportFilter {\n");
            sb.Append("  ReportFilterId: ").Append(ReportFilterId).Append("\n");
            sb.Append("  ReportFilterName: ").Append(ReportFilterName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(obj as ReportFilter);
        }

        /// <summary>
        /// Returns true if ReportFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportFilterId == other.ReportFilterId ||
                    this.ReportFilterId != null &&
                    this.ReportFilterId.Equals(other.ReportFilterId)
                ) && 
                (
                    this.ReportFilterName == other.ReportFilterName ||
                    this.ReportFilterName != null &&
                    this.ReportFilterName.Equals(other.ReportFilterName)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.Equals(other.Parameters)
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
                if (this.ReportFilterId != null)
                    hash = hash * 59 + this.ReportFilterId.GetHashCode();
                if (this.ReportFilterName != null)
                    hash = hash * 59 + this.ReportFilterName.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
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
