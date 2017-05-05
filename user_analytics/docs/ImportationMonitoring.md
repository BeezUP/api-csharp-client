# IO.Swagger.Model.ImportationMonitoring
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | [**BeezUPCommonUserId**](BeezUPCommonUserId.md) |  | [optional] 
**Success** | **bool?** | Indicates if the importation was successfully completed or not | 
**ExecutionId** | [**ExecutionId**](ExecutionId.md) |  | 
**LastUpdateUtcDate** | **DateTime?** | The last update of the reporting | 
**BeginUtcDate** | **DateTime?** | The start date of the importation | 
**Errors** | [**List&lt;BeezUPCommonUserErrorMessage&gt;**](BeezUPCommonUserErrorMessage.md) | In case of error a description will be indicated | [optional] 
**Steps** | **Dictionary&lt;string, bool?&gt;** | Contains all steps of the importation process with a boolean. If true the step has been passed, false the step is not complete | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

