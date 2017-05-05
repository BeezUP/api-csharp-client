/* 
 * Customer
 *
 * This API will gives you the ability to : - manage your account - manage your stores - shares your stores with your friends - manage your contracts - access to your invoices 
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
    /// The payment status
    /// </summary>
    /// <value>The payment status</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoicePaymentStatus
    {
        
        /// <summary>
        /// Enum Paid for "Paid"
        /// </summary>
        [EnumMember(Value = "Paid")]
        Paid,
        
        /// <summary>
        /// Enum NotPaid for "NotPaid"
        /// </summary>
        [EnumMember(Value = "NotPaid")]
        NotPaid,
        
        /// <summary>
        /// Enum PartiallyPaid for "PartiallyPaid"
        /// </summary>
        [EnumMember(Value = "PartiallyPaid")]
        PartiallyPaid,
        
        /// <summary>
        /// Enum Loss for "Loss"
        /// </summary>
        [EnumMember(Value = "Loss")]
        Loss
    }

}