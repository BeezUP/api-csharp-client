# IO.Swagger.Api.ImportationCatalogInfoApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImportationConfigureCatalogColumn**](ImportationCatalogInfoApi.md#importationconfigurecatalogcolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId} | Configure catalog column
[**ImportationDeleteCustomColumn**](ImportationCatalogInfoApi.md#importationdeletecustomcolumn) | **DELETE** /v2/user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId} | Delete Custom Column
[**ImportationGetCustomColumnExpression**](ImportationCatalogInfoApi.md#importationgetcustomcolumnexpression) | **GET** /v2/user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId}/expression | Get the encrypted custom column expression in this importation
[**ImportationGetCustomColumns**](ImportationCatalogInfoApi.md#importationgetcustomcolumns) | **GET** /v2/user/catalogs/{storeId}/importations/{executionId}/customColumns | Get custom columns currently place in this importation
[**ImportationGetDetectedCatalogColumns**](ImportationCatalogInfoApi.md#importationgetdetectedcatalogcolumns) | **GET** /v2/user/catalogs/{storeId}/importations/{executionId}/catalogColumns | Get detected catalog columns during this importation.
[**ImportationGetProductSample**](ImportationCatalogInfoApi.md#importationgetproductsample) | **GET** /v2/user/catalogs/{storeId}/importations/{executionId}/productSamples/{productSampleIndex} | Get the product sample related to this importation with all columns (catalog and custom)
[**ImportationGetProductSampleCustomColumnValue**](ImportationCatalogInfoApi.md#importationgetproductsamplecustomcolumnvalue) | **GET** /v2/user/catalogs/{storeId}/importations/{executionId}/productSamples/{productSampleIndex}/customColumns/{columnId} | Get product sample custom column value related to this importation.
[**ImportationIgnoreColumn**](ImportationCatalogInfoApi.md#importationignorecolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/ignore | Ignore Column
[**ImportationMapCatalogColumn**](ImportationCatalogInfoApi.md#importationmapcatalogcolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/map | Map catalog column to a BeezUP column
[**ImportationMapCustomColumn**](ImportationCatalogInfoApi.md#importationmapcustomcolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId}/map | Map custom column to a BeezUP column
[**ImportationReattendColumn**](ImportationCatalogInfoApi.md#importationreattendcolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/reattend | Reattend Column
[**ImportationSaveCustomColumn**](ImportationCatalogInfoApi.md#importationsavecustomcolumn) | **PUT** /v2/user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId} | Create or replace a custom column
[**ImportationUnmapCatalogColumn**](ImportationCatalogInfoApi.md#importationunmapcatalogcolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/catalogColumns/{columnId}/unmap | Unmap catalog column
[**ImportationUnmapCustomColumn**](ImportationCatalogInfoApi.md#importationunmapcustomcolumn) | **POST** /v2/user/catalogs/{storeId}/importations/{executionId}/customColumns/{columnId}/unmap | Unmap custom column


<a name="importationconfigurecatalogcolumn"></a>
# **ImportationConfigureCatalogColumn**
> void ImportationConfigureCatalogColumn (string storeId, string executionId, string columnId, ConfigureCatalogColumnCatalogRequest request)

Configure catalog column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationConfigureCatalogColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ConfigureCatalogColumnCatalogRequest(); // ConfigureCatalogColumnCatalogRequest | 

            try
            {
                // Configure catalog column
                apiInstance.ImportationConfigureCatalogColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationConfigureCatalogColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ConfigureCatalogColumnCatalogRequest**](ConfigureCatalogColumnCatalogRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationdeletecustomcolumn"></a>
# **ImportationDeleteCustomColumn**
> void ImportationDeleteCustomColumn (string storeId, string executionId, string columnId)

Delete Custom Column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationDeleteCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Delete Custom Column
                apiInstance.ImportationDeleteCustomColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationDeleteCustomColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetcustomcolumnexpression"></a>
# **ImportationGetCustomColumnExpression**
> string ImportationGetCustomColumnExpression (string storeId, string executionId, string columnId)

Get the encrypted custom column expression in this importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetCustomColumnExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Get the encrypted custom column expression in this importation
                string result = apiInstance.ImportationGetCustomColumnExpression(storeId, executionId, columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationGetCustomColumnExpression: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetcustomcolumns"></a>
# **ImportationGetCustomColumns**
> CustomColumns ImportationGetCustomColumns (string storeId, string executionId)

Get custom columns currently place in this importation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetCustomColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get custom columns currently place in this importation
                CustomColumns result = apiInstance.ImportationGetCustomColumns(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationGetCustomColumns: " + e.Message );
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

[**CustomColumns**](CustomColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetdetectedcatalogcolumns"></a>
# **ImportationGetDetectedCatalogColumns**
> DetectedCatalogColumns ImportationGetDetectedCatalogColumns (string storeId, string executionId)

Get detected catalog columns during this importation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetDetectedCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation

            try
            {
                // Get detected catalog columns during this importation.
                DetectedCatalogColumns result = apiInstance.ImportationGetDetectedCatalogColumns(storeId, executionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationGetDetectedCatalogColumns: " + e.Message );
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

[**DetectedCatalogColumns**](DetectedCatalogColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetproductsample"></a>
# **ImportationGetProductSample**
> ProductSample ImportationGetProductSample (string storeId, string executionId, int? productSampleIndex)

Get the product sample related to this importation with all columns (catalog and custom)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetProductSampleExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var productSampleIndex = 56;  // int? | Index of the product sample. Starting from 0 to 99.

            try
            {
                // Get the product sample related to this importation with all columns (catalog and custom)
                ProductSample result = apiInstance.ImportationGetProductSample(storeId, executionId, productSampleIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationGetProductSample: " + e.Message );
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
 **productSampleIndex** | **int?**| Index of the product sample. Starting from 0 to 99. | 

### Return type

[**ProductSample**](ProductSample.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetproductsamplecustomcolumnvalue"></a>
# **ImportationGetProductSampleCustomColumnValue**
> string ImportationGetProductSampleCustomColumnValue (string storeId, string executionId, int? productSampleIndex, string columnId)

Get product sample custom column value related to this importation.

/!\\ Use this operation only when you just changed the custom column expression and you want to get a precise the property value. Otherwise use the operation Importation_GetProductSample which will give you all property values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetProductSampleCustomColumnValueExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var productSampleIndex = 56;  // int? | Index of the product sample. Starting from 0 to 99.
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Get product sample custom column value related to this importation.
                string result = apiInstance.ImportationGetProductSampleCustomColumnValue(storeId, executionId, productSampleIndex, columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationGetProductSampleCustomColumnValue: " + e.Message );
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
 **productSampleIndex** | **int?**| Index of the product sample. Starting from 0 to 99. | 
 **columnId** | **string**| The custom column identifier | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationignorecolumn"></a>
# **ImportationIgnoreColumn**
> void ImportationIgnoreColumn (string storeId, string executionId, string columnId)

Ignore Column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationIgnoreColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Ignore Column
                apiInstance.ImportationIgnoreColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationIgnoreColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationmapcatalogcolumn"></a>
# **ImportationMapCatalogColumn**
> void ImportationMapCatalogColumn (string storeId, string executionId, string columnId, MapBeezUPColumnRequest request)

Map catalog column to a BeezUP column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationMapCatalogColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The catalog column identifier
            var request = new MapBeezUPColumnRequest(); // MapBeezUPColumnRequest | 

            try
            {
                // Map catalog column to a BeezUP column
                apiInstance.ImportationMapCatalogColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationMapCatalogColumn: " + e.Message );
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
 **columnId** | **string**| The catalog column identifier | 
 **request** | [**MapBeezUPColumnRequest**](MapBeezUPColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationmapcustomcolumn"></a>
# **ImportationMapCustomColumn**
> void ImportationMapCustomColumn (string storeId, string executionId, string columnId, MapBeezUPColumnRequest request)

Map custom column to a BeezUP column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationMapCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new MapBeezUPColumnRequest(); // MapBeezUPColumnRequest | 

            try
            {
                // Map custom column to a BeezUP column
                apiInstance.ImportationMapCustomColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationMapCustomColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 
 **request** | [**MapBeezUPColumnRequest**](MapBeezUPColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationreattendcolumn"></a>
# **ImportationReattendColumn**
> void ImportationReattendColumn (string storeId, string executionId, string columnId)

Reattend Column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationReattendColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Reattend Column
                apiInstance.ImportationReattendColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationReattendColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationsavecustomcolumn"></a>
# **ImportationSaveCustomColumn**
> void ImportationSaveCustomColumn (string storeId, string executionId, string columnId, ChangeCustomColumnRequest request)

Create or replace a custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationSaveCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ChangeCustomColumnRequest(); // ChangeCustomColumnRequest | 

            try
            {
                // Create or replace a custom column
                apiInstance.ImportationSaveCustomColumn(storeId, executionId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationSaveCustomColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ChangeCustomColumnRequest**](ChangeCustomColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationunmapcatalogcolumn"></a>
# **ImportationUnmapCatalogColumn**
> void ImportationUnmapCatalogColumn (string storeId, string executionId, string columnId)

Unmap catalog column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationUnmapCatalogColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The catalog column identifier

            try
            {
                // Unmap catalog column
                apiInstance.ImportationUnmapCatalogColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationUnmapCatalogColumn: " + e.Message );
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
 **columnId** | **string**| The catalog column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationunmapcustomcolumn"></a>
# **ImportationUnmapCustomColumn**
> void ImportationUnmapCustomColumn (string storeId, string executionId, string columnId)

Unmap custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationUnmapCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new ImportationCatalogInfoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var executionId = executionId_example;  // string | The execution identifier of you catalog importation
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Unmap custom column
                apiInstance.ImportationUnmapCustomColumn(storeId, executionId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportationCatalogInfoApi.ImportationUnmapCustomColumn: " + e.Message );
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
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

