/* 
 * Customer
 *
 * This API will gives you the ability to : - manage your account - manage your stores - shares your stores with your friends - manage your contracts - access to your invoices 
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
    /// The different actions you can make on this offer
    /// </summary>
    [DataContract]
    public partial class StoreAlertLinks :  IEquatable<StoreAlertLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAlertLinks" /> class.
        /// </summary>
        /// <param name="SaveStoreAlert">SaveStoreAlert.</param>
        public StoreAlertLinks(LinksSaveStoreAlertLink SaveStoreAlert = default(LinksSaveStoreAlertLink))
        {
            this.SaveStoreAlert = SaveStoreAlert;
        }
        
        /// <summary>
        /// Gets or Sets SaveStoreAlert
        /// </summary>
        [DataMember(Name="saveStoreAlert", EmitDefaultValue=false)]
        public LinksSaveStoreAlertLink SaveStoreAlert { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreAlertLinks {\n");
            sb.Append("  SaveStoreAlert: ").Append(SaveStoreAlert).Append("\n");
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
            return this.Equals(obj as StoreAlertLinks);
        }

        /// <summary>
        /// Returns true if StoreAlertLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of StoreAlertLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreAlertLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SaveStoreAlert == other.SaveStoreAlert ||
                    this.SaveStoreAlert != null &&
                    this.SaveStoreAlert.Equals(other.SaveStoreAlert)
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
                if (this.SaveStoreAlert != null)
                    hash = hash * 59 + this.SaveStoreAlert.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
