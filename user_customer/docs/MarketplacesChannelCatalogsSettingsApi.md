# IO.Swagger.Api.MarketplacesChannelCatalogsSettingsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannelCatalogMarketplaceProperties**](MarketplacesChannelCatalogsSettingsApi.md#getchannelcatalogmarketplaceproperties) | **GET** /v2/user/marketplaces/channelcatalogs/{channelCatalogId}/properties | Get the marketplace properties for a channel catalog
[**GetChannelCatalogMarketplaceSettings**](MarketplacesChannelCatalogsSettingsApi.md#getchannelcatalogmarketplacesettings) | **GET** /v2/user/marketplaces/channelcatalogs/{channelCatalogId}/settings | Get the marketplace settings for a channel catalog
[**SetChannelCatalogMarketplaceSettings**](MarketplacesChannelCatalogsSettingsApi.md#setchannelcatalogmarketplacesettings) | **POST** /v2/user/marketplaces/channelcatalogs/{channelCatalogId}/settings | Save new marketplace settings for a channel catalog


<a name="getchannelcatalogmarketplaceproperties"></a>
# **GetChannelCatalogMarketplaceProperties**
> ChannelCatalogMarketplaceProperties GetChannelCatalogMarketplaceProperties (string channelCatalogId)

Get the marketplace properties for a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogMarketplacePropertiesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new MarketplacesChannelCatalogsSettingsApi();
            var channelCatalogId = channelCatalogId_example;  // string | 

            try
            {
                // Get the marketplace properties for a channel catalog
                ChannelCatalogMarketplaceProperties result = apiInstance.GetChannelCatalogMarketplaceProperties(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesChannelCatalogsSettingsApi.GetChannelCatalogMarketplaceProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**|  | 

### Return type

[**ChannelCatalogMarketplaceProperties**](ChannelCatalogMarketplaceProperties.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogmarketplacesettings"></a>
# **GetChannelCatalogMarketplaceSettings**
> ChannelCatalogMarketplaceSettings GetChannelCatalogMarketplaceSettings (string channelCatalogId)

Get the marketplace settings for a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogMarketplaceSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new MarketplacesChannelCatalogsSettingsApi();
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id to query (required)

            try
            {
                // Get the marketplace settings for a channel catalog
                ChannelCatalogMarketplaceSettings result = apiInstance.GetChannelCatalogMarketplaceSettings(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesChannelCatalogsSettingsApi.GetChannelCatalogMarketplaceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| Channel Catalog Id to query (required) | 

### Return type

[**ChannelCatalogMarketplaceSettings**](ChannelCatalogMarketplaceSettings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setchannelcatalogmarketplacesettings"></a>
# **SetChannelCatalogMarketplaceSettings**
> void SetChannelCatalogMarketplaceSettings (string channelCatalogId, SetChannelCatalogMarketplaceSettingsRequest model)

Save new marketplace settings for a channel catalog

Allow you to configure your marketplace settings.  Partial update accepted. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetChannelCatalogMarketplaceSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new MarketplacesChannelCatalogsSettingsApi();
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id to query
            var model = new SetChannelCatalogMarketplaceSettingsRequest(); // SetChannelCatalogMarketplaceSettingsRequest | Settings to save

            try
            {
                // Save new marketplace settings for a channel catalog
                apiInstance.SetChannelCatalogMarketplaceSettings(channelCatalogId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesChannelCatalogsSettingsApi.SetChannelCatalogMarketplaceSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| Channel Catalog Id to query | 
 **model** | [**SetChannelCatalogMarketplaceSettingsRequest**](SetChannelCatalogMarketplaceSettingsRequest.md)| Settings to save | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

