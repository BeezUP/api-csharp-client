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
    /// StoreAlertPropertyInfo
    /// </summary>
    [DataContract]
    public partial class StoreAlertPropertyInfo :  IEquatable<StoreAlertPropertyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAlertPropertyInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoreAlertPropertyInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAlertPropertyInfo" /> class.
        /// </summary>
        /// <param name="PropertyId">PropertyId (required).</param>
        /// <param name="PropertyValue">PropertyValue (required).</param>
        /// <param name="PropertyName">The property name of the alert (required).</param>
        /// <param name="PropertyValidationExpression">The regular expression related to the alert property.</param>
        public StoreAlertPropertyInfo(AlertPropertyId PropertyId = default(AlertPropertyId), AlertPropertyValue PropertyValue = default(AlertPropertyValue), string PropertyName = default(string), string PropertyValidationExpression = default(string))
        {
            // to ensure "PropertyId" is required (not null)
            if (PropertyId == null)
            {
                throw new InvalidDataException("PropertyId is a required property for StoreAlertPropertyInfo and cannot be null");
            }
            else
            {
                this.PropertyId = PropertyId;
            }
            // to ensure "PropertyValue" is required (not null)
            if (PropertyValue == null)
            {
                throw new InvalidDataException("PropertyValue is a required property for StoreAlertPropertyInfo and cannot be null");
            }
            else
            {
                this.PropertyValue = PropertyValue;
            }
            // to ensure "PropertyName" is required (not null)
            if (PropertyName == null)
            {
                throw new InvalidDataException("PropertyName is a required property for StoreAlertPropertyInfo and cannot be null");
            }
            else
            {
                this.PropertyName = PropertyName;
            }
            this.PropertyValidationExpression = PropertyValidationExpression;
        }
        
        /// <summary>
        /// Gets or Sets PropertyId
        /// </summary>
        [DataMember(Name="propertyId", EmitDefaultValue=false)]
        public AlertPropertyId PropertyId { get; set; }
        /// <summary>
        /// Gets or Sets PropertyValue
        /// </summary>
        [DataMember(Name="propertyValue", EmitDefaultValue=false)]
        public AlertPropertyValue PropertyValue { get; set; }
        /// <summary>
        /// The property name of the alert
        /// </summary>
        /// <value>The property name of the alert</value>
        [DataMember(Name="propertyName", EmitDefaultValue=false)]
        public string PropertyName { get; set; }
        /// <summary>
        /// The regular expression related to the alert property
        /// </summary>
        /// <value>The regular expression related to the alert property</value>
        [DataMember(Name="propertyValidationExpression", EmitDefaultValue=false)]
        public string PropertyValidationExpression { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreAlertPropertyInfo {\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  PropertyValidationExpression: ").Append(PropertyValidationExpression).Append("\n");
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
            return this.Equals(obj as StoreAlertPropertyInfo);
        }

        /// <summary>
        /// Returns true if StoreAlertPropertyInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreAlertPropertyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreAlertPropertyInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PropertyId == other.PropertyId ||
                    this.PropertyId != null &&
                    this.PropertyId.Equals(other.PropertyId)
                ) && 
                (
                    this.PropertyValue == other.PropertyValue ||
                    this.PropertyValue != null &&
                    this.PropertyValue.Equals(other.PropertyValue)
                ) && 
                (
                    this.PropertyName == other.PropertyName ||
                    this.PropertyName != null &&
                    this.PropertyName.Equals(other.PropertyName)
                ) && 
                (
                    this.PropertyValidationExpression == other.PropertyValidationExpression ||
                    this.PropertyValidationExpression != null &&
                    this.PropertyValidationExpression.Equals(other.PropertyValidationExpression)
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
                if (this.PropertyId != null)
                    hash = hash * 59 + this.PropertyId.GetHashCode();
                if (this.PropertyValue != null)
                    hash = hash * 59 + this.PropertyValue.GetHashCode();
                if (this.PropertyName != null)
                    hash = hash * 59 + this.PropertyName.GetHashCode();
                if (this.PropertyValidationExpression != null)
                    hash = hash * 59 + this.PropertyValidationExpression.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}