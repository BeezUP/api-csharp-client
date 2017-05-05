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
    /// CPC means cost per click. CPA means cost per action. You can have CPC/CPA with a global cost value. You can have CPC/CPA by category the cost value MUST be null You can have global fixed price. 
    /// </summary>
    /// <value>CPC means cost per click. CPA means cost per action. You can have CPC/CPA with a global cost value. You can have CPC/CPA by category the cost value MUST be null You can have global fixed price. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CostType
    {
        
        /// <summary>
        /// Enum CPCGlobal for "CPC_Global"
        /// </summary>
        [EnumMember(Value = "CPC_Global")]
        CPCGlobal,
        
        /// <summary>
        /// Enum CPAGlobal for "CPA_Global"
        /// </summary>
        [EnumMember(Value = "CPA_Global")]
        CPAGlobal,
        
        /// <summary>
        /// Enum CPCByCategory for "CPC_ByCategory"
        /// </summary>
        [EnumMember(Value = "CPC_ByCategory")]
        CPCByCategory,
        
        /// <summary>
        /// Enum CPAByCategory for "CPA_ByCategory"
        /// </summary>
        [EnumMember(Value = "CPA_ByCategory")]
        CPAByCategory,
        
        /// <summary>
        /// Enum FixedGlobal for "Fixed_Global"
        /// </summary>
        [EnumMember(Value = "Fixed_Global")]
        FixedGlobal
    }

}