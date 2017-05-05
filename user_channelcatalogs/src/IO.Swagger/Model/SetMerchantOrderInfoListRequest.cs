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
    /// SetMerchantOrderInfoListRequest
    /// </summary>
    [DataContract]
    public partial class SetMerchantOrderInfoListRequest :  IEquatable<SetMerchantOrderInfoListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetMerchantOrderInfoListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetMerchantOrderInfoListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetMerchantOrderInfoListRequest" /> class.
        /// </summary>
        /// <param name="OrderMerchantECommerceSoftwareName">OrderMerchantECommerceSoftwareName.</param>
        /// <param name="OrderMerchantECommerceSoftwareVersion">OrderMerchantECommerceSoftwareVersion.</param>
        /// <param name="Orders">Orders (required).</param>
        public SetMerchantOrderInfoListRequest(OrderMerchantECommerceSoftwareName OrderMerchantECommerceSoftwareName = default(OrderMerchantECommerceSoftwareName), OrderMerchantECommerceSoftwareVersion OrderMerchantECommerceSoftwareVersion = default(OrderMerchantECommerceSoftwareVersion), List<SetMerchantOrderInfoListRequestItem> Orders = default(List<SetMerchantOrderInfoListRequestItem>))
        {
            // to ensure "Orders" is required (not null)
            if (Orders == null)
            {
                throw new InvalidDataException("Orders is a required property for SetMerchantOrderInfoListRequest and cannot be null");
            }
            else
            {
                this.Orders = Orders;
            }
            this.OrderMerchantECommerceSoftwareName = OrderMerchantECommerceSoftwareName;
            this.OrderMerchantECommerceSoftwareVersion = OrderMerchantECommerceSoftwareVersion;
        }
        
        /// <summary>
        /// Gets or Sets OrderMerchantECommerceSoftwareName
        /// </summary>
        [DataMember(Name="order_MerchantECommerceSoftwareName", EmitDefaultValue=false)]
        public OrderMerchantECommerceSoftwareName OrderMerchantECommerceSoftwareName { get; set; }
        /// <summary>
        /// Gets or Sets OrderMerchantECommerceSoftwareVersion
        /// </summary>
        [DataMember(Name="order_MerchantECommerceSoftwareVersion", EmitDefaultValue=false)]
        public OrderMerchantECommerceSoftwareVersion OrderMerchantECommerceSoftwareVersion { get; set; }
        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<SetMerchantOrderInfoListRequestItem> Orders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetMerchantOrderInfoListRequest {\n");
            sb.Append("  OrderMerchantECommerceSoftwareName: ").Append(OrderMerchantECommerceSoftwareName).Append("\n");
            sb.Append("  OrderMerchantECommerceSoftwareVersion: ").Append(OrderMerchantECommerceSoftwareVersion).Append("\n");
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
            return this.Equals(obj as SetMerchantOrderInfoListRequest);
        }

        /// <summary>
        /// Returns true if SetMerchantOrderInfoListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SetMerchantOrderInfoListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetMerchantOrderInfoListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderMerchantECommerceSoftwareName == other.OrderMerchantECommerceSoftwareName ||
                    this.OrderMerchantECommerceSoftwareName != null &&
                    this.OrderMerchantECommerceSoftwareName.Equals(other.OrderMerchantECommerceSoftwareName)
                ) && 
                (
                    this.OrderMerchantECommerceSoftwareVersion == other.OrderMerchantECommerceSoftwareVersion ||
                    this.OrderMerchantECommerceSoftwareVersion != null &&
                    this.OrderMerchantECommerceSoftwareVersion.Equals(other.OrderMerchantECommerceSoftwareVersion)
                ) && 
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
                if (this.OrderMerchantECommerceSoftwareName != null)
                    hash = hash * 59 + this.OrderMerchantECommerceSoftwareName.GetHashCode();
                if (this.OrderMerchantECommerceSoftwareVersion != null)
                    hash = hash * 59 + this.OrderMerchantECommerceSoftwareVersion.GetHashCode();
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
