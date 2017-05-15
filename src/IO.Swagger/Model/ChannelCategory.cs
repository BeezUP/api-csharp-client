/* 
 * BeezUP API
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
    /// The channel category
    /// </summary>
    [DataContract]
    public partial class ChannelCategory :  IEquatable<ChannelCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCategory" /> class.
        /// </summary>
        /// <param name="ChannelCategoryId">ChannelCategoryId (required).</param>
        /// <param name="ChannelCategoryPath">ChannelCategoryPath (required).</param>
        /// <param name="ChannelCategoryLevel">ChannelCategoryLevel (required).</param>
        /// <param name="ChannelCategoryDefaultCost">ChannelCategoryDefaultCost.</param>
        /// <param name="ChannelCategoryChannelCode">ChannelCategoryChannelCode.</param>
        /// <param name="ChannelCategoryColumnOverrides">ChannelCategoryColumnOverrides.</param>
        public ChannelCategory(BeezUPCommonChannelCategoryId ChannelCategoryId = default(BeezUPCommonChannelCategoryId), BeezUPCommonChannelCategoryPath ChannelCategoryPath = default(BeezUPCommonChannelCategoryPath), ChannelCategoryLevel ChannelCategoryLevel = default(ChannelCategoryLevel), ChannelCategoryDefaultCost ChannelCategoryDefaultCost = default(ChannelCategoryDefaultCost), ChannelCategoryChannelCode ChannelCategoryChannelCode = default(ChannelCategoryChannelCode), ChannelCategoryColumnOverrides ChannelCategoryColumnOverrides = default(ChannelCategoryColumnOverrides))
        {
            // to ensure "ChannelCategoryId" is required (not null)
            if (ChannelCategoryId == null)
            {
                throw new InvalidDataException("ChannelCategoryId is a required property for ChannelCategory and cannot be null");
            }
            else
            {
                this.ChannelCategoryId = ChannelCategoryId;
            }
            // to ensure "ChannelCategoryPath" is required (not null)
            if (ChannelCategoryPath == null)
            {
                throw new InvalidDataException("ChannelCategoryPath is a required property for ChannelCategory and cannot be null");
            }
            else
            {
                this.ChannelCategoryPath = ChannelCategoryPath;
            }
            // to ensure "ChannelCategoryLevel" is required (not null)
            if (ChannelCategoryLevel == null)
            {
                throw new InvalidDataException("ChannelCategoryLevel is a required property for ChannelCategory and cannot be null");
            }
            else
            {
                this.ChannelCategoryLevel = ChannelCategoryLevel;
            }
            this.ChannelCategoryDefaultCost = ChannelCategoryDefaultCost;
            this.ChannelCategoryChannelCode = ChannelCategoryChannelCode;
            this.ChannelCategoryColumnOverrides = ChannelCategoryColumnOverrides;
        }
        
        /// <summary>
        /// Gets or Sets ChannelCategoryId
        /// </summary>
        [DataMember(Name="channelCategoryId", EmitDefaultValue=false)]
        public BeezUPCommonChannelCategoryId ChannelCategoryId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryPath
        /// </summary>
        [DataMember(Name="channelCategoryPath", EmitDefaultValue=false)]
        public BeezUPCommonChannelCategoryPath ChannelCategoryPath { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryLevel
        /// </summary>
        [DataMember(Name="channelCategoryLevel", EmitDefaultValue=false)]
        public ChannelCategoryLevel ChannelCategoryLevel { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryDefaultCost
        /// </summary>
        [DataMember(Name="channelCategoryDefaultCost", EmitDefaultValue=false)]
        public ChannelCategoryDefaultCost ChannelCategoryDefaultCost { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryChannelCode
        /// </summary>
        [DataMember(Name="channelCategoryChannelCode", EmitDefaultValue=false)]
        public ChannelCategoryChannelCode ChannelCategoryChannelCode { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryColumnOverrides
        /// </summary>
        [DataMember(Name="channelCategoryColumnOverrides", EmitDefaultValue=false)]
        public ChannelCategoryColumnOverrides ChannelCategoryColumnOverrides { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCategory {\n");
            sb.Append("  ChannelCategoryId: ").Append(ChannelCategoryId).Append("\n");
            sb.Append("  ChannelCategoryPath: ").Append(ChannelCategoryPath).Append("\n");
            sb.Append("  ChannelCategoryLevel: ").Append(ChannelCategoryLevel).Append("\n");
            sb.Append("  ChannelCategoryDefaultCost: ").Append(ChannelCategoryDefaultCost).Append("\n");
            sb.Append("  ChannelCategoryChannelCode: ").Append(ChannelCategoryChannelCode).Append("\n");
            sb.Append("  ChannelCategoryColumnOverrides: ").Append(ChannelCategoryColumnOverrides).Append("\n");
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
            return this.Equals(obj as ChannelCategory);
        }

        /// <summary>
        /// Returns true if ChannelCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCategory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelCategoryId == other.ChannelCategoryId ||
                    this.ChannelCategoryId != null &&
                    this.ChannelCategoryId.Equals(other.ChannelCategoryId)
                ) && 
                (
                    this.ChannelCategoryPath == other.ChannelCategoryPath ||
                    this.ChannelCategoryPath != null &&
                    this.ChannelCategoryPath.Equals(other.ChannelCategoryPath)
                ) && 
                (
                    this.ChannelCategoryLevel == other.ChannelCategoryLevel ||
                    this.ChannelCategoryLevel != null &&
                    this.ChannelCategoryLevel.Equals(other.ChannelCategoryLevel)
                ) && 
                (
                    this.ChannelCategoryDefaultCost == other.ChannelCategoryDefaultCost ||
                    this.ChannelCategoryDefaultCost != null &&
                    this.ChannelCategoryDefaultCost.Equals(other.ChannelCategoryDefaultCost)
                ) && 
                (
                    this.ChannelCategoryChannelCode == other.ChannelCategoryChannelCode ||
                    this.ChannelCategoryChannelCode != null &&
                    this.ChannelCategoryChannelCode.Equals(other.ChannelCategoryChannelCode)
                ) && 
                (
                    this.ChannelCategoryColumnOverrides == other.ChannelCategoryColumnOverrides ||
                    this.ChannelCategoryColumnOverrides != null &&
                    this.ChannelCategoryColumnOverrides.Equals(other.ChannelCategoryColumnOverrides)
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
                if (this.ChannelCategoryId != null)
                    hash = hash * 59 + this.ChannelCategoryId.GetHashCode();
                if (this.ChannelCategoryPath != null)
                    hash = hash * 59 + this.ChannelCategoryPath.GetHashCode();
                if (this.ChannelCategoryLevel != null)
                    hash = hash * 59 + this.ChannelCategoryLevel.GetHashCode();
                if (this.ChannelCategoryDefaultCost != null)
                    hash = hash * 59 + this.ChannelCategoryDefaultCost.GetHashCode();
                if (this.ChannelCategoryChannelCode != null)
                    hash = hash * 59 + this.ChannelCategoryChannelCode.GetHashCode();
                if (this.ChannelCategoryColumnOverrides != null)
                    hash = hash * 59 + this.ChannelCategoryColumnOverrides.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
