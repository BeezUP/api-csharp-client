# IO.Swagger.Api.ChannelCatalogsExclusionFiltersApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigureChannelCatalogExclusionFilters**](ChannelCatalogsExclusionFiltersApi.md#configurechannelcatalogexclusionfilters) | **PUT** /user/channelCatalogs/{channelCatalogId}/exclusionFilters | Configure channel catalog exclusion filters
[**GetChannelCatalogExclusionFilterOperators**](ChannelCatalogsExclusionFiltersApi.md#getchannelcatalogexclusionfilteroperators) | **GET** /user/channelCatalogs/exclusionFilterOperators | Get channel catalog exclusion filter operators


<a name="configurechannelcatalogexclusionfilters"></a>
# **ConfigureChannelCatalogExclusionFilters**
> void ConfigureChannelCatalogExclusionFilters (string channelCatalogId, ExclusionFilters request)

Configure channel catalog exclusion filters

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureChannelCatalogExclusionFiltersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsExclusionFiltersApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new ExclusionFilters(); // ExclusionFilters | 

            try
            {
                // Configure channel catalog exclusion filters
                apiInstance.ConfigureChannelCatalogExclusionFilters(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsExclusionFiltersApi.ConfigureChannelCatalogExclusionFilters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**ExclusionFilters**](ExclusionFilters.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogexclusionfilteroperators"></a>
# **GetChannelCatalogExclusionFilterOperators**
> List<ExclusionFilterOperator> GetChannelCatalogExclusionFilterOperators ()

Get channel catalog exclusion filter operators

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExclusionFilterOperatorsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsExclusionFiltersApi();

            try
            {
                // Get channel catalog exclusion filter operators
                List&lt;ExclusionFilterOperator&gt; result = apiInstance.GetChannelCatalogExclusionFilterOperators();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsExclusionFiltersApi.GetChannelCatalogExclusionFilterOperators: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ExclusionFilterOperator>**](ExclusionFilterOperator.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

