# IO.Swagger.Api.BatchesApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeOrderList**](BatchesApi.md#changeorderlist) | **POST** /v2/user/marketplaces/orders/batches/changeOrders/{changeOrderType} | Batches the change order operation.
[**ClearMerchantOrderInfoList**](BatchesApi.md#clearmerchantorderinfolist) | **POST** /v2/user/marketplaces/orders/batches/clearMerchantOrderInfos | Batches the clear merchant order info operation.
[**SetMerchantOrderInfoList**](BatchesApi.md#setmerchantorderinfolist) | **POST** /v2/user/marketplaces/orders/batches/setMerchantOrderInfos | Batches the set merchant order info operation.


<a name="changeorderlist"></a>
# **ChangeOrderList**
> void ChangeOrderList (string changeOrderType, string userName, ChangeOrderListRequest request, bool? testMode = null)

Batches the change order operation.

The purpose of this  operation is to reduce the amount of request to the API.

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

            var apiInstance = new BatchesApi();
            var changeOrderType = changeOrderType_example;  // string | The order change type
            var userName = userName_example;  // string | Sometimes the user in the e-commerce application is not the same than the subscription key you indicate in your settings. We recommand you to indicate the login of the user in your appplication.
            var request = new ChangeOrderListRequest(); // ChangeOrderListRequest | 
            var testMode = false;  // bool? | If true, the operation will be be commited. But the validation will be taken in account. (optional)  (default to false)

            try
            {
                // Batches the change order operation.
                apiInstance.ChangeOrderList(changeOrderType, userName, request, testMode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.ChangeOrderList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changeOrderType** | **string**| The order change type | 
 **userName** | **string**| Sometimes the user in the e-commerce application is not the same than the subscription key you indicate in your settings. We recommand you to indicate the login of the user in your appplication. | 
 **request** | [**ChangeOrderListRequest**](ChangeOrderListRequest.md)|  | 
 **testMode** | **bool?**| If true, the operation will be be commited. But the validation will be taken in account. | [optional] [default to false]

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
> void ClearMerchantOrderInfoList (ClearMerchantOrderInfoListRequest request)

Batches the clear merchant order info operation.

The purpose of this  operation is to reduce the amount of request to the API.

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

            var apiInstance = new BatchesApi();
            var request = new ClearMerchantOrderInfoListRequest(); // ClearMerchantOrderInfoListRequest | 

            try
            {
                // Batches the clear merchant order info operation.
                apiInstance.ClearMerchantOrderInfoList(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.ClearMerchantOrderInfoList: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmerchantorderinfolist"></a>
# **SetMerchantOrderInfoList**
> void SetMerchantOrderInfoList (SetMerchantOrderInfoListRequest request)

Batches the set merchant order info operation.

The purpose of this  operation is to reduce the amount of request to the API.

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

            var apiInstance = new BatchesApi();
            var request = new SetMerchantOrderInfoListRequest(); // SetMerchantOrderInfoListRequest | 

            try
            {
                // Batches the set merchant order info operation.
                apiInstance.SetMerchantOrderInfoList(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.SetMerchantOrderInfoList: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

