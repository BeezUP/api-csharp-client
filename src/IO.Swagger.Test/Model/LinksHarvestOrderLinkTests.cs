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
    ///  Class for testing LinksHarvestOrderLink
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LinksHarvestOrderLinkTests
    {
        // TODO uncomment below to declare an instance variable for LinksHarvestOrderLink
        //private LinksHarvestOrderLink instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LinksHarvestOrderLink
            //instance = new LinksHarvestOrderLink();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LinksHarvestOrderLink
        /// </summary>
        [Test]
        public void LinksHarvestOrderLinkInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LinksHarvestOrderLink
            //Assert.IsInstanceOfType<LinksHarvestOrderLink> (instance, "variable 'instance' is a LinksHarvestOrderLink");
        }

        /// <summary>
        /// Test the property 'DocUrl'
        /// </summary>
        [Test]
        public void DocUrlTest()
        {
            // TODO unit test for the property 'DocUrl'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Href'
        /// </summary>
        [Test]
        public void HrefTest()
        {
            // TODO unit test for the property 'Href'
        }
        /// <summary>
        /// Test the property 'OperationId'
        /// </summary>
        [Test]
        public void OperationIdTest()
        {
            // TODO unit test for the property 'OperationId'
        }
        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Test]
        public void MethodTest()
        {
            // TODO unit test for the property 'Method'
        }
        /// <summary>
        /// Test the property 'Parameters'
        /// </summary>
        [Test]
        public void ParametersTest()
        {
            // TODO unit test for the property 'Parameters'
        }
        /// <summary>
        /// Test the property 'Templated'
        /// </summary>
        [Test]
        public void TemplatedTest()
        {
            // TODO unit test for the property 'Templated'
        }
        /// <summary>
        /// Test the property 'Info'
        /// </summary>
        [Test]
        public void InfoTest()
        {
            // TODO unit test for the property 'Info'
        }

    }

}