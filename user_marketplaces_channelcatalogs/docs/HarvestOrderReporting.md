# IO.Swagger.Model.HarvestOrderReporting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionUUID** | [**ExecutionUUID**](ExecutionUUID.md) |  | [optional] 
**CreationUtcDate** | **DateTime?** | The creation UTC date of the execution | [optional] 
**ProcessingStatus** | **string** | The processing status of the execution | [optional] 
**LastUpdateUtcDate** | **DateTime?** | The last update UTC date of the execution | [optional] 
**ErrorMessage** | **string** | The warning message during the execution | [optional] 
**WarningMessage** | **string** | The warning message during the execution | [optional] 
**BeezUPStatus** | [**BeezUPOrderStatus**](BeezUPOrderStatus.md) |  | [optional] 
**MarketplaceStatus** | **string** | The order marketplace status | [optional] 
**BeezUPForcedStatus** | **string** | The marketplace order status forced by BeezUP during the order change oepration. This could happend when there is no status on the marketplace side. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

