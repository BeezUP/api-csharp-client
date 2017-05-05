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
    /// ReportByDayRequest
    /// </summary>
    [DataContract]
    public partial class ReportByDayRequest :  IEquatable<ReportByDayRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByDayRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportByDayRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByDayRequest" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="ProductId">ProductId.</param>
        /// <param name="CatalogCategoryId">CatalogCategoryId.</param>
        /// <param name="BeginPeriodUtcDate">The begin date period you want to get the report (required).</param>
        /// <param name="EndPeriodUtcDate">The end date period you want to get the report. (required).</param>
        /// <param name="AdvancedFilters">AdvancedFilters (required).</param>
        public ReportByDayRequest(BeezUPCommonChannelId ChannelId = default(BeezUPCommonChannelId), BeezUPCommonProductId ProductId = default(BeezUPCommonProductId), BeezUPCommonCatalogCategoryId CatalogCategoryId = default(BeezUPCommonCatalogCategoryId), DateTime? BeginPeriodUtcDate = default(DateTime?), DateTime? EndPeriodUtcDate = default(DateTime?), ReportAdvancedFilters AdvancedFilters = default(ReportAdvancedFilters))
        {
            // to ensure "BeginPeriodUtcDate" is required (not null)
            if (BeginPeriodUtcDate == null)
            {
                throw new InvalidDataException("BeginPeriodUtcDate is a required property for ReportByDayRequest and cannot be null");
            }
            else
            {
                this.BeginPeriodUtcDate = BeginPeriodUtcDate;
            }
            // to ensure "EndPeriodUtcDate" is required (not null)
            if (EndPeriodUtcDate == null)
            {
                throw new InvalidDataException("EndPeriodUtcDate is a required property for ReportByDayRequest and cannot be null");
            }
            else
            {
                this.EndPeriodUtcDate = EndPeriodUtcDate;
            }
            // to ensure "AdvancedFilters" is required (not null)
            if (AdvancedFilters == null)
            {
                throw new InvalidDataException("AdvancedFilters is a required property for ReportByDayRequest and cannot be null");
            }
            else
            {
                this.AdvancedFilters = AdvancedFilters;
            }
            this.ChannelId = ChannelId;
            this.ProductId = ProductId;
            this.CatalogCategoryId = CatalogCategoryId;
        }
        
        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public BeezUPCommonChannelId ChannelId { get; set; }
        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public BeezUPCommonProductId ProductId { get; set; }
        /// <summary>
        /// Gets or Sets CatalogCategoryId
        /// </summary>
        [DataMember(Name="catalogCategoryId", EmitDefaultValue=false)]
        public BeezUPCommonCatalogCategoryId CatalogCategoryId { get; set; }
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
        /// Gets or Sets AdvancedFilters
        /// </summary>
        [DataMember(Name="advancedFilters", EmitDefaultValue=false)]
        public ReportAdvancedFilters AdvancedFilters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportByDayRequest {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  CatalogCategoryId: ").Append(CatalogCategoryId).Append("\n");
            sb.Append("  BeginPeriodUtcDate: ").Append(BeginPeriodUtcDate).Append("\n");
            sb.Append("  EndPeriodUtcDate: ").Append(EndPeriodUtcDate).Append("\n");
            sb.Append("  AdvancedFilters: ").Append(AdvancedFilters).Append("\n");
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
            return this.Equals(obj as ReportByDayRequest);
        }

        /// <summary>
        /// Returns true if ReportByDayRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportByDayRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportByDayRequest other)
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
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.CatalogCategoryId == other.CatalogCategoryId ||
                    this.CatalogCategoryId != null &&
                    this.CatalogCategoryId.Equals(other.CatalogCategoryId)
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
                    this.AdvancedFilters == other.AdvancedFilters ||
                    this.AdvancedFilters != null &&
                    this.AdvancedFilters.Equals(other.AdvancedFilters)
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
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.CatalogCategoryId != null)
                    hash = hash * 59 + this.CatalogCategoryId.GetHashCode();
                if (this.BeginPeriodUtcDate != null)
                    hash = hash * 59 + this.BeginPeriodUtcDate.GetHashCode();
                if (this.EndPeriodUtcDate != null)
                    hash = hash * 59 + this.EndPeriodUtcDate.GetHashCode();
                if (this.AdvancedFilters != null)
                    hash = hash * 59 + this.AdvancedFilters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
