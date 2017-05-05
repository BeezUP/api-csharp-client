/* 
 * Customer
 *
 * This API will gives you the ability to : - manage your account - manage your stores - shares your stores with your friends - manage your contracts - access to your invoices 
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
    ///  Class for testing StoresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoresApiTests
    {
        private StoresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoresApi
            //Assert.IsInstanceOfType(typeof(StoresApi), instance, "instance is a StoresApi");
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
