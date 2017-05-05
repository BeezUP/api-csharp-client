/* 
 * Catalogs
 *
 * This API allows you to manage your catalogs
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
    /// BeezUPCommonLink2
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonLink2 :  IEquatable<BeezUPCommonLink2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLink2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonLink2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLink2" /> class.
        /// </summary>
        /// <param name="Rel">Indicate the relation name related to the link (required).</param>
        /// <param name="Href">Href.</param>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="Method">Method.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Info">Info.</param>
        public BeezUPCommonLink2(string Rel = default(string), BeezUPCommonHref Href = default(BeezUPCommonHref), BeezUPCommonOperationId OperationId = default(BeezUPCommonOperationId), BeezUPCommonHttpMethod Method = default(BeezUPCommonHttpMethod), List<BeezUPCommonLinkParameter2> Parameters = default(List<BeezUPCommonLinkParameter2>), BeezUPCommonInfoSummaries Info = default(BeezUPCommonInfoSummaries))
        {
            // to ensure "Rel" is required (not null)
            if (Rel == null)
            {
                throw new InvalidDataException("Rel is a required property for BeezUPCommonLink2 and cannot be null");
            }
            else
            {
                this.Rel = Rel;
            }
            this.Href = Href;
            this.OperationId = OperationId;
            this.Method = Method;
            this.Parameters = Parameters;
            this.Info = Info;
        }
        
        /// <summary>
        /// Indicate the relation name related to the link
        /// </summary>
        /// <value>Indicate the relation name related to the link</value>
        [DataMember(Name="rel", EmitDefaultValue=false)]
        public string Rel { get; set; }
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public BeezUPCommonHref Href { get; set; }
        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public BeezUPCommonOperationId OperationId { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public BeezUPCommonHttpMethod Method { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<BeezUPCommonLinkParameter2> Parameters { get; set; }
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public BeezUPCommonInfoSummaries Info { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonLink2 {\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
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
            return this.Equals(obj as BeezUPCommonLink2);
        }

        /// <summary>
        /// Returns true if BeezUPCommonLink2 instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonLink2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonLink2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rel == other.Rel ||
                    this.Rel != null &&
                    this.Rel.Equals(other.Rel)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
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
                if (this.Rel != null)
                    hash = hash * 59 + this.Rel.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}