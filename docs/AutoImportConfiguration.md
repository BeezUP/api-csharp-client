# IO.Swagger.Model.AutoImportConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Input** | [**InputConfiguration**](InputConfiguration.md) |  | 
**InputConfiguredByUserId** | [**BeezUPCommonUserId**](BeezUPCommonUserId.md) |  | 
**SchedulingType** | [**SchedulingType**](SchedulingType.md) |  | 
**ScheduledByUserId** | [**BeezUPCommonUserId**](BeezUPCommonUserId.md) |  | [optional] 
**SchedulingValue** | **List&lt;string&gt;** | Indicate the scheduling value. If the scheduling type is Interval then the value will be a duration otherwise the values will be the time. | 
**Paused** | **bool?** | Indicate if the auto import is in pause or not. | [default to false]
**PauseStatusChangedByUserId** | [**BeezUPCommonUserId**](BeezUPCommonUserId.md) |  | [optional] 
**PauseStatusChangedUtcDate** | **DateTime?** | Indicate when the pause status has changed in UTC date. | [optional] 
**DuplicateProductConfiguration** | [**DuplicateProductValueConfiguration**](DuplicateProductValueConfiguration.md) |  | 
**SchedulingLocalTimeZoneName** | **string** | Indicate the time zone name of the scheduling. If the scheduling type is \&quot;Schedule\&quot; | [optional] [default to "Romance Standard Time"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

