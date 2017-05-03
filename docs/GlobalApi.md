# IO.Swagger.Api.GlobalApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CatalogGetBeezUPColumns**](GlobalApi.md#cataloggetbeezupcolumns) | **GET** /v2/user/catalogs/beezupColumns | Get the BeezUP columns
[**GetMarketplaceAccountsSynchronization**](GlobalApi.md#getmarketplaceaccountssynchronization) | **GET** /v2/user/marketplaces/orders/status | Get marketplace accounts synchronization status
[**HarvestAll**](GlobalApi.md#harvestall) | **POST** /v2/user/marketplaces/orders/harvest | Harvest orders from all marketplaces


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

<a name="getmarketplaceaccountssynchronization"></a>
# **GetMarketplaceAccountsSynchronization**
> AccountSynchronizations GetMarketplaceAccountsSynchronization ()

Get marketplace accounts synchronization status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMarketplaceAccountsSynchronizationExample
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
                // Get marketplace accounts synchronization status
                AccountSynchronizations result = apiInstance.GetMarketplaceAccountsSynchronization();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalApi.GetMarketplaceAccountsSynchronization: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountSynchronizations**](AccountSynchronizations.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="harvestall"></a>
# **HarvestAll**
> void HarvestAll ()

Harvest orders from all marketplaces

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HarvestAllExample
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
                // Harvest orders from all marketplaces
                apiInstance.HarvestAll();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GlobalApi.HarvestAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

