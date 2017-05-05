/* 
 * Channel Catalogs
 *
 * This api allows you to manage your channel catalogs.   A channel catalog is an association between your store and a channel.  You will be able to: - map your catalog colums to channel columns. - map your catalog categories to the channel categories and define a cost of this category - configure the general and cost settings of the channel - enable or disable a channel - exclude products using filters for a channel - override product values for a channel - disable or reenable a product on a channel 
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
    /// CreateChannelCatalogRequest
    /// </summary>
    [DataContract]
    public partial class CreateChannelCatalogRequest :  IEquatable<CreateChannelCatalogRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelCatalogRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateChannelCatalogRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelCatalogRequest" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId (required).</param>
        /// <param name="StoreId">StoreId (required).</param>
        public CreateChannelCatalogRequest(BeezUPCommonChannelId ChannelId = default(BeezUPCommonChannelId), BeezUPCommonStoreId StoreId = default(BeezUPCommonStoreId))
        {
            // to ensure "ChannelId" is required (not null)
            if (ChannelId == null)
            {
                throw new InvalidDataException("ChannelId is a required property for CreateChannelCatalogRequest and cannot be null");
            }
            else
            {
                this.ChannelId = ChannelId;
            }
            // to ensure "StoreId" is required (not null)
            if (StoreId == null)
            {
                throw new InvalidDataException("StoreId is a required property for CreateChannelCatalogRequest and cannot be null");
            }
            else
            {
                this.StoreId = StoreId;
            }
        }
        
        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public BeezUPCommonChannelId ChannelId { get; set; }
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public BeezUPCommonStoreId StoreId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChannelCatalogRequest {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
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
            return this.Equals(obj as CreateChannelCatalogRequest);
        }

        /// <summary>
        /// Returns true if CreateChannelCatalogRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateChannelCatalogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChannelCatalogRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) && 
                (
                    this.StoreId == other.StoreId ||
                    this.StoreId != null &&
                    this.StoreId.Equals(other.StoreId)
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
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();
                if (this.StoreId != null)
                    hash = hash * 59 + this.StoreId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}