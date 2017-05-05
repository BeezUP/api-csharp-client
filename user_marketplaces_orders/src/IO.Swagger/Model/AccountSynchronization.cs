/* 
 * Marketplaces - Orders
 *
 * The features exposed in this API are centered around managing Orders harvested from your configured marketplaces.\\ This includes: - fetching current information (as known by BeezUP) for a single or multiple Orders, - requesting Order harvest to synchronize your marketplaces and BeezUP accounts, - changing BeezUP data and requesting changes to your marketplaces (accepting, shipping, etc), - configuring automatic changes to marketplace based our newly fetched data, - creating and exporting reports for your Orders. 
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
    /// AccountSynchronization
    /// </summary>
    [DataContract]
    public partial class AccountSynchronization :  IEquatable<AccountSynchronization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSynchronization" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="CompletedHarvestSynchroUtcDate">CompletedHarvestSynchroUtcDate.</param>
        /// <param name="MarketplaceBusinessCode">MarketplaceBusinessCode.</param>
        /// <param name="MarketplaceTechnicalCode">MarketplaceTechnicalCode.</param>
        public AccountSynchronization(AccountId AccountId = default(AccountId), DateTime? CompletedHarvestSynchroUtcDate = default(DateTime?), MarketplaceBusinessCode MarketplaceBusinessCode = default(MarketplaceBusinessCode), MarketplaceTechnicalCode MarketplaceTechnicalCode = default(MarketplaceTechnicalCode))
        {
            this.AccountId = AccountId;
            this.CompletedHarvestSynchroUtcDate = CompletedHarvestSynchroUtcDate;
            this.MarketplaceBusinessCode = MarketplaceBusinessCode;
            this.MarketplaceTechnicalCode = MarketplaceTechnicalCode;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public AccountId AccountId { get; set; }
        /// <summary>
        /// Gets or Sets CompletedHarvestSynchroUtcDate
        /// </summary>
        [DataMember(Name="completedHarvestSynchroUtcDate", EmitDefaultValue=false)]
        public DateTime? CompletedHarvestSynchroUtcDate { get; set; }
        /// <summary>
        /// Gets or Sets MarketplaceBusinessCode
        /// </summary>
        [DataMember(Name="marketplaceBusinessCode", EmitDefaultValue=false)]
        public MarketplaceBusinessCode MarketplaceBusinessCode { get; set; }
        /// <summary>
        /// Gets or Sets MarketplaceTechnicalCode
        /// </summary>
        [DataMember(Name="marketplaceTechnicalCode", EmitDefaultValue=false)]
        public MarketplaceTechnicalCode MarketplaceTechnicalCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSynchronization {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CompletedHarvestSynchroUtcDate: ").Append(CompletedHarvestSynchroUtcDate).Append("\n");
            sb.Append("  MarketplaceBusinessCode: ").Append(MarketplaceBusinessCode).Append("\n");
            sb.Append("  MarketplaceTechnicalCode: ").Append(MarketplaceTechnicalCode).Append("\n");
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
            return this.Equals(obj as AccountSynchronization);
        }

        /// <summary>
        /// Returns true if AccountSynchronization instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSynchronization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSynchronization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.CompletedHarvestSynchroUtcDate == other.CompletedHarvestSynchroUtcDate ||
                    this.CompletedHarvestSynchroUtcDate != null &&
                    this.CompletedHarvestSynchroUtcDate.Equals(other.CompletedHarvestSynchroUtcDate)
                ) && 
                (
                    this.MarketplaceBusinessCode == other.MarketplaceBusinessCode ||
                    this.MarketplaceBusinessCode != null &&
                    this.MarketplaceBusinessCode.Equals(other.MarketplaceBusinessCode)
                ) && 
                (
                    this.MarketplaceTechnicalCode == other.MarketplaceTechnicalCode ||
                    this.MarketplaceTechnicalCode != null &&
                    this.MarketplaceTechnicalCode.Equals(other.MarketplaceTechnicalCode)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.CompletedHarvestSynchroUtcDate != null)
                    hash = hash * 59 + this.CompletedHarvestSynchroUtcDate.GetHashCode();
                if (this.MarketplaceBusinessCode != null)
                    hash = hash * 59 + this.MarketplaceBusinessCode.GetHashCode();
                if (this.MarketplaceTechnicalCode != null)
                    hash = hash * 59 + this.MarketplaceTechnicalCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}