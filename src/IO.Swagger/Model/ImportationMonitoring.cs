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
    /// Describe the reporting of the catalog importation
    /// </summary>
    [DataContract]
    public partial class ImportationMonitoring :  IEquatable<ImportationMonitoring>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportationMonitoring" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportationMonitoring() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportationMonitoring" /> class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Success">Indicates if the importation was successfully completed or not (required).</param>
        /// <param name="ExecutionId">ExecutionId (required).</param>
        /// <param name="LastUpdateUtcDate">The last update of the reporting (required).</param>
        /// <param name="BeginUtcDate">The start date of the importation (required).</param>
        /// <param name="Errors">In case of error a description will be indicated.</param>
        /// <param name="Steps">Contains all steps of the importation process with a boolean. If true the step has been passed, false the step is not complete (required).</param>
        public ImportationMonitoring(BeezUPCommonUserId UserId = default(BeezUPCommonUserId), bool? Success = default(bool?), ExecutionId ExecutionId = default(ExecutionId), DateTime? LastUpdateUtcDate = default(DateTime?), DateTime? BeginUtcDate = default(DateTime?), List<BeezUPCommonUserErrorMessage> Errors = default(List<BeezUPCommonUserErrorMessage>), Dictionary<string, bool?> Steps = default(Dictionary<string, bool?>))
        {
            // to ensure "Success" is required (not null)
            if (Success == null)
            {
                throw new InvalidDataException("Success is a required property for ImportationMonitoring and cannot be null");
            }
            else
            {
                this.Success = Success;
            }
            // to ensure "ExecutionId" is required (not null)
            if (ExecutionId == null)
            {
                throw new InvalidDataException("ExecutionId is a required property for ImportationMonitoring and cannot be null");
            }
            else
            {
                this.ExecutionId = ExecutionId;
            }
            // to ensure "LastUpdateUtcDate" is required (not null)
            if (LastUpdateUtcDate == null)
            {
                throw new InvalidDataException("LastUpdateUtcDate is a required property for ImportationMonitoring and cannot be null");
            }
            else
            {
                this.LastUpdateUtcDate = LastUpdateUtcDate;
            }
            // to ensure "BeginUtcDate" is required (not null)
            if (BeginUtcDate == null)
            {
                throw new InvalidDataException("BeginUtcDate is a required property for ImportationMonitoring and cannot be null");
            }
            else
            {
                this.BeginUtcDate = BeginUtcDate;
            }
            // to ensure "Steps" is required (not null)
            if (Steps == null)
            {
                throw new InvalidDataException("Steps is a required property for ImportationMonitoring and cannot be null");
            }
            else
            {
                this.Steps = Steps;
            }
            this.UserId = UserId;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public BeezUPCommonUserId UserId { get; set; }
        /// <summary>
        /// Indicates if the importation was successfully completed or not
        /// </summary>
        /// <value>Indicates if the importation was successfully completed or not</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
        /// <summary>
        /// Gets or Sets ExecutionId
        /// </summary>
        [DataMember(Name="executionId", EmitDefaultValue=false)]
        public ExecutionId ExecutionId { get; set; }
        /// <summary>
        /// The last update of the reporting
        /// </summary>
        /// <value>The last update of the reporting</value>
        [DataMember(Name="lastUpdateUtcDate", EmitDefaultValue=false)]
        public DateTime? LastUpdateUtcDate { get; set; }
        /// <summary>
        /// The start date of the importation
        /// </summary>
        /// <value>The start date of the importation</value>
        [DataMember(Name="beginUtcDate", EmitDefaultValue=false)]
        public DateTime? BeginUtcDate { get; set; }
        /// <summary>
        /// In case of error a description will be indicated
        /// </summary>
        /// <value>In case of error a description will be indicated</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<BeezUPCommonUserErrorMessage> Errors { get; set; }
        /// <summary>
        /// Contains all steps of the importation process with a boolean. If true the step has been passed, false the step is not complete
        /// </summary>
        /// <value>Contains all steps of the importation process with a boolean. If true the step has been passed, false the step is not complete</value>
        [DataMember(Name="steps", EmitDefaultValue=false)]
        public Dictionary<string, bool?> Steps { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportationMonitoring {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  LastUpdateUtcDate: ").Append(LastUpdateUtcDate).Append("\n");
            sb.Append("  BeginUtcDate: ").Append(BeginUtcDate).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
            return this.Equals(obj as ImportationMonitoring);
        }

        /// <summary>
        /// Returns true if ImportationMonitoring instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportationMonitoring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportationMonitoring other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) && 
                (
                    this.ExecutionId == other.ExecutionId ||
                    this.ExecutionId != null &&
                    this.ExecutionId.Equals(other.ExecutionId)
                ) && 
                (
                    this.LastUpdateUtcDate == other.LastUpdateUtcDate ||
                    this.LastUpdateUtcDate != null &&
                    this.LastUpdateUtcDate.Equals(other.LastUpdateUtcDate)
                ) && 
                (
                    this.BeginUtcDate == other.BeginUtcDate ||
                    this.BeginUtcDate != null &&
                    this.BeginUtcDate.Equals(other.BeginUtcDate)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Steps == other.Steps ||
                    this.Steps != null &&
                    this.Steps.SequenceEqual(other.Steps)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                if (this.ExecutionId != null)
                    hash = hash * 59 + this.ExecutionId.GetHashCode();
                if (this.LastUpdateUtcDate != null)
                    hash = hash * 59 + this.LastUpdateUtcDate.GetHashCode();
                if (this.BeginUtcDate != null)
                    hash = hash * 59 + this.BeginUtcDate.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Steps != null)
                    hash = hash * 59 + this.Steps.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
