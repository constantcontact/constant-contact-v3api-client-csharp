# ConstantContactApi.Api.ContactsReportingApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetContactOpenClickRateReport**](ContactsReportingApi.md#getcontactopenclickratereport) | **GET** /reports/contact_reports/{contact_id}/open_and_click_rates | GET Average Open and Click Rates |
| [**GetContactTrackingCountReport**](ContactsReportingApi.md#getcontacttrackingcountreport) | **GET** /reports/contact_reports/{contact_id}/activity_summary | GET Contact Action Summary |
| [**GetContactTrackingReport**](ContactsReportingApi.md#getcontacttrackingreport) | **GET** /reports/contact_reports/{contact_id}/activity_details | GET Contact Activity Details |

<a id="getcontactopenclickratereport"></a>
# **GetContactOpenClickRateReport**
> GetContactOpenClickRateReport200Response GetContactOpenClickRateReport (string contactId, string start, string end)

GET Average Open and Click Rates

<p>Gets the average open and click rate for a given account and contact.<p>Looks at all tracking activities for bulk emails from a given contact over the given date range. Range cannot exceed 5 years.</p><p>Returns the rates and the number of campaign activities that were included in the calculation.</p><p>If no activities fall into the given date range, all rates will return 0 and the number of included activities will be 0.</p>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactOpenClickRateReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsReportingApi(config);
            var contactId = aa9ff7b0-478d-11e6-8059-00163e3c8e19;  // string | The contact id which is requesting tracking activity data (e.g. aa9ff7b0-478d-11e6-8059-00163e3c8e19)
            var start = "start_example";  // string | The starting date, in ISO 8601 format, to use to get campaigns. For example: 2019-01-01T00:00:00-0500.
            var end = "end_example";  // string | The ending date, in ISO 8601 format, to use to get campaigns. For example: 2019-12-01T00:00:00-0500.

            try
            {
                // GET Average Open and Click Rates
                GetContactOpenClickRateReport200Response result = apiInstance.GetContactOpenClickRateReport(contactId, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsReportingApi.GetContactOpenClickRateReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactOpenClickRateReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Average Open and Click Rates
    ApiResponse<GetContactOpenClickRateReport200Response> response = apiInstance.GetContactOpenClickRateReportWithHttpInfo(contactId, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsReportingApi.GetContactOpenClickRateReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | The contact id which is requesting tracking activity data (e.g. aa9ff7b0-478d-11e6-8059-00163e3c8e19) |  |
| **start** | **string** | The starting date, in ISO 8601 format, to use to get campaigns. For example: 2019-01-01T00:00:00-0500. |  |
| **end** | **string** | The ending date, in ISO 8601 format, to use to get campaigns. For example: 2019-12-01T00:00:00-0500. |  |

### Return type

[**GetContactOpenClickRateReport200Response**](GetContactOpenClickRateReport200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontacttrackingcountreport"></a>
# **GetContactTrackingCountReport**
> GetContactTrackingCountReport200Response GetContactTrackingCountReport (string contactId, string start, string end)

GET Contact Action Summary

Get a list of the recent emails (aka, campaign activities) sent to a specific contact and a summary of the actions the contact took on that email for the most recent 200 campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactTrackingCountReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsReportingApi(config);
            var contactId = aa9ff7b0-478d-11e6-8059-00163e3c8e19;  // string | The contact id which is requesting tracking activity data (e.g. aa9ff7b0-478d-11e6-8059-00163e3c8e19)
            var start = "start_example";  // string | The starting date, in ISO 8601 format, to use to get campaigns. For example: 2019-01-01T00:00:00-0500.
            var end = "end_example";  // string | The ending date, in ISO 8601 format, to use to get campaigns. For example: 2019-12-01T00:00:00-0500.

            try
            {
                // GET Contact Action Summary
                GetContactTrackingCountReport200Response result = apiInstance.GetContactTrackingCountReport(contactId, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsReportingApi.GetContactTrackingCountReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactTrackingCountReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Contact Action Summary
    ApiResponse<GetContactTrackingCountReport200Response> response = apiInstance.GetContactTrackingCountReportWithHttpInfo(contactId, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsReportingApi.GetContactTrackingCountReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | The contact id which is requesting tracking activity data (e.g. aa9ff7b0-478d-11e6-8059-00163e3c8e19) |  |
| **start** | **string** | The starting date, in ISO 8601 format, to use to get campaigns. For example: 2019-01-01T00:00:00-0500. |  |
| **end** | **string** | The ending date, in ISO 8601 format, to use to get campaigns. For example: 2019-12-01T00:00:00-0500. |  |

### Return type

[**GetContactTrackingCountReport200Response**](GetContactTrackingCountReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontacttrackingreport"></a>
# **GetContactTrackingReport**
> GetContactTrackingReport200Response GetContactTrackingReport (string contactId, List<string>? trackingActivitiesList = null, List<string>? trackingActivityType = null, bool? includeCampaignActivityNames = null, string? limit = null)

GET Contact Activity Details

<p>Gets the tracking activity data for a single contact, sorted in descending activity date order.</p> <p>You must chose either the `tracking_activities_list` query parameter and or the `tracking_activity_type` query parameter to specify one or more tracking activity types In the request. The `tracking_activities_list`  and `tracking_activities_type` query parameters are mutually exclusive.</p>       <table><tr><td colspan='2'>Valid tracking activity types</td></tr>         <tr><td><b>em_sends</b></td><td>Send activities</td></tr>         <tr><td><b>em_opens</b></td><td>Email open tracking activities</td></tr>         <tr><td><b>em_clicks</b></td><td>Link click-through tracking activities</td></tr>         <tr><td><b>em_bounces</b></td><td>Bounce tracking activities</td></tr>         <tr><td><b>em_optouts</b></td><td>Opt-out tracking activities</td></tr><tr>         <td><b>em_forwards</b></td><td>Forward to a friend tracking activities</td></tr>         <tr><td><b>p_contact_open</b></td><td>Landing page opens</td></tr>         <tr><td><b>p_contact_click</b></td><td>Landing page clicks</td></tr>         <tr><td><b>p_contact_add</b></td><td>Landing page adds</td></tr>         <tr><td><b>p_contact_update </b></td><td> Landing page updates</td></tr>       </table>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactTrackingReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsReportingApi(config);
            var contactId = aa9ff7b0-478d-11e6-8059-00163e3c8e19;  // string | The contact's ID for which tracking activity data is requested.
            var trackingActivitiesList = new List<string>?(); // List<string>? | Specify one or more tracking activity types to include as a comma-delimited string. The `tracking_activities_list`  and `tracking_activities_type` query parameters are mutually exclusive. (optional) 
            var trackingActivityType = new List<string>?(); // List<string>? | Specify one or more tracking activity types to include as an array. The `tracking_activities_list`  and `tracking_activities_type` query parameters are mutually exclusive. (optional) 
            var includeCampaignActivityNames = true;  // bool? | Default (`true`) returns campaign activity names in the results. Not including campaign activity names in the results (`false`), is more efficient. (optional)  (default to true)
            var limit = 20;  // string? | The number of tracking activities to return in a single page. Valid values are 1 to 100. Default is 100. (optional)  (default to "100")

            try
            {
                // GET Contact Activity Details
                GetContactTrackingReport200Response result = apiInstance.GetContactTrackingReport(contactId, trackingActivitiesList, trackingActivityType, includeCampaignActivityNames, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactsReportingApi.GetContactTrackingReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactTrackingReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Contact Activity Details
    ApiResponse<GetContactTrackingReport200Response> response = apiInstance.GetContactTrackingReportWithHttpInfo(contactId, trackingActivitiesList, trackingActivityType, includeCampaignActivityNames, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactsReportingApi.GetContactTrackingReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **string** | The contact&#39;s ID for which tracking activity data is requested. |  |
| **trackingActivitiesList** | [**List&lt;string&gt;?**](string.md) | Specify one or more tracking activity types to include as a comma-delimited string. The &#x60;tracking_activities_list&#x60;  and &#x60;tracking_activities_type&#x60; query parameters are mutually exclusive. | [optional]  |
| **trackingActivityType** | [**List&lt;string&gt;?**](string.md) | Specify one or more tracking activity types to include as an array. The &#x60;tracking_activities_list&#x60;  and &#x60;tracking_activities_type&#x60; query parameters are mutually exclusive. | [optional]  |
| **includeCampaignActivityNames** | **bool?** | Default (&#x60;true&#x60;) returns campaign activity names in the results. Not including campaign activity names in the results (&#x60;false&#x60;), is more efficient. | [optional] [default to true] |
| **limit** | **string?** | The number of tracking activities to return in a single page. Valid values are 1 to 100. Default is 100. | [optional] [default to &quot;100&quot;] |

### Return type

[**GetContactTrackingReport200Response**](GetContactTrackingReport200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

