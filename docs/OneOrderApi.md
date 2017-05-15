# IO.Swagger.Api.OneOrderApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeOrder**](OneOrderApi.md#changeorder) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/{changeOrderType} | Change order status
[**ClearMerchantOrderInfo**](OneOrderApi.md#clearmerchantorderinfo) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/clearMerchantOrderInfo | Clear the merchant info related to this order
[**GetOrder**](OneOrderApi.md#getorder) | **GET** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId} | Get order details
[**GetOrderHistory**](OneOrderApi.md#getorderhistory) | **GET** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/history | Get the harvest history and the change status operations
[**HarvestOrder**](OneOrderApi.md#harvestorder) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/harvest | Harvest a specific order from the marketplace
[**SetMerchantOrderInfo**](OneOrderApi.md#setmerchantorderinfo) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/setMerchantOrderInfo | Associate your merchant order identifier to this order


<a name="changeorder"></a>
# **ChangeOrder**
> void ChangeOrder (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId, string changeOrderType, string userName, ChangeOrderRequest request, string ifMatch, bool? testMode = null)

Change order status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OneOrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The order BeezUP identifier
            var changeOrderType = changeOrderType_example;  // string | The order change type
            var userName = userName_example;  // string | Sometimes the user in the e-commerce application is not the same than the subscription key you indicate in your settings. We recommand you to indicate the login of the user in your appplication.
            var request = new ChangeOrderRequest(); // ChangeOrderRequest | 
            var ifMatch = ifMatch_example;  // string | To ensure that you are making a change on the lastest version of the order. ETag value to identify the order given in the order information. \\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3 
            var testMode = false;  // bool? | If true, the operation will be be commited. But the validation will be taken in account. (optional)  (default to false)

            try
            {
                // Change order status
                apiInstance.ChangeOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, changeOrderType, userName, request, ifMatch, testMode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneOrderApi.ChangeOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **string**| The order BeezUP identifier | 
 **changeOrderType** | **string**| The order change type | 
 **userName** | **string**| Sometimes the user in the e-commerce application is not the same than the subscription key you indicate in your settings. We recommand you to indicate the login of the user in your appplication. | 
 **request** | [**ChangeOrderRequest**](ChangeOrderRequest.md)|  | 
 **ifMatch** | **string**| To ensure that you are making a change on the lastest version of the order. ETag value to identify the order given in the order information. \\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | 
 **testMode** | **bool?**| If true, the operation will be be commited. But the validation will be taken in account. | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearmerchantorderinfo"></a>
# **ClearMerchantOrderInfo**
> void ClearMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId)

Clear the merchant info related to this order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearMerchantOrderInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OneOrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The order BeezUP identifier

            try
            {
                // Clear the merchant info related to this order
                apiInstance.ClearMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneOrderApi.ClearMerchantOrderInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **string**| The order BeezUP identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId, string ifNoneMatch = null)

Get order details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OneOrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The order BeezUP identifier
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the order given in the order information. \\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get order details
                Order result = apiInstance.GetOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneOrderApi.GetOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **string**| The order BeezUP identifier | 
 **ifNoneMatch** | **string**| ETag value to identify the order given in the order information. \\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderhistory"></a>
# **GetOrderHistory**
> OrderHistory GetOrderHistory (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId)

Get the harvest history and the change status operations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderHistoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OneOrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The order BeezUP identifier

            try
            {
                // Get the harvest history and the change status operations
                OrderHistory result = apiInstance.GetOrderHistory(marketplaceTechnicalCode, accountId, beezUPOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneOrderApi.GetOrderHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **string**| The order BeezUP identifier | 

### Return type

[**OrderHistory**](OrderHistory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="harvestorder"></a>
# **HarvestOrder**
> void HarvestOrder (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId)

Harvest a specific order from the marketplace

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HarvestOrderExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OneOrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The order BeezUP identifier

            try
            {
                // Harvest a specific order from the marketplace
                apiInstance.HarvestOrder(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneOrderApi.HarvestOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **string**| The order BeezUP identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmerchantorderinfo"></a>
# **SetMerchantOrderInfo**
> void SetMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId, SetMerchantOrderInfoRequest request)

Associate your merchant order identifier to this order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetMerchantOrderInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OneOrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The order BeezUP identifier
            var request = new SetMerchantOrderInfoRequest(); // SetMerchantOrderInfoRequest | 

            try
            {
                // Associate your merchant order identifier to this order
                apiInstance.SetMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OneOrderApi.SetMerchantOrderInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| The marketplace technical code | 
 **accountId** | **int?**| The account identifier | 
 **beezUPOrderId** | **string**| The order BeezUP identifier | 
 **request** | [**SetMerchantOrderInfoRequest**](SetMerchantOrderInfoRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

