# IO.Swagger.Model.InputFileFetchConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Indicate the Uri of the file. (http, https, ftp, ftps, sftp are allowed) | 
**Credential** | [**Credential**](Credential.md) |  | [optional] 
**DownloadCatalogStrategy** | [**DownloadCatalogStrategy**](DownloadCatalogStrategy.md) |  | 
**CompressionFormatStrategy** | [**CompressionFormatStrategy**](CompressionFormatStrategy.md) |  | [optional] 
**CompressedRelativePath** | **string** | Indicate the relative path in the compressed file | [optional] 
**DownloadTimeout** | **int?** | Indicate the download time out in second | [optional] [default to 30]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

