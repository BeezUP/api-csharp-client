# IO.Swagger.Model.InputFileReadConfiguration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | [**FileFormatStrategy**](FileFormatStrategy.md) |  | 
**EncodingTypeName** | **string** | The encoding type. UTF-8 by default. | [optional] [default to "UTF-8"]
**CultureName** | **string** | The culture name of the file.  (i.e. fr-FR). If null then Invariant culture will be used. | [optional] [default to ""]
**CsvFileReadProperties** | [**InputFileReadCsvConfiguration**](InputFileReadCsvConfiguration.md) |  | [optional] 
**XmlFileReadProperties** | [**InputFileReadXmlConfiguration**](InputFileReadXmlConfiguration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

