# IO.Swagger.Model.PublicationFeedReporting
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeedType** | [**FeedType**](FeedType.md) |  | 
**StartUtcDate** | **DateTime?** | The feed publication start time (UTC timezone) | 
**EndUtcDate** | **DateTime?** | The feed publication end time (UTC timezone) | [optional] 
**ProcessingStatus** | **string** | The processing status | 
**ExportedProducts** | **int?** | The product count downloaded from BeezUP Export | [optional] 
**TransmittedItems** | **int?** | The item count (products or offers) sent to the marketplace | [optional] 
**PublishedItems** | **int?** | The item count (products or offers) the marketplace flagged as successful | [optional] 
**PublishedItemsWithWarning** | **int?** | The item count (products or offers) the marketplace flagged as successful with warnings | [optional] 
**FailedItems** | **int?** | The item count (products or offers) the marketplace flagged as failed | [optional] 
**ErrorMessage** | **string** | The error message | [optional] 
**HtmlReportUrl** | **string** | The Url for the Html Report generated | [optional] 
**HtmlReportGenerationErrorMessage** | **string** | The error message if the Html Report generation failed | [optional] 
**Completed** | **bool?** | Indicates if the publication is completed or not | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

