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
    ///  Class for testing ChannelCatalogsCategoryMappingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChannelCatalogsCategoryMappingsApiTests
    {
        private ChannelCatalogsCategoryMappingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChannelCatalogsCategoryMappingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChannelCatalogsCategoryMappingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChannelCatalogsCategoryMappingsApi
            //Assert.IsInstanceOfType(typeof(ChannelCatalogsCategoryMappingsApi), instance, "instance is a ChannelCatalogsCategoryMappingsApi");
        }

        
        /// <summary>
        /// Test GetChannelCatalogCategories
        /// </summary>
        [Test]
        public void GetChannelCatalogCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //var response = instance.GetChannelCatalogCategories(channelCatalogId);
            //Assert.IsInstanceOf<ChannelCatalogCategoryMappings> (response, "response is ChannelCatalogCategoryMappings");
        }
        
        /// <summary>
        /// Test MapChannelCatalogCategory
        /// </summary>
        [Test]
        public void MapChannelCatalogCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //MapCategoryRequest request = null;
            //instance.MapChannelCatalogCategory(channelCatalogId, request);
            
        }
        
        /// <summary>
        /// Test UnmapChannelCatalogCategory
        /// </summary>
        [Test]
        public void UnmapChannelCatalogCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelCatalogId = null;
            //UnmapCategoryRequest request = null;
            //instance.UnmapChannelCatalogCategory(channelCatalogId, request);
            
        }
        
    }

}
