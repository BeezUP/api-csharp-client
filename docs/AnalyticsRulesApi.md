# IO.Swagger.Api.AnalyticsRulesApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRule**](AnalyticsRulesApi.md#createrule) | **POST** /user/analytics/{storeId}/rules | Rule creation
[**DeleteRule**](AnalyticsRulesApi.md#deleterule) | **DELETE** /user/analytics/{storeId}/rules/{ruleId} | Delete Rule
[**DisableRule**](AnalyticsRulesApi.md#disablerule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/disable | Disable rule
[**EnableRule**](AnalyticsRulesApi.md#enablerule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/enable | Enable rule
[**GetRule**](AnalyticsRulesApi.md#getrule) | **GET** /user/analytics/{storeId}/rules/{ruleId} | Gets the rule
[**GetRules**](AnalyticsRulesApi.md#getrules) | **GET** /user/analytics/{storeId}/rules | Gets the list of rules for a given store
[**GetRulesExecutions**](AnalyticsRulesApi.md#getrulesexecutions) | **GET** /user/analytics/{storeId}/rules/executions | Get the rules execution history
[**MoveDownRule**](AnalyticsRulesApi.md#movedownrule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/movedown | Move the rule down
[**MoveUpRule**](AnalyticsRulesApi.md#moveuprule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/moveup | Move the rule up
[**RunRule**](AnalyticsRulesApi.md#runrule) | **POST** /user/analytics/{storeId}/rules/{ruleId}/run | Run rule
[**RunRules**](AnalyticsRulesApi.md#runrules) | **POST** /user/analytics/{storeId}/rules/run | Run all rules for this store
[**UpdateRule**](AnalyticsRulesApi.md#updaterule) | **PATCH** /user/analytics/{storeId}/rules/{ruleId} | Update Rule


<a name="createrule"></a>
# **CreateRule**
> void CreateRule (string storeId, CreateRuleRequest request)

Rule creation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new CreateRuleRequest(); // CreateRuleRequest | 

            try
            {
                // Rule creation
                apiInstance.CreateRule(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.CreateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**CreateRuleRequest**](CreateRuleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterule"></a>
# **DeleteRule**
> void DeleteRule (string storeId, string ruleId)

Delete Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Delete Rule
                apiInstance.DeleteRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.DeleteRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablerule"></a>
# **DisableRule**
> void DisableRule (string storeId, string ruleId)

Disable rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Disable rule
                apiInstance.DisableRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.DisableRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enablerule"></a>
# **EnableRule**
> void EnableRule (string storeId, string ruleId)

Enable rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnableRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Enable rule
                apiInstance.EnableRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.EnableRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrule"></a>
# **GetRule**
> Rule GetRule (string storeId, string ruleId)

Gets the rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Gets the rule
                Rule result = apiInstance.GetRule(storeId, ruleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.GetRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

[**Rule**](Rule.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrules"></a>
# **GetRules**
> RuleList GetRules (string storeId)

Gets the list of rules for a given store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRulesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Gets the list of rules for a given store
                RuleList result = apiInstance.GetRules(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.GetRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**RuleList**](RuleList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrulesexecutions"></a>
# **GetRulesExecutions**
> RuleExecutionReportings GetRulesExecutions (string storeId, int? pageNumber, int? pageSize)

Get the rules execution history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRulesExecutionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var pageNumber = 56;  // int? | The page to retrieve (default to 1)
            var pageSize = 56;  // int? | The count of rule history to retrieve (default to 10)

            try
            {
                // Get the rules execution history
                RuleExecutionReportings result = apiInstance.GetRulesExecutions(storeId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.GetRulesExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **pageNumber** | **int?**| The page to retrieve | [default to 1]
 **pageSize** | **int?**| The count of rule history to retrieve | [default to 10]

### Return type

[**RuleExecutionReportings**](RuleExecutionReportings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movedownrule"></a>
# **MoveDownRule**
> void MoveDownRule (string storeId, string ruleId)

Move the rule down

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoveDownRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Move the rule down
                apiInstance.MoveDownRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.MoveDownRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="moveuprule"></a>
# **MoveUpRule**
> void MoveUpRule (string storeId, string ruleId)

Move the rule up

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MoveUpRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Move the rule up
                apiInstance.MoveUpRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.MoveUpRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runrule"></a>
# **RunRule**
> void RunRule (string storeId, string ruleId)

Run rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Run rule
                apiInstance.RunRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.RunRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runrules"></a>
# **RunRules**
> void RunRules (string storeId)

Run all rules for this store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunRulesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Run all rules for this store
                apiInstance.RunRules(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.RunRules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterule"></a>
# **UpdateRule**
> void UpdateRule (string storeId, string ruleId, UpdateRuleRequest request)

Update Rule

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRuleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AnalyticsRulesApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier
            var request = new UpdateRuleRequest(); // UpdateRuleRequest | 

            try
            {
                // Update Rule
                apiInstance.UpdateRule(storeId, ruleId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnalyticsRulesApi.UpdateRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **ruleId** | **string**| Your rule identifier | 
 **request** | [**UpdateRuleRequest**](UpdateRuleRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

