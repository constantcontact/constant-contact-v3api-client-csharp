# ConstantContactApi.Api.SocialApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSocialPost**](SocialApi.md#createsocialpost) | **POST** /social/posts | POST (create) a social media post |
| [**GetHashtagGroups**](SocialApi.md#gethashtaggroups) | **GET** /social/hashtags/groups | GET hashtag groups |
| [**GetSocialConnections**](SocialApi.md#getsocialconnections) | **GET** /social/connections | GET social network connections |
| [**GetSocialProfiles**](SocialApi.md#getsocialprofiles) | **GET** /social/profiles | GET social media profiles |

<a id="createsocialpost"></a>
# **CreateSocialPost**
> CreateSocialPost200Response CreateSocialPost (CreateSocialPostRequest createSocialPostRequest)

POST (create) a social media post

Creates a new social media post that can be published immediately or scheduled for later publication. A post can target one or more social profiles, and can include text, images, and network-specific settings.  Set `status` to `DRAFT` to save without publishing, or `SCHEDULED` to schedule for publication. Scheduled posts require a `scheduled_time` in ISO-8601 format.  Post content and settings can vary per profile — each `profile_posts` entry can have its own text, images, and network-specific settings (e.g., TikTok-specific settings like `disable_comment`). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateSocialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var createSocialPostRequest = new CreateSocialPostRequest(); // CreateSocialPostRequest | The social post content and configuration.

            try
            {
                // POST (create) a social media post
                CreateSocialPost200Response result = apiInstance.CreateSocialPost(createSocialPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.CreateSocialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSocialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (create) a social media post
    ApiResponse<CreateSocialPost200Response> response = apiInstance.CreateSocialPostWithHttpInfo(createSocialPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.CreateSocialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSocialPostRequest** | [**CreateSocialPostRequest**](CreateSocialPostRequest.md) | The social post content and configuration. |  |

### Return type

[**CreateSocialPost200Response**](CreateSocialPost200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Post created successfully |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethashtaggroups"></a>
# **GetHashtagGroups**
> GetHashtagGroups200Response GetHashtagGroups (int? limit = null, int? page = null)

GET hashtag groups

Retrieves a paginated list of saved hashtag groups for the account. Hashtag groups allow users to save and organize reusable collections of hashtags that can be applied to social posts.  Use the `limit` and `page` query parameters to paginate through results. Navigate to the next page using the `_links.next` link in the response. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetHashtagGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var limit = 5;  // int? | Maximum number of hashtag groups to retrieve per page. Default and maximum is `5`. (optional)  (default to 5)
            var page = 0;  // int? | Page number to retrieve (0-based). (optional)  (default to 0)

            try
            {
                // GET hashtag groups
                GetHashtagGroups200Response result = apiInstance.GetHashtagGroups(limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.GetHashtagGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHashtagGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET hashtag groups
    ApiResponse<GetHashtagGroups200Response> response = apiInstance.GetHashtagGroupsWithHttpInfo(limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.GetHashtagGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Maximum number of hashtag groups to retrieve per page. Default and maximum is &#x60;5&#x60;. | [optional] [default to 5] |
| **page** | **int?** | Page number to retrieve (0-based). | [optional] [default to 0] |

### Return type

[**GetHashtagGroups200Response**](GetHashtagGroups200Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsocialconnections"></a>
# **GetSocialConnections**
> GetSocialConnections200Response GetSocialConnections ()

GET social network connections

Retrieves all social network accounts connected to the Constant Contact account, with support for multiple accounts per social network.  A connection represents the authorization link between a Constant Contact account and a single account on a social network (Facebook, Instagram, LinkedIn, TikTok, etc.). Each connection includes account information about the connected user on that network (display name, username, image, etc.) and the current status of the connection (whether it's active, rate-limited, or has any errors).  Note that a single connection may have multiple profiles (pages) associated with it — use `GET /social/profiles` to retrieve the individual profiles. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetSocialConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);

            try
            {
                // GET social network connections
                GetSocialConnections200Response result = apiInstance.GetSocialConnections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.GetSocialConnections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSocialConnectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET social network connections
    ApiResponse<GetSocialConnections200Response> response = apiInstance.GetSocialConnectionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.GetSocialConnectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetSocialConnections200Response**](GetSocialConnections200Response.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsocialprofiles"></a>
# **GetSocialProfiles**
> List&lt;GetSocialProfiles200ResponseInner&gt; GetSocialProfiles (List<string>? include = null)

GET social media profiles

Retrieves all social media profiles connected to the account. A profile represents a single account on a social network (such as a Facebook Business Page, a LinkedIn Company Page, or an Instagram Business account) that the user has connected to Constant Contact.  Use the `include=accessible` query parameter to additionally check whether each profile is currently accessible for posting. Profiles that are not currently accessible will fail if used to publish a post. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetSocialProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi(config);
            var include = new List<string>?(); // List<string>? | Optional sub-resources to include. Use `accessible` to check if profiles are accessible on the network. (optional) 

            try
            {
                // GET social media profiles
                List<GetSocialProfiles200ResponseInner> result = apiInstance.GetSocialProfiles(include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SocialApi.GetSocialProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSocialProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET social media profiles
    ApiResponse<List<GetSocialProfiles200ResponseInner>> response = apiInstance.GetSocialProfilesWithHttpInfo(include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SocialApi.GetSocialProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **include** | [**List&lt;string&gt;?**](string.md) | Optional sub-resources to include. Use &#x60;accessible&#x60; to check if profiles are accessible on the network. | [optional]  |

### Return type

[**List&lt;GetSocialProfiles200ResponseInner&gt;**](GetSocialProfiles200ResponseInner.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

