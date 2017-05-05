# IO.Swagger.Api.AlertsApi

All URIs are relative to *https://api.beezup.com/v2/user/customer*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetStoreAlerts**](AlertsApi.md#getstorealerts) | **GET** /stores/{storeId}/alerts | Get store&#39;s alerts
[**SaveStoreAlert**](AlertsApi.md#savestorealert) | **PUT** /stores/{storeId}/alerts/{alertId} | Save store alert


<a name="getstorealerts"></a>
# **GetStoreAlerts**
> StoreAlerts GetStoreAlerts (string storeId)

Get store's alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreAlertsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AlertsApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store's alerts
                StoreAlerts result = apiInstance.GetStoreAlerts(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.GetStoreAlerts: " + e.Message );
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

[**StoreAlerts**](StoreAlerts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savestorealert"></a>
# **SaveStoreAlert**
> void SaveStoreAlert (string storeId, int? alertId, List<SaveStoreAlertRequest> request)

Save store alert

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveStoreAlertExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AlertsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var alertId = 56;  // int? | 
            var request = new List<SaveStoreAlertRequest>(); // List<SaveStoreAlertRequest> | 

            try
            {
                // Save store alert
                apiInstance.SaveStoreAlert(storeId, alertId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.SaveStoreAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **alertId** | **int?**|  | 
 **request** | [**List&lt;SaveStoreAlertRequest&gt;**](SaveStoreAlertRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

