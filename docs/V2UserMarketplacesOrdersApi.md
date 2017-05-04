# IO.Swagger.Api.V2UserMarketplacesOrdersApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeOrder**](V2UserMarketplacesOrdersApi.md#changeorder) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/{changeOrderType} | Change your marketplace Order Information (accept, ship, etc.)
[**ChangeOrderList**](V2UserMarketplacesOrdersApi.md#changeorderlist) | **POST** /v2/user/marketplaces/orders/batches/changeOrders/{changeOrderType} | Send a batch of operations to change your marketplace Order information (accept, ship, etc.)
[**ClearMerchantOrderInfo**](V2UserMarketplacesOrdersApi.md#clearmerchantorderinfo) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/clearMerchantOrderInfo | Clear an Order&#39;s merchant information
[**ClearMerchantOrderInfoList**](V2UserMarketplacesOrdersApi.md#clearmerchantorderinfolist) | **POST** /v2/user/marketplaces/orders/batches/clearMerchantOrderInfos | Send a batch of operations to clear an Order&#39;s merchant information
[**ConfigureAutomaticTransitions**](V2UserMarketplacesOrdersApi.md#configureautomatictransitions) | **POST** /v2/user/marketplaces/orders/automaticTransitions | Configure new or existing automatic Order status transition
[**ExportOrders**](V2UserMarketplacesOrdersApi.md#exportorders) | **POST** /v2/user/marketplaces/orders/exportations | Request a new Order report exportation to be generated
[**GetAutomaticTransitions**](V2UserMarketplacesOrdersApi.md#getautomatictransitions) | **GET** /v2/user/marketplaces/orders/automaticTransitions | Get list of configured automatic Order status transitions
[**GetMarketplaceAccountsSynchronization**](V2UserMarketplacesOrdersApi.md#getmarketplaceaccountssynchronization) | **GET** /v2/user/marketplaces/orders/status | Get current synchronization status between your marketplaces and BeezUP accounts
[**GetOrder**](V2UserMarketplacesOrdersApi.md#getorder) | **GET** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId} | Get full Order and Order Item(s) properties
[**GetOrderExportations**](V2UserMarketplacesOrdersApi.md#getorderexportations) | **GET** /v2/user/marketplaces/orders/exportations | Get a paginated list of Order report exportations
[**GetOrderHistory**](V2UserMarketplacesOrdersApi.md#getorderhistory) | **GET** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/history | Get an Order&#39;s harvest and change history
[**GetOrderListFull**](V2UserMarketplacesOrdersApi.md#getorderlistfull) | **POST** /v2/user/marketplaces/orders/list/full | Get a paginated list of all Orders with all Order and Order Item(s) properties
[**GetOrderListLight**](V2UserMarketplacesOrdersApi.md#getorderlistlight) | **POST** /v2/user/marketplaces/orders/list/light | Get a paginated list of all Orders without details
[**HarvestAll**](V2UserMarketplacesOrdersApi.md#harvestall) | **POST** /v2/user/marketplaces/orders/harvest | Send harvest request to all your marketplaces
[**HarvestOrder**](V2UserMarketplacesOrdersApi.md#harvestorder) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/harvest | Send harvest request for a single Order
[**SetMerchantOrderInfo**](V2UserMarketplacesOrdersApi.md#setmerchantorderinfo) | **POST** /v2/user/marketplaces/orders/{marketplaceTechnicalCode}/{accountId}/{beezUPOrderId}/setMerchantOrderInfo | Set an Order&#39;s merchant information
[**SetMerchantOrderInfoList**](V2UserMarketplacesOrdersApi.md#setmerchantorderinfolist) | **POST** /v2/user/marketplaces/orders/batches/setMerchantOrderInfos | Send a batch of operations to set an Order&#39;s merchant information


<a name="changeorder"></a>
# **ChangeOrder**
> void ChangeOrder (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId, string changeOrderType, string userName, ChangeOrderRequest request, string ifMatch, bool? testMode = null)

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The BeezUP Order identifier
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
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.ChangeOrder: " + e.Message );
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
 **beezUPOrderId** | **string**| The BeezUP Order identifier | 
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

<a name="changeorderlist"></a>
# **ChangeOrderList**
> BatchOrderOperationResponse ChangeOrderList (string changeOrderType, string userName, ChangeOrderListRequest request, bool? testMode = null)

Send a batch of operations to change your marketplace Order information (accept, ship, etc.)

The purpose of this operation is to reduce the amount of request to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeOrderListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var changeOrderType = changeOrderType_example;  // string | The Order change type
            var userName = userName_example;  // string | Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application's user login.
            var request = new ChangeOrderListRequest(); // ChangeOrderListRequest | 
            var testMode = false;  // bool? | If true, the operation will be not be sent to marketplace. But the validation will be taken in account. (optional)  (default to false)

            try
            {
                // Send a batch of operations to change your marketplace Order information (accept, ship, etc.)
                BatchOrderOperationResponse result = apiInstance.ChangeOrderList(changeOrderType, userName, request, testMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.ChangeOrderList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeOrderType** | **string**| The Order change type | 
 **userName** | **string**| Sometimes the user in the e-commerce application is not the same as user associated with the current subscription key. We recommend providing your application&#39;s user login. | 
 **request** | [**ChangeOrderListRequest**](ChangeOrderListRequest.md)|  | 
 **testMode** | **bool?**| If true, the operation will be not be sent to marketplace. But the validation will be taken in account. | [optional] [default to false]

### Return type

[**BatchOrderOperationResponse**](BatchOrderOperationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearmerchantorderinfo"></a>
# **ClearMerchantOrderInfo**
> void ClearMerchantOrderInfo (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId)

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The BeezUP Order identifier

            try
            {
                // Clear an Order's merchant information
                apiInstance.ClearMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.ClearMerchantOrderInfo: " + e.Message );
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
 **beezUPOrderId** | **string**| The BeezUP Order identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearmerchantorderinfolist"></a>
# **ClearMerchantOrderInfoList**
> BatchOrderOperationResponse ClearMerchantOrderInfoList (ClearMerchantOrderInfoListRequest request)

Send a batch of operations to clear an Order's merchant information

The purpose of this operation is to reduce the amount of request to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearMerchantOrderInfoListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var request = new ClearMerchantOrderInfoListRequest(); // ClearMerchantOrderInfoListRequest | 

            try
            {
                // Send a batch of operations to clear an Order's merchant information
                BatchOrderOperationResponse result = apiInstance.ClearMerchantOrderInfoList(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.ClearMerchantOrderInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ClearMerchantOrderInfoListRequest**](ClearMerchantOrderInfoListRequest.md)|  | 

### Return type

[**BatchOrderOperationResponse**](BatchOrderOperationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configureautomatictransitions"></a>
# **ConfigureAutomaticTransitions**
> void ConfigureAutomaticTransitions (SaveAutomaticTransitionRequest request)

Configure new or existing automatic Order status transition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureAutomaticTransitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var request = new SaveAutomaticTransitionRequest(); // SaveAutomaticTransitionRequest | 

            try
            {
                // Configure new or existing automatic Order status transition
                apiInstance.ConfigureAutomaticTransitions(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.ConfigureAutomaticTransitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveAutomaticTransitionRequest**](SaveAutomaticTransitionRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportorders"></a>
# **ExportOrders**
> void ExportOrders (string format, ExportOrderListRequest request)

Request a new Order report exportation to be generated

A new file will be generated containing a summary of all the Orders matching the requested filter settings.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExportOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var format = csv;  // string | The type of the file to export (default to csv)
            var request = new ExportOrderListRequest(); // ExportOrderListRequest | 

            try
            {
                // Request a new Order report exportation to be generated
                apiInstance.ExportOrders(format, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.ExportOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| The type of the file to export | [default to csv]
 **request** | [**ExportOrderListRequest**](ExportOrderListRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautomatictransitions"></a>
# **GetAutomaticTransitions**
> AutomaticTransitionInfos GetAutomaticTransitions ()

Get list of configured automatic Order status transitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAutomaticTransitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();

            try
            {
                // Get list of configured automatic Order status transitions
                AutomaticTransitionInfos result = apiInstance.GetAutomaticTransitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetAutomaticTransitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AutomaticTransitionInfos**](AutomaticTransitionInfos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketplaceaccountssynchronization"></a>
# **GetMarketplaceAccountsSynchronization**
> AccountSynchronizations GetMarketplaceAccountsSynchronization ()

Get current synchronization status between your marketplaces and BeezUP accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketplaceAccountsSynchronizationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();

            try
            {
                // Get current synchronization status between your marketplaces and BeezUP accounts
                AccountSynchronizations result = apiInstance.GetMarketplaceAccountsSynchronization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetMarketplaceAccountsSynchronization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountSynchronizations**](AccountSynchronizations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId, string ifNoneMatch = null)

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The BeezUP Order identifier
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested Order\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get full Order and Order Item(s) properties
                Order result = apiInstance.GetOrder(marketplaceTechnicalCode, accountId, beezUPOrderId, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetOrder: " + e.Message );
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
 **beezUPOrderId** | **string**| The BeezUP Order identifier | 
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested Order\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderexportations"></a>
# **GetOrderExportations**
> OrderExportations GetOrderExportations (int? pageNumber, int? pageSize)

Get a paginated list of Order report exportations

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderExportationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var pageNumber = 1;  // int? | The page number you want to get
            var pageSize = 25;  // int? | The count of Order report exportations you want to get

            try
            {
                // Get a paginated list of Order report exportations
                OrderExportations result = apiInstance.GetOrderExportations(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetOrderExportations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNumber** | **int?**| The page number you want to get | 
 **pageSize** | **int?**| The count of Order report exportations you want to get | 

### Return type

[**OrderExportations**](OrderExportations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderhistory"></a>
# **GetOrderHistory**
> OrderHistory GetOrderHistory (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId)

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The BeezUP Order identifier

            try
            {
                // Get an Order's harvest and change history
                OrderHistory result = apiInstance.GetOrderHistory(marketplaceTechnicalCode, accountId, beezUPOrderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetOrderHistory: " + e.Message );
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
 **beezUPOrderId** | **string**| The BeezUP Order identifier | 

### Return type

[**OrderHistory**](OrderHistory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorderlistfull"></a>
# **GetOrderListFull**
> OrderListFull GetOrderListFull (List<string> acceptEncoding, OrderListRequest request = null)

Get a paginated list of all Orders with all Order and Order Item(s) properties

The purpose of this operation is to reduce the amount of request to the API.\\ \\ Previous implmentation of this feature only returned a partial (light) version of the Orders. The purpose of this API is to reduce the number of incoming requests by returning the complete (full) Order and Order Item(s) properties. 

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var acceptEncoding = new List<string>(); // List<string> | Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size
            var request = new OrderListRequest(); // OrderListRequest |  (optional) 

            try
            {
                // Get a paginated list of all Orders with all Order and Order Item(s) properties
                OrderListFull result = apiInstance.GetOrderListFull(acceptEncoding, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetOrderListFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size | 
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

Get a paginated list of all Orders without details

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var request = new OrderListRequest(); // OrderListRequest |  (optional) 

            try
            {
                // Get a paginated list of all Orders without details
                OrderListLight result = apiInstance.GetOrderListLight(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.GetOrderListLight: " + e.Message );
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

<a name="harvestall"></a>
# **HarvestAll**
> void HarvestAll ()

Send harvest request to all your marketplaces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HarvestAllExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();

            try
            {
                // Send harvest request to all your marketplaces
                apiInstance.HarvestAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.HarvestAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="harvestorder"></a>
# **HarvestOrder**
> void HarvestOrder (string marketplaceTechnicalCode, int? accountId, string beezUPOrderId)

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The BeezUP Order identifier

            try
            {
                // Send harvest request for a single Order
                apiInstance.HarvestOrder(marketplaceTechnicalCode, accountId, beezUPOrderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.HarvestOrder: " + e.Message );
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
 **beezUPOrderId** | **string**| The BeezUP Order identifier | 

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

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var marketplaceTechnicalCode = Amazon;  // string | The marketplace technical code
            var accountId = 1001;  // int? | The account identifier
            var beezUPOrderId = 00000000000000000000000000000000000000000000000;  // string | The BeezUP Order identifier
            var request = new SetMerchantOrderInfoRequest(); // SetMerchantOrderInfoRequest | 

            try
            {
                // Set an Order's merchant information
                apiInstance.SetMerchantOrderInfo(marketplaceTechnicalCode, accountId, beezUPOrderId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.SetMerchantOrderInfo: " + e.Message );
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
 **beezUPOrderId** | **string**| The BeezUP Order identifier | 
 **request** | [**SetMerchantOrderInfoRequest**](SetMerchantOrderInfoRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmerchantorderinfolist"></a>
# **SetMerchantOrderInfoList**
> BatchOrderOperationResponse SetMerchantOrderInfoList (SetMerchantOrderInfoListRequest request)

Send a batch of operations to set an Order's merchant information

The purpose of this operation is to reduce the amount of request to the API.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetMerchantOrderInfoListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesOrdersApi();
            var request = new SetMerchantOrderInfoListRequest(); // SetMerchantOrderInfoListRequest | 

            try
            {
                // Send a batch of operations to set an Order's merchant information
                BatchOrderOperationResponse result = apiInstance.SetMerchantOrderInfoList(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesOrdersApi.SetMerchantOrderInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetMerchantOrderInfoListRequest**](SetMerchantOrderInfoListRequest.md)|  | 

### Return type

[**BatchOrderOperationResponse**](BatchOrderOperationResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

