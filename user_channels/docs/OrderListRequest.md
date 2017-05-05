# IO.Swagger.Model.OrderListRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceTechnicalCodes** | [**List&lt;MarketplaceTechnicalCode&gt;**](MarketplaceTechnicalCode.md) |  | [optional] 
**MarketplaceBusinessCodes** | [**List&lt;MarketplaceBusinessCode&gt;**](MarketplaceBusinessCode.md) |  | [optional] 
**AccountIds** | [**List&lt;AccountId&gt;**](AccountId.md) | Account id list | [optional] 
**BeezUPOrderStatuses** | [**List&lt;BeezUPOrderStatus&gt;**](BeezUPOrderStatus.md) |  | [optional] 
**DateSearchType** | [**DateSearchType**](DateSearchType.md) |  | [optional] 
**BeginPeriodUtcDate** | **DateTime?** | The begin period you want to make the search. The period MUST not be greater than 30 days. If null, the current date minus 30 days will be used. | [optional] 
**EndPeriodUtcDate** | **DateTime?** | The end period of you search. The period MUST not be greater than 30 days. If null the current date will be used. | [optional] 
**OrderBuyerName** | [**OrderBuyerName**](OrderBuyerName.md) |  | [optional] 
**MarketplaceOrderIds** | [**List&lt;MarketplaceOrderId&gt;**](MarketplaceOrderId.md) |  | [optional] 
**OrderMerchantOrderIds** | [**List&lt;OrderMerchantOrderId&gt;**](OrderMerchantOrderId.md) | Merchant order id list | [optional] 
**PageSize** | [**PageSize**](PageSize.md) |  | [optional] 
**PageNumber** | [**PageNumber**](PageNumber.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

