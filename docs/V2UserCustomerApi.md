# IO.Swagger.Api.V2UserCustomerApi

All URIs are relative to *https://api.beezup.comv2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateUserAccount**](V2UserCustomerApi.md#activateuseraccount) | **POST** /v2/user/customer/account/activate | Activate the user account
[**ChangePassword**](V2UserCustomerApi.md#changepassword) | **POST** /v2/user/customer/account/changePassword | Change user password
[**CreateContract**](V2UserCustomerApi.md#createcontract) | **POST** /v2/user/customer/contracts | Create a new contract
[**CreateStore**](V2UserCustomerApi.md#createstore) | **POST** /v2/user/customer/stores | Create a new store
[**DeleteNextContract**](V2UserCustomerApi.md#deletenextcontract) | **DELETE** /v2/user/customer/contracts/next | Delete your next contract
[**DeleteShare**](V2UserCustomerApi.md#deleteshare) | **DELETE** /v2/user/customer/stores/{storeId}/shares/{userId} | Delete a share to another user
[**DeleteStore**](V2UserCustomerApi.md#deletestore) | **DELETE** /v2/user/customer/stores/{storeId} | Delete a store
[**GetBillingPeriods**](V2UserCustomerApi.md#getbillingperiods) | **GET** /v2/user/customer/billingPeriods | Get billing periods conditions
[**GetContracts**](V2UserCustomerApi.md#getcontracts) | **GET** /v2/user/customer/contracts | Get contract list
[**GetCreditCardInfo**](V2UserCustomerApi.md#getcreditcardinfo) | **GET** /v2/user/customer/account/creditCardInfo | Get credit card information
[**GetFriendInfo**](V2UserCustomerApi.md#getfriendinfo) | **GET** /v2/user/customer/friends/{userId} | Get friend information
[**GetInvoices**](V2UserCustomerApi.md#getinvoices) | **GET** /v2/user/customer/invoices | Get all your invoices
[**GetOffer**](V2UserCustomerApi.md#getoffer) | **POST** /v2/user/customer/offers | Get offer pricing
[**GetRights**](V2UserCustomerApi.md#getrights) | **POST** /v2/user/customer/stores/{storeId}/rights | Get store&#39;s rights
[**GetShares**](V2UserCustomerApi.md#getshares) | **GET** /v2/user/customer/stores/{storeId}/shares | Get shares related to this store
[**GetStandardOffers**](V2UserCustomerApi.md#getstandardoffers) | **GET** /v2/user/customer/offers | Get all standard offers
[**GetStore**](V2UserCustomerApi.md#getstore) | **GET** /v2/user/customer/stores/{storeId} | Get store&#39;s information
[**GetStoreAlerts**](V2UserCustomerApi.md#getstorealerts) | **GET** /v2/user/customer/stores/{storeId}/alerts | Get store&#39;s alerts
[**GetStores**](V2UserCustomerApi.md#getstores) | **GET** /v2/user/customer/stores | Get store list
[**GetUserAccountInfo**](V2UserCustomerApi.md#getuseraccountinfo) | **GET** /v2/user/customer/account | Get user account information
[**Logout**](V2UserCustomerApi.md#logout) | **POST** /v2/user/customer/security/logout | Log out the current user from go2
[**ReactivateCurrentContract**](V2UserCustomerApi.md#reactivatecurrentcontract) | **POST** /v2/user/customer/contracts/current/reenableAutoRenewal | Reactivate your terminated contract.
[**ResendEmailActivation**](V2UserCustomerApi.md#resendemailactivation) | **POST** /v2/user/customer/account/resendEmailActivation | Resend email activation
[**SaveCompanyInfo**](V2UserCustomerApi.md#savecompanyinfo) | **PUT** /v2/user/customer/account/companyInfo | Change company information
[**SaveCreditCardInfo**](V2UserCustomerApi.md#savecreditcardinfo) | **PUT** /v2/user/customer/account/creditCardInfo | Save user credit card info
[**SavePersonalInfo**](V2UserCustomerApi.md#savepersonalinfo) | **PUT** /v2/user/customer/account/personalInfo | Save user personal information
[**SaveProfilePictureInfo**](V2UserCustomerApi.md#saveprofilepictureinfo) | **PUT** /v2/user/customer/account/profilePictureInfo | Change user picture information
[**SaveStoreAlert**](V2UserCustomerApi.md#savestorealert) | **PUT** /v2/user/customer/stores/{storeId}/alerts/{alertId} | Save store alert
[**Share**](V2UserCustomerApi.md#share) | **POST** /v2/user/customer/stores/{storeId}/shares | Share a store to another user
[**TerminateCurrentContract**](V2UserCustomerApi.md#terminatecurrentcontract) | **POST** /v2/user/customer/contracts/current/disableAutoRenewal | Schedule termination of your current contract at the end of the commitment.
[**UpdateStore**](V2UserCustomerApi.md#updatestore) | **PATCH** /v2/user/customer/stores/{storeId} | Update some store&#39;s information.


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

            var apiInstance = new V2UserCustomerApi();
            var emailActivationId = emailActivationId_example;  // string | The email activation id received by email.

            try
            {
                // Activate the user account
                apiInstance.ActivateUserAccount(emailActivationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.ActivateUserAccount: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();
            var request = new ChangePasswordRequest(); // ChangePasswordRequest | 

            try
            {
                // Change user password
                apiInstance.ChangePassword(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.ChangePassword: " + e.Message );
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

<a name="createcontract"></a>
# **CreateContract**
> BeezUPCommonInfoSummaries CreateContract (CreateContract request)

Create a new contract

Now you are ready to create your contract. Before that, please ensure that you check the offer with the same request parameterts. /offers 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var request = new CreateContract(); // CreateContract | 

            try
            {
                // Create a new contract
                BeezUPCommonInfoSummaries result = apiInstance.CreateContract(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.CreateContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateContract**](CreateContract.md)|  | 

### Return type

[**BeezUPCommonInfoSummaries**](BeezUPCommonInfoSummaries.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstore"></a>
# **CreateStore**
> LinksGetStoresLink CreateStore (CreateStoreRequest request)

Create a new store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var request = new CreateStoreRequest(); // CreateStoreRequest | 

            try
            {
                // Create a new store
                LinksGetStoresLink result = apiInstance.CreateStore(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.CreateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateStoreRequest**](CreateStoreRequest.md)|  | 

### Return type

[**LinksGetStoresLink**](LinksGetStoresLink.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenextcontract"></a>
# **DeleteNextContract**
> void DeleteNextContract ()

Delete your next contract

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteNextContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Delete your next contract
                apiInstance.DeleteNextContract();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.DeleteNextContract: " + e.Message );
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

<a name="deleteshare"></a>
# **DeleteShare**
> void DeleteShare (string storeId, string userId)

Delete a share to another user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShareExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier
            var userId = userId_example;  // string | The friend user id

            try
            {
                // Delete a share to another user
                apiInstance.DeleteShare(storeId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.DeleteShare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **userId** | **string**| The friend user id | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestore"></a>
# **DeleteStore**
> void DeleteStore (string storeId)

Delete a store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Delete a store
                apiInstance.DeleteStore(storeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.DeleteStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingperiods"></a>
# **GetBillingPeriods**
> BillingPeriods GetBillingPeriods ()

Get billing periods conditions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBillingPeriodsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get billing periods conditions
                BillingPeriods result = apiInstance.GetBillingPeriods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetBillingPeriods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BillingPeriods**](BillingPeriods.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontracts"></a>
# **GetContracts**
> Contracts GetContracts ()

Get contract list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContractsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get contract list
                Contracts result = apiInstance.GetContracts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Contracts**](Contracts.md)

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

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get credit card information
                CreditCardInfoResponse result = apiInstance.GetCreditCardInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetCreditCardInfo: " + e.Message );
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

<a name="getfriendinfo"></a>
# **GetFriendInfo**
> UserFriendInfo GetFriendInfo (string userId)

Get friend information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFriendInfoExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var userId = userId_example;  // string | Your friend user id

            try
            {
                // Get friend information
                UserFriendInfo result = apiInstance.GetFriendInfo(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetFriendInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| Your friend user id | 

### Return type

[**UserFriendInfo**](UserFriendInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoices"></a>
# **GetInvoices**
> Invoices GetInvoices ()

Get all your invoices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get all your invoices
                Invoices result = apiInstance.GetInvoices();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Invoices**](Invoices.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoffer"></a>
# **GetOffer**
> Offer GetOffer (OfferRequest request)

Get offer pricing

Get the offer pricing then you can create your contract with the same request parameters. /v2/user/customer/contracts 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOfferExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var request = new OfferRequest(); // OfferRequest | 

            try
            {
                // Get offer pricing
                Offer result = apiInstance.GetOffer(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetOffer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**OfferRequest**](OfferRequest.md)|  | 

### Return type

[**Offer**](Offer.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrights"></a>
# **GetRights**
> List<FunctionalityRightInfo> GetRights (string storeId, List<string> functionalityCodeList)

Get store's rights

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRightsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier
            var functionalityCodeList = ;  // List<string> | The functionality code list you want to check

            try
            {
                // Get store's rights
                List&lt;FunctionalityRightInfo&gt; result = apiInstance.GetRights(storeId, functionalityCodeList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **functionalityCodeList** | **List&lt;string&gt;**| The functionality code list you want to check | 

### Return type

[**List<FunctionalityRightInfo>**](FunctionalityRightInfo.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshares"></a>
# **GetShares**
> StoreShares GetShares (string storeId)

Get shares related to this store

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSharesExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get shares related to this store
                StoreShares result = apiInstance.GetShares(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetShares: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreShares**](StoreShares.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstandardoffers"></a>
# **GetStandardOffers**
> StandardOffers GetStandardOffers ()

Get all standard offers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStandardOffersExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get all standard offers
                StandardOffers result = apiInstance.GetStandardOffers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetStandardOffers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StandardOffers**](StandardOffers.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstore"></a>
# **GetStore**
> StoreHeader GetStore (string storeId)

Get store's information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store's information
                StoreHeader result = apiInstance.GetStore(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreHeader**](StoreHeader.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstorealerts"></a>
# **GetStoreAlerts**
> StoreAlerts GetStoreAlerts (string storeId)

Get store's alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoreAlertsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier

            try
            {
                // Get store's alerts
                StoreAlerts result = apiInstance.GetStoreAlerts(storeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetStoreAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 

### Return type

[**StoreAlerts**](StoreAlerts.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstores"></a>
# **GetStores**
> Stores GetStores ()

Get store list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStoresExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get store list
                Stores result = apiInstance.GetStores();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetStores: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Stores**](Stores.md)

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

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Get user account information
                AccountInfo result = apiInstance.GetUserAccountInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.GetUserAccountInfo: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Log out the current user from go2
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.Logout: " + e.Message );
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

<a name="reactivatecurrentcontract"></a>
# **ReactivateCurrentContract**
> void ReactivateCurrentContract ()

Reactivate your terminated contract.

By calling this operation you can re-enable the auto renewal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReactivateCurrentContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Reactivate your terminated contract.
                apiInstance.ReactivateCurrentContract();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.ReactivateCurrentContract: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();

            try
            {
                // Resend email activation
                apiInstance.ResendEmailActivation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.ResendEmailActivation: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();
            var request = new CompanyInfo(); // CompanyInfo | 

            try
            {
                // Change company information
                apiInstance.SaveCompanyInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.SaveCompanyInfo: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();
            var request = new CreditCardInfo(); // CreditCardInfo | Credit card info

            try
            {
                // Save user credit card info
                apiInstance.SaveCreditCardInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.SaveCreditCardInfo: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();
            var request = new PersonalInfo(); // PersonalInfo | 

            try
            {
                // Save user personal information
                apiInstance.SavePersonalInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.SavePersonalInfo: " + e.Message );
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

            var apiInstance = new V2UserCustomerApi();
            var request = new ProfilePictureInfo(); // ProfilePictureInfo | 

            try
            {
                // Change user picture information
                apiInstance.SaveProfilePictureInfo(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.SaveProfilePictureInfo: " + e.Message );
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

<a name="savestorealert"></a>
# **SaveStoreAlert**
> void SaveStoreAlert (string storeId, int? alertId, List<SaveStoreAlertRequest> request)

Save store alert

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SaveStoreAlertExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier
            var alertId = 56;  // int? | 
            var request = new List<SaveStoreAlertRequest>(); // List<SaveStoreAlertRequest> | 

            try
            {
                // Save store alert
                apiInstance.SaveStoreAlert(storeId, alertId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.SaveStoreAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **alertId** | **int?**|  | 
 **request** | [**List&lt;SaveStoreAlertRequest&gt;**](SaveStoreAlertRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="share"></a>
# **Share**
> void Share (string storeId, FriendEmail email)

Share a store to another user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShareExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier
            var email = new FriendEmail(); // FriendEmail | Your friend's email

            try
            {
                // Share a store to another user
                apiInstance.Share(storeId, email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.Share: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **email** | [**FriendEmail**](FriendEmail.md)| Your friend&#39;s email | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="terminatecurrentcontract"></a>
# **TerminateCurrentContract**
> void TerminateCurrentContract (TerminateContract request)

Schedule termination of your current contract at the end of the commitment.

By default your contract are automatically renew. By calling this operation you can disable the auto renewal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TerminateCurrentContractExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var request = new TerminateContract(); // TerminateContract | Indicate the termination reason

            try
            {
                // Schedule termination of your current contract at the end of the commitment.
                apiInstance.TerminateCurrentContract(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.TerminateCurrentContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TerminateContract**](TerminateContract.md)| Indicate the termination reason | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestore"></a>
# **UpdateStore**
> void UpdateStore (string storeId, UpdateStoreRequest request)

Update some store's information.

Update some store's information. FYI, you cannot change the country. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateStoreExample
    {
        public void main()
        {
            
            // Configure API key authorization: api_key
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");

            var apiInstance = new V2UserCustomerApi();
            var storeId = storeId_example;  // string | Your store identifier
            var request = new UpdateStoreRequest(); // UpdateStoreRequest | 

            try
            {
                // Update some store's information.
                apiInstance.UpdateStore(storeId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V2UserCustomerApi.UpdateStore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | **string**| Your store identifier | 
 **request** | [**UpdateStoreRequest**](UpdateStoreRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

