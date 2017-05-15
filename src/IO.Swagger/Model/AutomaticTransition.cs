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
    /// AutomaticTransition
    /// </summary>
    [DataContract]
    public partial class AutomaticTransition :  IEquatable<AutomaticTransition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticTransition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutomaticTransition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticTransition" /> class.
        /// </summary>
        /// <param name="MarketplaceTechnicalCode">MarketplaceTechnicalCode (required).</param>
        /// <param name="AccountId">AccountId (required).</param>
        /// <param name="OrderStatusTransitionId">OrderStatusTransitionId (required).</param>
        /// <param name="Enabled">Enabled (required).</param>
        public AutomaticTransition(BeezUPCommonMarketplaceTechnicalCode MarketplaceTechnicalCode = default(BeezUPCommonMarketplaceTechnicalCode), AccountId AccountId = default(AccountId), int? OrderStatusTransitionId = default(int?), bool? Enabled = default(bool?))
        {
            // to ensure "MarketplaceTechnicalCode" is required (not null)
            if (MarketplaceTechnicalCode == null)
            {
                throw new InvalidDataException("MarketplaceTechnicalCode is a required property for AutomaticTransition and cannot be null");
            }
            else
            {
                this.MarketplaceTechnicalCode = MarketplaceTechnicalCode;
            }
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for AutomaticTransition and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "OrderStatusTransitionId" is required (not null)
            if (OrderStatusTransitionId == null)
            {
                throw new InvalidDataException("OrderStatusTransitionId is a required property for AutomaticTransition and cannot be null");
            }
            else
            {
                this.OrderStatusTransitionId = OrderStatusTransitionId;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for AutomaticTransition and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
        }
        
        /// <summary>
        /// Gets or Sets MarketplaceTechnicalCode
        /// </summary>
        [DataMember(Name="marketplaceTechnicalCode", EmitDefaultValue=false)]
        public BeezUPCommonMarketplaceTechnicalCode MarketplaceTechnicalCode { get; set; }
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public AccountId AccountId { get; set; }
        /// <summary>
        /// Gets or Sets OrderStatusTransitionId
        /// </summary>
        [DataMember(Name="orderStatusTransitionId", EmitDefaultValue=false)]
        public int? OrderStatusTransitionId { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticTransition {\n");
            sb.Append("  MarketplaceTechnicalCode: ").Append(MarketplaceTechnicalCode).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  OrderStatusTransitionId: ").Append(OrderStatusTransitionId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as AutomaticTransition);
        }

        /// <summary>
        /// Returns true if AutomaticTransition instances are equal
        /// </summary>
        /// <param name="other">Instance of AutomaticTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticTransition other)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.OrderStatusTransitionId == other.OrderStatusTransitionId ||
                    this.OrderStatusTransitionId != null &&
                    this.OrderStatusTransitionId.Equals(other.OrderStatusTransitionId)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.OrderStatusTransitionId != null)
                    hash = hash * 59 + this.OrderStatusTransitionId.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
