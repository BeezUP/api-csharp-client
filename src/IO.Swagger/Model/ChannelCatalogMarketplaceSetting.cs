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
    /// Model for fetching a channel catalog marketplace setting
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogMarketplaceSetting :  IEquatable<ChannelCatalogMarketplaceSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogMarketplaceSetting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogMarketplaceSetting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogMarketplaceSetting" /> class.
        /// </summary>
        /// <param name="Name">Channel catalog marketplace property name (required).</param>
        /// <param name="Values">Channel catalog marketplace property values.</param>
        public ChannelCatalogMarketplaceSetting(string Name = default(string), List<string> Values = default(List<string>))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ChannelCatalogMarketplaceSetting and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Values = Values;
        }
        
        /// <summary>
        /// Channel catalog marketplace property name
        /// </summary>
        /// <value>Channel catalog marketplace property name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Channel catalog marketplace property values
        /// </summary>
        /// <value>Channel catalog marketplace property values</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogMarketplaceSetting {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as ChannelCatalogMarketplaceSetting);
        }

        /// <summary>
        /// Returns true if ChannelCatalogMarketplaceSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogMarketplaceSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogMarketplaceSetting other)
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
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
