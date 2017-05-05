/* 
 * Marketplaces - Orders
 *
 * The features exposed in this API are centered around managing Orders harvested from your configured marketplaces.\\ This includes: - fetching current information (as known by BeezUP) for a single or multiple Orders, - requesting Order harvest to synchronize your marketplaces and BeezUP accounts, - changing BeezUP data and requesting changes to your marketplaces (accepting, shipping, etc), - configuring automatic changes to marketplace based our newly fetched data, - creating and exporting reports for your Orders. 
 *
 * OpenAPI spec version: 2.0
 * Contact: support@beezup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ExportOrderListRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExportOrderListRequestTests
    {
        // TODO uncomment below to declare an instance variable for ExportOrderListRequest
        //private ExportOrderListRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ExportOrderListRequest
            //instance = new ExportOrderListRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExportOrderListRequest
        /// </summary>
        [Test]
        public void ExportOrderListRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ExportOrderListRequest
            //Assert.IsInstanceOfType<ExportOrderListRequest> (instance, "variable 'instance' is a ExportOrderListRequest");
        }

        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Test]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'OrderListRequest'
        /// </summary>
        [Test]
        public void OrderListRequestTest()
        {
            // TODO unit test for the property 'OrderListRequest'
        }

    }

}