# IO.Swagger.Api.PublicChannelsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChannels**](PublicChannelsApi.md#getchannels) | **GET** /BeezUP/public_channels/2.0/{countryIsoCode} | The channel list for one country
[**GetChannelsByCountry**](PublicChannelsApi.md#getchannelsbycountry) | **GET** /BeezUP/public_channels/2.0/ | The channel list regrouped by country


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
            
            var apiInstance = new PublicChannelsApi();
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
                Debug.Print("Exception when calling PublicChannelsApi.GetChannels: " + e.Message );
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

<a name="getchannelsbycountry"></a>
# **GetChannelsByCountry**
> Dictionary<string, string> GetChannelsByCountry ()

The channel list regrouped by country

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChannelsByCountryExample
    {
        public void main()
        {
            
            var apiInstance = new PublicChannelsApi();

            try
            {
                // The channel list regrouped by country
                Dictionary&lt;string, string&gt; result = apiInstance.GetChannelsByCountry();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicChannelsApi.GetChannelsByCountry: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

