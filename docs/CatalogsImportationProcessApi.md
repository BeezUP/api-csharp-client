# IO.Swagger.Api.CatalogsImportationProcessApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportationCancel**](CatalogsImportationProcessApi.md#importationcancel) | **DELETE** /user/catalogs/{storeId}/importations/{executionId} | Cancel importation
[**ImportationCommit**](CatalogsImportationProcessApi.md#importationcommit) | **POST** /user/catalogs/{storeId}/importations/{executionId}/commit | Commit Importation
[**ImportationCommitColumns**](CatalogsImportationProcessApi.md#importationcommitcolumns) | **POST** /user/catalogs/{storeId}/importations/{executionId}/commitColumns | Commit columns
[**ImportationConfigureRemainingCatalogColumns**](CatalogsImportationProcessApi.md#importationconfigureremainingcatalogcolumns) | **POST** /user/catalogs/{storeId}/importations/{executionId}/configureRemainingCatalogColumns | Configure remaining catalog columns
[**ImportationGetImportationMonitoring**](CatalogsImportationProcessApi.md#importationgetimportationmonitoring) | **GET** /user/catalogs/{storeId}/importations/{executionId} | Get the importation status
[**ImportationGetReportings**](CatalogsImportationProcessApi.md#importationgetreportings) | **GET** /user/catalogs/{storeId}/importations | Get the latest catalog importation reporting
[**ImportationStartManualUpdate**](CatalogsImportationProcessApi.md#importationstartmanualupdate) | **POST** /user/catalogs/{storeId}/importations | Start Manual Import
[**ImportationTechnicalProgression**](CatalogsImportationProcessApi.md#importationtechnicalprogression) | **GET** /user/catalogs/{storeId}/importations/{executionId}/technicalProgression | Get technical progression


<a name="importationcancel"></a>
# **ImportationCancel**
> void ImportationCancel (string storeId, string executionId)

Cancel importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationCancelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Cancel importation
                apiInstance.ImportationCancel(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationcommit"></a>
# **ImportationCommit**
> void ImportationCommit (string storeId, string executionId)

Commit Importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationCommitExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Commit Importation
                apiInstance.ImportationCommit(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationCommit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationcommitcolumns"></a>
# **ImportationCommitColumns**
> void ImportationCommitColumns (string storeId, string executionId)

Commit columns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationCommitColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Commit columns
                apiInstance.ImportationCommitColumns(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationCommitColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationconfigureremainingcatalogcolumns"></a>
# **ImportationConfigureRemainingCatalogColumns**
> void ImportationConfigureRemainingCatalogColumns (string storeId, string executionId)

Configure remaining catalog columns

This operation should be used after you have mapped the required BeezUP Columns

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationConfigureRemainingCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Configure remaining catalog columns
                apiInstance.ImportationConfigureRemainingCatalogColumns(storeId, executionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationConfigureRemainingCatalogColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetimportationmonitoring"></a>
# **ImportationGetImportationMonitoring**
> ImportationMonitoring ImportationGetImportationMonitoring (string storeId, string executionId)

Get the importation status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetImportationMonitoringExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get the importation status
                ImportationMonitoring result = apiInstance.ImportationGetImportationMonitoring(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationGetImportationMonitoring: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

[**ImportationMonitoring**](ImportationMonitoring.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetreportings"></a>
# **ImportationGetReportings**
> List<ImportationReporting> ImportationGetReportings (string storeId)

Get the latest catalog importation reporting

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetReportingsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get the latest catalog importation reporting
                List&lt;ImportationReporting&gt; result = apiInstance.ImportationGetReportings(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationGetReportings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**List<ImportationReporting>**](ImportationReporting.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationstartmanualupdate"></a>
# **ImportationStartManualUpdate**
> LinksImportationGetImportationMonitoringLink ImportationStartManualUpdate (string storeId, StartManualImportRequest request)

Start Manual Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationStartManualUpdateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new StartManualImportRequest(); // StartManualImportRequest | 

            try
            {
                // Start Manual Import
                LinksImportationGetImportationMonitoringLink result = apiInstance.ImportationStartManualUpdate(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationStartManualUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**StartManualImportRequest**](StartManualImportRequest.md)|  | 

### Return type

[**LinksImportationGetImportationMonitoringLink**](LinksImportationGetImportationMonitoringLink.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationtechnicalprogression"></a>
# **ImportationTechnicalProgression**
> ImportationTechnicalProgression ImportationTechnicalProgression (string storeId, string executionId)

Get technical progression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationTechnicalProgressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsImportationProcessApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get technical progression
                ImportationTechnicalProgression result = apiInstance.ImportationTechnicalProgression(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsImportationProcessApi.ImportationTechnicalProgression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **executionId** | **string**| The execution identifier of you catalog importation | 

### Return type

[**ImportationTechnicalProgression**](ImportationTechnicalProgression.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

