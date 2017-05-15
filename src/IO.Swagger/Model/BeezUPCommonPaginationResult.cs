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
    /// BeezUPCommonPaginationResult
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonPaginationResult :  IEquatable<BeezUPCommonPaginationResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonPaginationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonPaginationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonPaginationResult" /> class.
        /// </summary>
        /// <param name="EntryCount">The entry count currently returned (required).</param>
        /// <param name="PageCount">The page count (required).</param>
        /// <param name="TotalEntryCount">The total entry count (required).</param>
        /// <param name="Links">Links (required).</param>
        public BeezUPCommonPaginationResult(int? EntryCount = default(int?), int? PageCount = default(int?), int? TotalEntryCount = default(int?), BeezUPCommonPaginationResultLinks Links = default(BeezUPCommonPaginationResultLinks))
        {
            // to ensure "EntryCount" is required (not null)
            if (EntryCount == null)
            {
                throw new InvalidDataException("EntryCount is a required property for BeezUPCommonPaginationResult and cannot be null");
            }
            else
            {
                this.EntryCount = EntryCount;
            }
            // to ensure "PageCount" is required (not null)
            if (PageCount == null)
            {
                throw new InvalidDataException("PageCount is a required property for BeezUPCommonPaginationResult and cannot be null");
            }
            else
            {
                this.PageCount = PageCount;
            }
            // to ensure "TotalEntryCount" is required (not null)
            if (TotalEntryCount == null)
            {
                throw new InvalidDataException("TotalEntryCount is a required property for BeezUPCommonPaginationResult and cannot be null");
            }
            else
            {
                this.TotalEntryCount = TotalEntryCount;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for BeezUPCommonPaginationResult and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
        }
        
        /// <summary>
        /// The entry count currently returned
        /// </summary>
        /// <value>The entry count currently returned</value>
        [DataMember(Name="entryCount", EmitDefaultValue=false)]
        public int? EntryCount { get; set; }
        /// <summary>
        /// The page count
        /// </summary>
        /// <value>The page count</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
        /// <summary>
        /// The total entry count
        /// </summary>
        /// <value>The total entry count</value>
        [DataMember(Name="totalEntryCount", EmitDefaultValue=false)]
        public int? TotalEntryCount { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public BeezUPCommonPaginationResultLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonPaginationResult {\n");
            sb.Append("  EntryCount: ").Append(EntryCount).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  TotalEntryCount: ").Append(TotalEntryCount).Append("\n");
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
            return this.Equals(obj as BeezUPCommonPaginationResult);
        }

        /// <summary>
        /// Returns true if BeezUPCommonPaginationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonPaginationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonPaginationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EntryCount == other.EntryCount ||
                    this.EntryCount != null &&
                    this.EntryCount.Equals(other.EntryCount)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.TotalEntryCount == other.TotalEntryCount ||
                    this.TotalEntryCount != null &&
                    this.TotalEntryCount.Equals(other.TotalEntryCount)
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
                if (this.EntryCount != null)
                    hash = hash * 59 + this.EntryCount.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.TotalEntryCount != null)
                    hash = hash * 59 + this.TotalEntryCount.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // EntryCount (int?) minimum
            if(this.EntryCount < (int?)0)
            {
                yield return new ValidationResult("Invalid value for EntryCount, must be a value greater than or equal to 0.", new [] { "EntryCount" });
            }

            // PageCount (int?) minimum
            if(this.PageCount < (int?)0)
            {
                yield return new ValidationResult("Invalid value for PageCount, must be a value greater than or equal to 0.", new [] { "PageCount" });
            }

            // TotalEntryCount (int?) minimum
            if(this.TotalEntryCount < (int?)0)
            {
                yield return new ValidationResult("Invalid value for TotalEntryCount, must be a value greater than or equal to 0.", new [] { "TotalEntryCount" });
            }

            yield break;
        }
    }

}
