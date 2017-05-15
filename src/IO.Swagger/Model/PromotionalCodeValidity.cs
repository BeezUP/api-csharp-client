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
    /// Indicate the validaty of the discount
    /// </summary>
    /// <value>Indicate the validaty of the discount</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PromotionalCodeValidity
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Valid for "Valid"
        /// </summary>
        [EnumMember(Value = "Valid")]
        Valid,
        
        /// <summary>
        /// Enum Invalid for "Invalid"
        /// </summary>
        [EnumMember(Value = "Invalid")]
        Invalid,
        
        /// <summary>
        /// Enum ExpiredOrInactive for "ExpiredOrInactive"
        /// </summary>
        [EnumMember(Value = "ExpiredOrInactive")]
        ExpiredOrInactive
    }

}
