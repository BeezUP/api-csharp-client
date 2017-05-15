# IO.Swagger.Api.MarketplacesChannelCatalogsGlobalApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMarketplaceAccountStores**](MarketplacesChannelCatalogsGlobalApi.md#getmarketplaceaccountstores) | **GET** /user/marketplaces/channelcatalogs/ | Get  you marketplace channel catalog list


<a name="getmarketplaceaccountstores"></a>
# **GetMarketplaceAccountStores**
> MarketplaceChannelCatalogList GetMarketplaceAccountStores ()

Get  you marketplace channel catalog list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketplaceAccountStoresExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new MarketplacesChannelCatalogsGlobalApi();

            try
            {
                // Get  you marketplace channel catalog list
                MarketplaceChannelCatalogList result = apiInstance.GetMarketplaceAccountStores();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesChannelCatalogsGlobalApi.GetMarketplaceAccountStores: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MarketplaceChannelCatalogList**](MarketplaceChannelCatalogList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

