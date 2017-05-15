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
    /// The optimisation action
    /// </summary>
    /// <value>The optimisation action</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OptimisationActionName
    {
        
        /// <summary>
        /// Enum Reenable for "reenable"
        /// </summary>
        [EnumMember(Value = "reenable")]
        Reenable,
        
        /// <summary>
        /// Enum Disable for "disable"
        /// </summary>
        [EnumMember(Value = "disable")]
        Disable
    }

}
