# IO.Swagger.Model.ChannelCatalogMarketplaceProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Channel catalog marketplace property name | 
**Values** | **List&lt;string&gt;** | Channel catalog marketplace property values | [optional] 
**Info** | [**BeezUPCommonInfoSummaries**](BeezUPCommonInfoSummaries.md) |  | [optional] 
**_Default** | **List&lt;string&gt;** | Indicate the default values of the property | [optional] 
**Description** | **string** | Indicate the description of the property | [optional] 
**Position** | **int?** | Indicate the position of the property in the display group | 
**_ReadOnly** | **bool?** | Indicate if the value cannot be changed. This is used for example for ebay token that should not be changed. | [default to false]
**MinLength** | **int?** | Indicates the minimum size of the property value | [optional] [default to 0]
**MaxLength** | **int?** | Indicates the maximum size of the property value | [optional] 
**MinItems** | **int?** | Indicates the minimum item count of the property value. | [optional] [default to 1]
**MaxItems** | **int?** | Indicates the maximum item count of the property value | [optional] [default to 1]
**LovLink** | [**BeezUPCommonLOVLink3**](BeezUPCommonLOVLink3.md) |  | [optional] 
**LovRequired** | **bool?** | Indicates if the property value must be in the list of value. | [optional] [default to false]
**Required** | **bool?** | Indicate if the property is required or not | [default to false]
**OfferIdRequired** | **int?** | Indicates the offer identifier required to configure this property. | [optional] 
**Visible** | **bool?** | Indicates if this property should be displayed in the configuration page. | [default to true]
**Type** | [**Type**](Type.md) |  | [optional] 
**Pattern** | **string** | Channel catalog marketplace setting value format validation regular expression | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

