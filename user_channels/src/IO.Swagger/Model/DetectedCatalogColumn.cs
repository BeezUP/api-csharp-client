/* 
 * Catalogs
 *
 * This API allows you to manage your catalogs
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
    /// DetectedCatalogColumn
    /// </summary>
    [DataContract]
    public partial class DetectedCatalogColumn :  IEquatable<DetectedCatalogColumn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedCatalogColumn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DetectedCatalogColumn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedCatalogColumn" /> class.
        /// </summary>
        /// <param name="Ignored">IF true, the product values of this column will be not taken in account during the importation process (default to false).</param>
        /// <param name="DuplicateProductValueConfiguration">DuplicateProductValueConfiguration.</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="CatalogColumnName">CatalogColumnName (required).</param>
        /// <param name="UserColumName">UserColumName (required).</param>
        /// <param name="Configuration">Configuration (required).</param>
        /// <param name="ColumnId">ColumnId (required).</param>
        /// <param name="Detected">Indicates if the column is detected or is from the current catalog (required).</param>
        /// <param name="ExistingConfiguration">ExistingConfiguration.</param>
        public DetectedCatalogColumn(bool? Ignored = false, DuplicateProductValueConfiguration DuplicateProductValueConfiguration = default(DuplicateProductValueConfiguration), ColumnId Id = default(ColumnId), CatalogColumnName CatalogColumnName = default(CatalogColumnName), UserColumName UserColumName = default(UserColumName), ColumnConfiguration Configuration = default(ColumnConfiguration), ColumnId ColumnId = default(ColumnId), bool? Detected = default(bool?), ExistingCatalogColumnConfiguration ExistingConfiguration = default(ExistingCatalogColumnConfiguration))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for DetectedCatalogColumn and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CatalogColumnName" is required (not null)
            if (CatalogColumnName == null)
            {
                throw new InvalidDataException("CatalogColumnName is a required property for DetectedCatalogColumn and cannot be null");
            }
            else
            {
                this.CatalogColumnName = CatalogColumnName;
            }
            // to ensure "UserColumName" is required (not null)
            if (UserColumName == null)
            {
                throw new InvalidDataException("UserColumName is a required property for DetectedCatalogColumn and cannot be null");
            }
            else
            {
                this.UserColumName = UserColumName;
            }
            // to ensure "Configuration" is required (not null)
            if (Configuration == null)
            {
                throw new InvalidDataException("Configuration is a required property for DetectedCatalogColumn and cannot be null");
            }
            else
            {
                this.Configuration = Configuration;
            }
            // to ensure "ColumnId" is required (not null)
            if (ColumnId == null)
            {
                throw new InvalidDataException("ColumnId is a required property for DetectedCatalogColumn and cannot be null");
            }
            else
            {
                this.ColumnId = ColumnId;
            }
            // to ensure "Detected" is required (not null)
            if (Detected == null)
            {
                throw new InvalidDataException("Detected is a required property for DetectedCatalogColumn and cannot be null");
            }
            else
            {
                this.Detected = Detected;
            }
            // use default value if no "Ignored" provided
            if (Ignored == null)
            {
                this.Ignored = false;
            }
            else
            {
                this.Ignored = Ignored;
            }
            this.DuplicateProductValueConfiguration = DuplicateProductValueConfiguration;
            this.ExistingConfiguration = ExistingConfiguration;
        }
        
        /// <summary>
        /// IF true, the product values of this column will be not taken in account during the importation process
        /// </summary>
        /// <value>IF true, the product values of this column will be not taken in account during the importation process</value>
        [DataMember(Name="ignored", EmitDefaultValue=false)]
        public bool? Ignored { get; set; }
        /// <summary>
        /// Gets or Sets DuplicateProductValueConfiguration
        /// </summary>
        [DataMember(Name="duplicateProductValueConfiguration", EmitDefaultValue=false)]
        public DuplicateProductValueConfiguration DuplicateProductValueConfiguration { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ColumnId Id { get; set; }
        /// <summary>
        /// Gets or Sets CatalogColumnName
        /// </summary>
        [DataMember(Name="catalogColumnName", EmitDefaultValue=false)]
        public CatalogColumnName CatalogColumnName { get; set; }
        /// <summary>
        /// Gets or Sets UserColumName
        /// </summary>
        [DataMember(Name="userColumName", EmitDefaultValue=false)]
        public UserColumName UserColumName { get; set; }
        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public ColumnConfiguration Configuration { get; set; }
        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name="columnId", EmitDefaultValue=false)]
        public ColumnId ColumnId { get; set; }
        /// <summary>
        /// Indicates if the column is detected or is from the current catalog
        /// </summary>
        /// <value>Indicates if the column is detected or is from the current catalog</value>
        [DataMember(Name="detected", EmitDefaultValue=false)]
        public bool? Detected { get; set; }
        /// <summary>
        /// Gets or Sets ExistingConfiguration
        /// </summary>
        [DataMember(Name="existingConfiguration", EmitDefaultValue=false)]
        public ExistingCatalogColumnConfiguration ExistingConfiguration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedCatalogColumn {\n");
            sb.Append("  Ignored: ").Append(Ignored).Append("\n");
            sb.Append("  DuplicateProductValueConfiguration: ").Append(DuplicateProductValueConfiguration).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CatalogColumnName: ").Append(CatalogColumnName).Append("\n");
            sb.Append("  UserColumName: ").Append(UserColumName).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  Detected: ").Append(Detected).Append("\n");
            sb.Append("  ExistingConfiguration: ").Append(ExistingConfiguration).Append("\n");
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
            return this.Equals(obj as DetectedCatalogColumn);
        }

        /// <summary>
        /// Returns true if DetectedCatalogColumn instances are equal
        /// </summary>
        /// <param name="other">Instance of DetectedCatalogColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedCatalogColumn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ignored == other.Ignored ||
                    this.Ignored != null &&
                    this.Ignored.Equals(other.Ignored)
                ) && 
                (
                    this.DuplicateProductValueConfiguration == other.DuplicateProductValueConfiguration ||
                    this.DuplicateProductValueConfiguration != null &&
                    this.DuplicateProductValueConfiguration.Equals(other.DuplicateProductValueConfiguration)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CatalogColumnName == other.CatalogColumnName ||
                    this.CatalogColumnName != null &&
                    this.CatalogColumnName.Equals(other.CatalogColumnName)
                ) && 
                (
                    this.UserColumName == other.UserColumName ||
                    this.UserColumName != null &&
                    this.UserColumName.Equals(other.UserColumName)
                ) && 
                (
                    this.Configuration == other.Configuration ||
                    this.Configuration != null &&
                    this.Configuration.Equals(other.Configuration)
                ) && 
                (
                    this.ColumnId == other.ColumnId ||
                    this.ColumnId != null &&
                    this.ColumnId.Equals(other.ColumnId)
                ) && 
                (
                    this.Detected == other.Detected ||
                    this.Detected != null &&
                    this.Detected.Equals(other.Detected)
                ) && 
                (
                    this.ExistingConfiguration == other.ExistingConfiguration ||
                    this.ExistingConfiguration != null &&
                    this.ExistingConfiguration.Equals(other.ExistingConfiguration)
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
                if (this.Ignored != null)
                    hash = hash * 59 + this.Ignored.GetHashCode();
                if (this.DuplicateProductValueConfiguration != null)
                    hash = hash * 59 + this.DuplicateProductValueConfiguration.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CatalogColumnName != null)
                    hash = hash * 59 + this.CatalogColumnName.GetHashCode();
                if (this.UserColumName != null)
                    hash = hash * 59 + this.UserColumName.GetHashCode();
                if (this.Configuration != null)
                    hash = hash * 59 + this.Configuration.GetHashCode();
                if (this.ColumnId != null)
                    hash = hash * 59 + this.ColumnId.GetHashCode();
                if (this.Detected != null)
                    hash = hash * 59 + this.Detected.GetHashCode();
                if (this.ExistingConfiguration != null)
                    hash = hash * 59 + this.ExistingConfiguration.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}