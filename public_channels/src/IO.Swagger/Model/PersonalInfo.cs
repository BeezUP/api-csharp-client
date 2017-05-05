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
    /// PersonalInfo
    /// </summary>
    [DataContract]
    public partial class PersonalInfo :  IEquatable<PersonalInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PersonalInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalInfo" /> class.
        /// </summary>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="PhoneNumber">PhoneNumber (required).</param>
        /// <param name="WhatIDo">WhatIDo.</param>
        /// <param name="BeezUPTimeZoneId">BeezUPTimeZoneId (required).</param>
        public PersonalInfo(LastName LastName = default(LastName), FirstName FirstName = default(FirstName), PhoneNumber PhoneNumber = default(PhoneNumber), WhatIDo WhatIDo = default(WhatIDo), BeezUPTimeZoneId BeezUPTimeZoneId = default(BeezUPTimeZoneId))
        {
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for PersonalInfo and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for PersonalInfo and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for PersonalInfo and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            // to ensure "BeezUPTimeZoneId" is required (not null)
            if (BeezUPTimeZoneId == null)
            {
                throw new InvalidDataException("BeezUPTimeZoneId is a required property for PersonalInfo and cannot be null");
            }
            else
            {
                this.BeezUPTimeZoneId = BeezUPTimeZoneId;
            }
            this.WhatIDo = WhatIDo;
        }
        
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public LastName LastName { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public FirstName FirstName { get; set; }
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public PhoneNumber PhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets WhatIDo
        /// </summary>
        [DataMember(Name="whatIDo", EmitDefaultValue=false)]
        public WhatIDo WhatIDo { get; set; }
        /// <summary>
        /// Gets or Sets BeezUPTimeZoneId
        /// </summary>
        [DataMember(Name="beezUPTimeZoneId", EmitDefaultValue=false)]
        public BeezUPTimeZoneId BeezUPTimeZoneId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalInfo {\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  WhatIDo: ").Append(WhatIDo).Append("\n");
            sb.Append("  BeezUPTimeZoneId: ").Append(BeezUPTimeZoneId).Append("\n");
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
            return this.Equals(obj as PersonalInfo);
        }

        /// <summary>
        /// Returns true if PersonalInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.WhatIDo == other.WhatIDo ||
                    this.WhatIDo != null &&
                    this.WhatIDo.Equals(other.WhatIDo)
                ) && 
                (
                    this.BeezUPTimeZoneId == other.BeezUPTimeZoneId ||
                    this.BeezUPTimeZoneId != null &&
                    this.BeezUPTimeZoneId.Equals(other.BeezUPTimeZoneId)
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
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.WhatIDo != null)
                    hash = hash * 59 + this.WhatIDo.GetHashCode();
                if (this.BeezUPTimeZoneId != null)
                    hash = hash * 59 + this.BeezUPTimeZoneId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
