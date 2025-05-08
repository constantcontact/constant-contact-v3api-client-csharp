# ConstantContactApi.Api.ContactsCustomFieldsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomFields**](ContactsCustomFieldsApi.md#createcustomfields) | **POST** /contact_custom_fields | POST (create) a custom_field |
| [**DeleteCustomField**](ContactsCustomFieldsApi.md#deletecustomfield) | **DELETE** /contact_custom_fields/{custom_field_id} | DELETE a custom_field |
| [**GetAllCustomFields**](ContactsCustomFieldsApi.md#getallcustomfields) | **GET** /contact_custom_fields | GET custom_fields Collection |
| [**GetCustomField**](ContactsCustomFieldsApi.md#getcustomfield) | **GET** /contact_custom_fields/{custom_field_id} | GET a custom_field |
| [**UpdateCustomField**](ContactsCustomFieldsApi.md#updatecustomfield) | **PUT** /contact_custom_fields/{custom_field_id} | PUT (update) a custom_field |

<a id="createcustomfields"></a>
# **CreateCustomFields**
> GetCustomField200Response CreateCustomFields (UpdateCustomFieldRequest updateCustomFieldRequest)

POST (create) a custom_field

This POST request adds a new `custom_field` to the user's account. A user can configure up to 100 `custom_fields` in their account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateCustomFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsCustomFieldsApi(config);
            var updateCustomFieldRequest = new UpdateCustomFieldRequest(); // UpdateCustomFieldRequest | The JSON payload required to create a new `custom_field`

            try
            {
                // POST (create) a custom_field
                GetCustomField200Response result = apiInstance.CreateCustomFields(updateCustomFieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsCustomFieldsApi.CreateCustomFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (create) a custom_field
    ApiResponse<GetCustomField200Response> response = apiInstance.CreateCustomFieldsWithHttpInfo(updateCustomFieldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsCustomFieldsApi.CreateCustomFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateCustomFieldRequest** | [**UpdateCustomFieldRequest**](UpdateCustomFieldRequest.md) | The JSON payload required to create a new &#x60;custom_field&#x60; |  |

### Return type

[**GetCustomField200Response**](GetCustomField200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | New custom_field successfully created |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type; the payload must be in JSON format, and Content-Type must be application/json. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomfield"></a>
# **DeleteCustomField**
> void DeleteCustomField (string customFieldId)

DELETE a custom_field

This DELETE request deletes a custom_field from the user's account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsCustomFieldsApi(config);
            var customFieldId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | Unique ID of the custom_field on which to operate.

            try
            {
                // DELETE a custom_field
                apiInstance.DeleteCustomField(customFieldId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsCustomFieldsApi.DeleteCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE a custom_field
    apiInstance.DeleteCustomFieldWithHttpInfo(customFieldId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsCustomFieldsApi.DeleteCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customFieldId** | **string** | Unique ID of the custom_field on which to operate. |  |

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
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallcustomfields"></a>
# **GetAllCustomFields**
> GetAllCustomFields200Response GetAllCustomFields (int? limit = null)

GET custom_fields Collection

This GET request returns all `custom_fields` defined in the user's account. <div class=\"Msg\"><p class=\"note-text\">This method does not currently support filtering results using the custom field update date.</p></div>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllCustomFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsCustomFieldsApi(config);
            var limit = 50;  // int? | Specifies the number of results displayed per page of output, from 1 - 100, default = 50. (optional)  (default to 50)

            try
            {
                // GET custom_fields Collection
                GetAllCustomFields200Response result = apiInstance.GetAllCustomFields(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsCustomFieldsApi.GetAllCustomFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllCustomFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET custom_fields Collection
    ApiResponse<GetAllCustomFields200Response> response = apiInstance.GetAllCustomFieldsWithHttpInfo(limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsCustomFieldsApi.GetAllCustomFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Specifies the number of results displayed per page of output, from 1 - 100, default &#x3D; 50. | [optional] [default to 50] |

### Return type

[**GetAllCustomFields200Response**](GetAllCustomFields200Response.md)

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

<a id="getcustomfield"></a>
# **GetCustomField**
> GetCustomField200Response GetCustomField (string customFieldId)

GET a custom_field

This GET call retrieves a `custom_field` resource, specified by `custom_field_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsCustomFieldsApi(config);
            var customFieldId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | Unique ID of the `custom_field` on which to operate.

            try
            {
                // GET a custom_field
                GetCustomField200Response result = apiInstance.GetCustomField(customFieldId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsCustomFieldsApi.GetCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a custom_field
    ApiResponse<GetCustomField200Response> response = apiInstance.GetCustomFieldWithHttpInfo(customFieldId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsCustomFieldsApi.GetCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customFieldId** | **string** | Unique ID of the &#x60;custom_field&#x60; on which to operate. |  |

### Return type

[**GetCustomField200Response**](GetCustomField200Response.md)

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

<a id="updatecustomfield"></a>
# **UpdateCustomField**
> GetCustomField200Response UpdateCustomField (string customFieldId, UpdateCustomFieldRequest updateCustomFieldRequest)

PUT (update) a custom_field

This PUT request updates an existing `custom_field` object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsCustomFieldsApi(config);
            var customFieldId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | Unique ID of the `custom_field` on which to operate.
            var updateCustomFieldRequest = new UpdateCustomFieldRequest(); // UpdateCustomFieldRequest | The JSON payload used to update an existing custom field. Any properties omitted in the PUT request are overwritten with a null value.

            try
            {
                // PUT (update) a custom_field
                GetCustomField200Response result = apiInstance.UpdateCustomField(customFieldId, updateCustomFieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsCustomFieldsApi.UpdateCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (update) a custom_field
    ApiResponse<GetCustomField200Response> response = apiInstance.UpdateCustomFieldWithHttpInfo(customFieldId, updateCustomFieldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsCustomFieldsApi.UpdateCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customFieldId** | **string** | Unique ID of the &#x60;custom_field&#x60; on which to operate. |  |
| **updateCustomFieldRequest** | [**UpdateCustomFieldRequest**](UpdateCustomFieldRequest.md) | The JSON payload used to update an existing custom field. Any properties omitted in the PUT request are overwritten with a null value. |  |

### Return type

[**GetCustomField200Response**](GetCustomField200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success - custom_field updated |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

