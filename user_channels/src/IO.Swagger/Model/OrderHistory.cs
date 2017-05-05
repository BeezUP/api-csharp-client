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
    /// Describe the history related to an order
    /// </summary>
    [DataContract]
    public partial class OrderHistory :  IEquatable<OrderHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderHistory" /> class.
        /// </summary>
        /// <param name="ChangeOrderReportings">The list of change order operation.</param>
        /// <param name="HarvestOrderReportings">HarvestOrderReportings.</param>
        /// <param name="LastModificationUtcDate">LastModificationUtcDate.</param>
        /// <param name="Info">Info.</param>
        public OrderHistory(List<ChangeOrderReporting> ChangeOrderReportings = default(List<ChangeOrderReporting>), List<HarvestOrderReporting> HarvestOrderReportings = default(List<HarvestOrderReporting>), DateTime? LastModificationUtcDate = default(DateTime?), BeezUPCommonInfoSummaries Info = default(BeezUPCommonInfoSummaries))
        {
            this.ChangeOrderReportings = ChangeOrderReportings;
            this.HarvestOrderReportings = HarvestOrderReportings;
            this.LastModificationUtcDate = LastModificationUtcDate;
            this.Info = Info;
        }
        
        /// <summary>
        /// The list of change order operation
        /// </summary>
        /// <value>The list of change order operation</value>
        [DataMember(Name="changeOrderReportings", EmitDefaultValue=false)]
        public List<ChangeOrderReporting> ChangeOrderReportings { get; set; }
        /// <summary>
        /// Gets or Sets HarvestOrderReportings
        /// </summary>
        [DataMember(Name="harvestOrderReportings", EmitDefaultValue=false)]
        public List<HarvestOrderReporting> HarvestOrderReportings { get; set; }
        /// <summary>
        /// Gets or Sets LastModificationUtcDate
        /// </summary>
        [DataMember(Name="lastModificationUtcDate", EmitDefaultValue=false)]
        public DateTime? LastModificationUtcDate { get; set; }
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
            sb.Append("class OrderHistory {\n");
            sb.Append("  ChangeOrderReportings: ").Append(ChangeOrderReportings).Append("\n");
            sb.Append("  HarvestOrderReportings: ").Append(HarvestOrderReportings).Append("\n");
            sb.Append("  LastModificationUtcDate: ").Append(LastModificationUtcDate).Append("\n");
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
            return this.Equals(obj as OrderHistory);
        }

        /// <summary>
        /// Returns true if OrderHistory instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderHistory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChangeOrderReportings == other.ChangeOrderReportings ||
                    this.ChangeOrderReportings != null &&
                    this.ChangeOrderReportings.SequenceEqual(other.ChangeOrderReportings)
                ) && 
                (
                    this.HarvestOrderReportings == other.HarvestOrderReportings ||
                    this.HarvestOrderReportings != null &&
                    this.HarvestOrderReportings.SequenceEqual(other.HarvestOrderReportings)
                ) && 
                (
                    this.LastModificationUtcDate == other.LastModificationUtcDate ||
                    this.LastModificationUtcDate != null &&
                    this.LastModificationUtcDate.Equals(other.LastModificationUtcDate)
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
                if (this.ChangeOrderReportings != null)
                    hash = hash * 59 + this.ChangeOrderReportings.GetHashCode();
                if (this.HarvestOrderReportings != null)
                    hash = hash * 59 + this.HarvestOrderReportings.GetHashCode();
                if (this.LastModificationUtcDate != null)
                    hash = hash * 59 + this.LastModificationUtcDate.GetHashCode();
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
