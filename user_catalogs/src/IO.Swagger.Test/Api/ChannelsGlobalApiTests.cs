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
    ///  Class for testing ChannelsGlobalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ChannelsGlobalApiTests
    {
        private ChannelsGlobalApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChannelsGlobalApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChannelsGlobalApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChannelsGlobalApi
            //Assert.IsInstanceOfType(typeof(ChannelsGlobalApi), instance, "instance is a ChannelsGlobalApi");
        }

        
        /// <summary>
        /// Test GetChannelCategories
        /// </summary>
        [Test]
        public void GetChannelCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //List<string> acceptEncoding = null;
            //var response = instance.GetChannelCategories(channelId, acceptEncoding);
            //Assert.IsInstanceOf<ChannelRootCategory> (response, "response is ChannelRootCategory");
        }
        
        /// <summary>
        /// Test GetChannelColumns
        /// </summary>
        [Test]
        public void GetChannelColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //List<string> acceptEncoding = null;
            //List<BeezUPCommonChannelColumnId> request = null;
            //var response = instance.GetChannelColumns(channelId, acceptEncoding, request);
            //Assert.IsInstanceOf<List<ChannelColumn>> (response, "response is List<ChannelColumn>");
        }
        
        /// <summary>
        /// Test GetChannelInfo
        /// </summary>
        [Test]
        public void GetChannelInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //var response = instance.GetChannelInfo(channelId);
            //Assert.IsInstanceOf<ChannelInfo> (response, "response is ChannelInfo");
        }
        
        /// <summary>
        /// Test GetCurrentChannels
        /// </summary>
        [Test]
        public void GetCurrentChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetCurrentChannels(storeId);
            //Assert.IsInstanceOf<List<ChannelHeader>> (response, "response is List<ChannelHeader>");
        }
        
    }

}