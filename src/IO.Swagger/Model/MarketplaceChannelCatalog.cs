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
    /// This object indicates you the association between a channel catalog and a marketplace. The account identifier will be automatically defined based on your marketplace merchant identfier.
    /// </summary>
    [DataContract]
    public partial class MarketplaceChannelCatalog :  IEquatable<MarketplaceChannelCatalog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarketplaceChannelCatalog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceChannelCatalog" /> class.
        /// </summary>
        /// <param name="MarketplaceTechnicalCode">MarketplaceTechnicalCode (required).</param>
        /// <param name="MarketplaceBusinessCode">MarketplaceBusinessCode (required).</param>
        /// <param name="MarketplaceMarketPlaceId">The marketplace identifier in the marketplace (required).</param>
        /// <param name="MarketplaceIsoCountryCodeAlpha2">The marketplace country iso code alpha 2 (see http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Decoding_table for more details) (required).</param>
        /// <param name="BeezUPChannelId">BeezUPChannelId (required).</param>
        /// <param name="BeezUPChannelCatalogId">BeezUPChannelCatalogId (required).</param>
        /// <param name="BeezUPStoreId">BeezUPStoreId (required).</param>
        /// <param name="BeezUPStoreName">The store name (required).</param>
        /// <param name="MarketplaceMerchantIdentifiers">The marketplace merchant identifier list.</param>
        /// <param name="MarketplaceAccountId">MarketplaceAccountId.</param>
        /// <param name="LovLinks">LovLinks (required).</param>
        /// <param name="Links">Links (required).</param>
        public MarketplaceChannelCatalog(BeezUPCommonMarketplaceTechnicalCode MarketplaceTechnicalCode = default(BeezUPCommonMarketplaceTechnicalCode), BeezUPCommonMarketplaceBusinessCode MarketplaceBusinessCode = default(BeezUPCommonMarketplaceBusinessCode), string MarketplaceMarketPlaceId = default(string), string MarketplaceIsoCountryCodeAlpha2 = default(string), BeezUPCommonChannelId BeezUPChannelId = default(BeezUPCommonChannelId), BeezUPCommonChannelCatalogId BeezUPChannelCatalogId = default(BeezUPCommonChannelCatalogId), BeezUPCommonStoreId BeezUPStoreId = default(BeezUPCommonStoreId), string BeezUPStoreName = default(string), Dictionary<string, string> MarketplaceMerchantIdentifiers = default(Dictionary<string, string>), BeezUPCommonMarketplaceAccountId MarketplaceAccountId = default(BeezUPCommonMarketplaceAccountId), MarketplaceChannelCatalogLovLinks LovLinks = default(MarketplaceChannelCatalogLovLinks), MarketplaceChannelCatalogLinks Links = default(MarketplaceChannelCatalogLinks))
        {
            // to ensure "MarketplaceTechnicalCode" is required (not null)
            if (MarketplaceTechnicalCode == null)
            {
                throw new InvalidDataException("MarketplaceTechnicalCode is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.MarketplaceTechnicalCode = MarketplaceTechnicalCode;
            }
            // to ensure "MarketplaceBusinessCode" is required (not null)
            if (MarketplaceBusinessCode == null)
            {
                throw new InvalidDataException("MarketplaceBusinessCode is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.MarketplaceBusinessCode = MarketplaceBusinessCode;
            }
            // to ensure "MarketplaceMarketPlaceId" is required (not null)
            if (MarketplaceMarketPlaceId == null)
            {
                throw new InvalidDataException("MarketplaceMarketPlaceId is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.MarketplaceMarketPlaceId = MarketplaceMarketPlaceId;
            }
            // to ensure "MarketplaceIsoCountryCodeAlpha2" is required (not null)
            if (MarketplaceIsoCountryCodeAlpha2 == null)
            {
                throw new InvalidDataException("MarketplaceIsoCountryCodeAlpha2 is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.MarketplaceIsoCountryCodeAlpha2 = MarketplaceIsoCountryCodeAlpha2;
            }
            // to ensure "BeezUPChannelId" is required (not null)
            if (BeezUPChannelId == null)
            {
                throw new InvalidDataException("BeezUPChannelId is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.BeezUPChannelId = BeezUPChannelId;
            }
            // to ensure "BeezUPChannelCatalogId" is required (not null)
            if (BeezUPChannelCatalogId == null)
            {
                throw new InvalidDataException("BeezUPChannelCatalogId is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.BeezUPChannelCatalogId = BeezUPChannelCatalogId;
            }
            // to ensure "BeezUPStoreId" is required (not null)
            if (BeezUPStoreId == null)
            {
                throw new InvalidDataException("BeezUPStoreId is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.BeezUPStoreId = BeezUPStoreId;
            }
            // to ensure "BeezUPStoreName" is required (not null)
            if (BeezUPStoreName == null)
            {
                throw new InvalidDataException("BeezUPStoreName is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.BeezUPStoreName = BeezUPStoreName;
            }
            // to ensure "LovLinks" is required (not null)
            if (LovLinks == null)
            {
                throw new InvalidDataException("LovLinks is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.LovLinks = LovLinks;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for MarketplaceChannelCatalog and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this.MarketplaceMerchantIdentifiers = MarketplaceMerchantIdentifiers;
            this.MarketplaceAccountId = MarketplaceAccountId;
        }
        
        /// <summary>
        /// Gets or Sets MarketplaceTechnicalCode
        /// </summary>
        [DataMember(Name="marketplaceTechnicalCode", EmitDefaultValue=false)]
        public BeezUPCommonMarketplaceTechnicalCode MarketplaceTechnicalCode { get; set; }
        /// <summary>
        /// Gets or Sets MarketplaceBusinessCode
        /// </summary>
        [DataMember(Name="marketplaceBusinessCode", EmitDefaultValue=false)]
        public BeezUPCommonMarketplaceBusinessCode MarketplaceBusinessCode { get; set; }
        /// <summary>
        /// The marketplace identifier in the marketplace
        /// </summary>
        /// <value>The marketplace identifier in the marketplace</value>
        [DataMember(Name="marketplaceMarketPlaceId", EmitDefaultValue=false)]
        public string MarketplaceMarketPlaceId { get; set; }
        /// <summary>
        /// The marketplace country iso code alpha 2 (see http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Decoding_table for more details)
        /// </summary>
        /// <value>The marketplace country iso code alpha 2 (see http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Decoding_table for more details)</value>
        [DataMember(Name="marketplaceIsoCountryCodeAlpha2", EmitDefaultValue=false)]
        public string MarketplaceIsoCountryCodeAlpha2 { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPChannelId
        /// </summary>
        [DataMember(Name="beezUPChannelId", EmitDefaultValue=false)]
        public BeezUPCommonChannelId BeezUPChannelId { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPChannelCatalogId
        /// </summary>
        [DataMember(Name="beezUPChannelCatalogId", EmitDefaultValue=false)]
        public BeezUPCommonChannelCatalogId BeezUPChannelCatalogId { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPStoreId
        /// </summary>
        [DataMember(Name="beezUPStoreId", EmitDefaultValue=false)]
        public BeezUPCommonStoreId BeezUPStoreId { get; set; }
        /// <summary>
        /// The store name
        /// </summary>
        /// <value>The store name</value>
        [DataMember(Name="beezUPStoreName", EmitDefaultValue=false)]
        public string BeezUPStoreName { get; set; }
        /// <summary>
        /// The marketplace merchant identifier list
        /// </summary>
        /// <value>The marketplace merchant identifier list</value>
        [DataMember(Name="marketplaceMerchantIdentifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> MarketplaceMerchantIdentifiers { get; set; }
        /// <summary>
        /// Gets or Sets MarketplaceAccountId
        /// </summary>
        [DataMember(Name="marketplaceAccountId", EmitDefaultValue=false)]
        public BeezUPCommonMarketplaceAccountId MarketplaceAccountId { get; set; }
        /// <summary>
        /// Gets or Sets LovLinks
        /// </summary>
        [DataMember(Name="lovLinks", EmitDefaultValue=false)]
        public MarketplaceChannelCatalogLovLinks LovLinks { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public MarketplaceChannelCatalogLinks Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceChannelCatalog {\n");
            sb.Append("  MarketplaceTechnicalCode: ").Append(MarketplaceTechnicalCode).Append("\n");
            sb.Append("  MarketplaceBusinessCode: ").Append(MarketplaceBusinessCode).Append("\n");
            sb.Append("  MarketplaceMarketPlaceId: ").Append(MarketplaceMarketPlaceId).Append("\n");
            sb.Append("  MarketplaceIsoCountryCodeAlpha2: ").Append(MarketplaceIsoCountryCodeAlpha2).Append("\n");
            sb.Append("  BeezUPChannelId: ").Append(BeezUPChannelId).Append("\n");
            sb.Append("  BeezUPChannelCatalogId: ").Append(BeezUPChannelCatalogId).Append("\n");
            sb.Append("  BeezUPStoreId: ").Append(BeezUPStoreId).Append("\n");
            sb.Append("  BeezUPStoreName: ").Append(BeezUPStoreName).Append("\n");
            sb.Append("  MarketplaceMerchantIdentifiers: ").Append(MarketplaceMerchantIdentifiers).Append("\n");
            sb.Append("  MarketplaceAccountId: ").Append(MarketplaceAccountId).Append("\n");
            sb.Append("  LovLinks: ").Append(LovLinks).Append("\n");
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
            return this.Equals(obj as MarketplaceChannelCatalog);
        }

        /// <summary>
        /// Returns true if MarketplaceChannelCatalog instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketplaceChannelCatalog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceChannelCatalog other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MarketplaceTechnicalCode == other.MarketplaceTechnicalCode ||
                    this.MarketplaceTechnicalCode != null &&
                    this.MarketplaceTechnicalCode.Equals(other.MarketplaceTechnicalCode)
                ) && 
                (
                    this.MarketplaceBusinessCode == other.MarketplaceBusinessCode ||
                    this.MarketplaceBusinessCode != null &&
                    this.MarketplaceBusinessCode.Equals(other.MarketplaceBusinessCode)
                ) && 
                (
                    this.MarketplaceMarketPlaceId == other.MarketplaceMarketPlaceId ||
                    this.MarketplaceMarketPlaceId != null &&
                    this.MarketplaceMarketPlaceId.Equals(other.MarketplaceMarketPlaceId)
                ) && 
                (
                    this.MarketplaceIsoCountryCodeAlpha2 == other.MarketplaceIsoCountryCodeAlpha2 ||
                    this.MarketplaceIsoCountryCodeAlpha2 != null &&
                    this.MarketplaceIsoCountryCodeAlpha2.Equals(other.MarketplaceIsoCountryCodeAlpha2)
                ) && 
                (
                    this.BeezUPChannelId == other.BeezUPChannelId ||
                    this.BeezUPChannelId != null &&
                    this.BeezUPChannelId.Equals(other.BeezUPChannelId)
                ) && 
                (
                    this.BeezUPChannelCatalogId == other.BeezUPChannelCatalogId ||
                    this.BeezUPChannelCatalogId != null &&
                    this.BeezUPChannelCatalogId.Equals(other.BeezUPChannelCatalogId)
                ) && 
                (
                    this.BeezUPStoreId == other.BeezUPStoreId ||
                    this.BeezUPStoreId != null &&
                    this.BeezUPStoreId.Equals(other.BeezUPStoreId)
                ) && 
                (
                    this.BeezUPStoreName == other.BeezUPStoreName ||
                    this.BeezUPStoreName != null &&
                    this.BeezUPStoreName.Equals(other.BeezUPStoreName)
                ) && 
                (
                    this.MarketplaceMerchantIdentifiers == other.MarketplaceMerchantIdentifiers ||
                    this.MarketplaceMerchantIdentifiers != null &&
                    this.MarketplaceMerchantIdentifiers.SequenceEqual(other.MarketplaceMerchantIdentifiers)
                ) && 
                (
                    this.MarketplaceAccountId == other.MarketplaceAccountId ||
                    this.MarketplaceAccountId != null &&
                    this.MarketplaceAccountId.Equals(other.MarketplaceAccountId)
                ) && 
                (
                    this.LovLinks == other.LovLinks ||
                    this.LovLinks != null &&
                    this.LovLinks.Equals(other.LovLinks)
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
                if (this.MarketplaceTechnicalCode != null)
                    hash = hash * 59 + this.MarketplaceTechnicalCode.GetHashCode();
                if (this.MarketplaceBusinessCode != null)
                    hash = hash * 59 + this.MarketplaceBusinessCode.GetHashCode();
                if (this.MarketplaceMarketPlaceId != null)
                    hash = hash * 59 + this.MarketplaceMarketPlaceId.GetHashCode();
                if (this.MarketplaceIsoCountryCodeAlpha2 != null)
                    hash = hash * 59 + this.MarketplaceIsoCountryCodeAlpha2.GetHashCode();
                if (this.BeezUPChannelId != null)
                    hash = hash * 59 + this.BeezUPChannelId.GetHashCode();
                if (this.BeezUPChannelCatalogId != null)
                    hash = hash * 59 + this.BeezUPChannelCatalogId.GetHashCode();
                if (this.BeezUPStoreId != null)
                    hash = hash * 59 + this.BeezUPStoreId.GetHashCode();
                if (this.BeezUPStoreName != null)
                    hash = hash * 59 + this.BeezUPStoreName.GetHashCode();
                if (this.MarketplaceMerchantIdentifiers != null)
                    hash = hash * 59 + this.MarketplaceMerchantIdentifiers.GetHashCode();
                if (this.MarketplaceAccountId != null)
                    hash = hash * 59 + this.MarketplaceAccountId.GetHashCode();
                if (this.LovLinks != null)
                    hash = hash * 59 + this.LovLinks.GetHashCode();
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
