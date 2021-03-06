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
    ///  Class for testing CustomerRightsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerRightsApiTests
    {
        private CustomerRightsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerRightsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerRightsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerRightsApi
            //Assert.IsInstanceOfType(typeof(CustomerRightsApi), instance, "instance is a CustomerRightsApi");
        }

        
        /// <summary>
        /// Test GetRights
        /// </summary>
        [Test]
        public void GetRightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //List<string> functionalityCodeList = null;
            //var response = instance.GetRights(storeId, functionalityCodeList);
            //Assert.IsInstanceOf<List<FunctionalityRightInfo>> (response, "response is List<FunctionalityRightInfo>");
        }
        
    }

}
