# IO.Swagger.Api.V2UserChannelCatalogsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigureChannelCatalogCostSettings**](V2UserChannelCatalogsApi.md#configurechannelcatalogcostsettings) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/settings/cost | Disable a channel catalog
[**ConfigureChannelCatalogExclusionFilters**](V2UserChannelCatalogsApi.md#configurechannelcatalogexclusionfilters) | **PUT** /v2/user/channelCatalogs/{channelCatalogId}/exclusionFilters | Configure channel catalog exclusion filters
[**ConfigureChannelCatalogGeneralSettings**](V2UserChannelCatalogsApi.md#configurechannelcataloggeneralsettings) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/settings/general | Disable a channel catalog
[**CreateChannelCatalog**](V2UserChannelCatalogsApi.md#createchannelcatalog) | **POST** /v2/user/channelCatalogs/ | Create a new channel catalog
[**DeleteChannelCatalog**](V2UserChannelCatalogsApi.md#deletechannelcatalog) | **DELETE** /v2/user/channelCatalogs/{channelCatalogId} | Delete the channel catalog
[**DeleteChannelCatalogProductValueOverride**](V2UserChannelCatalogsApi.md#deletechannelcatalogproductvalueoverride) | **DELETE** /v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides/{channelColumnId} | Delete a specific channel catalog product value override
[**DisableChannelCatalog**](V2UserChannelCatalogsApi.md#disablechannelcatalog) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/disable | Disable a channel catalog
[**DisableChannelCatalogProduct**](V2UserChannelCatalogsApi.md#disablechannelcatalogproduct) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/disable | Disable channel catalog product
[**EnableChannelCatalog**](V2UserChannelCatalogsApi.md#enablechannelcatalog) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/enable | Enable a channel catalog
[**GetChannelCatalog**](V2UserChannelCatalogsApi.md#getchannelcatalog) | **GET** /v2/user/channelCatalogs/{channelCatalogId} | Get the channel catalog information
[**GetChannelCatalogCategories**](V2UserChannelCatalogsApi.md#getchannelcatalogcategories) | **GET** /v2/user/channelCatalogs/{channelCatalogId}/categoryMappings | Get channel catalog categories
[**GetChannelCatalogExclusionFilterOperators**](V2UserChannelCatalogsApi.md#getchannelcatalogexclusionfilteroperators) | **GET** /v2/user/channelCatalogs/exclusionFilterOperators | Get channel catalog exclusion filter operators
[**GetChannelCatalogProductInfo**](V2UserChannelCatalogsApi.md#getchannelcatalogproductinfo) | **GET** /v2/user/channelCatalogs/{channelCatalogId}/products/{productId} | Get channel catalog product information
[**GetChannelCatalogProductInfoList**](V2UserChannelCatalogsApi.md#getchannelcatalogproductinfolist) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/products | Get channel catalog product information list
[**GetChannelCatalogs**](V2UserChannelCatalogsApi.md#getchannelcatalogs) | **GET** /v2/user/channelCatalogs/ | List all your current channel catalogs
[**MapChannelCatalogCategory**](V2UserChannelCatalogsApi.md#mapchannelcatalogcategory) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/categoryMappings/map | Map channel catalog category
[**MapChannelCatalogColumns**](V2UserChannelCatalogsApi.md#mapchannelcatalogcolumns) | **PUT** /v2/user/channelCatalogs/{channelCatalogId}/columnMappings | Configure channel catalog column mappings
[**OverrideChannelCatalogProductOverrides**](V2UserChannelCatalogsApi.md#overridechannelcatalogproductoverrides) | **PUT** /v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/overrides | Override channel catalog product values
[**ReenableChannelCatalogProduct**](V2UserChannelCatalogsApi.md#reenablechannelcatalogproduct) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/products/{productId}/reenable | Reenable channel catalog product
[**UnmapChannelCatalogCategory**](V2UserChannelCatalogsApi.md#unmapchannelcatalogcategory) | **POST** /v2/user/channelCatalogs/{channelCatalogId}/categoryMappings/unmap | Unmap channel catalog category


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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new CostSettings(); // CostSettings | 

            try
            {
                // Disable a channel catalog
                apiInstance.ConfigureChannelCatalogCostSettings(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.ConfigureChannelCatalogCostSettings: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new ExclusionFilters(); // ExclusionFilters | 

            try
            {
                // Configure channel catalog exclusion filters
                apiInstance.ConfigureChannelCatalogExclusionFilters(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.ConfigureChannelCatalogExclusionFilters: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new GeneralSettings(); // GeneralSettings | 

            try
            {
                // Disable a channel catalog
                apiInstance.ConfigureChannelCatalogGeneralSettings(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.ConfigureChannelCatalogGeneralSettings: " + e.Message );
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

<a name="createchannelcatalog"></a>
# **CreateChannelCatalog**
> List<BeezUPCommonLink2> CreateChannelCatalog (CreateChannelCatalogRequest request)

Create a new channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelCatalogsApi();
            var request = new CreateChannelCatalogRequest(); // CreateChannelCatalogRequest | 

            try
            {
                // Create a new channel catalog
                List&lt;BeezUPCommonLink2&gt; result = apiInstance.CreateChannelCatalog(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.CreateChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateChannelCatalogRequest**](CreateChannelCatalogRequest.md)|  | 

### Return type

[**List<BeezUPCommonLink2>**](BeezUPCommonLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechannelcatalog"></a>
# **DeleteChannelCatalog**
> void DeleteChannelCatalog ()

Delete the channel catalog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelCatalogsApi();

            try
            {
                // Delete the channel catalog
                apiInstance.DeleteChannelCatalog();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.DeleteChannelCatalog: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new V2UserChannelCatalogsApi();
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
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.DeleteChannelCatalogProductValueOverride: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Disable a channel catalog
                apiInstance.DisableChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.DisableChannelCatalog: " + e.Message );
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

<a name="disablechannelcatalogproduct"></a>
# **DisableChannelCatalogProduct**
> void DisableChannelCatalogProduct (string channelCatalogId, string productId)

Disable channel catalog product

By default a all your catalog products are exposed to the channel. You can disable a product by using this operation. /!\\ In case of massive optimisation we recommand you to use the analytics api 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DisableChannelCatalogProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier

            try
            {
                // Disable channel catalog product
                apiInstance.DisableChannelCatalogProduct(channelCatalogId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.DisableChannelCatalogProduct: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Enable a channel catalog
                apiInstance.EnableChannelCatalog(channelCatalogId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.EnableChannelCatalog: " + e.Message );
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

<a name="getchannelcatalog"></a>
# **GetChannelCatalog**
> ChannelCatalog GetChannelCatalog (string channelCatalogId)

Get the channel catalog information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get the channel catalog information
                ChannelCatalog result = apiInstance.GetChannelCatalog(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.GetChannelCatalog: " + e.Message );
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

[**ChannelCatalog**](ChannelCatalog.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier

            try
            {
                // Get channel catalog categories
                ChannelCatalogCategoryMappings result = apiInstance.GetChannelCatalogCategories(channelCatalogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.GetChannelCatalogCategories: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();

            try
            {
                // Get channel catalog exclusion filter operators
                List&lt;ExclusionFilterOperator&gt; result = apiInstance.GetChannelCatalogExclusionFilterOperators();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.GetChannelCatalogExclusionFilterOperators: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
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
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.GetChannelCatalogProductInfo: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
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
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.GetChannelCatalogProductInfoList: " + e.Message );
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

<a name="getchannelcatalogs"></a>
# **GetChannelCatalogs**
> ChannelCatalogList GetChannelCatalogs (string storeId = null)

List all your current channel catalogs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCatalogsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelCatalogsApi();
            var storeId = 04730364-9826-4ff3-92e4-51fccd02bf10;  // string | The store identifier (optional) 

            try
            {
                // List all your current channel catalogs
                ChannelCatalogList result = apiInstance.GetChannelCatalogs(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.GetChannelCatalogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| The store identifier | [optional] 

### Return type

[**ChannelCatalogList**](ChannelCatalogList.md)

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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new MapCategoryRequest(); // MapCategoryRequest | 

            try
            {
                // Map channel catalog category
                apiInstance.MapChannelCatalogCategory(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.MapChannelCatalogCategory: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new ColumnMappingList(); // ColumnMappingList | 

            try
            {
                // Configure channel catalog column mappings
                apiInstance.MapChannelCatalogColumns(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.MapChannelCatalogColumns: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
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
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.OverrideChannelCatalogProductOverrides: " + e.Message );
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

<a name="reenablechannelcatalogproduct"></a>
# **ReenableChannelCatalogProduct**
> void ReenableChannelCatalogProduct (string channelCatalogId, string productId)

Reenable channel catalog product

By default a all your catalog products are exposed to the channel. You can reenable a product by using this operation. /!\\ In case of massive optimisation we recommand you to use the analytics api 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReenableChannelCatalogProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var productId = 578419df-1bbf-41a6-96fa-862e42182b67;  // string | The product identifier

            try
            {
                // Reenable channel catalog product
                apiInstance.ReenableChannelCatalogProduct(channelCatalogId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.ReenableChannelCatalogProduct: " + e.Message );
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

            var apiInstance = new V2UserChannelCatalogsApi();
            var channelCatalogId = 6d6b04de-406b-4539-8e7e-bf3e8da5dfb0;  // string | The channel catalog identifier
            var request = new UnmapCategoryRequest(); // UnmapCategoryRequest | 

            try
            {
                // Unmap channel catalog category
                apiInstance.UnmapChannelCatalogCategory(channelCatalogId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelCatalogsApi.UnmapChannelCatalogCategory: " + e.Message );
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

