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
    /// The channel column
    /// </summary>
    [DataContract]
    public partial class ChannelColumn :  IEquatable<ChannelColumn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelColumn" /> class.
        /// </summary>
        /// <param name="ChannelColumnId">ChannelColumnId (required).</param>
        /// <param name="ChannelColumnName">ChannelColumnName (required).</param>
        /// <param name="ChannelColumnDescription">ChannelColumnDescription.</param>
        /// <param name="ShowInMapping">ShowInMapping (required).</param>
        /// <param name="Position">The position of the column starting from 1 (required).</param>
        /// <param name="Configuration">Configuration (required).</param>
        /// <param name="RestrictedValues">RestrictedValues.</param>
        public ChannelColumn(BeezUPCommonChannelColumnId ChannelColumnId = default(BeezUPCommonChannelColumnId), BeezUPCommonChannelColumnName ChannelColumnName = default(BeezUPCommonChannelColumnName), ChannelColumnDescription ChannelColumnDescription = default(ChannelColumnDescription), ChannelColumnShowInMapping ShowInMapping = default(ChannelColumnShowInMapping), int? Position = default(int?), ChannelColumnConfiguration Configuration = default(ChannelColumnConfiguration), ChannelColumnRestrictedValues RestrictedValues = default(ChannelColumnRestrictedValues))
        {
            // to ensure "ChannelColumnId" is required (not null)
            if (ChannelColumnId == null)
            {
                throw new InvalidDataException("ChannelColumnId is a required property for ChannelColumn and cannot be null");
            }
            else
            {
                this.ChannelColumnId = ChannelColumnId;
            }
            // to ensure "ChannelColumnName" is required (not null)
            if (ChannelColumnName == null)
            {
                throw new InvalidDataException("ChannelColumnName is a required property for ChannelColumn and cannot be null");
            }
            else
            {
                this.ChannelColumnName = ChannelColumnName;
            }
            // to ensure "ShowInMapping" is required (not null)
            if (ShowInMapping == null)
            {
                throw new InvalidDataException("ShowInMapping is a required property for ChannelColumn and cannot be null");
            }
            else
            {
                this.ShowInMapping = ShowInMapping;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for ChannelColumn and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "Configuration" is required (not null)
            if (Configuration == null)
            {
                throw new InvalidDataException("Configuration is a required property for ChannelColumn and cannot be null");
            }
            else
            {
                this.Configuration = Configuration;
            }
            this.ChannelColumnDescription = ChannelColumnDescription;
            this.RestrictedValues = RestrictedValues;
        }
        
        /// <summary>
        /// Gets or Sets ChannelColumnId
        /// </summary>
        [DataMember(Name="channelColumnId", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnId ChannelColumnId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelColumnName
        /// </summary>
        [DataMember(Name="channelColumnName", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnName ChannelColumnName { get; set; }
        /// <summary>
        /// Gets or Sets ChannelColumnDescription
        /// </summary>
        [DataMember(Name="channelColumnDescription", EmitDefaultValue=false)]
        public ChannelColumnDescription ChannelColumnDescription { get; set; }
        /// <summary>
        /// Gets or Sets ShowInMapping
        /// </summary>
        [DataMember(Name="showInMapping", EmitDefaultValue=false)]
        public ChannelColumnShowInMapping ShowInMapping { get; set; }
        /// <summary>
        /// The position of the column starting from 1
        /// </summary>
        /// <value>The position of the column starting from 1</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }
        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public ChannelColumnConfiguration Configuration { get; set; }
        /// <summary>
        /// Gets or Sets RestrictedValues
        /// </summary>
        [DataMember(Name="restrictedValues", EmitDefaultValue=false)]
        public ChannelColumnRestrictedValues RestrictedValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelColumn {\n");
            sb.Append("  ChannelColumnId: ").Append(ChannelColumnId).Append("\n");
            sb.Append("  ChannelColumnName: ").Append(ChannelColumnName).Append("\n");
            sb.Append("  ChannelColumnDescription: ").Append(ChannelColumnDescription).Append("\n");
            sb.Append("  ShowInMapping: ").Append(ShowInMapping).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  RestrictedValues: ").Append(RestrictedValues).Append("\n");
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
            return this.Equals(obj as ChannelColumn);
        }

        /// <summary>
        /// Returns true if ChannelColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelColumn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelColumnId == other.ChannelColumnId ||
                    this.ChannelColumnId != null &&
                    this.ChannelColumnId.Equals(other.ChannelColumnId)
                ) && 
                (
                    this.ChannelColumnName == other.ChannelColumnName ||
                    this.ChannelColumnName != null &&
                    this.ChannelColumnName.Equals(other.ChannelColumnName)
                ) && 
                (
                    this.ChannelColumnDescription == other.ChannelColumnDescription ||
                    this.ChannelColumnDescription != null &&
                    this.ChannelColumnDescription.Equals(other.ChannelColumnDescription)
                ) && 
                (
                    this.ShowInMapping == other.ShowInMapping ||
                    this.ShowInMapping != null &&
                    this.ShowInMapping.Equals(other.ShowInMapping)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.Equals(other.Configuration)
                ) && 
                (
                    this.RestrictedValues == other.RestrictedValues ||
                    this.RestrictedValues != null &&
                    this.RestrictedValues.Equals(other.RestrictedValues)
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
                if (this.ChannelColumnId != null)
                    hash = hash * 59 + this.ChannelColumnId.GetHashCode();
                if (this.ChannelColumnName != null)
                    hash = hash * 59 + this.ChannelColumnName.GetHashCode();
                if (this.ChannelColumnDescription != null)
                    hash = hash * 59 + this.ChannelColumnDescription.GetHashCode();
                if (this.ShowInMapping != null)
                    hash = hash * 59 + this.ShowInMapping.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
                if (this.RestrictedValues != null)
                    hash = hash * 59 + this.RestrictedValues.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
