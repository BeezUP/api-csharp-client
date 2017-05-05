# IO.Swagger.Model.TrackedOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UtcDate** | **DateTime?** | The utc date of the order. | 
**Channel** | [**BeezUPCommonChannelBasicInfo**](BeezUPCommonChannelBasicInfo.md) |  | 
**MerchantOrderId** | **string** | The merchant order identifier | 
**TotalAmount** | **decimal?** | The total amount related to the order. | 
**CurrencyCode** | [**BeezUPCommonCurrencyCode**](BeezUPCommonCurrencyCode.md) |  | 
**PaymentValidated** | **bool?** | Indicate if the payment of this order has been validated or not. | 
**Products** | [**List&lt;TrackedOrderProduct&gt;**](TrackedOrderProduct.md) | the product list related to this order. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

