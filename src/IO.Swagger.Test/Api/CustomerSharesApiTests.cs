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
    ///  Class for testing CustomerSharesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerSharesApiTests
    {
        private CustomerSharesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerSharesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerSharesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerSharesApi
            //Assert.IsInstanceOfType(typeof(CustomerSharesApi), instance, "instance is a CustomerSharesApi");
        }

        
        /// <summary>
        /// Test DeleteShare
        /// </summary>
        [Test]
        public void DeleteShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string userId = null;
            //instance.DeleteShare(storeId, userId);
            
        }
        
        /// <summary>
        /// Test GetShares
        /// </summary>
        [Test]
        public void GetSharesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetShares(storeId);
            //Assert.IsInstanceOf<StoreShares> (response, "response is StoreShares");
        }
        
        /// <summary>
        /// Test Share
        /// </summary>
        [Test]
        public void ShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //FriendEmail email = null;
            //instance.Share(storeId, email);
            
        }
        
    }

}
