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
    /// The Publication Type
    /// </summary>
    /// <value>The Publication Type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublicationType
    {
        
        /// <summary>
        /// Enum PublishProducts for "PublishProducts"
        /// </summary>
        [EnumMember(Value = "PublishProducts")]
        PublishProducts,
        
        /// <summary>
        /// Enum PublishOffers for "PublishOffers"
        /// </summary>
        [EnumMember(Value = "PublishOffers")]
        PublishOffers,
        
        /// <summary>
        /// Enum Unpublish for "Unpublish"
        /// </summary>
        [EnumMember(Value = "Unpublish")]
        Unpublish
    }

}
