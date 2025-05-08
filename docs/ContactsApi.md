# ConstantContactApi.Api.ContactsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateContact**](ContactsApi.md#createcontact) | **POST** /contacts | POST (create) a Contact |
| [**CreateOrUpdateContact**](ContactsApi.md#createorupdatecontact) | **POST** /contacts/sign_up_form | Create or Update a Contact |
| [**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /contacts/{contact_id} | DELETE a Contact |
| [**GetAllContacts**](ContactsApi.md#getallcontacts) | **GET** /contacts | GET Contacts Collection |
| [**GetContactById**](ContactsApi.md#getcontactbyid) | **GET** /contacts/{contact_id} | GET a Contact |
| [**GetContactCounts**](ContactsApi.md#getcontactcounts) | **GET** /contacts/counts | GET Contact Consent Counts |
| [**GetContactIdXrefs**](ContactsApi.md#getcontactidxrefs) | **GET** /contacts/contact_id_xrefs | GET a collection of V2 and V3 API contact IDs |
| [**GetSmsEngagementHistory**](ContactsApi.md#getsmsengagementhistory) | **GET** /contacts/sms_engagement_history/{contact_id} | GET SMS Engagement History for a Contact |
| [**ResubscribeContact**](ContactsApi.md#resubscribecontact) | **PUT** /contacts/resubscribe/{contact_id} | PUT Resubscribe a Contact |
| [**UpdateContact**](ContactsApi.md#updatecontact) | **PUT** /contacts/{contact_id} | PUT (update) a Contact |

<a id="createcontact"></a>
# **CreateContact**
> GetContactById200Response CreateContact (CreateContactRequest createContactRequest)

POST (create) a Contact

 Creates a new contact resource. You must include the `create_source` property and at least one of the following properties: `first_name`, `last_name`, a unique `email_address` (specified using the `EmailAddress` object), or the `sms_channel` property (specified using the `ContactSmsChannel` object).  <div class=\"Msg\"><p class=\"note-text\">If `email_address` is specified: **Only use this method when a contact gives you their explicit permission to send them an email. It is a violation of anti-spam and telemarketing laws, as well as a serious violation of the Constant Contact Terms of Service to use the Opt-in features of the API to opt a contact back in without his or her own action and consent.</p></div>  If `sms_channel` is specified: <div class=\"Msg\"><p class=\"note-text\">Only use this method when a contact gives you their explicit permission to send them an SMS. It is a violation of anti-spam and telemarketing laws, as well as a serious violation of the Constant Contact Terms of Service to use the Opt-in features of the API to opt a contact back in without his or her own action and consent.</p></div>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var createContactRequest = new CreateContactRequest(); // CreateContactRequest | The JSON payload defining the contact

            try
            {
                // POST (create) a Contact
                GetContactById200Response result = apiInstance.CreateContact(createContactRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (create) a Contact
    ApiResponse<GetContactById200Response> response = apiInstance.CreateContactWithHttpInfo(createContactRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.CreateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createContactRequest** | [**CreateContactRequest**](CreateContactRequest.md) | The JSON payload defining the contact |  |

### Return type

[**GetContactById200Response**](GetContactById200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | New contact successfully created |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type; the payload must be in JSON format, and Content-Type must be application/json |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createorupdatecontact"></a>
# **CreateOrUpdateContact**
> CreateOrUpdateContact200Response CreateOrUpdateContact (CreateOrUpdateContactRequest createOrUpdateContactRequest)

Create or Update a Contact

Use this method to create a new contact or update an existing contact. In the request body, this method requires including the `list_memberships` array as well as either the contact's `email_address` string or `sms_channel` object which includes the contact's SMS number. The information you specify determines if a new contact is either created (the email address or SMS number does not already exist in the account), or if an existing contact is updated (the email address or SMS number already exists). The SMS product feature does not need to be enabled to include a contacts SMS details.  Updates to existing contacts are partial updates. This method only updates the contact properties you include in the request body. Updates append new contact lists or custom fields to the existing `list_memberships` or `custom_fields` arrays. If `email_address` is specified: <div class=\"Msg\"><p class=\"note-text\">Only use this method when a contact gives you their explicit permission to send them an email. It is a violation of anti-spam and telemarketing laws, as well as a serious violation of the Constant Contact Terms of Service to use the Opt-in features of the API to opt a contact back in without his or her own action and consent.</p></div>  If `sms_channel` is specified: <div class=\"Msg\"><p class=\"note-text\">Only use this method when a contact gives you their explicit permission to send them an SMS. It is a violation of anti-spam and telemarketing laws, as well as a serious violation of the Constant Contact Terms of Service to use the Opt-in features of the API to opt a contact back in without his or her own action and consent.</p></div> When this method creates a new contact, it returns a 201 response code.When this method updates an existing contact, it returns a 200 response code. Updating a deleted contact restores the contact.  The method automatically modifies the contact's `permission_to_send` and `opt_in_source` properties depending on the [Confirmed Opt-In](https://knowledgebase.constantcontact.com/articles/KnowledgeBase/5533-obtain-permission-to-send-email-campaigns-to-your-contacts-by-using-confirmed-opt-in) Constant Contact account setting:  If Confirmed Opt-in is _enabled_, this method automatically sets the `permission_to_send` property as `pending_confirmation` for new contacts. If Confirmed Opt-in is _disabled_, this method automatically sets the `permission_to_send` property as explicit and the `opt_in_source` property as `Contact` for new contacts. Updated contacts have their `permission_to_send` property set as explicit.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateOrUpdateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var createOrUpdateContactRequest = new CreateOrUpdateContactRequest(); // CreateOrUpdateContactRequest | A JSON request body payload that contains the contact resource you are creating or updating. The request body must contain the `email_address` property and `list_memberships` array, or the `sms_channel` object.

            try
            {
                // Create or Update a Contact
                CreateOrUpdateContact200Response result = apiInstance.CreateOrUpdateContact(createOrUpdateContactRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateOrUpdateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or Update a Contact
    ApiResponse<CreateOrUpdateContact200Response> response = apiInstance.CreateOrUpdateContactWithHttpInfo(createOrUpdateContactRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.CreateOrUpdateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrUpdateContactRequest** | [**CreateOrUpdateContactRequest**](CreateOrUpdateContactRequest.md) | A JSON request body payload that contains the contact resource you are creating or updating. The request body must contain the &#x60;email_address&#x60; property and &#x60;list_memberships&#x60; array, or the &#x60;sms_channel&#x60; object. |  |

### Return type

[**CreateOrUpdateContact200Response**](CreateOrUpdateContact200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact successfully updated. |  -  |
| **201** | Contact successfully created. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. You sent simultaneous requests that are attempting to modify the same contact. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (string contactId)

DELETE a Contact

Deletes the contact identified by the contact_id path parameter. Deleted contacts won't receive email from you, and they don't count as active contacts. Unlike unsubscribed contacts, deleted contacts can be revived, or added back to an account. Learn how to [revive deleted contacts](/api_guide/contacts_delete.html#revive).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var contactId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | Unique ID of contact to DELETE

            try
            {
                // DELETE a Contact
                apiInstance.DeleteContact(contactId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE a Contact
    apiInstance.DeleteContactWithHttpInfo(contactId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.DeleteContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | Unique ID of contact to DELETE |  |

### Return type

void (empty response body)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request successful; No content returned |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallcontacts"></a>
# **GetAllContacts**
> GetAllContacts200Response GetAllContacts (string? status = null, string? email = null, string? lists = null, string? segmentId = null, Guid? tags = null, DateTime? updatedAfter = null, DateTime? updatedBefore = null, DateTime? createdAfter = null, DateTime? createdBefore = null, DateTime? optoutAfter = null, DateTime? optoutBefore = null, string? include = null, string? smsStatus = null, bool? includeCount = null, int? limit = null)

GET Contacts Collection

Use this method to return a collection of contacts. Use the query parameters to search for contacts that match specific contact properties and sub-resource properties as criteria. For example, you can search using the contact's `email` address, `lists` memberships, and by the date range that a contact was created or updated. Use the `limit` query parameter to limit the number of results returned per page. Use the `include` query parameter to include contact sub-resources in the response and `include_count` to include the total number of contacts that meet your specified search criteria.  By default, this method returns all contacts that are not deleted. Use the `status` query parameter with the value `all` to return all contacts including deleted contacts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var status = "all";  // string? | Use the `status` query parameter to search for contacts by status. This parameter accepts one or more comma separated values: `all`, `active`, `deleted`, `not_set`, `pending_confirmation`, `temp_hold`, and `unsubscribed`. (optional) 
            var email = xyz@example.com;  // string? | Use the `email` query parameter to search for a contact using a specific email address. (optional) 
            var lists = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a,04fe9a-a579-43c5-bb1a-58ed29bf0a6a,04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string? | Use the `lists` query parameter to search for contacts that are members of one or more specified lists. Use a comma to separate multiple `list_id` values, up to a maximum of 25. (optional) 
            var segmentId = 14;  // string? | Use to get contacts that meet the segment criteria for a single specified `segment_id`. This query parameter can only be combined with the limit query parameter. When using the `segment_id` query parameter, the V3 API may return a 202 response code instead of a 200 response. The 202 response code indicates that your request has been accepted, but not fully completed. Retry sending your API request to return the completed results and a 200 response code. (optional) 
            var tags = fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid? | Use to get contact details for up to 50 specified tags. Use a comma to separate each `tag_id`. (optional) 
            var updatedAfter = 2022-01-01T16:37:59.091Z;  // DateTime? | Use `updated_after` to search for contacts that have been updated after the date you specify. To search for updated contacts within a date range, specify both `updated_after` and `updated_before` dates. Accepts ISO-8601 formatted dates. (optional) 
            var updatedBefore = 2022-07-16T16:37:59.091Z;  // DateTime? | Use `updated_before` to search for contacts that have been updated before a specified date. To search for updated contacts within a date range, specify both `updated_after` and `updated_before` dates. Accepts ISO-8601 formatted dates. (optional) 
            var createdAfter = 2021-01-01T16:37:59.091Z;  // DateTime? | Use `created_after` to search for contacts created after a specified date. To search for contacts created within a date range, specify both `created_after` and `created_before` dates. Accepts ISO-8601 formatted dates. (optional) 
            var createdBefore = 2022-07-16T16:37:59.091Z;  // DateTime? | Use `created_before` to search for contacts created before a specified date. To search for contacts created within a date range, specify both `created_after` and `created_before` dates. Accepts ISO-8601 formatted dates. (optional) 
            var optoutAfter = 2022-11-16T16:20:59.091Z;  // DateTime? | Use `optout_after` to search for contacts that unsubscribed after a specified date. (optional) 
            var optoutBefore = 2022-11-16T16:20:59.091Z;  // DateTime? | Use `optout_before` to search for contacts that unsubscribed before a specified date. (optional) 
            var include = custom_fields,list_memberships;  // string? | Use `include` to specify which contact sub-resources to include in the response. Use a comma to separate multiple sub-resources. Valid values: `custom_fields`, `list_memberships`, `taggings`, `notes`,`phone_numbers`, `street_addresses`. (optional) 
            var smsStatus = "all";  // string? | Use to get contacts by their SMS status. This parameter accepts one or more comma separated values: `all`, `explicit`, `unsubscribed`, `pending_confirmation`, `not_set`. (optional) 
            var includeCount = true;  // bool? | Set `include_count=true` to include the total number of contacts (`contacts_count`) that meet all search criteria in the response body. (optional) 
            var limit = 25;  // int? | Specifies the number of results displayed per page of output in the response, from 1 - 500, default = 50. (optional)  (default to 50)

            try
            {
                // GET Contacts Collection
                GetAllContacts200Response result = apiInstance.GetAllContacts(status, email, lists, segmentId, tags, updatedAfter, updatedBefore, createdAfter, createdBefore, optoutAfter, optoutBefore, include, smsStatus, includeCount, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAllContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Contacts Collection
    ApiResponse<GetAllContacts200Response> response = apiInstance.GetAllContactsWithHttpInfo(status, email, lists, segmentId, tags, updatedAfter, updatedBefore, createdAfter, createdBefore, optoutAfter, optoutBefore, include, smsStatus, includeCount, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetAllContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string?** | Use the &#x60;status&#x60; query parameter to search for contacts by status. This parameter accepts one or more comma separated values: &#x60;all&#x60;, &#x60;active&#x60;, &#x60;deleted&#x60;, &#x60;not_set&#x60;, &#x60;pending_confirmation&#x60;, &#x60;temp_hold&#x60;, and &#x60;unsubscribed&#x60;. | [optional]  |
| **email** | **string?** | Use the &#x60;email&#x60; query parameter to search for a contact using a specific email address. | [optional]  |
| **lists** | **string?** | Use the &#x60;lists&#x60; query parameter to search for contacts that are members of one or more specified lists. Use a comma to separate multiple &#x60;list_id&#x60; values, up to a maximum of 25. | [optional]  |
| **segmentId** | **string?** | Use to get contacts that meet the segment criteria for a single specified &#x60;segment_id&#x60;. This query parameter can only be combined with the limit query parameter. When using the &#x60;segment_id&#x60; query parameter, the V3 API may return a 202 response code instead of a 200 response. The 202 response code indicates that your request has been accepted, but not fully completed. Retry sending your API request to return the completed results and a 200 response code. | [optional]  |
| **tags** | **Guid?** | Use to get contact details for up to 50 specified tags. Use a comma to separate each &#x60;tag_id&#x60;. | [optional]  |
| **updatedAfter** | **DateTime?** | Use &#x60;updated_after&#x60; to search for contacts that have been updated after the date you specify. To search for updated contacts within a date range, specify both &#x60;updated_after&#x60; and &#x60;updated_before&#x60; dates. Accepts ISO-8601 formatted dates. | [optional]  |
| **updatedBefore** | **DateTime?** | Use &#x60;updated_before&#x60; to search for contacts that have been updated before a specified date. To search for updated contacts within a date range, specify both &#x60;updated_after&#x60; and &#x60;updated_before&#x60; dates. Accepts ISO-8601 formatted dates. | [optional]  |
| **createdAfter** | **DateTime?** | Use &#x60;created_after&#x60; to search for contacts created after a specified date. To search for contacts created within a date range, specify both &#x60;created_after&#x60; and &#x60;created_before&#x60; dates. Accepts ISO-8601 formatted dates. | [optional]  |
| **createdBefore** | **DateTime?** | Use &#x60;created_before&#x60; to search for contacts created before a specified date. To search for contacts created within a date range, specify both &#x60;created_after&#x60; and &#x60;created_before&#x60; dates. Accepts ISO-8601 formatted dates. | [optional]  |
| **optoutAfter** | **DateTime?** | Use &#x60;optout_after&#x60; to search for contacts that unsubscribed after a specified date. | [optional]  |
| **optoutBefore** | **DateTime?** | Use &#x60;optout_before&#x60; to search for contacts that unsubscribed before a specified date. | [optional]  |
| **include** | **string?** | Use &#x60;include&#x60; to specify which contact sub-resources to include in the response. Use a comma to separate multiple sub-resources. Valid values: &#x60;custom_fields&#x60;, &#x60;list_memberships&#x60;, &#x60;taggings&#x60;, &#x60;notes&#x60;,&#x60;phone_numbers&#x60;, &#x60;street_addresses&#x60;. | [optional]  |
| **smsStatus** | **string?** | Use to get contacts by their SMS status. This parameter accepts one or more comma separated values: &#x60;all&#x60;, &#x60;explicit&#x60;, &#x60;unsubscribed&#x60;, &#x60;pending_confirmation&#x60;, &#x60;not_set&#x60;. | [optional]  |
| **includeCount** | **bool?** | Set &#x60;include_count&#x3D;true&#x60; to include the total number of contacts (&#x60;contacts_count&#x60;) that meet all search criteria in the response body. | [optional]  |
| **limit** | **int?** | Specifies the number of results displayed per page of output in the response, from 1 - 500, default &#x3D; 50. | [optional] [default to 50] |

### Return type

[**GetAllContacts200Response**](GetAllContacts200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful |  -  |
| **202** | Accepted |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactbyid"></a>
# **GetContactById**
> GetContactById200Response GetContactById (string contactId, string? include = null)

GET a Contact

This endpoint GETs a specific contact resource (contact_id). Use the `include` query parameter to add any of the available contact sub-resources to the response payload.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var contactId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | Unique ID of contact to GET
            var include = custom_fields,list_memberships;  // string? | Use `include` to specify which contact sub-resources to include in the response. Use a comma to separate multiple sub-resources. Valid values: `custom_fields`, `list_memberships`, `phone_numbers`, `street_addresses`, `notes`, and `taggings`. (optional) 

            try
            {
                // GET a Contact
                GetContactById200Response result = apiInstance.GetContactById(contactId, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Contact
    ApiResponse<GetContactById200Response> response = apiInstance.GetContactByIdWithHttpInfo(contactId, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | Unique ID of contact to GET |  |
| **include** | **string?** | Use &#x60;include&#x60; to specify which contact sub-resources to include in the response. Use a comma to separate multiple sub-resources. Valid values: &#x60;custom_fields&#x60;, &#x60;list_memberships&#x60;, &#x60;phone_numbers&#x60;, &#x60;street_addresses&#x60;, &#x60;notes&#x60;, and &#x60;taggings&#x60;. | [optional]  |

### Return type

[**GetContactById200Response**](GetContactById200Response.md)

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
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactcounts"></a>
# **GetContactCounts**
> GetContactCounts200Response GetContactCounts (string? include = null)

GET Contact Consent Counts

Use to get the total contacts count for the account and the total contact-consent counts for each consent state. Optionally, to include the total number of contacts that subscribed within the last 30 days in the results, use `new_subscribers` in the `include` query parameter. To optimize open rates, reduce spam reports, and help grow your business,  you must value your contact's consent to receive or to not receive your emails.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactCountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var include = new_subscriber;  // string? | Use to return the total number of contacts that subscribed within the last 30 days in the results. (optional) 

            try
            {
                // GET Contact Consent Counts
                GetContactCounts200Response result = apiInstance.GetContactCounts(include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactCounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactCountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Contact Consent Counts
    ApiResponse<GetContactCounts200Response> response = apiInstance.GetContactCountsWithHttpInfo(include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactCountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **include** | **string?** | Use to return the total number of contacts that subscribed within the last 30 days in the results. | [optional]  |

### Return type

[**GetContactCounts200Response**](GetContactCounts200Response.md)

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
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactidxrefs"></a>
# **GetContactIdXrefs**
> GetContactIdXrefs200Response GetContactIdXrefs (string sequenceIds)

GET a collection of V2 and V3 API contact IDs

<div class=\"Msg Msg- -warning\"><p class=\"note-text\">Use this endpoint to migrate your locally stored V2 contact ids to the new V3 format. Developers are expected to use this endpoint sparingly. This endpoint is NOT intended for regular or repeated use. Constant Contact will eventually deprecate and remove this endpoint.</p></div>  This GET call retrieves a collection of cross-referenced contact sequence IDs (`id` used in the V2 API) and UUIDs (`contact_id` used in the V3 API). This endpoint is intended for developers who have an existing V2 API integration, and are migrating their users to a new V3 API integration. The V2 and V3 APIs use different resource ID formats. Use the `sequence_ids` query parameter to specify a set of comma delimited V2 contacts ids to cross-referenced with their V3 `contact_ids`. See [Migrating to V3](/api_guide/migration_overview.html) to learn more.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactIdXrefsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var sequenceIds = 1995998026,1882999944,1775099999;  // string | Comma delimited list of V2 API contact `ids` to cross-reference with the V3 API `contact_id` value. Endpoint accepts a maximum of 500 ids at a time.

            try
            {
                // GET a collection of V2 and V3 API contact IDs
                GetContactIdXrefs200Response result = apiInstance.GetContactIdXrefs(sequenceIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactIdXrefs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactIdXrefsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a collection of V2 and V3 API contact IDs
    ApiResponse<GetContactIdXrefs200Response> response = apiInstance.GetContactIdXrefsWithHttpInfo(sequenceIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetContactIdXrefsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sequenceIds** | **string** | Comma delimited list of V2 API contact &#x60;ids&#x60; to cross-reference with the V3 API &#x60;contact_id&#x60; value. Endpoint accepts a maximum of 500 ids at a time. |  |

### Return type

[**GetContactIdXrefs200Response**](GetContactIdXrefs200Response.md)

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
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsmsengagementhistory"></a>
# **GetSmsEngagementHistory**
> List&lt;GetSmsEngagementHistory200ResponseInner&gt; GetSmsEngagementHistory (string contactId)

GET SMS Engagement History for a Contact

Use this method to return SMS engagement details for a contact, such as SMS consent and advertising frequency details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetSmsEngagementHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var contactId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | The contact's unique ID.

            try
            {
                // GET SMS Engagement History for a Contact
                List<GetSmsEngagementHistory200ResponseInner> result = apiInstance.GetSmsEngagementHistory(contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.GetSmsEngagementHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsEngagementHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET SMS Engagement History for a Contact
    ApiResponse<List<GetSmsEngagementHistory200ResponseInner>> response = apiInstance.GetSmsEngagementHistoryWithHttpInfo(contactId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.GetSmsEngagementHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | The contact&#39;s unique ID. |  |

### Return type

[**List&lt;GetSmsEngagementHistory200ResponseInner&gt;**](GetSmsEngagementHistory200ResponseInner.md)

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
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resubscribecontact"></a>
# **ResubscribeContact**
> void ResubscribeContact (string contactId, ResubscribeContactRequest resubscribeContactRequest)

PUT Resubscribe a Contact

Use this endpoint to send a confirmation resubscribe email to a contact in order to get their confirmation to resubscribe. This endpoint also adds the resubscribed contact to the contact lists you specify in the request body. You can only send a resubscribe email to the unsubscribed contact once. The contact is not resubscribed until after you receive their confirmation. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class ResubscribeContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var contactId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | The ID that uniquely identifies the contact to resubscribe.
            var resubscribeContactRequest = new ResubscribeContactRequest(); // ResubscribeContactRequest | The JSON payload used to specify one (or more) contact lists to which the contact requested to be resubscribed.

            try
            {
                // PUT Resubscribe a Contact
                apiInstance.ResubscribeContact(contactId, resubscribeContactRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.ResubscribeContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResubscribeContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT Resubscribe a Contact
    apiInstance.ResubscribeContactWithHttpInfo(contactId, resubscribeContactRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.ResubscribeContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | The ID that uniquely identifies the contact to resubscribe. |  |
| **resubscribeContactRequest** | [**ResubscribeContactRequest**](ResubscribeContactRequest.md) | The JSON payload used to specify one (or more) contact lists to which the contact requested to be resubscribed. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact resource has been updated. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontact"></a>
# **UpdateContact**
> GetContactById200Response UpdateContact (string contactId, UpdateContactRequest updateContactRequest)

PUT (update) a Contact

The PUT method updates an existing contact. You must include the `update_source` property in the PUT request payload. To restore  a deleted contact you must specify the `update_source` as `Account`. When updating any resource using PUT, all properties are updated, overwriting all previous values. Any properties left blank or not included in the request are overwritten with null value - however this does not apply to contact subresources.   Add or change any of the subresources by including them in the PUT request payload. Omitted subresources are not overwritten with null. If the contact being updated is deleted, the contact will be revived. If `email_address` is specified: <div class=\"Msg\"><p class=\"note-text\"> **Only use this method when a contact gives you their explicit permission to send them an email. It is a violation of anti-spam and telemarketing laws, as well as a serious violation of the Constant Contact Terms of Service to use the Opt-in features of the API to opt a contact back in without his or her own action and consent.</p></div>  If `sms_channel` is specified: <div class=\"Msg\"><p class=\"note-text\">Only use this method when a contact gives you their explicit permission to send them an SMS. It is a violation of anti-spam and telemarketing laws, as well as a serious violation of the Constant Contact Terms of Service to use the Opt-in features of the API to opt a contact back in without his or her own action and consent.</p></div>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi(config);
            var contactId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | Unique ID of contact to update
            var updateContactRequest = new UpdateContactRequest(); // UpdateContactRequest | JSON payload defining the contact object, with updates. Any properties left blank or not included in the PUT payload are overwritten with null value - does not apply to contact subresources.

            try
            {
                // PUT (update) a Contact
                GetContactById200Response result = apiInstance.UpdateContact(contactId, updateContactRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (update) a Contact
    ApiResponse<GetContactById200Response> response = apiInstance.UpdateContactWithHttpInfo(contactId, updateContactRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsApi.UpdateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | Unique ID of contact to update |  |
| **updateContactRequest** | [**UpdateContactRequest**](UpdateContactRequest.md) | JSON payload defining the contact object, with updates. Any properties left blank or not included in the PUT payload are overwritten with null value - does not apply to contact subresources. |  |

### Return type

[**GetContactById200Response**](GetContactById200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact resource has been updated |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

