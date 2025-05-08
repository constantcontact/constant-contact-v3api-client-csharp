# ConstantContactApi.Api.LandingPagesReportingApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetContactAdds**](LandingPagesReportingApi.md#getcontactadds) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_adds | GET a Unique Contacts Adds Landing Page Report |
| [**GetContactOpens**](LandingPagesReportingApi.md#getcontactopens) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_contact_opens | GET a Contacts Opens Landing Page Report |
| [**GetUniqueContactClicks**](LandingPagesReportingApi.md#getuniquecontactclicks) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_clicks | GET a Unique Contacts Clicks Landing Page Report |
| [**GetUniqueContactOpens**](LandingPagesReportingApi.md#getuniquecontactopens) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_opens | GET a Unique Contacts Opens Landing Page Report |
| [**GetUniqueContactSMSOptIns**](LandingPagesReportingApi.md#getuniquecontactsmsoptins) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_sms_optins | GET a Unique Contacts SMS Opt-In Landing Page Report |
| [**GetUniqueContactUpdates**](LandingPagesReportingApi.md#getuniquecontactupdates) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_updates | GET a Unique Contacts Updates Landing Page Report |

<a id="getcontactadds"></a>
# **GetContactAdds**
> GetContactAdds200Response GetContactAdds (Guid campaignActivityId, string? limit = null, string? contactsFilter = null)

GET a Unique Contacts Adds Landing Page Report

Use this method to get details about each contact added to the account from a specified landing page. Contacts are identified by `contact_id`. The resulting contact data is listed with most recent activity first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactAddsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LandingPagesReportingApi(config);
            var campaignActivityId = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // Guid | The landing page `campaign_activity_id` (UUID's) to use to get unique contact results.
            var limit = 100;  // string? | Use to limit the number of contact tracking activities to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")
            var contactsFilter = Jo;  // string? | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. (optional) 

            try
            {
                // GET a Unique Contacts Adds Landing Page Report
                GetContactAdds200Response result = apiInstance.GetContactAdds(campaignActivityId, limit, contactsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LandingPagesReportingApi.GetContactAdds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactAddsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Unique Contacts Adds Landing Page Report
    ApiResponse<GetContactAdds200Response> response = apiInstance.GetContactAddsWithHttpInfo(campaignActivityId, limit, contactsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LandingPagesReportingApi.GetContactAddsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The landing page &#x60;campaign_activity_id&#x60; (UUID&#39;s) to use to get unique contact results. |  |
| **limit** | **string?** | Use to limit the number of contact tracking activities to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |
| **contactsFilter** | **string?** | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. | [optional]  |

### Return type

[**GetContactAdds200Response**](GetContactAdds200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactopens"></a>
# **GetContactOpens**
> GetUniqueContactOpens200Response GetContactOpens (Guid campaignActivityId, string? limit = null, string? contactsFilter = null)

GET a Contacts Opens Landing Page Report

Use this method get contact details for each time a contact opens a link on a landing page.  The resulting contact data is listed with most recent activity first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetContactOpensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LandingPagesReportingApi(config);
            var campaignActivityId = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // Guid | The landing page `campaign_activity_id` (UUID's) to use to get unique contact open results.
            var limit = 100;  // string? | Use to limit the number of contact tracking activities to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")
            var contactsFilter = Jo;  // string? | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. (optional) 

            try
            {
                // GET a Contacts Opens Landing Page Report
                GetUniqueContactOpens200Response result = apiInstance.GetContactOpens(campaignActivityId, limit, contactsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LandingPagesReportingApi.GetContactOpens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactOpensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Contacts Opens Landing Page Report
    ApiResponse<GetUniqueContactOpens200Response> response = apiInstance.GetContactOpensWithHttpInfo(campaignActivityId, limit, contactsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LandingPagesReportingApi.GetContactOpensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The landing page &#x60;campaign_activity_id&#x60; (UUID&#39;s) to use to get unique contact open results. |  |
| **limit** | **string?** | Use to limit the number of contact tracking activities to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |
| **contactsFilter** | **string?** | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. | [optional]  |

### Return type

[**GetUniqueContactOpens200Response**](GetUniqueContactOpens200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuniquecontactclicks"></a>
# **GetUniqueContactClicks**
> GetUniqueContactClicks200Response GetUniqueContactClicks (Guid campaignActivityId, string? limit = null, string? contactsFilter = null)

GET a Unique Contacts Clicks Landing Page Report

Use this method get details about each contact that clicked a link on a landing page campaign activity. Unique contact clicks are identified by both the `contact_id` and `url_id`. The same contact may appear more than once in the results, if they clicked more than one link on the landing page. The resulting contact data is listed with most recent activity first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetUniqueContactClicksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LandingPagesReportingApi(config);
            var campaignActivityId = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // Guid | The landing page `campaign_activity_id` (UUID's) to use to get unique contact click results.
            var limit = 100;  // string? | Use to limit the number of contact tracking activities to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")
            var contactsFilter = Jo;  // string? | Use to filter the results to return only contacts that match a contacts full or partial first or last name, or email. For example: Josie or Jo. (optional) 

            try
            {
                // GET a Unique Contacts Clicks Landing Page Report
                GetUniqueContactClicks200Response result = apiInstance.GetUniqueContactClicks(campaignActivityId, limit, contactsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactClicks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUniqueContactClicksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Unique Contacts Clicks Landing Page Report
    ApiResponse<GetUniqueContactClicks200Response> response = apiInstance.GetUniqueContactClicksWithHttpInfo(campaignActivityId, limit, contactsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactClicksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The landing page &#x60;campaign_activity_id&#x60; (UUID&#39;s) to use to get unique contact click results. |  |
| **limit** | **string?** | Use to limit the number of contact tracking activities to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |
| **contactsFilter** | **string?** | Use to filter the results to return only contacts that match a contacts full or partial first or last name, or email. For example: Josie or Jo. | [optional]  |

### Return type

[**GetUniqueContactClicks200Response**](GetUniqueContactClicks200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuniquecontactopens"></a>
# **GetUniqueContactOpens**
> GetUniqueContactOpens200Response GetUniqueContactOpens (Guid campaignActivityId, string? limit = null, string? contactsFilter = null)

GET a Unique Contacts Opens Landing Page Report

Use this method get details about each contact that opens a link on a landing page. Contacts are uniquely identified by `contact_id`.  The resulting contact data is listed with most recent activity first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetUniqueContactOpensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LandingPagesReportingApi(config);
            var campaignActivityId = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // Guid | The landing page `campaign_activity_id` (UUID's) to use to get unique contact open results.
            var limit = 100;  // string? | Use to limit the number of contact tracking activities to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")
            var contactsFilter = Jo;  // string? | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. (optional) 

            try
            {
                // GET a Unique Contacts Opens Landing Page Report
                GetUniqueContactOpens200Response result = apiInstance.GetUniqueContactOpens(campaignActivityId, limit, contactsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactOpens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUniqueContactOpensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Unique Contacts Opens Landing Page Report
    ApiResponse<GetUniqueContactOpens200Response> response = apiInstance.GetUniqueContactOpensWithHttpInfo(campaignActivityId, limit, contactsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactOpensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The landing page &#x60;campaign_activity_id&#x60; (UUID&#39;s) to use to get unique contact open results. |  |
| **limit** | **string?** | Use to limit the number of contact tracking activities to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |
| **contactsFilter** | **string?** | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. | [optional]  |

### Return type

[**GetUniqueContactOpens200Response**](GetUniqueContactOpens200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuniquecontactsmsoptins"></a>
# **GetUniqueContactSMSOptIns**
> GetUniqueContactSMSOptIns200Response GetUniqueContactSMSOptIns (Guid campaignActivityId, string? limit = null, string? contactsFilter = null)

GET a Unique Contacts SMS Opt-In Landing Page Report

Use this method get details about unique contacts that click a link on a landing page to opt in to receiving SMS text messages. Contacts are uniquely identified by `contact_id``.  The resulting contact data is listed with most recent activity first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetUniqueContactSMSOptInsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LandingPagesReportingApi(config);
            var campaignActivityId = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // Guid | The landing page `campaign_activity_id` (UUID's) to use to get unique contact click results.
            var limit = 100;  // string? | Use to limit the number of contact tracking activities to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")
            var contactsFilter = Jo;  // string? | Use to filter the results to return only contacts that match a contacts full or partial first or last name, or email. For example: Josie or Jo. (optional) 

            try
            {
                // GET a Unique Contacts SMS Opt-In Landing Page Report
                GetUniqueContactSMSOptIns200Response result = apiInstance.GetUniqueContactSMSOptIns(campaignActivityId, limit, contactsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactSMSOptIns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUniqueContactSMSOptInsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Unique Contacts SMS Opt-In Landing Page Report
    ApiResponse<GetUniqueContactSMSOptIns200Response> response = apiInstance.GetUniqueContactSMSOptInsWithHttpInfo(campaignActivityId, limit, contactsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactSMSOptInsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The landing page &#x60;campaign_activity_id&#x60; (UUID&#39;s) to use to get unique contact click results. |  |
| **limit** | **string?** | Use to limit the number of contact tracking activities to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |
| **contactsFilter** | **string?** | Use to filter the results to return only contacts that match a contacts full or partial first or last name, or email. For example: Josie or Jo. | [optional]  |

### Return type

[**GetUniqueContactSMSOptIns200Response**](GetUniqueContactSMSOptIns200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuniquecontactupdates"></a>
# **GetUniqueContactUpdates**
> GetUniqueContactUpdates200Response GetUniqueContactUpdates (Guid campaignActivityId, string? limit = null, string? contactsFilter = null)

GET a Unique Contacts Updates Landing Page Report

Use this method to get contact details for each contact that updated their contact data from a landing page. Contacts are uniquely identified by `contact_id`.  The resulting contact data is listed with most recent activity first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetUniqueContactUpdatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LandingPagesReportingApi(config);
            var campaignActivityId = 82ee2c37-c8f8-4974-9560-ef93ad51d58z;  // Guid | The landing page `campaign_activity_id` (UUID's) to use to get unique contact open results.
            var limit = 100;  // string? | Use to limit the number of contact tracking activities to return on a single page. The default is `50` and the maximum is `500` per page. (optional)  (default to "50")
            var contactsFilter = Jo;  // string? | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. (optional) 

            try
            {
                // GET a Unique Contacts Updates Landing Page Report
                GetUniqueContactUpdates200Response result = apiInstance.GetUniqueContactUpdates(campaignActivityId, limit, contactsFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactUpdates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUniqueContactUpdatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a Unique Contacts Updates Landing Page Report
    ApiResponse<GetUniqueContactUpdates200Response> response = apiInstance.GetUniqueContactUpdatesWithHttpInfo(campaignActivityId, limit, contactsFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LandingPagesReportingApi.GetUniqueContactUpdatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignActivityId** | **Guid** | The landing page &#x60;campaign_activity_id&#x60; (UUID&#39;s) to use to get unique contact open results. |  |
| **limit** | **string?** | Use to limit the number of contact tracking activities to return on a single page. The default is &#x60;50&#x60; and the maximum is &#x60;500&#x60; per page. | [optional] [default to &quot;50&quot;] |
| **contactsFilter** | **string?** | Use to filter the results to only include contacts that contain a certain value. This parameter does full and partial matches and applies to the contact first name, last name, and email fields. For example: Josie or Jo. | [optional]  |

### Return type

[**GetUniqueContactUpdates200Response**](GetUniqueContactUpdates200Response.md)

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
| **415** | Unsupported Media Type. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

