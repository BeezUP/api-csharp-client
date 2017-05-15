/* 
 * Public - Security
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
    /// Defines orderExportationReportingProcessingStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderExportationReportingProcessingStatus
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum InProgress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress,
        
        /// <summary>
        /// Enum Done for "Done"
        /// </summary>
        [EnumMember(Value = "Done")]
        Done,
        
        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,
        
        /// <summary>
        /// Enum AlreadyInProgress for "AlreadyInProgress"
        /// </summary>
        [EnumMember(Value = "AlreadyInProgress")]
        AlreadyInProgress,
        
        /// <summary>
        /// Enum Aborted for "Aborted"
        /// </summary>
        [EnumMember(Value = "Aborted")]
        Aborted,
        
        /// <summary>
        /// Enum Suspended for "Suspended"
        /// </summary>
        [EnumMember(Value = "Suspended")]
        Suspended
    }

}
