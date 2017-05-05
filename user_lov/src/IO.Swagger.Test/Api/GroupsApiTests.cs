/* 
 * User - List of Values
 *
 * This API gives you access to list of values.
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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //Assert.IsInstanceOfType(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test GetUserListGroup
        /// </summary>
        [Test]
        public void GetUserListGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string listGroupName = null;
            //var response = instance.GetUserListGroup(listGroupName);
            //Assert.IsInstanceOf<List<BeezUPCommonLOVLink2>> (response, "response is List<BeezUPCommonLOVLink2>");
        }
        
        /// <summary>
        /// Test GetUserListGroupNames
        /// </summary>
        [Test]
        public void GetUserListGroupNamesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserListGroupNames();
            //Assert.IsInstanceOf<List<BeezUPCommonLOVLink2>> (response, "response is List<BeezUPCommonLOVLink2>");
        }
        
    }

}
