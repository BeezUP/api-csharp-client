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
    /// The marketplace channel catalog list
    /// </summary>
    [DataContract]
    public partial class MarketplaceChannelCatalogList :  IEquatable<MarketplaceChannelCatalogList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalogList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarketplaceChannelCatalogList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalogList" /> class.
        /// </summary>
        /// <param name="Links">Links (required).</param>
        /// <param name="MarketplaceChannelCatalogs">The list of marketplace channel catalog (required).</param>
        public MarketplaceChannelCatalogList(MarketplaceChannelCatalogListLinks Links = default(MarketplaceChannelCatalogListLinks), List<MarketplaceChannelCatalog> MarketplaceChannelCatalogs = default(List<MarketplaceChannelCatalog>))
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for MarketplaceChannelCatalogList and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            // to ensure "MarketplaceChannelCatalogs" is required (not null)
            if (MarketplaceChannelCatalogs == null)
            {
                throw new InvalidDataException("MarketplaceChannelCatalogs is a required property for MarketplaceChannelCatalogList and cannot be null");
            }
            else
            {
                this.MarketplaceChannelCatalogs = MarketplaceChannelCatalogs;
            }
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public MarketplaceChannelCatalogListLinks Links { get; set; }
        /// <summary>
        /// The list of marketplace channel catalog
        /// </summary>
        /// <value>The list of marketplace channel catalog</value>
        [DataMember(Name="marketplaceChannelCatalogs", EmitDefaultValue=false)]
        public List<MarketplaceChannelCatalog> MarketplaceChannelCatalogs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceChannelCatalogList {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  MarketplaceChannelCatalogs: ").Append(MarketplaceChannelCatalogs).Append("\n");
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
            return this.Equals(obj as MarketplaceChannelCatalogList);
        }

        /// <summary>
        /// Returns true if MarketplaceChannelCatalogList instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketplaceChannelCatalogList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceChannelCatalogList other)
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
                    this.MarketplaceChannelCatalogs == other.MarketplaceChannelCatalogs ||
                    this.MarketplaceChannelCatalogs != null &&
                    this.MarketplaceChannelCatalogs.SequenceEqual(other.MarketplaceChannelCatalogs)
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
                if (this.MarketplaceChannelCatalogs != null)
                    hash = hash * 59 + this.MarketplaceChannelCatalogs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
