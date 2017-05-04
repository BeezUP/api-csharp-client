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
    /// CreditCardInfoWithCardType
    /// </summary>
    [DataContract]
    public partial class CreditCardInfoWithCardType :  IEquatable<CreditCardInfoWithCardType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardInfoWithCardType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditCardInfoWithCardType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardInfoWithCardType" /> class.
        /// </summary>
        /// <param name="CardNumber">CardNumber (required).</param>
        /// <param name="CardVerificationCode">CardVerificationCode.</param>
        /// <param name="ExpirationMonth">ExpirationMonth (required).</param>
        /// <param name="ExpirationYear">ExpirationYear (required).</param>
        /// <param name="CardType">Your credit card type. Example: VISA, MasterCard, etc... (required).</param>
        public CreditCardInfoWithCardType(CardNumber CardNumber = default(CardNumber), CardVerificationCode CardVerificationCode = default(CardVerificationCode), ExpirationMonth ExpirationMonth = default(ExpirationMonth), ExpirationYear ExpirationYear = default(ExpirationYear), string CardType = default(string))
        {
            // to ensure "CardNumber" is required (not null)
            if (CardNumber == null)
            {
                throw new InvalidDataException("CardNumber is a required property for CreditCardInfoWithCardType and cannot be null");
            }
            else
            {
                this.CardNumber = CardNumber;
            }
            // to ensure "ExpirationMonth" is required (not null)
            if (ExpirationMonth == null)
            {
                throw new InvalidDataException("ExpirationMonth is a required property for CreditCardInfoWithCardType and cannot be null");
            }
            else
            {
                this.ExpirationMonth = ExpirationMonth;
            }
            // to ensure "ExpirationYear" is required (not null)
            if (ExpirationYear == null)
            {
                throw new InvalidDataException("ExpirationYear is a required property for CreditCardInfoWithCardType and cannot be null");
            }
            else
            {
                this.ExpirationYear = ExpirationYear;
            }
            // to ensure "CardType" is required (not null)
            if (CardType == null)
            {
                throw new InvalidDataException("CardType is a required property for CreditCardInfoWithCardType and cannot be null");
            }
            else
            {
                this.CardType = CardType;
            }
            this.CardVerificationCode = CardVerificationCode;
        }
        
        /// <summary>
        /// Gets or Sets CardNumber
        /// </summary>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public CardNumber CardNumber { get; set; }
        /// <summary>
        /// Gets or Sets CardVerificationCode
        /// </summary>
        [DataMember(Name="cardVerificationCode", EmitDefaultValue=false)]
        public CardVerificationCode CardVerificationCode { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationMonth
        /// </summary>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public ExpirationMonth ExpirationMonth { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationYear
        /// </summary>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public ExpirationYear ExpirationYear { get; set; }
        /// <summary>
        /// Your credit card type. Example: VISA, MasterCard, etc...
        /// </summary>
        /// <value>Your credit card type. Example: VISA, MasterCard, etc...</value>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public string CardType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardInfoWithCardType {\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardVerificationCode: ").Append(CardVerificationCode).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
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
            return this.Equals(obj as CreditCardInfoWithCardType);
        }

        /// <summary>
        /// Returns true if CreditCardInfoWithCardType instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCardInfoWithCardType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardInfoWithCardType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardNumber == other.CardNumber ||
                    this.CardNumber != null &&
                    this.CardNumber.Equals(other.CardNumber)
                ) && 
                (
                    this.CardVerificationCode == other.CardVerificationCode ||
                    this.CardVerificationCode != null &&
                    this.CardVerificationCode.Equals(other.CardVerificationCode)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
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
                if (this.CardNumber != null)
                    hash = hash * 59 + this.CardNumber.GetHashCode();
                if (this.CardVerificationCode != null)
                    hash = hash * 59 + this.CardVerificationCode.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
