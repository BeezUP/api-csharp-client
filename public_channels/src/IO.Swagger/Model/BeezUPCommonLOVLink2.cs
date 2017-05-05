/* 
 * Public - Channels
 *
 * This api allows you to get access to the channels. The main use case is our public commercial web site.
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
    /// Describe the way you have to follow to get access to the LOV
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonLOVLink2 :  IEquatable<BeezUPCommonLOVLink2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLOVLink2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonLOVLink2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonLOVLink2" /> class.
        /// </summary>
        /// <param name="Rel">Indicate the relation name related to the link.</param>
        /// <param name="Href">Indicate the relative uri pattern to the list of value (default to &quot;/v2/user/{listName}&quot;).</param>
        /// <param name="ListName">The name of the list of value (required).</param>
        public BeezUPCommonLOVLink2(string Rel = default(string), string Href = "/v2/user/{listName}", string ListName = default(string))
        {
            // to ensure "ListName" is required (not null)
            if (ListName == null)
            {
                throw new InvalidDataException("ListName is a required property for BeezUPCommonLOVLink2 and cannot be null");
            }
            else
            {
                this.ListName = ListName;
            }
            this.Rel = Rel;
            // use default value if no "Href" provided
            if (Href == null)
            {
                this.Href = "/v2/user/{listName}";
            }
            else
            {
                this.Href = Href;
            }
        }
        
        /// <summary>
        /// Indicate the relation name related to the link
        /// </summary>
        /// <value>Indicate the relation name related to the link</value>
        [DataMember(Name="rel", EmitDefaultValue=false)]
        public string Rel { get; set; }
        /// <summary>
        /// Indicate the relative uri pattern to the list of value
        /// </summary>
        /// <value>Indicate the relative uri pattern to the list of value</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }
        /// <summary>
        /// The name of the list of value
        /// </summary>
        /// <value>The name of the list of value</value>
        [DataMember(Name="listName", EmitDefaultValue=false)]
        public string ListName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonLOVLink2 {\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
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
            return this.Equals(obj as BeezUPCommonLOVLink2);
        }

        /// <summary>
        /// Returns true if BeezUPCommonLOVLink2 instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonLOVLink2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonLOVLink2 other)
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
                    this.ListName == other.ListName ||
                    this.ListName != null &&
                    this.ListName.Equals(other.ListName)
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
                if (this.ListName != null)
                    hash = hash * 59 + this.ListName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
