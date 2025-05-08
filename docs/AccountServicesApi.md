# ConstantContactApi.Api.AccountServicesApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAccountEmailAddress**](AccountServicesApi.md#addaccountemailaddress) | **POST** /account/emails | POST Add an Account Email Address |
| [**AddPhysicalAddress**](AccountServicesApi.md#addphysicaladdress) | **POST** /account/summary/physical_address | POST the Physical Address for the Account |
| [**GetAccountDetails**](AccountServicesApi.md#getaccountdetails) | **GET** /account/summary | GET a Summary of Account Details |
| [**GetAccountPhysicalAddress**](AccountServicesApi.md#getaccountphysicaladdress) | **GET** /account/summary/physical_address | GET the Physical Address for the Account |
| [**GetAllAccountEmailAddresses**](AccountServicesApi.md#getallaccountemailaddresses) | **GET** /account/emails | GET a Collection of Account Email Addresses |
| [**GetUserPrivileges**](AccountServicesApi.md#getuserprivileges) | **GET** /account/user/privileges | GET User Privileges |
| [**UpdateAccount**](AccountServicesApi.md#updateaccount) | **PUT** /account/summary | PUT (update) Account Details |
| [**UpdateAccountPhysicalAddress**](AccountServicesApi.md#updateaccountphysicaladdress) | **PUT** /account/summary/physical_address | PUT (update) the Physical Address for an Account |

<a id="addaccountemailaddress"></a>
# **AddAccountEmailAddress**
> AddAccountEmailAddress201Response AddAccountEmailAddress (AddAccountEmailAddressRequest addAccountEmailAddressRequest)

POST Add an Account Email Address

Use this method to add a new email address to a Constant Contact account. If the email address you are adding already exists in the account the API will return a 409 conflict error.   When you add a new email address to an account, Constant Contact automatically sends an email to that address with a link to confirm it. After a user clicks that link, the account email status changes from `UNCONFIRMED` to `CONFIRMED`. You can use confirmed account email addresses in the email campaign `from_email` and `reply_to_email` headers. For more use case information, see [Add an Account Email Address](/api_guide/account_post_emails.html) in the API guide.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class AddAccountEmailAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);
            var addAccountEmailAddressRequest = new AddAccountEmailAddressRequest(); // AddAccountEmailAddressRequest | A JSON request payload containing the new email address you want to add to the Constant Contact account.

            try
            {
                // POST Add an Account Email Address
                AddAccountEmailAddress201Response result = apiInstance.AddAccountEmailAddress(addAccountEmailAddressRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.AddAccountEmailAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAccountEmailAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST Add an Account Email Address
    ApiResponse<AddAccountEmailAddress201Response> response = apiInstance.AddAccountEmailAddressWithHttpInfo(addAccountEmailAddressRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.AddAccountEmailAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addAccountEmailAddressRequest** | [**AddAccountEmailAddressRequest**](AddAccountEmailAddressRequest.md) | A JSON request payload containing the new email address you want to add to the Constant Contact account. |  |

### Return type

[**AddAccountEmailAddress201Response**](AddAccountEmailAddress201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addphysicaladdress"></a>
# **AddPhysicalAddress**
> GetAccountDetails200ResponsePhysicalAddress AddPhysicalAddress (GetAccountDetails200ResponsePhysicalAddress getAccountDetails200ResponsePhysicalAddress)

POST the Physical Address for the Account

Use this method to add the address where the account's organization physically resides. The physical address is required to send emails and displays on the footer of every email that is sent from the account. The country (<code>country_code</code>) where the account organization resides determines whether you use the <code>state_code</code> to specify United States (<code>US</code>) and Canada (<code>CA</code>) addresses, or use the <code>state_name</code> to specify all other countries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class AddPhysicalAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);
            var getAccountDetails200ResponsePhysicalAddress = new GetAccountDetails200ResponsePhysicalAddress(); // GetAccountDetails200ResponsePhysicalAddress | Include all `AccountPhysicalAddress` properties required for the specified `country_code`. If a required property is not included or incorrectly formatted, a 400 error message is returned. If the address already exists, a 409 error message is returned.

            try
            {
                // POST the Physical Address for the Account
                GetAccountDetails200ResponsePhysicalAddress result = apiInstance.AddPhysicalAddress(getAccountDetails200ResponsePhysicalAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.AddPhysicalAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPhysicalAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST the Physical Address for the Account
    ApiResponse<GetAccountDetails200ResponsePhysicalAddress> response = apiInstance.AddPhysicalAddressWithHttpInfo(getAccountDetails200ResponsePhysicalAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.AddPhysicalAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getAccountDetails200ResponsePhysicalAddress** | [**GetAccountDetails200ResponsePhysicalAddress**](GetAccountDetails200ResponsePhysicalAddress.md) | Include all &#x60;AccountPhysicalAddress&#x60; properties required for the specified &#x60;country_code&#x60;. If a required property is not included or incorrectly formatted, a 400 error message is returned. If the address already exists, a 409 error message is returned. |  |

### Return type

[**GetAccountDetails200ResponsePhysicalAddress**](GetAccountDetails200ResponsePhysicalAddress.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountdetails"></a>
# **GetAccountDetails**
> GetAccountDetails200Response GetAccountDetails (string? extraFields = null)

GET a Summary of Account Details

Get account related details for a Constant Contact user account. Use the `extra_fields` query parameter to include the `company_logo` and/or `physical_address` details in the response body. For more details, see [Get Account Summary Details](/api_guide/account_details_get.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAccountDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);
            var extraFields = company_logo;  // string? | Use the `extra_fields` query parameter to include the `physical_address` and/or `company_logo` details in the response body. Use a comma separated list to include both (physical_address, company logo). (optional) 

            try
            {
                // GET a Summary of Account Details
                GetAccountDetails200Response result = apiInstance.GetAccountDetails(extraFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.GetAccountDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Summary of Account Details
    ApiResponse<GetAccountDetails200Response> response = apiInstance.GetAccountDetailsWithHttpInfo(extraFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.GetAccountDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **extraFields** | **string?** | Use the &#x60;extra_fields&#x60; query parameter to include the &#x60;physical_address&#x60; and/or &#x60;company_logo&#x60; details in the response body. Use a comma separated list to include both (physical_address, company logo). | [optional]  |

### Return type

[**GetAccountDetails200Response**](GetAccountDetails200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountphysicaladdress"></a>
# **GetAccountPhysicalAddress**
> GetAccountDetails200ResponsePhysicalAddress GetAccountPhysicalAddress ()

GET the Physical Address for the Account

Use this method to get the address where the account's organization physically resides. The physical address is required to send emails and displays on the footer of every email that is sent from the account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAccountPhysicalAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);

            try
            {
                // GET the Physical Address for the Account
                GetAccountDetails200ResponsePhysicalAddress result = apiInstance.GetAccountPhysicalAddress();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.GetAccountPhysicalAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountPhysicalAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET the Physical Address for the Account
    ApiResponse<GetAccountDetails200ResponsePhysicalAddress> response = apiInstance.GetAccountPhysicalAddressWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.GetAccountPhysicalAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetAccountDetails200ResponsePhysicalAddress**](GetAccountDetails200ResponsePhysicalAddress.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallaccountemailaddresses"></a>
# **GetAllAccountEmailAddresses**
> List&lt;GetAllAccountEmailAddresses200ResponseInner&gt; GetAllAccountEmailAddresses (string? confirmStatus = null, string? roleCode = null, string? emailAddress = null)

GET a Collection of Account Email Addresses

Use this method to return a collection of email addresses for the account associated with your access token. When you <a href=\"https://v3.developer.constantcontact.com/api_reference/index.html#!/Email_Campaigns/createEmailCampaignUsingPOST\" target=\"_blank\">Create an Email Campaign<a/>, you must use an account email address with a `CONFIRMED` status in the email campaign `from_email` and `reply_to_email` headers.         Use the query parameters to filter results. You can filter using `confirm_status`, `role_code`, or `email_address`. For example, searching with `confirm_status=CONFIRMED` returns all confirmed email addresses in the account. This method only supports one query parameter at a time. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllAccountEmailAddressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);
            var confirmStatus = "CONFIRMED";  // string? | Use the `confirm_status` query parameter to search for account emails using the email status. Possible values are `CONFIRMED` or `UNCONFIRMED`. You can also abbreviate the values of this query parameter and use `C` or `U`.  (optional) 
            var roleCode = "CONTACT";  // string? | Use the `role_code` query parameter to search for account emails that have a specific role. Each each email address in an account can have multiple roles or no role. Possible values are `CONTACT`, `BILLING`, `REPLY_TO`, `JOURNALING`, or `OTHER`. You can also abbreviate the value of this query parameter and use `C`,`B`,`R`,`J`, or `O`. (optional) 
            var emailAddress = "emailAddress_example";  // string? | Use the `email_address` query parameter to search for a specific account email address. (optional) 

            try
            {
                // GET a Collection of Account Email Addresses
                List<GetAllAccountEmailAddresses200ResponseInner> result = apiInstance.GetAllAccountEmailAddresses(confirmStatus, roleCode, emailAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.GetAllAccountEmailAddresses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllAccountEmailAddressesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Collection of Account Email Addresses
    ApiResponse<List<GetAllAccountEmailAddresses200ResponseInner>> response = apiInstance.GetAllAccountEmailAddressesWithHttpInfo(confirmStatus, roleCode, emailAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.GetAllAccountEmailAddressesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **confirmStatus** | **string?** | Use the &#x60;confirm_status&#x60; query parameter to search for account emails using the email status. Possible values are &#x60;CONFIRMED&#x60; or &#x60;UNCONFIRMED&#x60;. You can also abbreviate the values of this query parameter and use &#x60;C&#x60; or &#x60;U&#x60;.  | [optional]  |
| **roleCode** | **string?** | Use the &#x60;role_code&#x60; query parameter to search for account emails that have a specific role. Each each email address in an account can have multiple roles or no role. Possible values are &#x60;CONTACT&#x60;, &#x60;BILLING&#x60;, &#x60;REPLY_TO&#x60;, &#x60;JOURNALING&#x60;, or &#x60;OTHER&#x60;. You can also abbreviate the value of this query parameter and use &#x60;C&#x60;,&#x60;B&#x60;,&#x60;R&#x60;,&#x60;J&#x60;, or &#x60;O&#x60;. | [optional]  |
| **emailAddress** | **string?** | Use the &#x60;email_address&#x60; query parameter to search for a specific account email address. | [optional]  |

### Return type

[**List&lt;GetAllAccountEmailAddresses200ResponseInner&gt;**](GetAllAccountEmailAddresses200ResponseInner.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserprivileges"></a>
# **GetUserPrivileges**
> List&lt;GetUserPrivileges200ResponseInner&gt; GetUserPrivileges ()

GET User Privileges

Use this method to return the user privileges associated with your access token as an array of objects. This method returns all user privileges, including privileges the V3 API does not currently use. Constant Contact requires specific user privileges to make requests using the V3 API. For more information, see the [User Privileges and Roles Overview](/api_guide/user_privileges.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetUserPrivilegesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);

            try
            {
                // GET User Privileges
                List<GetUserPrivileges200ResponseInner> result = apiInstance.GetUserPrivileges();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.GetUserPrivileges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserPrivilegesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET User Privileges
    ApiResponse<List<GetUserPrivileges200ResponseInner>> response = apiInstance.GetUserPrivilegesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.GetUserPrivilegesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GetUserPrivileges200ResponseInner&gt;**](GetUserPrivileges200ResponseInner.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. Your application is deactivated. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaccount"></a>
# **UpdateAccount**
> UpdateAccountRequest UpdateAccount (UpdateAccountRequest updateAccountRequest)

PUT (update) Account Details

Use this method to update account details for a Constant Contact account, such as the email address or phone number. This PUT method provides a partial update where only valid properties that you include in the request body are updated and excluded properties are not overwritten. For more details, see [Put (update) Account Summary Details](/api_guide/account_details_put.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);
            var updateAccountRequest = new UpdateAccountRequest(); // UpdateAccountRequest | In the request body, specify changes to account details by including and modifying all or select `CustomerPut` properties. Changes to read-only fields (`encoded_account_id`) are ignored.

            try
            {
                // PUT (update) Account Details
                UpdateAccountRequest result = apiInstance.UpdateAccount(updateAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.UpdateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (update) Account Details
    ApiResponse<UpdateAccountRequest> response = apiInstance.UpdateAccountWithHttpInfo(updateAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.UpdateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateAccountRequest** | [**UpdateAccountRequest**](UpdateAccountRequest.md) | In the request body, specify changes to account details by including and modifying all or select &#x60;CustomerPut&#x60; properties. Changes to read-only fields (&#x60;encoded_account_id&#x60;) are ignored. |  |

### Return type

[**UpdateAccountRequest**](UpdateAccountRequest.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaccountphysicaladdress"></a>
# **UpdateAccountPhysicalAddress**
> GetAccountDetails200ResponsePhysicalAddress UpdateAccountPhysicalAddress (GetAccountDetails200ResponsePhysicalAddress getAccountDetails200ResponsePhysicalAddress)

PUT (update) the Physical Address for an Account

Use this method to update the organization's physical address for the Constant Contact user account. The physical address is required to send emails and displays on the footer of every email that is sent from the account. To get the current physical address, make a GET call to `/account/summary/physical_address`. The country (<code>country_code</code>) where the account organization resides determines whether you use the <code>state_code</code> to specify United States (<code>US</code>) and Canada (<code>CA</code>) addresses, or use the <code>state_name</code> to specify all other countries. For more details, see [Put (update) the Physical Address for the Account](/api_guide/account_address_put.html). You must have the role of Account Owner assigned to update account level details. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateAccountPhysicalAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountServicesApi(config);
            var getAccountDetails200ResponsePhysicalAddress = new GetAccountDetails200ResponsePhysicalAddress(); // GetAccountDetails200ResponsePhysicalAddress | Include all `AccountPhysicalAddress` properties required for the specified `country_code` and then update only those properties that you want to change. Excluding a non-read only field from the request body removes it from the physical address.

            try
            {
                // PUT (update) the Physical Address for an Account
                GetAccountDetails200ResponsePhysicalAddress result = apiInstance.UpdateAccountPhysicalAddress(getAccountDetails200ResponsePhysicalAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountServicesApi.UpdateAccountPhysicalAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountPhysicalAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (update) the Physical Address for an Account
    ApiResponse<GetAccountDetails200ResponsePhysicalAddress> response = apiInstance.UpdateAccountPhysicalAddressWithHttpInfo(getAccountDetails200ResponsePhysicalAddress);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountServicesApi.UpdateAccountPhysicalAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getAccountDetails200ResponsePhysicalAddress** | [**GetAccountDetails200ResponsePhysicalAddress**](GetAccountDetails200ResponsePhysicalAddress.md) | Include all &#x60;AccountPhysicalAddress&#x60; properties required for the specified &#x60;country_code&#x60; and then update only those properties that you want to change. Excluding a non-read only field from the request body removes it from the physical address. |  |

### Return type

[**GetAccountDetails200ResponsePhysicalAddress**](GetAccountDetails200ResponsePhysicalAddress.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

