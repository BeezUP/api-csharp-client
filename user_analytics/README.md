# IO.Swagger - the C# library for the Analytics

This API will help you to manage the tracking of your clicks and your sales, get reporting on this trackings and put in place rules based on this reporting to automatically optimize your channel catalogs. \\ Also, you will be able to consult the rule execution reporting. 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new OptimisationsApi();
            var storeId = storeId_example;  // string | Your store identifier
            var actionName = actionName_example;  // string | 
            var request = new OptimiseRequest(); // OptimiseRequest | 

            try
            {
                // Optimise products
                apiInstance.Optimise(storeId, actionName, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OptimisationsApi.Optimise: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.beezup.com/v2/user/analytics*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*OptimisationsApi* | [**Optimise**](docs/OptimisationsApi.md#optimise) | **POST** /{storeId}/optimisations/{actionName} | Optimise products
*OptimisationsApi* | [**OptimiseByCategory**](docs/OptimisationsApi.md#optimisebycategory) | **POST** /{storeId}/optimisations/bycategory/{catalogCategoryId}/{actionName} | Optimise products's category
*OptimisationsApi* | [**OptimiseByChannel**](docs/OptimisationsApi.md#optimisebychannel) | **POST** /{storeId}/optimisations/bychannel/{channelId}/{actionName} | Optimise products's category
*OptimisationsApi* | [**OptimiseByProduct**](docs/OptimisationsApi.md#optimisebyproduct) | **POST** /{storeId}/optimisations/byproduct/{productId}/{actionName} | Optimise products
*ReportsApi* | [**DeleteReportFilter**](docs/ReportsApi.md#deletereportfilter) | **DELETE** /{storeId}/reports/filters/{reportFilterId} | Delete the report filter
*ReportsApi* | [**ExportStoreReportByCategory**](docs/ReportsApi.md#exportstorereportbycategory) | **POST** /{storeId}/reports/bycategory/export | Export the report by category
*ReportsApi* | [**ExportStoreReportByChannel**](docs/ReportsApi.md#exportstorereportbychannel) | **POST** /{storeId}/reports/bychannel/export | Export the report by channel
*ReportsApi* | [**ExportStoreReportByProduct**](docs/ReportsApi.md#exportstorereportbyproduct) | **POST** /{storeId}/reports/byproduct/export | Export the report by product
*ReportsApi* | [**GetReportFilter**](docs/ReportsApi.md#getreportfilter) | **GET** /{storeId}/reports/filters/{reportFilterId} | Get the report filter description
*ReportsApi* | [**GetReportFilters**](docs/ReportsApi.md#getreportfilters) | **GET** /{storeId}/reports/filters | Get report filter list for the given store
*ReportsApi* | [**GetStoreReportByCategory**](docs/ReportsApi.md#getstorereportbycategory) | **POST** /{storeId}/reports/bycategory | Get the report by category
*ReportsApi* | [**GetStoreReportByChannel**](docs/ReportsApi.md#getstorereportbychannel) | **POST** /{storeId}/reports/bychannel | Get the report by channel
*ReportsApi* | [**GetStoreReportByDay**](docs/ReportsApi.md#getstorereportbyday) | **POST** /{storeId}/reports/byday | Get the report by day
*ReportsApi* | [**GetStoreReportByDayExport**](docs/ReportsApi.md#getstorereportbydayexport) | **POST** /{storeId}/reports/byday/export | Get the report by day
*ReportsApi* | [**GetStoreReportByProduct**](docs/ReportsApi.md#getstorereportbyproduct) | **POST** /{storeId}/reports/byproduct | Get the report by product
*ReportsApi* | [**SaveReportFilter**](docs/ReportsApi.md#savereportfilter) | **PUT** /{storeId}/reports/filters/{reportFilterId} | Save the report filter
*RulesApi* | [**CreateRule**](docs/RulesApi.md#createrule) | **POST** /{storeId}/rules | Rule creation
*RulesApi* | [**DeleteRule**](docs/RulesApi.md#deleterule) | **DELETE** /{storeId}/rules/{ruleId} | Delete Rule
*RulesApi* | [**DisableRule**](docs/RulesApi.md#disablerule) | **POST** /{storeId}/rules/{ruleId}/disable | Disable rule
*RulesApi* | [**EnableRule**](docs/RulesApi.md#enablerule) | **POST** /{storeId}/rules/{ruleId}/enable | Enable rule
*RulesApi* | [**GetRule**](docs/RulesApi.md#getrule) | **GET** /{storeId}/rules/{ruleId} | Gets the rule
*RulesApi* | [**GetRules**](docs/RulesApi.md#getrules) | **GET** /{storeId}/rules | Gets the list of rules for a given store
*RulesApi* | [**GetRulesExecutions**](docs/RulesApi.md#getrulesexecutions) | **GET** /{storeId}/rules/executions | Get the rules execution history
*RulesApi* | [**MoveDownRule**](docs/RulesApi.md#movedownrule) | **POST** /{storeId}/rules/{ruleId}/movedown | Move the rule down
*RulesApi* | [**MoveUpRule**](docs/RulesApi.md#moveuprule) | **POST** /{storeId}/rules/{ruleId}/moveup | Move the rule up
*RulesApi* | [**RunRule**](docs/RulesApi.md#runrule) | **POST** /{storeId}/rules/{ruleId}/run | Run rule
*RulesApi* | [**RunRules**](docs/RulesApi.md#runrules) | **POST** /{storeId}/rules/run | Run all rules for this store
*RulesApi* | [**UpdateRule**](docs/RulesApi.md#updaterule) | **PATCH** /{storeId}/rules/{ruleId} | Update Rule
*TrackingApi* | [**GetStoreTrackedClicks**](docs/TrackingApi.md#getstoretrackedclicks) | **GET** /{storeId}/tracking/clicks | Get the latest clicks tracked
*TrackingApi* | [**GetStoreTrackedExternalOrders**](docs/TrackingApi.md#getstoretrackedexternalorders) | **GET** /{storeId}/tracking/externalorders | Get the latest external orders tracked
*TrackingApi* | [**GetStoreTrackedOrders**](docs/TrackingApi.md#getstoretrackedorders) | **GET** /{storeId}/tracking/orders | Get the latest orders tracked
*TrackingApi* | [**GetStoreTrackingStatus**](docs/TrackingApi.md#getstoretrackingstatus) | **GET** /{storeId}/tracking/status | Get store tracking synchronization status
*TrackingApi* | [**GetTrackingStatus**](docs/TrackingApi.md#gettrackingstatus) | **GET** /tracking/status | Display the synchronization status of the clicks and orders


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BeezUPCommonCatalogCategoryId](docs/BeezUPCommonCatalogCategoryId.md)
 - [Model.BeezUPCommonCatalogCategoryPath](docs/BeezUPCommonCatalogCategoryPath.md)
 - [Model.BeezUPCommonCatalogColumnId](docs/BeezUPCommonCatalogColumnId.md)
 - [Model.BeezUPCommonChannelBasicInfo](docs/BeezUPCommonChannelBasicInfo.md)
 - [Model.BeezUPCommonChannelId](docs/BeezUPCommonChannelId.md)
 - [Model.BeezUPCommonChannelName](docs/BeezUPCommonChannelName.md)
 - [Model.BeezUPCommonCurrencyCode](docs/BeezUPCommonCurrencyCode.md)
 - [Model.BeezUPCommonDocUrl](docs/BeezUPCommonDocUrl.md)
 - [Model.BeezUPCommonErrorResponseMessage](docs/BeezUPCommonErrorResponseMessage.md)
 - [Model.BeezUPCommonErrorSummary](docs/BeezUPCommonErrorSummary.md)
 - [Model.BeezUPCommonExceptionDetail](docs/BeezUPCommonExceptionDetail.md)
 - [Model.BeezUPCommonHref](docs/BeezUPCommonHref.md)
 - [Model.BeezUPCommonHttpMethod](docs/BeezUPCommonHttpMethod.md)
 - [Model.BeezUPCommonHttpUrl](docs/BeezUPCommonHttpUrl.md)
 - [Model.BeezUPCommonInfoSummaries](docs/BeezUPCommonInfoSummaries.md)
 - [Model.BeezUPCommonInfoSummary](docs/BeezUPCommonInfoSummary.md)
 - [Model.BeezUPCommonLOVLink2](docs/BeezUPCommonLOVLink2.md)
 - [Model.BeezUPCommonLink3](docs/BeezUPCommonLink3.md)
 - [Model.BeezUPCommonLinkParameter3](docs/BeezUPCommonLinkParameter3.md)
 - [Model.BeezUPCommonOperationId](docs/BeezUPCommonOperationId.md)
 - [Model.BeezUPCommonPaginationResult](docs/BeezUPCommonPaginationResult.md)
 - [Model.BeezUPCommonPaginationResultLinks](docs/BeezUPCommonPaginationResultLinks.md)
 - [Model.BeezUPCommonProductBasicInfo](docs/BeezUPCommonProductBasicInfo.md)
 - [Model.BeezUPCommonProductId](docs/BeezUPCommonProductId.md)
 - [Model.BeezUPCommonSuccessSummary](docs/BeezUPCommonSuccessSummary.md)
 - [Model.BeezUPCommonUserErrorMessage](docs/BeezUPCommonUserErrorMessage.md)
 - [Model.BeezUPCommonUserErrorMessageArguments](docs/BeezUPCommonUserErrorMessageArguments.md)
 - [Model.BeezUPCommonWarningSummary](docs/BeezUPCommonWarningSummary.md)
 - [Model.CreateRuleRequest](docs/CreateRuleRequest.md)
 - [Model.GlobalPerformanceIndicatorByChannel](docs/GlobalPerformanceIndicatorByChannel.md)
 - [Model.LinkClickToOrderType](docs/LinkClickToOrderType.md)
 - [Model.LinksCreateRuleLink](docs/LinksCreateRuleLink.md)
 - [Model.LinksDeleteReportFilterLink](docs/LinksDeleteReportFilterLink.md)
 - [Model.LinksDeleteRuleLink](docs/LinksDeleteRuleLink.md)
 - [Model.LinksDisableRuleLink](docs/LinksDisableRuleLink.md)
 - [Model.LinksEnableRuleLink](docs/LinksEnableRuleLink.md)
 - [Model.LinksGetChannelCatalogProductInfoLink](docs/LinksGetChannelCatalogProductInfoLink.md)
 - [Model.LinksGetReportFilterLink](docs/LinksGetReportFilterLink.md)
 - [Model.LinksGetReportFiltersLink](docs/LinksGetReportFiltersLink.md)
 - [Model.LinksGetRuleLink](docs/LinksGetRuleLink.md)
 - [Model.LinksGetRulesExecutionsLink](docs/LinksGetRulesExecutionsLink.md)
 - [Model.LinksGetRulesLink](docs/LinksGetRulesLink.md)
 - [Model.LinksMoveDownRuleLink](docs/LinksMoveDownRuleLink.md)
 - [Model.LinksMoveUpRuleLink](docs/LinksMoveUpRuleLink.md)
 - [Model.LinksOptimiseByCategoryLink](docs/LinksOptimiseByCategoryLink.md)
 - [Model.LinksOptimiseByChannelLink](docs/LinksOptimiseByChannelLink.md)
 - [Model.LinksOptimiseByProductLink](docs/LinksOptimiseByProductLink.md)
 - [Model.LinksOptimiseLink](docs/LinksOptimiseLink.md)
 - [Model.LinksRunRuleLink](docs/LinksRunRuleLink.md)
 - [Model.LinksRunRulesLink](docs/LinksRunRulesLink.md)
 - [Model.LinksSaveReportFilterLink](docs/LinksSaveReportFilterLink.md)
 - [Model.LinksUpdateRuleLink](docs/LinksUpdateRuleLink.md)
 - [Model.MargingType](docs/MargingType.md)
 - [Model.OptimisationActionName](docs/OptimisationActionName.md)
 - [Model.OptimiseRequest](docs/OptimiseRequest.md)
 - [Model.PageNumber](docs/PageNumber.md)
 - [Model.PageSize](docs/PageSize.md)
 - [Model.PaginationRequestParameters](docs/PaginationRequestParameters.md)
 - [Model.PerformanceIndicatorFormula](docs/PerformanceIndicatorFormula.md)
 - [Model.PerformanceIndicatorFormulaOperatorName](docs/PerformanceIndicatorFormulaOperatorName.md)
 - [Model.PerformanceIndicatorFormulaParameterType](docs/PerformanceIndicatorFormulaParameterType.md)
 - [Model.PerformanceIndicatorType](docs/PerformanceIndicatorType.md)
 - [Model.ProductFilters](docs/ProductFilters.md)
 - [Model.ProductStateFilter](docs/ProductStateFilter.md)
 - [Model.ReportAdvancedFilters](docs/ReportAdvancedFilters.md)
 - [Model.ReportByCategory](docs/ReportByCategory.md)
 - [Model.ReportByCategoryLinks](docs/ReportByCategoryLinks.md)
 - [Model.ReportByCategoryRequest](docs/ReportByCategoryRequest.md)
 - [Model.ReportByCategoryResponse](docs/ReportByCategoryResponse.md)
 - [Model.ReportByCategoryResponseLinks](docs/ReportByCategoryResponseLinks.md)
 - [Model.ReportByChannel](docs/ReportByChannel.md)
 - [Model.ReportByChannelLinks](docs/ReportByChannelLinks.md)
 - [Model.ReportByChannelRequest](docs/ReportByChannelRequest.md)
 - [Model.ReportByChannelResponse](docs/ReportByChannelResponse.md)
 - [Model.ReportByChannelResponseLinks](docs/ReportByChannelResponseLinks.md)
 - [Model.ReportByCommonResponseLinks](docs/ReportByCommonResponseLinks.md)
 - [Model.ReportByDay](docs/ReportByDay.md)
 - [Model.ReportByDayAllChannels](docs/ReportByDayAllChannels.md)
 - [Model.ReportByDayByChannel](docs/ReportByDayByChannel.md)
 - [Model.ReportByDayRequest](docs/ReportByDayRequest.md)
 - [Model.ReportByDayResponse](docs/ReportByDayResponse.md)
 - [Model.ReportByProduct](docs/ReportByProduct.md)
 - [Model.ReportByProductLinks](docs/ReportByProductLinks.md)
 - [Model.ReportByProductRequest](docs/ReportByProductRequest.md)
 - [Model.ReportByProductResponse](docs/ReportByProductResponse.md)
 - [Model.ReportByProductResponseLinks](docs/ReportByProductResponseLinks.md)
 - [Model.ReportCategoryFilter](docs/ReportCategoryFilter.md)
 - [Model.ReportFilter](docs/ReportFilter.md)
 - [Model.ReportFilterCommonParameters](docs/ReportFilterCommonParameters.md)
 - [Model.ReportFilterHeader](docs/ReportFilterHeader.md)
 - [Model.ReportFilterHeaderLinks](docs/ReportFilterHeaderLinks.md)
 - [Model.ReportFilterLinks](docs/ReportFilterLinks.md)
 - [Model.ReportFilterParameters](docs/ReportFilterParameters.md)
 - [Model.ReportFilters](docs/ReportFilters.md)
 - [Model.ReportFiltersLinks](docs/ReportFiltersLinks.md)
 - [Model.ReportIndicatorFilter](docs/ReportIndicatorFilter.md)
 - [Model.ReportIndicatorFilterOperatorName](docs/ReportIndicatorFilterOperatorName.md)
 - [Model.ReportProductFilter](docs/ReportProductFilter.md)
 - [Model.ReportProductFilterOperatorName](docs/ReportProductFilterOperatorName.md)
 - [Model.ReportType](docs/ReportType.md)
 - [Model.Rule](docs/Rule.md)
 - [Model.RuleExecutionReporting](docs/RuleExecutionReporting.md)
 - [Model.RuleExecutionReportingErrorType](docs/RuleExecutionReportingErrorType.md)
 - [Model.RuleExecutionReportingExecutionSource](docs/RuleExecutionReportingExecutionSource.md)
 - [Model.RuleExecutionReportingLinks](docs/RuleExecutionReportingLinks.md)
 - [Model.RuleExecutionReportingStatus](docs/RuleExecutionReportingStatus.md)
 - [Model.RuleExecutionReportings](docs/RuleExecutionReportings.md)
 - [Model.RuleLastExecutionStatus](docs/RuleLastExecutionStatus.md)
 - [Model.RuleLinks](docs/RuleLinks.md)
 - [Model.RuleList](docs/RuleList.md)
 - [Model.RuleListLinks](docs/RuleListLinks.md)
 - [Model.SaveReportFilterRequest](docs/SaveReportFilterRequest.md)
 - [Model.StoreTrackingStatus](docs/StoreTrackingStatus.md)
 - [Model.TrackedClick](docs/TrackedClick.md)
 - [Model.TrackedClicks](docs/TrackedClicks.md)
 - [Model.TrackedExternalOrder](docs/TrackedExternalOrder.md)
 - [Model.TrackedExternalOrderProduct](docs/TrackedExternalOrderProduct.md)
 - [Model.TrackedExternalOrders](docs/TrackedExternalOrders.md)
 - [Model.TrackedOrder](docs/TrackedOrder.md)
 - [Model.TrackedOrderProduct](docs/TrackedOrderProduct.md)
 - [Model.TrackedOrders](docs/TrackedOrders.md)
 - [Model.TrackingStatus](docs/TrackingStatus.md)
 - [Model.UpdateRuleRequest](docs/UpdateRuleRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: Ocp-Apim-Subscription-Key
- **Location**: HTTP header
