# IO.Swagger.Api.V2UserChannelsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannelCategories**](V2UserChannelsApi.md#getchannelcategories) | **GET** /v2/user/channels/{channelId}/categories | Get channel categories
[**GetChannelColumns**](V2UserChannelsApi.md#getchannelcolumns) | **POST** /v2/user/channels/{channelId}/columns | Get channel columns
[**GetChannelInfo**](V2UserChannelsApi.md#getchannelinfo) | **GET** /v2/user/channels/{channelId} | Get channel information
[**GetCurrentChannels**](V2UserChannelsApi.md#getcurrentchannels) | **GET** /v2/user/channels/ | List all available channel for this store


<a name="getchannelcategories"></a>
# **GetChannelCategories**
> ChannelRootCategory GetChannelCategories (string channelId, List<string> acceptEncoding)

Get channel categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelsApi();
            var channelId = 2dc136a7-0d3d-4cc9-a825-a28a42c53e28;  // string | The channel identifier
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.

            try
            {
                // Get channel categories
                ChannelRootCategory result = apiInstance.GetChannelCategories(channelId, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelsApi.GetChannelCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| The channel identifier | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 

### Return type

[**ChannelRootCategory**](ChannelRootCategory.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelcolumns"></a>
# **GetChannelColumns**
> List<ChannelColumn> GetChannelColumns (string channelId, List<string> acceptEncoding, List<BeezUPCommonChannelColumnId> request = null)

Get channel columns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelsApi();
            var channelId = 2dc136a7-0d3d-4cc9-a825-a28a42c53e28;  // string | The channel identifier
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.
            var request = new List<BeezUPCommonChannelColumnId>(); // List<BeezUPCommonChannelColumnId> | Allow you to filter the channel column identifier list your want to get (optional) 

            try
            {
                // Get channel columns
                List&lt;ChannelColumn&gt; result = apiInstance.GetChannelColumns(channelId, acceptEncoding, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelsApi.GetChannelColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| The channel identifier | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 
 **request** | [**List&lt;BeezUPCommonChannelColumnId&gt;**](BeezUPCommonChannelColumnId.md)| Allow you to filter the channel column identifier list your want to get | [optional] 

### Return type

[**List<ChannelColumn>**](ChannelColumn.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelinfo"></a>
# **GetChannelInfo**
> ChannelInfo GetChannelInfo (string channelId)

Get channel information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelsApi();
            var channelId = 2dc136a7-0d3d-4cc9-a825-a28a42c53e28;  // string | The channel identifier

            try
            {
                // Get channel information
                ChannelInfo result = apiInstance.GetChannelInfo(channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelsApi.GetChannelInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| The channel identifier | 

### Return type

[**ChannelInfo**](ChannelInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentchannels"></a>
# **GetCurrentChannels**
> List<ChannelHeader> GetCurrentChannels (string storeId)

List all available channel for this store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentChannelsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserChannelsApi();
            var storeId = 04730364-9826-4ff3-92e4-51fccd02bf10;  // string | The store identifier

            try
            {
                // List all available channel for this store
                List&lt;ChannelHeader&gt; result = apiInstance.GetCurrentChannels(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserChannelsApi.GetCurrentChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| The store identifier | 

### Return type

[**List<ChannelHeader>**](ChannelHeader.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

