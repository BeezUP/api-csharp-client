# IO.Swagger.Model.RuleExecutionReporting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The rule identifier | 
**RuleName** | **string** | The name of the rule | 
**StartedUtcDate** | **DateTime?** | The start utc date of the execution of the rule | [optional] 
**CompletedUtcDate** | **DateTime?** | The completed utc date of the execution of the rule | [optional] 
**Status** | [**RuleExecutionReportingStatus**](RuleExecutionReportingStatus.md) |  | 
**ErrorType** | [**RuleExecutionReportingErrorType**](RuleExecutionReportingErrorType.md) |  | [optional] 
**AffectedProductCount** | **int?** | The count of affected products, active or not | [optional] 
**ActiveAffectedProductCount** | **int?** | The count of affected active products | [optional] 
**AffectedChannelCount** | **int?** | The count of affected Channels across all products | [optional] 
**OptimisationActionName** | [**OptimisationActionName**](OptimisationActionName.md) |  | [optional] 
**UserId** | **string** | The userId that executed the rule if any | [optional] 
**ExecutionSource** | [**RuleExecutionReportingExecutionSource**](RuleExecutionReportingExecutionSource.md) |  | 
**ReportUrl** | **string** | The url for the excel report for this execution | [optional] 
**Links** | [**DefinitionsruleExecutionReportingLinks**](DefinitionsruleExecutionReportingLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

