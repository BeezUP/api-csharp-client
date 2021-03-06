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
    ///  Class for testing V2UserCustomerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class V2UserCustomerApiTests
    {
        private V2UserCustomerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new V2UserCustomerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V2UserCustomerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' V2UserCustomerApi
            //Assert.IsInstanceOfType(typeof(V2UserCustomerApi), instance, "instance is a V2UserCustomerApi");
        }

        
        /// <summary>
        /// Test ActivateUserAccount
        /// </summary>
        [Test]
        public void ActivateUserAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emailActivationId = null;
            //instance.ActivateUserAccount(emailActivationId);
            
        }
        
        /// <summary>
        /// Test ChangePassword
        /// </summary>
        [Test]
        public void ChangePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChangePasswordRequest request = null;
            //instance.ChangePassword(request);
            
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
        /// Test DeleteNextContract
        /// </summary>
        [Test]
        public void DeleteNextContractTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteNextContract();
            
        }
        
        /// <summary>
        /// Test DeleteShare
        /// </summary>
        [Test]
        public void DeleteShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string userId = null;
            //instance.DeleteShare(storeId, userId);
            
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
        /// Test GetCreditCardInfo
        /// </summary>
        [Test]
        public void GetCreditCardInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCreditCardInfo();
            //Assert.IsInstanceOf<CreditCardInfoResponse> (response, "response is CreditCardInfoResponse");
        }
        
        /// <summary>
        /// Test GetFriendInfo
        /// </summary>
        [Test]
        public void GetFriendInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.GetFriendInfo(userId);
            //Assert.IsInstanceOf<UserFriendInfo> (response, "response is UserFriendInfo");
        }
        
        /// <summary>
        /// Test GetInvoices
        /// </summary>
        [Test]
        public void GetInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetInvoices();
            //Assert.IsInstanceOf<Invoices> (response, "response is Invoices");
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
        /// Test GetRights
        /// </summary>
        [Test]
        public void GetRightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //List<string> functionalityCodeList = null;
            //var response = instance.GetRights(storeId, functionalityCodeList);
            //Assert.IsInstanceOf<List<FunctionalityRightInfo>> (response, "response is List<FunctionalityRightInfo>");
        }
        
        /// <summary>
        /// Test GetShares
        /// </summary>
        [Test]
        public void GetSharesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetShares(storeId);
            //Assert.IsInstanceOf<StoreShares> (response, "response is StoreShares");
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
        /// Test GetUserAccountInfo
        /// </summary>
        [Test]
        public void GetUserAccountInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserAccountInfo();
            //Assert.IsInstanceOf<AccountInfo> (response, "response is AccountInfo");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Logout();
            
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
        /// Test ResendEmailActivation
        /// </summary>
        [Test]
        public void ResendEmailActivationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ResendEmailActivation();
            
        }
        
        /// <summary>
        /// Test SaveCompanyInfo
        /// </summary>
        [Test]
        public void SaveCompanyInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompanyInfo request = null;
            //instance.SaveCompanyInfo(request);
            
        }
        
        /// <summary>
        /// Test SaveCreditCardInfo
        /// </summary>
        [Test]
        public void SaveCreditCardInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreditCardInfo request = null;
            //instance.SaveCreditCardInfo(request);
            
        }
        
        /// <summary>
        /// Test SavePersonalInfo
        /// </summary>
        [Test]
        public void SavePersonalInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PersonalInfo request = null;
            //instance.SavePersonalInfo(request);
            
        }
        
        /// <summary>
        /// Test SaveProfilePictureInfo
        /// </summary>
        [Test]
        public void SaveProfilePictureInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProfilePictureInfo request = null;
            //instance.SaveProfilePictureInfo(request);
            
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
        
        /// <summary>
        /// Test Share
        /// </summary>
        [Test]
        public void ShareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //FriendEmail email = null;
            //instance.Share(storeId, email);
            
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
