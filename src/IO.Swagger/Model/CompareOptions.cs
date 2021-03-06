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
    /// Indicate how the product sku are compared for the duplication check.
    /// </summary>
    /// <value>Indicate how the product sku are compared for the duplication check.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompareOptions
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum IgnoreCase for "IgnoreCase"
        /// </summary>
        [EnumMember(Value = "IgnoreCase")]
        IgnoreCase,
        
        /// <summary>
        /// Enum IgnoreNonSpace for "IgnoreNonSpace"
        /// </summary>
        [EnumMember(Value = "IgnoreNonSpace")]
        IgnoreNonSpace,
        
        /// <summary>
        /// Enum IgnoreSymbols for "IgnoreSymbols"
        /// </summary>
        [EnumMember(Value = "IgnoreSymbols")]
        IgnoreSymbols,
        
        /// <summary>
        /// Enum OrdinalIgnoreCase for "OrdinalIgnoreCase"
        /// </summary>
        [EnumMember(Value = "OrdinalIgnoreCase")]
        OrdinalIgnoreCase,
        
        /// <summary>
        /// Enum StringSort for "StringSort"
        /// </summary>
        [EnumMember(Value = "StringSort")]
        StringSort,
        
        /// <summary>
        /// Enum Ordinal for "Ordinal"
        /// </summary>
        [EnumMember(Value = "Ordinal")]
        Ordinal
    }

}
