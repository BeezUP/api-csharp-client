# IO.Swagger.Model.OrderHeader
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketplaceTechnicalCode** | [**MarketplaceTechnicalCode**](MarketplaceTechnicalCode.md) |  | 
**AccountId** | [**AccountId**](AccountId.md) |  | 
**BeezUPOrderId** | [**BeezUPOrderId**](BeezUPOrderId.md) |  | 
**BeezUPOrderUrl** | [**BeezUPCommonHttpUrl**](BeezUPCommonHttpUrl.md) |  | [optional] 
**MarketplaceBusinessCode** | [**MarketplaceBusinessCode**](MarketplaceBusinessCode.md) |  | 
**OrderMarketplaceOrderId** | [**MarketplaceOrderId**](MarketplaceOrderId.md) |  | 
**OrderStatusBeezUPOrderStatus** | [**BeezUPOrderStatus**](BeezUPOrderStatus.md) |  | 
**OrderStatusMarketplaceOrderStatus** | [**MarketplaceOrderStatus**](MarketplaceOrderStatus.md) |  | [optional] 
**OrderMerchantOrderId** | [**OrderMerchantOrderId**](OrderMerchantOrderId.md) |  | [optional] 
**OrderMerchantECommerceSoftwareName** | [**OrderMerchantECommerceSoftwareName**](OrderMerchantECommerceSoftwareName.md) |  | [optional] 
**OrderMerchantECommerceSoftwareVersion** | [**OrderMerchantECommerceSoftwareVersion**](OrderMerchantECommerceSoftwareVersion.md) |  | [optional] 
**OrderPurchaseUtcDate** | **DateTime?** | The purchase date of this order | 
**OrderLastModificationUtcDate** | **DateTime?** | The last modification UTC date done by BeezUP of this order. | 
**OrderMarketplaceLastModificationUtcDate** | **DateTime?** | The last modification UTC date done by the marketplace on this order. | 
**OrderBuyerName** | [**OrderBuyerName**](OrderBuyerName.md) |  | [optional] 
**OrderTotalPrice** | **decimal?** | The total price of this order (corresponding to the amount paid by the customer) | [optional] 
**OrderCurrencyCode** | [**BeezUPCommonCurrencyCode**](BeezUPCommonCurrencyCode.md) |  | [optional] 
**Processing** | [**Processing**](Processing.md) |  | 
**ETag** | **string** | ETag value to identify the order. For more details go to this link: http://tools.ietf.org/html/rfc7232#section-2.3  | 
**Links** | [**List&lt;BeezUPCommonLink2&gt;**](BeezUPCommonLink2.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
