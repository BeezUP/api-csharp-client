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
    /// CreateRuleRequest
    /// </summary>
    [DataContract]
    public partial class CreateRuleRequest :  IEquatable<CreateRuleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRuleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRuleRequest" /> class.
        /// </summary>
        /// <param name="OptimisationActionName">OptimisationActionName (required).</param>
        /// <param name="RuleName">The name of the rule (required).</param>
        /// <param name="ReportFilterId">The report filter to use for the rule (required).</param>
        /// <param name="StartUtcDate">The start validity utc date of the rule.</param>
        /// <param name="EndUtcDate">The end validity utc date of the rule.</param>
        public CreateRuleRequest(OptimisationActionName OptimisationActionName = default(OptimisationActionName), string RuleName = default(string), string ReportFilterId = default(string), DateTime? StartUtcDate = default(DateTime?), DateTime? EndUtcDate = default(DateTime?))
        {
            // to ensure "OptimisationActionName" is required (not null)
            if (OptimisationActionName == null)
            {
                throw new InvalidDataException("OptimisationActionName is a required property for CreateRuleRequest and cannot be null");
            }
            else
            {
                this.OptimisationActionName = OptimisationActionName;
            }
            // to ensure "RuleName" is required (not null)
            if (RuleName == null)
            {
                throw new InvalidDataException("RuleName is a required property for CreateRuleRequest and cannot be null");
            }
            else
            {
                this.RuleName = RuleName;
            }
            // to ensure "ReportFilterId" is required (not null)
            if (ReportFilterId == null)
            {
                throw new InvalidDataException("ReportFilterId is a required property for CreateRuleRequest and cannot be null");
            }
            else
            {
                this.ReportFilterId = ReportFilterId;
            }
            this.StartUtcDate = StartUtcDate;
            this.EndUtcDate = EndUtcDate;
        }
        
        /// <summary>
        /// Gets or Sets OptimisationActionName
        /// </summary>
        [DataMember(Name="optimisationActionName", EmitDefaultValue=false)]
        public OptimisationActionName OptimisationActionName { get; set; }
        /// <summary>
        /// The name of the rule
        /// </summary>
        /// <value>The name of the rule</value>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }
        /// <summary>
        /// The report filter to use for the rule
        /// </summary>
        /// <value>The report filter to use for the rule</value>
        [DataMember(Name="reportFilterId", EmitDefaultValue=false)]
        public string ReportFilterId { get; set; }
        /// <summary>
        /// The start validity utc date of the rule
        /// </summary>
        /// <value>The start validity utc date of the rule</value>
        [DataMember(Name="startUtcDate", EmitDefaultValue=false)]
        public DateTime? StartUtcDate { get; set; }
        /// <summary>
        /// The end validity utc date of the rule
        /// </summary>
        /// <value>The end validity utc date of the rule</value>
        [DataMember(Name="endUtcDate", EmitDefaultValue=false)]
        public DateTime? EndUtcDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRuleRequest {\n");
            sb.Append("  OptimisationActionName: ").Append(OptimisationActionName).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  ReportFilterId: ").Append(ReportFilterId).Append("\n");
            sb.Append("  StartUtcDate: ").Append(StartUtcDate).Append("\n");
            sb.Append("  EndUtcDate: ").Append(EndUtcDate).Append("\n");
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
            return this.Equals(obj as CreateRuleRequest);
        }

        /// <summary>
        /// Returns true if CreateRuleRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRuleRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OptimisationActionName == other.OptimisationActionName ||
                    this.OptimisationActionName != null &&
                    this.OptimisationActionName.Equals(other.OptimisationActionName)
                ) && 
                (
                    this.RuleName == other.RuleName ||
                    this.RuleName != null &&
                    this.RuleName.Equals(other.RuleName)
                ) && 
                (
                    this.ReportFilterId == other.ReportFilterId ||
                    this.ReportFilterId != null &&
                    this.ReportFilterId.Equals(other.ReportFilterId)
                ) && 
                (
                    this.StartUtcDate == other.StartUtcDate ||
                    this.StartUtcDate != null &&
                    this.StartUtcDate.Equals(other.StartUtcDate)
                ) && 
                (
                    this.EndUtcDate == other.EndUtcDate ||
                    this.EndUtcDate != null &&
                    this.EndUtcDate.Equals(other.EndUtcDate)
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
                if (this.OptimisationActionName != null)
                    hash = hash * 59 + this.OptimisationActionName.GetHashCode();
                if (this.RuleName != null)
                    hash = hash * 59 + this.RuleName.GetHashCode();
                if (this.ReportFilterId != null)
                    hash = hash * 59 + this.ReportFilterId.GetHashCode();
                if (this.StartUtcDate != null)
                    hash = hash * 59 + this.StartUtcDate.GetHashCode();
                if (this.EndUtcDate != null)
                    hash = hash * 59 + this.EndUtcDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
