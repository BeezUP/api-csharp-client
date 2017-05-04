# IO.Swagger.Model.Rule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The identifier of the rule | 
**RuleName** | **string** | The name of the rule | 
**LastExecutionStatus** | [**RuleLastExecutionStatus**](RuleLastExecutionStatus.md) |  | [optional] 
**LastExecutionUtcDate** | **DateTime?** | The utc date of the last execution | [optional] 
**ActionName** | [**OptimisationActionName**](OptimisationActionName.md) |  | 
**ReportFilterId** | **string** | Report filter identifier linked to the rule | 
**Position** | **int?** | Rule execution position | 
**Enabled** | **bool?** | Is the rule enabled | 
**ValidityStartUtcDate** | **DateTime?** | Rule validity start utc date | [optional] 
**ValidityEndUtcDate** | **DateTime?** | Rule validity end utc date | [optional] 
**Links** | [**DefinitionsruleLinks**](DefinitionsruleLinks.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

