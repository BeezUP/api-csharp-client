# IO.Swagger.Api.UserLOVApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserListGroup**](UserLOVApi.md#getuserlistgroup) | **GET** /v2/user/lov/groups/{listGroupName} | Get list of values related to this group name
[**GetUserListGroupNames**](UserLOVApi.md#getuserlistgroupnames) | **GET** /v2/user/lov/groups | Get list of group of list name
[**GetUserListNames**](UserLOVApi.md#getuserlistnames) | **GET** /v2/user/lov/ | Get all list names
[**GetUserListOfValues**](UserLOVApi.md#getuserlistofvalues) | **GET** /v2/user/lov/{listName} | Get the list of values related to this list name


<a name="getuserlistgroup"></a>
# **GetUserListGroup**
> List<BeezUPCommonLOVLink2> GetUserListGroup (string listGroupName)

Get list of values related to this group name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserListGroupExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new UserLOVApi();
            var listGroupName = listGroupName_example;  // string | The list group name your want to get

            try
            {
                // Get list of values related to this group name
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetUserListGroup(listGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserLOVApi.GetUserListGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listGroupName** | **string**| The list group name your want to get | 

### Return type

[**List<BeezUPCommonLOVLink2>**](BeezUPCommonLOVLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlistgroupnames"></a>
# **GetUserListGroupNames**
> List<BeezUPCommonLOVLink2> GetUserListGroupNames ()

Get list of group of list name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserListGroupNamesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new UserLOVApi();

            try
            {
                // Get list of group of list name
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetUserListGroupNames();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserLOVApi.GetUserListGroupNames: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BeezUPCommonLOVLink2>**](BeezUPCommonLOVLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlistnames"></a>
# **GetUserListNames**
> List<BeezUPCommonLOVLink2> GetUserListNames ()

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
    public class GetUserListNamesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new UserLOVApi();

            try
            {
                // Get all list names
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetUserListNames();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserLOVApi.GetUserListNames: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BeezUPCommonLOVLink2>**](BeezUPCommonLOVLink2.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserlistofvalues"></a>
# **GetUserListOfValues**
> List<BeezUPCommonListOfValueItem> GetUserListOfValues (string listName, List<string> acceptLanguage = null)

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

            var apiInstance = new UserLOVApi();
            var listName = listName_example;  // string | The list of value name your want to get
            var acceptLanguage = new List<string>(); // List<string> | Indicates that the client accepts the following languages. (optional) 

            try
            {
                // Get the list of values related to this list name
                List&lt;BeezUPCommonListOfValueItem&gt; result = apiInstance.GetUserListOfValues(listName, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserLOVApi.GetUserListOfValues: " + e.Message );
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

### Return type

[**List<BeezUPCommonListOfValueItem>**](BeezUPCommonListOfValueItem.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

