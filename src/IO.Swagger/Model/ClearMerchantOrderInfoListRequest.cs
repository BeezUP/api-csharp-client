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
    /// ClearMerchantOrderInfoListRequest
    /// </summary>
    [DataContract]
    public partial class ClearMerchantOrderInfoListRequest :  IEquatable<ClearMerchantOrderInfoListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClearMerchantOrderInfoListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClearMerchantOrderInfoListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClearMerchantOrderInfoListRequest" /> class.
        /// </summary>
        /// <param name="Orders">Orders (required).</param>
        public ClearMerchantOrderInfoListRequest(List<OrderIdentifier> Orders = default(List<OrderIdentifier>))
        {
            // to ensure "Orders" is required (not null)
            if (Orders == null)
            {
                throw new InvalidDataException("Orders is a required property for ClearMerchantOrderInfoListRequest and cannot be null");
            }
            else
            {
                this.Orders = Orders;
            }
        }
        
        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<OrderIdentifier> Orders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClearMerchantOrderInfoListRequest {\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
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
            return this.Equals(obj as ClearMerchantOrderInfoListRequest);
        }

        /// <summary>
        /// Returns true if ClearMerchantOrderInfoListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ClearMerchantOrderInfoListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClearMerchantOrderInfoListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Orders == other.Orders ||
                    this.Orders != null &&
                    this.Orders.SequenceEqual(other.Orders)
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
                if (this.Orders != null)
                    hash = hash * 59 + this.Orders.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
