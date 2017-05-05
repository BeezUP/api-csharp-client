# IO.Swagger.Api.AutoTransitionsApi

All URIs are relative to *https://api.beezup.com/v2/user/marketplaces/orders*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigureAutomaticTransitions**](AutoTransitionsApi.md#configureautomatictransitions) | **POST** /automaticTransitions | Configure new or existing automatic Order status transition
[**GetAutomaticTransitions**](AutoTransitionsApi.md#getautomatictransitions) | **GET** /automaticTransitions | Get list of configured automatic Order status transitions


<a name="configureautomatictransitions"></a>
# **ConfigureAutomaticTransitions**
> void ConfigureAutomaticTransitions (SaveAutomaticTransitionRequest request)

Configure new or existing automatic Order status transition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ConfigureAutomaticTransitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AutoTransitionsApi();
            var request = new SaveAutomaticTransitionRequest(); // SaveAutomaticTransitionRequest | 

            try
            {
                // Configure new or existing automatic Order status transition
                apiInstance.ConfigureAutomaticTransitions(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoTransitionsApi.ConfigureAutomaticTransitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveAutomaticTransitionRequest**](SaveAutomaticTransitionRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautomatictransitions"></a>
# **GetAutomaticTransitions**
> AutomaticTransitionInfos GetAutomaticTransitions ()

Get list of configured automatic Order status transitions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAutomaticTransitionsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new AutoTransitionsApi();

            try
            {
                // Get list of configured automatic Order status transitions
                AutomaticTransitionInfos result = apiInstance.GetAutomaticTransitions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoTransitionsApi.GetAutomaticTransitions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AutomaticTransitionInfos**](AutomaticTransitionInfos.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

