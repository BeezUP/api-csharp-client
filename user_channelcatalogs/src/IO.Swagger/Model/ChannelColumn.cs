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
