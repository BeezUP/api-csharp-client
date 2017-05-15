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
    /// The type of the file to export
    /// </summary>
    /// <value>The type of the file to export</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportOrderListFormat
    {
        
        /// <summary>
        /// Enum Csv for "csv"
        /// </summary>
        [EnumMember(Value = "csv")]
        Csv
    }

}
