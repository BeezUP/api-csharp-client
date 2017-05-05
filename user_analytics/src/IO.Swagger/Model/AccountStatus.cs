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
    /// The account status * Active:  When the account is active * SystemBlocked:  When all stores on the account are blocked by the system * UserBlocked: When all stores on the account are blocked on GO not on the system 
    /// </summary>
    /// <value>The account status * Active:  When the account is active * SystemBlocked:  When all stores on the account are blocked by the system * UserBlocked: When all stores on the account are blocked on GO not on the system </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountStatus
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
