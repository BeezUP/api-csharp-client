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
    /// Represents the general settings of your channel catalog
    /// </summary>
    [DataContract]
    public partial class GeneralSettings :  IEquatable<GeneralSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeneralSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralSettings" /> class.
        /// </summary>
        /// <param name="AcceptToPublishInfo">If true then you authorize disclosure of my statistics generated from clicks and sales (required).</param>
        /// <param name="UseBid">Activate bidding for this channel (required).</param>
        /// <param name="NoCategoryMapping">Indicates that the channel authorize you to do not map your categories with their categories (required).</param>
        /// <param name="DoNotExportOutOfStockProducts">Do not export \&quot;out of stock\&quot; products. Note: this option is not taken into account by the counter.  (required).</param>
        /// <param name="ActiveBeezUPTracking">Activate BeezUP tracking for my statistics (checked by default) (required) (default to true).</param>
        public GeneralSettings(bool? AcceptToPublishInfo = default(bool?), bool? UseBid = default(bool?), bool? NoCategoryMapping = default(bool?), bool? DoNotExportOutOfStockProducts = default(bool?), bool? ActiveBeezUPTracking = true)
        {
            // to ensure "AcceptToPublishInfo" is required (not null)
            if (AcceptToPublishInfo == null)
            {
                throw new InvalidDataException("AcceptToPublishInfo is a required property for GeneralSettings and cannot be null");
            }
            else
            {
                this.AcceptToPublishInfo = AcceptToPublishInfo;
            }
            // to ensure "UseBid" is required (not null)
            if (UseBid == null)
            {
                throw new InvalidDataException("UseBid is a required property for GeneralSettings and cannot be null");
            }
            else
            {
                this.UseBid = UseBid;
            }
            // to ensure "NoCategoryMapping" is required (not null)
            if (NoCategoryMapping == null)
            {
                throw new InvalidDataException("NoCategoryMapping is a required property for GeneralSettings and cannot be null");
            }
            else
            {
                this.NoCategoryMapping = NoCategoryMapping;
            }
            // to ensure "DoNotExportOutOfStockProducts" is required (not null)
            if (DoNotExportOutOfStockProducts == null)
            {
                throw new InvalidDataException("DoNotExportOutOfStockProducts is a required property for GeneralSettings and cannot be null");
            }
            else
            {
                this.DoNotExportOutOfStockProducts = DoNotExportOutOfStockProducts;
            }
            // to ensure "ActiveBeezUPTracking" is required (not null)
            if (ActiveBeezUPTracking == null)
            {
                throw new InvalidDataException("ActiveBeezUPTracking is a required property for GeneralSettings and cannot be null");
            }
            else
            {
                this.ActiveBeezUPTracking = ActiveBeezUPTracking;
            }
        }
        
        /// <summary>
        /// If true then you authorize disclosure of my statistics generated from clicks and sales
        /// </summary>
        /// <value>If true then you authorize disclosure of my statistics generated from clicks and sales</value>
        [DataMember(Name="acceptToPublishInfo", EmitDefaultValue=false)]
        public bool? AcceptToPublishInfo { get; set; }
        /// <summary>
        /// Activate bidding for this channel
        /// </summary>
        /// <value>Activate bidding for this channel</value>
        [DataMember(Name="useBid", EmitDefaultValue=false)]
        public bool? UseBid { get; set; }
        /// <summary>
        /// Indicates that the channel authorize you to do not map your categories with their categories
        /// </summary>
        /// <value>Indicates that the channel authorize you to do not map your categories with their categories</value>
        [DataMember(Name="noCategoryMapping", EmitDefaultValue=false)]
        public bool? NoCategoryMapping { get; set; }
        /// <summary>
        /// Do not export \&quot;out of stock\&quot; products. Note: this option is not taken into account by the counter. 
        /// </summary>
        /// <value>Do not export \&quot;out of stock\&quot; products. Note: this option is not taken into account by the counter. </value>
        [DataMember(Name="doNotExportOutOfStockProducts", EmitDefaultValue=false)]
        public bool? DoNotExportOutOfStockProducts { get; set; }
        /// <summary>
        /// Activate BeezUP tracking for my statistics (checked by default)
        /// </summary>
        /// <value>Activate BeezUP tracking for my statistics (checked by default)</value>
        [DataMember(Name="activeBeezUPTracking", EmitDefaultValue=false)]
        public bool? ActiveBeezUPTracking { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralSettings {\n");
            sb.Append("  AcceptToPublishInfo: ").Append(AcceptToPublishInfo).Append("\n");
            sb.Append("  UseBid: ").Append(UseBid).Append("\n");
            sb.Append("  NoCategoryMapping: ").Append(NoCategoryMapping).Append("\n");
            sb.Append("  DoNotExportOutOfStockProducts: ").Append(DoNotExportOutOfStockProducts).Append("\n");
            sb.Append("  ActiveBeezUPTracking: ").Append(ActiveBeezUPTracking).Append("\n");
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
            return this.Equals(obj as GeneralSettings);
        }

        /// <summary>
        /// Returns true if GeneralSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of GeneralSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneralSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcceptToPublishInfo == other.AcceptToPublishInfo ||
                    this.AcceptToPublishInfo != null &&
                    this.AcceptToPublishInfo.Equals(other.AcceptToPublishInfo)
                ) && 
                (
                    this.UseBid == other.UseBid ||
                    this.UseBid != null &&
                    this.UseBid.Equals(other.UseBid)
                ) && 
                (
                    this.NoCategoryMapping == other.NoCategoryMapping ||
                    this.NoCategoryMapping != null &&
                    this.NoCategoryMapping.Equals(other.NoCategoryMapping)
                ) && 
                (
                    this.DoNotExportOutOfStockProducts == other.DoNotExportOutOfStockProducts ||
                    this.DoNotExportOutOfStockProducts != null &&
                    this.DoNotExportOutOfStockProducts.Equals(other.DoNotExportOutOfStockProducts)
                ) && 
                (
                    this.ActiveBeezUPTracking == other.ActiveBeezUPTracking ||
                    this.ActiveBeezUPTracking != null &&
                    this.ActiveBeezUPTracking.Equals(other.ActiveBeezUPTracking)
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
                if (this.AcceptToPublishInfo != null)
                    hash = hash * 59 + this.AcceptToPublishInfo.GetHashCode();
                if (this.UseBid != null)
                    hash = hash * 59 + this.UseBid.GetHashCode();
                if (this.NoCategoryMapping != null)
                    hash = hash * 59 + this.NoCategoryMapping.GetHashCode();
                if (this.DoNotExportOutOfStockProducts != null)
                    hash = hash * 59 + this.DoNotExportOutOfStockProducts.GetHashCode();
                if (this.ActiveBeezUPTracking != null)
                    hash = hash * 59 + this.ActiveBeezUPTracking.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
