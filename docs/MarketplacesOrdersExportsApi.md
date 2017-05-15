# IO.Swagger.Api.MarketplacesOrdersExportsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportOrders**](MarketplacesOrdersExportsApi.md#exportorders) | **POST** /user/marketplaces/orders/exportations | Request a new Order report exportation to be generated
[**GetOrderExportations**](MarketplacesOrdersExportsApi.md#getorderexportations) | **GET** /user/marketplaces/orders/exportations | Get a paginated list of Order report exportations


<a name="exportorders"></a>
# **ExportOrders**
> void ExportOrders (ExportOrderListRequest request)

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

            var apiInstance = new MarketplacesOrdersExportsApi();
            var request = new ExportOrderListRequest(); // ExportOrderListRequest | 

            try
            {
                // Request a new Order report exportation to be generated
                apiInstance.ExportOrders(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesOrdersExportsApi.ExportOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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
> OrderExportations GetOrderExportations (int? pageNumber, int? pageSize, string storeId)

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

            var apiInstance = new MarketplacesOrdersExportsApi();
            var pageNumber = 1;  // int? | The page number you want to get
            var pageSize = 25;  // int? | The entry count you want to get
            var storeId = storeId_example;  // string | The store identifier to regroup the order exportations

            try
            {
                // Get a paginated list of Order report exportations
                OrderExportations result = apiInstance.GetOrderExportations(pageNumber, pageSize, storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesOrdersExportsApi.GetOrderExportations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNumber** | **int?**| The page number you want to get | 
 **pageSize** | **int?**| The entry count you want to get | 
 **storeId** | **string**| The store identifier to regroup the order exportations | 

### Return type

[**OrderExportations**](OrderExportations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

