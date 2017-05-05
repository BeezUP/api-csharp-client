# IO.Swagger.Model.ContractCommitmentInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommitmentCalculatedFinishDate** | **DateTime?** | The commitment end date related to the offer | [optional] 
**NewContractStartDate** | **DateTime?** | The start date related to the offer | [optional] 
**CommitmentPeriodInMonth** | **int?** | The commitment period in month related to the offer | [optional] 
**TrialPeriodInMonth** | **int?** | The trial period in month related to the offer | [optional] 
**TrialPeriodFinishDate** | **DateTime?** | The trial period end date related to the offer | [optional] 
**PaymentDelayInDays** | **int?** | The payment delay in days related to the offer | [optional] 
**OfferId** | [**OfferId**](OfferId.md) |  | [optional] 
**OfferName** | **string** | The offer Name | [optional] 
**CurrentContractId** | **string** | Your current contract id | [optional] 
**CommercialUserId** | **string** | Your current commercial user id | [optional] 
**Model** | **string** | Interal usage: Old offer type. The model description | [optional] 
**CurrentContractTerminationDate** | **DateTime?** | The current contract termination date | [optional] 
**RequestedPaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**CurrentCustomerPaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**ContractType** | **int?** | Internal usage: Old offer type. Your contract type | [optional] 
**IsModelMustBeTransmittedInNewContract** | **bool?** | Internal usage: Old offer type. Is the current contract model needs to be converted into a new contract type | [optional] 
**FixedAndVariableClickInfo** | [**FixedAndVariableClickModelInfo**](FixedAndVariableClickModelInfo.md) |  | [optional] 
**VariableModelInfo** | [**VariableModelInfo**](VariableModelInfo.md) |  | [optional] 
**PaymentMethodAuthorized** | [**PaymentMethod**](PaymentMethod.md) |  | [optional] 
**CouponOfferCode** | [**CouponOfferCode**](CouponOfferCode.md) |  | [optional] 
**CommercialCreatorUserId** | **string** | The commercial that is responsible of the creation of your account | [optional] 
**MinBillingPeriodInMonths** | **int?** | The minimum billing period in month authorized for this offer. | [optional] 
**IsCustomerWantsToTerminateHisContract** | **bool?** | If true, this means you want to leave us and that&#39;s sad... :&#39;-( | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

