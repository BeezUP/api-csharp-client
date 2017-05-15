# IO.Swagger.Api.MarketplacesChannelCatalogsPublicationsApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPublications**](MarketplacesChannelCatalogsPublicationsApi.md#getpublications) | **GET** /user/marketplaces/channelcatalogs/publications/{marketplaceTechnicalCode}/{accountId}/history | Fetch the publication history for an account, sorted by descending start date


<a name="getpublications"></a>
# **GetPublications**
> AccountPublications GetPublications (string marketplaceTechnicalCode, int? accountId, string channelCatalogId = null, int? count = null, List<string> publicationTypes = null)

Fetch the publication history for an account, sorted by descending start date

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPublicationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new MarketplacesChannelCatalogsPublicationsApi();
            var marketplaceTechnicalCode = marketplaceTechnicalCode_example;  // string | Marketplace Technical Code to query (required)
            var accountId = 56;  // int? | Account Id to query (required)
            var channelCatalogId = channelCatalogId_example;  // string | Channel Catalog Id by which to filter (optional) (optional) 
            var count = 56;  // int? | Amount of entries to fetch (optional, default set to 10) (optional)  (default to 10)
            var publicationTypes = new List<string>(); // List<string> | Publication types by which to filter (optional) (optional) 

            try
            {
                // Fetch the publication history for an account, sorted by descending start date
                AccountPublications result = apiInstance.GetPublications(marketplaceTechnicalCode, accountId, channelCatalogId, count, publicationTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplacesChannelCatalogsPublicationsApi.GetPublications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketplaceTechnicalCode** | **string**| Marketplace Technical Code to query (required) | 
 **accountId** | **int?**| Account Id to query (required) | 
 **channelCatalogId** | **string**| Channel Catalog Id by which to filter (optional) | [optional] 
 **count** | **int?**| Amount of entries to fetch (optional, default set to 10) | [optional] [default to 10]
 **publicationTypes** | [**List&lt;string&gt;**](string.md)| Publication types by which to filter (optional) | [optional] 

### Return type

[**AccountPublications**](AccountPublications.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

