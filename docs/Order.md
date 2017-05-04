# IO.Swagger.Model.Order
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
**OrderLastModificationUtcDate** | **DateTime?** | The last modification UTC date done by BeezUP of this order | 
**OrderMarketplaceLastModificationUtcDate** | **DateTime?** | The last modification UTC date done by the marketplace on this order | 
**OrderBuyerName** | [**OrderBuyerName**](OrderBuyerName.md) |  | [optional] 
**OrderTotalPrice** | **decimal?** | The total price of this order (corresponding to the amount paid by the customer) | [optional] 
**OrderCurrencyCode** | [**BeezUPCommonCurrencyCode**](BeezUPCommonCurrencyCode.md) |  | [optional] 
**Processing** | [**Processing**](Processing.md) |  | 
**Etag** | [**Etag**](Etag.md) |  | 
**Links** | [**List&lt;BeezUPCommonLink2&gt;**](BeezUPCommonLink2.md) |  | 
**OrderMarketPlaceChannel** | **string** | Useful to identify the origin of the order. For example in Amazon. | [optional] 
**OrderTotalTax** | **decimal?** | The total tax of this order | [optional] 
**OrderTotalCommission** | **decimal?** | The total commission of this order | [optional] 
**OrderPaymentMethod** | **string** | The payment method of this order | [optional] 
**OrderPayingUtcDate** | **DateTime?** | The UTC date of the payment of this order | [optional] 
**OrderComment** | **string** | The comment associated to this order | [optional] 
**OrderShippingCivility** | **string** | The civility of the person in the shipping address for this order | [optional] 
**OrderShippingCompanyName** | **string** | The company name of the shipping address for this order | [optional] 
**OrderShippingAddressName** | **string** | The name of the person in the shipping address for this order | [optional] 
**OrderShippingEmail** | **string** | The email of the person in the shipping address for this order | [optional] 
**OrderShippingAddressLine1** | **string** | The shipping address line 1 of this order | [optional] 
**OrderShippingAddressLine2** | **string** | The shipping address line 2 of this order | [optional] 
**OrderShippingAddressLine3** | **string** | The shipping address line 3 of this order | [optional] 
**OrderShippingAddressPostalCode** | **string** | The shipping address postal code of this order | [optional] 
**OrderShippingAddressCity** | **string** | The shipping address city of this order | [optional] 
**OrderShippingAddressStateOrRegion** | **string** | The shipping address state or region of this order | [optional] 
**OrderShippingAddressCountryName** | **string** | The shipping address country name | [optional] 
**OrderShippingAddressCountryIsoCodeAlpha2** | **string** | The shipping address country iso code alpha 2 (see http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Decoding_table for more details) | [optional] 
**OrderShippingPhone** | **string** | The phone number of the person in the shipping address for this order | [optional] 
**OrderShippingMobilePhone** | **string** | The mobile phone number of the person in the shipping address for this order | [optional] 
**OrderShippingPrice** | **decimal?** | The shipping price of this order | [optional] 
**OrderShippingMethod** | **string** | The shipping method of this order | [optional] 
**OrderShippingShippingTax** | **decimal?** | The shipping tax for this order | [optional] 
**OrderShippingEarliestShipUtcDate** | **DateTime?** | The UTC date of the earliest ship for this order | [optional] 
**OrderShippingLatestShipUtcDate** | **DateTime?** | The UTC date of the latest ship for this order | [optional] 
**OrderBuyerIdentifier** | **string** | The buyer identifier for this order | [optional] 
**OrderBuyerCivility** | **string** | The buyer civility for this order | [optional] 
**OrderBuyerCompanyName** | **string** | The buyer company name for this order | [optional] 
**OrderBuyerEmail** | **string** | The email of the buyer for this order | [optional] 
**OrderBuyerAddressLine1** | **string** | The Buyer address line 1 of this order | [optional] 
**OrderBuyerAddressLine2** | **string** | The Buyer address line 2 of this order | [optional] 
**OrderBuyerAddressLine3** | **string** | The Buyer address line 3 of this order | [optional] 
**OrderBuyerAddressPostalCode** | **string** | The Buyer address postal code of this order | [optional] 
**OrderBuyerAddressCity** | **string** | The Buyer address city of this order | [optional] 
**OrderBuyerAddressStateOrRegion** | **string** | The Buyer address state or region of this order | [optional] 
**OrderBuyerAddressCountryName** | **string** | The Buyer address country name | [optional] 
**OrderBuyerAddressCountryIsoCodeAlpha2** | **string** | The Buyer address country iso code alpha 2 (see http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2#Decoding_table for more details) | [optional] 
**OrderBuyerPhone** | **string** | The phone number of the buyer for this order | [optional] 
**OrderBuyerMobilePhone** | **string** | The mobile phone number of the buyer for this order | [optional] 
**OrderOrderSourceUri** | **string** | Technical information: The url to the source of this order. We received this information from the marketplace.  | [optional] 
**OrderOrderItemsSourceUri** | **string** | Technical information: The url to the source of this order items. We received this information from the marketplace.  | [optional] 
**OrderItems** | [**List&lt;OrderItem&gt;**](OrderItem.md) |  | 
**TransitionLinks** | [**List&lt;BeezUPCommonLink2&gt;**](BeezUPCommonLink2.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

