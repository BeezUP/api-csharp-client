# IO.Swagger.Api.V2UserAnalyticsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRule**](V2UserAnalyticsApi.md#createrule) | **POST** /v2/user/analytics/{storeId}/rules | Rule creation
[**DeleteReportFilter**](V2UserAnalyticsApi.md#deletereportfilter) | **DELETE** /v2/user/analytics/{storeId}/reports/filters/{reportFilterId} | Delete the report filter
[**DeleteRule**](V2UserAnalyticsApi.md#deleterule) | **DELETE** /v2/user/analytics/{storeId}/rules/{ruleId} | Delete Rule
[**DisableRule**](V2UserAnalyticsApi.md#disablerule) | **POST** /v2/user/analytics/{storeId}/rules/{ruleId}/disable | Disable rule
[**EnableRule**](V2UserAnalyticsApi.md#enablerule) | **POST** /v2/user/analytics/{storeId}/rules/{ruleId}/enable | Enable rule
[**ExportStoreReportByCategory**](V2UserAnalyticsApi.md#exportstorereportbycategory) | **POST** /v2/user/analytics/{storeId}/reports/bycategory/export | Export the report by category
[**ExportStoreReportByChannel**](V2UserAnalyticsApi.md#exportstorereportbychannel) | **POST** /v2/user/analytics/{storeId}/reports/bychannel/export | Export the report by channel
[**ExportStoreReportByProduct**](V2UserAnalyticsApi.md#exportstorereportbyproduct) | **POST** /v2/user/analytics/{storeId}/reports/byproduct/export | Export the report by product
[**GetReportFilter**](V2UserAnalyticsApi.md#getreportfilter) | **GET** /v2/user/analytics/{storeId}/reports/filters/{reportFilterId} | Get the report filter description
[**GetReportFilters**](V2UserAnalyticsApi.md#getreportfilters) | **GET** /v2/user/analytics/{storeId}/reports/filters | Get report filter list for the given store
[**GetRule**](V2UserAnalyticsApi.md#getrule) | **GET** /v2/user/analytics/{storeId}/rules/{ruleId} | Gets the rule
[**GetRules**](V2UserAnalyticsApi.md#getrules) | **GET** /v2/user/analytics/{storeId}/rules | Gets the list of rules for a given store
[**GetRulesExecutions**](V2UserAnalyticsApi.md#getrulesexecutions) | **GET** /v2/user/analytics/{storeId}/rules/executions | Get the rules execution history
[**GetStoreReportByCategory**](V2UserAnalyticsApi.md#getstorereportbycategory) | **POST** /v2/user/analytics/{storeId}/reports/bycategory | Get the report by category
[**GetStoreReportByChannel**](V2UserAnalyticsApi.md#getstorereportbychannel) | **POST** /v2/user/analytics/{storeId}/reports/bychannel | Get the report by channel
[**GetStoreReportByDay**](V2UserAnalyticsApi.md#getstorereportbyday) | **POST** /v2/user/analytics/{storeId}/reports/byday | Get the report by day
[**GetStoreReportByDayExport**](V2UserAnalyticsApi.md#getstorereportbydayexport) | **POST** /v2/user/analytics/{storeId}/reports/byday/export | Get the report by day
[**GetStoreReportByProduct**](V2UserAnalyticsApi.md#getstorereportbyproduct) | **POST** /v2/user/analytics/{storeId}/reports/byproduct | Get the report by product
[**GetStoreTrackedClicks**](V2UserAnalyticsApi.md#getstoretrackedclicks) | **GET** /v2/user/analytics/{storeId}/tracking/clicks | Get the latest clicks tracked
[**GetStoreTrackedExternalOrders**](V2UserAnalyticsApi.md#getstoretrackedexternalorders) | **GET** /v2/user/analytics/{storeId}/tracking/externalorders | Get the latest external orders tracked
[**GetStoreTrackedOrders**](V2UserAnalyticsApi.md#getstoretrackedorders) | **GET** /v2/user/analytics/{storeId}/tracking/orders | Get the latest orders tracked
[**GetStoreTrackingStatus**](V2UserAnalyticsApi.md#getstoretrackingstatus) | **GET** /v2/user/analytics/{storeId}/tracking/status | Get store tracking synchronization status
[**GetTrackingStatus**](V2UserAnalyticsApi.md#gettrackingstatus) | **GET** /v2/user/analytics/tracking/status | Display the synchronization status of the clicks and orders
[**MoveDownRule**](V2UserAnalyticsApi.md#movedownrule) | **POST** /v2/user/analytics/{storeId}/rules/{ruleId}/movedown | Move the rule down
[**MoveUpRule**](V2UserAnalyticsApi.md#moveuprule) | **POST** /v2/user/analytics/{storeId}/rules/{ruleId}/moveup | Move the rule up
[**Optimise**](V2UserAnalyticsApi.md#optimise) | **POST** /v2/user/analytics/{storeId}/optimisations/{actionName} | Optimise products
[**OptimiseByCategory**](V2UserAnalyticsApi.md#optimisebycategory) | **POST** /v2/user/analytics/{storeId}/optimisations/bycategory/{catalogCategoryId}/{actionName} | Optimise products&#39;s category
[**OptimiseByChannel**](V2UserAnalyticsApi.md#optimisebychannel) | **POST** /v2/user/analytics/{storeId}/optimisations/bychannel/{channelId}/{actionName} | Optimise products&#39;s category
[**OptimiseByProduct**](V2UserAnalyticsApi.md#optimisebyproduct) | **POST** /v2/user/analytics/{storeId}/optimisations/byproduct/{productId}/{actionName} | Optimise products
[**RunRule**](V2UserAnalyticsApi.md#runrule) | **POST** /v2/user/analytics/{storeId}/rules/{ruleId}/run | Run rule
[**RunRules**](V2UserAnalyticsApi.md#runrules) | **POST** /v2/user/analytics/{storeId}/rules/run | Run all rules for this store
[**SaveReportFilter**](V2UserAnalyticsApi.md#savereportfilter) | **PUT** /v2/user/analytics/{storeId}/reports/filters/{reportFilterId} | Save the report filter
[**UpdateRule**](V2UserAnalyticsApi.md#updaterule) | **PATCH** /v2/user/analytics/{storeId}/rules/{ruleId} | Update Rule


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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new CreateRuleRequest(); // CreateRuleRequest | 

            try
            {
                // Rule creation
                apiInstance.CreateRule(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.CreateRule: " + e.Message );
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

<a name="deletereportfilter"></a>
# **DeleteReportFilter**
> void DeleteReportFilter (string storeId, string reportFilterId)

Delete the report filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteReportFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier

            try
            {
                // Delete the report filter
                apiInstance.DeleteReportFilter(storeId, reportFilterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.DeleteReportFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **reportFilterId** | **string**| Your report filter identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Delete Rule
                apiInstance.DeleteRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.DeleteRule: " + e.Message );
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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Disable rule
                apiInstance.DisableRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.DisableRule: " + e.Message );
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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Enable rule
                apiInstance.EnableRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.EnableRule: " + e.Message );
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

<a name="exportstorereportbycategory"></a>
# **ExportStoreReportByCategory**
> List<BeezUPCommonLink2> ExportStoreReportByCategory (string storeId, string format, ReportByCategoryRequest request)

Export the report by category

Export the report by category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportStoreReportByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByCategoryRequest(); // ReportByCategoryRequest | 

            try
            {
                // Export the report by category
                List&lt;BeezUPCommonLink2&gt; result = apiInstance.ExportStoreReportByCategory(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.ExportStoreReportByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByCategoryRequest**](ReportByCategoryRequest.md)|  | 

### Return type

[**List<BeezUPCommonLink2>**](BeezUPCommonLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportstorereportbychannel"></a>
# **ExportStoreReportByChannel**
> List<BeezUPCommonLink2> ExportStoreReportByChannel (string storeId, string format, ReportByChannelRequest request)

Export the report by channel

Export the report by channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportStoreReportByChannelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByChannelRequest(); // ReportByChannelRequest | 

            try
            {
                // Export the report by channel
                List&lt;BeezUPCommonLink2&gt; result = apiInstance.ExportStoreReportByChannel(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.ExportStoreReportByChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByChannelRequest**](ReportByChannelRequest.md)|  | 

### Return type

[**List<BeezUPCommonLink2>**](BeezUPCommonLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportstorereportbyproduct"></a>
# **ExportStoreReportByProduct**
> List<BeezUPCommonLink2> ExportStoreReportByProduct (string storeId, string format, ReportByProductRequest request)

Export the report by product

Export the report by product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportStoreReportByProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByProductRequest(); // ReportByProductRequest | 

            try
            {
                // Export the report by product
                List&lt;BeezUPCommonLink2&gt; result = apiInstance.ExportStoreReportByProduct(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.ExportStoreReportByProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByProductRequest**](ReportByProductRequest.md)|  | 

### Return type

[**List<BeezUPCommonLink2>**](BeezUPCommonLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportfilter"></a>
# **GetReportFilter**
> ReportFilter GetReportFilter (string storeId, string reportFilterId)

Get the report filter description

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier

            try
            {
                // Get the report filter description
                ReportFilter result = apiInstance.GetReportFilter(storeId, reportFilterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetReportFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **reportFilterId** | **string**| Your report filter identifier | 

### Return type

[**ReportFilter**](ReportFilter.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportfilters"></a>
# **GetReportFilters**
> ReportFilters GetReportFilters (string storeId)

Get report filter list for the given store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReportFiltersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get report filter list for the given store
                ReportFilters result = apiInstance.GetReportFilters(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetReportFilters: " + e.Message );
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

[**ReportFilters**](ReportFilters.md)

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

            var apiInstance = new V2UserAnalyticsApi();
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
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetRule: " + e.Message );
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
> Rules GetRules (string storeId)

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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Gets the list of rules for a given store
                Rules result = apiInstance.GetRules(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetRules: " + e.Message );
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

[**Rules**](Rules.md)

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

            var apiInstance = new V2UserAnalyticsApi();
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
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetRulesExecutions: " + e.Message );
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

<a name="getstorereportbycategory"></a>
# **GetStoreReportByCategory**
> ReportByCategoryResponse GetStoreReportByCategory (string storeId, ReportByCategoryRequest request)

Get the report by category

Get the report by category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByCategoryRequest(); // ReportByCategoryRequest | 

            try
            {
                // Get the report by category
                ReportByCategoryResponse result = apiInstance.GetStoreReportByCategory(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreReportByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByCategoryRequest**](ReportByCategoryRequest.md)|  | 

### Return type

[**ReportByCategoryResponse**](ReportByCategoryResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbychannel"></a>
# **GetStoreReportByChannel**
> ReportByChannelResponse GetStoreReportByChannel (string storeId, ReportByChannelRequest request)

Get the report by channel

Get the report by channel

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByChannelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByChannelRequest(); // ReportByChannelRequest | 

            try
            {
                // Get the report by channel
                ReportByChannelResponse result = apiInstance.GetStoreReportByChannel(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreReportByChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByChannelRequest**](ReportByChannelRequest.md)|  | 

### Return type

[**ReportByChannelResponse**](ReportByChannelResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbyday"></a>
# **GetStoreReportByDay**
> ReportByDayResponse GetStoreReportByDay (string storeId, ReportByDayRequest request)

Get the report by day

Get the report by day

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByDayExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByDayRequest(); // ReportByDayRequest | 

            try
            {
                // Get the report by day
                ReportByDayResponse result = apiInstance.GetStoreReportByDay(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreReportByDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByDayRequest**](ReportByDayRequest.md)|  | 

### Return type

[**ReportByDayResponse**](ReportByDayResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbydayexport"></a>
# **GetStoreReportByDayExport**
> List<BeezUPCommonLink2> GetStoreReportByDayExport (string storeId, string format, ReportByDayRequest request)

Get the report by day

Get the report by day

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByDayExportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var format = format_example;  // string | 
            var request = new ReportByDayRequest(); // ReportByDayRequest | 

            try
            {
                // Get the report by day
                List&lt;BeezUPCommonLink2&gt; result = apiInstance.GetStoreReportByDayExport(storeId, format, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreReportByDayExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **format** | **string**|  | 
 **request** | [**ReportByDayRequest**](ReportByDayRequest.md)|  | 

### Return type

[**List<BeezUPCommonLink2>**](BeezUPCommonLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorereportbyproduct"></a>
# **GetStoreReportByProduct**
> ReportByProductResponse GetStoreReportByProduct (string storeId, ReportByProductRequest request)

Get the report by product

Get the report by product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreReportByProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ReportByProductRequest(); // ReportByProductRequest | 

            try
            {
                // Get the report by product
                ReportByProductResponse result = apiInstance.GetStoreReportByProduct(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreReportByProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ReportByProductRequest**](ReportByProductRequest.md)|  | 

### Return type

[**ReportByProductResponse**](ReportByProductResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackedclicks"></a>
# **GetStoreTrackedClicks**
> TrackedClicks GetStoreTrackedClicks (string storeId, int? count = null)

Get the latest clicks tracked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackedClicksExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 56;  // int? | The click's count you want to get (optional)  (default to 100)

            try
            {
                // Get the latest clicks tracked
                TrackedClicks result = apiInstance.GetStoreTrackedClicks(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreTrackedClicks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The click&#39;s count you want to get | [optional] [default to 100]

### Return type

[**TrackedClicks**](TrackedClicks.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackedexternalorders"></a>
# **GetStoreTrackedExternalOrders**
> TrackedExternalOrders GetStoreTrackedExternalOrders (string storeId, int? count = null)

Get the latest external orders tracked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackedExternalOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 56;  // int? | The external order's count you want to get (optional)  (default to 100)

            try
            {
                // Get the latest external orders tracked
                TrackedExternalOrders result = apiInstance.GetStoreTrackedExternalOrders(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreTrackedExternalOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The external order&#39;s count you want to get | [optional] [default to 100]

### Return type

[**TrackedExternalOrders**](TrackedExternalOrders.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackedorders"></a>
# **GetStoreTrackedOrders**
> TrackedOrders GetStoreTrackedOrders (string storeId, int? count = null)

Get the latest orders tracked

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackedOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 56;  // int? | The order's count you want to get (optional)  (default to 100)

            try
            {
                // Get the latest orders tracked
                TrackedOrders result = apiInstance.GetStoreTrackedOrders(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreTrackedOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The order&#39;s count you want to get | [optional] [default to 100]

### Return type

[**TrackedOrders**](TrackedOrders.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstoretrackingstatus"></a>
# **GetStoreTrackingStatus**
> StoreTrackingStatus GetStoreTrackingStatus (string storeId)

Get store tracking synchronization status

Your clicks and orders are eventually consistent. \\ This operation indicates you at which date the projections are for this store. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreTrackingStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store tracking synchronization status
                StoreTrackingStatus result = apiInstance.GetStoreTrackingStatus(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetStoreTrackingStatus: " + e.Message );
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

[**StoreTrackingStatus**](StoreTrackingStatus.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrackingstatus"></a>
# **GetTrackingStatus**
> TrackingStatus GetTrackingStatus ()

Display the synchronization status of the clicks and orders

Your clicks and orders are eventually consistent. \\ This operation indicates you at which date the projections are. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrackingStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();

            try
            {
                // Display the synchronization status of the clicks and orders
                TrackingStatus result = apiInstance.GetTrackingStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.GetTrackingStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TrackingStatus**](TrackingStatus.md)

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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Move the rule down
                apiInstance.MoveDownRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.MoveDownRule: " + e.Message );
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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Move the rule up
                apiInstance.MoveUpRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.MoveUpRule: " + e.Message );
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

<a name="optimise"></a>
# **Optimise**
> void Optimise (string storeId, string actionName, OptimiseRequest request)

Optimise products

/!\\ WARNING /!\\ \\ Apply the operation on every product related to this request. \\ This operation is used at the bottom of the analytics page result. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var actionName = actionName_example;  // string | 
            var request = new OptimiseRequest(); // OptimiseRequest | 

            try
            {
                // Optimise products
                apiInstance.Optimise(storeId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.Optimise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **actionName** | **string**|  | 
 **request** | [**OptimiseRequest**](OptimiseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimisebycategory"></a>
# **OptimiseByCategory**
> void OptimiseByCategory (string storeId, string catalogCategoryId, string actionName, List<string> request = null)

Optimise products's category

/!\\ WARNING /!\\ \\ This operation will reenable or disable products's category for every channel indicated in the body.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseByCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var catalogCategoryId = catalogCategoryId_example;  // string | The category identifier concerned by this optimisation
            var actionName = actionName_example;  // string | 
            var request = ;  // List<string> | The channel identifier list concerned by this optimisation (optional) 

            try
            {
                // Optimise products's category
                apiInstance.OptimiseByCategory(storeId, catalogCategoryId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.OptimiseByCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **catalogCategoryId** | **string**| The category identifier concerned by this optimisation | 
 **actionName** | **string**|  | 
 **request** | **List&lt;string&gt;**| The channel identifier list concerned by this optimisation | [optional] 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimisebychannel"></a>
# **OptimiseByChannel**
> void OptimiseByChannel (string storeId, string channelId, string actionName)

Optimise products's category

/!\\ WARNING /!\\ \\ Apply the operation on every product on this channel. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseByChannelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var channelId = channelId_example;  // string | The channel identifier concerned by this optimisation
            var actionName = actionName_example;  // string | 

            try
            {
                // Optimise products's category
                apiInstance.OptimiseByChannel(storeId, channelId, actionName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.OptimiseByChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **channelId** | **string**| The channel identifier concerned by this optimisation | 
 **actionName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="optimisebyproduct"></a>
# **OptimiseByProduct**
> void OptimiseByProduct (string storeId, string productId, string actionName, List<string> request = null)

Optimise products

/!\\ WARNING /!\\ \\ This operation will reenable or disable this product for every channel indicated in the body.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OptimiseByProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var productId = productId_example;  // string | The product identifier concerned by this optimisation
            var actionName = actionName_example;  // string | 
            var request = ;  // List<string> | The channel identifier list concerned by this optimisation (optional) 

            try
            {
                // Optimise products
                apiInstance.OptimiseByProduct(storeId, productId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.OptimiseByProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **productId** | **string**| The product identifier concerned by this optimisation | 
 **actionName** | **string**|  | 
 **request** | **List&lt;string&gt;**| The channel identifier list concerned by this optimisation | [optional] 

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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var ruleId = ruleId_example;  // string | Your rule identifier

            try
            {
                // Run rule
                apiInstance.RunRule(storeId, ruleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.RunRule: " + e.Message );
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

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Run all rules for this store
                apiInstance.RunRules(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.RunRules: " + e.Message );
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

<a name="savereportfilter"></a>
# **SaveReportFilter**
> void SaveReportFilter (string storeId, string reportFilterId, SaveReportFilterRequest reportFilter)

Save the report filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveReportFilterExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserAnalyticsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier
            var reportFilter = new SaveReportFilterRequest(); // SaveReportFilterRequest | 

            try
            {
                // Save the report filter
                apiInstance.SaveReportFilter(storeId, reportFilterId, reportFilter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserAnalyticsApi.SaveReportFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **reportFilterId** | **string**| Your report filter identifier | 
 **reportFilter** | [**SaveReportFilterRequest**](SaveReportFilterRequest.md)|  | 

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

            var apiInstance = new V2UserAnalyticsApi();
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
                Debug.Print("Exception when calling V2UserAnalyticsApi.UpdateRule: " + e.Message );
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

