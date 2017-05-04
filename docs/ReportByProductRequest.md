# IO.Swagger.Model.ReportByProductRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelId** | [**BeezUPCommonChannelId**](BeezUPCommonChannelId.md) |  | [optional] 
**BeginPeriodUtcDate** | **DateTime?** | The begin date period you want to get the report | 
**EndPeriodUtcDate** | **DateTime?** | The end date period you want to get the report. | 
**CategoryFilter** | [**ReportCategoryFilter**](ReportCategoryFilter.md) |  | [optional] 
**IndicatorFilters** | [**List&lt;ReportIndicatorFilter&gt;**](ReportIndicatorFilter.md) |  | [optional] 
**AdvancedFilters** | [**ReportAdvancedFilters**](ReportAdvancedFilters.md) |  | 
**PageSize** | [**PageSize**](PageSize.md) |  | [optional] 
**PageNumber** | [**PageNumber**](PageNumber.md) |  | [optional] 
**ProductColumnsToDisplay** | [**List&lt;BeezUPCommonCatalogColumnId&gt;**](BeezUPCommonCatalogColumnId.md) |  | [optional] 
**ProductState** | [**ProductStateFilter**](ProductStateFilter.md) |  | 
**ProductFilters** | [**ProductFilters**](ProductFilters.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

