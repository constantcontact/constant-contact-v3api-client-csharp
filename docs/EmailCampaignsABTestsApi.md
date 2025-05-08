# ConstantContactApi.Api.EmailCampaignsABTestsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateABTestEmailCampaign**](EmailCampaignsABTestsApi.md#createabtestemailcampaign) | **POST** /emails/activities/{campaign_activity_id}/abtest | POST (Create) an A/B Test for an Email Campaign Activity |
| [**DeleteABTestEmailCampaign**](EmailCampaignsABTestsApi.md#deleteabtestemailcampaign) | **DELETE** /emails/activities/{campaign_activity_id}/abtest | DELETE an A/B Test for an Email Campaign Activity |
| [**GetABTestEmailCampaign**](EmailCampaignsABTestsApi.md#getabtestemailcampaign) | **GET** /emails/activities/{campaign_activity_id}/abtest | GET A/B Test Details for an Email Campaign Activity |

<a id="createabtestemailcampaign"></a>
# **CreateABTestEmailCampaign**
> GetABTestEmailCampaign200Response CreateABTestEmailCampaign (string campaignActivityId, GetABTestEmailCampaign200Response getABTestEmailCampaign200Response)

POST (Create) an A/B Test for an Email Campaign Activity

Use this method to create a new A/B test for a primary email campaign activity. You must specify an alternative subject line, the percentage of contact to use for the A/B test, and the number of hours to wait after the A/B test is sent before determining the winning subject line. To create an A/B test, the campaign must have a `current_status` of `DRAFT`. When you create an A/B test, the `type` changes from Newsletter (code= `10`) to A/B Test (code= `57`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateABTestEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsABTestsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the primary email campaign activity.
            var getABTestEmailCampaign200Response = new GetABTestEmailCampaign200Response(); // GetABTestEmailCampaign200Response | Specify the `alternative_subject` line, `test_size` percentage of contacts (value must from `5` to `50` inclusively), and the `winner_wait_duration` (value must be `6`, `12`, `24`, or `48` hours).

            try
            {
                // POST (Create) an A/B Test for an Email Campaign Activity
                GetABTestEmailCampaign200Response result = apiInstance.CreateABTestEmailCampaign(campaignActivityId, getABTestEmailCampaign200Response);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsABTestsApi.CreateABTestEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateABTestEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (Create) an A/B Test for an Email Campaign Activity
    ApiResponse<GetABTestEmailCampaign200Response> response = apiInstance.CreateABTestEmailCampaignWithHttpInfo(campaignActivityId, getABTestEmailCampaign200Response);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsABTestsApi.CreateABTestEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the primary email campaign activity. |  |
| **getABTestEmailCampaign200Response** | [**GetABTestEmailCampaign200Response**](GetABTestEmailCampaign200Response.md) | Specify the &#x60;alternative_subject&#x60; line, &#x60;test_size&#x60; percentage of contacts (value must from &#x60;5&#x60; to &#x60;50&#x60; inclusively), and the &#x60;winner_wait_duration&#x60; (value must be &#x60;6&#x60;, &#x60;12&#x60;, &#x60;24&#x60;, or &#x60;48&#x60; hours). |  |

### Return type

[**GetABTestEmailCampaign200Response**](GetABTestEmailCampaign200Response.md)

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
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteabtestemailcampaign"></a>
# **DeleteABTestEmailCampaign**
> void DeleteABTestEmailCampaign (string campaignActivityId)

DELETE an A/B Test for an Email Campaign Activity

Deletes an A/B Test on an primary email campaign activity. You can only delete A/B tests that have a `current_status` of `Draft`. Deleting an A/B tests reverts the email campaign activity `type` from A/B Test (code= `57`) back to NewsLetter (code= `10`). Constant Contact uses the original subject line, rather than the alternate A/B test subject line, when an A/B test is deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteABTestEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsABTestsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the primary email campaign activity.

            try
            {
                // DELETE an A/B Test for an Email Campaign Activity
                apiInstance.DeleteABTestEmailCampaign(campaignActivityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsABTestsApi.DeleteABTestEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteABTestEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE an A/B Test for an Email Campaign Activity
    apiInstance.DeleteABTestEmailCampaignWithHttpInfo(campaignActivityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsABTestsApi.DeleteABTestEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the primary email campaign activity. |  |

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
| **204** | A/B test successfully deleted. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getabtestemailcampaign"></a>
# **GetABTestEmailCampaign**
> GetABTestEmailCampaign200Response GetABTestEmailCampaign (string campaignActivityId)

GET A/B Test Details for an Email Campaign Activity

Use this method to get A/B test details for a primary email campaign activity, such as the alternate email subject line, the contact test percentage size, and the number of hours to wait to determine the winning subject line to use. Currently, A/B tests support subject line only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetABTestEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsABTestsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the primary email campaign activity.

            try
            {
                // GET A/B Test Details for an Email Campaign Activity
                GetABTestEmailCampaign200Response result = apiInstance.GetABTestEmailCampaign(campaignActivityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsABTestsApi.GetABTestEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetABTestEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET A/B Test Details for an Email Campaign Activity
    ApiResponse<GetABTestEmailCampaign200Response> response = apiInstance.GetABTestEmailCampaignWithHttpInfo(campaignActivityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsABTestsApi.GetABTestEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the primary email campaign activity. |  |

### Return type

[**GetABTestEmailCampaign200Response**](GetABTestEmailCampaign200Response.md)

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
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

