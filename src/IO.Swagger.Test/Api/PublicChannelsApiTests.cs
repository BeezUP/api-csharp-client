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
    ///  Class for testing PublicChannelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicChannelsApiTests
    {
        private PublicChannelsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicChannelsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicChannelsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicChannelsApi
            //Assert.IsInstanceOfType(typeof(PublicChannelsApi), instance, "instance is a PublicChannelsApi");
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
        /// Test GetChannelsByCountry
        /// </summary>
        [Test]
        public void GetChannelsByCountryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetChannelsByCountry();
            //Assert.IsInstanceOf<Dictionary<string, string>> (response, "response is Dictionary<string, string>");
        }
        
    }

}
