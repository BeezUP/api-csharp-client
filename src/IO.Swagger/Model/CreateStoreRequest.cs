/* 
 * BeezUP API
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
    /// CreateStoreRequest
    /// </summary>
    [DataContract]
    public partial class CreateStoreRequest :  IEquatable<CreateStoreRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStoreRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateStoreRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStoreRequest" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Url">Url (required).</param>
        /// <param name="CountryIsoCodeAlpha3">CountryIsoCodeAlpha3 (required).</param>
        /// <param name="Sectors">Sectors (required).</param>
        public CreateStoreRequest(StoreName Name = default(StoreName), StoreUrl Url = default(StoreUrl), StoreCountryIsoCodeAlpha3 CountryIsoCodeAlpha3 = default(StoreCountryIsoCodeAlpha3), StoreSectors Sectors = default(StoreSectors))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateStoreRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for CreateStoreRequest and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "CountryIsoCodeAlpha3" is required (not null)
            if (CountryIsoCodeAlpha3 == null)
            {
                throw new InvalidDataException("CountryIsoCodeAlpha3 is a required property for CreateStoreRequest and cannot be null");
            }
            else
            {
                this.CountryIsoCodeAlpha3 = CountryIsoCodeAlpha3;
            }
            // to ensure "Sectors" is required (not null)
            if (Sectors == null)
            {
                throw new InvalidDataException("Sectors is a required property for CreateStoreRequest and cannot be null");
            }
            else
            {
                this.Sectors = Sectors;
            }
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public StoreName Name { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public StoreUrl Url { get; set; }
        /// <summary>
        /// Gets or Sets CountryIsoCodeAlpha3
        /// </summary>
        [DataMember(Name="countryIsoCodeAlpha3", EmitDefaultValue=false)]
        public StoreCountryIsoCodeAlpha3 CountryIsoCodeAlpha3 { get; set; }
        /// <summary>
        /// Gets or Sets Sectors
        /// </summary>
        [DataMember(Name="sectors", EmitDefaultValue=false)]
        public StoreSectors Sectors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStoreRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CountryIsoCodeAlpha3: ").Append(CountryIsoCodeAlpha3).Append("\n");
            sb.Append("  Sectors: ").Append(Sectors).Append("\n");
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
            return this.Equals(obj as CreateStoreRequest);
        }

        /// <summary>
        /// Returns true if CreateStoreRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateStoreRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateStoreRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.CountryIsoCodeAlpha3 == other.CountryIsoCodeAlpha3 ||
                    this.CountryIsoCodeAlpha3 != null &&
                    this.CountryIsoCodeAlpha3.Equals(other.CountryIsoCodeAlpha3)
                ) && 
                (
                    this.Sectors == other.Sectors ||
                    this.Sectors != null &&
                    this.Sectors.Equals(other.Sectors)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.CountryIsoCodeAlpha3 != null)
                    hash = hash * 59 + this.CountryIsoCodeAlpha3.GetHashCode();
                if (this.Sectors != null)
                    hash = hash * 59 + this.Sectors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
