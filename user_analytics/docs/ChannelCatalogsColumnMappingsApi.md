# IO.Swagger.Api.ChannelCatalogsColumnMappingsApi

All URIs are relative to *https://api.beezup.com/v2/user/channelCatalogs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MapChannelCatalogColumns**](ChannelCatalogsColumnMappingsApi.md#mapchannelcatalogcolumns) | **PUT** /{channelCatalogId}/columnMappings | Configure channel catalog column mappings


<a name="mapchannelcatalogcolumns"></a>
# **MapChannelCatalogColumns**
> void MapChannelCatalogColumns (string channelCatalogId, ColumnMappingList request)

Configure channel catalog column mappings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MapChannelCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsColumnMappingsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new ColumnMappingList(); // ColumnMappingList | 

            try
            {
                // Configure channel catalog column mappings
                apiInstance.MapChannelCatalogColumns(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsColumnMappingsApi.MapChannelCatalogColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**ColumnMappingList**](ColumnMappingList.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

