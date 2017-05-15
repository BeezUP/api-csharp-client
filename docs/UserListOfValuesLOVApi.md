# IO.Swagger.Api.UserListOfValuesLOVApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserListOfValues**](UserListOfValuesLOVApi.md#getuserlistofvalues) | **GET** /user/lov/{listName} | Get the list of values related to this list name
[**GetUserLovIndex**](UserListOfValuesLOVApi.md#getuserlovindex) | **GET** /user/lov/ | Get all list names


<a name="getuserlistofvalues"></a>
# **GetUserListOfValues**
> UserListOfValuesResponse GetUserListOfValues (string listName, List<string> acceptLanguage = null, string ifNoneMatch = null)

Get the list of values related to this list name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserListOfValuesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new UserListOfValuesLOVApi();
            var listName = listName_example;  // string | The list of value name your want to get
            var acceptLanguage = new List<string>(); // List<string> | Indicates that the client accepts the following languages. (optional) 
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  (optional) 

            try
            {
                // Get the list of values related to this list name
                UserListOfValuesResponse result = apiInstance.GetUserListOfValues(listName, acceptLanguage, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserListOfValuesLOVApi.GetUserListOfValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listName** | **string**| The list of value name your want to get | 
 **acceptLanguage** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts the following languages. | [optional] 
 **ifNoneMatch** | **string**| ETag value to identify the last known version of requested resource.\\ To avoid useless exchange, we recommend you to indicate the ETag you previously got from this operation.\\ If the ETag value does not match the response will be 200 to give you a new content, otherwise the response will be: 304 Not Modified, without any content.\\ For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | [optional] 

### Return type

[**UserListOfValuesResponse**](UserListOfValuesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlovindex"></a>
# **GetUserLovIndex**
> UserLovIndex GetUserLovIndex ()

Get all list names

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserLovIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new UserListOfValuesLOVApi();

            try
            {
                // Get all list names
                UserLovIndex result = apiInstance.GetUserLovIndex();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserListOfValuesLOVApi.GetUserLovIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserLovIndex**](UserLovIndex.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

