/* 
 * BeezUP API
 *
 * # The REST API of BeezUP system ## Overview The REST APIs provide programmatic access to read and write BeezUP data.  Basically, with this API you will be able to do everything like you were with your browser on https://go.beezup.com !  The main features are: - Register and manage your account - Create and manage and share your stores with your friends/co-workers. - Import your product catalog and schedule the auto importation - Search the channels your want to use - Configure your channels for your catalogs to export your product information:     - cost and general settings     - category and columns mappings     - your will be able to create and manage your custom column     - put in place exlusion filters based on simple conditions on your product data     - override product values     - get product vision for a channel catalog scope - Analyze and optimize your performance of your catalogs on all yours channels with different type of reportings by day, channel, category and by product. - Automatize your optimisation by using rules! - And of course... Manage your orders harvested from all your marketplaces:     - Synchronize your orders in an uniformized way     - Get the available actions and update the order status - ...and more!  ## Authentication credentials The public API with the base path **_/v2/public** have been put in place to give you an entry point to our system for the user registration, login and lost password. The public API does not require any credentials. We give you the some public list of values and public channels for our public commercial web site [www.beezup.com](http://www.beezup.com).  The user API with the base path **_/v2/user** requires a token which is available on this page: https://go.beezup.com/Account/MyAccount  ## Things to keep in mind ### API Rate Limits - The BeezUP REST API is limited to 100 calls/minute.  ### Media type The default media type for requests and responses is application/json. Where noted, some operations support other content types. If no additional content type is mentioned for a specific operation, then the media type is application/json.  ### Required content type The required and default encoding for the request and responses is UTF8.  ### Required date time format All our date time are formatted in ISO 8601 format: 2014-06-24T16:25:00Z.  ### Base URL The Base URL of the BeezUP API Order Management REST API conforms to the following template.  https://api.beezup.com  All URLs returned by the BeezUP API are relative to this base URL, and all requests to the REST API must use this base URL template.  You can test our API on https://api-docs.beezup.com/swagger-ui\\ You can contact us on [gitter, #BeezUP/API](https://gitter.im/beezUP/API) 
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
    /// ReportByCategoryRequest
    /// </summary>
    [DataContract]
    public partial class ReportByCategoryRequest :  IEquatable<ReportByCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByCategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportByCategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportByCategoryRequest" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="BeginPeriodUtcDate">The begin date period you want to get the report (required).</param>
        /// <param name="EndPeriodUtcDate">The end date period you want to get the report. (required).</param>
        /// <param name="CategoryFilter">CategoryFilter.</param>
        /// <param name="IndicatorFilters">IndicatorFilters.</param>
        /// <param name="AdvancedFilters">AdvancedFilters (required).</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="PageNumber">PageNumber.</param>
        public ReportByCategoryRequest(BeezUPCommonChannelId ChannelId = default(BeezUPCommonChannelId), DateTime? BeginPeriodUtcDate = default(DateTime?), DateTime? EndPeriodUtcDate = default(DateTime?), ReportCategoryFilter CategoryFilter = default(ReportCategoryFilter), List<ReportIndicatorFilter> IndicatorFilters = default(List<ReportIndicatorFilter>), ReportAdvancedFilters AdvancedFilters = default(ReportAdvancedFilters), PageSize PageSize = default(PageSize), PageNumber PageNumber = default(PageNumber))
        {
            // to ensure "BeginPeriodUtcDate" is required (not null)
            if (BeginPeriodUtcDate == null)
            {
                throw new InvalidDataException("BeginPeriodUtcDate is a required property for ReportByCategoryRequest and cannot be null");
            }
            else
            {
                this.BeginPeriodUtcDate = BeginPeriodUtcDate;
            }
            // to ensure "EndPeriodUtcDate" is required (not null)
            if (EndPeriodUtcDate == null)
            {
                throw new InvalidDataException("EndPeriodUtcDate is a required property for ReportByCategoryRequest and cannot be null");
            }
            else
            {
                this.EndPeriodUtcDate = EndPeriodUtcDate;
            }
            // to ensure "AdvancedFilters" is required (not null)
            if (AdvancedFilters == null)
            {
                throw new InvalidDataException("AdvancedFilters is a required property for ReportByCategoryRequest and cannot be null");
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
            sb.Append("class ReportByCategoryRequest {\n");
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
            return this.Equals(obj as ReportByCategoryRequest);
        }

        /// <summary>
        /// Returns true if ReportByCategoryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportByCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportByCategoryRequest other)
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
