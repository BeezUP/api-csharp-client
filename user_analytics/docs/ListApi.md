# IO.Swagger.Api.ListApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderListFull**](ListApi.md#getorderlistfull) | **POST** /v2/user/marketplaces/orders/list/full | Get order list with all order properties and all order items.
[**GetOrderListLight**](ListApi.md#getorderlistlight) | **POST** /v2/user/marketplaces/orders/list/light | Get order list without details


<a name="getorderlistfull"></a>
# **GetOrderListFull**
> OrderListFull GetOrderListFull (List<string> acceptEncoding, OrderListRequest request = null)

Get order list with all order properties and all order items.

The purpose of this API is to reduce the request count.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderListFullExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ListApi();
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.
            var request = new OrderListRequest(); // OrderListRequest |  (optional) 

            try
            {
                // Get order list with all order properties and all order items.
                OrderListFull result = apiInstance.GetOrderListFull(acceptEncoding, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetOrderListFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 
 **request** | [**OrderListRequest**](OrderListRequest.md)|  | [optional] 

### Return type

[**OrderListFull**](OrderListFull.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlistlight"></a>
# **GetOrderListLight**
> OrderListLight GetOrderListLight (OrderListRequest request = null)

Get order list without details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderListLightExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ListApi();
            var request = new OrderListRequest(); // OrderListRequest |  (optional) 

            try
            {
                // Get order list without details
                OrderListLight result = apiInstance.GetOrderListLight(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListApi.GetOrderListLight: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**OrderListRequest**](OrderListRequest.md)|  | [optional] 

### Return type

[**OrderListLight**](OrderListLight.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

