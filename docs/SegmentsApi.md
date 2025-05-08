# ConstantContactApi.Api.SegmentsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSegment**](SegmentsApi.md#createsegment) | **POST** /segments | POST (create) a Segment |
| [**DeleteSegment**](SegmentsApi.md#deletesegment) | **DELETE** /segments/{segment_id} | DELETE a Segment |
| [**GetAllSegments**](SegmentsApi.md#getallsegments) | **GET** /segments | GET all Segments |
| [**GetSegmentById**](SegmentsApi.md#getsegmentbyid) | **GET** /segments/{segment_id} | GET a Segment&#39;s Details |
| [**UpdateSegment**](SegmentsApi.md#updatesegment) | **PUT** /segments/{segment_id} | PUT (update) a Segment |
| [**UpdateSegmentName**](SegmentsApi.md#updatesegmentname) | **PATCH** /segments/{segment_id}/name | PATCH (rename) a Segment |

<a id="createsegment"></a>
# **CreateSegment**
> CreateSegment201Response CreateSegment (CreateSegmentRequest createSegmentRequest)

POST (create) a Segment

Use this method to create a new segment. You create segments to target a subset of your contacts that meet your specific criteria for a marketing campaign. The segment `name` must be unique. The `segment_criteria` requires single-string escaped JSON. Constant Contact uses the contact data that you specify in the `segment_criteria` to evaluate and identify the contacts you want to target. Contact data can be grouped from different data sources, including:    -  **`tracking`**: Supports **or** and **and** groups.     -  **`contact`**: Supports **or** and **and** groups.     -  **`list_membership`**: Supports **or** groups.    -  **`tags`**: Supports **or** groups.  If you do not specify `list_membership` as criteria, Constant Contact evaluates all contacts in your account. To avoid returning a 400 error response, when specifying the `segment_criteria` do not request more than 500 email campaigns or a date range greater than 1825 days (5 years) be evaluated.  For more use case information, see the [Segments Overview](/api_guide/segments_overview.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var createSegmentRequest = new CreateSegmentRequest(); // CreateSegmentRequest | The segment `name` and `segment_criteria` (requires single-string escaped JSON).

            try
            {
                // POST (create) a Segment
                CreateSegment201Response result = apiInstance.CreateSegment(createSegmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.CreateSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (create) a Segment
    ApiResponse<CreateSegment201Response> response = apiInstance.CreateSegmentWithHttpInfo(createSegmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.CreateSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSegmentRequest** | [**CreateSegmentRequest**](CreateSegmentRequest.md) | The segment &#x60;name&#x60; and &#x60;segment_criteria&#x60; (requires single-string escaped JSON). |  |

### Return type

[**CreateSegment201Response**](CreateSegment201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Segment successfully created. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesegment"></a>
# **DeleteSegment**
> void DeleteSegment (int segmentId)

DELETE a Segment

Use this method to delete a segment from your account. Before deleting a segment, verify that the segment is not associated with a scheduled campaign.  Deleted segments do not display in the results when using the `GET /segments` endpoint. If you know the `segment_id`, you can use the `GET /segments/{segment_id}` endpoint to view the deleted segment's details. A segment's details are preserved for external reference purposes, such as displaying the segment name in a campaign's history. For more use case information, see [Delete a Segment](/api_guide/segment_delete.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var segmentId = 14;  // int | The system generated ID that uniquely identifies the segment.

            try
            {
                // DELETE a Segment
                apiInstance.DeleteSegment(segmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.DeleteSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE a Segment
    apiInstance.DeleteSegmentWithHttpInfo(segmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.DeleteSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **segmentId** | **int** | The system generated ID that uniquely identifies the segment. |  |

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
| **204** | The segment was successfully deleted. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallsegments"></a>
# **GetAllSegments**
> GetAllSegments200Response GetAllSegments (string? limit = null, string? sortBy = null)

GET all Segments

Use this method to get a list of all segments associated with the account. You can sort segment results and limit the number of segments that display per page. Deleted segments are excluded from the results. For more use case information, see [Get All Segments](/api_guide/segment_get_all.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllSegmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var limit = 1000;  // string? | The number of segments to return on a page. (optional)  (default to "1000")
            var sortBy = sort_by=date;  // string? | Specify the segment sort order to use. Sort by name (`sort_by=name`) in ascending order, or sort by date (`sort_by=date`) in descending order with the most recently updated segments listed first. (optional)  (default to "date")

            try
            {
                // GET all Segments
                GetAllSegments200Response result = apiInstance.GetAllSegments(limit, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetAllSegments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllSegmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET all Segments
    ApiResponse<GetAllSegments200Response> response = apiInstance.GetAllSegmentsWithHttpInfo(limit, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.GetAllSegmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **string?** | The number of segments to return on a page. | [optional] [default to &quot;1000&quot;] |
| **sortBy** | **string?** | Specify the segment sort order to use. Sort by name (&#x60;sort_by&#x3D;name&#x60;) in ascending order, or sort by date (&#x60;sort_by&#x3D;date&#x60;) in descending order with the most recently updated segments listed first. | [optional] [default to &quot;date&quot;] |

### Return type

[**GetAllSegments200Response**](GetAllSegments200Response.md)

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
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsegmentbyid"></a>
# **GetSegmentById**
> CreateSegment201Response GetSegmentById (int segmentId)

GET a Segment's Details

Use this method to get details about a segment, including the segment criteria. If you know the `segment_id` You can also use this method to get details about a deleted segment. For more use case information, see [Get a Segment's Details](/api_guide/segment_get.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetSegmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var segmentId = 14;  // int | The system-generated unique ID that identifies a segment.

            try
            {
                // GET a Segment's Details
                CreateSegment201Response result = apiInstance.GetSegmentById(segmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.GetSegmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSegmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Segment's Details
    ApiResponse<CreateSegment201Response> response = apiInstance.GetSegmentByIdWithHttpInfo(segmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.GetSegmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **segmentId** | **int** | The system-generated unique ID that identifies a segment. |  |

### Return type

[**CreateSegment201Response**](CreateSegment201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The segment was successfully returned. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesegment"></a>
# **UpdateSegment**
> CreateSegment201Response UpdateSegment (int segmentId, CreateSegmentRequest createSegmentRequest)

PUT (update) a Segment

Use this method to update an existing segment's name (`name`) and/or contact selection criteria (`segment_criteria`). You must specify both the `name` and the `segment_criteria` in the request body, even if you don't plan to update both. The segment's name must be unique and the JSON must be valid (requires single-string escaped JSON). To avoid returning a 400 error response, when specifying the `segment_criteria` do not request more than 500 email campaigns or a date range greater than 1825 days (5 years) be evaluated. For more use case information, see [Update Segment Details](/api_guide/segment_update.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var segmentId = 14;  // int | The system generated ID that uniquely identifies the segment that you want to modify.
            var createSegmentRequest = new CreateSegmentRequest(); // CreateSegmentRequest | Include both the `name` and `segment_criteria` (single-string escaped JSON) in the body request, then make updates to either or both.

            try
            {
                // PUT (update) a Segment
                CreateSegment201Response result = apiInstance.UpdateSegment(segmentId, createSegmentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.UpdateSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (update) a Segment
    ApiResponse<CreateSegment201Response> response = apiInstance.UpdateSegmentWithHttpInfo(segmentId, createSegmentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.UpdateSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **segmentId** | **int** | The system generated ID that uniquely identifies the segment that you want to modify. |  |
| **createSegmentRequest** | [**CreateSegmentRequest**](CreateSegmentRequest.md) | Include both the &#x60;name&#x60; and &#x60;segment_criteria&#x60; (single-string escaped JSON) in the body request, then make updates to either or both. |  |

### Return type

[**CreateSegment201Response**](CreateSegment201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The segment was successfully updated. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesegmentname"></a>
# **UpdateSegmentName**
> CreateSegment201Response UpdateSegmentName (int segmentId, UpdateSegmentNameRequest updateSegmentNameRequest)

PATCH (rename) a Segment

Use this method to update an existing segment `name` with a new unique name in the request body. For more use case information, see [Rename a Segment](/api_guide/segment_rename.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateSegmentNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var segmentId = 14;  // int | The system generated ID that uniquely identifies the segment that you want to modify.
            var updateSegmentNameRequest = new UpdateSegmentNameRequest(); // UpdateSegmentNameRequest | Include the existing segment `name` in the body request, then rename the segment using a unique new name.

            try
            {
                // PATCH (rename) a Segment
                CreateSegment201Response result = apiInstance.UpdateSegmentName(segmentId, updateSegmentNameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.UpdateSegmentName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSegmentNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PATCH (rename) a Segment
    ApiResponse<CreateSegment201Response> response = apiInstance.UpdateSegmentNameWithHttpInfo(segmentId, updateSegmentNameRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.UpdateSegmentNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **segmentId** | **int** | The system generated ID that uniquely identifies the segment that you want to modify. |  |
| **updateSegmentNameRequest** | [**UpdateSegmentNameRequest**](UpdateSegmentNameRequest.md) | Include the existing segment &#x60;name&#x60; in the body request, then rename the segment using a unique new name. |  |

### Return type

[**CreateSegment201Response**](CreateSegment201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The segment name was successfully updated. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

