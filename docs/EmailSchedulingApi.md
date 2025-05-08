# ConstantContactApi.Api.EmailSchedulingApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEmailCampaignActivityPreview**](EmailSchedulingApi.md#getemailcampaignactivitypreview) | **GET** /emails/activities/{campaign_activity_id}/previews | GET the HTML Preview of an Email Campaign Activity |
| [**GetEmailCampaignActivitySchedule**](EmailSchedulingApi.md#getemailcampaignactivityschedule) | **GET** /emails/activities/{campaign_activity_id}/schedules | GET an Email Campaign Activity Schedule |
| [**GetEmailCampaignActivitySendHistory**](EmailSchedulingApi.md#getemailcampaignactivitysendhistory) | **GET** /emails/activities/{campaign_activity_id}/send_history | GET the Send History of an Email Campaign Activity |
| [**ScheduleEmailCampaignActivity**](EmailSchedulingApi.md#scheduleemailcampaignactivity) | **POST** /emails/activities/{campaign_activity_id}/schedules | POST (Create) an Email Campaign Activity Schedule |
| [**TestSendEmailCampaignActivity**](EmailSchedulingApi.md#testsendemailcampaignactivity) | **POST** /emails/activities/{campaign_activity_id}/tests | POST Test Send an Email Campaign Activity |
| [**UnscheduleEmailCampaignActivity**](EmailSchedulingApi.md#unscheduleemailcampaignactivity) | **DELETE** /emails/activities/{campaign_activity_id}/schedules | DELETE an Email Campaign Activity Schedule |

<a id="getemailcampaignactivitypreview"></a>
# **GetEmailCampaignActivityPreview**
> GetEmailCampaignActivityPreview200Response GetEmailCampaignActivityPreview (Guid campaignActivityId)

GET the HTML Preview of an Email Campaign Activity

Use this method to get the HTML preview of an email campaign activity. The HTML preview allows you to verify how the email campaign activity will look before you send it to contacts.  Custom code emails (`format_type` 5) use the Constant Contact account owner's contact information to process contact, custom field, and account variables in the preview.  This method returns the HTML preview encoded as a JSON string. You will need to decode the string before you can use it as valid HTML. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignActivityPreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailSchedulingApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // Guid | The unique ID for an email campaign activity.

            try
            {
                // GET the HTML Preview of an Email Campaign Activity
                GetEmailCampaignActivityPreview200Response result = apiInstance.GetEmailCampaignActivityPreview(campaignActivityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailSchedulingApi.GetEmailCampaignActivityPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignActivityPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET the HTML Preview of an Email Campaign Activity
    ApiResponse<GetEmailCampaignActivityPreview200Response> response = apiInstance.GetEmailCampaignActivityPreviewWithHttpInfo(campaignActivityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailSchedulingApi.GetEmailCampaignActivityPreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity. |  |

### Return type

[**GetEmailCampaignActivityPreview200Response**](GetEmailCampaignActivityPreview200Response.md)

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

<a id="getemailcampaignactivityschedule"></a>
# **GetEmailCampaignActivitySchedule**
> List&lt;GetEmailCampaignActivitySchedule200ResponseInner&gt; GetEmailCampaignActivitySchedule (Guid campaignActivityId)

GET an Email Campaign Activity Schedule

Use this method to return the current schedule for an email campaign activity. This schedule contains the date that Constant Contact will send the email campaign activity to contacts. If the email campaign activity is not in `SCHEDULED` status, this method returns an empty array and a 200 response code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignActivityScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailSchedulingApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // Guid | The unique ID for an email campaign activity.

            try
            {
                // GET an Email Campaign Activity Schedule
                List<GetEmailCampaignActivitySchedule200ResponseInner> result = apiInstance.GetEmailCampaignActivitySchedule(campaignActivityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailSchedulingApi.GetEmailCampaignActivitySchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignActivityScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Campaign Activity Schedule
    ApiResponse<List<GetEmailCampaignActivitySchedule200ResponseInner>> response = apiInstance.GetEmailCampaignActivityScheduleWithHttpInfo(campaignActivityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailSchedulingApi.GetEmailCampaignActivityScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity. |  |

### Return type

[**List&lt;GetEmailCampaignActivitySchedule200ResponseInner&gt;**](GetEmailCampaignActivitySchedule200ResponseInner.md)

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

<a id="getemailcampaignactivitysendhistory"></a>
# **GetEmailCampaignActivitySendHistory**
> List&lt;GetEmailCampaignActivitySendHistory200ResponseInner&gt; GetEmailCampaignActivitySendHistory (string campaignActivityId)

GET the Send History of an Email Campaign Activity

Use this method to return the send history of an email campaign activity. This method returns the send history as an array containing an object for each time you sent a specific email campaign activity to contacts.   Each send history object contains the email campaign activity send date, the number of contacts it was sent to, and the contact lists or segments used to send it. Each send history object also includes if the send attempt completed or encountered an error, and the reason why each error occurred. This method returns results in ascending order starting with the first send attempt.   If the email campaign activity has not been sent to contacts, this method returns a 200 response and an empty array. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignActivitySendHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailSchedulingApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // string | The unique ID for an email campaign activity. You can return the send history for `primary_email` and `resend` role email campaign activities.

            try
            {
                // GET the Send History of an Email Campaign Activity
                List<GetEmailCampaignActivitySendHistory200ResponseInner> result = apiInstance.GetEmailCampaignActivitySendHistory(campaignActivityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailSchedulingApi.GetEmailCampaignActivitySendHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignActivitySendHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET the Send History of an Email Campaign Activity
    ApiResponse<List<GetEmailCampaignActivitySendHistory200ResponseInner>> response = apiInstance.GetEmailCampaignActivitySendHistoryWithHttpInfo(campaignActivityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailSchedulingApi.GetEmailCampaignActivitySendHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **string** | The unique ID for an email campaign activity. You can return the send history for &#x60;primary_email&#x60; and &#x60;resend&#x60; role email campaign activities. |  |

### Return type

[**List&lt;GetEmailCampaignActivitySendHistory200ResponseInner&gt;**](GetEmailCampaignActivitySendHistory200ResponseInner.md)

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

<a id="scheduleemailcampaignactivity"></a>
# **ScheduleEmailCampaignActivity**
> List&lt;GetEmailCampaignActivitySchedule200ResponseInner&gt; ScheduleEmailCampaignActivity (Guid campaignActivityId, ScheduleEmailCampaignActivityRequest scheduleEmailCampaignActivityRequest)

POST (Create) an Email Campaign Activity Schedule

Use this method to schedule when Constant Contact will send an email campaign activity to contacts. Use the `scheduled_date` request body property to enter the ISO-8601 format date that you want Constant Contact to send the email campaign activity on.   Before you schedule an email campaign activity, you must update the email campaign activity and specify which contacts you want Constant Contact to send the email to. When you make a PUT call to update an email campaign activity, use the `contact_list_ids` or `segment_ids` array to add contacts.  You can only schedule email campaign activities that have the `primary_email` role and are in `DRAFT`, `DONE`, or `ERROR` status. When you schedule an email campaign activity in `DONE` status, Constant Contact does not send the email campaign activity to contacts that already received it. Constant Contact only sends the email campaign activity to any new contacts in the contact lists or segment you use. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class ScheduleEmailCampaignActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailSchedulingApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // Guid | The unique ID for an email campaign activity. You can only schedule email campaign activities that have the `primary_email` role.
            var scheduleEmailCampaignActivityRequest = new ScheduleEmailCampaignActivityRequest(); // ScheduleEmailCampaignActivityRequest | A request body payload that contains the date that you want Constant Contact to send your email campaign activity on. Use `\"0\"` as the date to have Constant Contact immediately send the email campaign activity.

            try
            {
                // POST (Create) an Email Campaign Activity Schedule
                List<GetEmailCampaignActivitySchedule200ResponseInner> result = apiInstance.ScheduleEmailCampaignActivity(campaignActivityId, scheduleEmailCampaignActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailSchedulingApi.ScheduleEmailCampaignActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduleEmailCampaignActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (Create) an Email Campaign Activity Schedule
    ApiResponse<List<GetEmailCampaignActivitySchedule200ResponseInner>> response = apiInstance.ScheduleEmailCampaignActivityWithHttpInfo(campaignActivityId, scheduleEmailCampaignActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailSchedulingApi.ScheduleEmailCampaignActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity. You can only schedule email campaign activities that have the &#x60;primary_email&#x60; role. |  |
| **scheduleEmailCampaignActivityRequest** | [**ScheduleEmailCampaignActivityRequest**](ScheduleEmailCampaignActivityRequest.md) | A request body payload that contains the date that you want Constant Contact to send your email campaign activity on. Use &#x60;\&quot;0\&quot;&#x60; as the date to have Constant Contact immediately send the email campaign activity. |  |

### Return type

[**List&lt;GetEmailCampaignActivitySchedule200ResponseInner&gt;**](GetEmailCampaignActivitySchedule200ResponseInner.md)

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
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testsendemailcampaignactivity"></a>
# **TestSendEmailCampaignActivity**
> void TestSendEmailCampaignActivity (Guid campaignActivityId, TestSendEmailCampaignActivityRequest testSendEmailCampaignActivityRequest)

POST Test Send an Email Campaign Activity

Use this method to send a test email to specific email addresses. Test emails allow you to verify how the email campaign activity will look before you send it to contacts. This method uses the `email_addresses` array in the request body to determine the recipients of the test email. The test email does not process any dynamic content in the email campaign activity. Dynamic content includes contact and custom field variables.  You can send up to 50 test emails each day. Each recipient you add to the `email_addresses` array in the request body counts towards this limit. Successfully sending a test email returns a 204 response code without a response body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class TestSendEmailCampaignActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailSchedulingApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // Guid | The unique ID for an email campaign activity. You can only test send email campaign activities that have the `primary_email` role.
            var testSendEmailCampaignActivityRequest = new TestSendEmailCampaignActivityRequest(); // TestSendEmailCampaignActivityRequest | A JSON request body that contains the recipients of the test email and an optional personal message.

            try
            {
                // POST Test Send an Email Campaign Activity
                apiInstance.TestSendEmailCampaignActivity(campaignActivityId, testSendEmailCampaignActivityRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailSchedulingApi.TestSendEmailCampaignActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestSendEmailCampaignActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST Test Send an Email Campaign Activity
    apiInstance.TestSendEmailCampaignActivityWithHttpInfo(campaignActivityId, testSendEmailCampaignActivityRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailSchedulingApi.TestSendEmailCampaignActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity. You can only test send email campaign activities that have the &#x60;primary_email&#x60; role. |  |
| **testSendEmailCampaignActivityRequest** | [**TestSendEmailCampaignActivityRequest**](TestSendEmailCampaignActivityRequest.md) | A JSON request body that contains the recipients of the test email and an optional personal message. |  |

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
| **204** | Test email campaign activity successfully sent. No response body returned. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unscheduleemailcampaignactivity"></a>
# **UnscheduleEmailCampaignActivity**
> void UnscheduleEmailCampaignActivity (Guid campaignActivityId)

DELETE an Email Campaign Activity Schedule

Use this method to unschedule an email campaign activity by deleting the schedule. You can only unschedule email campaign activities that are in `SCHEDULED` status. Unscheduling reverts the email campaign activity to the status prior to `SCHEDULED`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UnscheduleEmailCampaignActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailSchedulingApi(config);
            var campaignActivityId = 91569d46-00e4-4a4d-9a4c-d17d98740d04;  // Guid | The unique ID for an email campaign activity.

            try
            {
                // DELETE an Email Campaign Activity Schedule
                apiInstance.UnscheduleEmailCampaignActivity(campaignActivityId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailSchedulingApi.UnscheduleEmailCampaignActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnscheduleEmailCampaignActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DELETE an Email Campaign Activity Schedule
    apiInstance.UnscheduleEmailCampaignActivityWithHttpInfo(campaignActivityId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailSchedulingApi.UnscheduleEmailCampaignActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity. |  |

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
| **204** | Email campaign activity schedule successfully deleted. No response body returned. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded the request rate limit. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

