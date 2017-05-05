# IO.Swagger.Model.ChannelCatalogProductInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **string** | The product identifier | 
**ProductSku** | **string** | The product SKU | 
**ProductTitle** | **string** | The product tile | 
**ProductImageUrl** | **string** | The product image Url | 
**ProductActive** | **bool?** | Indicates if the product still exists in your catalog | 
**Overrides** | [**ProductOverrides**](ProductOverrides.md) |  | 
**Disabled** | **bool?** | Indicates if the product has been disabled or not | [default to false]
**CategoryMapped** | **bool?** | Indicates if the product&#39;s category has been mapped to a channel category | 
**Excluded** | **bool?** | Indicates if the product has been excluded by a exclusion filter | [default to false]
**ExcludedBy** | [**List&lt;ExclusionFilterName&gt;**](ExclusionFilterName.md) |  | [optional] 
**Links** | [**ChannelCatalogProductInfoLinks**](ChannelCatalogProductInfoLinks.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

