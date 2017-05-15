# IO.Swagger.Api.PublicChannelsPublicChannelsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannels**](PublicChannelsPublicChannelsApi.md#getchannels) | **GET** /public/channels/{countryIsoCode} | The channel list for one country
[**GetChannelsIndex**](PublicChannelsPublicChannelsApi.md#getchannelsindex) | **GET** /public/channels/ | Get public channel index


<a name="getchannels"></a>
# **GetChannels**
> ChannelInfoList GetChannels (string countryIsoCode, List<string> acceptEncoding)

The channel list for one country

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelsExample
    {
        public void main()
        {
            
            var apiInstance = new PublicChannelsPublicChannelsApi();
            var countryIsoCode = countryIsoCode_example;  // string | The country iso code alpha 3 based on this: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3#Decoding_table \\ To know which country are available you have to use the operation: GetChannelsByCountry 
            var acceptEncoding = new List<string>(); // List<string> | Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size.

            try
            {
                // The channel list for one country
                ChannelInfoList result = apiInstance.GetChannels(countryIsoCode, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicChannelsPublicChannelsApi.GetChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryIsoCode** | **string**| The country iso code alpha 3 based on this: https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3#Decoding_table \\ To know which country are available you have to use the operation: GetChannelsByCountry  | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Allows the client to indicate wether it accepts a compressed encoding to reduce traffic size. | 

### Return type

[**ChannelInfoList**](ChannelInfoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchannelsindex"></a>
# **GetChannelsIndex**
> PublicChannelIndex GetChannelsIndex ()

Get public channel index

Use this operation to get the correct link to the channels and to the list of values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelsIndexExample
    {
        public void main()
        {
            
            var apiInstance = new PublicChannelsPublicChannelsApi();

            try
            {
                // Get public channel index
                PublicChannelIndex result = apiInstance.GetChannelsIndex();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicChannelsPublicChannelsApi.GetChannelsIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PublicChannelIndex**](PublicChannelIndex.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

