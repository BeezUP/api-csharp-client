# IO.Swagger.Api.ReportsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteReportFilter**](ReportsApi.md#deletereportfilter) | **DELETE** /v2/user/analytics/{storeId}/reports/filters/{reportFilterId} | Delete the report filter
[**ExportStoreReportByCategory**](ReportsApi.md#exportstorereportbycategory) | **POST** /v2/user/analytics/{storeId}/reports/bycategory/export | Export the report by category
[**ExportStoreReportByChannel**](ReportsApi.md#exportstorereportbychannel) | **POST** /v2/user/analytics/{storeId}/reports/bychannel/export | Export the report by channel
[**ExportStoreReportByProduct**](ReportsApi.md#exportstorereportbyproduct) | **POST** /v2/user/analytics/{storeId}/reports/byproduct/export | Export the report by product
[**GetReportFilter**](ReportsApi.md#getreportfilter) | **GET** /v2/user/analytics/{storeId}/reports/filters/{reportFilterId} | Get the report filter description
[**GetReportFilters**](ReportsApi.md#getreportfilters) | **GET** /v2/user/analytics/{storeId}/reports/filters | Get report filter list for the given store
[**GetStoreReportByCategory**](ReportsApi.md#getstorereportbycategory) | **POST** /v2/user/analytics/{storeId}/reports/bycategory | Get the report by category
[**GetStoreReportByChannel**](ReportsApi.md#getstorereportbychannel) | **POST** /v2/user/analytics/{storeId}/reports/bychannel | Get the report by channel
[**GetStoreReportByDay**](ReportsApi.md#getstorereportbyday) | **POST** /v2/user/analytics/{storeId}/reports/byday | Get the report by day
[**GetStoreReportByDayExport**](ReportsApi.md#getstorereportbydayexport) | **POST** /v2/user/analytics/{storeId}/reports/byday/export | Get the report by day
[**GetStoreReportByProduct**](ReportsApi.md#getstorereportbyproduct) | **POST** /v2/user/analytics/{storeId}/reports/byproduct | Get the report by product
[**SaveReportFilter**](ReportsApi.md#savereportfilter) | **PUT** /v2/user/analytics/{storeId}/reports/filters/{reportFilterId} | Save the report filter


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

            var apiInstance = new ReportsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var reportFilterId = reportFilterId_example;  // string | Your report filter identifier

            try
            {
                // Delete the report filter
                apiInstance.DeleteReportFilter(storeId, reportFilterId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteReportFilter: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.ExportStoreReportByCategory: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.ExportStoreReportByChannel: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.ExportStoreReportByProduct: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.GetReportFilter: " + e.Message );
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

            var apiInstance = new ReportsApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get report filter list for the given store
                ReportFilters result = apiInstance.GetReportFilters(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportFilters: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.GetStoreReportByCategory: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.GetStoreReportByChannel: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.GetStoreReportByDay: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.GetStoreReportByDayExport: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.GetStoreReportByProduct: " + e.Message );
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

            var apiInstance = new ReportsApi();
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
                Debug.Print("Exception when calling ReportsApi.SaveReportFilter: " + e.Message );
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

