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
    /// Indicate the scheduling type. Schedule or Interval. We recommand you to use interval for a better reporting.
    /// </summary>
    /// <value>Indicate the scheduling type. Schedule or Interval. We recommand you to use interval for a better reporting.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SchedulingType
    {
        
        /// <summary>
        /// Enum Schedule for "Schedule"
        /// </summary>
        [EnumMember(Value = "Schedule")]
        Schedule,
        
        /// <summary>
        /// Enum Interval for "Interval"
        /// </summary>
        [EnumMember(Value = "Interval")]
        Interval
    }

}
