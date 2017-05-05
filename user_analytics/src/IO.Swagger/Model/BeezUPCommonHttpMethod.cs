/* 
 * Analytics
 *
 * This API will help you to manage the tracking of your clicks and your sales, get reporting on this trackings and put in place rules based on this reporting to automatically optimize your channel catalogs. \\ Also, you will be able to consult the rule execution reporting. 
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
    /// Indicate the http method to use on this link
    /// </summary>
    /// <value>Indicate the http method to use on this link</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BeezUPCommonHttpMethod
    {
        
        /// <summary>
        /// Enum GET for "GET"
        /// </summary>
        [EnumMember(Value = "GET")]
        GET,
        
        /// <summary>
        /// Enum POST for "POST"
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,
        
        /// <summary>
        /// Enum PATCH for "PATCH"
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH,
        
        /// <summary>
        /// Enum DELETE for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE,
        
        /// <summary>
        /// Enum PUT for "PUT"
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT,
        
        /// <summary>
        /// Enum HEAD for "HEAD"
        /// </summary>
        [EnumMember(Value = "HEAD")]
        HEAD
    }

}
