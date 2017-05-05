/* 
 * Marketplaces - Orders
 *
 * The features exposed in this API are centered around managing Orders harvested from your configured marketplaces.\\ This includes: - fetching current information (as known by BeezUP) for a single or multiple Orders, - requesting Order harvest to synchronize your marketplaces and BeezUP accounts, - changing BeezUP data and requesting changes to your marketplaces (accepting, shipping, etc), - configuring automatic changes to marketplace based our newly fetched data, - creating and exporting reports for your Orders. 
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
    /// Represent the reporting of the Order report exportations
    /// </summary>
    [DataContract]
    public partial class OrderExportationReporting :  IEquatable<OrderExportationReporting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExportationReporting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderExportationReporting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExportationReporting" /> class.
        /// </summary>
        /// <param name="AbortionUtcDate">AbortionUtcDate.</param>
        /// <param name="BeginUtcDate">BeginUtcDate.</param>
        /// <param name="BlobNameUri">BlobNameUri.</param>
        /// <param name="EndUtcDate">EndUtcDate.</param>
        /// <param name="EnqueuedUtcDate">EnqueuedUtcDate (required).</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="ExecutionUUID">ExecutionUUID (required).</param>
        /// <param name="ExpirationUtcDate">ExpirationUtcDate.</param>
        /// <param name="FailureUtcDate">FailureUtcDate.</param>
        /// <param name="IpAddress">IpAddress (required).</param>
        /// <param name="JsonCriteria">Raw representation of the JSON.</param>
        /// <param name="LastUpdateUtcDate">LastUpdateUtcDate.</param>
        /// <param name="OrderCount">OrderCount.</param>
        /// <param name="ProcessingStatus">ProcessingStatus (required).</param>
        /// <param name="RemainingOrderCount">RemainingOrderCount.</param>
        /// <param name="ResumedUtcDate">ResumedUtcDate.</param>
        /// <param name="SourceType">SourceType (required).</param>
        /// <param name="SourceUserId">SourceUserId.</param>
        /// <param name="SourceUserName">SourceUserName (required).</param>
        /// <param name="SuspendedUtcDate">SuspendedUtcDate.</param>
        /// <param name="TimeoutDuration">TimeoutDuration.</param>
        /// <param name="WarningMessage">WarningMessage.</param>
        public OrderExportationReporting(DateTime? AbortionUtcDate = default(DateTime?), DateTime? BeginUtcDate = default(DateTime?), string BlobNameUri = default(string), DateTime? EndUtcDate = default(DateTime?), DateTime? EnqueuedUtcDate = default(DateTime?), string ErrorMessage = default(string), Guid? ExecutionUUID = default(Guid?), DateTime? ExpirationUtcDate = default(DateTime?), DateTime? FailureUtcDate = default(DateTime?), string IpAddress = default(string), string JsonCriteria = default(string), DateTime? LastUpdateUtcDate = default(DateTime?), int? OrderCount = default(int?), OrderExportationReportingProcessingStatus ProcessingStatus = default(OrderExportationReportingProcessingStatus), int? RemainingOrderCount = default(int?), DateTime? ResumedUtcDate = default(DateTime?), SourceType SourceType = default(SourceType), BeezUPCommonUserId SourceUserId = default(BeezUPCommonUserId), string SourceUserName = default(string), DateTime? SuspendedUtcDate = default(DateTime?), string TimeoutDuration = default(string), string WarningMessage = default(string))
        {
            // to ensure "EnqueuedUtcDate" is required (not null)
            if (EnqueuedUtcDate == null)
            {
                throw new InvalidDataException("EnqueuedUtcDate is a required property for OrderExportationReporting and cannot be null");
            }
            else
            {
                this.EnqueuedUtcDate = EnqueuedUtcDate;
            }
            // to ensure "ExecutionUUID" is required (not null)
            if (ExecutionUUID == null)
            {
                throw new InvalidDataException("ExecutionUUID is a required property for OrderExportationReporting and cannot be null");
            }
            else
            {
                this.ExecutionUUID = ExecutionUUID;
            }
            // to ensure "IpAddress" is required (not null)
            if (IpAddress == null)
            {
                throw new InvalidDataException("IpAddress is a required property for OrderExportationReporting and cannot be null");
            }
            else
            {
                this.IpAddress = IpAddress;
            }
            // to ensure "ProcessingStatus" is required (not null)
            if (ProcessingStatus == null)
            {
                throw new InvalidDataException("ProcessingStatus is a required property for OrderExportationReporting and cannot be null");
            }
            else
            {
                this.ProcessingStatus = ProcessingStatus;
            }
            // to ensure "SourceType" is required (not null)
            if (SourceType == null)
            {
                throw new InvalidDataException("SourceType is a required property for OrderExportationReporting and cannot be null");
            }
            else
            {
                this.SourceType = SourceType;
            }
            // to ensure "SourceUserName" is required (not null)
            if (SourceUserName == null)
            {
                throw new InvalidDataException("SourceUserName is a required property for OrderExportationReporting and cannot be null");
            }
            else
            {
                this.SourceUserName = SourceUserName;
            }
            this.AbortionUtcDate = AbortionUtcDate;
            this.BeginUtcDate = BeginUtcDate;
            this.BlobNameUri = BlobNameUri;
            this.EndUtcDate = EndUtcDate;
            this.ErrorMessage = ErrorMessage;
            this.ExpirationUtcDate = ExpirationUtcDate;
            this.FailureUtcDate = FailureUtcDate;
            this.JsonCriteria = JsonCriteria;
            this.LastUpdateUtcDate = LastUpdateUtcDate;
            this.OrderCount = OrderCount;
            this.RemainingOrderCount = RemainingOrderCount;
            this.ResumedUtcDate = ResumedUtcDate;
            this.SourceUserId = SourceUserId;
            this.SuspendedUtcDate = SuspendedUtcDate;
            this.TimeoutDuration = TimeoutDuration;
            this.WarningMessage = WarningMessage;
        }
        
        /// <summary>
        /// Gets or Sets AbortionUtcDate
        /// </summary>
        [DataMember(Name="abortionUtcDate", EmitDefaultValue=false)]
        public DateTime? AbortionUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets BeginUtcDate
        /// </summary>
        [DataMember(Name="beginUtcDate", EmitDefaultValue=false)]
        public DateTime? BeginUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets BlobNameUri
        /// </summary>
        [DataMember(Name="blobNameUri", EmitDefaultValue=false)]
        public string BlobNameUri { get; set; }
        /// <summary>
        /// Gets or Sets EndUtcDate
        /// </summary>
        [DataMember(Name="endUtcDate", EmitDefaultValue=false)]
        public DateTime? EndUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets EnqueuedUtcDate
        /// </summary>
        [DataMember(Name="enqueuedUtcDate", EmitDefaultValue=false)]
        public DateTime? EnqueuedUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Gets or Sets ExecutionUUID
        /// </summary>
        [DataMember(Name="executionUUID", EmitDefaultValue=false)]
        public Guid? ExecutionUUID { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationUtcDate
        /// </summary>
        [DataMember(Name="expirationUtcDate", EmitDefaultValue=false)]
        public DateTime? ExpirationUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets FailureUtcDate
        /// </summary>
        [DataMember(Name="failureUtcDate", EmitDefaultValue=false)]
        public DateTime? FailureUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
        /// <summary>
        /// Raw representation of the JSON
        /// </summary>
        /// <value>Raw representation of the JSON</value>
        [DataMember(Name="jsonCriteria", EmitDefaultValue=false)]
        public string JsonCriteria { get; set; }
        /// <summary>
        /// Gets or Sets LastUpdateUtcDate
        /// </summary>
        [DataMember(Name="lastUpdateUtcDate", EmitDefaultValue=false)]
        public DateTime? LastUpdateUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets OrderCount
        /// </summary>
        [DataMember(Name="orderCount", EmitDefaultValue=false)]
        public int? OrderCount { get; set; }
        /// <summary>
        /// Gets or Sets ProcessingStatus
        /// </summary>
        [DataMember(Name="processingStatus", EmitDefaultValue=false)]
        public OrderExportationReportingProcessingStatus ProcessingStatus { get; set; }
        /// <summary>
        /// Gets or Sets RemainingOrderCount
        /// </summary>
        [DataMember(Name="remainingOrderCount", EmitDefaultValue=false)]
        public int? RemainingOrderCount { get; set; }
        /// <summary>
        /// Gets or Sets ResumedUtcDate
        /// </summary>
        [DataMember(Name="resumedUtcDate", EmitDefaultValue=false)]
        public DateTime? ResumedUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public SourceType SourceType { get; set; }
        /// <summary>
        /// Gets or Sets SourceUserId
        /// </summary>
        [DataMember(Name="sourceUserId", EmitDefaultValue=false)]
        public BeezUPCommonUserId SourceUserId { get; set; }
        /// <summary>
        /// Gets or Sets SourceUserName
        /// </summary>
        [DataMember(Name="sourceUserName", EmitDefaultValue=false)]
        public string SourceUserName { get; set; }
        /// <summary>
        /// Gets or Sets SuspendedUtcDate
        /// </summary>
        [DataMember(Name="suspendedUtcDate", EmitDefaultValue=false)]
        public DateTime? SuspendedUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets TimeoutDuration
        /// </summary>
        [DataMember(Name="timeoutDuration", EmitDefaultValue=false)]
        public string TimeoutDuration { get; set; }
        /// <summary>
        /// Gets or Sets WarningMessage
        /// </summary>
        [DataMember(Name="warningMessage", EmitDefaultValue=false)]
        public string WarningMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderExportationReporting {\n");
            sb.Append("  AbortionUtcDate: ").Append(AbortionUtcDate).Append("\n");
            sb.Append("  BeginUtcDate: ").Append(BeginUtcDate).Append("\n");
            sb.Append("  BlobNameUri: ").Append(BlobNameUri).Append("\n");
            sb.Append("  EndUtcDate: ").Append(EndUtcDate).Append("\n");
            sb.Append("  EnqueuedUtcDate: ").Append(EnqueuedUtcDate).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ExecutionUUID: ").Append(ExecutionUUID).Append("\n");
            sb.Append("  ExpirationUtcDate: ").Append(ExpirationUtcDate).Append("\n");
            sb.Append("  FailureUtcDate: ").Append(FailureUtcDate).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  JsonCriteria: ").Append(JsonCriteria).Append("\n");
            sb.Append("  LastUpdateUtcDate: ").Append(LastUpdateUtcDate).Append("\n");
            sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  ProcessingStatus: ").Append(ProcessingStatus).Append("\n");
            sb.Append("  RemainingOrderCount: ").Append(RemainingOrderCount).Append("\n");
            sb.Append("  ResumedUtcDate: ").Append(ResumedUtcDate).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceUserId: ").Append(SourceUserId).Append("\n");
            sb.Append("  SourceUserName: ").Append(SourceUserName).Append("\n");
            sb.Append("  SuspendedUtcDate: ").Append(SuspendedUtcDate).Append("\n");
            sb.Append("  TimeoutDuration: ").Append(TimeoutDuration).Append("\n");
            sb.Append("  WarningMessage: ").Append(WarningMessage).Append("\n");
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
            return this.Equals(obj as OrderExportationReporting);
        }

        /// <summary>
        /// Returns true if OrderExportationReporting instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderExportationReporting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderExportationReporting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AbortionUtcDate == other.AbortionUtcDate ||
                    this.AbortionUtcDate != null &&
                    this.AbortionUtcDate.Equals(other.AbortionUtcDate)
                ) && 
                (
                    this.BeginUtcDate == other.BeginUtcDate ||
                    this.BeginUtcDate != null &&
                    this.BeginUtcDate.Equals(other.BeginUtcDate)
                ) && 
                (
                    this.BlobNameUri == other.BlobNameUri ||
                    this.BlobNameUri != null &&
                    this.BlobNameUri.Equals(other.BlobNameUri)
                ) && 
                (
                    this.EndUtcDate == other.EndUtcDate ||
                    this.EndUtcDate != null &&
                    this.EndUtcDate.Equals(other.EndUtcDate)
                ) && 
                (
                    this.EnqueuedUtcDate == other.EnqueuedUtcDate ||
                    this.EnqueuedUtcDate != null &&
                    this.EnqueuedUtcDate.Equals(other.EnqueuedUtcDate)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.ExecutionUUID == other.ExecutionUUID ||
                    this.ExecutionUUID != null &&
                    this.ExecutionUUID.Equals(other.ExecutionUUID)
                ) && 
                (
                    this.ExpirationUtcDate == other.ExpirationUtcDate ||
                    this.ExpirationUtcDate != null &&
                    this.ExpirationUtcDate.Equals(other.ExpirationUtcDate)
                ) && 
                (
                    this.FailureUtcDate == other.FailureUtcDate ||
                    this.FailureUtcDate != null &&
                    this.FailureUtcDate.Equals(other.FailureUtcDate)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.JsonCriteria == other.JsonCriteria ||
                    this.JsonCriteria != null &&
                    this.JsonCriteria.Equals(other.JsonCriteria)
                ) && 
                (
                    this.LastUpdateUtcDate == other.LastUpdateUtcDate ||
                    this.LastUpdateUtcDate != null &&
                    this.LastUpdateUtcDate.Equals(other.LastUpdateUtcDate)
                ) && 
                (
                    this.OrderCount == other.OrderCount ||
                    this.OrderCount != null &&
                    this.OrderCount.Equals(other.OrderCount)
                ) && 
                (
                    this.ProcessingStatus == other.ProcessingStatus ||
                    this.ProcessingStatus != null &&
                    this.ProcessingStatus.Equals(other.ProcessingStatus)
                ) && 
                (
                    this.RemainingOrderCount == other.RemainingOrderCount ||
                    this.RemainingOrderCount != null &&
                    this.RemainingOrderCount.Equals(other.RemainingOrderCount)
                ) && 
                (
                    this.ResumedUtcDate == other.ResumedUtcDate ||
                    this.ResumedUtcDate != null &&
                    this.ResumedUtcDate.Equals(other.ResumedUtcDate)
                ) && 
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) && 
                (
                    this.SourceUserId == other.SourceUserId ||
                    this.SourceUserId != null &&
                    this.SourceUserId.Equals(other.SourceUserId)
                ) && 
                (
                    this.SourceUserName == other.SourceUserName ||
                    this.SourceUserName != null &&
                    this.SourceUserName.Equals(other.SourceUserName)
                ) && 
                (
                    this.SuspendedUtcDate == other.SuspendedUtcDate ||
                    this.SuspendedUtcDate != null &&
                    this.SuspendedUtcDate.Equals(other.SuspendedUtcDate)
                ) && 
                (
                    this.TimeoutDuration == other.TimeoutDuration ||
                    this.TimeoutDuration != null &&
                    this.TimeoutDuration.Equals(other.TimeoutDuration)
                ) && 
                (
                    this.WarningMessage == other.WarningMessage ||
                    this.WarningMessage != null &&
                    this.WarningMessage.Equals(other.WarningMessage)
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
                if (this.AbortionUtcDate != null)
                    hash = hash * 59 + this.AbortionUtcDate.GetHashCode();
                if (this.BeginUtcDate != null)
                    hash = hash * 59 + this.BeginUtcDate.GetHashCode();
                if (this.BlobNameUri != null)
                    hash = hash * 59 + this.BlobNameUri.GetHashCode();
                if (this.EndUtcDate != null)
                    hash = hash * 59 + this.EndUtcDate.GetHashCode();
                if (this.EnqueuedUtcDate != null)
                    hash = hash * 59 + this.EnqueuedUtcDate.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.ExecutionUUID != null)
                    hash = hash * 59 + this.ExecutionUUID.GetHashCode();
                if (this.ExpirationUtcDate != null)
                    hash = hash * 59 + this.ExpirationUtcDate.GetHashCode();
                if (this.FailureUtcDate != null)
                    hash = hash * 59 + this.FailureUtcDate.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.JsonCriteria != null)
                    hash = hash * 59 + this.JsonCriteria.GetHashCode();
                if (this.LastUpdateUtcDate != null)
                    hash = hash * 59 + this.LastUpdateUtcDate.GetHashCode();
                if (this.OrderCount != null)
                    hash = hash * 59 + this.OrderCount.GetHashCode();
                if (this.ProcessingStatus != null)
                    hash = hash * 59 + this.ProcessingStatus.GetHashCode();
                if (this.RemainingOrderCount != null)
                    hash = hash * 59 + this.RemainingOrderCount.GetHashCode();
                if (this.ResumedUtcDate != null)
                    hash = hash * 59 + this.ResumedUtcDate.GetHashCode();
                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();
                if (this.SourceUserId != null)
                    hash = hash * 59 + this.SourceUserId.GetHashCode();
                if (this.SourceUserName != null)
                    hash = hash * 59 + this.SourceUserName.GetHashCode();
                if (this.SuspendedUtcDate != null)
                    hash = hash * 59 + this.SuspendedUtcDate.GetHashCode();
                if (this.TimeoutDuration != null)
                    hash = hash * 59 + this.TimeoutDuration.GetHashCode();
                if (this.WarningMessage != null)
                    hash = hash * 59 + this.WarningMessage.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}