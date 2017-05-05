/* 
 * Channel Catalogs
 *
 * This api allows you to manage your channel catalogs.   A channel catalog is an association between your store and a channel.  You will be able to: - map your catalog colums to channel columns. - map your catalog categories to the channel categories and define a cost of this category - configure the general and cost settings of the channel - enable or disable a channel - exclude products using filters for a channel - override product values for a channel - disable or reenable a product on a channel 
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
    /// The exclusion filter
    /// </summary>
    [DataContract]
    public partial class ExclusionFilter :  IEquatable<ExclusionFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExclusionFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionFilter" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Position">The position of the exclusion filter (required).</param>
        /// <param name="GroupId">Indicate the filter&#39;s group. All filters in the same group means an \&quot;AND\&quot; operation in the filter group (required).</param>
        /// <param name="PositionInGroup">Indicate the filter group position. This information is used for the UI purpose and must be unique in the filter group. (required).</param>
        /// <param name="ChannelColumnId">ChannelColumnId (required).</param>
        /// <param name="OperatorName">OperatorName (required).</param>
        /// <param name="Value">The value indicate by the user when the filter operation requires it..</param>
        public ExclusionFilter(ExclusionFilterName Name = default(ExclusionFilterName), int? Position = default(int?), string GroupId = default(string), int? PositionInGroup = default(int?), BeezUPCommonChannelColumnId ChannelColumnId = default(BeezUPCommonChannelColumnId), ExclusionFilterOperatorName OperatorName = default(ExclusionFilterOperatorName), string Value = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ExclusionFilter and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Position" is required (not null)
            if (Position == null)
            {
                throw new InvalidDataException("Position is a required property for ExclusionFilter and cannot be null");
            }
            else
            {
                this.Position = Position;
            }
            // to ensure "GroupId" is required (not null)
            if (GroupId == null)
            {
                throw new InvalidDataException("GroupId is a required property for ExclusionFilter and cannot be null");
            }
            else
            {
                this.GroupId = GroupId;
            }
            // to ensure "PositionInGroup" is required (not null)
            if (PositionInGroup == null)
            {
                throw new InvalidDataException("PositionInGroup is a required property for ExclusionFilter and cannot be null");
            }
            else
            {
                this.PositionInGroup = PositionInGroup;
            }
            // to ensure "ChannelColumnId" is required (not null)
            if (ChannelColumnId == null)
            {
                throw new InvalidDataException("ChannelColumnId is a required property for ExclusionFilter and cannot be null");
            }
            else
            {
                this.ChannelColumnId = ChannelColumnId;
            }
            // to ensure "OperatorName" is required (not null)
            if (OperatorName == null)
            {
                throw new InvalidDataException("OperatorName is a required property for ExclusionFilter and cannot be null");
            }
            else
            {
                this.OperatorName = OperatorName;
            }
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public ExclusionFilterName Name { get; set; }
        /// <summary>
        /// The position of the exclusion filter
        /// </summary>
        /// <value>The position of the exclusion filter</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }
        /// <summary>
        /// Indicate the filter&#39;s group. All filters in the same group means an \&quot;AND\&quot; operation in the filter group
        /// </summary>
        /// <value>Indicate the filter&#39;s group. All filters in the same group means an \&quot;AND\&quot; operation in the filter group</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        /// <summary>
        /// Indicate the filter group position. This information is used for the UI purpose and must be unique in the filter group.
        /// </summary>
        /// <value>Indicate the filter group position. This information is used for the UI purpose and must be unique in the filter group.</value>
        [DataMember(Name="positionInGroup", EmitDefaultValue=false)]
        public int? PositionInGroup { get; set; }
        /// <summary>
        /// Gets or Sets ChannelColumnId
        /// </summary>
        [DataMember(Name="channelColumnId", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnId ChannelColumnId { get; set; }
        /// <summary>
        /// Gets or Sets OperatorName
        /// </summary>
        [DataMember(Name="operatorName", EmitDefaultValue=false)]
        public ExclusionFilterOperatorName OperatorName { get; set; }
        /// <summary>
        /// The value indicate by the user when the filter operation requires it.
        /// </summary>
        /// <value>The value indicate by the user when the filter operation requires it.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExclusionFilter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  PositionInGroup: ").Append(PositionInGroup).Append("\n");
            sb.Append("  ChannelColumnId: ").Append(ChannelColumnId).Append("\n");
            sb.Append("  OperatorName: ").Append(OperatorName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as ExclusionFilter);
        }

        /// <summary>
        /// Returns true if ExclusionFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of ExclusionFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExclusionFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) && 
                (
                    this.PositionInGroup == other.PositionInGroup ||
                    this.PositionInGroup != null &&
                    this.PositionInGroup.Equals(other.PositionInGroup)
                ) && 
                (
                    this.ChannelColumnId == other.ChannelColumnId ||
                    this.ChannelColumnId != null &&
                    this.ChannelColumnId.Equals(other.ChannelColumnId)
                ) && 
                (
                    this.OperatorName == other.OperatorName ||
                    this.OperatorName != null &&
                    this.OperatorName.Equals(other.OperatorName)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.PositionInGroup != null)
                    hash = hash * 59 + this.PositionInGroup.GetHashCode();
                if (this.ChannelColumnId != null)
                    hash = hash * 59 + this.ChannelColumnId.GetHashCode();
                if (this.OperatorName != null)
                    hash = hash * 59 + this.OperatorName.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Position (int?) minimum
            if(this.Position < (int?)1)
            {
                yield return new ValidationResult("Invalid value for Position, must be a value greater than or equal to 1.", new [] { "Position" });
            }

            // PositionInGroup (int?) minimum
            if(this.PositionInGroup < (int?)1)
            {
                yield return new ValidationResult("Invalid value for PositionInGroup, must be a value greater than or equal to 1.", new [] { "PositionInGroup" });
            }

            yield break;
        }
    }

}
