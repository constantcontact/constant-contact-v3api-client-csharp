# ConstantContactApi.Api.SMSReportingApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllBulkSmsCampaignSummaries**](SMSReportingApi.md#getallbulksmscampaignsummaries) | **GET** /reports/summary_reports/sms_campaign_summaries | GET an SMS Campaigns Summary Report |

<a id="getallbulksmscampaignsummaries"></a>
# **GetAllBulkSmsCampaignSummaries**
> GetAllBulkSmsCampaignSummaries200Response GetAllBulkSmsCampaignSummaries (string startAt, string? limit = null, string? endAt = null)

GET an SMS Campaigns Summary Report

Use this method to get SMS campaign summary details, including the total number of times that each contact uniquely interacted with each tracked campaign activity and aggregate tracking statistics. Results are sorted in descending order by the date the SMS was last sent (`last_sent_date`). The `start_at` date is required. Use both the `start_at` and `end_at` date query parameters to return only SMS campaign summary details that occurred within a specified date range. Use the `limit` query parameter to limit the number of results returned per page. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllBulkSmsCampaignSummariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SMSReportingApi(config);
            var startAt = 2023-01-27T21:56:37.011Z;  // string | Use to limit the results to include SMS campaign summary details for SMS campaigns sent on or after the required `start_at` date you specify. ISO 8601 format.
            var limit = 15;  // string? | Use to limit the number of results to return on a single page (from 1 to 50). The default setting is 50. (optional)  (default to "50")
            var endAt = 2024-01-27T21:56:37.011Z;  // string? | Use to limit the results to include SMS campaign summary details for SMS campaigns sent on or before the `end_at` date you specify. ISO 8601 format. (optional) 

            try
            {
                // GET an SMS Campaigns Summary Report
                GetAllBulkSmsCampaignSummaries200Response result = apiInstance.GetAllBulkSmsCampaignSummaries(startAt, limit, endAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSReportingApi.GetAllBulkSmsCampaignSummaries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllBulkSmsCampaignSummariesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an SMS Campaigns Summary Report
    ApiResponse<GetAllBulkSmsCampaignSummaries200Response> response = apiInstance.GetAllBulkSmsCampaignSummariesWithHttpInfo(startAt, limit, endAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSReportingApi.GetAllBulkSmsCampaignSummariesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startAt** | **string** | Use to limit the results to include SMS campaign summary details for SMS campaigns sent on or after the required &#x60;start_at&#x60; date you specify. ISO 8601 format. |  |
| **limit** | **string?** | Use to limit the number of results to return on a single page (from 1 to 50). The default setting is 50. | [optional] [default to &quot;50&quot;] |
| **endAt** | **string?** | Use to limit the results to include SMS campaign summary details for SMS campaigns sent on or before the &#x60;end_at&#x60; date you specify. ISO 8601 format. | [optional]  |

### Return type

[**GetAllBulkSmsCampaignSummaries200Response**](GetAllBulkSmsCampaignSummaries200Response.md)

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

