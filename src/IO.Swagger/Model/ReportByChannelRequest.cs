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
    /// ReportByChannelRequest
    /// </summary>
    [DataContract]
    public partial class ReportByChannelRequest :  IEquatable<ReportByChannelRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByChannelRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportByChannelRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByChannelRequest" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="BeginPeriodUtcDate">The begin date period you want to get the report (required).</param>
        /// <param name="EndPeriodUtcDate">The end date period you want to get the report. (required).</param>
        /// <param name="CategoryFilter">CategoryFilter.</param>
        /// <param name="IndicatorFilters">IndicatorFilters.</param>
        /// <param name="AdvancedFilters">AdvancedFilters (required).</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        public ReportByChannelRequest(BeezUPCommonChannelId ChannelId = default(BeezUPCommonChannelId), DateTime? BeginPeriodUtcDate = default(DateTime?), DateTime? EndPeriodUtcDate = default(DateTime?), ReportCategoryFilter CategoryFilter = default(ReportCategoryFilter), List<ReportIndicatorFilter> IndicatorFilters = default(List<ReportIndicatorFilter>), ReportAdvancedFilters AdvancedFilters = default(ReportAdvancedFilters), PageSize PageSize = default(PageSize), PageNumber PageNumber = default(PageNumber))
        {
            // to ensure "BeginPeriodUtcDate" is required (not null)
            if (BeginPeriodUtcDate == null)
            {
                throw new InvalidDataException("BeginPeriodUtcDate is a required property for ReportByChannelRequest and cannot be null");
            }
            else
            {
                this.BeginPeriodUtcDate = BeginPeriodUtcDate;
            }
            // to ensure "EndPeriodUtcDate" is required (not null)
            if (EndPeriodUtcDate == null)
            {
                throw new InvalidDataException("EndPeriodUtcDate is a required property for ReportByChannelRequest and cannot be null");
            }
            else
            {
                this.EndPeriodUtcDate = EndPeriodUtcDate;
            }
            // to ensure "AdvancedFilters" is required (not null)
            if (AdvancedFilters == null)
            {
                throw new InvalidDataException("AdvancedFilters is a required property for ReportByChannelRequest and cannot be null");
            }
            else
            {
                this.AdvancedFilters = AdvancedFilters;
            }
            this.ChannelId = ChannelId;
            this.CategoryFilter = CategoryFilter;
            this.IndicatorFilters = IndicatorFilters;
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
        }
        
        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public BeezUPCommonChannelId ChannelId { get; set; }
        /// <summary>
        /// The begin date period you want to get the report
        /// </summary>
        /// <value>The begin date period you want to get the report</value>
        [DataMember(Name="beginPeriodUtcDate", EmitDefaultValue=false)]
        public DateTime? BeginPeriodUtcDate { get; set; }
        /// <summary>
        /// The end date period you want to get the report.
        /// </summary>
        /// <value>The end date period you want to get the report.</value>
        [DataMember(Name="endPeriodUtcDate", EmitDefaultValue=false)]
        public DateTime? EndPeriodUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets CategoryFilter
        /// </summary>
        [DataMember(Name="categoryFilter", EmitDefaultValue=false)]
        public ReportCategoryFilter CategoryFilter { get; set; }
        /// <summary>
        /// Gets or Sets IndicatorFilters
        /// </summary>
        [DataMember(Name="indicatorFilters", EmitDefaultValue=false)]
        public List<ReportIndicatorFilter> IndicatorFilters { get; set; }
        /// <summary>
        /// Gets or Sets AdvancedFilters
        /// </summary>
        [DataMember(Name="advancedFilters", EmitDefaultValue=false)]
        public ReportAdvancedFilters AdvancedFilters { get; set; }
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public PageSize PageSize { get; set; }
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public PageNumber PageNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportByChannelRequest {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  BeginPeriodUtcDate: ").Append(BeginPeriodUtcDate).Append("\n");
            sb.Append("  EndPeriodUtcDate: ").Append(EndPeriodUtcDate).Append("\n");
            sb.Append("  CategoryFilter: ").Append(CategoryFilter).Append("\n");
            sb.Append("  IndicatorFilters: ").Append(IndicatorFilters).Append("\n");
            sb.Append("  AdvancedFilters: ").Append(AdvancedFilters).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
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
            return this.Equals(obj as ReportByChannelRequest);
        }

        /// <summary>
        /// Returns true if ReportByChannelRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportByChannelRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportByChannelRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) && 
                (
                    this.BeginPeriodUtcDate == other.BeginPeriodUtcDate ||
                    this.BeginPeriodUtcDate != null &&
                    this.BeginPeriodUtcDate.Equals(other.BeginPeriodUtcDate)
                ) && 
                (
                    this.EndPeriodUtcDate == other.EndPeriodUtcDate ||
                    this.EndPeriodUtcDate != null &&
                    this.EndPeriodUtcDate.Equals(other.EndPeriodUtcDate)
                ) && 
                (
                    this.CategoryFilter == other.CategoryFilter ||
                    this.CategoryFilter != null &&
                    this.CategoryFilter.Equals(other.CategoryFilter)
                ) && 
                (
                    this.IndicatorFilters == other.IndicatorFilters ||
                    this.IndicatorFilters != null &&
                    this.IndicatorFilters.SequenceEqual(other.IndicatorFilters)
                ) && 
                (
                    this.AdvancedFilters == other.AdvancedFilters ||
                    this.AdvancedFilters != null &&
                    this.AdvancedFilters.Equals(other.AdvancedFilters)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
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
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();
                if (this.BeginPeriodUtcDate != null)
                    hash = hash * 59 + this.BeginPeriodUtcDate.GetHashCode();
                if (this.EndPeriodUtcDate != null)
                    hash = hash * 59 + this.EndPeriodUtcDate.GetHashCode();
                if (this.CategoryFilter != null)
                    hash = hash * 59 + this.CategoryFilter.GetHashCode();
                if (this.IndicatorFilters != null)
                    hash = hash * 59 + this.IndicatorFilters.GetHashCode();
                if (this.AdvancedFilters != null)
                    hash = hash * 59 + this.AdvancedFilters.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
