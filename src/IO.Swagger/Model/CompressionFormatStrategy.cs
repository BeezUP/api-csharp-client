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
    /// Indicate the compression type
    /// </summary>
    /// <value>Indicate the compression type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompressionFormatStrategy
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Zip for "Zip"
        /// </summary>
        [EnumMember(Value = "Zip")]
        Zip,
        
        /// <summary>
        /// Enum TarGz for "TarGz"
        /// </summary>
        [EnumMember(Value = "TarGz")]
        TarGz,
        
        /// <summary>
        /// Enum Gzip for "Gzip"
        /// </summary>
        [EnumMember(Value = "Gzip")]
        Gzip,
        
        /// <summary>
        /// Enum Bzip2 for "Bzip2"
        /// </summary>
        [EnumMember(Value = "Bzip2")]
        Bzip2,
        
        /// <summary>
        /// Enum Rar for "Rar"
        /// </summary>
        [EnumMember(Value = "Rar")]
        Rar
    }

}
