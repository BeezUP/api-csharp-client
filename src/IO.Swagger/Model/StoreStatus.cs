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
    /// The store status * Active:  When the store is active * SystemBlocked:  When the store is blocked by the system * UserBlocked: When the store is blocked on GO not on the system 
    /// </summary>
    /// <value>The store status * Active:  When the store is active * SystemBlocked:  When the store is blocked by the system * UserBlocked: When the store is blocked on GO not on the system </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StoreStatus
    {
        
        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,
        
        /// <summary>
        /// Enum SystemBlocked for "SystemBlocked"
        /// </summary>
        [EnumMember(Value = "SystemBlocked")]
        SystemBlocked,
        
        /// <summary>
        /// Enum UserBlocked for "UserBlocked"
        /// </summary>
        [EnumMember(Value = "UserBlocked")]
        UserBlocked
    }

}
