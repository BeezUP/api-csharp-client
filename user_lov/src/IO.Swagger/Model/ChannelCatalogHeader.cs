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
    /// ChannelCatalogHeader
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogHeader :  IEquatable<ChannelCatalogHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogHeader" /> class.
        /// </summary>
        /// <param name="ChannelCatalogId">ChannelCatalogId.</param>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="ChannelName">ChannelName.</param>
        /// <param name="IsMarketplace">Indicates if this channel catalog is related to a marketplace.</param>
        /// <param name="StoreId">StoreId.</param>
        /// <param name="Links">Links.</param>
        public ChannelCatalogHeader(BeezUPCommonChannelCatalogId ChannelCatalogId = default(BeezUPCommonChannelCatalogId), BeezUPCommonChannelId ChannelId = default(BeezUPCommonChannelId), BeezUPCommonChannelName ChannelName = default(BeezUPCommonChannelName), bool? IsMarketplace = default(bool?), BeezUPCommonStoreId StoreId = default(BeezUPCommonStoreId), ChannelCatalogHeaderLinks Links = default(ChannelCatalogHeaderLinks))
        {
            this.ChannelCatalogId = ChannelCatalogId;
            this.ChannelId = ChannelId;
            this.ChannelName = ChannelName;
            this.IsMarketplace = IsMarketplace;
            this.StoreId = StoreId;
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets ChannelCatalogId
        /// </summary>
        [DataMember(Name="channelCatalogId", EmitDefaultValue=false)]
        public BeezUPCommonChannelCatalogId ChannelCatalogId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public BeezUPCommonChannelId ChannelId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelName
        /// </summary>
        [DataMember(Name="channelName", EmitDefaultValue=false)]
        public BeezUPCommonChannelName ChannelName { get; set; }
        /// <summary>
        /// Indicates if this channel catalog is related to a marketplace
        /// </summary>
        /// <value>Indicates if this channel catalog is related to a marketplace</value>
        [DataMember(Name="isMarketplace", EmitDefaultValue=false)]
        public bool? IsMarketplace { get; set; }
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public BeezUPCommonStoreId StoreId { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ChannelCatalogHeaderLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogHeader {\n");
            sb.Append("  ChannelCatalogId: ").Append(ChannelCatalogId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  IsMarketplace: ").Append(IsMarketplace).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as ChannelCatalogHeader);
        }

        /// <summary>
        /// Returns true if ChannelCatalogHeader instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogHeader other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelCatalogId == other.ChannelCatalogId ||
                    this.ChannelCatalogId != null &&
                    this.ChannelCatalogId.Equals(other.ChannelCatalogId)
                ) && 
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) && 
                (
                    this.ChannelName == other.ChannelName ||
                    this.ChannelName != null &&
                    this.ChannelName.Equals(other.ChannelName)
                ) && 
                (
                    this.IsMarketplace == other.IsMarketplace ||
                    this.IsMarketplace != null &&
                    this.IsMarketplace.Equals(other.IsMarketplace)
                ) && 
                (
                    this.StoreId == other.StoreId ||
                    this.StoreId != null &&
                    this.StoreId.Equals(other.StoreId)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.ChannelCatalogId != null)
                    hash = hash * 59 + this.ChannelCatalogId.GetHashCode();
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();
                if (this.ChannelName != null)
                    hash = hash * 59 + this.ChannelName.GetHashCode();
                if (this.IsMarketplace != null)
                    hash = hash * 59 + this.IsMarketplace.GetHashCode();
                if (this.StoreId != null)
                    hash = hash * 59 + this.StoreId.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}