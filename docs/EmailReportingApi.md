# ConstantContactApi.Api.EmailReportingApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBouncesReport**](EmailReportingApi.md#getbouncesreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/bounces | GET an Email Bounces Report |
| [**GetCampaignActivityLinkReport**](EmailReportingApi.md#getcampaignactivitylinkreport) | **GET** /reports/email_reports/{campaign_activity_id}/links | GET an Email Links Report |
| [**GetClicksReport**](EmailReportingApi.md#getclicksreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/clicks | GET an Email Clicks Report |
| [**GetDidNotOpensReport**](EmailReportingApi.md#getdidnotopensreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/didnotopens | GET an Email Did Not Opens Report |
| [**GetEmailCampaignActivityReport**](EmailReportingApi.md#getemailcampaignactivityreport) | **GET** /reports/stats/email_campaign_activities/{campaign_activity_ids} | GET an Email Campaign Activity Stats Report |
| [**GetEmailCampaignReport**](EmailReportingApi.md#getemailcampaignreport) | **GET** /reports/summary_reports/email_campaign_summaries | GET an Email Campaigns Summary Report |
| [**GetEmailOpensReport**](EmailReportingApi.md#getemailopensreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/opens | GET an Email Opens Report |
| [**GetEmailSendsReport**](EmailReportingApi.md#getemailsendsreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/sends | GET an Email Sends Report |
| [**GetEmailStatsReport**](EmailReportingApi.md#getemailstatsreport) | **GET** /reports/stats/email_campaigns/{campaign_ids} | GET an Email Campaign Stats Report |
| [**GetForwardsReport**](EmailReportingApi.md#getforwardsreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/forwards | GET an Email Forwards Report |
| [**GetOptoutsReport**](EmailReportingApi.md#getoptoutsreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/optouts | GET an Email Opt-outs Report |
| [**GetUniqueOpensReport**](EmailReportingApi.md#getuniqueopensreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/unique_opens | GET an Email Unique Opens Report |

<a id="getbouncesreport"></a>
# **GetBouncesReport**
> GetBouncesReport200Response GetBouncesReport (Guid campaignActivityId, List<string>? bounceCode = null, string? limit = null)

GET an Email Bounces Report

Use this method to get a report listing contact bounce data for the specified email campaign activity. This report lists the most recent bounce data first and includes contact information, such as the contact's email address, unique ID, and the email bounce date and time. Use the <code>bounce_code</code> query parameter to limit the type of bounce data to return.  For more use case information, see [Get a Bounces Report for an Email Campaign Activity](/api_guide/email_summary_bounces_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetBouncesReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = "campaignActivityId_example";  // Guid | The ID that uniquely identifies the email campaign activity to use for this report.
            var bounceCode = new List<string>?(); // List<string>? | To return results for a specific bounce code, select the `bounce_code` from the drop-down list. To return results for multiple codes, repeat the bounce code parameter for each. For example, to return results for bounce codes `B` and `D` use `bounce_code=B&bounce_code=D`. (optional) 
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Bounces Report
                GetBouncesReport200Response result = apiInstance.GetBouncesReport(campaignActivityId, bounceCode, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetBouncesReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBouncesReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Bounces Report
    ApiResponse<GetBouncesReport200Response> response = apiInstance.GetBouncesReportWithHttpInfo(campaignActivityId, bounceCode, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetBouncesReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The ID that uniquely identifies the email campaign activity to use for this report. |  |
| **bounceCode** | [**List&lt;string&gt;?**](string.md) | To return results for a specific bounce code, select the &#x60;bounce_code&#x60; from the drop-down list. To return results for multiple codes, repeat the bounce code parameter for each. For example, to return results for bounce codes &#x60;B&#x60; and &#x60;D&#x60; use &#x60;bounce_code&#x3D;B&amp;bounce_code&#x3D;D&#x60;. | [optional]  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetBouncesReport200Response**](GetBouncesReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcampaignactivitylinkreport"></a>
# **GetCampaignActivityLinkReport**
> GetCampaignActivityLinkReport200Response GetCampaignActivityLinkReport (Guid campaignActivityId, bool? noClicks = null)

GET an Email Links Report

Use this method to return link details, including the number of unique contacts that clicked each link in an email campaign activity, and the type of action associated with clicking each link. To include link details for links that were not clicked, set the `no_clicks` query parameter to `true`.  You can return reporting data for `primary_email` and `resend` role email campaign activities. For more use case information, see [Get an Email Links Report](/api_guide/email_links_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetCampaignActivityLinkReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = 8892baf9-970a-4de6-8400-fa4ec461987c;  // Guid | The unique ID for an email campaign activity.
            var noClicks = true;  // bool? | Set this query parameter to `true` to  return details for links that were not clicked in the response results. (optional)  (default to false)

            try
            {
                // GET an Email Links Report
                GetCampaignActivityLinkReport200Response result = apiInstance.GetCampaignActivityLinkReport(campaignActivityId, noClicks);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetCampaignActivityLinkReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCampaignActivityLinkReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Links Report
    ApiResponse<GetCampaignActivityLinkReport200Response> response = apiInstance.GetCampaignActivityLinkReportWithHttpInfo(campaignActivityId, noClicks);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetCampaignActivityLinkReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity. |  |
| **noClicks** | **bool?** | Set this query parameter to &#x60;true&#x60; to  return details for links that were not clicked in the response results. | [optional] [default to false] |

### Return type

[**GetCampaignActivityLinkReport200Response**](GetCampaignActivityLinkReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclicksreport"></a>
# **GetClicksReport**
> GetClicksReport200Response GetClicksReport (Guid campaignActivityId, long? urlId = null, string? limit = null)

GET an Email Clicks Report

Use this method to get each time a contact clicked a link, the click date and time, and the device type they used. Use the `url_id` query parameter to get a clicks report for a specific link URL. Clicks report data is sorted with most recent activity listed first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetClicksReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = c8cdf384-15ca-4dcc-9b6f-4c91121fdc23;  // Guid | The ID that uniquely identifies the email campaign activity to use for this report.
            var urlId = 49920742166;  // long? | The ID that uniquely identifies a single link URL for which you want to get a clicks report. (optional) 
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Clicks Report
                GetClicksReport200Response result = apiInstance.GetClicksReport(campaignActivityId, urlId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetClicksReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClicksReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Clicks Report
    ApiResponse<GetClicksReport200Response> response = apiInstance.GetClicksReportWithHttpInfo(campaignActivityId, urlId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetClicksReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The ID that uniquely identifies the email campaign activity to use for this report. |  |
| **urlId** | **long?** | The ID that uniquely identifies a single link URL for which you want to get a clicks report. | [optional]  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetClicksReport200Response**](GetClicksReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdidnotopensreport"></a>
# **GetDidNotOpensReport**
> GetDidNotOpensReport200Response GetDidNotOpensReport (Guid campaignActivityId, string? limit = null)

GET an Email Did Not Opens Report

Use this method to get a report listing each contact that was sent, but did not open the specified email campaign activity. This report lists contact information such as the contact's email address and unique ID, and the date and time that the email campaign activity was sent. This report lists the most recent activity first. For more use case information, see [Get a Did Not Opens Report for an Email Campaign Activity](/api_guide/email_summary_non_opens_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetDidNotOpensReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = 8892baf9-970a-4de6-8400-fa4ec461987c;  // Guid | The ID that uniquely identifies the email campaign activity to use for this report.
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Did Not Opens Report
                GetDidNotOpensReport200Response result = apiInstance.GetDidNotOpensReport(campaignActivityId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetDidNotOpensReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDidNotOpensReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Did Not Opens Report
    ApiResponse<GetDidNotOpensReport200Response> response = apiInstance.GetDidNotOpensReportWithHttpInfo(campaignActivityId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetDidNotOpensReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The ID that uniquely identifies the email campaign activity to use for this report. |  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetDidNotOpensReport200Response**](GetDidNotOpensReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailcampaignactivityreport"></a>
# **GetEmailCampaignActivityReport**
> GetEmailCampaignActivityReport200Response GetEmailCampaignActivityReport (string campaignActivityIds)

GET an Email Campaign Activity Stats Report

Use this method to get performance tracking statistics for up to ten email campaign activities. Statistics include the total number of times contacts interacted with your campaigns and how.  For each `campaign_activity_id`, this method returns the `campaign_id`, the total counts (`stats`) for each type of tracked email activity, and the date and time that Constant Contact last refreshed (`last_refresh_time`) the `stats`.  When requesting statistics for multiple email campaign activities, if one or more of the `campaign_activity_ids` do not exist, were deleted, or do not have any stats associated with it, the `campaign_activity_ids` and error details display under `errors`. If any single specified `campaign_activity_id` is invalid (malformed), a 404 error response is returned for all campaign activities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignActivityReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityIds = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // string | A comma-separated list of `campaign_activity_id`s (UUID's).

            try
            {
                // GET an Email Campaign Activity Stats Report
                GetEmailCampaignActivityReport200Response result = apiInstance.GetEmailCampaignActivityReport(campaignActivityIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetEmailCampaignActivityReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignActivityReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Campaign Activity Stats Report
    ApiResponse<GetEmailCampaignActivityReport200Response> response = apiInstance.GetEmailCampaignActivityReportWithHttpInfo(campaignActivityIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetEmailCampaignActivityReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityIds** | **string** | A comma-separated list of &#x60;campaign_activity_id&#x60;s (UUID&#39;s). |  |

### Return type

[**GetEmailCampaignActivityReport200Response**](GetEmailCampaignActivityReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailcampaignreport"></a>
# **GetEmailCampaignReport**
> GetEmailCampaignReport200Response GetEmailCampaignReport (string? limit = null)

GET an Email Campaigns Summary Report

Use this method to get aggregate email campaign statistics for up to five hundred email campaigns. The response results include the total number of times that each contact uniquely interacted with each tracked campaign activity.  Results are sorted in descending order by the date that the email was last sent (<code>last_sent_date</code>). Use the <code>limit</code> query parameter to limit the number of email campaign summary reports listed on each page.     For more use case information, see \"[Get an Email Campaign Summary Report](/api_guide/email_bulk_campaign_summary_report.html)\"

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailCampaignReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var limit = 100;  // string? | Use the `limit` query parameter to limit the number of email campaign summaries to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")

            try
            {
                // GET an Email Campaigns Summary Report
                GetEmailCampaignReport200Response result = apiInstance.GetEmailCampaignReport(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetEmailCampaignReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Campaigns Summary Report
    ApiResponse<GetEmailCampaignReport200Response> response = apiInstance.GetEmailCampaignReportWithHttpInfo(limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetEmailCampaignReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **string?** | Use the &#x60;limit&#x60; query parameter to limit the number of email campaign summaries to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |

### Return type

[**GetEmailCampaignReport200Response**](GetEmailCampaignReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailopensreport"></a>
# **GetEmailOpensReport**
> GetEmailOpensReport200Response GetEmailOpensReport (Guid campaignActivityId, string? limit = null)

GET an Email Opens Report

Use this method to get each time a contact opened a specific email campaign activity. This report includes general contact information such as the contact's email address and unique ID, the date and time they opened the email campaign activity, and the type of device they used to open it. This report lists the most recent activity first. For more use case information, see [Get an Opens report for an Email Campaign Activity](/api_guide/email_summary_opens_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailOpensReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = 8892baf9-970a-4de6-8400-fa4ec461987c;  // Guid | The unique ID for an email campaign activity to use for this report.
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Opens Report
                GetEmailOpensReport200Response result = apiInstance.GetEmailOpensReport(campaignActivityId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetEmailOpensReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailOpensReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Opens Report
    ApiResponse<GetEmailOpensReport200Response> response = apiInstance.GetEmailOpensReportWithHttpInfo(campaignActivityId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetEmailOpensReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity to use for this report. |  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetEmailOpensReport200Response**](GetEmailOpensReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailsendsreport"></a>
# **GetEmailSendsReport**
> GetEmailSendsReport200Response GetEmailSendsReport (Guid campaignActivityId, string? limit = null)

GET an Email Sends Report

Use this method to get each contact that was sent a specific email campaign activity. This sends report includes general contact data such as the date and time that the email campaign activity was sent to a contact's email address, the contact's first and last name, and unique ID. This report lists the most recent activity first. For more use case information, see [Get an Sends report for an Email Campaign Activity](/api_guide/email_summary_sends_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailSendsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = 8892baf9-970a-4de6-8400-fa4ec461987c;  // Guid | The unique ID for an email campaign activity to use for this report.
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Sends Report
                GetEmailSendsReport200Response result = apiInstance.GetEmailSendsReport(campaignActivityId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetEmailSendsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailSendsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Sends Report
    ApiResponse<GetEmailSendsReport200Response> response = apiInstance.GetEmailSendsReportWithHttpInfo(campaignActivityId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetEmailSendsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The unique ID for an email campaign activity to use for this report. |  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetEmailSendsReport200Response**](GetEmailSendsReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailstatsreport"></a>
# **GetEmailStatsReport**
> GetEmailStatsReport200Response GetEmailStatsReport (string campaignIds)

GET an Email Campaign Stats Report

Use this method to get email campaign performance tracking statistics for one or more campaigns, including the total number of times contacts interacted with your campaigns and how.  For each `campaign_id`, this method returns lists that include total counts (`stats`) for each type of tracked email and relevant campaign-related percentages (`percents`). It also returns the date and time at which the campaign stats were last refreshed. If any specified `campaign_id` is invalid, a 404 error response is returned for all campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEmailStatsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignIds = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // string | A comma-separated list of `campaign_id`s (UUID's).

            try
            {
                // GET an Email Campaign Stats Report
                GetEmailStatsReport200Response result = apiInstance.GetEmailStatsReport(campaignIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetEmailStatsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailStatsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Campaign Stats Report
    ApiResponse<GetEmailStatsReport200Response> response = apiInstance.GetEmailStatsReportWithHttpInfo(campaignIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetEmailStatsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignIds** | **string** | A comma-separated list of &#x60;campaign_id&#x60;s (UUID&#39;s). |  |

### Return type

[**GetEmailStatsReport200Response**](GetEmailStatsReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getforwardsreport"></a>
# **GetForwardsReport**
> GetForwardsReport200Response GetForwardsReport (Guid campaignActivityId, string? limit = null)

GET an Email Forwards Report

Use this method to get a report listing each time a contact forwarded the email campaign activity using the forwarding link in the email footer. The report includes general contact information, such as the contact's email address and unique ID, and the date and time that the email campaign activity was forwarded. Forwards report data is sorted with the most recent activity listed first. For more use case information, see [Get an Email Forwards Report](/api_guide/email_summary_forwards_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetForwardsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = "campaignActivityId_example";  // Guid | The ID that uniquely identifies the email campaign activity to use for this report.
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Forwards Report
                GetForwardsReport200Response result = apiInstance.GetForwardsReport(campaignActivityId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetForwardsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetForwardsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Forwards Report
    ApiResponse<GetForwardsReport200Response> response = apiInstance.GetForwardsReportWithHttpInfo(campaignActivityId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetForwardsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The ID that uniquely identifies the email campaign activity to use for this report. |  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetForwardsReport200Response**](GetForwardsReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoptoutsreport"></a>
# **GetOptoutsReport**
> GetOptoutsReport200Response GetOptoutsReport (Guid campaignActivityId, string? limit = null)

GET an Email Opt-outs Report

Use this method to get a report listing each contact that clicked the unsubscribe link in the email campaign activity to opt-out from receiving emails sent from your Constant Contact account. This report includes contact information, such as the contact's email address, unique ID, and the opt-out date and time. Opt-out report data is sorted with the most recent activity listed first. For more use case information, see [Get an Email Opt-outs Report](/api_guide/email_summary_optouts_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetOptoutsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = "campaignActivityId_example";  // Guid | The ID that uniquely identifies the email campaign activity to use for this report.
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Opt-outs Report
                GetOptoutsReport200Response result = apiInstance.GetOptoutsReport(campaignActivityId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetOptoutsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOptoutsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Opt-outs Report
    ApiResponse<GetOptoutsReport200Response> response = apiInstance.GetOptoutsReportWithHttpInfo(campaignActivityId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetOptoutsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The ID that uniquely identifies the email campaign activity to use for this report. |  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetOptoutsReport200Response**](GetOptoutsReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuniqueopensreport"></a>
# **GetUniqueOpensReport**
> GetEmailOpensReport200Response GetUniqueOpensReport (Guid campaignActivityId, string? limit = null)

GET an Email Unique Opens Report

Use this method to get a unique opens report that provides details about the last time that each contact opened the specified email campaign activity. This report includes general contact information such as the contact's email address and unique ID, the date and time they opened the email campaign activity, and the type of device they used to open it. This report lists the most recent activity first. For more use case information, see [Get an Unique Opens Report for an Email Campaign Activity](/api_guide/email_summary_unique_opens_report.html) in the API guide.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetUniqueOpensReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmailReportingApi(config);
            var campaignActivityId = 8892baf9-970a-4de6-8400-fa4ec461987c;  // Guid | The ID that uniquely identifies the email campaign activity to use for this report.
            var limit = "\"500\"";  // string? | The number of tracking activities to return on a page. (optional)  (default to "500")

            try
            {
                // GET an Email Unique Opens Report
                GetEmailOpensReport200Response result = apiInstance.GetUniqueOpensReport(campaignActivityId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailReportingApi.GetUniqueOpensReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUniqueOpensReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Email Unique Opens Report
    ApiResponse<GetEmailOpensReport200Response> response = apiInstance.GetUniqueOpensReportWithHttpInfo(campaignActivityId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailReportingApi.GetUniqueOpensReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The ID that uniquely identifies the email campaign activity to use for this report. |  |
| **limit** | **string?** | The number of tracking activities to return on a page. | [optional] [default to &quot;500&quot;] |

### Return type

[**GetEmailOpensReport200Response**](GetEmailOpensReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request was successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

