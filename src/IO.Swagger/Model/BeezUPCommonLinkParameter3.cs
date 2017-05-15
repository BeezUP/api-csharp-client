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
    /// BeezUPCommonLinkParameter3
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonLinkParameter3 :  IEquatable<BeezUPCommonLinkParameter3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLinkParameter3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonLinkParameter3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLinkParameter3" /> class.
        /// </summary>
        /// <param name="Value">The value of the parameter. It can be an integer a string or an object..</param>
        /// <param name="Required">Required (default to false).</param>
        /// <param name="_In">_In (required).</param>
        /// <param name="Type">Type.</param>
        /// <param name="LovLink">LovLink.</param>
        /// <param name="LovRequired">If true, you MUST indicate a value from the list of values otherwise it&#39;s a freetext.</param>
        /// <param name="Description">description of the parameter.</param>
        /// <param name="Schema">schema of the parameter.</param>
        /// <param name="Properties">If the parameter is an object with flexible properties (additionProperties/dictionary), we will describe the properties of the object..</param>
        public BeezUPCommonLinkParameter3(Object Value = default(Object), bool? Required = false, BeezUPCommonParameterIn _In = default(BeezUPCommonParameterIn), BeezUPCommonParameterType Type = default(BeezUPCommonParameterType), BeezUPCommonLOVLink3 LovLink = default(BeezUPCommonLOVLink3), bool? LovRequired = default(bool?), string Description = default(string), string Schema = default(string), Dictionary<string, BeezUPCommonLinkParameterProperty3> Properties = default(Dictionary<string, BeezUPCommonLinkParameterProperty3>))
        {
            // to ensure "_In" is required (not null)
            if (_In == null)
            {
                throw new InvalidDataException("_In is a required property for BeezUPCommonLinkParameter3 and cannot be null");
            }
            else
            {
                this._In = _In;
            }
            this.Value = Value;
            // use default value if no "Required" provided
            if (Required == null)
            {
                this.Required = false;
            }
            else
            {
                this.Required = Required;
            }
            this.Type = Type;
            this.LovLink = LovLink;
            this.LovRequired = LovRequired;
            this.Description = Description;
            this.Schema = Schema;
            this.Properties = Properties;
        }
        
        /// <summary>
        /// The value of the parameter. It can be an integer a string or an object.
        /// </summary>
        /// <value>The value of the parameter. It can be an integer a string or an object.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }
        /// <summary>
        /// Gets or Sets _In
        /// </summary>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public BeezUPCommonParameterIn _In { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public BeezUPCommonParameterType Type { get; set; }
        /// <summary>
        /// Gets or Sets LovLink
        /// </summary>
        [DataMember(Name="lovLink", EmitDefaultValue=false)]
        public BeezUPCommonLOVLink3 LovLink { get; set; }
        /// <summary>
        /// If true, you MUST indicate a value from the list of values otherwise it&#39;s a freetext
        /// </summary>
        /// <value>If true, you MUST indicate a value from the list of values otherwise it&#39;s a freetext</value>
        [DataMember(Name="lovRequired", EmitDefaultValue=false)]
        public bool? LovRequired { get; set; }
        /// <summary>
        /// description of the parameter
        /// </summary>
        /// <value>description of the parameter</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// schema of the parameter
        /// </summary>
        /// <value>schema of the parameter</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public string Schema { get; set; }
        /// <summary>
        /// If the parameter is an object with flexible properties (additionProperties/dictionary), we will describe the properties of the object.
        /// </summary>
        /// <value>If the parameter is an object with flexible properties (additionProperties/dictionary), we will describe the properties of the object.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, BeezUPCommonLinkParameterProperty3> Properties { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonLinkParameter3 {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  _In: ").Append(_In).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LovLink: ").Append(LovLink).Append("\n");
            sb.Append("  LovRequired: ").Append(LovRequired).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(obj as BeezUPCommonLinkParameter3);
        }

        /// <summary>
        /// Returns true if BeezUPCommonLinkParameter3 instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonLinkParameter3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonLinkParameter3 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this._In == other._In ||
                    this._In != null &&
                    this._In.Equals(other._In)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.LovLink == other.LovLink ||
                    this.LovLink != null &&
                    this.LovLink.Equals(other.LovLink)
                ) && 
                (
                    this.LovRequired == other.LovRequired ||
                    this.LovRequired != null &&
                    this.LovRequired.Equals(other.LovRequired)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this._In != null)
                    hash = hash * 59 + this._In.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.LovLink != null)
                    hash = hash * 59 + this.LovLink.GetHashCode();
                if (this.LovRequired != null)
                    hash = hash * 59 + this.LovRequired.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
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
