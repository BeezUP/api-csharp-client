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
    /// BeezUPCommonLinkParameter3
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonLinkParameter3 :  IEquatable<BeezUPCommonLinkParameter3>, IValidatableObject
    {
        /// <summary>
        /// * path: if the parameter must be pass in the path uri * header: if the parameter must be passed in http header * query: if the parameter must be passed in querystring * body: if the paramter must be passed in the body 
        /// </summary>
        /// <value>* path: if the parameter must be pass in the path uri * header: if the parameter must be passed in http header * query: if the parameter must be passed in querystring * body: if the paramter must be passed in the body </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InEnum
        {
            
            /// <summary>
            /// Enum Path for "path"
            /// </summary>
            [EnumMember(Value = "path")]
            Path,
            
            /// <summary>
            /// Enum Header for "header"
            /// </summary>
            [EnumMember(Value = "header")]
            Header,
            
            /// <summary>
            /// Enum Query for "query"
            /// </summary>
            [EnumMember(Value = "query")]
            Query,
            
            /// <summary>
            /// Enum Body for "body"
            /// </summary>
            [EnumMember(Value = "body")]
            Body
        }

        /// <summary>
        /// The value type of the parameter
        /// </summary>
        /// <value>The value type of the parameter</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Integer for "integer"
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer,
            
            /// <summary>
            /// Enum Number for "number"
            /// </summary>
            [EnumMember(Value = "number")]
            Number,
            
            /// <summary>
            /// Enum Boolean for "boolean"
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean,
            
            /// <summary>
            /// Enum Object for "object"
            /// </summary>
            [EnumMember(Value = "object")]
            Object,
            
            /// <summary>
            /// Enum Array for "array"
            /// </summary>
            [EnumMember(Value = "array")]
            Array,
            
            /// <summary>
            /// Enum Date for "date"
            /// </summary>
            [EnumMember(Value = "date")]
            Date,
            
            /// <summary>
            /// Enum Datetime for "date-time"
            /// </summary>
            [EnumMember(Value = "date-time")]
            Datetime
        }

        /// <summary>
        /// * path: if the parameter must be pass in the path uri * header: if the parameter must be passed in http header * query: if the parameter must be passed in querystring * body: if the paramter must be passed in the body 
        /// </summary>
        /// <value>* path: if the parameter must be pass in the path uri * header: if the parameter must be passed in http header * query: if the parameter must be passed in querystring * body: if the paramter must be passed in the body </value>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public InEnum? _In { get; set; }
        /// <summary>
        /// The value type of the parameter
        /// </summary>
        /// <value>The value type of the parameter</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLinkParameter3" /> class.
        /// </summary>
        /// <param name="Value">The value of the parameter. It can be an integer a string or an object..</param>
        /// <param name="Required">Required.</param>
        /// <param name="_In">* path: if the parameter must be pass in the path uri * header: if the parameter must be passed in http header * query: if the parameter must be passed in querystring * body: if the paramter must be passed in the body .</param>
        /// <param name="Type">The value type of the parameter.</param>
        /// <param name="LovLink">This parameter expect the values indicated in this list of values..</param>
        /// <param name="LovRequired">If true, you MUST use indicate a value from the list of values otherwise it&#39;s a freetext.</param>
        /// <param name="Description">description of the parameter.</param>
        /// <param name="Schema">schema of the parameter.</param>
        public BeezUPCommonLinkParameter3(Object Value = default(Object), bool? Required = default(bool?), InEnum? _In = default(InEnum?), TypeEnum? Type = default(TypeEnum?), BeezUPCommonLOVLink2 LovLink = default(BeezUPCommonLOVLink2), bool? LovRequired = default(bool?), string Description = default(string), string Schema = default(string))
        {
            this.Value = Value;
            this.Required = Required;
            this._In = _In;
            this.Type = Type;
            this.LovLink = LovLink;
            this.LovRequired = LovRequired;
            this.Description = Description;
            this.Schema = Schema;
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
        /// This parameter expect the values indicated in this list of values.
        /// </summary>
        /// <value>This parameter expect the values indicated in this list of values.</value>
        [DataMember(Name="lovLink", EmitDefaultValue=false)]
        public BeezUPCommonLOVLink2 LovLink { get; set; }
        /// <summary>
        /// If true, you MUST use indicate a value from the list of values otherwise it&#39;s a freetext
        /// </summary>
        /// <value>If true, you MUST use indicate a value from the list of values otherwise it&#39;s a freetext</value>
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
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
