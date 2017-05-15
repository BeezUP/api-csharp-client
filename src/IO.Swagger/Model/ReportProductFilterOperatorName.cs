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
    /// Indicate the operator you want to make on the columnId
    /// </summary>
    /// <value>Indicate the operator you want to make on the columnId</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportProductFilterOperatorName
    {
        
        /// <summary>
        /// Enum Equals for "Equals"
        /// </summary>
        [EnumMember(Value = "Equals")]
        Equals,
        
        /// <summary>
        /// Enum Contains for "Contains"
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains,
        
        /// <summary>
        /// Enum GreaterTo for "GreaterTo"
        /// </summary>
        [EnumMember(Value = "GreaterTo")]
        GreaterTo,
        
        /// <summary>
        /// Enum LowerTo for "LowerTo"
        /// </summary>
        [EnumMember(Value = "LowerTo")]
        LowerTo,
        
        /// <summary>
        /// Enum InList for "InList"
        /// </summary>
        [EnumMember(Value = "InList")]
        InList,
        
        /// <summary>
        /// Enum IsNull for "IsNull"
        /// </summary>
        [EnumMember(Value = "IsNull")]
        IsNull,
        
        /// <summary>
        /// Enum IsNotNull for "IsNotNull"
        /// </summary>
        [EnumMember(Value = "IsNotNull")]
        IsNotNull
    }

}
