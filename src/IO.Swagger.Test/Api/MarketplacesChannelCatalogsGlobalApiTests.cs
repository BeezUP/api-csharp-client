/* 
 * Public - Security
 *
 * This API will allow you to create your account and to get your tokens. \\ If you lost your password, you have an operation to get it back. 
 *
 * OpenAPI spec version: 2.0
 * Contact: support@beezup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing MarketplacesChannelCatalogsGlobalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MarketplacesChannelCatalogsGlobalApiTests
    {
        private MarketplacesChannelCatalogsGlobalApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MarketplacesChannelCatalogsGlobalApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MarketplacesChannelCatalogsGlobalApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MarketplacesChannelCatalogsGlobalApi
            //Assert.IsInstanceOfType(typeof(MarketplacesChannelCatalogsGlobalApi), instance, "instance is a MarketplacesChannelCatalogsGlobalApi");
        }

        
        /// <summary>
        /// Test GetMarketplaceAccountStores
        /// </summary>
        [Test]
        public void GetMarketplaceAccountStoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetMarketplaceAccountStores();
            //Assert.IsInstanceOf<MarketplaceChannelCatalogList> (response, "response is MarketplaceChannelCatalogList");
        }
        
    }

}
