/* 
 * BeezUP API
 *
 * # The REST API of BeezUP system ## Overview The REST APIs provide programmatic access to read and write BeezUP data.  Basically, with this API you will be able to do everything like you were with your browser on https://go.beezup.com !  The main features are: - Register and manage your account - Create and manage and share your stores with your friends/co-workers. - Import your product catalog and schedule the auto importation - Search the channels your want to use - Configure your channels for your catalogs to export your product information:     - cost and general settings     - category and columns mappings     - your will be able to create and manage your custom column     - put in place exlusion filters based on simple conditions on your product data     - override product values     - get product vision for a channel catalog scope - Analyze and optimize your performance of your catalogs on all yours channels with different type of reportings by day, channel, category and by product. - Automatize your optimisation by using rules! - And of course... Manage your orders harvested from all your marketplaces:     - Synchronize your orders in an uniformized way     - Get the available actions and update the order status - ...and more!  ## Authentication credentials The public API with the base path **_/v2/public** have been put in place to give you an entry point to our system for the user registration, login and lost password. The public API does not require any credentials. We give you the some public list of values and public channels for our public commercial web site [www.beezup.com](http://www.beezup.com).  The user API with the base path **_/v2/user** requires a token which is available on this page: https://go.beezup.com/Account/MyAccount  ## Things to keep in mind ### API Rate Limits - The BeezUP REST API is limited to 100 calls/minute.  ### Media type The default media type for requests and responses is application/json. Where noted, some operations support other content types. If no additional content type is mentioned for a specific operation, then the media type is application/json.  ### Required content type The required and default encoding for the request and responses is UTF8.  ### Required date time format All our date time are formatted in ISO 8601 format: 2014-06-24T16:25:00Z.  ### Base URL The Base URL of the BeezUP API Order Management REST API conforms to the following template.  https://api.beezup.com  All URLs returned by the BeezUP API are relative to this base URL, and all requests to the REST API must use this base URL template.  You can test our API on https://api-docs.beezup.com/swagger-ui\\ You can contact us on [gitter, #BeezUP/API](https://gitter.im/beezUP/API) 
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
    /// The KPI formula
    /// </summary>
    [DataContract]
    public partial class PerformanceIndicatorFormula :  IEquatable<PerformanceIndicatorFormula>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceIndicatorFormula" /> class.
        /// </summary>
        /// <param name="FirstParameter">FirstParameter.</param>
        /// <param name="OperatorName">OperatorName.</param>
        /// <param name="SecondParameter">SecondParameter.</param>
        /// <param name="ThirdParameter">Indicate the value of the third parameter of your formula.</param>
        public PerformanceIndicatorFormula(PerformanceIndicatorFormulaParameterType FirstParameter = default(PerformanceIndicatorFormulaParameterType), PerformanceIndicatorFormulaOperatorName OperatorName = default(PerformanceIndicatorFormulaOperatorName), PerformanceIndicatorFormulaParameterType SecondParameter = default(PerformanceIndicatorFormulaParameterType), int? ThirdParameter = default(int?))
        {
            this.FirstParameter = FirstParameter;
            this.OperatorName = OperatorName;
            this.SecondParameter = SecondParameter;
            this.ThirdParameter = ThirdParameter;
        }
        
        /// <summary>
        /// Gets or Sets FirstParameter
        /// </summary>
        [DataMember(Name="firstParameter", EmitDefaultValue=false)]
        public PerformanceIndicatorFormulaParameterType FirstParameter { get; set; }
        /// <summary>
        /// Gets or Sets OperatorName
        /// </summary>
        [DataMember(Name="operatorName", EmitDefaultValue=false)]
        public PerformanceIndicatorFormulaOperatorName OperatorName { get; set; }
        /// <summary>
        /// Gets or Sets SecondParameter
        /// </summary>
        [DataMember(Name="secondParameter", EmitDefaultValue=false)]
        public PerformanceIndicatorFormulaParameterType SecondParameter { get; set; }
        /// <summary>
        /// Indicate the value of the third parameter of your formula
        /// </summary>
        /// <value>Indicate the value of the third parameter of your formula</value>
        [DataMember(Name="thirdParameter", EmitDefaultValue=false)]
        public int? ThirdParameter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceIndicatorFormula {\n");
            sb.Append("  FirstParameter: ").Append(FirstParameter).Append("\n");
            sb.Append("  OperatorName: ").Append(OperatorName).Append("\n");
            sb.Append("  SecondParameter: ").Append(SecondParameter).Append("\n");
            sb.Append("  ThirdParameter: ").Append(ThirdParameter).Append("\n");
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
            return this.Equals(obj as PerformanceIndicatorFormula);
        }

        /// <summary>
        /// Returns true if PerformanceIndicatorFormula instances are equal
        /// </summary>
        /// <param name="other">Instance of PerformanceIndicatorFormula to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceIndicatorFormula other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstParameter == other.FirstParameter ||
                    this.FirstParameter != null &&
                    this.FirstParameter.Equals(other.FirstParameter)
                ) && 
                (
                    this.OperatorName == other.OperatorName ||
                    this.OperatorName != null &&
                    this.OperatorName.Equals(other.OperatorName)
                ) && 
                (
                    this.SecondParameter == other.SecondParameter ||
                    this.SecondParameter != null &&
                    this.SecondParameter.Equals(other.SecondParameter)
                ) && 
                (
                    this.ThirdParameter == other.ThirdParameter ||
                    this.ThirdParameter != null &&
                    this.ThirdParameter.Equals(other.ThirdParameter)
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
                if (this.FirstParameter != null)
                    hash = hash * 59 + this.FirstParameter.GetHashCode();
                if (this.OperatorName != null)
                    hash = hash * 59 + this.OperatorName.GetHashCode();
                if (this.SecondParameter != null)
                    hash = hash * 59 + this.SecondParameter.GetHashCode();
                if (this.ThirdParameter != null)
                    hash = hash * 59 + this.ThirdParameter.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
