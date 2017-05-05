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
    /// Contains all change order operations you want to make
    /// </summary>
    [DataContract]
    public partial class ChangeOrderListRequest :  IEquatable<ChangeOrderListRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOrderListRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeOrderListRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOrderListRequest" /> class.
        /// </summary>
        /// <param name="ChangeOrders">The change order operations (required).</param>
        public ChangeOrderListRequest(List<ChangeOrderListRequestItem> ChangeOrders = default(List<ChangeOrderListRequestItem>))
        {
            // to ensure "ChangeOrders" is required (not null)
            if (ChangeOrders == null)
            {
                throw new InvalidDataException("ChangeOrders is a required property for ChangeOrderListRequest and cannot be null");
            }
            else
            {
                this.ChangeOrders = ChangeOrders;
            }
        }
        
        /// <summary>
        /// The change order operations
        /// </summary>
        /// <value>The change order operations</value>
        [DataMember(Name="changeOrders", EmitDefaultValue=false)]
        public List<ChangeOrderListRequestItem> ChangeOrders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeOrderListRequest {\n");
            sb.Append("  ChangeOrders: ").Append(ChangeOrders).Append("\n");
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
            return this.Equals(obj as ChangeOrderListRequest);
        }

        /// <summary>
        /// Returns true if ChangeOrderListRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangeOrderListRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeOrderListRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChangeOrders == other.ChangeOrders ||
                    this.ChangeOrders != null &&
                    this.ChangeOrders.SequenceEqual(other.ChangeOrders)
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
                if (this.ChangeOrders != null)
                    hash = hash * 59 + this.ChangeOrders.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
