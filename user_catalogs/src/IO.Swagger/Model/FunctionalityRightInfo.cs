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
    /// Describe the rights for a functionality
    /// </summary>
    [DataContract]
    public partial class FunctionalityRightInfo :  IEquatable<FunctionalityRightInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionalityRightInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FunctionalityRightInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionalityRightInfo" /> class.
        /// </summary>
        /// <param name="FunctionalityCode">The functionality code (required).</param>
        /// <param name="MaxValueInterger">The max value for this functionality code considering your rights.</param>
        /// <param name="Unlimited">If you can use this functionality unlimitedly.</param>
        public FunctionalityRightInfo(string FunctionalityCode = default(string), int? MaxValueInterger = default(int?), bool? Unlimited = default(bool?))
        {
            // to ensure "FunctionalityCode" is required (not null)
            if (FunctionalityCode == null)
            {
                throw new InvalidDataException("FunctionalityCode is a required property for FunctionalityRightInfo and cannot be null");
            }
            else
            {
                this.FunctionalityCode = FunctionalityCode;
            }
            this.MaxValueInterger = MaxValueInterger;
            this.Unlimited = Unlimited;
        }
        
        /// <summary>
        /// The functionality code
        /// </summary>
        /// <value>The functionality code</value>
        [DataMember(Name="functionalityCode", EmitDefaultValue=false)]
        public string FunctionalityCode { get; set; }
        /// <summary>
        /// The max value for this functionality code considering your rights
        /// </summary>
        /// <value>The max value for this functionality code considering your rights</value>
        [DataMember(Name="maxValueInterger", EmitDefaultValue=false)]
        public int? MaxValueInterger { get; set; }
        /// <summary>
        /// If you can use this functionality unlimitedly
        /// </summary>
        /// <value>If you can use this functionality unlimitedly</value>
        [DataMember(Name="unlimited", EmitDefaultValue=false)]
        public bool? Unlimited { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionalityRightInfo {\n");
            sb.Append("  FunctionalityCode: ").Append(FunctionalityCode).Append("\n");
            sb.Append("  MaxValueInterger: ").Append(MaxValueInterger).Append("\n");
            sb.Append("  Unlimited: ").Append(Unlimited).Append("\n");
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
            return this.Equals(obj as FunctionalityRightInfo);
        }

        /// <summary>
        /// Returns true if FunctionalityRightInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of FunctionalityRightInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FunctionalityRightInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FunctionalityCode == other.FunctionalityCode ||
                    this.FunctionalityCode != null &&
                    this.FunctionalityCode.Equals(other.FunctionalityCode)
                ) && 
                (
                    this.MaxValueInterger == other.MaxValueInterger ||
                    this.MaxValueInterger != null &&
                    this.MaxValueInterger.Equals(other.MaxValueInterger)
                ) && 
                (
                    this.Unlimited == other.Unlimited ||
                    this.Unlimited != null &&
                    this.Unlimited.Equals(other.Unlimited)
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
                if (this.FunctionalityCode != null)
                    hash = hash * 59 + this.FunctionalityCode.GetHashCode();
                if (this.MaxValueInterger != null)
                    hash = hash * 59 + this.MaxValueInterger.GetHashCode();
                if (this.Unlimited != null)
                    hash = hash * 59 + this.Unlimited.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
