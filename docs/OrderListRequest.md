# IO.Swagger.Model.OrderListRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceTechnicalCodes** | [**List&lt;BeezUPCommonMarketplaceTechnicalCode&gt;**](BeezUPCommonMarketplaceTechnicalCode.md) |  | [optional] 
**MarketplaceBusinessCodes** | [**List&lt;BeezUPCommonMarketplaceBusinessCode&gt;**](BeezUPCommonMarketplaceBusinessCode.md) |  | [optional] 
**AccountIds** | [**List&lt;AccountId&gt;**](AccountId.md) | Account id list | [optional] 
**BeezUPOrderStatuses** | [**List&lt;BeezUPOrderStatus&gt;**](BeezUPOrderStatus.md) |  | [optional] 
**DateSearchType** | [**DateSearchType**](DateSearchType.md) |  | 
**BeginPeriodUtcDate** | **DateTime?** | The begin period you want to make the search. \\ The period MUST not be greater than 30 days. The begin period MUST be lower than the end period.   | 
**EndPeriodUtcDate** | **DateTime?** | The end period of you search. \\ The period MUST not be greater than 30 days. \\ The end period MUST be greater than the begin period.  The end period MUST be lower to the current date.  | 
**OrderBuyerName** | [**OrderBuyerName**](OrderBuyerName.md) |  | [optional] 
**MarketplaceOrderIds** | [**List&lt;MarketplaceOrderId&gt;**](MarketplaceOrderId.md) |  | [optional] 
**OrderMerchantOrderIds** | [**List&lt;OrderMerchantOrderId&gt;**](OrderMerchantOrderId.md) | Merchant order id list | [optional] 
**PageSize** | [**PageSize**](PageSize.md) |  | 
**PageNumber** | [**PageNumber**](PageNumber.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

