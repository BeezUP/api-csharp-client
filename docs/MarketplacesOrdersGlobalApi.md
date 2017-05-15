# IO.Swagger.Api.MarketplacesOrdersGlobalApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketplaceAccountsSynchronization**](MarketplacesOrdersGlobalApi.md#getmarketplaceaccountssynchronization) | **GET** /user/marketplaces/orders/status | Get current synchronization status between your marketplaces and BeezUP accounts
[**GetOrderIndex**](MarketplacesOrdersGlobalApi.md#getorderindex) | **GET** /user/marketplaces/orders/ | Get all actions you can do on the order API
[**HarvestAll**](MarketplacesOrdersGlobalApi.md#harvestall) | **POST** /user/marketplaces/orders/harvest | Send harvest request to all your marketplaces


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

            var apiInstance = new MarketplacesOrdersGlobalApi();

            try
            {
                // Get current synchronization status between your marketplaces and BeezUP accounts
                AccountSynchronizations result = apiInstance.GetMarketplaceAccountsSynchronization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesOrdersGlobalApi.GetMarketplaceAccountsSynchronization: " + e.Message );
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

<a name="getorderindex"></a>
# **GetOrderIndex**
> OrderIndex GetOrderIndex ()

Get all actions you can do on the order API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new MarketplacesOrdersGlobalApi();

            try
            {
                // Get all actions you can do on the order API
                OrderIndex result = apiInstance.GetOrderIndex();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesOrdersGlobalApi.GetOrderIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OrderIndex**](OrderIndex.md)

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

            var apiInstance = new MarketplacesOrdersGlobalApi();

            try
            {
                // Send harvest request to all your marketplaces
                apiInstance.HarvestAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesOrdersGlobalApi.HarvestAll: " + e.Message );
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

