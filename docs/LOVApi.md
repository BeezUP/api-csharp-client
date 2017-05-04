# IO.Swagger.Api.LOVApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPublicListNames**](LOVApi.md#getpubliclistnames) | **GET** /v2/public/lov/ | Get all list names
[**GetPublicListOfValues**](LOVApi.md#getpubliclistofvalues) | **GET** /v2/public/lov/{listName} | Get the list of values related to this list name


<a name="getpubliclistnames"></a>
# **GetPublicListNames**
> List<BeezUPCommonLOVLink2> GetPublicListNames ()

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
    public class GetPublicListNamesExample
    {
        public void main()
        {
            
            var apiInstance = new LOVApi();

            try
            {
                // Get all list names
                List&lt;BeezUPCommonLOVLink2&gt; result = apiInstance.GetPublicListNames();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LOVApi.GetPublicListNames: " + e.Message );
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

<a name="getpubliclistofvalues"></a>
# **GetPublicListOfValues**
> List<BeezUPCommonListOfValueItem> GetPublicListOfValues (string listName, List<string> acceptLanguage = null)

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
    public class GetPublicListOfValuesExample
    {
        public void main()
        {
            
            var apiInstance = new LOVApi();
            var listName = listName_example;  // string | The list of value name your want to get
            var acceptLanguage = new List<string>(); // List<string> | Indicates that the client accepts the following languages. (optional) 

            try
            {
                // Get the list of values related to this list name
                List&lt;BeezUPCommonListOfValueItem&gt; result = apiInstance.GetPublicListOfValues(listName, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LOVApi.GetPublicListOfValues: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

