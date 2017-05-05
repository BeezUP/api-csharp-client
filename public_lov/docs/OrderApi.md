# IO.Swagger.Api.OrderApi

All URIs are relative to *https://api.beezup.com/v2/user/marketplaces/orders*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeOrder**](OrderApi.md#changeorder) | **POST** /{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/{changeOrderType} | Change your marketplace Order Information (accept, ship, etc.)
[**ClearMerchantOrderInfo**](OrderApi.md#clearmerchantorderinfo) | **POST** /{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/clearMerchantOrderInfo | Clear an Order&#39;s merchant information
[**GetOrder**](OrderApi.md#getorder) | **GET** /{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId} | Get full Order and Order Item(s) properties
[**GetOrderHistory**](OrderApi.md#getorderhistory) | **GET** /{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/history | Get an Order&#39;s harvest and change history
[**HarvestOrder**](OrderApi.md#harvestorder) | **POST** /{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/harvest | Send harvest request for a single Order
[**SetMerchantOrderInfo**](OrderApi.md#setmerchantorderinfo) | **POST** /{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/setMerchantOrderInfo | Set an Order&#39;s merchant information


<a name="changeorder"></a>
# **ChangeOrder**
> void ChangeOrder (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId, string changeOrderType, string userName, ChangeOrderRequest request, string ifMatch, bool? testMode = null)

Change your marketplace Order Information (accept, ship, etc.)

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

            var apiInstance = new OrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier
            var changeOrderType = changeOrderType_example;  // string | The Order change type
            var userName = userName_example;  // string | Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application's user login.
            var request = new ChangeOrderRequest(); // ChangeOrderRequest | 
            var ifMatch = ifMatch_example;  // string | ETag value to identify the last known version of requested Order, to ensure that you are making a change on the lastest version of the order.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3 
            var testMode = false;  // bool? | If true, the operation will be not be sent to marketplace. But the validation will be taken in account. (optional)  (default to false)

            try
            {
                // Change your marketplace Order Information (accept, ship, etc.)
                apiInstance.ChangeOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, changeOrderType, userName, request, ifMatch, testMode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ChangeOrder: " + e.Message );
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
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 
 **changeOrderType** | **string**| The Order change type | 
 **userName** | **string**| Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application&#39;s user login. | 
 **request** | [**ChangeOrderRequest**](ChangeOrderRequest.md)|  | 
 **ifMatch** | **string**| ETag value to identify the last known version of requested Order, to ensure that you are making a change on the lastest version of the order.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | 
 **testMode** | **bool?**| If true, the operation will be not be sent to marketplace. But the validation will be taken in account. | [optional] [default to false]

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
> void ClearMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId)

Clear an Order's merchant information

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

            var apiInstance = new OrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier

            try
            {
                // Clear an Order's merchant information
                apiInstance.ClearMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.ClearMerchantOrderInfo: " + e.Message );
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
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 

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
> Order GetOrder (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId, string ifNoneMatch = null)

Get full Order and Order Item(s) properties

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

            var apiInstance = new OrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested Order\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get full Order and Order Item(s) properties
                Order result = apiInstance.GetOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrder: " + e.Message );
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
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested Order\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

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
> OrderHistory GetOrderHistory (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId)

Get an Order's harvest and change history

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

            var apiInstance = new OrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier

            try
            {
                // Get an Order's harvest and change history
                OrderHistory result = apiInstance.GetOrderHistory(marketplaceTechnicalCode, accountId, beezUPOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.GetOrderHistory: " + e.Message );
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
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 

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
> void HarvestOrder (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId)

Send harvest request for a single Order

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

            var apiInstance = new OrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier

            try
            {
                // Send harvest request for a single Order
                apiInstance.HarvestOrder(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.HarvestOrder: " + e.Message );
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
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 

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
> void SetMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, Guid? beezUPOrderId, SetMerchantOrderInfoRequest request)

Set an Order's merchant information

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

            var apiInstance = new OrderApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // Guid? | The BeezUP Order identifier
            var request = new SetMerchantOrderInfoRequest(); // SetMerchantOrderInfoRequest | 

            try
            {
                // Set an Order's merchant information
                apiInstance.SetMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.SetMerchantOrderInfo: " + e.Message );
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
 **beezUPOrderId** | **Guid?**| The BeezUP Order identifier | 
 **request** | [**SetMerchantOrderInfoRequest**](SetMerchantOrderInfoRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

