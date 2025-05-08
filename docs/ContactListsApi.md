# ConstantContactApi.Api.ContactListsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateList**](ContactListsApi.md#createlist) | **POST** /contact_lists | POST (create) a List |
| [**DeleteList**](ContactListsApi.md#deletelist) | **DELETE** /contact_lists/{list_id} | DELETE a List |
| [**GetAllLists**](ContactListsApi.md#getalllists) | **GET** /contact_lists | GET Lists Collection |
| [**GetList**](ContactListsApi.md#getlist) | **GET** /contact_lists/{list_id} | GET a List |
| [**GetListIdXrefs**](ContactListsApi.md#getlistidxrefs) | **GET** /contact_lists/list_id_xrefs | GET a collection of V2 and V3 API List IDs |
| [**UpdateList**](ContactListsApi.md#updatelist) | **PUT** /contact_lists/{list_id} | PUT (update) a List |

<a id="createlist"></a>
# **CreateList**
> UpdateList200Response CreateList (UpdateListRequest updateListRequest)

POST (create) a List

Create a new contact list resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactListsApi(config);
            var updateListRequest = new UpdateListRequest(); // UpdateListRequest | JSON payload defining the new contact list

            try
            {
                // POST (create) a List
                UpdateList200Response result = apiInstance.CreateList(updateListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactListsApi.CreateList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (create) a List
    ApiResponse<UpdateList200Response> response = apiInstance.CreateListWithHttpInfo(updateListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactListsApi.CreateListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateListRequest** | [**UpdateListRequest**](UpdateListRequest.md) | JSON payload defining the new contact list |  |

### Return type

[**UpdateList200Response**](UpdateList200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | New list successfully created |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelist"></a>
# **DeleteList**
> DeleteList202Response DeleteList (Guid listId)

DELETE a List

Deletes the specified contact list and its membership. DELETE List requests are processed asynchronously, and you can track the status of the request by making a GET call to the URI shown in the `_links` property in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactListsApi(config);
            var listId = cbc05bac-6a41-46fa-a063-79961763bf4b;  // Guid | Unique ID of the list to delete

            try
            {
                // DELETE a List
                DeleteList202Response result = apiInstance.DeleteList(listId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactListsApi.DeleteList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE a List
    ApiResponse<DeleteList202Response> response = apiInstance.DeleteListWithHttpInfo(listId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactListsApi.DeleteListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | Unique ID of the list to delete |  |

### Return type

[**DeleteList202Response**](DeleteList202Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  * Location - URL to retrieve the delete activity status <br>  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalllists"></a>
# **GetAllLists**
> GetAllLists200Response GetAllLists (int? limit = null, bool? includeCount = null, string? includeMembershipCount = null, string? name = null, string? status = null)

GET Lists Collection

Use this method to return details about all contact lists for the account. <div class=\"Msg\"><p class=\"note-text\">This method does not currently support filtering results using the contact list update date.</p></div>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactListsApi(config);
            var limit = 50;  // int? | Use to specify the number of results displayed per page of output, from 1 - 500, default = 50. (optional)  (default to 50)
            var includeCount = true;  // bool? | Set `include_count` to `true` to return the total number of contact lists that meet your selection criteria. (optional)  (default to false)
            var includeMembershipCount = all;  // string? | Use to include the total number of contacts per list. Set to  `active`, to count only active (mailable) contacts, or `all` to count all contacts. (optional) 
            var name = TopTier;  // string? | Use to get details for a single list by entering the full name of the list. (optional) 
            var status = all;  // string? | Use to get lists by status. Accepts comma-separated status values. (optional) 

            try
            {
                // GET Lists Collection
                GetAllLists200Response result = apiInstance.GetAllLists(limit, includeCount, includeMembershipCount, name, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactListsApi.GetAllLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Lists Collection
    ApiResponse<GetAllLists200Response> response = apiInstance.GetAllListsWithHttpInfo(limit, includeCount, includeMembershipCount, name, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactListsApi.GetAllListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Use to specify the number of results displayed per page of output, from 1 - 500, default &#x3D; 50. | [optional] [default to 50] |
| **includeCount** | **bool?** | Set &#x60;include_count&#x60; to &#x60;true&#x60; to return the total number of contact lists that meet your selection criteria. | [optional] [default to false] |
| **includeMembershipCount** | **string?** | Use to include the total number of contacts per list. Set to  &#x60;active&#x60;, to count only active (mailable) contacts, or &#x60;all&#x60; to count all contacts. | [optional]  |
| **name** | **string?** | Use to get details for a single list by entering the full name of the list. | [optional]  |
| **status** | **string?** | Use to get lists by status. Accepts comma-separated status values. | [optional]  |

### Return type

[**GetAllLists200Response**](GetAllLists200Response.md)

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

<a id="getlist"></a>
# **GetList**
> GetList200Response GetList (Guid listId, string? includeMembershipCount = null)

GET a List

Use this method to get details about a specific contact list (`list_id`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactListsApi(config);
            var listId = cbc05bac-6a41-46fa-a063-79961763bf4b;  // Guid | The system generated ID that uniquely identifies a contact list.
            var includeMembershipCount = all;  // string? | Returns the total number of contacts per list that meet your selection criteria. Set the `include_membership_count` to `active`, to count only active contacts, or `all` to include all contacts in the count. (optional) 

            try
            {
                // GET a List
                GetList200Response result = apiInstance.GetList(listId, includeMembershipCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactListsApi.GetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a List
    ApiResponse<GetList200Response> response = apiInstance.GetListWithHttpInfo(listId, includeMembershipCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactListsApi.GetListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | The system generated ID that uniquely identifies a contact list. |  |
| **includeMembershipCount** | **string?** | Returns the total number of contacts per list that meet your selection criteria. Set the &#x60;include_membership_count&#x60; to &#x60;active&#x60;, to count only active contacts, or &#x60;all&#x60; to include all contacts in the count. | [optional]  |

### Return type

[**GetList200Response**](GetList200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlistidxrefs"></a>
# **GetListIdXrefs**
> GetListIdXrefs200Response GetListIdXrefs (string sequenceIds)

GET a collection of V2 and V3 API List IDs

<div class=\"Msg Msg- -warning\"><p class=\"note-text\">Use this endpoint to migrate your locally stored V2 contact list data to the new V3 format. Developers are expected to use this endpoint sparingly. This endpoint is NOT intended for regular or repeated use. Constant Contact will eventually deprecate and remove this endpoint.</p></div>  This GET call retrieves a collection of cross-referenced list sequence IDs (`id` used in the V2 API) and UUIDs (`list_id` used in the V3 API). This endpoint is intended for developers who have an existing V2 API integration, and are migrating their users to a new V3 API integration. The V2 and V3 APIs use different resource ID formats. Use the `sequence_ids` query parameter to specify a set of comma delimited V2 list ids to cross-reference. See [Migrating Apps and Data to V3](/api_guide/migration_overview.html) to learn more.\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetListIdXrefsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactListsApi(config);
            var sequenceIds = 1995998026,1882999944,1775099999;  // string | Comma delimited list of V2 API list `ids` to cross-reference with the V3 API `list_id` value. Endpoint accepts a maximum of 500 ids at a time.

            try
            {
                // GET a collection of V2 and V3 API List IDs
                GetListIdXrefs200Response result = apiInstance.GetListIdXrefs(sequenceIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactListsApi.GetListIdXrefs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListIdXrefsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a collection of V2 and V3 API List IDs
    ApiResponse<GetListIdXrefs200Response> response = apiInstance.GetListIdXrefsWithHttpInfo(sequenceIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactListsApi.GetListIdXrefsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sequenceIds** | **string** | Comma delimited list of V2 API list &#x60;ids&#x60; to cross-reference with the V3 API &#x60;list_id&#x60; value. Endpoint accepts a maximum of 500 ids at a time. |  |

### Return type

[**GetListIdXrefs200Response**](GetListIdXrefs200Response.md)

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

<a id="updatelist"></a>
# **UpdateList**
> UpdateList200Response UpdateList (Guid listId, UpdateListRequest updateListRequest)

PUT (update) a List

Updates an existing contact list resource, specified by `list_id`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactListsApi(config);
            var listId = cbc05bac-6a41-46fa-a063-79961763bf4b;  // Guid | Unique ID of the contact list to update
            var updateListRequest = new UpdateListRequest(); // UpdateListRequest | JSON payload containing updates to the specified contact list

            try
            {
                // PUT (update) a List
                UpdateList200Response result = apiInstance.UpdateList(listId, updateListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactListsApi.UpdateList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (update) a List
    ApiResponse<UpdateList200Response> response = apiInstance.UpdateListWithHttpInfo(listId, updateListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactListsApi.UpdateListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **Guid** | Unique ID of the contact list to update |  |
| **updateListRequest** | [**UpdateListRequest**](UpdateListRequest.md) | JSON payload containing updates to the specified contact list |  |

### Return type

[**UpdateList200Response**](UpdateList200Response.md)

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
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

