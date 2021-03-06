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
    ///  Class for testing PublicChannelsPublicChannelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicChannelsPublicChannelsApiTests
    {
        private PublicChannelsPublicChannelsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicChannelsPublicChannelsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicChannelsPublicChannelsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicChannelsPublicChannelsApi
            //Assert.IsInstanceOfType(typeof(PublicChannelsPublicChannelsApi), instance, "instance is a PublicChannelsPublicChannelsApi");
        }

        
        /// <summary>
        /// Test GetChannels
        /// </summary>
        [Test]
        public void GetChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string countryIsoCode = null;
            //List<string> acceptEncoding = null;
            //var response = instance.GetChannels(countryIsoCode, acceptEncoding);
            //Assert.IsInstanceOf<ChannelInfoList> (response, "response is ChannelInfoList");
        }
        
        /// <summary>
        /// Test GetChannelsIndex
        /// </summary>
        [Test]
        public void GetChannelsIndexTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetChannelsIndex();
            //Assert.IsInstanceOf<PublicChannelIndex> (response, "response is PublicChannelIndex");
        }
        
    }

}
