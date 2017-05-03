# IO.Swagger.Model.TrackedExternalOrderProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductSku** | **string** | The product sku received related to the external order. | 
**ProductTitle** | **string** | We tried to get the catalog product title based on the product SKU. This property can be null, if we cannot found the product. This is possible if the product is not referenced in the imported catalog. | [optional] 
**ProductImageUrl** | **string** | We tried to get the catalog product image Url based on the product SKU. This property can be null, if we cannot found the product. This is possible if the product is not referenced in the imported catalog. | [optional] 
**ProductActive** | **bool?** | We tried to get the catalog product if it&#39;s still active based on the product SKU. This property can be null, if we cannot found the product. This is possible if the product is not referenced in the imported catalog. | [optional] 
**ProductId** | **string** | We tried to get the catalog product identifier based on the product SKU. This property can be null, if we cannot found the product. This is possible if the product is not referenced in the imported catalog. | [optional] 
**UnitPrice** | **string** | The product&#39;s unit price related to this external order. This property is voluntarily a string because the value could be an invalid one. | [optional] 
**Quantity** | **string** | Indicate the product&#39;s quantity ordered. This property is voluntarily a string because the value could be an invalid one | [optional] 
**Margin** | **string** | Indicate the product&#39;s margin related to this order. This property is voluntarily a string because the value could be an invalid one | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

