/* 
 * User - List of Values
 *
 * This API gives you access to list of values.
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
    ///  Class for testing LOVApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LOVApiTests
    {
        private LOVApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LOVApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LOVApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LOVApi
            //Assert.IsInstanceOfType(typeof(LOVApi), instance, "instance is a LOVApi");
        }

        
        /// <summary>
        /// Test GetUserListNames
        /// </summary>
        [Test]
        public void GetUserListNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserListNames();
            //Assert.IsInstanceOf<List<BeezUPCommonLOVLink2>> (response, "response is List<BeezUPCommonLOVLink2>");
        }
        
        /// <summary>
        /// Test GetUserListOfValues
        /// </summary>
        [Test]
        public void GetUserListOfValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string listName = null;
            //List<string> acceptLanguage = null;
            //var response = instance.GetUserListOfValues(listName, acceptLanguage);
            //Assert.IsInstanceOf<List<BeezUPCommonListOfValueItem>> (response, "response is List<BeezUPCommonListOfValueItem>");
        }
        
    }

}
