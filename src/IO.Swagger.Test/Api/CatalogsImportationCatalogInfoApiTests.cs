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
    ///  Class for testing CatalogsImportationCatalogInfoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CatalogsImportationCatalogInfoApiTests
    {
        private CatalogsImportationCatalogInfoApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CatalogsImportationCatalogInfoApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CatalogsImportationCatalogInfoApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CatalogsImportationCatalogInfoApi
            //Assert.IsInstanceOfType(typeof(CatalogsImportationCatalogInfoApi), instance, "instance is a CatalogsImportationCatalogInfoApi");
        }

        
        /// <summary>
        /// Test ImportationConfigureCatalogColumn
        /// </summary>
        [Test]
        public void ImportationConfigureCatalogColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //ConfigureCatalogColumnCatalogRequest request = null;
            //instance.ImportationConfigureCatalogColumn(storeId, executionId, columnId, request);
            
        }
        
        /// <summary>
        /// Test ImportationDeleteCustomColumn
        /// </summary>
        [Test]
        public void ImportationDeleteCustomColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //instance.ImportationDeleteCustomColumn(storeId, executionId, columnId);
            
        }
        
        /// <summary>
        /// Test ImportationGetCustomColumnExpression
        /// </summary>
        [Test]
        public void ImportationGetCustomColumnExpressionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //var response = instance.ImportationGetCustomColumnExpression(storeId, executionId, columnId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ImportationGetCustomColumns
        /// </summary>
        [Test]
        public void ImportationGetCustomColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //var response = instance.ImportationGetCustomColumns(storeId, executionId);
            //Assert.IsInstanceOf<CustomColumns> (response, "response is CustomColumns");
        }
        
        /// <summary>
        /// Test ImportationGetDetectedCatalogColumns
        /// </summary>
        [Test]
        public void ImportationGetDetectedCatalogColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //var response = instance.ImportationGetDetectedCatalogColumns(storeId, executionId);
            //Assert.IsInstanceOf<DetectedCatalogColumns> (response, "response is DetectedCatalogColumns");
        }
        
        /// <summary>
        /// Test ImportationGetProductSample
        /// </summary>
        [Test]
        public void ImportationGetProductSampleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //int? productSampleIndex = null;
            //var response = instance.ImportationGetProductSample(storeId, executionId, productSampleIndex);
            //Assert.IsInstanceOf<ProductSample> (response, "response is ProductSample");
        }
        
        /// <summary>
        /// Test ImportationGetProductSampleCustomColumnValue
        /// </summary>
        [Test]
        public void ImportationGetProductSampleCustomColumnValueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //int? productSampleIndex = null;
            //string columnId = null;
            //var response = instance.ImportationGetProductSampleCustomColumnValue(storeId, executionId, productSampleIndex, columnId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ImportationIgnoreColumn
        /// </summary>
        [Test]
        public void ImportationIgnoreColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //instance.ImportationIgnoreColumn(storeId, executionId, columnId);
            
        }
        
        /// <summary>
        /// Test ImportationMapCatalogColumn
        /// </summary>
        [Test]
        public void ImportationMapCatalogColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //MapBeezUPColumnRequest request = null;
            //instance.ImportationMapCatalogColumn(storeId, executionId, columnId, request);
            
        }
        
        /// <summary>
        /// Test ImportationMapCustomColumn
        /// </summary>
        [Test]
        public void ImportationMapCustomColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //MapBeezUPColumnRequest request = null;
            //instance.ImportationMapCustomColumn(storeId, executionId, columnId, request);
            
        }
        
        /// <summary>
        /// Test ImportationReattendColumn
        /// </summary>
        [Test]
        public void ImportationReattendColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //instance.ImportationReattendColumn(storeId, executionId, columnId);
            
        }
        
        /// <summary>
        /// Test ImportationSaveCustomColumn
        /// </summary>
        [Test]
        public void ImportationSaveCustomColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //ChangeCustomColumnRequest request = null;
            //instance.ImportationSaveCustomColumn(storeId, executionId, columnId, request);
            
        }
        
        /// <summary>
        /// Test ImportationUnmapCatalogColumn
        /// </summary>
        [Test]
        public void ImportationUnmapCatalogColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //instance.ImportationUnmapCatalogColumn(storeId, executionId, columnId);
            
        }
        
        /// <summary>
        /// Test ImportationUnmapCustomColumn
        /// </summary>
        [Test]
        public void ImportationUnmapCustomColumnTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string executionId = null;
            //string columnId = null;
            //instance.ImportationUnmapCustomColumn(storeId, executionId, columnId);
            
        }
        
    }

}
