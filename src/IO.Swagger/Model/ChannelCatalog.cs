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
    /// ChannelCatalog
    /// </summary>
    [DataContract]
    public partial class ChannelCatalog :  IEquatable<ChannelCatalog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalog" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId (required).</param>
        /// <param name="ChannelName">ChannelName (required).</param>
        /// <param name="ChannelImageUrl">ChannelImageUrl (required).</param>
        /// <param name="ProductCount">The product count exported considering category mapping. Not all filters have been applied. (required).</param>
        /// <param name="Enabled">Indicates if the channel catalog is active (required).</param>
        /// <param name="IsMarketplace">Indicates if this channel catalog is related to a marketplace (required).</param>
        /// <param name="ChannelCatalogId">ChannelCatalogId (required).</param>
        /// <param name="StoreId">StoreId (required).</param>
        /// <param name="GeneralSettings">GeneralSettings (required).</param>
        /// <param name="CostSettings">CostSettings (required).</param>
        /// <param name="ColumnMappings">ColumnMappings.</param>
        /// <param name="ExclusionFilters">ExclusionFilters.</param>
        /// <param name="ExportUrl">ExportUrl.</param>
        /// <param name="State">State (required).</param>
        /// <param name="Types">The channel type list related to the channel (required).</param>
        /// <param name="Links">Indicates the actions you can do on a channel catalog (required).</param>
        public ChannelCatalog(BeezUPCommonChannelId ChannelId = default(BeezUPCommonChannelId), BeezUPCommonChannelName ChannelName = default(BeezUPCommonChannelName), BeezUPCommonHttpUrl ChannelImageUrl = default(BeezUPCommonHttpUrl), int? ProductCount = default(int?), bool? Enabled = default(bool?), bool? IsMarketplace = default(bool?), BeezUPCommonChannelCatalogId ChannelCatalogId = default(BeezUPCommonChannelCatalogId), BeezUPCommonStoreId StoreId = default(BeezUPCommonStoreId), GeneralSettings GeneralSettings = default(GeneralSettings), CostSettings CostSettings = default(CostSettings), ColumnMappingWithNameList ColumnMappings = default(ColumnMappingWithNameList), ExclusionFilters ExclusionFilters = default(ExclusionFilters), BeezUPCommonHttpUrl ExportUrl = default(BeezUPCommonHttpUrl), ChannelCatalogState State = default(ChannelCatalogState), List<string> Types = default(List<string>), List<BeezUPCommonLink2> Links = default(List<BeezUPCommonLink2>))
        {
            // to ensure "ChannelId" is required (not null)
            if (ChannelId == null)
            {
                throw new InvalidDataException("ChannelId is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.ChannelId = ChannelId;
            }
            // to ensure "ChannelName" is required (not null)
            if (ChannelName == null)
            {
                throw new InvalidDataException("ChannelName is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.ChannelName = ChannelName;
            }
            // to ensure "ChannelImageUrl" is required (not null)
            if (ChannelImageUrl == null)
            {
                throw new InvalidDataException("ChannelImageUrl is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.ChannelImageUrl = ChannelImageUrl;
            }
            // to ensure "ProductCount" is required (not null)
            if (ProductCount == null)
            {
                throw new InvalidDataException("ProductCount is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.ProductCount = ProductCount;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            // to ensure "IsMarketplace" is required (not null)
            if (IsMarketplace == null)
            {
                throw new InvalidDataException("IsMarketplace is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.IsMarketplace = IsMarketplace;
            }
            // to ensure "ChannelCatalogId" is required (not null)
            if (ChannelCatalogId == null)
            {
                throw new InvalidDataException("ChannelCatalogId is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.ChannelCatalogId = ChannelCatalogId;
            }
            // to ensure "StoreId" is required (not null)
            if (StoreId == null)
            {
                throw new InvalidDataException("StoreId is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.StoreId = StoreId;
            }
            // to ensure "GeneralSettings" is required (not null)
            if (GeneralSettings == null)
            {
                throw new InvalidDataException("GeneralSettings is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.GeneralSettings = GeneralSettings;
            }
            // to ensure "CostSettings" is required (not null)
            if (CostSettings == null)
            {
                throw new InvalidDataException("CostSettings is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.CostSettings = CostSettings;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "Types" is required (not null)
            if (Types == null)
            {
                throw new InvalidDataException("Types is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.Types = Types;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for ChannelCatalog and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this.ColumnMappings = ColumnMappings;
            this.ExclusionFilters = ExclusionFilters;
            this.ExportUrl = ExportUrl;
        }
        
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
        /// Gets or Sets ChannelImageUrl
        /// </summary>
        [DataMember(Name="channelImageUrl", EmitDefaultValue=false)]
        public BeezUPCommonHttpUrl ChannelImageUrl { get; set; }
        /// <summary>
        /// The product count exported considering category mapping. Not all filters have been applied.
        /// </summary>
        /// <value>The product count exported considering category mapping. Not all filters have been applied.</value>
        [DataMember(Name="productCount", EmitDefaultValue=false)]
        public int? ProductCount { get; set; }
        /// <summary>
        /// Indicates if the channel catalog is active
        /// </summary>
        /// <value>Indicates if the channel catalog is active</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Indicates if this channel catalog is related to a marketplace
        /// </summary>
        /// <value>Indicates if this channel catalog is related to a marketplace</value>
        [DataMember(Name="isMarketplace", EmitDefaultValue=false)]
        public bool? IsMarketplace { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCatalogId
        /// </summary>
        [DataMember(Name="channelCatalogId", EmitDefaultValue=false)]
        public BeezUPCommonChannelCatalogId ChannelCatalogId { get; set; }
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public BeezUPCommonStoreId StoreId { get; set; }
        /// <summary>
        /// Gets or Sets GeneralSettings
        /// </summary>
        [DataMember(Name="generalSettings", EmitDefaultValue=false)]
        public GeneralSettings GeneralSettings { get; set; }
        /// <summary>
        /// Gets or Sets CostSettings
        /// </summary>
        [DataMember(Name="costSettings", EmitDefaultValue=false)]
        public CostSettings CostSettings { get; set; }
        /// <summary>
        /// Gets or Sets ColumnMappings
        /// </summary>
        [DataMember(Name="columnMappings", EmitDefaultValue=false)]
        public ColumnMappingWithNameList ColumnMappings { get; set; }
        /// <summary>
        /// Gets or Sets ExclusionFilters
        /// </summary>
        [DataMember(Name="exclusionFilters", EmitDefaultValue=false)]
        public ExclusionFilters ExclusionFilters { get; set; }
        /// <summary>
        /// Gets or Sets ExportUrl
        /// </summary>
        [DataMember(Name="exportUrl", EmitDefaultValue=false)]
        public BeezUPCommonHttpUrl ExportUrl { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChannelCatalogState State { get; set; }
        /// <summary>
        /// The channel type list related to the channel
        /// </summary>
        /// <value>The channel type list related to the channel</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        /// <summary>
        /// Indicates the actions you can do on a channel catalog
        /// </summary>
        /// <value>Indicates the actions you can do on a channel catalog</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<BeezUPCommonLink2> Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalog {\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ChannelImageUrl: ").Append(ChannelImageUrl).Append("\n");
            sb.Append("  ProductCount: ").Append(ProductCount).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsMarketplace: ").Append(IsMarketplace).Append("\n");
            sb.Append("  ChannelCatalogId: ").Append(ChannelCatalogId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  GeneralSettings: ").Append(GeneralSettings).Append("\n");
            sb.Append("  CostSettings: ").Append(CostSettings).Append("\n");
            sb.Append("  ColumnMappings: ").Append(ColumnMappings).Append("\n");
            sb.Append("  ExclusionFilters: ").Append(ExclusionFilters).Append("\n");
            sb.Append("  ExportUrl: ").Append(ExportUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(obj as ChannelCatalog);
        }

        /// <summary>
        /// Returns true if ChannelCatalog instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalog other)
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
                    this.ChannelName == other.ChannelName ||
                    this.ChannelName != null &&
                    this.ChannelName.Equals(other.ChannelName)
                ) && 
                (
                    this.ChannelImageUrl == other.ChannelImageUrl ||
                    this.ChannelImageUrl != null &&
                    this.ChannelImageUrl.Equals(other.ChannelImageUrl)
                ) && 
                (
                    this.ProductCount == other.ProductCount ||
                    this.ProductCount != null &&
                    this.ProductCount.Equals(other.ProductCount)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.IsMarketplace == other.IsMarketplace ||
                    this.IsMarketplace != null &&
                    this.IsMarketplace.Equals(other.IsMarketplace)
                ) && 
                (
                    this.ChannelCatalogId == other.ChannelCatalogId ||
                    this.ChannelCatalogId != null &&
                    this.ChannelCatalogId.Equals(other.ChannelCatalogId)
                ) && 
                (
                    this.StoreId == other.StoreId ||
                    this.StoreId != null &&
                    this.StoreId.Equals(other.StoreId)
                ) && 
                (
                    this.GeneralSettings == other.GeneralSettings ||
                    this.GeneralSettings != null &&
                    this.GeneralSettings.Equals(other.GeneralSettings)
                ) && 
                (
                    this.CostSettings == other.CostSettings ||
                    this.CostSettings != null &&
                    this.CostSettings.Equals(other.CostSettings)
                ) && 
                (
                    this.ColumnMappings == other.ColumnMappings ||
                    this.ColumnMappings != null &&
                    this.ColumnMappings.Equals(other.ColumnMappings)
                ) && 
                (
                    this.ExclusionFilters == other.ExclusionFilters ||
                    this.ExclusionFilters != null &&
                    this.ExclusionFilters.Equals(other.ExclusionFilters)
                ) && 
                (
                    this.ExportUrl == other.ExportUrl ||
                    this.ExportUrl != null &&
                    this.ExportUrl.Equals(other.ExportUrl)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
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
                if (this.ChannelName != null)
                    hash = hash * 59 + this.ChannelName.GetHashCode();
                if (this.ChannelImageUrl != null)
                    hash = hash * 59 + this.ChannelImageUrl.GetHashCode();
                if (this.ProductCount != null)
                    hash = hash * 59 + this.ProductCount.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.IsMarketplace != null)
                    hash = hash * 59 + this.IsMarketplace.GetHashCode();
                if (this.ChannelCatalogId != null)
                    hash = hash * 59 + this.ChannelCatalogId.GetHashCode();
                if (this.StoreId != null)
                    hash = hash * 59 + this.StoreId.GetHashCode();
                if (this.GeneralSettings != null)
                    hash = hash * 59 + this.GeneralSettings.GetHashCode();
                if (this.CostSettings != null)
                    hash = hash * 59 + this.CostSettings.GetHashCode();
                if (this.ColumnMappings != null)
                    hash = hash * 59 + this.ColumnMappings.GetHashCode();
                if (this.ExclusionFilters != null)
                    hash = hash * 59 + this.ExclusionFilters.GetHashCode();
                if (this.ExportUrl != null)
                    hash = hash * 59 + this.ExportUrl.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
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
