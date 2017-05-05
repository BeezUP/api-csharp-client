# IO.Swagger.Api.CatalogApi

All URIs are relative to *https://api.beezup.com/v2/user/catalogs*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CatalogChangeCatalogColumnUserName**](CatalogApi.md#catalogchangecatalogcolumnusername) | **POST** /{storeId}/catalogColumns/{columnId}/rename | Change Catalog Column User Name
[**CatalogChangeCustomColumnExpression**](CatalogApi.md#catalogchangecustomcolumnexpression) | **PUT** /{storeId}/customColumns/{columnId}/expression | Change custom column expression
[**CatalogChangeCustomColumnUserName**](CatalogApi.md#catalogchangecustomcolumnusername) | **POST** /{storeId}/customColumns/{columnId}/rename | Change Custom Column User Name
[**CatalogComputeExpression**](CatalogApi.md#catalogcomputeexpression) | **POST** /{storeId}/customColumns/computeExpression | Compute the expression for this catalog.
[**CatalogDeleteCustomColumn**](CatalogApi.md#catalogdeletecustomcolumn) | **DELETE** /{storeId}/customColumns/{columnId} | Delete custom column
[**CatalogGetCatalogColumns**](CatalogApi.md#cataloggetcatalogcolumns) | **GET** /{storeId}/catalogColumns | Get catalog column list
[**CatalogGetCategories**](CatalogApi.md#cataloggetcategories) | **GET** /{storeId}/categories | Get category list
[**CatalogGetCustomColumnExpression**](CatalogApi.md#cataloggetcustomcolumnexpression) | **GET** /{storeId}/customColumns/{columnId}/expression | Get the encrypted custom column expression
[**CatalogGetCustomColumns**](CatalogApi.md#cataloggetcustomcolumns) | **GET** /{storeId}/customColumns | Get custom column list
[**CatalogGetProduct**](CatalogApi.md#cataloggetproduct) | **GET** /{storeId}/products/{productId} | Get product
[**CatalogGetProducts**](CatalogApi.md#cataloggetproducts) | **POST** /{storeId}/products | Get product list
[**CatalogGetRandomProducts**](CatalogApi.md#cataloggetrandomproducts) | **GET** /{storeId}/products/random | Get random product list
[**CatalogSaveCustomColumn**](CatalogApi.md#catalogsavecustomcolumn) | **PUT** /{storeId}/customColumns/{columnId} | Create or replace a custom column
[**ImportationGetManualUpdateLastInputConfig**](CatalogApi.md#importationgetmanualupdatelastinputconfig) | **GET** /{storeId}/inputConfiguration | Get the last input configuration


<a name="catalogchangecatalogcolumnusername"></a>
# **CatalogChangeCatalogColumnUserName**
> void CatalogChangeCatalogColumnUserName (string storeId, string columnId, ChangeUserColumnNameRequest request)

Change Catalog Column User Name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogChangeCatalogColumnUserNameExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The catalog column identifier
            var request = new ChangeUserColumnNameRequest(); // ChangeUserColumnNameRequest | 

            try
            {
                // Change Catalog Column User Name
                apiInstance.CatalogChangeCatalogColumnUserName(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogChangeCatalogColumnUserName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The catalog column identifier | 
 **request** | [**ChangeUserColumnNameRequest**](ChangeUserColumnNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogchangecustomcolumnexpression"></a>
# **CatalogChangeCustomColumnExpression**
> void CatalogChangeCustomColumnExpression (string storeId, string columnId, ChangeCustomColumnExpressionRequest request)

Change custom column expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogChangeCustomColumnExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ChangeCustomColumnExpressionRequest(); // ChangeCustomColumnExpressionRequest | 

            try
            {
                // Change custom column expression
                apiInstance.CatalogChangeCustomColumnExpression(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogChangeCustomColumnExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ChangeCustomColumnExpressionRequest**](ChangeCustomColumnExpressionRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogchangecustomcolumnusername"></a>
# **CatalogChangeCustomColumnUserName**
> void CatalogChangeCustomColumnUserName (string storeId, string columnId, ChangeUserColumnNameRequest request)

Change Custom Column User Name

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogChangeCustomColumnUserNameExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new ChangeUserColumnNameRequest(); // ChangeUserColumnNameRequest | 

            try
            {
                // Change Custom Column User Name
                apiInstance.CatalogChangeCustomColumnUserName(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogChangeCustomColumnUserName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**ChangeUserColumnNameRequest**](ChangeUserColumnNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogcomputeexpression"></a>
# **CatalogComputeExpression**
> string CatalogComputeExpression (string storeId, ComputeExpressionRequest request)

Compute the expression for this catalog.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogComputeExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ComputeExpressionRequest(); // ComputeExpressionRequest | 

            try
            {
                // Compute the expression for this catalog.
                string result = apiInstance.CatalogComputeExpression(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogComputeExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ComputeExpressionRequest**](ComputeExpressionRequest.md)|  | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogdeletecustomcolumn"></a>
# **CatalogDeleteCustomColumn**
> void CatalogDeleteCustomColumn (string storeId, string columnId)

Delete custom column

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogDeleteCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Delete custom column
                apiInstance.CatalogDeleteCustomColumn(storeId, columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogDeleteCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcatalogcolumns"></a>
# **CatalogGetCatalogColumns**
> CatalogColumns CatalogGetCatalogColumns (string storeId)

Get catalog column list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCatalogColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get catalog column list
                CatalogColumns result = apiInstance.CatalogGetCatalogColumns(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetCatalogColumns: " + e.Message );
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

[**CatalogColumns**](CatalogColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcategories"></a>
# **CatalogGetCategories**
> Categories CatalogGetCategories (string storeId, List<string> acceptEncoding)

Get category list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCategoriesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var acceptEncoding = new List<string>(); // List<string> | Indicates that the client accepts that the response will be compressed to reduce traffic size.

            try
            {
                // Get category list
                Categories result = apiInstance.CatalogGetCategories(storeId, acceptEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **acceptEncoding** | [**List&lt;string&gt;**](string.md)| Indicates that the client accepts that the response will be compressed to reduce traffic size. | 

### Return type

[**Categories**](Categories.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcustomcolumnexpression"></a>
# **CatalogGetCustomColumnExpression**
> string CatalogGetCustomColumnExpression (string storeId, string columnId)

Get the encrypted custom column expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCustomColumnExpressionExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier

            try
            {
                // Get the encrypted custom column expression
                string result = apiInstance.CatalogGetCustomColumnExpression(storeId, columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetCustomColumnExpression: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 

### Return type

**string**

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetcustomcolumns"></a>
# **CatalogGetCustomColumns**
> CustomColumns CatalogGetCustomColumns (string storeId)

Get custom column list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetCustomColumnsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get custom column list
                CustomColumns result = apiInstance.CatalogGetCustomColumns(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetCustomColumns: " + e.Message );
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

[**CustomColumns**](CustomColumns.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetproduct"></a>
# **CatalogGetProduct**
> Product CatalogGetProduct (string storeId, string productId)

Get product

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var productId = productId_example;  // string | The product identifier you want to get

            try
            {
                // Get product
                Product result = apiInstance.CatalogGetProduct(storeId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **productId** | **string**| The product identifier you want to get | 

### Return type

[**Product**](Product.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetproducts"></a>
# **CatalogGetProducts**
> Products CatalogGetProducts (string storeId, GetProductsRequest request = null)

Get product list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new GetProductsRequest(); // GetProductsRequest |  (optional) 

            try
            {
                // Get product list
                Products result = apiInstance.CatalogGetProducts(storeId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**GetProductsRequest**](GetProductsRequest.md)|  | [optional] 

### Return type

[**Products**](Products.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cataloggetrandomproducts"></a>
# **CatalogGetRandomProducts**
> Products CatalogGetRandomProducts (string storeId, int? count = null)

Get random product list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CatalogGetRandomProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var count = 25;  // int? | The count of random product you want to get (optional)  (default to 100)

            try
            {
                // Get random product list
                Products result = apiInstance.CatalogGetRandomProducts(storeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetRandomProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **count** | **int?**| The count of random product you want to get | [optional] [default to 100]

### Return type

[**Products**](Products.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="catalogsavecustomcolumn"></a>
# **CatalogSaveCustomColumn**
> void CatalogSaveCustomColumn (string storeId, string columnId, CreateCustomColumnRequest request)

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
    public class CatalogSaveCustomColumnExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier
            var columnId = columnId_example;  // string | The custom column identifier
            var request = new CreateCustomColumnRequest(); // CreateCustomColumnRequest | 

            try
            {
                // Create or replace a custom column
                apiInstance.CatalogSaveCustomColumn(storeId, columnId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogSaveCustomColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **columnId** | **string**| The custom column identifier | 
 **request** | [**CreateCustomColumnRequest**](CreateCustomColumnRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationgetmanualupdatelastinputconfig"></a>
# **ImportationGetManualUpdateLastInputConfig**
> LastManualImportInputConfiguration ImportationGetManualUpdateLastInputConfig (string storeId)

Get the last input configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationGetManualUpdateLastInputConfigExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get the last input configuration
                LastManualImportInputConfiguration result = apiInstance.ImportationGetManualUpdateLastInputConfig(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.ImportationGetManualUpdateLastInputConfig: " + e.Message );
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

[**LastManualImportInputConfiguration**](LastManualImportInputConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

