# IO.Swagger.Api.ChannelCatalogsProductsOverridesApi

All URIs are relative to *https://api.beezup.com/v2/user/channelCatalogs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteChannelCatalogProductValueOverride**](ChannelCatalogsProductsOverridesApi.md#deletechannelcatalogproductvalueoverride) | **DELETE** /{channelCatalogId}/products/{productId}/overrides/{channelColumnId} | Delete a specific channel catalog product value override
[**OverrideChannelCatalogProductOverrides**](ChannelCatalogsProductsOverridesApi.md#overridechannelcatalogproductoverrides) | **PUT** /{channelCatalogId}/products/{productId}/overrides | Override channel catalog product values


<a name="deletechannelcatalogproductvalueoverride"></a>
# **DeleteChannelCatalogProductValueOverride**
> void DeleteChannelCatalogProductValueOverride (string channelCatalogId, string productId, string channelColumnId)

Delete a specific channel catalog product value override

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChannelCatalogProductValueOverrideExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsProductsOverridesApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier
            var channelColumnId = 8a76f06a-fefc-4c0d-bcfe-b210f1482977;  // string | The channel column identifier

            try
            {
                // Delete a specific channel catalog product value override
                apiInstance.DeleteChannelCatalogProductValueOverride(channelCatalogId, productId, channelColumnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsProductsOverridesApi.DeleteChannelCatalogProductValueOverride: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 
 **channelColumnId** | **string**| The channel column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="overridechannelcatalogproductoverrides"></a>
# **OverrideChannelCatalogProductOverrides**
> void OverrideChannelCatalogProductOverrides (string channelCatalogId, string productId, ProductOverrides request)

Override channel catalog product values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OverrideChannelCatalogProductOverridesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsProductsOverridesApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier
            var request = new ProductOverrides(); // ProductOverrides | 

            try
            {
                // Override channel catalog product values
                apiInstance.OverrideChannelCatalogProductOverrides(channelCatalogId, productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsProductsOverridesApi.OverrideChannelCatalogProductOverrides: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **productId** | **string**| The product identifier | 
 **request** | [**ProductOverrides**](ProductOverrides.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

