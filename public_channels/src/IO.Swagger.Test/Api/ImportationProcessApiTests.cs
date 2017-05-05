/* 
 * Catalogs
 *
 * This API allows you to manage your catalogs
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
    ///  Class for testing ImportationProcessApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImportationProcessApiTests
    {
        private ImportationProcessApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImportationProcessApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImportationProcessApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImportationProcessApi
            //Assert.IsInstanceOfType(typeof(ImportationProcessApi), instance, "instance is a ImportationProcessApi");
        }

        
        /// <summary>
        /// Test ImportationCancel
        /// </summary>
        [Test]
        public void ImportationCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //instance.ImportationCancel(storeId, executionId);
            
        }
        
        /// <summary>
        /// Test ImportationCommit
        /// </summary>
        [Test]
        public void ImportationCommitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //instance.ImportationCommit(storeId, executionId);
            
        }
        
        /// <summary>
        /// Test ImportationCommitColumns
        /// </summary>
        [Test]
        public void ImportationCommitColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //instance.ImportationCommitColumns(storeId, executionId);
            
        }
        
        /// <summary>
        /// Test ImportationConfigureRemainingCatalogColumns
        /// </summary>
        [Test]
        public void ImportationConfigureRemainingCatalogColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //instance.ImportationConfigureRemainingCatalogColumns(storeId, executionId);
            
        }
        
        /// <summary>
        /// Test ImportationGetImportationMonitoring
        /// </summary>
        [Test]
        public void ImportationGetImportationMonitoringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //var response = instance.ImportationGetImportationMonitoring(storeId, executionId);
            //Assert.IsInstanceOf<ImportationMonitoring> (response, "response is ImportationMonitoring");
        }
        
        /// <summary>
        /// Test ImportationGetReportings
        /// </summary>
        [Test]
        public void ImportationGetReportingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.ImportationGetReportings(storeId);
            //Assert.IsInstanceOf<List<ImportationReporting>> (response, "response is List<ImportationReporting>");
        }
        
        /// <summary>
        /// Test ImportationStartManualUpdate
        /// </summary>
        [Test]
        public void ImportationStartManualUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //StartManualImportRequest request = null;
            //var response = instance.ImportationStartManualUpdate(storeId, request);
            //Assert.IsInstanceOf<List<BeezUPCommonLink2>> (response, "response is List<BeezUPCommonLink2>");
        }
        
        /// <summary>
        /// Test ImportationTechnicalProgression
        /// </summary>
        [Test]
        public void ImportationTechnicalProgressionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //var response = instance.ImportationTechnicalProgression(storeId, executionId);
            //Assert.IsInstanceOf<ImportationTechnicalProgression> (response, "response is ImportationTechnicalProgression");
        }
        
    }

}