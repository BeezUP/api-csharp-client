# IO.Swagger.Model.TrackedExternalOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UtcDate** | **DateTime?** | The utc date of the external order. | 
**MerchantOrderId** | **string** | The merchant order identifier | 
**VisitorId** | **string** | Can be null. The visitor identifier related to this external order | [optional] 
**TotalAmount** | **decimal?** | The total amount related to the external order. | 
**CurrencyCode** | [**BeezUPCommonCurrencyCode**](BeezUPCommonCurrencyCode.md) |  | 
**PaymentValidated** | **bool?** | Indicate if the payment of this external order has been validated or not. | 
**Products** | [**List&lt;TrackedExternalOrderProduct&gt;**](TrackedExternalOrderProduct.md) | Can be null. the product list related to this external order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

