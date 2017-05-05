# IO.Swagger.Api.RightsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRights**](RightsApi.md#getrights) | **POST** /v2/user/customer/stores/{storeId}/rights | Get store&#39;s rights


<a name="getrights"></a>
# **GetRights**
> List<FunctionalityRightInfo> GetRights (string storeId, List<string> functionalityCodeList)

Get store's rights

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRightsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new RightsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var functionalityCodeList = ;  // List<string> | The functionality code list you want to check

            try
            {
                // Get store's rights
                List&lt;FunctionalityRightInfo&gt; result = apiInstance.GetRights(storeId, functionalityCodeList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RightsApi.GetRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **functionalityCodeList** | **List&lt;string&gt;**| The functionality code list you want to check | 

### Return type

[**List<FunctionalityRightInfo>**](FunctionalityRightInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

