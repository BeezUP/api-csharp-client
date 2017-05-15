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
    ///  Class for testing PublicListOfValuesLOVApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicListOfValuesLOVApiTests
    {
        private PublicListOfValuesLOVApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicListOfValuesLOVApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicListOfValuesLOVApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicListOfValuesLOVApi
            //Assert.IsInstanceOfType(typeof(PublicListOfValuesLOVApi), instance, "instance is a PublicListOfValuesLOVApi");
        }

        
        /// <summary>
        /// Test GetPublicListOfValues
        /// </summary>
        [Test]
        public void GetPublicListOfValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string listName = null;
            //List<string> acceptLanguage = null;
            //string ifNoneMatch = null;
            //var response = instance.GetPublicListOfValues(listName, acceptLanguage, ifNoneMatch);
            //Assert.IsInstanceOf<PublicListOfValuesResponse> (response, "response is PublicListOfValuesResponse");
        }
        
        /// <summary>
        /// Test GetPublicLovIndex
        /// </summary>
        [Test]
        public void GetPublicLovIndexTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ifNoneMatch = null;
            //var response = instance.GetPublicLovIndex(ifNoneMatch);
            //Assert.IsInstanceOf<PublicLovIndex> (response, "response is PublicLovIndex");
        }
        
    }

}
