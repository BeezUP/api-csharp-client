/* 
 * Marketplaces - Channel catalogs
 *
 * This API allows you to manage your channel catalogs\\' marketplace settings and fetch your account\\'s catalog publication history
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
    /// LinksGetChannelCatalogMarketplaceSettingsLink
    /// </summary>
    [DataContract]
    public partial class LinksGetChannelCatalogMarketplaceSettingsLink :  IEquatable<LinksGetChannelCatalogMarketplaceSettingsLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksGetChannelCatalogMarketplaceSettingsLink" /> class.
        /// </summary>
        /// <param name="DocUrl">DocUrl.</param>
        /// <param name="Description">The description of the link.</param>
        /// <param name="Href">Href.</param>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="Method">Method.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Templated">indicates whether the href is templated or not.</param>
        /// <param name="Info">Info.</param>
        public LinksGetChannelCatalogMarketplaceSettingsLink(BeezUPCommonDocUrl DocUrl = default(BeezUPCommonDocUrl), string Description = default(string), BeezUPCommonHref Href = default(BeezUPCommonHref), BeezUPCommonOperationId OperationId = default(BeezUPCommonOperationId), BeezUPCommonHttpMethod Method = default(BeezUPCommonHttpMethod), Dictionary<string, BeezUPCommonLinkParameter3> Parameters = default(Dictionary<string, BeezUPCommonLinkParameter3>), bool? Templated = default(bool?), BeezUPCommonInfoSummaries Info = default(BeezUPCommonInfoSummaries))
        {
            this.DocUrl = DocUrl;
            this.Description = Description;
            this.Href = Href;
            this.OperationId = OperationId;
            this.Method = Method;
            this.Parameters = Parameters;
            this.Templated = Templated;
            this.Info = Info;
        }
        
        /// <summary>
        /// Gets or Sets DocUrl
        /// </summary>
        [DataMember(Name="docUrl", EmitDefaultValue=false)]
        public BeezUPCommonDocUrl DocUrl { get; set; }
        /// <summary>
        /// The description of the link
        /// </summary>
        /// <value>The description of the link</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public BeezUPCommonHref Href { get; set; }
        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [DataMember(Name="operationId", EmitDefaultValue=false)]
        public BeezUPCommonOperationId OperationId { get; set; }
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public BeezUPCommonHttpMethod Method { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, BeezUPCommonLinkParameter3> Parameters { get; set; }
        /// <summary>
        /// indicates whether the href is templated or not
        /// </summary>
        /// <value>indicates whether the href is templated or not</value>
        [DataMember(Name="templated", EmitDefaultValue=false)]
        public bool? Templated { get; set; }
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public BeezUPCommonInfoSummaries Info { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinksGetChannelCatalogMarketplaceSettingsLink {\n");
            sb.Append("  DocUrl: ").Append(DocUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Templated: ").Append(Templated).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
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
            return this.Equals(obj as LinksGetChannelCatalogMarketplaceSettingsLink);
        }

        /// <summary>
        /// Returns true if LinksGetChannelCatalogMarketplaceSettingsLink instances are equal
        /// </summary>
        /// <param name="other">Instance of LinksGetChannelCatalogMarketplaceSettingsLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinksGetChannelCatalogMarketplaceSettingsLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocUrl == other.DocUrl ||
                    this.DocUrl != null &&
                    this.DocUrl.Equals(other.DocUrl)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.OperationId == other.OperationId ||
                    this.OperationId != null &&
                    this.OperationId.Equals(other.OperationId)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Templated == other.Templated ||
                    this.Templated != null &&
                    this.Templated.Equals(other.Templated)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
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
                if (this.DocUrl != null)
                    hash = hash * 59 + this.DocUrl.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.OperationId != null)
                    hash = hash * 59 + this.OperationId.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                if (this.Templated != null)
                    hash = hash * 59 + this.Templated.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
