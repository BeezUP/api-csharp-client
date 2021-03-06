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
    ///  Class for testing MarketplacesChannelCatalogsSettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MarketplacesChannelCatalogsSettingsApiTests
    {
        private MarketplacesChannelCatalogsSettingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MarketplacesChannelCatalogsSettingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MarketplacesChannelCatalogsSettingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MarketplacesChannelCatalogsSettingsApi
            //Assert.IsInstanceOfType(typeof(MarketplacesChannelCatalogsSettingsApi), instance, "instance is a MarketplacesChannelCatalogsSettingsApi");
        }

        
        /// <summary>
        /// Test GetChannelCatalogMarketplaceProperties
        /// </summary>
        [Test]
        public void GetChannelCatalogMarketplacePropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //var response = instance.GetChannelCatalogMarketplaceProperties(channelCatalogId);
            //Assert.IsInstanceOf<ChannelCatalogMarketplaceProperties> (response, "response is ChannelCatalogMarketplaceProperties");
        }
        
        /// <summary>
        /// Test GetChannelCatalogMarketplaceSettings
        /// </summary>
        [Test]
        public void GetChannelCatalogMarketplaceSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //var response = instance.GetChannelCatalogMarketplaceSettings(channelCatalogId);
            //Assert.IsInstanceOf<ChannelCatalogMarketplaceSettings> (response, "response is ChannelCatalogMarketplaceSettings");
        }
        
        /// <summary>
        /// Test SetChannelCatalogMarketplaceSettings
        /// </summary>
        [Test]
        public void SetChannelCatalogMarketplaceSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //SetChannelCatalogMarketplaceSettingsRequest model = null;
            //instance.SetChannelCatalogMarketplaceSettings(channelCatalogId, model);
            
        }
        
    }

}
