# ConstantContactApi.Api.EmailCampaignsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEmailCampaign**](EmailCampaignsApi.md#createemailcampaign) | **POST** /emails | POST (Create) a New Email Campaign |
| [**CreateResendEmailCampaign**](EmailCampaignsApi.md#createresendemailcampaign) | **POST** /emails/activities/{campaign_activity_id}/non_opener_resends | POST a Resend to Non-openers Campaign Activity |
| [**DeleteEmailCampaign**](EmailCampaignsApi.md#deleteemailcampaign) | **DELETE** /emails/{campaign_id} | DELETE an Email Campaign |
| [**DeleteResendEmailCampaign**](EmailCampaignsApi.md#deleteresendemailcampaign) | **DELETE** /emails/activities/{campaign_activity_id}/non_opener_resends/{resend_request_id} | DELETE a Resend to Non Openers Activity |
| [**GetAllEmailCampaigns**](EmailCampaignsApi.md#getallemailcampaigns) | **GET** /emails | GET a Collection of Email Campaigns |
| [**GetEmailCampaignActivity**](EmailCampaignsApi.md#getemailcampaignactivity) | **GET** /emails/activities/{campaign_activity_id} | GET a Single Email Campaign Activity |
| [**GetEmailCampaignById**](EmailCampaignsApi.md#getemailcampaignbyid) | **GET** /emails/{campaign_id} | GET Details About a Single Email Campaign |
| [**GetEmailCampaignXrefs**](EmailCampaignsApi.md#getemailcampaignxrefs) | **GET** /emails/campaign_id_xrefs | GET a Collection of V2 and V3 API Email Campaign Identifiers |
| [**GetResendEmailCampaign**](EmailCampaignsApi.md#getresendemailcampaign) | **GET** /emails/activities/{campaign_activity_id}/non_opener_resends | GET Details for a Resend to Non-openers Campaign Activity |
| [**PatchEmailCampaignName**](EmailCampaignsApi.md#patchemailcampaignname) | **PATCH** /emails/{campaign_id} | PATCH (Update) an Email Campaign Name |
| [**UpdateEmailCampaignActivity**](EmailCampaignsApi.md#updateemailcampaignactivity) | **PUT** /emails/activities/{campaign_activity_id} | PUT (Update) An Email Campaign Activity |

<a id="createemailcampaign"></a>
# **CreateEmailCampaign**
> CreateEmailCampaign200Response CreateEmailCampaign (CreateEmailCampaignRequest createEmailCampaignRequest)

POST (Create) a New Email Campaign

Use this method to create a new email campaign. This method also creates new `primary_email` and `permalink` email campaign activities and associates them with the new email campaign.  The request body must contain the `name` property and the `email_campaign_activities` array. The `name` must be unique. The `email_campaign_activities` array contains the main content of your email campaign and must include `format_type`, `from_name`, `from_email`, `reply_to_email`, `subject`, and `html_content` properties. The `from_email` address you use must use a verified email address for your account. NOTE: If you create an email campaign using a legacy (V7) format, Constant Contact automatically converts it to the newer custom code format. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var createEmailCampaignRequest = new CreateEmailCampaignRequest(); // CreateEmailCampaignRequest | A JSON request body that contains the email content.

            try
            {
                // POST (Create) a New Email Campaign
                CreateEmailCampaign200Response result = apiInstance.CreateEmailCampaign(createEmailCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.CreateEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (Create) a New Email Campaign
    ApiResponse<CreateEmailCampaign200Response> response = apiInstance.CreateEmailCampaignWithHttpInfo(createEmailCampaignRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.CreateEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEmailCampaignRequest** | [**CreateEmailCampaignRequest**](CreateEmailCampaignRequest.md) | A JSON request body that contains the email content. |  |

### Return type

[**CreateEmailCampaign200Response**](CreateEmailCampaign200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request successful. NOTE: If you created an email campaign using a legacy (V7) format, Constant Contact successfully converted it to the newer custom code format. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createresendemailcampaign"></a>
# **CreateResendEmailCampaign**
> CreateResendEmailCampaign201Response CreateResendEmailCampaign (string campaignActivityId, CreateResendEmailCampaignRequest createResendEmailCampaignRequest)

POST a Resend to Non-openers Campaign Activity

Use this POST method to resend a primary campaign activity to contacts that did not open a campaign activity that has a current `status` of `Draft`, `Scheduled`, or `Done`. You can only create one resend activity per email campaign.    After an email campaign activity is sent to contacts, Constant Contact waits the specified number of `delay_days` or `delay_minutes` (properties are mutually exclusive) before resending to non-openers. If you set both `delay_days` or `delay_minutes`, `delay_minutes` is ignored in the request. You can resend to non-openers a minimum of twelve hours (720 minutes) and a maximum of up to 10 days (or 10 x 1440 minutes) after the initial send date.    

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateResendEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the primary email campaign activity.
            var createResendEmailCampaignRequest = new CreateResendEmailCampaignRequest(); // CreateResendEmailCampaignRequest | A JSON request body that specifies when to resend the campaign activity to non-openers.

            try
            {
                // POST a Resend to Non-openers Campaign Activity
                CreateResendEmailCampaign201Response result = apiInstance.CreateResendEmailCampaign(campaignActivityId, createResendEmailCampaignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.CreateResendEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateResendEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST a Resend to Non-openers Campaign Activity
    ApiResponse<CreateResendEmailCampaign201Response> response = apiInstance.CreateResendEmailCampaignWithHttpInfo(campaignActivityId, createResendEmailCampaignRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.CreateResendEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the primary email campaign activity. |  |
| **createResendEmailCampaignRequest** | [**CreateResendEmailCampaignRequest**](CreateResendEmailCampaignRequest.md) | A JSON request body that specifies when to resend the campaign activity to non-openers. |  |

### Return type

[**CreateResendEmailCampaign201Response**](CreateResendEmailCampaign201Response.md)

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

<a id="deleteemailcampaign"></a>
# **DeleteEmailCampaign**
> void DeleteEmailCampaign (string campaignId)

DELETE an Email Campaign

Use this method to delete an email campaign and the email campaign activities associated with the email campaign. You cannot delete an email campaign when it has a `Scheduled` status.  Constant Contact users can restore deleted email campaigns using the UI. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the email campaign you are deleting.

            try
            {
                // DELETE an Email Campaign
                apiInstance.DeleteEmailCampaign(campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.DeleteEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE an Email Campaign
    apiInstance.DeleteEmailCampaignWithHttpInfo(campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.DeleteEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The unique ID for the email campaign you are deleting. |  |

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
| **204** | Email campaign successfully deleted. No response body returned. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteresendemailcampaign"></a>
# **DeleteResendEmailCampaign**
> void DeleteResendEmailCampaign (string campaignActivityId, string resendRequestId)

DELETE a Resend to Non Openers Activity

Use this `DELETE` method to delete (unschedule) a resend to non openers activity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class DeleteResendEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the primary email campaign activity.
            var resendRequestId = 389093;  // string | The unique ID associated with the resend for the email campaign activity (for example: `389093`). If the email campaign activity is currently in draft status, specify `DRAFT` as the ID.

            try
            {
                // DELETE a Resend to Non Openers Activity
                apiInstance.DeleteResendEmailCampaign(campaignActivityId, resendRequestId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.DeleteResendEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteResendEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE a Resend to Non Openers Activity
    apiInstance.DeleteResendEmailCampaignWithHttpInfo(campaignActivityId, resendRequestId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.DeleteResendEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the primary email campaign activity. |  |
| **resendRequestId** | **string** | The unique ID associated with the resend for the email campaign activity (for example: &#x60;389093&#x60;). If the email campaign activity is currently in draft status, specify &#x60;DRAFT&#x60; as the ID. |  |

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
| **204** | Request successful. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **409** | Conflict. The resource you are creating or updating conflicts with an existing resource. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallemailcampaigns"></a>
# **GetAllEmailCampaigns**
> GetAllEmailCampaigns200Response GetAllEmailCampaigns (int? limit = null, DateTime? beforeDate = null, DateTime? afterDate = null)

GET a Collection of Email Campaigns

Use this method to list and get details about your email campaigns. By default, this method returns all email campaigns for the user account including deleted email campaigns. To get email campaigns within a date-range, use the `after_date` and `before_date` query parameters.  This endpoint does not return campaign activity details for each email campaign in the collection. To get email campaign activity details for a single email campaign, use the GET `/emails/{campaign_id}` endpoint.\" <div class=\"Msg\"><p class=\"note-text\">This method does not currently support filtering results using the email campaign creation date.</p></div> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllEmailCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var limit = 50;  // int? | Specifies the number of campaigns to display on each page of output that is returned (from return 1 - 500). The default returns 50 campaigns per page. (optional)  (default to 50)
            var beforeDate = 2021-01-10T11:42:57.000Z;  // DateTime? | Use to return email campaigns with `updated_at` timestamps that are before a specific date and time (in ISO-8601 format). Use with the `after_date` query parameter to get email campaigns sent within a specific date range. (optional) 
            var afterDate = 2021-03-10T11:42:57.000Z;  // DateTime? | Use to return email campaigns with last `updated_at` timestamps that are after a specific date and time (in ISO-8601 format). Use with the `before_date` query parameter to get email campaigns sent within a specific date range. (optional) 

            try
            {
                // GET a Collection of Email Campaigns
                GetAllEmailCampaigns200Response result = apiInstance.GetAllEmailCampaigns(limit, beforeDate, afterDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetAllEmailCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllEmailCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Collection of Email Campaigns
    ApiResponse<GetAllEmailCampaigns200Response> response = apiInstance.GetAllEmailCampaignsWithHttpInfo(limit, beforeDate, afterDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetAllEmailCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Specifies the number of campaigns to display on each page of output that is returned (from return 1 - 500). The default returns 50 campaigns per page. | [optional] [default to 50] |
| **beforeDate** | **DateTime?** | Use to return email campaigns with &#x60;updated_at&#x60; timestamps that are before a specific date and time (in ISO-8601 format). Use with the &#x60;after_date&#x60; query parameter to get email campaigns sent within a specific date range. | [optional]  |
| **afterDate** | **DateTime?** | Use to return email campaigns with last &#x60;updated_at&#x60; timestamps that are after a specific date and time (in ISO-8601 format). Use with the &#x60;before_date&#x60; query parameter to get email campaigns sent within a specific date range. | [optional]  |

### Return type

[**GetAllEmailCampaigns200Response**](GetAllEmailCampaigns200Response.md)

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
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailcampaignactivity"></a>
# **GetEmailCampaignActivity**
> GetEmailCampaignActivity200Response GetEmailCampaignActivity (string campaignActivityId, string? include = null)

GET a Single Email Campaign Activity

Use this method to return a specific email campaign activity. Each email campaign activity contains the email content, metadata, and styling information of an email. Email campaign activities can also contain either contact lists or segments. Constant Contact uses this information to determine who to send the email campaign activity to when you schedule it. You cannot get email campaign activities that have a `REMOVED` status. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for an email campaign activity.
            var include = "physical_address_in_footer";  // string? | Use the `include` query parameter to enter a comma separated list of additional email campaign activity properties for the V3 API to return. Valid values are `physical_address_in_footer`, `permalink_url`, `html_content`, and `document_properties`. (optional) 

            try
            {
                // GET a Single Email Campaign Activity
                GetEmailCampaignActivity200Response result = apiInstance.GetEmailCampaignActivity(campaignActivityId, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Single Email Campaign Activity
    ApiResponse<GetEmailCampaignActivity200Response> response = apiInstance.GetEmailCampaignActivityWithHttpInfo(campaignActivityId, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for an email campaign activity. |  |
| **include** | **string?** | Use the &#x60;include&#x60; query parameter to enter a comma separated list of additional email campaign activity properties for the V3 API to return. Valid values are &#x60;physical_address_in_footer&#x60;, &#x60;permalink_url&#x60;, &#x60;html_content&#x60;, and &#x60;document_properties&#x60;. | [optional]  |

### Return type

[**GetEmailCampaignActivity200Response**](GetEmailCampaignActivity200Response.md)

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
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailcampaignbyid"></a>
# **GetEmailCampaignById**
> CreateEmailCampaign200Response GetEmailCampaignById (string campaignId)

GET Details About a Single Email Campaign

Use this method to get details about a single email campaign and campaign related activities. Details include the email campaign name, current status, create date, last update date, and a list of campaign activities; including the `campaign_activity_id` and `role`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The ID (UUID format) that uniquely identifies this email campaign.

            try
            {
                // GET Details About a Single Email Campaign
                CreateEmailCampaign200Response result = apiInstance.GetEmailCampaignById(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Details About a Single Email Campaign
    ApiResponse<CreateEmailCampaign200Response> response = apiInstance.GetEmailCampaignByIdWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The ID (UUID format) that uniquely identifies this email campaign. |  |

### Return type

[**CreateEmailCampaign200Response**](CreateEmailCampaign200Response.md)

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
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailcampaignxrefs"></a>
# **GetEmailCampaignXrefs**
> GetEmailCampaignXrefs200Response GetEmailCampaignXrefs (string v2EmailCampaignIds)

GET a Collection of V2 and V3 API Email Campaign Identifiers

<div class=\"Msg Msg- -warning\"><p class=\"note-text\">Use this endpoint to migrate your locally stored V2 email campaign data to the new V3 format. Developers are expected to use this endpoint sparingly. This endpoint is NOT intended for regular or repeated use. Constant Contact will eventually deprecate and remove this endpoint.</p></div>  Use this method to migrate your local V2 API email data to the V3 API format. For each value that you provide in the `v2_email_campaign_ids` query parameter, this method returns the corresponding V3 `campaign_id` and V3 `campaign_activity_id` UUID value. For more information on the changes to the email campaign resource model, see [V3 Email Campaign Resource Changes](/api_guide/v3_v2_email_campaign_deltas.html) in the API guide. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignXrefsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var v2EmailCampaignIds = 1100567546598,1604567396117,12002485195578;  // string | Comma separated list of V2 API `campaignId` values. You can enter up to 50 V2 `campaignId` values in each request.

            try
            {
                // GET a Collection of V2 and V3 API Email Campaign Identifiers
                GetEmailCampaignXrefs200Response result = apiInstance.GetEmailCampaignXrefs(v2EmailCampaignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignXrefs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignXrefsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Collection of V2 and V3 API Email Campaign Identifiers
    ApiResponse<GetEmailCampaignXrefs200Response> response = apiInstance.GetEmailCampaignXrefsWithHttpInfo(v2EmailCampaignIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignXrefsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **v2EmailCampaignIds** | **string** | Comma separated list of V2 API &#x60;campaignId&#x60; values. You can enter up to 50 V2 &#x60;campaignId&#x60; values in each request. |  |

### Return type

[**GetEmailCampaignXrefs200Response**](GetEmailCampaignXrefs200Response.md)

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
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getresendemailcampaign"></a>
# **GetResendEmailCampaign**
> List&lt;GetResendEmailCampaign200ResponseInner&gt; GetResendEmailCampaign (string campaignActivityId)

GET Details for a Resend to Non-openers Campaign Activity

Get details about a resend to non-openers campaign activity. If resend activity does not exist for the specified `campaign_activity_id`, an empty list is returned in the results. You can only create one resend activity per email campaign.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetResendEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the primary email campaign activity.

            try
            {
                // GET Details for a Resend to Non-openers Campaign Activity
                List<GetResendEmailCampaign200ResponseInner> result = apiInstance.GetResendEmailCampaign(campaignActivityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetResendEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResendEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Details for a Resend to Non-openers Campaign Activity
    ApiResponse<List<GetResendEmailCampaign200ResponseInner>> response = apiInstance.GetResendEmailCampaignWithHttpInfo(campaignActivityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetResendEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the primary email campaign activity. |  |

### Return type

[**List&lt;GetResendEmailCampaign200ResponseInner&gt;**](GetResendEmailCampaign200ResponseInner.md)

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
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="patchemailcampaignname"></a>
# **PatchEmailCampaignName**
> CreateEmailCampaign200Response PatchEmailCampaignName (string campaignId, PatchEmailCampaignNameRequest patchEmailCampaignNameRequest)

PATCH (Update) an Email Campaign Name

Use this method to rename an email campaign. The name is not visible to contacts. The name must be unique and cannot exceed 80 characters. You cannot rename email campaigns that have a `Removed` status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class PatchEmailCampaignNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique identifier for an email campaign.
            var patchEmailCampaignNameRequest = new PatchEmailCampaignNameRequest(); // PatchEmailCampaignNameRequest | A JSON payload that contains the new email campaign name.

            try
            {
                // PATCH (Update) an Email Campaign Name
                CreateEmailCampaign200Response result = apiInstance.PatchEmailCampaignName(campaignId, patchEmailCampaignNameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.PatchEmailCampaignName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchEmailCampaignNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PATCH (Update) an Email Campaign Name
    ApiResponse<CreateEmailCampaign200Response> response = apiInstance.PatchEmailCampaignNameWithHttpInfo(campaignId, patchEmailCampaignNameRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.PatchEmailCampaignNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **string** | The unique identifier for an email campaign. |  |
| **patchEmailCampaignNameRequest** | [**PatchEmailCampaignNameRequest**](PatchEmailCampaignNameRequest.md) | A JSON payload that contains the new email campaign name. |  |

### Return type

[**CreateEmailCampaign200Response**](CreateEmailCampaign200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
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
| **415** | Unsupported Media Type. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateemailcampaignactivity"></a>
# **UpdateEmailCampaignActivity**
> GetEmailCampaignActivity200Response UpdateEmailCampaignActivity (string campaignActivityId, GetEmailCampaignActivity200Response getEmailCampaignActivity200Response)

PUT (Update) An Email Campaign Activity

Use this method to update an email campaign activity by including the complete email campaign activity with your changes in the request body. The request body requires the `from_name`, `from_email`, `reply_to_email`, and `subject` properties.  You can only update email campaign activities that have the `primary_email` role and that are in `DRAFT` or `Done` status. When you use a PUT method to update a resource, the V3 API overwrites any properties that are missing in the request body. However, the V3 API does not overwrite subresources that you omit in the request body or missing properties in subresources. This method considers `physical_address_in_footer`, `document_properties`, `html_content`, and `permalink_url` subresources of the email campaign activity. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateEmailCampaignActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailCampaignsApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for the email campaign activity you are updating.
            var getEmailCampaignActivity200Response = new GetEmailCampaignActivity200Response(); // GetEmailCampaignActivity200Response | A request body payload that contains the complete email campaign activity with your changes.

            try
            {
                // PUT (Update) An Email Campaign Activity
                GetEmailCampaignActivity200Response result = apiInstance.UpdateEmailCampaignActivity(campaignActivityId, getEmailCampaignActivity200Response);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.UpdateEmailCampaignActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEmailCampaignActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PUT (Update) An Email Campaign Activity
    ApiResponse<GetEmailCampaignActivity200Response> response = apiInstance.UpdateEmailCampaignActivityWithHttpInfo(campaignActivityId, getEmailCampaignActivity200Response);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.UpdateEmailCampaignActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for the email campaign activity you are updating. |  |
| **getEmailCampaignActivity200Response** | [**GetEmailCampaignActivity200Response**](GetEmailCampaignActivity200Response.md) | A request body payload that contains the complete email campaign activity with your changes. |  |

### Return type

[**GetEmailCampaignActivity200Response**](GetEmailCampaignActivity200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email campaign activity successfully updated. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

