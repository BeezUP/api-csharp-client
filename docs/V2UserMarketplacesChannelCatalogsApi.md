# IO.Swagger.Api.V2UserMarketplacesChannelCatalogsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannelCatalogMarketplaceProperties**](V2UserMarketplacesChannelCatalogsApi.md#getchannelcatalogmarketplaceproperties) | **GET** /v2/user/marketplaces/channelcatalogs/{channelCatalogId}/properties | Get the marketplace properties for a channel catalog
[**GetChannelCatalogMarketplaceSettings**](V2UserMarketplacesChannelCatalogsApi.md#getchannelcatalogmarketplacesettings) | **GET** /v2/user/marketplaces/channelcatalogs/{channelCatalogId}/settings | Get the marketplace settings for a channel catalog
[**GetMarketplaceAccountStores**](V2UserMarketplacesChannelCatalogsApi.md#getmarketplaceaccountstores) | **GET** /v2/user/marketplaces/channelcatalogs/ | Get  you marketplace channel catalog list
[**GetPublications**](V2UserMarketplacesChannelCatalogsApi.md#getpublications) | **GET** /v2/user/marketplaces/channelcatalogs/publications/{marketplaceTechnicalCode}/{accountId}/history | Fetch the publication history for an account, sorted by descending start date
[**SetChannelCatalogMarketplaceSettings**](V2UserMarketplacesChannelCatalogsApi.md#setchannelcatalogmarketplacesettings) | **POST** /v2/user/marketplaces/channelcatalogs/{channelCatalogId}/settings | Save new marketplace settings for a channel catalog


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

            var apiInstance = new V2UserMarketplacesChannelCatalogsApi();
            var channelCatalogId = channelCatalogId_example;  // string | 

            try
            {
                // Get the marketplace properties for a channel catalog
                ChannelCatalogMarketplaceProperties result = apiInstance.GetChannelCatalogMarketplaceProperties(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesChannelCatalogsApi.GetChannelCatalogMarketplaceProperties: " + e.Message );
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

            var apiInstance = new V2UserMarketplacesChannelCatalogsApi();
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id to query (required)

            try
            {
                // Get the marketplace settings for a channel catalog
                ChannelCatalogMarketplaceSettings result = apiInstance.GetChannelCatalogMarketplaceSettings(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesChannelCatalogsApi.GetChannelCatalogMarketplaceSettings: " + e.Message );
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

            var apiInstance = new V2UserMarketplacesChannelCatalogsApi();

            try
            {
                // Get  you marketplace channel catalog list
                MarketplaceChannelCatalogList result = apiInstance.GetMarketplaceAccountStores();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesChannelCatalogsApi.GetMarketplaceAccountStores: " + e.Message );
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

<a name="getpublications"></a>
# **GetPublications**
> AccountPublications GetPublications (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)

Fetch the publication history for an account, sorted by descending start date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPublicationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserMarketplacesChannelCatalogsApi();
            var marketplaceTechnicalCode = marketplaceTechnicalCode_example;  // string | Marketplace Technical Code to query (required)
            var accountId = 56;  // int? | Account Id to query (required)
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id by which to filter (optional) (optional) 
            var count = 56;  // int? | Amount of entries to fetch (optional, default set to 10) (optional)  (default to 10)
            var publicationTypes = new List<string>(); // List<string> | Publication types by which to filter (optional) (optional) 

            try
            {
                // Fetch the publication history for an account, sorted by descending start date
                AccountPublications result = apiInstance.GetPublications(marketplaceTechnicalCode, accountId, channelCatalogId, count, publicationTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesChannelCatalogsApi.GetPublications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| Marketplace Technical Code to query (required) | 
 **accountId** | **int?**| Account Id to query (required) | 
 **channelCatalogId** | **string**| Channel Catalog Id by which to filter (optional) | [optional] 
 **count** | **int?**| Amount of entries to fetch (optional, default set to 10) | [optional] [default to 10]
 **publicationTypes** | [**List&lt;string&gt;**](string.md)| Publication types by which to filter (optional) | [optional] 

### Return type

[**AccountPublications**](AccountPublications.md)

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

            var apiInstance = new V2UserMarketplacesChannelCatalogsApi();
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id to query
            var model = new SetChannelCatalogMarketplaceSettingsRequest(); // SetChannelCatalogMarketplaceSettingsRequest | Settings to save

            try
            {
                // Save new marketplace settings for a channel catalog
                apiInstance.SetChannelCatalogMarketplaceSettings(channelCatalogId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserMarketplacesChannelCatalogsApi.SetChannelCatalogMarketplaceSettings: " + e.Message );
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

