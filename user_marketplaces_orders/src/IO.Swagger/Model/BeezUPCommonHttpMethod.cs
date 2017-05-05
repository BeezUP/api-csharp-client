/* 
 * Marketplaces - Orders
 *
 * The features exposed in this API are centered around managing Orders harvested from your configured marketplaces.\\ This includes: - fetching current information (as known by BeezUP) for a single or multiple Orders, - requesting Order harvest to synchronize your marketplaces and BeezUP accounts, - changing BeezUP data and requesting changes to your marketplaces (accepting, shipping, etc), - configuring automatic changes to marketplace based our newly fetched data, - creating and exporting reports for your Orders. 
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
