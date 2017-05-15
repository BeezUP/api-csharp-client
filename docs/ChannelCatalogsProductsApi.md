# IO.Swagger.Api.ChannelCatalogsProductsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannelCatalogProductByChannelCatalog**](ChannelCatalogsProductsApi.md#getchannelcatalogproductbychannelcatalog) | **POST** /user/channelCatalogs/products/{productId} | Get channel catalog products related to these channel catalogs
[**GetChannelCatalogProductInfo**](ChannelCatalogsProductsApi.md#getchannelcatalogproductinfo) | **GET** /user/channelCatalogs/{channelCatalogId}/products/{productId} | Get channel catalog product information
[**GetChannelCatalogProductInfoList**](ChannelCatalogsProductsApi.md#getchannelcatalogproductinfolist) | **POST** /user/channelCatalogs/{channelCatalogId}/products | Get channel catalog product information list


<a name="getchannelcatalogproductbychannelcatalog"></a>
# **GetChannelCatalogProductByChannelCatalog**
> ChannelCatalogProductByChannelCatalogResponse GetChannelCatalogProductByChannelCatalog (string productId, ChannelCatalogProductByChannelCatalogRequest request = null)

Get channel catalog products related to these channel catalogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogProductByChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsProductsApi();
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier
            var request = new ChannelCatalogProductByChannelCatalogRequest(); // ChannelCatalogProductByChannelCatalogRequest |  (optional) 

            try
            {
                // Get channel catalog products related to these channel catalogs
                ChannelCatalogProductByChannelCatalogResponse result = apiInstance.GetChannelCatalogProductByChannelCatalog(productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsProductsApi.GetChannelCatalogProductByChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**| The product identifier | 
 **request** | [**ChannelCatalogProductByChannelCatalogRequest**](ChannelCatalogProductByChannelCatalogRequest.md)|  | [optional] 

### Return type

[**ChannelCatalogProductByChannelCatalogResponse**](ChannelCatalogProductByChannelCatalogResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogproductinfo"></a>
# **GetChannelCatalogProductInfo**
> ChannelCatalogProductInfo GetChannelCatalogProductInfo (string channelCatalogId, string productId)

Get channel catalog product information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogProductInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsProductsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier

            try
            {
                // Get channel catalog product information
                ChannelCatalogProductInfo result = apiInstance.GetChannelCatalogProductInfo(channelCatalogId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsProductsApi.GetChannelCatalogProductInfo: " + e.Message );
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

### Return type

[**ChannelCatalogProductInfo**](ChannelCatalogProductInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcatalogproductinfolist"></a>
# **GetChannelCatalogProductInfoList**
> ChannelCatalogProductInfoList GetChannelCatalogProductInfoList (string channelCatalogId, GetChannelCatalogProductInfoListRequest request = null)

Get channel catalog product information list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogProductInfoListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ChannelCatalogsProductsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new GetChannelCatalogProductInfoListRequest(); // GetChannelCatalogProductInfoListRequest | The channel catalog product list filter (optional) 

            try
            {
                // Get channel catalog product information list
                ChannelCatalogProductInfoList result = apiInstance.GetChannelCatalogProductInfoList(channelCatalogId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChannelCatalogsProductsApi.GetChannelCatalogProductInfoList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelCatalogId** | **string**| The channel catalog identifier | 
 **request** | [**GetChannelCatalogProductInfoListRequest**](GetChannelCatalogProductInfoListRequest.md)| The channel catalog product list filter | [optional] 

### Return type

[**ChannelCatalogProductInfoList**](ChannelCatalogProductInfoList.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

