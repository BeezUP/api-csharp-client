# IO.Swagger.Api.ChannelCatalogsCategoryMappingsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannelCatalogCategories**](ChannelCatalogsCategoryMappingsApi.md#getchannelcatalogcategories) | **GET** /v2/user/channelCatalogs/{channelCatalogId}/categoryMappings | Get channel catalog categories
[**MapChannelCatalogCategory**](ChannelCatalogsCategoryMappingsApi.md#mapchannelcatalogcategory) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/categoryMappings/map | Map channel catalog category
[**UnmapChannelCatalogCategory**](ChannelCatalogsCategoryMappingsApi.md#unmapchannelcatalogcategory) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/categoryMappings/unmap | Unmap channel catalog category


<a name="getchannelcatalogcategories"></a>
# **GetChannelCatalogCategories**
> ChannelCatalogCategoryMappings GetChannelCatalogCategories (string channelCatalogId)

Get channel catalog categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsCategoryMappingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get channel catalog categories
                ChannelCatalogCategoryMappings result = apiInstance.GetChannelCatalogCategories(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsCategoryMappingsApi.GetChannelCatalogCategories: " + e.Message );
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

[**ChannelCatalogCategoryMappings**](ChannelCatalogCategoryMappings.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mapchannelcatalogcategory"></a>
# **MapChannelCatalogCategory**
> void MapChannelCatalogCategory (string channelCatalogId, MapCategoryRequest request)

Map channel catalog category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapChannelCatalogCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsCategoryMappingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new MapCategoryRequest(); // MapCategoryRequest | 

            try
            {
                // Map channel catalog category
                apiInstance.MapChannelCatalogCategory(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsCategoryMappingsApi.MapChannelCatalogCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**MapCategoryRequest**](MapCategoryRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unmapchannelcatalogcategory"></a>
# **UnmapChannelCatalogCategory**
> void UnmapChannelCatalogCategory (string channelCatalogId, UnmapCategoryRequest request)

Unmap channel catalog category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnmapChannelCatalogCategoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsCategoryMappingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new UnmapCategoryRequest(); // UnmapCategoryRequest | 

            try
            {
                // Unmap channel catalog category
                apiInstance.UnmapChannelCatalogCategory(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsCategoryMappingsApi.UnmapChannelCatalogCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**UnmapCategoryRequest**](UnmapCategoryRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

