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
    /// StoreAlert
    /// </summary>
    [DataContract]
    public partial class StoreAlert :  IEquatable<StoreAlert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAlert" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoreAlert() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAlert" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="AlertId">AlertId (required).</param>
        /// <param name="AlertName">AlertName (required).</param>
        /// <param name="Active">Active (required).</param>
        /// <param name="Properties">The current configuration properties of the alert.</param>
        public StoreAlert(StoreAlertLinks Links = default(StoreAlertLinks), AlertId AlertId = default(AlertId), AlertName AlertName = default(AlertName), AlertIsActive Active = default(AlertIsActive), List<StoreAlertPropertyInfo> Properties = default(List<StoreAlertPropertyInfo>))
        {
            // to ensure "AlertId" is required (not null)
            if (AlertId == null)
            {
                throw new InvalidDataException("AlertId is a required property for StoreAlert and cannot be null");
            }
            else
            {
                this.AlertId = AlertId;
            }
            // to ensure "AlertName" is required (not null)
            if (AlertName == null)
            {
                throw new InvalidDataException("AlertName is a required property for StoreAlert and cannot be null");
            }
            else
            {
                this.AlertName = AlertName;
            }
            // to ensure "Active" is required (not null)
            if (Active == null)
            {
                throw new InvalidDataException("Active is a required property for StoreAlert and cannot be null");
            }
            else
            {
                this.Active = Active;
            }
            this.Links = Links;
            this.Properties = Properties;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public StoreAlertLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets AlertId
        /// </summary>
        [DataMember(Name="alertId", EmitDefaultValue=false)]
        public AlertId AlertId { get; set; }
        /// <summary>
        /// Gets or Sets AlertName
        /// </summary>
        [DataMember(Name="alertName", EmitDefaultValue=false)]
        public AlertName AlertName { get; set; }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public AlertIsActive Active { get; set; }
        /// <summary>
        /// The current configuration properties of the alert
        /// </summary>
        /// <value>The current configuration properties of the alert</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<StoreAlertPropertyInfo> Properties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreAlert {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  AlertId: ").Append(AlertId).Append("\n");
            sb.Append("  AlertName: ").Append(AlertName).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(obj as StoreAlert);
        }

        /// <summary>
        /// Returns true if StoreAlert instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreAlert other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.AlertId == other.AlertId ||
                    this.AlertId != null &&
                    this.AlertId.Equals(other.AlertId)
                ) && 
                (
                    this.AlertName == other.AlertName ||
                    this.AlertName != null &&
                    this.AlertName.Equals(other.AlertName)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.AlertId != null)
                    hash = hash * 59 + this.AlertId.GetHashCode();
                if (this.AlertName != null)
                    hash = hash * 59 + this.AlertName.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
