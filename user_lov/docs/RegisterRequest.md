# IO.Swagger.Model.RegisterRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Your email. We refuse disposable email. | 
**Password** | **string** | The password you want to use for your new account. \\ The password length must be greater or equals to 6 and lower or equals to 128. \\ The password must contains at least one number and one special character  | 
**CultureName** | **string** | Can be null. Default: en-GB. The culture name you want to use. FYI. \\ The email activation will use this culture.  | [optional] 
**CommercialOwnerUserId** | **Guid?** | The user id of your commercial in BeezUP. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

