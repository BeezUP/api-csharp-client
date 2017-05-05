/* 
 * Marketplaces - Channel catalogs
 *
 * This API allows you to manage your channel catalogs\\' marketplace settings and fetch your account\\'s catalog publication history
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
    /// The Data Type
    /// </summary>
    /// <value>The Data Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type
    {
        
        /// <summary>
        /// Enum String for "string"
        /// </summary>
        [EnumMember(Value = "string")]
        String,
        
        /// <summary>
        /// Enum Integer for "integer"
        /// </summary>
        [EnumMember(Value = "integer")]
        Integer,
        
        /// <summary>
        /// Enum Boolean for "boolean"
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean,
        
        /// <summary>
        /// Enum Number for "number"
        /// </summary>
        [EnumMember(Value = "number")]
        Number
    }

}
