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
    /// The message request to schedule the auto import
    /// </summary>
    [DataContract]
    public partial class ScheduleAutoImportRequest :  IEquatable<ScheduleAutoImportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleAutoImportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleAutoImportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleAutoImportRequest" /> class.
        /// </summary>
        /// <param name="Schedules">Indicate the time span you want to import your catalog. (i.e. \&quot;21:00:00\&quot; to import your catalog at 9PM) (required).</param>
        /// <param name="LocalTimeZoneName">If null the local time zone name will be \&quot;Romance Standard Time\&quot; (default to &quot;Romance Standard Time&quot;).</param>
        public ScheduleAutoImportRequest(List<string> Schedules = default(List<string>), string LocalTimeZoneName = "Romance Standard Time")
        {
            // to ensure "Schedules" is required (not null)
            if (Schedules == null)
            {
                throw new InvalidDataException("Schedules is a required property for ScheduleAutoImportRequest and cannot be null");
            }
            else
            {
                this.Schedules = Schedules;
            }
            // use default value if no "LocalTimeZoneName" provided
            if (LocalTimeZoneName == null)
            {
                this.LocalTimeZoneName = "Romance Standard Time";
            }
            else
            {
                this.LocalTimeZoneName = LocalTimeZoneName;
            }
        }
        
        /// <summary>
        /// Indicate the time span you want to import your catalog. (i.e. \&quot;21:00:00\&quot; to import your catalog at 9PM)
        /// </summary>
        /// <value>Indicate the time span you want to import your catalog. (i.e. \&quot;21:00:00\&quot; to import your catalog at 9PM)</value>
        [DataMember(Name="schedules", EmitDefaultValue=false)]
        public List<string> Schedules { get; set; }
        /// <summary>
        /// If null the local time zone name will be \&quot;Romance Standard Time\&quot;
        /// </summary>
        /// <value>If null the local time zone name will be \&quot;Romance Standard Time\&quot;</value>
        [DataMember(Name="localTimeZoneName", EmitDefaultValue=false)]
        public string LocalTimeZoneName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleAutoImportRequest {\n");
            sb.Append("  Schedules: ").Append(Schedules).Append("\n");
            sb.Append("  LocalTimeZoneName: ").Append(LocalTimeZoneName).Append("\n");
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
            return this.Equals(obj as ScheduleAutoImportRequest);
        }

        /// <summary>
        /// Returns true if ScheduleAutoImportRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleAutoImportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleAutoImportRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Schedules == other.Schedules ||
                    this.Schedules != null &&
                    this.Schedules.SequenceEqual(other.Schedules)
                ) && 
                (
                    this.LocalTimeZoneName == other.LocalTimeZoneName ||
                    this.LocalTimeZoneName != null &&
                    this.LocalTimeZoneName.Equals(other.LocalTimeZoneName)
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
                if (this.Schedules != null)
                    hash = hash * 59 + this.Schedules.GetHashCode();
                if (this.LocalTimeZoneName != null)
                    hash = hash * 59 + this.LocalTimeZoneName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
