# IO.Swagger.Api.ExportsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportOrders**](ExportsApi.md#exportorders) | **POST** /v2/user/marketplaces/orders/exportations | Export orders
[**GetOrderExportations**](ExportsApi.md#getorderexportations) | **GET** /v2/user/marketplaces/orders/exportations | Get the order exportation list


<a name="exportorders"></a>
# **ExportOrders**
> void ExportOrders (string format, ExportOrderListRequest request)

Export orders

This will create a file with all your orders related to your filter

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

            var apiInstance = new ExportsApi();
            var format = csv;  // string | The type of the file to export (default to csv)
            var request = new ExportOrderListRequest(); // ExportOrderListRequest | 

            try
            {
                // Export orders
                apiInstance.ExportOrders(format, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.ExportOrders: " + e.Message );
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

<a name="getorderexportations"></a>
# **GetOrderExportations**
> OrderExportations GetOrderExportations (int? pageNumber, int? pageSize)

Get the order exportation list

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

            var apiInstance = new ExportsApi();
            var pageNumber = 1;  // int? | The page number you want to get
            var pageSize = 25;  // int? | The count of orders exportation you want to get

            try
            {
                // Get the order exportation list
                OrderExportations result = apiInstance.GetOrderExportations(pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExportsApi.GetOrderExportations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNumber** | **int?**| The page number you want to get | 
 **pageSize** | **int?**| The count of orders exportation you want to get | 

### Return type

[**OrderExportations**](OrderExportations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

