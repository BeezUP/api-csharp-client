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
    /// StandardOffer
    /// </summary>
    [DataContract]
    public partial class StandardOffer :  IEquatable<StandardOffer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardOffer" /> class.
        /// </summary>
        /// <param name="AdditionalClickPrice">The additional click price.</param>
        /// <param name="IncludedClick">The included click.</param>
        /// <param name="IsMostPopular">UI purpose. Is the offer is the most popular.</param>
        /// <param name="IsOldOffer">Is an old offer.</param>
        /// <param name="Name">The offer name.</param>
        /// <param name="OfferId">The offer Id.</param>
        /// <param name="FixedPrice">The fixed price of the offer.</param>
        /// <param name="CurrencyCode">CurrencyCode.</param>
        /// <param name="Position">UI purpose. The position of the offer.</param>
        /// <param name="Functionalities">Functionalities.</param>
        public StandardOffer(double? AdditionalClickPrice = default(double?), int? IncludedClick = default(int?), bool? IsMostPopular = default(bool?), bool? IsOldOffer = default(bool?), string Name = default(string), int? OfferId = default(int?), double? FixedPrice = default(double?), BeezUPCommonCurrencyCode CurrencyCode = default(BeezUPCommonCurrencyCode), int? Position = default(int?), List<OfferFunctionality> Functionalities = default(List<OfferFunctionality>))
        {
            this.AdditionalClickPrice = AdditionalClickPrice;
            this.IncludedClick = IncludedClick;
            this.IsMostPopular = IsMostPopular;
            this.IsOldOffer = IsOldOffer;
            this.Name = Name;
            this.OfferId = OfferId;
            this.FixedPrice = FixedPrice;
            this.CurrencyCode = CurrencyCode;
            this.Position = Position;
            this.Functionalities = Functionalities;
        }
        
        /// <summary>
        /// The additional click price
        /// </summary>
        /// <value>The additional click price</value>
        [DataMember(Name="additionalClickPrice", EmitDefaultValue=false)]
        public double? AdditionalClickPrice { get; set; }
        /// <summary>
        /// The included click
        /// </summary>
        /// <value>The included click</value>
        [DataMember(Name="includedClick", EmitDefaultValue=false)]
        public int? IncludedClick { get; set; }
        /// <summary>
        /// UI purpose. Is the offer is the most popular
        /// </summary>
        /// <value>UI purpose. Is the offer is the most popular</value>
        [DataMember(Name="isMostPopular", EmitDefaultValue=false)]
        public bool? IsMostPopular { get; set; }
        /// <summary>
        /// Is an old offer
        /// </summary>
        /// <value>Is an old offer</value>
        [DataMember(Name="isOldOffer", EmitDefaultValue=false)]
        public bool? IsOldOffer { get; set; }
        /// <summary>
        /// The offer name
        /// </summary>
        /// <value>The offer name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The offer Id
        /// </summary>
        /// <value>The offer Id</value>
        [DataMember(Name="offerId", EmitDefaultValue=false)]
        public int? OfferId { get; set; }
        /// <summary>
        /// The fixed price of the offer
        /// </summary>
        /// <value>The fixed price of the offer</value>
        [DataMember(Name="fixedPrice", EmitDefaultValue=false)]
        public double? FixedPrice { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public BeezUPCommonCurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// UI purpose. The position of the offer
        /// </summary>
        /// <value>UI purpose. The position of the offer</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }
        /// <summary>
        /// Gets or Sets Functionalities
        /// </summary>
        [DataMember(Name="functionalities", EmitDefaultValue=false)]
        public List<OfferFunctionality> Functionalities { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardOffer {\n");
            sb.Append("  AdditionalClickPrice: ").Append(AdditionalClickPrice).Append("\n");
            sb.Append("  IncludedClick: ").Append(IncludedClick).Append("\n");
            sb.Append("  IsMostPopular: ").Append(IsMostPopular).Append("\n");
            sb.Append("  IsOldOffer: ").Append(IsOldOffer).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OfferId: ").Append(OfferId).Append("\n");
            sb.Append("  FixedPrice: ").Append(FixedPrice).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Functionalities: ").Append(Functionalities).Append("\n");
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
            return this.Equals(obj as StandardOffer);
        }

        /// <summary>
        /// Returns true if StandardOffer instances are equal
        /// </summary>
        /// <param name="other">Instance of StandardOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardOffer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdditionalClickPrice == other.AdditionalClickPrice ||
                    this.AdditionalClickPrice != null &&
                    this.AdditionalClickPrice.Equals(other.AdditionalClickPrice)
                ) && 
                (
                    this.IncludedClick == other.IncludedClick ||
                    this.IncludedClick != null &&
                    this.IncludedClick.Equals(other.IncludedClick)
                ) && 
                (
                    this.IsMostPopular == other.IsMostPopular ||
                    this.IsMostPopular != null &&
                    this.IsMostPopular.Equals(other.IsMostPopular)
                ) && 
                (
                    this.IsOldOffer == other.IsOldOffer ||
                    this.IsOldOffer != null &&
                    this.IsOldOffer.Equals(other.IsOldOffer)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OfferId == other.OfferId ||
                    this.OfferId != null &&
                    this.OfferId.Equals(other.OfferId)
                ) && 
                (
                    this.FixedPrice == other.FixedPrice ||
                    this.FixedPrice != null &&
                    this.FixedPrice.Equals(other.FixedPrice)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.Functionalities == other.Functionalities ||
                    this.Functionalities != null &&
                    this.Functionalities.SequenceEqual(other.Functionalities)
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
                if (this.AdditionalClickPrice != null)
                    hash = hash * 59 + this.AdditionalClickPrice.GetHashCode();
                if (this.IncludedClick != null)
                    hash = hash * 59 + this.IncludedClick.GetHashCode();
                if (this.IsMostPopular != null)
                    hash = hash * 59 + this.IsMostPopular.GetHashCode();
                if (this.IsOldOffer != null)
                    hash = hash * 59 + this.IsOldOffer.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OfferId != null)
                    hash = hash * 59 + this.OfferId.GetHashCode();
                if (this.FixedPrice != null)
                    hash = hash * 59 + this.FixedPrice.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.Functionalities != null)
                    hash = hash * 59 + this.Functionalities.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
