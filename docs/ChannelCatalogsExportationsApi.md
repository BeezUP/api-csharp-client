# IO.Swagger.Api.ChannelCatalogsExportationsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteChannelCatalogExportationCache**](ChannelCatalogsExportationsApi.md#deletechannelcatalogexportationcache) | **DELETE** /user/channelCatalogs/{channelCatalogId}/exportations/cache | Delete the exportation cache
[**GetChannelCatalogExportationCacheInfo**](ChannelCatalogsExportationsApi.md#getchannelcatalogexportationcacheinfo) | **GET** /user/channelCatalogs/{channelCatalogId}/exportations/cache | Get the exportation cache information
[**GetChannelCatalogExportationHistory**](ChannelCatalogsExportationsApi.md#getchannelcatalogexportationhistory) | **GET** /user/channelCatalogs/{channelCatalogId}/exportations/history | Get the exportation history


<a name="deletechannelcatalogexportationcache"></a>
# **DeleteChannelCatalogExportationCache**
> void DeleteChannelCatalogExportationCache (string channelCatalogId)

Delete the exportation cache

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChannelCatalogExportationCacheExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsExportationsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Delete the exportation cache
                apiInstance.DeleteChannelCatalogExportationCache(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsExportationsApi.DeleteChannelCatalogExportationCache: " + e.Message );
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

<a name="getchannelcatalogexportationcacheinfo"></a>
# **GetChannelCatalogExportationCacheInfo**
> ChannelCatalogExportCacheInfoResponse GetChannelCatalogExportationCacheInfo (string channelCatalogId)

Get the exportation cache information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExportationCacheInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsExportationsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get the exportation cache information
                ChannelCatalogExportCacheInfoResponse result = apiInstance.GetChannelCatalogExportationCacheInfo(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsExportationsApi.GetChannelCatalogExportationCacheInfo: " + e.Message );
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

[**ChannelCatalogExportCacheInfoResponse**](ChannelCatalogExportCacheInfoResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogexportationhistory"></a>
# **GetChannelCatalogExportationHistory**
> ChannelCatalogExportationHistory GetChannelCatalogExportationHistory (string channelCatalogId, int? pageNumber, int? pageSize)

Get the exportation history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExportationHistoryExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsExportationsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var pageNumber = 1;  // int? | The page number you want to get
            var pageSize = 25;  // int? | The entry count you want to get

            try
            {
                // Get the exportation history
                ChannelCatalogExportationHistory result = apiInstance.GetChannelCatalogExportationHistory(channelCatalogId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsExportationsApi.GetChannelCatalogExportationHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **pageNumber** | **int?**| The page number you want to get | 
 **pageSize** | **int?**| The entry count you want to get | 

### Return type

[**ChannelCatalogExportationHistory**](ChannelCatalogExportationHistory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

