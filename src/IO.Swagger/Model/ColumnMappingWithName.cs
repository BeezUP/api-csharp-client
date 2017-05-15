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
    /// ColumnMappingWithName
    /// </summary>
    [DataContract]
    public partial class ColumnMappingWithName :  IEquatable<ColumnMappingWithName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnMappingWithName" /> class.
        /// </summary>
        /// <param name="ChannelColumnId">ChannelColumnId.</param>
        /// <param name="ChannelCategoryPath">ChannelCategoryPath.</param>
        /// <param name="CatalogColumnId">CatalogColumnId.</param>
        /// <param name="ChannelColumnName">ChannelColumnName.</param>
        /// <param name="ChannelBeezUPColumnName">ChannelBeezUPColumnName.</param>
        /// <param name="CatalogColumnName">CatalogColumnName.</param>
        /// <param name="CatalogBeezUPColumnName">CatalogBeezUPColumnName.</param>
        public ColumnMappingWithName(BeezUPCommonChannelColumnId ChannelColumnId = default(BeezUPCommonChannelColumnId), BeezUPCommonChannelCategoryPath ChannelCategoryPath = default(BeezUPCommonChannelCategoryPath), BeezUPCommonCatalogColumnId CatalogColumnId = default(BeezUPCommonCatalogColumnId), BeezUPCommonChannelColumnName ChannelColumnName = default(BeezUPCommonChannelColumnName), BeezUPCommonBeezUPColumnName ChannelBeezUPColumnName = default(BeezUPCommonBeezUPColumnName), BeezUPCommonCatalogColumnUserName CatalogColumnName = default(BeezUPCommonCatalogColumnUserName), BeezUPCommonBeezUPColumnName CatalogBeezUPColumnName = default(BeezUPCommonBeezUPColumnName))
        {
            this.ChannelColumnId = ChannelColumnId;
            this.ChannelCategoryPath = ChannelCategoryPath;
            this.CatalogColumnId = CatalogColumnId;
            this.ChannelColumnName = ChannelColumnName;
            this.ChannelBeezUPColumnName = ChannelBeezUPColumnName;
            this.CatalogColumnName = CatalogColumnName;
            this.CatalogBeezUPColumnName = CatalogBeezUPColumnName;
        }
        
        /// <summary>
        /// Gets or Sets ChannelColumnId
        /// </summary>
        [DataMember(Name="channelColumnId", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnId ChannelColumnId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelCategoryPath
        /// </summary>
        [DataMember(Name="channelCategoryPath", EmitDefaultValue=false)]
        public BeezUPCommonChannelCategoryPath ChannelCategoryPath { get; set; }
        /// <summary>
        /// Gets or Sets CatalogColumnId
        /// </summary>
        [DataMember(Name="catalogColumnId", EmitDefaultValue=false)]
        public BeezUPCommonCatalogColumnId CatalogColumnId { get; set; }
        /// <summary>
        /// Gets or Sets ChannelColumnName
        /// </summary>
        [DataMember(Name="channelColumnName", EmitDefaultValue=false)]
        public BeezUPCommonChannelColumnName ChannelColumnName { get; set; }
        /// <summary>
        /// Gets or Sets ChannelBeezUPColumnName
        /// </summary>
        [DataMember(Name="channelBeezUPColumnName", EmitDefaultValue=false)]
        public BeezUPCommonBeezUPColumnName ChannelBeezUPColumnName { get; set; }
        /// <summary>
        /// Gets or Sets CatalogColumnName
        /// </summary>
        [DataMember(Name="catalogColumnName", EmitDefaultValue=false)]
        public BeezUPCommonCatalogColumnUserName CatalogColumnName { get; set; }
        /// <summary>
        /// Gets or Sets CatalogBeezUPColumnName
        /// </summary>
        [DataMember(Name="catalogBeezUPColumnName", EmitDefaultValue=false)]
        public BeezUPCommonBeezUPColumnName CatalogBeezUPColumnName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnMappingWithName {\n");
            sb.Append("  ChannelColumnId: ").Append(ChannelColumnId).Append("\n");
            sb.Append("  ChannelCategoryPath: ").Append(ChannelCategoryPath).Append("\n");
            sb.Append("  CatalogColumnId: ").Append(CatalogColumnId).Append("\n");
            sb.Append("  ChannelColumnName: ").Append(ChannelColumnName).Append("\n");
            sb.Append("  ChannelBeezUPColumnName: ").Append(ChannelBeezUPColumnName).Append("\n");
            sb.Append("  CatalogColumnName: ").Append(CatalogColumnName).Append("\n");
            sb.Append("  CatalogBeezUPColumnName: ").Append(CatalogBeezUPColumnName).Append("\n");
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
            return this.Equals(obj as ColumnMappingWithName);
        }

        /// <summary>
        /// Returns true if ColumnMappingWithName instances are equal
        /// </summary>
        /// <param name="other">Instance of ColumnMappingWithName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ColumnMappingWithName other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelColumnId == other.ChannelColumnId ||
                    this.ChannelColumnId != null &&
                    this.ChannelColumnId.Equals(other.ChannelColumnId)
                ) && 
                (
                    this.ChannelCategoryPath == other.ChannelCategoryPath ||
                    this.ChannelCategoryPath != null &&
                    this.ChannelCategoryPath.Equals(other.ChannelCategoryPath)
                ) && 
                (
                    this.CatalogColumnId == other.CatalogColumnId ||
                    this.CatalogColumnId != null &&
                    this.CatalogColumnId.Equals(other.CatalogColumnId)
                ) && 
                (
                    this.ChannelColumnName == other.ChannelColumnName ||
                    this.ChannelColumnName != null &&
                    this.ChannelColumnName.Equals(other.ChannelColumnName)
                ) && 
                (
                    this.ChannelBeezUPColumnName == other.ChannelBeezUPColumnName ||
                    this.ChannelBeezUPColumnName != null &&
                    this.ChannelBeezUPColumnName.Equals(other.ChannelBeezUPColumnName)
                ) && 
                (
                    this.CatalogColumnName == other.CatalogColumnName ||
                    this.CatalogColumnName != null &&
                    this.CatalogColumnName.Equals(other.CatalogColumnName)
                ) && 
                (
                    this.CatalogBeezUPColumnName == other.CatalogBeezUPColumnName ||
                    this.CatalogBeezUPColumnName != null &&
                    this.CatalogBeezUPColumnName.Equals(other.CatalogBeezUPColumnName)
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
                if (this.ChannelColumnId != null)
                    hash = hash * 59 + this.ChannelColumnId.GetHashCode();
                if (this.ChannelCategoryPath != null)
                    hash = hash * 59 + this.ChannelCategoryPath.GetHashCode();
                if (this.CatalogColumnId != null)
                    hash = hash * 59 + this.CatalogColumnId.GetHashCode();
                if (this.ChannelColumnName != null)
                    hash = hash * 59 + this.ChannelColumnName.GetHashCode();
                if (this.ChannelBeezUPColumnName != null)
                    hash = hash * 59 + this.ChannelBeezUPColumnName.GetHashCode();
                if (this.CatalogColumnName != null)
                    hash = hash * 59 + this.CatalogColumnName.GetHashCode();
                if (this.CatalogBeezUPColumnName != null)
                    hash = hash * 59 + this.CatalogBeezUPColumnName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
