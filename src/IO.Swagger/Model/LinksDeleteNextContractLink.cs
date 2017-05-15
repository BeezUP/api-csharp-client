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
    /// LinksDeleteNextContractLink
    /// </summary>
    [DataContract]
    public partial class LinksDeleteNextContractLink :  IEquatable<LinksDeleteNextContractLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksDeleteNextContractLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinksDeleteNextContractLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinksDeleteNextContractLink" /> class.
        /// </summary>
        /// <param name="DocUrl">DocUrl.</param>
        /// <param name="Description">The description of the link.</param>
        /// <param name="Href">Href (required).</param>
        /// <param name="OperationId">OperationId.</param>
        /// <param name="Method">Method.</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Templated">indicates whether the href is templated or not.</param>
        /// <param name="Info">Info.</param>
        public LinksDeleteNextContractLink(BeezUPCommonDocUrl DocUrl = default(BeezUPCommonDocUrl), string Description = default(string), BeezUPCommonHref Href = default(BeezUPCommonHref), BeezUPCommonOperationId OperationId = default(BeezUPCommonOperationId), BeezUPCommonHttpMethod Method = default(BeezUPCommonHttpMethod), Dictionary<string, BeezUPCommonLinkParameter3> Parameters = default(Dictionary<string, BeezUPCommonLinkParameter3>), bool? Templated = default(bool?), BeezUPCommonInfoSummaries Info = default(BeezUPCommonInfoSummaries))
        {
            // to ensure "Href" is required (not null)
            if (Href == null)
            {
                throw new InvalidDataException("Href is a required property for LinksDeleteNextContractLink and cannot be null");
            }
            else
            {
                this.Href = Href;
            }
            this.DocUrl = DocUrl;
            this.Description = Description;
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
            sb.Append("class LinksDeleteNextContractLink {\n");
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
            return this.Equals(obj as LinksDeleteNextContractLink);
        }

        /// <summary>
        /// Returns true if LinksDeleteNextContractLink instances are equal
        /// </summary>
        /// <param name="other">Instance of LinksDeleteNextContractLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinksDeleteNextContractLink other)
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
