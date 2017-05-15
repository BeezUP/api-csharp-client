# IO.Swagger.Api.CatalogsAutoApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AutoConfigureAutoImportInterval**](CatalogsAutoApi.md#autoconfigureautoimportinterval) | **POST** /user/catalogs/{storeId}/autoImport/scheduling/interval | Configure Auto Import Interval
[**AutoDeleteAutoImport**](CatalogsAutoApi.md#autodeleteautoimport) | **DELETE** /user/catalogs/{storeId}/autoImport | Delete Auto Import
[**AutoGetAutoImportConfiguration**](CatalogsAutoApi.md#autogetautoimportconfiguration) | **GET** /user/catalogs/{storeId}/autoImport | Get the auto import configuration
[**AutoPauseAutoImport**](CatalogsAutoApi.md#autopauseautoimport) | **POST** /user/catalogs/{storeId}/autoImport/pause | Pause Auto Import
[**AutoResumeAutoImport**](CatalogsAutoApi.md#autoresumeautoimport) | **POST** /user/catalogs/{storeId}/autoImport/resume | Resume Auto Import
[**AutoScheduleAutoImport**](CatalogsAutoApi.md#autoscheduleautoimport) | **POST** /user/catalogs/{storeId}/autoImport/scheduling/schedules | Configure Auto Import Schedules
[**AutoStartAutoImport**](CatalogsAutoApi.md#autostartautoimport) | **POST** /user/catalogs/{storeId}/autoImport/start | Start Auto Import Manually
[**ImportationActivateAutoImport**](CatalogsAutoApi.md#importationactivateautoimport) | **POST** /user/catalogs/{storeId}/autoImport | Activate the auto importation of the last successful manual catalog importation.


<a name="autoconfigureautoimportinterval"></a>
# **AutoConfigureAutoImportInterval**
> void AutoConfigureAutoImportInterval (string storeId, ConfigureAutoImportIntervalRequest request)

Configure Auto Import Interval

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoConfigureAutoImportIntervalExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ConfigureAutoImportIntervalRequest(); // ConfigureAutoImportIntervalRequest | 

            try
            {
                // Configure Auto Import Interval
                apiInstance.AutoConfigureAutoImportInterval(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoConfigureAutoImportInterval: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ConfigureAutoImportIntervalRequest**](ConfigureAutoImportIntervalRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autodeleteautoimport"></a>
# **AutoDeleteAutoImport**
> void AutoDeleteAutoImport (string storeId)

Delete Auto Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoDeleteAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Delete Auto Import
                apiInstance.AutoDeleteAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoDeleteAutoImport: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autogetautoimportconfiguration"></a>
# **AutoGetAutoImportConfiguration**
> AutoImportConfiguration AutoGetAutoImportConfiguration (string storeId)

Get the auto import configuration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoGetAutoImportConfigurationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get the auto import configuration
                AutoImportConfiguration result = apiInstance.AutoGetAutoImportConfiguration(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoGetAutoImportConfiguration: " + e.Message );
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

[**AutoImportConfiguration**](AutoImportConfiguration.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autopauseautoimport"></a>
# **AutoPauseAutoImport**
> void AutoPauseAutoImport (string storeId)

Pause Auto Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoPauseAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Pause Auto Import
                apiInstance.AutoPauseAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoPauseAutoImport: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoresumeautoimport"></a>
# **AutoResumeAutoImport**
> void AutoResumeAutoImport (string storeId)

Resume Auto Import

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoResumeAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Resume Auto Import
                apiInstance.AutoResumeAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoResumeAutoImport: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autoscheduleautoimport"></a>
# **AutoScheduleAutoImport**
> void AutoScheduleAutoImport (string storeId, ScheduleAutoImportRequest request)

Configure Auto Import Schedules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoScheduleAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new ScheduleAutoImportRequest(); // ScheduleAutoImportRequest | 

            try
            {
                // Configure Auto Import Schedules
                apiInstance.AutoScheduleAutoImport(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoScheduleAutoImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**ScheduleAutoImportRequest**](ScheduleAutoImportRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="autostartautoimport"></a>
# **AutoStartAutoImport**
> LinksImportationGetImportationMonitoringLink AutoStartAutoImport (string storeId)

Start Auto Import Manually

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AutoStartAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Start Auto Import Manually
                LinksImportationGetImportationMonitoringLink result = apiInstance.AutoStartAutoImport(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.AutoStartAutoImport: " + e.Message );
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

[**LinksImportationGetImportationMonitoringLink**](LinksImportationGetImportationMonitoringLink.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importationactivateautoimport"></a>
# **ImportationActivateAutoImport**
> void ImportationActivateAutoImport (string storeId)

Activate the auto importation of the last successful manual catalog importation.

Once you have made your fist manual catalog importation with success, you can call this operation to import it automatically. No parameter required, we know which one it is.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ImportationActivateAutoImportExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CatalogsAutoApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Activate the auto importation of the last successful manual catalog importation.
                apiInstance.ImportationActivateAutoImport(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogsAutoApi.ImportationActivateAutoImport: " + e.Message );
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

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

