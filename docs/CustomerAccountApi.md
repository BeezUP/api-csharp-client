# IO.Swagger.Api.CustomerAccountApi

All URIs are relative to *https://api.beezup.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateUserAccount**](CustomerAccountApi.md#activateuseraccount) | **POST** /user/customer/account/activate | Activate the user account
[**ChangePassword**](CustomerAccountApi.md#changepassword) | **POST** /user/customer/account/changePassword | Change user password
[**GetCreditCardInfo**](CustomerAccountApi.md#getcreditcardinfo) | **GET** /user/customer/account/creditCardInfo | Get credit card information
[**GetProfilePictureInfo**](CustomerAccountApi.md#getprofilepictureinfo) | **GET** /user/customer/account/profilePictureInfo | Get profile picture information
[**GetUserAccountInfo**](CustomerAccountApi.md#getuseraccountinfo) | **GET** /user/customer/account | Get user account information
[**ResendEmailActivation**](CustomerAccountApi.md#resendemailactivation) | **POST** /user/customer/account/resendEmailActivation | Resend email activation
[**SaveCompanyInfo**](CustomerAccountApi.md#savecompanyinfo) | **PUT** /user/customer/account/companyInfo | Change company information
[**SaveCreditCardInfo**](CustomerAccountApi.md#savecreditcardinfo) | **PUT** /user/customer/account/creditCardInfo | Save user credit card info
[**SavePersonalInfo**](CustomerAccountApi.md#savepersonalinfo) | **PUT** /user/customer/account/personalInfo | Save user personal information
[**SaveProfilePictureInfo**](CustomerAccountApi.md#saveprofilepictureinfo) | **PUT** /user/customer/account/profilePictureInfo | Change user picture information


<a name="activateuseraccount"></a>
# **ActivateUserAccount**
> void ActivateUserAccount (string emailActivationId)

Activate the user account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActivateUserAccountExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();
            var emailActivationId = emailActivationId_example;  // string | The email activation id received by email.

            try
            {
                // Activate the user account
                apiInstance.ActivateUserAccount(emailActivationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.ActivateUserAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailActivationId** | **string**| The email activation id received by email. | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (ChangePasswordRequest request)

Change user password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();
            var request = new ChangePasswordRequest(); // ChangePasswordRequest | 

            try
            {
                // Change user password
                apiInstance.ChangePassword(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ChangePasswordRequest**](ChangePasswordRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditcardinfo"></a>
# **GetCreditCardInfo**
> CreditCardInfoResponse GetCreditCardInfo ()

Get credit card information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCreditCardInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();

            try
            {
                // Get credit card information
                CreditCardInfoResponse result = apiInstance.GetCreditCardInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.GetCreditCardInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CreditCardInfoResponse**](CreditCardInfoResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofilepictureinfo"></a>
# **GetProfilePictureInfo**
> ProfilePictureInfoResponse GetProfilePictureInfo ()

Get profile picture information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProfilePictureInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();

            try
            {
                // Get profile picture information
                ProfilePictureInfoResponse result = apiInstance.GetProfilePictureInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.GetProfilePictureInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProfilePictureInfoResponse**](ProfilePictureInfoResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuseraccountinfo"></a>
# **GetUserAccountInfo**
> AccountInfo GetUserAccountInfo ()

Get user account information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserAccountInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();

            try
            {
                // Get user account information
                AccountInfo result = apiInstance.GetUserAccountInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.GetUserAccountInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountInfo**](AccountInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendemailactivation"></a>
# **ResendEmailActivation**
> void ResendEmailActivation ()

Resend email activation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendEmailActivationExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();

            try
            {
                // Resend email activation
                apiInstance.ResendEmailActivation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.ResendEmailActivation: " + e.Message );
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

<a name="savecompanyinfo"></a>
# **SaveCompanyInfo**
> void SaveCompanyInfo (CompanyInfo request)

Change company information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveCompanyInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();
            var request = new CompanyInfo(); // CompanyInfo | 

            try
            {
                // Change company information
                apiInstance.SaveCompanyInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.SaveCompanyInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CompanyInfo**](CompanyInfo.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savecreditcardinfo"></a>
# **SaveCreditCardInfo**
> void SaveCreditCardInfo (CreditCardInfo request)

Save user credit card info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveCreditCardInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();
            var request = new CreditCardInfo(); // CreditCardInfo | Credit card info

            try
            {
                // Save user credit card info
                apiInstance.SaveCreditCardInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.SaveCreditCardInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreditCardInfo**](CreditCardInfo.md)| Credit card info | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="savepersonalinfo"></a>
# **SavePersonalInfo**
> void SavePersonalInfo (PersonalInfo request)

Save user personal information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SavePersonalInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();
            var request = new PersonalInfo(); // PersonalInfo | 

            try
            {
                // Save user personal information
                apiInstance.SavePersonalInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.SavePersonalInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PersonalInfo**](PersonalInfo.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="saveprofilepictureinfo"></a>
# **SaveProfilePictureInfo**
> void SaveProfilePictureInfo (ProfilePictureInfo request)

Change user picture information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveProfilePictureInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new CustomerAccountApi();
            var request = new ProfilePictureInfo(); // ProfilePictureInfo | 

            try
            {
                // Change user picture information
                apiInstance.SaveProfilePictureInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerAccountApi.SaveProfilePictureInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ProfilePictureInfo**](ProfilePictureInfo.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

