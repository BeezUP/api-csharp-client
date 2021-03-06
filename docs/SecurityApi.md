# IO.Swagger.Api.SecurityApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](SecurityApi.md#login) | **POST** /v2/public/security/login | Login
[**LostPassword**](SecurityApi.md#lostpassword) | **POST** /v2/public/security/lostpassword | Lost password
[**Register**](SecurityApi.md#register) | **POST** /v2/public/security/register | User Registration


<a name="login"></a>
# **Login**
> ApiCredentials Login (LoginRequest request)

Login

User Login - The login will give your tokens

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            
            var apiInstance = new SecurityApi();
            var request = new LoginRequest(); // LoginRequest | 

            try
            {
                // Login
                ApiCredentials result = apiInstance.Login(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**LoginRequest**](LoginRequest.md)|  | 

### Return type

[**ApiCredentials**](ApiCredentials.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lostpassword"></a>
# **LostPassword**
> void LostPassword (BeezUPCommonEmail email)

Lost password

Lost password - Your password will be regenerated and sent to your email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LostPasswordExample
    {
        public void main()
        {
            
            var apiInstance = new SecurityApi();
            var email = new BeezUPCommonEmail(); // BeezUPCommonEmail | Your email

            try
            {
                // Lost password
                apiInstance.LostPassword(email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.LostPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | [**BeezUPCommonEmail**](BeezUPCommonEmail.md)| Your email | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="register"></a>
# **Register**
> void Register (RegisterRequest request)

User Registration

User Registration - Create a new user on BeezUP

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            
            var apiInstance = new SecurityApi();
            var request = new RegisterRequest(); // RegisterRequest | 

            try
            {
                // User Registration
                apiInstance.Register(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RegisterRequest**](RegisterRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

