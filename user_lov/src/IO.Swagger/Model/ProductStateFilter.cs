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
    /// You can filter on the product state.
    /// </summary>
    /// <value>You can filter on the product state.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductStateFilter
    {
        
        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,
        
        /// <summary>
        /// Enum Enabled for "Enabled"
        /// </summary>
        [EnumMember(Value = "Enabled")]
        Enabled,
        
        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled
    }

}
