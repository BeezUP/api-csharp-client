/* 
 * Channel Catalogs
 *
 * This api allows you to manage your channel catalogs.   A channel catalog is an association between your store and a channel.  You will be able to: - map your catalog colums to channel columns. - map your catalog categories to the channel categories and define a cost of this category - configure the general and cost settings of the channel - enable or disable a channel - exclude products using filters for a channel - override product values for a channel - disable or reenable a product on a channel 
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
    ///  Class for testing ChannelCatalogsExclusionFiltersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChannelCatalogsExclusionFiltersApiTests
    {
        private ChannelCatalogsExclusionFiltersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChannelCatalogsExclusionFiltersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChannelCatalogsExclusionFiltersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChannelCatalogsExclusionFiltersApi
            //Assert.IsInstanceOfType(typeof(ChannelCatalogsExclusionFiltersApi), instance, "instance is a ChannelCatalogsExclusionFiltersApi");
        }

        
        /// <summary>
        /// Test ConfigureChannelCatalogExclusionFilters
        /// </summary>
        [Test]
        public void ConfigureChannelCatalogExclusionFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //ExclusionFilters request = null;
            //instance.ConfigureChannelCatalogExclusionFilters(channelCatalogId, request);
            
        }
        
        /// <summary>
        /// Test GetChannelCatalogExclusionFilterOperators
        /// </summary>
        [Test]
        public void GetChannelCatalogExclusionFilterOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetChannelCatalogExclusionFilterOperators();
            //Assert.IsInstanceOf<List<ExclusionFilterOperator>> (response, "response is List<ExclusionFilterOperator>");
        }
        
    }

}