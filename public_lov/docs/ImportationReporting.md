# IO.Swagger.Model.ImportationReporting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StepName** | **string** | The last step name of the importation process | [optional] 
**UserId** | [**BeezUPCommonUserId**](BeezUPCommonUserId.md) |  | [optional] 
**Success** | **bool?** | Indicate if the importation succeed or not. | [optional] 
**TotalProductCount** | **int?** | Indicate the total product count detected in the catalog during the importation. | [optional] 
**TotalProductErrorCount** | **int?** | Indicate the total product count in error detected in the catalog during the importation. | [optional] 
**TotalProductSuccessCount** | **int?** | Indicate the total product count in success in the catalog during the importation. | [optional] 
**Errors** | [**List&lt;BeezUPCommonUserErrorMessage&gt;**](BeezUPCommonUserErrorMessage.md) | Indicate the error message list related to this importation. | [optional] 
**LastUpdateUtcDate** | **DateTime?** | Indicate the last update UTC date of the reporting. | 
**AutoImported** | **bool?** | Indicate if this importation is an auto import or not. | [optional] 
**BeginUtcDate** | **DateTime?** | Indicate the begin UTC date of this importation. | 
**EndUtcDate** | **DateTime?** | Indicate the end UTC date of this importation. | [optional] 
**InputConfigurationUrl** | **string** | Indicate the input url of this importation. | [optional] 
**Steps** | **Dictionary&lt;string, bool?&gt;** | Indicate the steps that have been passed during the importation process | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

