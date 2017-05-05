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
    /// The Feed Type
    /// </summary>
    /// <value>The Feed Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeedType
    {
        
        /// <summary>
        /// Enum Products for "Products"
        /// </summary>
        [EnumMember(Value = "Products")]
        Products,
        
        /// <summary>
        /// Enum Inventory for "Inventory"
        /// </summary>
        [EnumMember(Value = "Inventory")]
        Inventory,
        
        /// <summary>
        /// Enum Pricing for "Pricing"
        /// </summary>
        [EnumMember(Value = "Pricing")]
        Pricing,
        
        /// <summary>
        /// Enum Images for "Images"
        /// </summary>
        [EnumMember(Value = "Images")]
        Images,
        
        /// <summary>
        /// Enum Relationships for "Relationships"
        /// </summary>
        [EnumMember(Value = "Relationships")]
        Relationships,
        
        /// <summary>
        /// Enum Unpublish for "Unpublish"
        /// </summary>
        [EnumMember(Value = "Unpublish")]
        Unpublish,
        
        /// <summary>
        /// Enum Offers for "Offers"
        /// </summary>
        [EnumMember(Value = "Offers")]
        Offers
    }

}
