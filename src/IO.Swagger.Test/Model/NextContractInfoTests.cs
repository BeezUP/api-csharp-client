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
    ///  Class for testing NextContractInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NextContractInfoTests
    {
        // TODO uncomment below to declare an instance variable for NextContractInfo
        //private NextContractInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NextContractInfo
            //instance = new NextContractInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NextContractInfo
        /// </summary>
        [Test]
        public void NextContractInfoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NextContractInfo
            //Assert.IsInstanceOfType<NextContractInfo> (instance, "variable 'instance' is a NextContractInfo");
        }

        /// <summary>
        /// Test the property 'TrialPeriodInMonth'
        /// </summary>
        [Test]
        public void TrialPeriodInMonthTest()
        {
            // TODO unit test for the property 'TrialPeriodInMonth'
        }
        /// <summary>
        /// Test the property 'BillingPeriodPercentDiscount'
        /// </summary>
        [Test]
        public void BillingPeriodPercentDiscountTest()
        {
            // TODO unit test for the property 'BillingPeriodPercentDiscount'
        }
        /// <summary>
        /// Test the property 'DiscountDurationInMonth'
        /// </summary>
        [Test]
        public void DiscountDurationInMonthTest()
        {
            // TODO unit test for the property 'DiscountDurationInMonth'
        }
        /// <summary>
        /// Test the property 'PercentDiscount'
        /// </summary>
        [Test]
        public void PercentDiscountTest()
        {
            // TODO unit test for the property 'PercentDiscount'
        }
        /// <summary>
        /// Test the property 'OfferId'
        /// </summary>
        [Test]
        public void OfferIdTest()
        {
            // TODO unit test for the property 'OfferId'
        }
        /// <summary>
        /// Test the property 'StoreCount'
        /// </summary>
        [Test]
        public void StoreCountTest()
        {
            // TODO unit test for the property 'StoreCount'
        }
        /// <summary>
        /// Test the property 'StartUtcDate'
        /// </summary>
        [Test]
        public void StartUtcDateTest()
        {
            // TODO unit test for the property 'StartUtcDate'
        }
        /// <summary>
        /// Test the property 'CommitmentCalculatedFinishUtcDate'
        /// </summary>
        [Test]
        public void CommitmentCalculatedFinishUtcDateTest()
        {
            // TODO unit test for the property 'CommitmentCalculatedFinishUtcDate'
        }
        /// <summary>
        /// Test the property 'BillingPeriodInMonth'
        /// </summary>
        [Test]
        public void BillingPeriodInMonthTest()
        {
            // TODO unit test for the property 'BillingPeriodInMonth'
        }
        /// <summary>
        /// Test the property 'FixedPrice'
        /// </summary>
        [Test]
        public void FixedPriceTest()
        {
            // TODO unit test for the property 'FixedPrice'
        }
        /// <summary>
        /// Test the property 'OfferName'
        /// </summary>
        [Test]
        public void OfferNameTest()
        {
            // TODO unit test for the property 'OfferName'
        }
        /// <summary>
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Test]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'ContractId'
        /// </summary>
        [Test]
        public void ContractIdTest()
        {
            // TODO unit test for the property 'ContractId'
        }
        /// <summary>
        /// Test the property 'CommitmentPeriodInMonth'
        /// </summary>
        [Test]
        public void CommitmentPeriodInMonthTest()
        {
            // TODO unit test for the property 'CommitmentPeriodInMonth'
        }
        /// <summary>
        /// Test the property 'ClickIncluded'
        /// </summary>
        [Test]
        public void ClickIncludedTest()
        {
            // TODO unit test for the property 'ClickIncluded'
        }
        /// <summary>
        /// Test the property 'AdditionalClickPrice'
        /// </summary>
        [Test]
        public void AdditionalClickPriceTest()
        {
            // TODO unit test for the property 'AdditionalClickPrice'
        }
        /// <summary>
        /// Test the property 'IpUserCreation'
        /// </summary>
        [Test]
        public void IpUserCreationTest()
        {
            // TODO unit test for the property 'IpUserCreation'
        }
        /// <summary>
        /// Test the property 'IpUserModification'
        /// </summary>
        [Test]
        public void IpUserModificationTest()
        {
            // TODO unit test for the property 'IpUserModification'
        }
        /// <summary>
        /// Test the property 'FixedAndVariableClickInfo'
        /// </summary>
        [Test]
        public void FixedAndVariableClickInfoTest()
        {
            // TODO unit test for the property 'FixedAndVariableClickInfo'
        }
        /// <summary>
        /// Test the property 'VariableModelInfo'
        /// </summary>
        [Test]
        public void VariableModelInfoTest()
        {
            // TODO unit test for the property 'VariableModelInfo'
        }
        /// <summary>
        /// Test the property 'IsCommitmentRenewalAutomatically'
        /// </summary>
        [Test]
        public void IsCommitmentRenewalAutomaticallyTest()
        {
            // TODO unit test for the property 'IsCommitmentRenewalAutomatically'
        }
        /// <summary>
        /// Test the property 'DiscountEndUtcDate'
        /// </summary>
        [Test]
        public void DiscountEndUtcDateTest()
        {
            // TODO unit test for the property 'DiscountEndUtcDate'
        }
        /// <summary>
        /// Test the property 'IsModifiableContract'
        /// </summary>
        [Test]
        public void IsModifiableContractTest()
        {
            // TODO unit test for the property 'IsModifiableContract'
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
