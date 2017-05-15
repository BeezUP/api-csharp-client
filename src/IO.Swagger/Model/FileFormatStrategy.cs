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
    /// CSV or XML
    /// </summary>
    /// <value>CSV or XML</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FileFormatStrategy
    {
        
        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        
        /// <summary>
        /// Enum Csv for "Csv"
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv,
        
        /// <summary>
        /// Enum Xml for "Xml"
        /// </summary>
        [EnumMember(Value = "Xml")]
        Xml,
        
        /// <summary>
        /// Enum Json for "Json"
        /// </summary>
        [EnumMember(Value = "Json")]
        Json
    }

}
