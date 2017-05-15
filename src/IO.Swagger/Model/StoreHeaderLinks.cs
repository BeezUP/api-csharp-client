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
    /// The action links for this store
    /// </summary>
    [DataContract]
    public partial class StoreHeaderLinks :  IEquatable<StoreHeaderLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreHeaderLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="DeleteStore">DeleteStore.</param>
        /// <param name="UpdateStore">UpdateStore.</param>
        /// <param name="GetShares">GetShares.</param>
        /// <param name="Share">Share.</param>
        public StoreHeaderLinks(LinksGetStoreLink Self = default(LinksGetStoreLink), LinksDeleteStoreLink DeleteStore = default(LinksDeleteStoreLink), LinksUpdateStoreLink UpdateStore = default(LinksUpdateStoreLink), LinksGetSharesLink GetShares = default(LinksGetSharesLink), LinksShareLink Share = default(LinksShareLink))
        {
            this.Self = Self;
            this.DeleteStore = DeleteStore;
            this.UpdateStore = UpdateStore;
            this.GetShares = GetShares;
            this.Share = Share;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public LinksGetStoreLink Self { get; set; }
        /// <summary>
        /// Gets or Sets DeleteStore
        /// </summary>
        [DataMember(Name="deleteStore", EmitDefaultValue=false)]
        public LinksDeleteStoreLink DeleteStore { get; set; }
        /// <summary>
        /// Gets or Sets UpdateStore
        /// </summary>
        [DataMember(Name="updateStore", EmitDefaultValue=false)]
        public LinksUpdateStoreLink UpdateStore { get; set; }
        /// <summary>
        /// Gets or Sets GetShares
        /// </summary>
        [DataMember(Name="getShares", EmitDefaultValue=false)]
        public LinksGetSharesLink GetShares { get; set; }
        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public LinksShareLink Share { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreHeaderLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  DeleteStore: ").Append(DeleteStore).Append("\n");
            sb.Append("  UpdateStore: ").Append(UpdateStore).Append("\n");
            sb.Append("  GetShares: ").Append(GetShares).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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
            return this.Equals(obj as StoreHeaderLinks);
        }

        /// <summary>
        /// Returns true if StoreHeaderLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreHeaderLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreHeaderLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.DeleteStore == other.DeleteStore ||
                    this.DeleteStore != null &&
                    this.DeleteStore.Equals(other.DeleteStore)
                ) && 
                (
                    this.UpdateStore == other.UpdateStore ||
                    this.UpdateStore != null &&
                    this.UpdateStore.Equals(other.UpdateStore)
                ) && 
                (
                    this.GetShares == other.GetShares ||
                    this.GetShares != null &&
                    this.GetShares.Equals(other.GetShares)
                ) && 
                (
                    this.Share == other.Share ||
                    this.Share != null &&
                    this.Share.Equals(other.Share)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.DeleteStore != null)
                    hash = hash * 59 + this.DeleteStore.GetHashCode();
                if (this.UpdateStore != null)
                    hash = hash * 59 + this.UpdateStore.GetHashCode();
                if (this.GetShares != null)
                    hash = hash * 59 + this.GetShares.GetHashCode();
                if (this.Share != null)
                    hash = hash * 59 + this.Share.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
