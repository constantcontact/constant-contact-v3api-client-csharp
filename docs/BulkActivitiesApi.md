# ConstantContactApi.Api.BulkActivitiesApi

All URIs are relative to *https://api.cc.email/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCSVImportActivity**](BulkActivitiesApi.md#createcsvimportactivity) | **POST** /activities/contacts_file_import | Import Contacts using a CSV File |
| [**CreateDeleteActivity**](BulkActivitiesApi.md#createdeleteactivity) | **POST** /activities/contact_delete | Delete Contacts in Bulk |
| [**CreateExportActivity**](BulkActivitiesApi.md#createexportactivity) | **POST** /activities/contact_exports | Export Contacts to a File |
| [**CreateImportJSONActivity**](BulkActivitiesApi.md#createimportjsonactivity) | **POST** /activities/contacts_json_import | Import Contacts using a JSON Payload |
| [**CreateListAddActivity**](BulkActivitiesApi.md#createlistaddactivity) | **POST** /activities/add_list_memberships | Add Contacts to Lists |
| [**CreateListDeleteActivity**](BulkActivitiesApi.md#createlistdeleteactivity) | **POST** /activities/list_delete | Delete Contact Lists |
| [**CreateListRemoveActivity**](BulkActivitiesApi.md#createlistremoveactivity) | **POST** /activities/remove_list_memberships | Remove Contacts from Lists |
| [**CreateTagAddContactActivity**](BulkActivitiesApi.md#createtagaddcontactactivity) | **POST** /activities/contacts_taggings_add | Add Tags to Contacts |
| [**CreateTagDeleteActivity**](BulkActivitiesApi.md#createtagdeleteactivity) | **POST** /activities/contacts_tags_delete | Delete Tags |
| [**CreateTagRemoveActivity**](BulkActivitiesApi.md#createtagremoveactivity) | **POST** /activities/contacts_taggings_remove | Remove Tags from Contacts |
| [**GetActivityById**](BulkActivitiesApi.md#getactivitybyid) | **GET** /activities/{activity_id} | GET an Activity Status |
| [**GetAllActivities**](BulkActivitiesApi.md#getallactivities) | **GET** /activities | GET Activity Status Collection |
| [**GetCSVExportFile**](BulkActivitiesApi.md#getcsvexportfile) | **GET** /contact_exports/{file_export_id} | Retrieve Exported Contacts File |
| [**PostCustomFieldDelete**](BulkActivitiesApi.md#postcustomfielddelete) | **POST** /activities/custom_fields_delete | Delete Custom Fields |

<a id="createcsvimportactivity"></a>
# **CreateCSVImportActivity**
> CreateCSVImportActivity201Response CreateCSVImportActivity (System.IO.Stream file, string listIds, string? smsPermissionToSend = null)

Import Contacts using a CSV File

This multipart method creates an asynchronous background job that adds or updates contacts by importing a CSV file containing contact information. Do not use a Content-Type header value with this method.  Importing a new contact email address automatically sets the contact's `permission_to_send` property as `implicit` and the `opt_in_source` property as `Account`. Importing an existing contact only updates the contact properties you include in the request. Importing contacts with `sms_number`s requires using the `sms_permission_to_send` parameter  to specify permissions for all contacts being imported. Set to `explicit` to specify that all contacts either provided explicit permission. Set to `not_set` if permission was not provided. If `explicit`, you must also include the `sms_consent_date` as a column header to include the date the contact consented to receiving SMS messages. Contacts must have either an email address or an SMS number defined.   The CSV file has a maximum of 40,000 lines including the header row (39,999 contacts) and a maximum file size of 4 megabytes (MB).  Lines above the 40,000 line maximum are not processed. If the request body exceeds 4 MB, only the contacts contained in the first 4 MB are imported and the remaining data is dropped.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateCSVImportActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | The CSV file you are importing  must include either `email` or `sms_number` as a column heading. Other properties you can include using column headings are: `first_name`.  `last_name`, `phone`, `job_title`, `anniversary`, `birthday_day`, `birthday_month`, `company_name`, `street`, `street2`, `city`, `state`, `zip`, `country`, and `sms_consent_date`.   If adding an `sms_number`, you must also include the `sms_permission_to_send` parameter and set it to either `not_set` or `explicit`. If `explicit`, requires including `sms_consent_date` as a column header to specify the date the contact consented to receiving SMS messages.   You can also use custom fields as column headings. Enter the custom field name prefixed with `cf:` as the column heading. For example, use `cf:first_name` as the header name if you have a custom field named \\\"first_name\\\". The custom field must already exist in the Constant Contact account you are using. Depending on the custom field data type, you can enter dates or strings as the value of the custom field. Each contact can contain up to 25 different custom fields.
            var listIds = "listIds_example";  // string | Specify which contact lists you are adding all imported contacts to as an array of up to 50 contact `list_id` values.
            var smsPermissionToSend = "not_set";  // string? | If importing contact `sms_number`s, use this parameter to specify how SMS consent was provided. If all contacts in the file provided their consent, set to `explicit` and include each contact's `sms_consent_date`. If all contacts in the file have not yet provided consent, set to `not_set` (`sms_consent_date` is not required). You cannot message a contact that does not have a sms consent date set. (optional) 

            try
            {
                // Import Contacts using a CSV File
                CreateCSVImportActivity201Response result = apiInstance.CreateCSVImportActivity(file, listIds, smsPermissionToSend);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateCSVImportActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCSVImportActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Contacts using a CSV File
    ApiResponse<CreateCSVImportActivity201Response> response = apiInstance.CreateCSVImportActivityWithHttpInfo(file, listIds, smsPermissionToSend);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateCSVImportActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | The CSV file you are importing  must include either &#x60;email&#x60; or &#x60;sms_number&#x60; as a column heading. Other properties you can include using column headings are: &#x60;first_name&#x60;.  &#x60;last_name&#x60;, &#x60;phone&#x60;, &#x60;job_title&#x60;, &#x60;anniversary&#x60;, &#x60;birthday_day&#x60;, &#x60;birthday_month&#x60;, &#x60;company_name&#x60;, &#x60;street&#x60;, &#x60;street2&#x60;, &#x60;city&#x60;, &#x60;state&#x60;, &#x60;zip&#x60;, &#x60;country&#x60;, and &#x60;sms_consent_date&#x60;.   If adding an &#x60;sms_number&#x60;, you must also include the &#x60;sms_permission_to_send&#x60; parameter and set it to either &#x60;not_set&#x60; or &#x60;explicit&#x60;. If &#x60;explicit&#x60;, requires including &#x60;sms_consent_date&#x60; as a column header to specify the date the contact consented to receiving SMS messages.   You can also use custom fields as column headings. Enter the custom field name prefixed with &#x60;cf:&#x60; as the column heading. For example, use &#x60;cf:first_name&#x60; as the header name if you have a custom field named \\\&quot;first_name\\\&quot;. The custom field must already exist in the Constant Contact account you are using. Depending on the custom field data type, you can enter dates or strings as the value of the custom field. Each contact can contain up to 25 different custom fields. |  |
| **listIds** | **string** | Specify which contact lists you are adding all imported contacts to as an array of up to 50 contact &#x60;list_id&#x60; values. |  |
| **smsPermissionToSend** | **string?** | If importing contact &#x60;sms_number&#x60;s, use this parameter to specify how SMS consent was provided. If all contacts in the file provided their consent, set to &#x60;explicit&#x60; and include each contact&#39;s &#x60;sms_consent_date&#x60;. If all contacts in the file have not yet provided consent, set to &#x60;not_set&#x60; (&#x60;sms_consent_date&#x60; is not required). You cannot message a contact that does not have a sms consent date set. | [optional]  |

### Return type

[**CreateCSVImportActivity201Response**](CreateCSVImportActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **415** | 1. This endpoint requires that Content-Type be unspecified 2. Wrong file format, upload file must be of type .csv |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdeleteactivity"></a>
# **CreateDeleteActivity**
> CreateDeleteActivity201Response CreateDeleteActivity (CreateDeleteActivityRequest createDeleteActivityRequest)

Delete Contacts in Bulk

Use this endpoint to bulk delete contacts in an account. Contacts to delete are specified by contact_id (up to 500), or by list_id (up to 50 lists); all contacts that are members of the list_ids are deleted. Deleted contacts won’t receive email from you, and they don’t count as active contacts. Unlike unsubscribed contacts, deleted contacts can be added back to an account. [Learn how to revive deleted contacts](/api_guide/contacts_delete.html#revive).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateDeleteActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createDeleteActivityRequest = new CreateDeleteActivityRequest(); // CreateDeleteActivityRequest | The request body contains an array of contact_ids <em>or</em> list_ids. All contact_ids provided are deleted, or all members of each specified list_id are deleted.

            try
            {
                // Delete Contacts in Bulk
                CreateDeleteActivity201Response result = apiInstance.CreateDeleteActivity(createDeleteActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateDeleteActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDeleteActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Contacts in Bulk
    ApiResponse<CreateDeleteActivity201Response> response = apiInstance.CreateDeleteActivityWithHttpInfo(createDeleteActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateDeleteActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDeleteActivityRequest** | [**CreateDeleteActivityRequest**](CreateDeleteActivityRequest.md) | The request body contains an array of contact_ids &lt;em&gt;or&lt;/em&gt; list_ids. All contact_ids provided are deleted, or all members of each specified list_id are deleted. |  |

### Return type

[**CreateDeleteActivity201Response**](CreateDeleteActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createexportactivity"></a>
# **CreateExportActivity**
> CreateExportActivity201Response CreateExportActivity (CreateExportActivityRequest createExportActivityRequest)

Export Contacts to a File

Use this method to create an activity that exports contacts and contact details to a CSV file.  You can choose to export all contacts in your account (default) or you can use parameters to filter on which contacts to export. After Constant Contact finishes processing the activity, use the `results` link in the response body to retrieve the CSV file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateExportActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createExportActivityRequest = new CreateExportActivityRequest(); // CreateExportActivityRequest | A JSON payload that specifies the contacts (rows in the CSV file) and contact properties (columns in the CSV file) you want to export.

            try
            {
                // Export Contacts to a File
                CreateExportActivity201Response result = apiInstance.CreateExportActivity(createExportActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateExportActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateExportActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export Contacts to a File
    ApiResponse<CreateExportActivity201Response> response = apiInstance.CreateExportActivityWithHttpInfo(createExportActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateExportActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createExportActivityRequest** | [**CreateExportActivityRequest**](CreateExportActivityRequest.md) | A JSON payload that specifies the contacts (rows in the CSV file) and contact properties (columns in the CSV file) you want to export. |  |

### Return type

[**CreateExportActivity201Response**](CreateExportActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful, queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createimportjsonactivity"></a>
# **CreateImportJSONActivity**
> CreateCSVImportActivity201Response CreateImportJSONActivity (CreateImportJSONActivityRequest createImportJSONActivityRequest)

Import Contacts using a JSON Payload

Use this method to create an asynchronous background job that adds new contacts or updates existing contacts by importing a JSON payload. This method requires a request body that contains the contact data you are importing and the contact lists to which you want to add the imported contacts. A contact's data must include an `email` address and/or `sms_number`. The `sms_number` must be a US phone number to associate with the contact's SMS-enabled phone. Valid formats are <code>1231231234</code> or <code>123-123-1234</code> (the country code must be valid).  Importing a new contact using this method automatically sets the contact's email `permission_to_send` property to `implicit` and the `opt_in_source` property as `Account`. Importing an existing contact only updates the contact properties you include in the request. For each contact, you can import up to three addresses and three phone numbers. International phone numbers are currently not supported.        To import custom fields, prefix the custom field name with `cf:` and add it as a contact property. For example, use the property name `cf:first_name` if you have a custom field named `first_name`. The custom field must already exist in the Constant Contact account you are using. Each contact can contain up to 25 custom fields.  To include a contact's `sms_number`, if the contact provided explicit permission to receive SMS messages, you must set the `sms_permission_to_send` property to `explicit` and specify the date of consent using the `sms_consent_date` column header. If explicit permission was not provided, set `sms_permission_to_send` to `not_set` (the `sms_consent_date` is not required). If the `sms_consent_date` is not set, SMS messages cannot be sent to contacts and `sms_permission_to_send` defaults to `not_set`. Valid value formats for `sms_consent_date` include MM/DD/YYYY, M/D/YYYY, YYYY/MM/DD, YYYY/M/D, YYYY-MM-DD, YYYY-M-D,M-D-YYYY, or M-DD-YYYY.   The request body payload has a maximum size of 4 megabytes (MB). If the request body exceeds 4 MB, this method only imports the first 4 MB and drops the remaining data. Use the activity URL to check the status of the import activity request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateImportJSONActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createImportJSONActivityRequest = new CreateImportJSONActivityRequest(); // CreateImportJSONActivityRequest | The JSON request payload that contains the contact data and contact lists for the import.

            try
            {
                // Import Contacts using a JSON Payload
                CreateCSVImportActivity201Response result = apiInstance.CreateImportJSONActivity(createImportJSONActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateImportJSONActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateImportJSONActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import Contacts using a JSON Payload
    ApiResponse<CreateCSVImportActivity201Response> response = apiInstance.CreateImportJSONActivityWithHttpInfo(createImportJSONActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateImportJSONActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createImportJSONActivityRequest** | [**CreateImportJSONActivityRequest**](CreateImportJSONActivityRequest.md) | The JSON request payload that contains the contact data and contact lists for the import. |  |

### Return type

[**CreateCSVImportActivity201Response**](CreateCSVImportActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlistaddactivity"></a>
# **CreateListAddActivity**
> CreateListRemoveActivity201Response CreateListAddActivity (CreateListAddActivityRequest createListAddActivityRequest)

Add Contacts to Lists

Use this method to create an activity that adds contacts to one or more lists. Each contact can be a member of up to 50 lists. Use the properties in the `source` object to specify the contacts you want to add to lists. Use the `list_ids` array to specify which lists you want to add your source contacts to.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateListAddActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createListAddActivityRequest = new CreateListAddActivityRequest(); // CreateListAddActivityRequest | The JSON payload used to create the 'add contacts to lists' activity

            try
            {
                // Add Contacts to Lists
                CreateListRemoveActivity201Response result = apiInstance.CreateListAddActivity(createListAddActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateListAddActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateListAddActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Contacts to Lists
    ApiResponse<CreateListRemoveActivity201Response> response = apiInstance.CreateListAddActivityWithHttpInfo(createListAddActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateListAddActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createListAddActivityRequest** | [**CreateListAddActivityRequest**](CreateListAddActivityRequest.md) | The JSON payload used to create the &#39;add contacts to lists&#39; activity |  |

### Return type

[**CreateListRemoveActivity201Response**](CreateListRemoveActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlistdeleteactivity"></a>
# **CreateListDeleteActivity**
> CreateListDeleteActivity201Response CreateListDeleteActivity (CreateListDeleteActivityRequest createListDeleteActivityRequest)

Delete Contact Lists

Use this endpoint to delete up to 100 contact lists in an account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateListDeleteActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createListDeleteActivityRequest = new CreateListDeleteActivityRequest(); // CreateListDeleteActivityRequest | An array of `list_id`'s to delete.

            try
            {
                // Delete Contact Lists
                CreateListDeleteActivity201Response result = apiInstance.CreateListDeleteActivity(createListDeleteActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateListDeleteActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateListDeleteActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Contact Lists
    ApiResponse<CreateListDeleteActivity201Response> response = apiInstance.CreateListDeleteActivityWithHttpInfo(createListDeleteActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateListDeleteActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createListDeleteActivityRequest** | [**CreateListDeleteActivityRequest**](CreateListDeleteActivityRequest.md) | An array of &#x60;list_id&#x60;&#39;s to delete. |  |

### Return type

[**CreateListDeleteActivity201Response**](CreateListDeleteActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlistremoveactivity"></a>
# **CreateListRemoveActivity**
> CreateListRemoveActivity201Response CreateListRemoveActivity (CreateListRemoveActivityRequest createListRemoveActivityRequest)

Remove Contacts from Lists

Use this method to create an activity that removes contacts from one or more contact lists. Use the properties in the `source` object to remove specific contacts from your lists. Use the `list_ids` array to specify the target lists from which contacts are removed. Optionally, if the source is  `all_active_contacts` (billable) or `list_ids`, use the `exclude` object to exclude specific contacts from being removed from the destination lists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateListRemoveActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createListRemoveActivityRequest = new CreateListRemoveActivityRequest(); // CreateListRemoveActivityRequest | The JSON payload used to create the Remove Contacts from Lists' activity

            try
            {
                // Remove Contacts from Lists
                CreateListRemoveActivity201Response result = apiInstance.CreateListRemoveActivity(createListRemoveActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateListRemoveActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateListRemoveActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Contacts from Lists
    ApiResponse<CreateListRemoveActivity201Response> response = apiInstance.CreateListRemoveActivityWithHttpInfo(createListRemoveActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateListRemoveActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createListRemoveActivityRequest** | [**CreateListRemoveActivityRequest**](CreateListRemoveActivityRequest.md) | The JSON payload used to create the Remove Contacts from Lists&#39; activity |  |

### Return type

[**CreateListRemoveActivity201Response**](CreateListRemoveActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtagaddcontactactivity"></a>
# **CreateTagAddContactActivity**
> CreateTagRemoveActivity201Response CreateTagAddContactActivity (CreateTagRemoveActivityRequest createTagRemoveActivityRequest)

Add Tags to Contacts

Use this method to create an asynchronous activity that adds one or more tags to all contacts meeting your contact filtering criteria. Use the `source` type to identify contacts from which the specified tags (`tag_id`) are added. Source criteria are mutually exclusive. If the source is `all_active_contacts` or `list_ids`, you can optionally choose to `exclude` contacts by `contact_id`. Use the activity link in the results to check the status of your request. For more use case information, see \"[Add Tags to Contacts](/api_guide/add_tagging_activity.html)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateTagAddContactActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createTagRemoveActivityRequest = new CreateTagRemoveActivityRequest(); // CreateTagRemoveActivityRequest | The JSON payload used to create an asynchronous activity that adds tags to contacts that meet your specified contact filtering criteria.

            try
            {
                // Add Tags to Contacts
                CreateTagRemoveActivity201Response result = apiInstance.CreateTagAddContactActivity(createTagRemoveActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateTagAddContactActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTagAddContactActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Tags to Contacts
    ApiResponse<CreateTagRemoveActivity201Response> response = apiInstance.CreateTagAddContactActivityWithHttpInfo(createTagRemoveActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateTagAddContactActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagRemoveActivityRequest** | [**CreateTagRemoveActivityRequest**](CreateTagRemoveActivityRequest.md) | The JSON payload used to create an asynchronous activity that adds tags to contacts that meet your specified contact filtering criteria. |  |

### Return type

[**CreateTagRemoveActivity201Response**](CreateTagRemoveActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtagdeleteactivity"></a>
# **CreateTagDeleteActivity**
> CreateTagRemoveActivity201Response CreateTagDeleteActivity (CreateTagDeleteActivityRequest createTagDeleteActivityRequest)

Delete Tags

Use this method to create an asynchronous activity that deletes up to 500 tags. Deleted tags are automatically removed from tagged contacts. Use the `tag_ids` array of string values in the request body to specify which tags to delete.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateTagDeleteActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createTagDeleteActivityRequest = new CreateTagDeleteActivityRequest(); // CreateTagDeleteActivityRequest | An array of string values (`tag_id`s) to delete.

            try
            {
                // Delete Tags
                CreateTagRemoveActivity201Response result = apiInstance.CreateTagDeleteActivity(createTagDeleteActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateTagDeleteActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTagDeleteActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Tags
    ApiResponse<CreateTagRemoveActivity201Response> response = apiInstance.CreateTagDeleteActivityWithHttpInfo(createTagDeleteActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateTagDeleteActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagDeleteActivityRequest** | [**CreateTagDeleteActivityRequest**](CreateTagDeleteActivityRequest.md) | An array of string values (&#x60;tag_id&#x60;s) to delete. |  |

### Return type

[**CreateTagRemoveActivity201Response**](CreateTagRemoveActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtagremoveactivity"></a>
# **CreateTagRemoveActivity**
> CreateTagRemoveActivity201Response CreateTagRemoveActivity (CreateTagRemoveActivityRequest createTagRemoveActivityRequest)

Remove Tags from Contacts

Use this method to create an asynchronous activity that removes one or more tags from all contacts meeting your contact filtering criteria. Filtering criteria must include the `source` type used to identify contacts from which the specified tags (`tag_id`) are removed. Source types are mutually exclusive. If the specified source is either `all_active_contacts` or `list_ids`, you can optionally choose to `exclude` specified contacts by `contact_id`. Use the activity link in the results to check the status of your request.\" For more use case information, see \"[Remove Tags from Contacts](/api_guide/remove_tagging_activity.html)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class CreateTagRemoveActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var createTagRemoveActivityRequest = new CreateTagRemoveActivityRequest(); // CreateTagRemoveActivityRequest | The JSON payload used to create an asynchronous activity that removes tags from contacts meeting your specified contact filtering criteria.

            try
            {
                // Remove Tags from Contacts
                CreateTagRemoveActivity201Response result = apiInstance.CreateTagRemoveActivity(createTagRemoveActivityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.CreateTagRemoveActivity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTagRemoveActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Tags from Contacts
    ApiResponse<CreateTagRemoveActivity201Response> response = apiInstance.CreateTagRemoveActivityWithHttpInfo(createTagRemoveActivityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.CreateTagRemoveActivityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagRemoveActivityRequest** | [**CreateTagRemoveActivityRequest**](CreateTagRemoveActivityRequest.md) | The JSON payload used to create an asynchronous activity that removes tags from contacts meeting your specified contact filtering criteria. |  |

### Return type

[**CreateTagRemoveActivity201Response**](CreateTagRemoveActivity201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getactivitybyid"></a>
# **GetActivityById**
> GetActivityById200Response GetActivityById (string activityId)

GET an Activity Status

This endpoint returns an activity status report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetActivityByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var activityId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | The unique ID of the activity to GET

            try
            {
                // GET an Activity Status
                GetActivityById200Response result = apiInstance.GetActivityById(activityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.GetActivityById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActivityByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET an Activity Status
    ApiResponse<GetActivityById200Response> response = apiInstance.GetActivityByIdWithHttpInfo(activityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.GetActivityByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activityId** | **string** | The unique ID of the activity to GET |  |

### Return type

[**GetActivityById200Response**](GetActivityById200Response.md)

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
| **404** | Resource not found for the activity_id provided |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallactivities"></a>
# **GetAllActivities**
> GetAllActivities200Response GetAllActivities (int? limit = null, string? state = null)

GET Activity Status Collection

This endpoint returns a collection of activities. Use the state query parameter to include only activities with a specific status (processing, completed, cancelled, failed, or time_out). Use the limit query parameter to define the number of activities returned per page. Learn [more](/api_guide/activity_status.html).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetAllActivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var limit = 25;  // int? | Specifies the number of results displayed per page of output, from 1 - 500, default = 50. (optional)  (default to 50)
            var state = processing;  // string? | Use this parameter to filter the response to include only activities in one of the following states: cancelled, completed, failed, processing, or timed_out. (optional) 

            try
            {
                // GET Activity Status Collection
                GetAllActivities200Response result = apiInstance.GetAllActivities(limit, state);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.GetAllActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Activity Status Collection
    ApiResponse<GetAllActivities200Response> response = apiInstance.GetAllActivitiesWithHttpInfo(limit, state);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.GetAllActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Specifies the number of results displayed per page of output, from 1 - 500, default &#x3D; 50. | [optional] [default to 50] |
| **state** | **string?** | Use this parameter to filter the response to include only activities in one of the following states: cancelled, completed, failed, processing, or timed_out. | [optional]  |

### Return type

[**GetAllActivities200Response**](GetAllActivities200Response.md)

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

<a id="getcsvexportfile"></a>
# **GetCSVExportFile**
> string GetCSVExportFile (string fileExportId)

Retrieve Exported Contacts File

Use this endpoint to retrieve (GET) a CSV file containing exported contacts by providing the `activity_id` of a completed CSV export activity.  

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class GetCSVExportFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var fileExportId = 04fe9a-a579-43c5-bb1a-58ed29bf0a6a;  // string | The unique ID of the exported file provided in the results: section of the export contacts activity response.

            try
            {
                // Retrieve Exported Contacts File
                string result = apiInstance.GetCSVExportFile(fileExportId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.GetCSVExportFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCSVExportFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Exported Contacts File
    ApiResponse<string> response = apiInstance.GetCSVExportFileWithHttpInfo(fileExportId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.GetCSVExportFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileExportId** | **string** | The unique ID of the exported file provided in the results: section of the export contacts activity response. |  |

### Return type

**string**

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request Successful |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postcustomfielddelete"></a>
# **PostCustomFieldDelete**
> PostCustomFieldDelete201Response PostCustomFieldDelete (PostCustomFieldDeleteRequest postCustomFieldDeleteRequest)

Delete Custom Fields

Use this endpoint to delete up to 100 custom fields for an account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
    public class PostCustomFieldDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cc.email/v3";
            // Configure OAuth2 access token for authorization: oauth2_access_code
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_implicit
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkActivitiesApi(config);
            var postCustomFieldDeleteRequest = new PostCustomFieldDeleteRequest(); // PostCustomFieldDeleteRequest | An array of `custom_field_id`'s to delete.

            try
            {
                // Delete Custom Fields
                PostCustomFieldDelete201Response result = apiInstance.PostCustomFieldDelete(postCustomFieldDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BulkActivitiesApi.PostCustomFieldDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCustomFieldDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Custom Fields
    ApiResponse<PostCustomFieldDelete201Response> response = apiInstance.PostCustomFieldDeleteWithHttpInfo(postCustomFieldDeleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BulkActivitiesApi.PostCustomFieldDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postCustomFieldDeleteRequest** | [**PostCustomFieldDeleteRequest**](PostCustomFieldDeleteRequest.md) | An array of &#x60;custom_field_id&#x60;&#39;s to delete. |  |

### Return type

[**PostCustomFieldDelete201Response**](PostCustomFieldDelete201Response.md)

### Authorization

[oauth2_access_code](../README.md#oauth2_access_code), [oauth2_implicit](../README.md#oauth2_implicit)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Request successful. Activity queued for processing. |  -  |
| **400** | Bad request. Either the JSON was malformed or there was a data validation error. |  -  |
| **401** | The Access Token used is invalid. |  -  |
| **403** | Forbidden request. You lack the necessary scopes, you lack the necessary user privileges, or the application is deactivated. |  -  |
| **404** | The requested resource was not found. |  -  |
| **429** | Too many requests. You exceeded 1,000 queued activities for this user account. |  -  |
| **500** | There was a problem with our internal service. |  -  |
| **503** | Our internal service is temporarily unavailable. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

