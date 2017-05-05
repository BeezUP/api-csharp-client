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
    /// Indicates on which date you want to make the filter.
    /// </summary>
    /// <value>Indicates on which date you want to make the filter.</value>
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