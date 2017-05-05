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
    /// Indicates on which date you want to make the filter
    /// </summary>
    /// <value>Indicates on which date you want to make the filter</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DateSearchType
    {
        
        /// <summary>
        /// Enum Purchase for "Purchase"
        /// </summary>
        [EnumMember(Value = "Purchase")]
        Purchase,
        
        /// <summary>
        /// Enum Modification for "Modification"
        /// </summary>
        [EnumMember(Value = "Modification")]
        Modification,
        
        /// <summary>
        /// Enum MarketPlaceModification for "MarketPlaceModification"
        /// </summary>
        [EnumMember(Value = "MarketPlaceModification")]
        MarketPlaceModification
    }

}
