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
    /// The message request to export order list. The store identifier is requested to regroup the exportations.
    /// </summary>
    [DataContract]
    public partial class ExportOrderListRequest :  IEquatable<ExportOrderListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportOrderListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportOrderListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportOrderListRequest" /> class.
        /// </summary>
        /// <param name="Format">Format.</param>
        /// <param name="StoreId">StoreId (required).</param>
        /// <param name="OrderListRequest">OrderListRequest (required).</param>
        public ExportOrderListRequest(ExportOrderListFormat Format = default(ExportOrderListFormat), BeezUPCommonStoreId StoreId = default(BeezUPCommonStoreId), OrderListRequest OrderListRequest = default(OrderListRequest))
        {
            // to ensure "StoreId" is required (not null)
            if (StoreId == null)
            {
                throw new InvalidDataException("StoreId is a required property for ExportOrderListRequest and cannot be null");
            }
            else
            {
                this.StoreId = StoreId;
            }
            // to ensure "OrderListRequest" is required (not null)
            if (OrderListRequest == null)
            {
                throw new InvalidDataException("OrderListRequest is a required property for ExportOrderListRequest and cannot be null");
            }
            else
            {
                this.OrderListRequest = OrderListRequest;
            }
            this.Format = Format;
        }
        
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public ExportOrderListFormat Format { get; set; }
        /// <summary>
        /// Gets or Sets StoreId
        /// </summary>
        [DataMember(Name="storeId", EmitDefaultValue=false)]
        public BeezUPCommonStoreId StoreId { get; set; }
        /// <summary>
        /// Gets or Sets OrderListRequest
        /// </summary>
        [DataMember(Name="orderListRequest", EmitDefaultValue=false)]
        public OrderListRequest OrderListRequest { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportOrderListRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  OrderListRequest: ").Append(OrderListRequest).Append("\n");
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
            return this.Equals(obj as ExportOrderListRequest);
        }

        /// <summary>
        /// Returns true if ExportOrderListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ExportOrderListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportOrderListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.StoreId == other.StoreId ||
                    this.StoreId != null &&
                    this.StoreId.Equals(other.StoreId)
                ) && 
                (
                    this.OrderListRequest == other.OrderListRequest ||
                    this.OrderListRequest != null &&
                    this.OrderListRequest.Equals(other.OrderListRequest)
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
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.StoreId != null)
                    hash = hash * 59 + this.StoreId.GetHashCode();
                if (this.OrderListRequest != null)
                    hash = hash * 59 + this.OrderListRequest.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
