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
    /// The reporting related to a harvest order operation
    /// </summary>
    [DataContract]
    public partial class HarvestOrderReporting :  IEquatable<HarvestOrderReporting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HarvestOrderReporting" /> class.
        /// </summary>
        /// <param name="ExecutionUUID">ExecutionUUID.</param>
        /// <param name="CreationUtcDate">The creation UTC date of the execution.</param>
        /// <param name="ProcessingStatus">The processing status of the execution.</param>
        /// <param name="LastUpdateUtcDate">The last update UTC date of the execution.</param>
        /// <param name="ErrorMessage">The warning message during the execution.</param>
        /// <param name="WarningMessage">The warning message during the execution.</param>
        /// <param name="BeezUPStatus">BeezUPStatus.</param>
        /// <param name="MarketplaceStatus">The order marketplace status.</param>
        /// <param name="BeezUPForcedStatus">The marketplace order status forced by BeezUP during the order change oepration. This could happend when there is no status on the marketplace side..</param>
        public HarvestOrderReporting(ExecutionUUID ExecutionUUID = default(ExecutionUUID), DateTime? CreationUtcDate = default(DateTime?), string ProcessingStatus = default(string), DateTime? LastUpdateUtcDate = default(DateTime?), string ErrorMessage = default(string), string WarningMessage = default(string), BeezUPOrderStatus BeezUPStatus = default(BeezUPOrderStatus), string MarketplaceStatus = default(string), string BeezUPForcedStatus = default(string))
        {
            this.ExecutionUUID = ExecutionUUID;
            this.CreationUtcDate = CreationUtcDate;
            this.ProcessingStatus = ProcessingStatus;
            this.LastUpdateUtcDate = LastUpdateUtcDate;
            this.ErrorMessage = ErrorMessage;
            this.WarningMessage = WarningMessage;
            this.BeezUPStatus = BeezUPStatus;
            this.MarketplaceStatus = MarketplaceStatus;
            this.BeezUPForcedStatus = BeezUPForcedStatus;
        }
        
        /// <summary>
        /// Gets or Sets ExecutionUUID
        /// </summary>
        [DataMember(Name="executionUUID", EmitDefaultValue=false)]
        public ExecutionUUID ExecutionUUID { get; set; }
        /// <summary>
        /// The creation UTC date of the execution
        /// </summary>
        /// <value>The creation UTC date of the execution</value>
        [DataMember(Name="creationUtcDate", EmitDefaultValue=false)]
        public DateTime? CreationUtcDate { get; set; }
        /// <summary>
        /// The processing status of the execution
        /// </summary>
        /// <value>The processing status of the execution</value>
        [DataMember(Name="processingStatus", EmitDefaultValue=false)]
        public string ProcessingStatus { get; set; }
        /// <summary>
        /// The last update UTC date of the execution
        /// </summary>
        /// <value>The last update UTC date of the execution</value>
        [DataMember(Name="lastUpdateUtcDate", EmitDefaultValue=false)]
        public DateTime? LastUpdateUtcDate { get; set; }
        /// <summary>
        /// The warning message during the execution
        /// </summary>
        /// <value>The warning message during the execution</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
        /// <summary>
        /// The warning message during the execution
        /// </summary>
        /// <value>The warning message during the execution</value>
        [DataMember(Name="warningMessage", EmitDefaultValue=false)]
        public string WarningMessage { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPStatus
        /// </summary>
        [DataMember(Name="beezUPStatus", EmitDefaultValue=false)]
        public BeezUPOrderStatus BeezUPStatus { get; set; }
        /// <summary>
        /// The order marketplace status
        /// </summary>
        /// <value>The order marketplace status</value>
        [DataMember(Name="marketplaceStatus", EmitDefaultValue=false)]
        public string MarketplaceStatus { get; set; }
        /// <summary>
        /// The marketplace order status forced by BeezUP during the order change oepration. This could happend when there is no status on the marketplace side.
        /// </summary>
        /// <value>The marketplace order status forced by BeezUP during the order change oepration. This could happend when there is no status on the marketplace side.</value>
        [DataMember(Name="beezUPForcedStatus", EmitDefaultValue=false)]
        public string BeezUPForcedStatus { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HarvestOrderReporting {\n");
            sb.Append("  ExecutionUUID: ").Append(ExecutionUUID).Append("\n");
            sb.Append("  CreationUtcDate: ").Append(CreationUtcDate).Append("\n");
            sb.Append("  ProcessingStatus: ").Append(ProcessingStatus).Append("\n");
            sb.Append("  LastUpdateUtcDate: ").Append(LastUpdateUtcDate).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  WarningMessage: ").Append(WarningMessage).Append("\n");
            sb.Append("  BeezUPStatus: ").Append(BeezUPStatus).Append("\n");
            sb.Append("  MarketplaceStatus: ").Append(MarketplaceStatus).Append("\n");
            sb.Append("  BeezUPForcedStatus: ").Append(BeezUPForcedStatus).Append("\n");
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
            return this.Equals(obj as HarvestOrderReporting);
        }

        /// <summary>
        /// Returns true if HarvestOrderReporting instances are equal
        /// </summary>
        /// <param name="other">Instance of HarvestOrderReporting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HarvestOrderReporting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExecutionUUID == other.ExecutionUUID ||
                    this.ExecutionUUID != null &&
                    this.ExecutionUUID.Equals(other.ExecutionUUID)
                ) && 
                (
                    this.CreationUtcDate == other.CreationUtcDate ||
                    this.CreationUtcDate != null &&
                    this.CreationUtcDate.Equals(other.CreationUtcDate)
                ) && 
                (
                    this.ProcessingStatus == other.ProcessingStatus ||
                    this.ProcessingStatus != null &&
                    this.ProcessingStatus.Equals(other.ProcessingStatus)
                ) && 
                (
                    this.LastUpdateUtcDate == other.LastUpdateUtcDate ||
                    this.LastUpdateUtcDate != null &&
                    this.LastUpdateUtcDate.Equals(other.LastUpdateUtcDate)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.WarningMessage == other.WarningMessage ||
                    this.WarningMessage != null &&
                    this.WarningMessage.Equals(other.WarningMessage)
                ) && 
                (
                    this.BeezUPStatus == other.BeezUPStatus ||
                    this.BeezUPStatus != null &&
                    this.BeezUPStatus.Equals(other.BeezUPStatus)
                ) && 
                (
                    this.MarketplaceStatus == other.MarketplaceStatus ||
                    this.MarketplaceStatus != null &&
                    this.MarketplaceStatus.Equals(other.MarketplaceStatus)
                ) && 
                (
                    this.BeezUPForcedStatus == other.BeezUPForcedStatus ||
                    this.BeezUPForcedStatus != null &&
                    this.BeezUPForcedStatus.Equals(other.BeezUPForcedStatus)
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
                if (this.ExecutionUUID != null)
                    hash = hash * 59 + this.ExecutionUUID.GetHashCode();
                if (this.CreationUtcDate != null)
                    hash = hash * 59 + this.CreationUtcDate.GetHashCode();
                if (this.ProcessingStatus != null)
                    hash = hash * 59 + this.ProcessingStatus.GetHashCode();
                if (this.LastUpdateUtcDate != null)
                    hash = hash * 59 + this.LastUpdateUtcDate.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.WarningMessage != null)
                    hash = hash * 59 + this.WarningMessage.GetHashCode();
                if (this.BeezUPStatus != null)
                    hash = hash * 59 + this.BeezUPStatus.GetHashCode();
                if (this.MarketplaceStatus != null)
                    hash = hash * 59 + this.MarketplaceStatus.GetHashCode();
                if (this.BeezUPForcedStatus != null)
                    hash = hash * 59 + this.BeezUPForcedStatus.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}