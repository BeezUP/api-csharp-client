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
    /// Rule
    /// </summary>
    [DataContract]
    public partial class Rule :  IEquatable<Rule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Rule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        /// <param name="RuleId">The identifier of the rule (required).</param>
        /// <param name="RuleName">The name of the rule (required).</param>
        /// <param name="LastExecutionStatus">LastExecutionStatus.</param>
        /// <param name="LastExecutionUtcDate">The utc date of the last execution.</param>
        /// <param name="ActionName">ActionName (required).</param>
        /// <param name="ReportFilterId">Report filter identifier linked to the rule (required).</param>
        /// <param name="Position">Rule execution position (required).</param>
        /// <param name="Enabled">Is the rule enabled (required).</param>
        /// <param name="ValidityStartUtcDate">Rule validity start utc date.</param>
        /// <param name="ValidityEndUtcDate">Rule validity end utc date.</param>
        /// <param name="Links">Links (required).</param>
        public Rule(string RuleId = default(string), string RuleName = default(string), RuleLastExecutionStatus LastExecutionStatus = default(RuleLastExecutionStatus), DateTime? LastExecutionUtcDate = default(DateTime?), OptimisationActionName ActionName = default(OptimisationActionName), string ReportFilterId = default(string), int? Position = default(int?), bool? Enabled = default(bool?), DateTime? ValidityStartUtcDate = default(DateTime?), DateTime? ValidityEndUtcDate = default(DateTime?), RuleLinks Links = default(RuleLinks))
        {
            // to ensure "RuleId" is required (not null)
            if (RuleId == null)
            {
                throw new InvalidDataException("RuleId is a required property for Rule and cannot be null");
            }
            else
            {
                this.RuleId = RuleId;
            }
            // to ensure "RuleName" is required (not null)
            if (RuleName == null)
            {
                throw new InvalidDataException("RuleName is a required property for Rule and cannot be null");
            }
            else
            {
                this.RuleName = RuleName;
            }
            // to ensure "ActionName" is required (not null)
            if (ActionName == null)
            {
                throw new InvalidDataException("ActionName is a required property for Rule and cannot be null");
            }
            else
            {
                this.ActionName = ActionName;
            }
            // to ensure "ReportFilterId" is required (not null)
            if (ReportFilterId == null)
            {
                throw new InvalidDataException("ReportFilterId is a required property for Rule and cannot be null");
            }
            else
            {
                this.ReportFilterId = ReportFilterId;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for Rule and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for Rule and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for Rule and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this.LastExecutionStatus = LastExecutionStatus;
            this.LastExecutionUtcDate = LastExecutionUtcDate;
            this.ValidityStartUtcDate = ValidityStartUtcDate;
            this.ValidityEndUtcDate = ValidityEndUtcDate;
        }
        
        /// <summary>
        /// The identifier of the rule
        /// </summary>
        /// <value>The identifier of the rule</value>
        [DataMember(Name="ruleId", EmitDefaultValue=false)]
        public string RuleId { get; set; }
        /// <summary>
        /// The name of the rule
        /// </summary>
        /// <value>The name of the rule</value>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }
        /// <summary>
        /// Gets or Sets LastExecutionStatus
        /// </summary>
        [DataMember(Name="lastExecutionStatus", EmitDefaultValue=false)]
        public RuleLastExecutionStatus LastExecutionStatus { get; set; }
        /// <summary>
        /// The utc date of the last execution
        /// </summary>
        /// <value>The utc date of the last execution</value>
        [DataMember(Name="lastExecutionUtcDate", EmitDefaultValue=false)]
        public DateTime? LastExecutionUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets ActionName
        /// </summary>
        [DataMember(Name="actionName", EmitDefaultValue=false)]
        public OptimisationActionName ActionName { get; set; }
        /// <summary>
        /// Report filter identifier linked to the rule
        /// </summary>
        /// <value>Report filter identifier linked to the rule</value>
        [DataMember(Name="reportFilterId", EmitDefaultValue=false)]
        public string ReportFilterId { get; set; }
        /// <summary>
        /// Rule execution position
        /// </summary>
        /// <value>Rule execution position</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }
        /// <summary>
        /// Is the rule enabled
        /// </summary>
        /// <value>Is the rule enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Rule validity start utc date
        /// </summary>
        /// <value>Rule validity start utc date</value>
        [DataMember(Name="validityStartUtcDate", EmitDefaultValue=false)]
        public DateTime? ValidityStartUtcDate { get; set; }
        /// <summary>
        /// Rule validity end utc date
        /// </summary>
        /// <value>Rule validity end utc date</value>
        [DataMember(Name="validityEndUtcDate", EmitDefaultValue=false)]
        public DateTime? ValidityEndUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public RuleLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  LastExecutionStatus: ").Append(LastExecutionStatus).Append("\n");
            sb.Append("  LastExecutionUtcDate: ").Append(LastExecutionUtcDate).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
            sb.Append("  ReportFilterId: ").Append(ReportFilterId).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ValidityStartUtcDate: ").Append(ValidityStartUtcDate).Append("\n");
            sb.Append("  ValidityEndUtcDate: ").Append(ValidityEndUtcDate).Append("\n");
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
            return this.Equals(obj as Rule);
        }

        /// <summary>
        /// Returns true if Rule instances are equal
        /// </summary>
        /// <param name="other">Instance of Rule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule other)
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
                    this.LastExecutionStatus == other.LastExecutionStatus ||
                    this.LastExecutionStatus != null &&
                    this.LastExecutionStatus.Equals(other.LastExecutionStatus)
                ) && 
                (
                    this.LastExecutionUtcDate == other.LastExecutionUtcDate ||
                    this.LastExecutionUtcDate != null &&
                    this.LastExecutionUtcDate.Equals(other.LastExecutionUtcDate)
                ) && 
                (
                    this.ActionName == other.ActionName ||
                    this.ActionName != null &&
                    this.ActionName.Equals(other.ActionName)
                ) && 
                (
                    this.ReportFilterId == other.ReportFilterId ||
                    this.ReportFilterId != null &&
                    this.ReportFilterId.Equals(other.ReportFilterId)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.ValidityStartUtcDate == other.ValidityStartUtcDate ||
                    this.ValidityStartUtcDate != null &&
                    this.ValidityStartUtcDate.Equals(other.ValidityStartUtcDate)
                ) && 
                (
                    this.ValidityEndUtcDate == other.ValidityEndUtcDate ||
                    this.ValidityEndUtcDate != null &&
                    this.ValidityEndUtcDate.Equals(other.ValidityEndUtcDate)
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
                if (this.LastExecutionStatus != null)
                    hash = hash * 59 + this.LastExecutionStatus.GetHashCode();
                if (this.LastExecutionUtcDate != null)
                    hash = hash * 59 + this.LastExecutionUtcDate.GetHashCode();
                if (this.ActionName != null)
                    hash = hash * 59 + this.ActionName.GetHashCode();
                if (this.ReportFilterId != null)
                    hash = hash * 59 + this.ReportFilterId.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.ValidityStartUtcDate != null)
                    hash = hash * 59 + this.ValidityStartUtcDate.GetHashCode();
                if (this.ValidityEndUtcDate != null)
                    hash = hash * 59 + this.ValidityEndUtcDate.GetHashCode();
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
