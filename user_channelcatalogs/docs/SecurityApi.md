# IO.Swagger.Api.SecurityApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](SecurityApi.md#login) | **POST** /v2/public/security/login | Login
[**Logout**](SecurityApi.md#logout) | **POST** /v2/user/customer/security/logout | Log out the current user from go2
[**LostPassword**](SecurityApi.md#lostpassword) | **POST** /v2/public/security/lostpassword | Lost password
[**Register**](SecurityApi.md#register) | **POST** /v2/public/security/register | User Registration


<a name="login"></a>
# **Login**
> ApiCredentials Login (LoginRequest request = null)

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
            var request = new LoginRequest(); // LoginRequest |  (optional) 

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
 **request** | [**LoginRequest**](LoginRequest.md)|  | [optional] 

### Return type

[**ApiCredentials**](ApiCredentials.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout ()

Log out the current user from go2

Log out the current user from go2

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new SecurityApi();

            try
            {
                // Log out the current user from go2
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lostpassword"></a>
# **LostPassword**
> void LostPassword (Email email = null)

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
            var email = new Email(); // Email | Your email (optional) 

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
 **email** | [**Email**](Email.md)| Your email | [optional] 

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
> void Register (RegisterRequest request = null)

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
            var request = new RegisterRequest(); // RegisterRequest |  (optional) 

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
 **request** | [**RegisterRequest**](RegisterRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

