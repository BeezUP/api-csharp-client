# IO.Swagger.Api.GroupsApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPublicListGroup**](GroupsApi.md#getpubliclistgroup) | **GET** /v2/public/lov/groups/{listGroupName} | Get list of values related to this group name
[**GetPublicListGroupNames**](GroupsApi.md#getpubliclistgroupnames) | **GET** /v2/public/lov/groups | Get list of group of list name
[**GetUserListGroup**](GroupsApi.md#getuserlistgroup) | **GET** /v2/user/lov/groups/{listGroupName} | Get list of values related to this group name
[**GetUserListGroupNames**](GroupsApi.md#getuserlistgroupnames) | **GET** /v2/user/lov/groups | Get list of group of list name


<a name="getpubliclistgroup"></a>
# **GetPublicListGroup**
> List<BeezUPCommonLOVLink2> GetPublicListGroup (string listGroupName)

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
    public class GetPublicListGroupExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var listGroupName = listGroupName_example;  // string | The list group name your want to get

            try
            {
                // Get list of values related to this group name
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetPublicListGroup(listGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetPublicListGroup: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpubliclistgroupnames"></a>
# **GetPublicListGroupNames**
> List<BeezUPCommonLOVLink2> GetPublicListGroupNames ()

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
    public class GetPublicListGroupNamesExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();

            try
            {
                // Get list of group of list name
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetPublicListGroupNames();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetPublicListGroupNames: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new GroupsApi();
            var listGroupName = listGroupName_example;  // string | The list group name your want to get

            try
            {
                // Get list of values related to this group name
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetUserListGroup(listGroupName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetUserListGroup: " + e.Message );
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

            var apiInstance = new GroupsApi();

            try
            {
                // Get list of group of list name
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetUserListGroupNames();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetUserListGroupNames: " + e.Message );
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

