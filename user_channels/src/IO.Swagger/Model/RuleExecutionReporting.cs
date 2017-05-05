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
    /// RuleExecutionReporting
    /// </summary>
    [DataContract]
    public partial class RuleExecutionReporting :  IEquatable<RuleExecutionReporting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleExecutionReporting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleExecutionReporting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleExecutionReporting" /> class.
        /// </summary>
        /// <param name="RuleId">The rule identifier (required).</param>
        /// <param name="RuleName">The name of the rule (required).</param>
        /// <param name="StartedUtcDate">The start utc date of the execution of the rule.</param>
        /// <param name="CompletedUtcDate">The completed utc date of the execution of the rule.</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="ErrorType">ErrorType.</param>
        /// <param name="AffectedProductCount">The count of affected products, active or not.</param>
        /// <param name="ActiveAffectedProductCount">The count of affected active products.</param>
        /// <param name="AffectedChannelCount">The count of affected Channels across all products.</param>
        /// <param name="OptimisationActionName">OptimisationActionName.</param>
        /// <param name="UserId">The userId that executed the rule if any.</param>
        /// <param name="ExecutionSource">ExecutionSource (required).</param>
        /// <param name="ReportUrl">The url for the excel report for this execution.</param>
        /// <param name="Links">Links.</param>
        public RuleExecutionReporting(string RuleId = default(string), string RuleName = default(string), DateTime? StartedUtcDate = default(DateTime?), DateTime? CompletedUtcDate = default(DateTime?), RuleExecutionReportingStatus Status = default(RuleExecutionReportingStatus), RuleExecutionReportingErrorType ErrorType = default(RuleExecutionReportingErrorType), int? AffectedProductCount = default(int?), int? ActiveAffectedProductCount = default(int?), int? AffectedChannelCount = default(int?), OptimisationActionName OptimisationActionName = default(OptimisationActionName), string UserId = default(string), RuleExecutionReportingExecutionSource ExecutionSource = default(RuleExecutionReportingExecutionSource), string ReportUrl = default(string), RuleExecutionReportingLinks Links = default(RuleExecutionReportingLinks))
        {
            // to ensure "RuleId" is required (not null)
            if (RuleId == null)
            {
                throw new InvalidDataException("RuleId is a required property for RuleExecutionReporting and cannot be null");
            }
            else
            {
                this.RuleId = RuleId;
            }
            // to ensure "RuleName" is required (not null)
            if (RuleName == null)
            {
                throw new InvalidDataException("RuleName is a required property for RuleExecutionReporting and cannot be null");
            }
            else
            {
                this.RuleName = RuleName;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for RuleExecutionReporting and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "ExecutionSource" is required (not null)
            if (ExecutionSource == null)
            {
                throw new InvalidDataException("ExecutionSource is a required property for RuleExecutionReporting and cannot be null");
            }
            else
            {
                this.ExecutionSource = ExecutionSource;
            }
            this.StartedUtcDate = StartedUtcDate;
            this.CompletedUtcDate = CompletedUtcDate;
            this.ErrorType = ErrorType;
            this.AffectedProductCount = AffectedProductCount;
            this.ActiveAffectedProductCount = ActiveAffectedProductCount;
            this.AffectedChannelCount = AffectedChannelCount;
            this.OptimisationActionName = OptimisationActionName;
            this.UserId = UserId;
            this.ReportUrl = ReportUrl;
            this.Links = Links;
        }
        
        /// <summary>
        /// The rule identifier
        /// </summary>
        /// <value>The rule identifier</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; set; }
        /// <summary>
        /// The name of the rule
        /// </summary>
        /// <value>The name of the rule</value>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }
        /// <summary>
        /// The start utc date of the execution of the rule
        /// </summary>
        /// <value>The start utc date of the execution of the rule</value>
        [DataMember(Name="startedUtcDate", EmitDefaultValue=false)]
        public DateTime? StartedUtcDate { get; set; }
        /// <summary>
        /// The completed utc date of the execution of the rule
        /// </summary>
        /// <value>The completed utc date of the execution of the rule</value>
        [DataMember(Name="completedUtcDate", EmitDefaultValue=false)]
        public DateTime? CompletedUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public RuleExecutionReportingStatus Status { get; set; }
        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [DataMember(Name="errorType", EmitDefaultValue=false)]
        public RuleExecutionReportingErrorType ErrorType { get; set; }
        /// <summary>
        /// The count of affected products, active or not
        /// </summary>
        /// <value>The count of affected products, active or not</value>
        [DataMember(Name="affectedProductCount", EmitDefaultValue=false)]
        public int? AffectedProductCount { get; set; }
        /// <summary>
        /// The count of affected active products
        /// </summary>
        /// <value>The count of affected active products</value>
        [DataMember(Name="activeAffectedProductCount", EmitDefaultValue=false)]
        public int? ActiveAffectedProductCount { get; set; }
        /// <summary>
        /// The count of affected Channels across all products
        /// </summary>
        /// <value>The count of affected Channels across all products</value>
        [DataMember(Name="affectedChannelCount", EmitDefaultValue=false)]
        public int? AffectedChannelCount { get; set; }
        /// <summary>
        /// Gets or Sets OptimisationActionName
        /// </summary>
        [DataMember(Name="optimisationActionName", EmitDefaultValue=false)]
        public OptimisationActionName OptimisationActionName { get; set; }
        /// <summary>
        /// The userId that executed the rule if any
        /// </summary>
        /// <value>The userId that executed the rule if any</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets ExecutionSource
        /// </summary>
        [DataMember(Name="executionSource", EmitDefaultValue=false)]
        public RuleExecutionReportingExecutionSource ExecutionSource { get; set; }
        /// <summary>
        /// The url for the excel report for this execution
        /// </summary>
        /// <value>The url for the excel report for this execution</value>
        [DataMember(Name="reportUrl", EmitDefaultValue=false)]
        public string ReportUrl { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public RuleExecutionReportingLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleExecutionReporting {\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  StartedUtcDate: ").Append(StartedUtcDate).Append("\n");
            sb.Append("  CompletedUtcDate: ").Append(CompletedUtcDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  AffectedProductCount: ").Append(AffectedProductCount).Append("\n");
            sb.Append("  ActiveAffectedProductCount: ").Append(ActiveAffectedProductCount).Append("\n");
            sb.Append("  AffectedChannelCount: ").Append(AffectedChannelCount).Append("\n");
            sb.Append("  OptimisationActionName: ").Append(OptimisationActionName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ExecutionSource: ").Append(ExecutionSource).Append("\n");
            sb.Append("  ReportUrl: ").Append(ReportUrl).Append("\n");
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
            return this.Equals(obj as RuleExecutionReporting);
        }

        /// <summary>
        /// Returns true if RuleExecutionReporting instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleExecutionReporting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleExecutionReporting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RuleId == other.RuleId ||
                    this.RuleId != null &&
                    this.RuleId.Equals(other.RuleId)
                ) && 
                (
                    this.RuleName == other.RuleName ||
                    this.RuleName != null &&
                    this.RuleName.Equals(other.RuleName)
                ) && 
                (
                    this.StartedUtcDate == other.StartedUtcDate ||
                    this.StartedUtcDate != null &&
                    this.StartedUtcDate.Equals(other.StartedUtcDate)
                ) && 
                (
                    this.CompletedUtcDate == other.CompletedUtcDate ||
                    this.CompletedUtcDate != null &&
                    this.CompletedUtcDate.Equals(other.CompletedUtcDate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ErrorType == other.ErrorType ||
                    this.ErrorType != null &&
                    this.ErrorType.Equals(other.ErrorType)
                ) && 
                (
                    this.AffectedProductCount == other.AffectedProductCount ||
                    this.AffectedProductCount != null &&
                    this.AffectedProductCount.Equals(other.AffectedProductCount)
                ) && 
                (
                    this.ActiveAffectedProductCount == other.ActiveAffectedProductCount ||
                    this.ActiveAffectedProductCount != null &&
                    this.ActiveAffectedProductCount.Equals(other.ActiveAffectedProductCount)
                ) && 
                (
                    this.AffectedChannelCount == other.AffectedChannelCount ||
                    this.AffectedChannelCount != null &&
                    this.AffectedChannelCount.Equals(other.AffectedChannelCount)
                ) && 
                (
                    this.OptimisationActionName == other.OptimisationActionName ||
                    this.OptimisationActionName != null &&
                    this.OptimisationActionName.Equals(other.OptimisationActionName)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ExecutionSource == other.ExecutionSource ||
                    this.ExecutionSource != null &&
                    this.ExecutionSource.Equals(other.ExecutionSource)
                ) && 
                (
                    this.ReportUrl == other.ReportUrl ||
                    this.ReportUrl != null &&
                    this.ReportUrl.Equals(other.ReportUrl)
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
                if (this.RuleId != null)
                    hash = hash * 59 + this.RuleId.GetHashCode();
                if (this.RuleName != null)
                    hash = hash * 59 + this.RuleName.GetHashCode();
                if (this.StartedUtcDate != null)
                    hash = hash * 59 + this.StartedUtcDate.GetHashCode();
                if (this.CompletedUtcDate != null)
                    hash = hash * 59 + this.CompletedUtcDate.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ErrorType != null)
                    hash = hash * 59 + this.ErrorType.GetHashCode();
                if (this.AffectedProductCount != null)
                    hash = hash * 59 + this.AffectedProductCount.GetHashCode();
                if (this.ActiveAffectedProductCount != null)
                    hash = hash * 59 + this.ActiveAffectedProductCount.GetHashCode();
                if (this.AffectedChannelCount != null)
                    hash = hash * 59 + this.AffectedChannelCount.GetHashCode();
                if (this.OptimisationActionName != null)
                    hash = hash * 59 + this.OptimisationActionName.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ExecutionSource != null)
                    hash = hash * 59 + this.ExecutionSource.GetHashCode();
                if (this.ReportUrl != null)
                    hash = hash * 59 + this.ReportUrl.GetHashCode();
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