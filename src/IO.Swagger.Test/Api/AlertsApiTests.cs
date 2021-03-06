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
    ///  Class for testing AlertsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AlertsApiTests
    {
        private AlertsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AlertsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AlertsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AlertsApi
            //Assert.IsInstanceOfType(typeof(AlertsApi), instance, "instance is a AlertsApi");
        }

        
        /// <summary>
        /// Test GetStoreAlerts
        /// </summary>
        [Test]
        public void GetStoreAlertsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetStoreAlerts(storeId);
            //Assert.IsInstanceOf<StoreAlerts> (response, "response is StoreAlerts");
        }
        
        /// <summary>
        /// Test SaveStoreAlert
        /// </summary>
        [Test]
        public void SaveStoreAlertTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //int? alertId = null;
            //List<SaveStoreAlertRequest> request = null;
            //instance.SaveStoreAlert(storeId, alertId, request);
            
        }
        
    }

}
