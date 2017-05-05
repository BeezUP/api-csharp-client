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
    ///  Class for testing ContractsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContractsApiTests
    {
        private ContractsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContractsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContractsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContractsApi
            //Assert.IsInstanceOfType(typeof(ContractsApi), instance, "instance is a ContractsApi");
        }

        
        /// <summary>
        /// Test CreateContract
        /// </summary>
        [Test]
        public void CreateContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateContract request = null;
            //var response = instance.CreateContract(request);
            //Assert.IsInstanceOf<BeezUPCommonInfoSummaries> (response, "response is BeezUPCommonInfoSummaries");
        }
        
        /// <summary>
        /// Test DeleteNextContract
        /// </summary>
        [Test]
        public void DeleteNextContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteNextContract();
            
        }
        
        /// <summary>
        /// Test GetBillingPeriods
        /// </summary>
        [Test]
        public void GetBillingPeriodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBillingPeriods();
            //Assert.IsInstanceOf<BillingPeriods> (response, "response is BillingPeriods");
        }
        
        /// <summary>
        /// Test GetContracts
        /// </summary>
        [Test]
        public void GetContractsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetContracts();
            //Assert.IsInstanceOf<Contracts> (response, "response is Contracts");
        }
        
        /// <summary>
        /// Test GetOffer
        /// </summary>
        [Test]
        public void GetOfferTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OfferRequest request = null;
            //var response = instance.GetOffer(request);
            //Assert.IsInstanceOf<Offer> (response, "response is Offer");
        }
        
        /// <summary>
        /// Test GetStandardOffers
        /// </summary>
        [Test]
        public void GetStandardOffersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStandardOffers();
            //Assert.IsInstanceOf<StandardOffers> (response, "response is StandardOffers");
        }
        
        /// <summary>
        /// Test ReactivateCurrentContract
        /// </summary>
        [Test]
        public void ReactivateCurrentContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ReactivateCurrentContract();
            
        }
        
        /// <summary>
        /// Test TerminateCurrentContract
        /// </summary>
        [Test]
        public void TerminateCurrentContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TerminateContract request = null;
            //instance.TerminateCurrentContract(request);
            
        }
        
    }

}
