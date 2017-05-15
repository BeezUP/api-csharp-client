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
    ///  Class for testing PublicSecuritySecurityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicSecuritySecurityApiTests
    {
        private PublicSecuritySecurityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicSecuritySecurityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicSecuritySecurityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicSecuritySecurityApi
            //Assert.IsInstanceOfType(typeof(PublicSecuritySecurityApi), instance, "instance is a PublicSecuritySecurityApi");
        }

        
        /// <summary>
        /// Test Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LoginRequest request = null;
            //var response = instance.Login(request);
            //Assert.IsInstanceOf<ApiCredentials> (response, "response is ApiCredentials");
        }
        
        /// <summary>
        /// Test LostPassword
        /// </summary>
        [Test]
        public void LostPasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BeezUPCommonEmail email = null;
            //instance.LostPassword(email);
            
        }
        
        /// <summary>
        /// Test Register
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RegisterRequest request = null;
            //instance.Register(request);
            
        }
        
    }

}
