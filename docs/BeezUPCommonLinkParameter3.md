# IO.Swagger.Model.BeezUPCommonLinkParameter3
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **Object** | The value of the parameter. It can be an integer a string or an object. | [optional] 
**Required** | **bool?** |  | [optional] 
**_In** | **string** | * path: if the parameter must be pass in the path uri * header: if the parameter must be passed in http header * query: if the parameter must be passed in querystring * body: if the paramter must be passed in the body  | [optional] 
**Type** | **string** | The value type of the parameter | [optional] 
**LovLink** | [**BeezUPCommonLOVLink2**](BeezUPCommonLOVLink2.md) | This parameter expect the values indicated in this list of values. | [optional] 
**LovRequired** | **bool?** | If true, you MUST use indicate a value from the list of values otherwise it&#39;s a freetext | [optional] 
**Description** | **string** | description of the parameter | [optional] 
**Schema** | **string** | schema of the parameter | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

