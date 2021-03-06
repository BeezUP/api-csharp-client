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
    ///  Class for testing BatchesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BatchesApiTests
    {
        private BatchesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BatchesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BatchesApi
            //Assert.IsInstanceOfType(typeof(BatchesApi), instance, "instance is a BatchesApi");
        }

        
        /// <summary>
        /// Test ChangeOrderList
        /// </summary>
        [Test]
        public void ChangeOrderListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string changeOrderType = null;
            //string userName = null;
            //ChangeOrderListRequest request = null;
            //bool? testMode = null;
            //var response = instance.ChangeOrderList(changeOrderType, userName, request, testMode);
            //Assert.IsInstanceOf<BatchOrderOperationResponse> (response, "response is BatchOrderOperationResponse");
        }
        
        /// <summary>
        /// Test ClearMerchantOrderInfoList
        /// </summary>
        [Test]
        public void ClearMerchantOrderInfoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClearMerchantOrderInfoListRequest request = null;
            //var response = instance.ClearMerchantOrderInfoList(request);
            //Assert.IsInstanceOf<BatchOrderOperationResponse> (response, "response is BatchOrderOperationResponse");
        }
        
        /// <summary>
        /// Test SetMerchantOrderInfoList
        /// </summary>
        [Test]
        public void SetMerchantOrderInfoListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetMerchantOrderInfoListRequest request = null;
            //var response = instance.SetMerchantOrderInfoList(request);
            //Assert.IsInstanceOf<BatchOrderOperationResponse> (response, "response is BatchOrderOperationResponse");
        }
        
    }

}
