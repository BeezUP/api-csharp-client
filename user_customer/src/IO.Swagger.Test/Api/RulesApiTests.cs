/* 
 * Analytics
 *
 * This API will help you to manage the tracking of your clicks and your sales, get reporting on this trackings and put in place rules based on this reporting to automatically optimize your channel catalogs. \\ Also, you will be able to consult the rule execution reporting. 
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
    ///  Class for testing RulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RulesApiTests
    {
        private RulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RulesApi
            //Assert.IsInstanceOfType(typeof(RulesApi), instance, "instance is a RulesApi");
        }

        
        /// <summary>
        /// Test CreateRule
        /// </summary>
        [Test]
        public void CreateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //CreateRuleRequest request = null;
            //instance.CreateRule(storeId, request);
            
        }
        
        /// <summary>
        /// Test DeleteRule
        /// </summary>
        [Test]
        public void DeleteRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //instance.DeleteRule(storeId, ruleId);
            
        }
        
        /// <summary>
        /// Test DisableRule
        /// </summary>
        [Test]
        public void DisableRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //instance.DisableRule(storeId, ruleId);
            
        }
        
        /// <summary>
        /// Test EnableRule
        /// </summary>
        [Test]
        public void EnableRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //instance.EnableRule(storeId, ruleId);
            
        }
        
        /// <summary>
        /// Test GetRule
        /// </summary>
        [Test]
        public void GetRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //var response = instance.GetRule(storeId, ruleId);
            //Assert.IsInstanceOf<Rule> (response, "response is Rule");
        }
        
        /// <summary>
        /// Test GetRules
        /// </summary>
        [Test]
        public void GetRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //var response = instance.GetRules(storeId);
            //Assert.IsInstanceOf<RuleList> (response, "response is RuleList");
        }
        
        /// <summary>
        /// Test GetRulesExecutions
        /// </summary>
        [Test]
        public void GetRulesExecutionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.GetRulesExecutions(storeId, pageNumber, pageSize);
            //Assert.IsInstanceOf<RuleExecutionReportings> (response, "response is RuleExecutionReportings");
        }
        
        /// <summary>
        /// Test MoveDownRule
        /// </summary>
        [Test]
        public void MoveDownRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //instance.MoveDownRule(storeId, ruleId);
            
        }
        
        /// <summary>
        /// Test MoveUpRule
        /// </summary>
        [Test]
        public void MoveUpRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //instance.MoveUpRule(storeId, ruleId);
            
        }
        
        /// <summary>
        /// Test RunRule
        /// </summary>
        [Test]
        public void RunRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //instance.RunRule(storeId, ruleId);
            
        }
        
        /// <summary>
        /// Test RunRules
        /// </summary>
        [Test]
        public void RunRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //instance.RunRules(storeId);
            
        }
        
        /// <summary>
        /// Test UpdateRule
        /// </summary>
        [Test]
        public void UpdateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string ruleId = null;
            //UpdateRuleRequest request = null;
            //instance.UpdateRule(storeId, ruleId, request);
            
        }
        
    }

}
