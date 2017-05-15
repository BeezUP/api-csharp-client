/* 
 * BeezUP API
 *
 * # The REST API of BeezUP system ## Overview The REST APIs provide programmatic access to read and write BeezUP data.  Basically, with this API you will be able to do everything like you were with your browser on https://go.beezup.com !  The main features are: - Register and manage your account - Create and manage and share your stores with your friends/co-workers. - Import your product catalog and schedule the auto importation - Search the channels your want to use - Configure your channels for your catalogs to export your product information:     - cost and general settings     - category and columns mappings     - your will be able to create and manage your custom column     - put in place exlusion filters based on simple conditions on your product data     - override product values     - get product vision for a channel catalog scope - Analyze and optimize your performance of your catalogs on all yours channels with different type of reportings by day, channel, category and by product. - Automatize your optimisation by using rules! - And of course... Manage your orders harvested from all your marketplaces:     - Synchronize your orders in an uniformized way     - Get the available actions and update the order status - ...and more!  ## Authentication credentials The public API with the base path **_/v2/public** have been put in place to give you an entry point to our system for the user registration, login and lost password. The public API does not require any credentials. We give you the some public list of values and public channels for our public commercial web site [www.beezup.com](http://www.beezup.com).  The user API with the base path **_/v2/user** requires a token which is available on this page: https://go.beezup.com/Account/MyAccount  ## Things to keep in mind ### API Rate Limits - The BeezUP REST API is limited to 100 calls/minute.  ### Media type The default media type for requests and responses is application/json. Where noted, some operations support other content types. If no additional content type is mentioned for a specific operation, then the media type is application/json.  ### Required content type The required and default encoding for the request and responses is UTF8.  ### Required date time format All our date time are formatted in ISO 8601 format: 2014-06-24T16:25:00Z.  ### Base URL The Base URL of the BeezUP API Order Management REST API conforms to the following template.  https://api.beezup.com  All URLs returned by the BeezUP API are relative to this base URL, and all requests to the REST API must use this base URL template.  You can test our API on https://api-docs.beezup.com/swagger-ui\\ You can contact us on [gitter, #BeezUP/API](https://gitter.im/beezUP/API) 
 *
 * OpenAPI spec version: 2.0
 * Contact: support@beezup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ChannelCatalog
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ChannelCatalogTests
    {
        // TODO uncomment below to declare an instance variable for ChannelCatalog
        //private ChannelCatalog instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ChannelCatalog
            //instance = new ChannelCatalog();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChannelCatalog
        /// </summary>
        [Test]
        public void ChannelCatalogInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ChannelCatalog
            //Assert.IsInstanceOfType<ChannelCatalog> (instance, "variable 'instance' is a ChannelCatalog");
        }

        /// <summary>
        /// Test the property 'ChannelId'
        /// </summary>
        [Test]
        public void ChannelIdTest()
        {
            // TODO unit test for the property 'ChannelId'
        }
        /// <summary>
        /// Test the property 'ChannelName'
        /// </summary>
        [Test]
        public void ChannelNameTest()
        {
            // TODO unit test for the property 'ChannelName'
        }
        /// <summary>
        /// Test the property 'ChannelImageUrl'
        /// </summary>
        [Test]
        public void ChannelImageUrlTest()
        {
            // TODO unit test for the property 'ChannelImageUrl'
        }
        /// <summary>
        /// Test the property 'ProductCount'
        /// </summary>
        [Test]
        public void ProductCountTest()
        {
            // TODO unit test for the property 'ProductCount'
        }
        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }
        /// <summary>
        /// Test the property 'IsMarketplace'
        /// </summary>
        [Test]
        public void IsMarketplaceTest()
        {
            // TODO unit test for the property 'IsMarketplace'
        }
        /// <summary>
        /// Test the property 'ChannelCatalogId'
        /// </summary>
        [Test]
        public void ChannelCatalogIdTest()
        {
            // TODO unit test for the property 'ChannelCatalogId'
        }
        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Test]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'GeneralSettings'
        /// </summary>
        [Test]
        public void GeneralSettingsTest()
        {
            // TODO unit test for the property 'GeneralSettings'
        }
        /// <summary>
        /// Test the property 'CostSettings'
        /// </summary>
        [Test]
        public void CostSettingsTest()
        {
            // TODO unit test for the property 'CostSettings'
        }
        /// <summary>
        /// Test the property 'ColumnMappings'
        /// </summary>
        [Test]
        public void ColumnMappingsTest()
        {
            // TODO unit test for the property 'ColumnMappings'
        }
        /// <summary>
        /// Test the property 'ExclusionFilters'
        /// </summary>
        [Test]
        public void ExclusionFiltersTest()
        {
            // TODO unit test for the property 'ExclusionFilters'
        }
        /// <summary>
        /// Test the property 'ExportUrl'
        /// </summary>
        [Test]
        public void ExportUrlTest()
        {
            // TODO unit test for the property 'ExportUrl'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Types'
        /// </summary>
        [Test]
        public void TypesTest()
        {
            // TODO unit test for the property 'Types'
        }
        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Test]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }

    }

}
