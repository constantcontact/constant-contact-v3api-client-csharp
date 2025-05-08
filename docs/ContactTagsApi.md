# ConstantContactApi.Api.ContactTagsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteTag**](ContactTagsApi.md#deletetag) | **DELETE** /contact_tags/{tag_id} | DELETE a Tag |
| [**GetAllTags**](ContactTagsApi.md#getalltags) | **GET** /contact_tags | GET Details for All Tags |
| [**GetTag**](ContactTagsApi.md#gettag) | **GET** /contact_tags/{tag_id} | GET Tag Details |
| [**PostTag**](ContactTagsApi.md#posttag) | **POST** /contact_tags | POST (Create) a Tag |
| [**PutTag**](ContactTagsApi.md#puttag) | **PUT** /contact_tags/{tag_id} | PUT (Update) a Tag |

<a id="deletetag"></a>
# **DeleteTag**
> DeleteTag202Response DeleteTag (Guid tagId)

DELETE a Tag

Use this method to create an activity used to un-assign a tag from all assigned contacts and delete the tag. This is an asynchronous activity. To view activity details for the delete request, use the href link returned in the response. [Learn more](/api_guide/tags_delete.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactTagsApi(config);
            var tagId = 30c97dd0-332e-11eb-923c-fa163e595327;  // Guid | The ID that uniquely identifies a tag in UUID format.

            try
            {
                // DELETE a Tag
                DeleteTag202Response result = apiInstance.DeleteTag(tagId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactTagsApi.DeleteTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE a Tag
    ApiResponse<DeleteTag202Response> response = apiInstance.DeleteTagWithHttpInfo(tagId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactTagsApi.DeleteTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagId** | **Guid** | The ID that uniquely identifies a tag in UUID format. |  |

### Return type

[**DeleteTag202Response**](DeleteTag202Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The asynchronous request was successfully accepted. To view the results of the activity request, use the href link returned in the response. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **406** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltags"></a>
# **GetAllTags**
> GetAllTags200Response GetAllTags (int? limit = null, bool? includeCount = null)

GET Details for All Tags

Use this endpoint to get details for all tags in your account. Use the <code>include_count</code> query parameter to include the total number of contacts assigned each tag. Use the <code>limit</code> query parameter to limit the number of tag results returned per page. To get the next page of results, copy the <code>cursor={the cursor ID}</code> from the resulting href link and add it (<code>&</code>) to the URL. For example:  <p><code>/v3/contact_tags?limit=1&cursor=</code></p><p><code>bGltaXQ9MSZuZXh0PTJjZDgwMjdhLTc4YzAtMTFlOS1iZmQwLWZhMTYzZTZiMDFjMQ=</code></p> To learn more, see [Get Tags](/api_guide/tags_get.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactTagsApi(config);
            var limit = 25;  // int? | Use to specify the number of tag results (up to `500`) to display per page of output. The default is `50`. (optional)  (default to 50)
            var includeCount = true;  // bool? | Returns the total number of contacts (`contacts_count`) to which a tag applies. (optional)  (default to false)

            try
            {
                // GET Details for All Tags
                GetAllTags200Response result = apiInstance.GetAllTags(limit, includeCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactTagsApi.GetAllTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Details for All Tags
    ApiResponse<GetAllTags200Response> response = apiInstance.GetAllTagsWithHttpInfo(limit, includeCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactTagsApi.GetAllTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Use to specify the number of tag results (up to &#x60;500&#x60;) to display per page of output. The default is &#x60;50&#x60;. | [optional] [default to 50] |
| **includeCount** | **bool?** | Returns the total number of contacts (&#x60;contacts_count&#x60;) to which a tag applies. | [optional] [default to false] |

### Return type

[**GetAllTags200Response**](GetAllTags200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request Successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettag"></a>
# **GetTag**
> GetTag200Response GetTag (Guid tagId, bool? includeCount = null)

GET Tag Details

Use this method to get tag details for a specified `tag_id`. Use the `include_count` query parameter to include or exclude the total number of contacts to which this tag is assigned. To learn more, see  [Get a Tag's Details](/api_guide/tags_get_single.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactTagsApi(config);
            var tagId = d938260a-af1e-11e9-a540-fa163e595123;  // Guid | The ID that uniquely identifies a tag (UUID format).
            var includeCount = true;  // bool? | Use to include (`true`) or exclude (`false`) the total number of tagged contacts (`contacts_count`) from the results. (optional)  (default to false)

            try
            {
                // GET Tag Details
                GetTag200Response result = apiInstance.GetTag(tagId, includeCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactTagsApi.GetTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Tag Details
    ApiResponse<GetTag200Response> response = apiInstance.GetTagWithHttpInfo(tagId, includeCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactTagsApi.GetTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagId** | **Guid** | The ID that uniquely identifies a tag (UUID format). |  |
| **includeCount** | **bool?** | Use to include (&#x60;true&#x60;) or exclude (&#x60;false&#x60;) the total number of tagged contacts (&#x60;contacts_count&#x60;) from the results. | [optional] [default to false] |

### Return type

[**GetTag200Response**](GetTag200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request Successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="posttag"></a>
# **PostTag**
> GetTag200Response PostTag (PostTagRequest postTagRequest)

POST (Create) a Tag

Use this method to create a new tag. The tag `name` is required and must be unique and can include most common keyboard symbols. Optionally, when creating a new tag you can specify the source (`tag_source`) used to identify the contacts to tag in the request body. [Learn more](/api_guide/tags_create.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class PostTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactTagsApi(config);
            var postTagRequest = new PostTagRequest(); // PostTagRequest | The JSON payload to use to create a new tag.

            try
            {
                // POST (Create) a Tag
                GetTag200Response result = apiInstance.PostTag(postTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactTagsApi.PostTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (Create) a Tag
    ApiResponse<GetTag200Response> response = apiInstance.PostTagWithHttpInfo(postTagRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactTagsApi.PostTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postTagRequest** | [**PostTagRequest**](PostTagRequest.md) | The JSON payload to use to create a new tag. |  |

### Return type

[**GetTag200Response**](GetTag200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request Successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="puttag"></a>
# **PutTag**
> GetTag200Response PutTag (Guid tagId, PutTagRequest putTagRequest)

PUT (Update) a Tag

Use this method to rename an existing tag to a new unique tag name (`name`). The maximum length is 255 characters. The `tag_source` value cannot be updated using this method. You can set the `tag_source` value using the `POST contact_tags method`. [Learn more](/api_guide/tags_update.html)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class PutTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactTagsApi(config);
            var tagId = 30c97dd0-332e-11eb-923c-fa163e595327;  // Guid | The system generated ID used to uniquely identify the tag that you want to rename (UUID format).
            var putTagRequest = new PutTagRequest(); // PutTagRequest | The JSON payload used to update the tag name (`name`).

            try
            {
                // PUT (Update) a Tag
                GetTag200Response result = apiInstance.PutTag(tagId, putTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactTagsApi.PutTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (Update) a Tag
    ApiResponse<GetTag200Response> response = apiInstance.PutTagWithHttpInfo(tagId, putTagRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactTagsApi.PutTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagId** | **Guid** | The system generated ID used to uniquely identify the tag that you want to rename (UUID format). |  |
| **putTagRequest** | [**PutTagRequest**](PutTagRequest.md) | The JSON payload used to update the tag name (&#x60;name&#x60;). |  |

### Return type

[**GetTag200Response**](GetTag200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request Successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

