/* 
 * Channel Catalogs
 *
 * This api allows you to manage your channel catalogs.   A channel catalog is an association between your store and a channel.  You will be able to: - map your catalog colums to channel columns. - map your catalog categories to the channel categories and define a cost of this category - configure the general and cost settings of the channel - enable or disable a channel - exclude products using filters for a channel - override product values for a channel - disable or reenable a product on a channel 
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
    /// Data type of the operator
    /// </summary>
    /// <value>Data type of the operator</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExclusionFilterOperatorDataType
    {
        
        /// <summary>
        /// Enum String for "string"
        /// </summary>
        [EnumMember(Value = "string")]
        String,
        
        /// <summary>
        /// Enum Number for "number"
        /// </summary>
        [EnumMember(Value = "number")]
        Number
    }

}
