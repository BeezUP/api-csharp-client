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
    ///  Class for testing AnalyticsTrackingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AnalyticsTrackingApiTests
    {
        private AnalyticsTrackingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnalyticsTrackingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyticsTrackingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AnalyticsTrackingApi
            //Assert.IsInstanceOfType(typeof(AnalyticsTrackingApi), instance, "instance is a AnalyticsTrackingApi");
        }

        
        /// <summary>
        /// Test GetStoreTrackedClicks
        /// </summary>
        [Test]
        public void GetStoreTrackedClicksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //int? count = null;
            //var response = instance.GetStoreTrackedClicks(storeId, count);
            //Assert.IsInstanceOf<TrackedClicks> (response, "response is TrackedClicks");
        }
        
        /// <summary>
        /// Test GetStoreTrackedExternalOrders
        /// </summary>
        [Test]
        public void GetStoreTrackedExternalOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //int? count = null;
            //var response = instance.GetStoreTrackedExternalOrders(storeId, count);
            //Assert.IsInstanceOf<TrackedExternalOrders> (response, "response is TrackedExternalOrders");
        }
        
        /// <summary>
        /// Test GetStoreTrackedOrders
        /// </summary>
        [Test]
        public void GetStoreTrackedOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //int? count = null;
            //var response = instance.GetStoreTrackedOrders(storeId, count);
            //Assert.IsInstanceOf<TrackedOrders> (response, "response is TrackedOrders");
        }
        
        /// <summary>
        /// Test GetStoreTrackingStatus
        /// </summary>
        [Test]
        public void GetStoreTrackingStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetStoreTrackingStatus(storeId);
            //Assert.IsInstanceOf<StoreTrackingStatus> (response, "response is StoreTrackingStatus");
        }
        
        /// <summary>
        /// Test GetTrackingStatus
        /// </summary>
        [Test]
        public void GetTrackingStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTrackingStatus();
            //Assert.IsInstanceOf<TrackingStatus> (response, "response is TrackingStatus");
        }
        
    }

}
