# IO.Swagger.Api.AnalyticsOptimisationsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Optimise**](AnalyticsOptimisationsApi.md#optimise) | **POST** /user/analytics/{storeId}/optimisations/{actionName} | Optimise products
[**OptimiseByCategory**](AnalyticsOptimisationsApi.md#optimisebycategory) | **POST** /user/analytics/{storeId}/optimisations/bycategory/{catalogCategoryId}/{actionName} | Optimise products&#39;s category
[**OptimiseByChannel**](AnalyticsOptimisationsApi.md#optimisebychannel) | **POST** /user/analytics/{storeId}/optimisations/bychannel/{channelId}/{actionName} | Optimise products&#39;s category
[**OptimiseByProduct**](AnalyticsOptimisationsApi.md#optimisebyproduct) | **POST** /user/analytics/{storeId}/optimisations/byproduct/{productId}/{actionName} | Optimise products


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

            var apiInstance = new AnalyticsOptimisationsApi();
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
                Debug.Print("Exception when calling AnalyticsOptimisationsApi.Optimise: " + e.Message );
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

            var apiInstance = new AnalyticsOptimisationsApi();
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
                Debug.Print("Exception when calling AnalyticsOptimisationsApi.OptimiseByCategory: " + e.Message );
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

            var apiInstance = new AnalyticsOptimisationsApi();
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
                Debug.Print("Exception when calling AnalyticsOptimisationsApi.OptimiseByChannel: " + e.Message );
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

            var apiInstance = new AnalyticsOptimisationsApi();
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
                Debug.Print("Exception when calling AnalyticsOptimisationsApi.OptimiseByProduct: " + e.Message );
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

