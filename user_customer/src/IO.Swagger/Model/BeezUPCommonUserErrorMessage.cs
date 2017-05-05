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
    /// BeezUPCommonUserErrorMessage
    /// </summary>
    [DataContract]
    public partial class BeezUPCommonUserErrorMessage :  IEquatable<BeezUPCommonUserErrorMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonUserErrorMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BeezUPCommonUserErrorMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BeezUPCommonUserErrorMessage" /> class.
        /// </summary>
        /// <param name="DocUrl">DocUrl.</param>
        /// <param name="Code">the error code. The error code can be a pattern containing the argument&#39;s name (required).</param>
        /// <param name="Message">The error message (required).</param>
        /// <param name="CultureName">If the error is translated, the culture name will be indicated.</param>
        /// <param name="Arguments">a dictionary string/object.</param>
        public BeezUPCommonUserErrorMessage(BeezUPCommonDocUrl DocUrl = default(BeezUPCommonDocUrl), string Code = default(string), string Message = default(string), string CultureName = default(string), List<BeezUPCommonUserErrorMessageArguments> Arguments = default(List<BeezUPCommonUserErrorMessageArguments>))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for BeezUPCommonUserErrorMessage and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for BeezUPCommonUserErrorMessage and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            this.DocUrl = DocUrl;
            this.CultureName = CultureName;
            this.Arguments = Arguments;
        }
        
        /// <summary>
        /// Gets or Sets DocUrl
        /// </summary>
        [DataMember(Name="docUrl", EmitDefaultValue=false)]
        public BeezUPCommonDocUrl DocUrl { get; set; }
        /// <summary>
        /// the error code. The error code can be a pattern containing the argument&#39;s name
        /// </summary>
        /// <value>the error code. The error code can be a pattern containing the argument&#39;s name</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// The error message
        /// </summary>
        /// <value>The error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// If the error is translated, the culture name will be indicated
        /// </summary>
        /// <value>If the error is translated, the culture name will be indicated</value>
        [DataMember(Name="cultureName", EmitDefaultValue=false)]
        public string CultureName { get; set; }
        /// <summary>
        /// a dictionary string/object
        /// </summary>
        /// <value>a dictionary string/object</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public List<BeezUPCommonUserErrorMessageArguments> Arguments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeezUPCommonUserErrorMessage {\n");
            sb.Append("  DocUrl: ").Append(DocUrl).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(obj as BeezUPCommonUserErrorMessage);
        }

        /// <summary>
        /// Returns true if BeezUPCommonUserErrorMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of BeezUPCommonUserErrorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeezUPCommonUserErrorMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocUrl == other.DocUrl ||
                    this.DocUrl != null &&
                    this.DocUrl.Equals(other.DocUrl)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.CultureName == other.CultureName ||
                    this.CultureName != null &&
                    this.CultureName.Equals(other.CultureName)
                ) && 
                (
                    this.Arguments == other.Arguments ||
                    this.Arguments != null &&
                    this.Arguments.SequenceEqual(other.Arguments)
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
                if (this.DocUrl != null)
                    hash = hash * 59 + this.DocUrl.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.CultureName != null)
                    hash = hash * 59 + this.CultureName.GetHashCode();
                if (this.Arguments != null)
                    hash = hash * 59 + this.Arguments.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
