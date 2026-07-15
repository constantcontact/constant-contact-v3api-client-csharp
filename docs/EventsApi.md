# ConstantContactApi.Api.EventsApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckInTickets**](EventsApi.md#checkintickets) | **POST** /events/{event_id}/check_in/tickets | Check in event tickets. |
| [**CopyEvent**](EventsApi.md#copyevent) | **POST** /events/{event_id}/copy | POST (copy) an existing event. |
| [**CreateEvent**](EventsApi.md#createevent) | **POST** /events/default | POST (create) a new event. |
| [**FindEvents**](EventsApi.md#findevents) | **GET** /events | GET a collection of events. |
| [**FindRegistrationsUsingGET**](EventsApi.md#findregistrationsusingget) | **GET** /events/{event_id}/tracks/{track_id}/registrations | Get a list of registrations for an event. |
| [**GetEvent2**](EventsApi.md#getevent2) | **GET** /events/{event_id} | GET details for a single event. |
| [**GetRegistrationInfo**](EventsApi.md#getregistrationinfo) | **GET** /events/{event_id}/tracks/{track_id}/registrations/{registration_id} | Get registration details for an event. |
| [**UndoCheckInTickets**](EventsApi.md#undocheckintickets) | **POST** /events/{event_id}/undo_check_in/tickets | Undo event ticket check-in. |
| [**UpdateEvent**](EventsApi.md#updateevent) | **PATCH** /events/{event_id} | PATCH (update) an event. |
| [**UpdateRegistrationPaymentStatusUsingPUT**](EventsApi.md#updateregistrationpaymentstatususingput) | **PUT** /events/{event_id}/tracks/{track_id}/registrations/payment_status | Update payment status for event registrations. |
| [**UpdateRegistrationStatusUsingPUT**](EventsApi.md#updateregistrationstatususingput) | **PUT** /events/{event_id}/tracks/{track_id}/registrations | Update status for event registrations. |

<a id="checkintickets"></a>
# **CheckInTickets**
> void CheckInTickets (string eventId, CheckInTicketsRequest checkInTicketsRequest)

Check in event tickets.

Use this endpoint to mark one or more tickets as checked in. The event must be in `ACTIVE` or `COMPLETE` status. Tickets with `CANCELLED` status cannot be checked in (returns HTTP 400).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CheckInTicketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 07216444-4e3b-41ea-a3b8-5a418fce41f4;  // string | The ID that uniquely identifies the event.
            var checkInTicketsRequest = new CheckInTicketsRequest(); // CheckInTicketsRequest | Set of order ticket keys to mark as checked in.

            try
            {
                // Check in event tickets.
                apiInstance.CheckInTickets(eventId, checkInTicketsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.CheckInTickets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckInTicketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check in event tickets.
    apiInstance.CheckInTicketsWithHttpInfo(eventId, checkInTicketsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.CheckInTicketsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **checkInTicketsRequest** | [**CheckInTicketsRequest**](CheckInTicketsRequest.md) | Set of order ticket keys to mark as checked in. |  |

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
| **204** | Successfully checked in order tickets. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="copyevent"></a>
# **CopyEvent**
> CreateEvent201Response CopyEvent (string eventId, CopyEventRequest copyEventRequest)

POST (copy) an existing event.

Creates a deep copy of an existing event with all its settings, registration forms, and landing pages. The copied event is created in DRAFT status. Events in DRAFT, ACTIVE, COMPLETE, or CANCELED status can be copied. DELETED events cannot be copied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CopyEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 1697732a-8664-4675-8415-c4aabaa17dae;  // string | The ID of the event to copy.
            var copyEventRequest = new CopyEventRequest(); // CopyEventRequest | A JSON request body containing the copy options.

            try
            {
                // POST (copy) an existing event.
                CreateEvent201Response result = apiInstance.CopyEvent(eventId, copyEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.CopyEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (copy) an existing event.
    ApiResponse<CreateEvent201Response> response = apiInstance.CopyEventWithHttpInfo(eventId, copyEventRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.CopyEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID of the event to copy. |  |
| **copyEventRequest** | [**CopyEventRequest**](CopyEventRequest.md) | A JSON request body containing the copy options. |  |

### Return type

[**CreateEvent201Response**](CreateEvent201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Event copied successfully |  -  |
| **207** | Event copied with some failures |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createevent"></a>
# **CreateEvent**
> CreateEvent201Response CreateEvent (string? name = null, string? startTime = null, string? endTime = null, string? placeholderCampaignId = null)

POST (create) a new event.

Creates a new event with default settings, registration form, and landing page. The event will be created in DRAFT status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var name = My Event;  // string? | Name for the new event. If not provided, a default name will be generated. (optional) 
            var startTime = 2024-01-15T10:00:00Z;  // string? | Event start time in ISO 8601 format. If not provided, defaults to a future date. (optional) 
            var endTime = 2024-01-15T18:00:00Z;  // string? | Event end time in ISO 8601 format. If not provided, defaults to one hour after start time. (optional) 
            var placeholderCampaignId = campaign-123;  // string? | Placeholder campaign ID for the event. (optional) 

            try
            {
                // POST (create) a new event.
                CreateEvent201Response result = apiInstance.CreateEvent(name, startTime, endTime, placeholderCampaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.CreateEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // POST (create) a new event.
    ApiResponse<CreateEvent201Response> response = apiInstance.CreateEventWithHttpInfo(name, startTime, endTime, placeholderCampaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.CreateEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | Name for the new event. If not provided, a default name will be generated. | [optional]  |
| **startTime** | **string?** | Event start time in ISO 8601 format. If not provided, defaults to a future date. | [optional]  |
| **endTime** | **string?** | Event end time in ISO 8601 format. If not provided, defaults to one hour after start time. | [optional]  |
| **placeholderCampaignId** | **string?** | Placeholder campaign ID for the event. | [optional]  |

### Return type

[**CreateEvent201Response**](CreateEvent201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Event created successfully |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findevents"></a>
# **FindEvents**
> FindEvents200Response FindEvents (string? eventStatus = null, string? searchText = null, string? sortBy = null, string? sortOrder = null, string? limit = null, string? prev = null, string? next = null)

GET a collection of events.

Retrieve a collection of events with event details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class FindEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventStatus = DRAFT;  // string? | Use to return only events that meet the specified status. Acceptable values include `ACTIVE`,`DRAFT`, `COMPLETE`, `DELETED`,`CANCELLED`, and `ERROR`. (optional) 
            var searchText = reunion;  // string? | Use to return only events that include the specified text. (optional) 
            var sortBy = created_time;  // string? | Use to sort resulting events by one of the following properties: `name`, `start_time`, `end_time`, `created_time`, or `updated_time`. (optional) 
            var sortOrder = DESC;  // string? | Sort order for the `sort_by parameter`. Accepted values include `ASC` (ascending) or `DESC` (descending). Defaults to `ASC` if `sort_by` is provided. (optional) 
            var limit = 5;  // string? | Limit the number of results to return per page. Default and maximum is `100`. (optional) 
            var prev = 7zDEe3DhD5gUiwRFsvWKKZlZO1j6-YihH2hyVWD8GaW7JnzXbHFP8Tou212KoU20mOjvM6pdWwycDWC3X-Hb_xY-RK1eBwYp_pc4X2CvLxo.;  // string? | Cursor for retrieving the previous page of results. This value is obtained from the `prev_cursor` field in a previous response. (optional) 
            var next = 7zDEe3DhD5gUiwRFsvWKKZlZO1j6-YihH2hyVWD8GaW7JnzXbHFP8Tou212KoU20mOjvM6pdWwycDWC3X-Hb_xY-RK1eBwYp_pc4X2CvLxo;  // string? | Cursor for retrieving the next page of results. This value is obtained from the `next_cursor` field in a previous response. (optional) 

            try
            {
                // GET a collection of events.
                FindEvents200Response result = apiInstance.FindEvents(eventStatus, searchText, sortBy, sortOrder, limit, prev, next);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.FindEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET a collection of events.
    ApiResponse<FindEvents200Response> response = apiInstance.FindEventsWithHttpInfo(eventStatus, searchText, sortBy, sortOrder, limit, prev, next);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.FindEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventStatus** | **string?** | Use to return only events that meet the specified status. Acceptable values include &#x60;ACTIVE&#x60;,&#x60;DRAFT&#x60;, &#x60;COMPLETE&#x60;, &#x60;DELETED&#x60;,&#x60;CANCELLED&#x60;, and &#x60;ERROR&#x60;. | [optional]  |
| **searchText** | **string?** | Use to return only events that include the specified text. | [optional]  |
| **sortBy** | **string?** | Use to sort resulting events by one of the following properties: &#x60;name&#x60;, &#x60;start_time&#x60;, &#x60;end_time&#x60;, &#x60;created_time&#x60;, or &#x60;updated_time&#x60;. | [optional]  |
| **sortOrder** | **string?** | Sort order for the &#x60;sort_by parameter&#x60;. Accepted values include &#x60;ASC&#x60; (ascending) or &#x60;DESC&#x60; (descending). Defaults to &#x60;ASC&#x60; if &#x60;sort_by&#x60; is provided. | [optional]  |
| **limit** | **string?** | Limit the number of results to return per page. Default and maximum is &#x60;100&#x60;. | [optional]  |
| **prev** | **string?** | Cursor for retrieving the previous page of results. This value is obtained from the &#x60;prev_cursor&#x60; field in a previous response. | [optional]  |
| **next** | **string?** | Cursor for retrieving the next page of results. This value is obtained from the &#x60;next_cursor&#x60; field in a previous response. | [optional]  |

### Return type

[**FindEvents200Response**](FindEvents200Response.md)

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
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findregistrationsusingget"></a>
# **FindRegistrationsUsingGET**
> FindRegistrationsUsingGET200Response FindRegistrationsUsingGET (string eventId, string trackId, string? registrationStatus = null, string? paymentStatus = null, string? searchText = null, string? sortBy = null, string? sortOrder = null, string? pageSize = null, string? limit = null, string? prev = null, string? next = null)

Get a list of registrations for an event.

Use the `event_id` and `track_id` path parameters to get a list of registrations for an event. Use optional query parameters to limit the number of results returned per page, the sort order, or to filter results by specific criteria; such as registration `status`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class FindRegistrationsUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 1697732a-8664-4675-8415-c4aabaa17dae;  // string | The ID that uniquely identifies the event.
            var trackId = s8zabc;  // string | The track ID that uniquely identifies the event track.
            var registrationStatus = REGISTERED;  // string? | Filter registration results by status. (optional) 
            var paymentStatus = PAID;  // string? | Filter registration results by payment status. (optional) 
            var searchText = john.doe@example.com;  // string? | Filter registration results by first name, last name, or email address. (optional) 
            var sortBy = email_address;  // string? | Specify the field to use to sort the results. (optional) 
            var sortOrder = ASC;  // string? | Use to specify how you want the results sorted. (optional) 
            var pageSize = 50;  // string? | Alternative to the <code>limit</code> parameter to limit the number of results returned per page. If specifying both the <code>limit</code> and <code>page_size</code> query parameters, they must be the same value. (optional) 
            var limit = 50;  // string? | Limit the number of results returned per page. If specifying both the <code>limit</code> and <code>page_size</code> query parameters, they must be the same value. (optional) 
            var prev = bSzsyWkkq95R44vIFEpY62gr8_xSeRXsEQkhnhltPgiT;  // string? | Cursor for pagination used to get the previous page of results (mutually exclusive with <code>next</code>). (optional) 
            var next = cTk9xLmmr06S55wJGfQ73hs9_yTfSYtFRlimimQhjUj;  // string? | Cursor for pagination used to get the next page of results (mutually exclusive with <code>prev</code>). (optional) 

            try
            {
                // Get a list of registrations for an event.
                FindRegistrationsUsingGET200Response result = apiInstance.FindRegistrationsUsingGET(eventId, trackId, registrationStatus, paymentStatus, searchText, sortBy, sortOrder, pageSize, limit, prev, next);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.FindRegistrationsUsingGET: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindRegistrationsUsingGETWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of registrations for an event.
    ApiResponse<FindRegistrationsUsingGET200Response> response = apiInstance.FindRegistrationsUsingGETWithHttpInfo(eventId, trackId, registrationStatus, paymentStatus, searchText, sortBy, sortOrder, pageSize, limit, prev, next);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.FindRegistrationsUsingGETWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **trackId** | **string** | The track ID that uniquely identifies the event track. |  |
| **registrationStatus** | **string?** | Filter registration results by status. | [optional]  |
| **paymentStatus** | **string?** | Filter registration results by payment status. | [optional]  |
| **searchText** | **string?** | Filter registration results by first name, last name, or email address. | [optional]  |
| **sortBy** | **string?** | Specify the field to use to sort the results. | [optional]  |
| **sortOrder** | **string?** | Use to specify how you want the results sorted. | [optional]  |
| **pageSize** | **string?** | Alternative to the &lt;code&gt;limit&lt;/code&gt; parameter to limit the number of results returned per page. If specifying both the &lt;code&gt;limit&lt;/code&gt; and &lt;code&gt;page_size&lt;/code&gt; query parameters, they must be the same value. | [optional]  |
| **limit** | **string?** | Limit the number of results returned per page. If specifying both the &lt;code&gt;limit&lt;/code&gt; and &lt;code&gt;page_size&lt;/code&gt; query parameters, they must be the same value. | [optional]  |
| **prev** | **string?** | Cursor for pagination used to get the previous page of results (mutually exclusive with &lt;code&gt;next&lt;/code&gt;). | [optional]  |
| **next** | **string?** | Cursor for pagination used to get the next page of results (mutually exclusive with &lt;code&gt;prev&lt;/code&gt;). | [optional]  |

### Return type

[**FindRegistrationsUsingGET200Response**](FindRegistrationsUsingGET200Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved registrations |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getevent2"></a>
# **GetEvent2**
> CreateEvent201Response GetEvent2 (string eventId, bool? include = null)

GET details for a single event.

Specify the `event_id` path parameter to retrieve the event's details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetEvent2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 1697732a-8664-4675-8415-c4aabaa17dae;  // string | The ID that uniquely identifies the event.
            var include = true;  // bool? | Use to include (`true`) or exclude (`false`) event setting properties in the results. (optional) 

            try
            {
                // GET details for a single event.
                CreateEvent201Response result = apiInstance.GetEvent2(eventId, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvent2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEvent2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET details for a single event.
    ApiResponse<CreateEvent201Response> response = apiInstance.GetEvent2WithHttpInfo(eventId, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEvent2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **include** | **bool?** | Use to include (&#x60;true&#x60;) or exclude (&#x60;false&#x60;) event setting properties in the results. | [optional]  |

### Return type

[**CreateEvent201Response**](CreateEvent201Response.md)

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
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getregistrationinfo"></a>
# **GetRegistrationInfo**
> GetRegistrationInfo200Response GetRegistrationInfo (string eventId, string trackId, string registrationId)

Get registration details for an event.

Use the `event_id`, `registration_id`, and `track_id` path parameters to get registration details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetRegistrationInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 1697732a-8664-4675-8415-c4aabaa17dae;  // string | The ID that uniquely identifies the event.
            var trackId = s8zabc;  // string | The track key that uniquely identifies the event track.
            var registrationId = a1b2c3d4-e5f6-7890-abcd-ef1234567890;  // string | The ID that uniquely identifies the registration.

            try
            {
                // Get registration details for an event.
                GetRegistrationInfo200Response result = apiInstance.GetRegistrationInfo(eventId, trackId, registrationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetRegistrationInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRegistrationInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get registration details for an event.
    ApiResponse<GetRegistrationInfo200Response> response = apiInstance.GetRegistrationInfoWithHttpInfo(eventId, trackId, registrationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetRegistrationInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **trackId** | **string** | The track key that uniquely identifies the event track. |  |
| **registrationId** | **string** | The ID that uniquely identifies the registration. |  |

### Return type

[**GetRegistrationInfo200Response**](GetRegistrationInfo200Response.md)

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
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="undocheckintickets"></a>
# **UndoCheckInTickets**
> void UndoCheckInTickets (string eventId, CheckInTicketsRequest checkInTicketsRequest)

Undo event ticket check-in.

Use this endpoint to undo check-in for one or more tickets, marking them as not checked in. The event must be in `ACTIVE` or `COMPLETE` status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UndoCheckInTicketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 07216444-4e3b-41ea-a3b8-5a418fce41f4;  // string | The ID that uniquely identifies the event.
            var checkInTicketsRequest = new CheckInTicketsRequest(); // CheckInTicketsRequest | Set of order ticket keys to mark as not checked in.

            try
            {
                // Undo event ticket check-in.
                apiInstance.UndoCheckInTickets(eventId, checkInTicketsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UndoCheckInTickets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UndoCheckInTicketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Undo event ticket check-in.
    apiInstance.UndoCheckInTicketsWithHttpInfo(eventId, checkInTicketsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.UndoCheckInTicketsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **checkInTicketsRequest** | [**CheckInTicketsRequest**](CheckInTicketsRequest.md) | Set of order ticket keys to mark as not checked in. |  |

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
| **204** | Successfully undone check-in for order tickets. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateevent"></a>
# **UpdateEvent**
> void UpdateEvent (string eventId, CreateEvent201Response createEvent201Response)

PATCH (update) an event.

Partially updates an event with the provided fields. Only the specified fields will be updated. This endpoint only works for events in DRAFT or ACTIVE status. Events in COMPLETE, CANCELED, or DELETED status cannot be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 1697732a-8664-4675-8415-c4aabaa17dae;  // string | The ID that uniquely identifies the event to update.
            var createEvent201Response = new CreateEvent201Response(); // CreateEvent201Response | A JSON request body containing the event fields to update.

            try
            {
                // PATCH (update) an event.
                apiInstance.UpdateEvent(eventId, createEvent201Response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UpdateEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PATCH (update) an event.
    apiInstance.UpdateEventWithHttpInfo(eventId, createEvent201Response);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.UpdateEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event to update. |  |
| **createEvent201Response** | [**CreateEvent201Response**](CreateEvent201Response.md) | A JSON request body containing the event fields to update. |  |

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
| **204** | Event updated successfully |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateregistrationpaymentstatususingput"></a>
# **UpdateRegistrationPaymentStatusUsingPUT**
> void UpdateRegistrationPaymentStatusUsingPUT (string eventId, string trackId, UpdateRegistrationPaymentStatusUsingPUTRequest updateRegistrationPaymentStatusUsingPUTRequest)

Update payment status for event registrations.

Use this endpoint to update the payment status for one or more registrations. This endpoint only processes registrations with a payment method (PAYPAL, WEPAY, STRIPE, DOOR, or CHECK). Free registrations without a payment method are silently excluded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateRegistrationPaymentStatusUsingPUTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = c5da3665-88f9-4b15-82bc-cd6593c32537;  // string | The ID that uniquely identifies the event.
            var trackId = 2unzqq;  // string | The track key that uniquely identifies the event track.
            var updateRegistrationPaymentStatusUsingPUTRequest = new UpdateRegistrationPaymentStatusUsingPUTRequest(); // UpdateRegistrationPaymentStatusUsingPUTRequest | Payment status update request data.

            try
            {
                // Update payment status for event registrations.
                apiInstance.UpdateRegistrationPaymentStatusUsingPUT(eventId, trackId, updateRegistrationPaymentStatusUsingPUTRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UpdateRegistrationPaymentStatusUsingPUT: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRegistrationPaymentStatusUsingPUTWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update payment status for event registrations.
    apiInstance.UpdateRegistrationPaymentStatusUsingPUTWithHttpInfo(eventId, trackId, updateRegistrationPaymentStatusUsingPUTRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.UpdateRegistrationPaymentStatusUsingPUTWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **trackId** | **string** | The track key that uniquely identifies the event track. |  |
| **updateRegistrationPaymentStatusUsingPUTRequest** | [**UpdateRegistrationPaymentStatusUsingPUTRequest**](UpdateRegistrationPaymentStatusUsingPUTRequest.md) | Payment status update request data. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated payment status. |  -  |
| **207** | Some registrations failed to update. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateregistrationstatususingput"></a>
# **UpdateRegistrationStatusUsingPUT**
> void UpdateRegistrationStatusUsingPUT (string eventId, string trackId, UpdateRegistrationStatusUsingPUTRequest updateRegistrationStatusUsingPUTRequest, bool? increaseCount = null, bool? increaseItemCount = null, bool? returnItemsToInventory = null)

Update status for event registrations.

Use this endpoint to update the registration status for one or more registrations within an event track.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class UpdateRegistrationStatusUsingPUTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 07216444-4e3b-41ea-a3b8-5a418fce41f4;  // string | The ID that uniquely identifies the event.
            var trackId = gqz1gb;  // string | The track key that uniquely identifies the event track.
            var updateRegistrationStatusUsingPUTRequest = new UpdateRegistrationStatusUsingPUTRequest(); // UpdateRegistrationStatusUsingPUTRequest | Registration status update request data.
            var increaseCount = true;  // bool? | Override count flag. (optional) 
            var increaseItemCount = true;  // bool? | Override item count flag. (optional) 
            var returnItemsToInventory = true;  // bool? | Return items to inventory flag. Defaults to `true`. (optional) 

            try
            {
                // Update status for event registrations.
                apiInstance.UpdateRegistrationStatusUsingPUT(eventId, trackId, updateRegistrationStatusUsingPUTRequest, increaseCount, increaseItemCount, returnItemsToInventory);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UpdateRegistrationStatusUsingPUT: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRegistrationStatusUsingPUTWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update status for event registrations.
    apiInstance.UpdateRegistrationStatusUsingPUTWithHttpInfo(eventId, trackId, updateRegistrationStatusUsingPUTRequest, increaseCount, increaseItemCount, returnItemsToInventory);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.UpdateRegistrationStatusUsingPUTWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | The ID that uniquely identifies the event. |  |
| **trackId** | **string** | The track key that uniquely identifies the event track. |  |
| **updateRegistrationStatusUsingPUTRequest** | [**UpdateRegistrationStatusUsingPUTRequest**](UpdateRegistrationStatusUsingPUTRequest.md) | Registration status update request data. |  |
| **increaseCount** | **bool?** | Override count flag. | [optional]  |
| **increaseItemCount** | **bool?** | Override item count flag. | [optional]  |
| **returnItemsToInventory** | **bool?** | Return items to inventory flag. Defaults to &#x60;true&#x60;. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated registration status. |  -  |
| **207** | Some registrations failed to update. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | There was a problem with our internal service. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

