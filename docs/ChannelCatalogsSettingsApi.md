# IO.Swagger.Api.ChannelCatalogsSettingsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigureChannelCatalogCostSettings**](ChannelCatalogsSettingsApi.md#configurechannelcatalogcostsettings) | **POST** /user/channelCatalogs/{channelCatalogId}/settings/cost | Disable a channel catalog
[**ConfigureChannelCatalogGeneralSettings**](ChannelCatalogsSettingsApi.md#configurechannelcataloggeneralsettings) | **POST** /user/channelCatalogs/{channelCatalogId}/settings/general | Disable a channel catalog
[**DisableChannelCatalog**](ChannelCatalogsSettingsApi.md#disablechannelcatalog) | **POST** /user/channelCatalogs/{channelCatalogId}/disable | Disable a channel catalog
[**EnableChannelCatalog**](ChannelCatalogsSettingsApi.md#enablechannelcatalog) | **POST** /user/channelCatalogs/{channelCatalogId}/enable | Enable a channel catalog


<a name="configurechannelcatalogcostsettings"></a>
# **ConfigureChannelCatalogCostSettings**
> void ConfigureChannelCatalogCostSettings (string channelCatalogId, CostSettings request)

Disable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureChannelCatalogCostSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsSettingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new CostSettings(); // CostSettings | 

            try
            {
                // Disable a channel catalog
                apiInstance.ConfigureChannelCatalogCostSettings(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsSettingsApi.ConfigureChannelCatalogCostSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**CostSettings**](CostSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurechannelcataloggeneralsettings"></a>
# **ConfigureChannelCatalogGeneralSettings**
> void ConfigureChannelCatalogGeneralSettings (string channelCatalogId, GeneralSettings request)

Disable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureChannelCatalogGeneralSettingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsSettingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new GeneralSettings(); // GeneralSettings | 

            try
            {
                // Disable a channel catalog
                apiInstance.ConfigureChannelCatalogGeneralSettings(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsSettingsApi.ConfigureChannelCatalogGeneralSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**GeneralSettings**](GeneralSettings.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablechannelcatalog"></a>
# **DisableChannelCatalog**
> void DisableChannelCatalog (string channelCatalogId)

Disable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsSettingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Disable a channel catalog
                apiInstance.DisableChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsSettingsApi.DisableChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enablechannelcatalog"></a>
# **EnableChannelCatalog**
> void EnableChannelCatalog (string channelCatalogId)

Enable a channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EnableChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsSettingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Enable a channel catalog
                apiInstance.EnableChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsSettingsApi.EnableChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

