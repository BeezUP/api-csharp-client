/* 
 * BeezUP API
 *
 * This is the RESTful API of BeezUP which allows you to manage everything related to BeezUP
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
    /// The contract termination info
    /// </summary>
    [DataContract]
    public partial class TerminateContract :  IEquatable<TerminateContract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateContract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TerminateContract() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateContract" /> class.
        /// </summary>
        /// <param name="ContractTerminationReasonType">ContractTerminationReasonType (required).</param>
        /// <param name="ContractTerminationReason">ContractTerminationReason.</param>
        public TerminateContract(ContractTerminationReasonType ContractTerminationReasonType = default(ContractTerminationReasonType), ContractTerminationReason ContractTerminationReason = default(ContractTerminationReason))
        {
            // to ensure "ContractTerminationReasonType" is required (not null)
            if (ContractTerminationReasonType == null)
            {
                throw new InvalidDataException("ContractTerminationReasonType is a required property for TerminateContract and cannot be null");
            }
            else
            {
                this.ContractTerminationReasonType = ContractTerminationReasonType;
            }
            this.ContractTerminationReason = ContractTerminationReason;
        }
        
        /// <summary>
        /// Gets or Sets ContractTerminationReasonType
        /// </summary>
        [DataMember(Name="contractTerminationReasonType", EmitDefaultValue=false)]
        public ContractTerminationReasonType ContractTerminationReasonType { get; set; }
        /// <summary>
        /// Gets or Sets ContractTerminationReason
        /// </summary>
        [DataMember(Name="contractTerminationReason", EmitDefaultValue=false)]
        public ContractTerminationReason ContractTerminationReason { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TerminateContract {\n");
            sb.Append("  ContractTerminationReasonType: ").Append(ContractTerminationReasonType).Append("\n");
            sb.Append("  ContractTerminationReason: ").Append(ContractTerminationReason).Append("\n");
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
            return this.Equals(obj as TerminateContract);
        }

        /// <summary>
        /// Returns true if TerminateContract instances are equal
        /// </summary>
        /// <param name="other">Instance of TerminateContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminateContract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContractTerminationReasonType == other.ContractTerminationReasonType ||
                    this.ContractTerminationReasonType != null &&
                    this.ContractTerminationReasonType.Equals(other.ContractTerminationReasonType)
                ) && 
                (
                    this.ContractTerminationReason == other.ContractTerminationReason ||
                    this.ContractTerminationReason != null &&
                    this.ContractTerminationReason.Equals(other.ContractTerminationReason)
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
                if (this.ContractTerminationReasonType != null)
                    hash = hash * 59 + this.ContractTerminationReasonType.GetHashCode();
                if (this.ContractTerminationReason != null)
                    hash = hash * 59 + this.ContractTerminationReason.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
