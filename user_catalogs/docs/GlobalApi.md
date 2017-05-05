# IO.Swagger.Api.GlobalApi

All URIs are relative to *https://api.beezup.com/v2/user/catalogs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CatalogGetBeezUPColumns**](GlobalApi.md#cataloggetbeezupcolumns) | **GET** /beezupColumns | Get the BeezUP columns


<a name="cataloggetbeezupcolumns"></a>
# **CatalogGetBeezUPColumns**
> List<BeezUPColumnConfiguration> CatalogGetBeezUPColumns ()

Get the BeezUP columns

Get the BeezUP columns, this columns are used for mapping during the manual catalog importation process.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetBeezUPColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new GlobalApi();

            try
            {
                // Get the BeezUP columns
                List&lt;BeezUPColumnConfiguration&gt; result = apiInstance.CatalogGetBeezUPColumns();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalApi.CatalogGetBeezUPColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BeezUPColumnConfiguration>**](BeezUPColumnConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

