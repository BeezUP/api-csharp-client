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
    ///  Class for testing CustomerStoresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerStoresApiTests
    {
        private CustomerStoresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerStoresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerStoresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerStoresApi
            //Assert.IsInstanceOfType(typeof(CustomerStoresApi), instance, "instance is a CustomerStoresApi");
        }

        
        /// <summary>
        /// Test CreateStore
        /// </summary>
        [Test]
        public void CreateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateStoreRequest request = null;
            //var response = instance.CreateStore(request);
            //Assert.IsInstanceOf<LinksGetStoresLink> (response, "response is LinksGetStoresLink");
        }
        
        /// <summary>
        /// Test DeleteStore
        /// </summary>
        [Test]
        public void DeleteStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //instance.DeleteStore(storeId);
            
        }
        
        /// <summary>
        /// Test GetStore
        /// </summary>
        [Test]
        public void GetStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetStore(storeId);
            //Assert.IsInstanceOf<StoreHeader> (response, "response is StoreHeader");
        }
        
        /// <summary>
        /// Test GetStores
        /// </summary>
        [Test]
        public void GetStoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStores();
            //Assert.IsInstanceOf<Stores> (response, "response is Stores");
        }
        
        /// <summary>
        /// Test UpdateStore
        /// </summary>
        [Test]
        public void UpdateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //UpdateStoreRequest request = null;
            //instance.UpdateStore(storeId, request);
            
        }
        
    }

}
