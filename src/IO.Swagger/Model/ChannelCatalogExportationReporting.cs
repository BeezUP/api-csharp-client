/* 
 * BeezUP API
 *
 * # The REST API of BeezUP system ## Overview The REST APIs provide programmatic access to read and write BeezUP data.  Basically, with this API you will be able to do everything like you were with your browser on https://go.beezup.com !  The main features are: - Register and manage your account - Create and manage and share your stores with your friends/co-workers. - Import your product catalog and schedule the auto importation - Search the channels your want to use - Configure your channels for your catalogs to export your product information:     - cost and general settings     - category and columns mappings     - your will be able to create and manage your custom column     - put in place exlusion filters based on simple conditions on your product data     - override product values     - get product vision for a channel catalog scope - Analyze and optimize your performance of your catalogs on all yours channels with different type of reportings by day, channel, category and by product. - Automatize your optimisation by using rules! - And of course... Manage your orders harvested from all your marketplaces:     - Synchronize your orders in an uniformized way     - Get the available actions and update the order status - ...and more!  ## Authentication credentials The public API with the base path **_/v2/public** have been put in place to give you an entry point to our system for the user registration, login and lost password. The public API does not require any credentials. We give you the some public list of values and public channels for our public commercial web site [www.beezup.com](http://www.beezup.com).  The user API with the base path **_/v2/user** requires a token which is available on this page: https://go.beezup.com/Account/MyAccount  ## Things to keep in mind ### API Rate Limits - The BeezUP REST API is limited to 100 calls/minute.  ### Media type The default media type for requests and responses is application/json. Where noted, some operations support other content types. If no additional content type is mentioned for a specific operation, then the media type is application/json.  ### Required content type The required and default encoding for the request and responses is UTF8.  ### Required date time format All our date time are formatted in ISO 8601 format: 2014-06-24T16:25:00Z.  ### Base URL The Base URL of the BeezUP API Order Management REST API conforms to the following template.  https://api.beezup.com  All URLs returned by the BeezUP API are relative to this base URL, and all requests to the REST API must use this base URL template.  You can test our API on https://api-docs.beezup.com/swagger-ui\\ You can contact us on [gitter, #BeezUP/API](https://gitter.im/beezUP/API) 
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
    /// ChannelCatalogExportationReporting
    /// </summary>
    [DataContract]
    public partial class ChannelCatalogExportationReporting :  IEquatable<ChannelCatalogExportationReporting>, IValidatableObject
    {
        /// <summary>
        /// The cache status during the exportation
        /// </summary>
        /// <value>The cache status during the exportation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CacheStatusEnum
        {
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,
            
            /// <summary>
            /// Enum Available for "Available"
            /// </summary>
            [EnumMember(Value = "Available")]
            Available,
            
            /// <summary>
            /// Enum GeneratedManually for "GeneratedManually"
            /// </summary>
            [EnumMember(Value = "GeneratedManually")]
            GeneratedManually
        }

        /// <summary>
        /// The cache status during the exportation
        /// </summary>
        /// <value>The cache status during the exportation</value>
        [DataMember(Name="cacheStatus", EmitDefaultValue=false)]
        public CacheStatusEnum? CacheStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogExportationReporting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCatalogExportationReporting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCatalogExportationReporting" /> class.
        /// </summary>
        /// <param name="ExportationUtcDate">The exportation UTC date (required).</param>
        /// <param name="ExportationDuration">The exportation duration. \\ &#39;00:01:00&#39; measn 1 minute. .</param>
        /// <param name="CacheStatus">The cache status during the exportation.</param>
        /// <param name="ExportedProductCount">The exportated product count during this exportation.</param>
        /// <param name="ClientIpAddress">The IP address of the client who requests this exportation (required).</param>
        /// <param name="ClientUserAgent">The http header User-Agent sent by the client who requests this operation (required).</param>
        public ChannelCatalogExportationReporting(DateTime? ExportationUtcDate = default(DateTime?), string ExportationDuration = default(string), CacheStatusEnum? CacheStatus = default(CacheStatusEnum?), int? ExportedProductCount = default(int?), string ClientIpAddress = default(string), string ClientUserAgent = default(string))
        {
            // to ensure "ExportationUtcDate" is required (not null)
            if (ExportationUtcDate == null)
            {
                throw new InvalidDataException("ExportationUtcDate is a required property for ChannelCatalogExportationReporting and cannot be null");
            }
            else
            {
                this.ExportationUtcDate = ExportationUtcDate;
            }
            // to ensure "ClientIpAddress" is required (not null)
            if (ClientIpAddress == null)
            {
                throw new InvalidDataException("ClientIpAddress is a required property for ChannelCatalogExportationReporting and cannot be null");
            }
            else
            {
                this.ClientIpAddress = ClientIpAddress;
            }
            // to ensure "ClientUserAgent" is required (not null)
            if (ClientUserAgent == null)
            {
                throw new InvalidDataException("ClientUserAgent is a required property for ChannelCatalogExportationReporting and cannot be null");
            }
            else
            {
                this.ClientUserAgent = ClientUserAgent;
            }
            this.ExportationDuration = ExportationDuration;
            this.CacheStatus = CacheStatus;
            this.ExportedProductCount = ExportedProductCount;
        }
        
        /// <summary>
        /// The exportation UTC date
        /// </summary>
        /// <value>The exportation UTC date</value>
        [DataMember(Name="exportationUtcDate", EmitDefaultValue=false)]
        public DateTime? ExportationUtcDate { get; set; }
        /// <summary>
        /// The exportation duration. \\ &#39;00:01:00&#39; measn 1 minute. 
        /// </summary>
        /// <value>The exportation duration. \\ &#39;00:01:00&#39; measn 1 minute. </value>
        [DataMember(Name="exportationDuration", EmitDefaultValue=false)]
        public string ExportationDuration { get; set; }
        /// <summary>
        /// The exportated product count during this exportation
        /// </summary>
        /// <value>The exportated product count during this exportation</value>
        [DataMember(Name="exportedProductCount", EmitDefaultValue=false)]
        public int? ExportedProductCount { get; set; }
        /// <summary>
        /// The IP address of the client who requests this exportation
        /// </summary>
        /// <value>The IP address of the client who requests this exportation</value>
        [DataMember(Name="clientIpAddress", EmitDefaultValue=false)]
        public string ClientIpAddress { get; set; }
        /// <summary>
        /// The http header User-Agent sent by the client who requests this operation
        /// </summary>
        /// <value>The http header User-Agent sent by the client who requests this operation</value>
        [DataMember(Name="clientUserAgent", EmitDefaultValue=false)]
        public string ClientUserAgent { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCatalogExportationReporting {\n");
            sb.Append("  ExportationUtcDate: ").Append(ExportationUtcDate).Append("\n");
            sb.Append("  ExportationDuration: ").Append(ExportationDuration).Append("\n");
            sb.Append("  CacheStatus: ").Append(CacheStatus).Append("\n");
            sb.Append("  ExportedProductCount: ").Append(ExportedProductCount).Append("\n");
            sb.Append("  ClientIpAddress: ").Append(ClientIpAddress).Append("\n");
            sb.Append("  ClientUserAgent: ").Append(ClientUserAgent).Append("\n");
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
            return this.Equals(obj as ChannelCatalogExportationReporting);
        }

        /// <summary>
        /// Returns true if ChannelCatalogExportationReporting instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCatalogExportationReporting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCatalogExportationReporting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExportationUtcDate == other.ExportationUtcDate ||
                    this.ExportationUtcDate != null &&
                    this.ExportationUtcDate.Equals(other.ExportationUtcDate)
                ) && 
                (
                    this.ExportationDuration == other.ExportationDuration ||
                    this.ExportationDuration != null &&
                    this.ExportationDuration.Equals(other.ExportationDuration)
                ) && 
                (
                    this.CacheStatus == other.CacheStatus ||
                    this.CacheStatus != null &&
                    this.CacheStatus.Equals(other.CacheStatus)
                ) && 
                (
                    this.ExportedProductCount == other.ExportedProductCount ||
                    this.ExportedProductCount != null &&
                    this.ExportedProductCount.Equals(other.ExportedProductCount)
                ) && 
                (
                    this.ClientIpAddress == other.ClientIpAddress ||
                    this.ClientIpAddress != null &&
                    this.ClientIpAddress.Equals(other.ClientIpAddress)
                ) && 
                (
                    this.ClientUserAgent == other.ClientUserAgent ||
                    this.ClientUserAgent != null &&
                    this.ClientUserAgent.Equals(other.ClientUserAgent)
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
                if (this.ExportationUtcDate != null)
                    hash = hash * 59 + this.ExportationUtcDate.GetHashCode();
                if (this.ExportationDuration != null)
                    hash = hash * 59 + this.ExportationDuration.GetHashCode();
                if (this.CacheStatus != null)
                    hash = hash * 59 + this.CacheStatus.GetHashCode();
                if (this.ExportedProductCount != null)
                    hash = hash * 59 + this.ExportedProductCount.GetHashCode();
                if (this.ClientIpAddress != null)
                    hash = hash * 59 + this.ClientIpAddress.GetHashCode();
                if (this.ClientUserAgent != null)
                    hash = hash * 59 + this.ClientUserAgent.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // ExportationDuration (string) pattern
            Regex regexExportationDuration = new Regex(@"(00:1[5-9])|(00:[2-5][0-9])|(0[1-9]:[0-5][0-9])|(1[0-9]:[0-5][0-9])|(2[0-3]:[0-5][0-9])", RegexOptions.CultureInvariant);
            if (false == regexExportationDuration.Match(this.ExportationDuration).Success)
            {
                yield return new ValidationResult("Invalid value for ExportationDuration, must match a pattern of /(00:1[5-9])|(00:[2-5][0-9])|(0[1-9]:[0-5][0-9])|(1[0-9]:[0-5][0-9])|(2[0-3]:[0-5][0-9])/.", new [] { "ExportationDuration" });
            }

            yield break;
        }
    }

}