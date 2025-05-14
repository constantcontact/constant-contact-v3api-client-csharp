# ConstantContactApi - the C# library for the Constant Contact API v3

Swagger build version 3.0.62

This repository contains a C# SDK for the public Constant Contact API. The code was generated using [openapi-generator](https://github.com/OpenAPITools/openapi-generator).

- API version: 1.0.193
- SDK version: 1.0.0
- Generator version: 7.2.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 112.0.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;
```
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out ConstantContactApi.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ConstantContactApi.Api;
using ConstantContactApi.Client;
using ConstantContactApi.Model;

namespace Example
{
public class Example
{
public static void Main()
{

    Configuration config = new Configuration();
    config.BasePath = "https://api.cc.email/v3";
    // Configure Bearer token for authorization: oauth2_access_code
    config.AccessToken = "YOUR_BEARER_TOKEN";
    var apiInstance = new AccountServicesApi(config);
        var addAccountEmailAddressRequest = new AddAccountEmailAddressRequest(); // AddAccountEmailAddressRequest | A JSON request payload containing the new email address you want to add to the Constant Contact account.

    try
    {
        // POST Add an Account Email Address
AddAccountEmailAddress201Response result = apiInstance.AddAccountEmailAddress(addAccountEmailAddressRequest);
        Debug.WriteLine(result);
    }
    catch (ApiException e)
    {
    Debug.Print("Exception when calling AccountServicesApi.AddAccountEmailAddress: " + e.Message );
    Debug.Print("Status Code: "+ e.ErrorCode);
    Debug.Print(e.StackTrace);
    }

}
}
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.cc.email/v3*

| Class | Method | HTTP request | Description |
| ------------- | ------------- | ------------- | ------------- |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**AddAccountEmailAddress**](docs/AccountServicesApi.md#addaccountemailaddress) | **POST** /account/emails | POST Add an Account Email Address |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**AddPhysicalAddress**](docs/AccountServicesApi.md#addphysicaladdress) | **POST** /account/summary/physical_address | POST the Physical Address for the Account |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**GetAccountDetails**](docs/AccountServicesApi.md#getaccountdetails) | **GET** /account/summary | GET a Summary of Account Details |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**GetAccountPhysicalAddress**](docs/AccountServicesApi.md#getaccountphysicaladdress) | **GET** /account/summary/physical_address | GET the Physical Address for the Account |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**GetAllAccountEmailAddresses**](docs/AccountServicesApi.md#getallaccountemailaddresses) | **GET** /account/emails | GET a Collection of Account Email Addresses |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**GetUserPrivileges**](docs/AccountServicesApi.md#getuserprivileges) | **GET** /account/user/privileges | GET User Privileges |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**UpdateAccount**](docs/AccountServicesApi.md#updateaccount) | **PUT** /account/summary | PUT (update) Account Details |
| [**AccountServicesApi**](docs/AccountServicesApi.md) | [**UpdateAccountPhysicalAddress**](docs/AccountServicesApi.md#updateaccountphysicaladdress) | **PUT** /account/summary/physical_address | PUT (update) the Physical Address for an Account |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateCSVImportActivity**](docs/BulkActivitiesApi.md#createcsvimportactivity) | **POST** /activities/contacts_file_import | Import Contacts using a CSV File |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateDeleteActivity**](docs/BulkActivitiesApi.md#createdeleteactivity) | **POST** /activities/contact_delete | Delete Contacts in Bulk |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateExportActivity**](docs/BulkActivitiesApi.md#createexportactivity) | **POST** /activities/contact_exports | Export Contacts to a File |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateImportJSONActivity**](docs/BulkActivitiesApi.md#createimportjsonactivity) | **POST** /activities/contacts_json_import | Import Contacts using a JSON Payload |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateListAddActivity**](docs/BulkActivitiesApi.md#createlistaddactivity) | **POST** /activities/add_list_memberships | Add Contacts to Lists |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateListDeleteActivity**](docs/BulkActivitiesApi.md#createlistdeleteactivity) | **POST** /activities/list_delete | Delete Contact Lists |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateListRemoveActivity**](docs/BulkActivitiesApi.md#createlistremoveactivity) | **POST** /activities/remove_list_memberships | Remove Contacts from Lists |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateTagAddContactActivity**](docs/BulkActivitiesApi.md#createtagaddcontactactivity) | **POST** /activities/contacts_taggings_add | Add Tags to Contacts |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateTagDeleteActivity**](docs/BulkActivitiesApi.md#createtagdeleteactivity) | **POST** /activities/contacts_tags_delete | Delete Tags |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**CreateTagRemoveActivity**](docs/BulkActivitiesApi.md#createtagremoveactivity) | **POST** /activities/contacts_taggings_remove | Remove Tags from Contacts |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**GetActivityById**](docs/BulkActivitiesApi.md#getactivitybyid) | **GET** /activities/{activity_id} | GET an Activity Status |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**GetAllActivities**](docs/BulkActivitiesApi.md#getallactivities) | **GET** /activities | GET Activity Status Collection |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**GetCSVExportFile**](docs/BulkActivitiesApi.md#getcsvexportfile) | **GET** /contact_exports/{file_export_id} | Retrieve Exported Contacts File |
| [**BulkActivitiesApi**](docs/BulkActivitiesApi.md) | [**PostCustomFieldDelete**](docs/BulkActivitiesApi.md#postcustomfielddelete) | **POST** /activities/custom_fields_delete | Delete Custom Fields |
| [**ContactListsApi**](docs/ContactListsApi.md) | [**CreateList**](docs/ContactListsApi.md#createlist) | **POST** /contact_lists | POST (create) a List |
| [**ContactListsApi**](docs/ContactListsApi.md) | [**DeleteList**](docs/ContactListsApi.md#deletelist) | **DELETE** /contact_lists/{list_id} | DELETE a List |
| [**ContactListsApi**](docs/ContactListsApi.md) | [**GetAllLists**](docs/ContactListsApi.md#getalllists) | **GET** /contact_lists | GET Lists Collection |
| [**ContactListsApi**](docs/ContactListsApi.md) | [**GetList**](docs/ContactListsApi.md#getlist) | **GET** /contact_lists/{list_id} | GET a List |
| [**ContactListsApi**](docs/ContactListsApi.md) | [**GetListIdXrefs**](docs/ContactListsApi.md#getlistidxrefs) | **GET** /contact_lists/list_id_xrefs | GET a collection of V2 and V3 API List IDs |
| [**ContactListsApi**](docs/ContactListsApi.md) | [**UpdateList**](docs/ContactListsApi.md#updatelist) | **PUT** /contact_lists/{list_id} | PUT (update) a List |
| [**ContactTagsApi**](docs/ContactTagsApi.md) | [**DeleteTag**](docs/ContactTagsApi.md#deletetag) | **DELETE** /contact_tags/{tag_id} | DELETE a Tag |
| [**ContactTagsApi**](docs/ContactTagsApi.md) | [**GetAllTags**](docs/ContactTagsApi.md#getalltags) | **GET** /contact_tags | GET Details for All Tags |
| [**ContactTagsApi**](docs/ContactTagsApi.md) | [**GetTag**](docs/ContactTagsApi.md#gettag) | **GET** /contact_tags/{tag_id} | GET Tag Details |
| [**ContactTagsApi**](docs/ContactTagsApi.md) | [**PostTag**](docs/ContactTagsApi.md#posttag) | **POST** /contact_tags | POST (Create) a Tag |
| [**ContactTagsApi**](docs/ContactTagsApi.md) | [**PutTag**](docs/ContactTagsApi.md#puttag) | **PUT** /contact_tags/{tag_id} | PUT (Update) a Tag |
| [**ContactsApi**](docs/ContactsApi.md) | [**CreateContact**](docs/ContactsApi.md#createcontact) | **POST** /contacts | POST (create) a Contact |
| [**ContactsApi**](docs/ContactsApi.md) | [**CreateOrUpdateContact**](docs/ContactsApi.md#createorupdatecontact) | **POST** /contacts/sign_up_form | Create or Update a Contact |
| [**ContactsApi**](docs/ContactsApi.md) | [**DeleteContact**](docs/ContactsApi.md#deletecontact) | **DELETE** /contacts/{contact_id} | DELETE a Contact |
| [**ContactsApi**](docs/ContactsApi.md) | [**GetAllContacts**](docs/ContactsApi.md#getallcontacts) | **GET** /contacts | GET Contacts Collection |
| [**ContactsApi**](docs/ContactsApi.md) | [**GetContactById**](docs/ContactsApi.md#getcontactbyid) | **GET** /contacts/{contact_id} | GET a Contact |
| [**ContactsApi**](docs/ContactsApi.md) | [**GetContactCounts**](docs/ContactsApi.md#getcontactcounts) | **GET** /contacts/counts | GET Contact Consent Counts |
| [**ContactsApi**](docs/ContactsApi.md) | [**GetContactIdXrefs**](docs/ContactsApi.md#getcontactidxrefs) | **GET** /contacts/contact_id_xrefs | GET a collection of V2 and V3 API contact IDs |
| [**ContactsApi**](docs/ContactsApi.md) | [**GetSmsEngagementHistory**](docs/ContactsApi.md#getsmsengagementhistory) | **GET** /contacts/sms_engagement_history/{contact_id} | GET SMS Engagement History for a Contact |
| [**ContactsApi**](docs/ContactsApi.md) | [**ResubscribeContact**](docs/ContactsApi.md#resubscribecontact) | **PUT** /contacts/resubscribe/{contact_id} | PUT Resubscribe a Contact |
| [**ContactsApi**](docs/ContactsApi.md) | [**UpdateContact**](docs/ContactsApi.md#updatecontact) | **PUT** /contacts/{contact_id} | PUT (update) a Contact |
| [**ContactsCustomFieldsApi**](docs/ContactsCustomFieldsApi.md) | [**CreateCustomFields**](docs/ContactsCustomFieldsApi.md#createcustomfields) | **POST** /contact_custom_fields | POST (create) a custom_field |
| [**ContactsCustomFieldsApi**](docs/ContactsCustomFieldsApi.md) | [**DeleteCustomField**](docs/ContactsCustomFieldsApi.md#deletecustomfield) | **DELETE** /contact_custom_fields/{custom_field_id} | DELETE a custom_field |
| [**ContactsCustomFieldsApi**](docs/ContactsCustomFieldsApi.md) | [**GetAllCustomFields**](docs/ContactsCustomFieldsApi.md#getallcustomfields) | **GET** /contact_custom_fields | GET custom_fields Collection |
| [**ContactsCustomFieldsApi**](docs/ContactsCustomFieldsApi.md) | [**GetCustomField**](docs/ContactsCustomFieldsApi.md#getcustomfield) | **GET** /contact_custom_fields/{custom_field_id} | GET a custom_field |
| [**ContactsCustomFieldsApi**](docs/ContactsCustomFieldsApi.md) | [**UpdateCustomField**](docs/ContactsCustomFieldsApi.md#updatecustomfield) | **PUT** /contact_custom_fields/{custom_field_id} | PUT (update) a custom_field |
| [**ContactsReportingApi**](docs/ContactsReportingApi.md) | [**GetContactOpenClickRateReport**](docs/ContactsReportingApi.md#getcontactopenclickratereport) | **GET** /reports/contact_reports/{contact_id}/open_and_click_rates | GET Average Open and Click Rates |
| [**ContactsReportingApi**](docs/ContactsReportingApi.md) | [**GetContactTrackingCountReport**](docs/ContactsReportingApi.md#getcontacttrackingcountreport) | **GET** /reports/contact_reports/{contact_id}/activity_summary | GET Contact Action Summary |
| [**ContactsReportingApi**](docs/ContactsReportingApi.md) | [**GetContactTrackingReport**](docs/ContactsReportingApi.md#getcontacttrackingreport) | **GET** /reports/contact_reports/{contact_id}/activity_details | GET Contact Activity Details |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**CreateEmailCampaign**](docs/EmailCampaignsApi.md#createemailcampaign) | **POST** /emails | POST (Create) a New Email Campaign |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**CreateResendEmailCampaign**](docs/EmailCampaignsApi.md#createresendemailcampaign) | **POST** /emails/activities/{campaign_activity_id}/non_opener_resends | POST a Resend to Non-openers Campaign Activity |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**DeleteEmailCampaign**](docs/EmailCampaignsApi.md#deleteemailcampaign) | **DELETE** /emails/{campaign_id} | DELETE an Email Campaign |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**DeleteResendEmailCampaign**](docs/EmailCampaignsApi.md#deleteresendemailcampaign) | **DELETE** /emails/activities/{campaign_activity_id}/non_opener_resends/{resend_request_id} | DELETE a Resend to Non Openers Activity |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**GetAllEmailCampaigns**](docs/EmailCampaignsApi.md#getallemailcampaigns) | **GET** /emails | GET a Collection of Email Campaigns |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**GetEmailCampaignActivity**](docs/EmailCampaignsApi.md#getemailcampaignactivity) | **GET** /emails/activities/{campaign_activity_id} | GET a Single Email Campaign Activity |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**GetEmailCampaignById**](docs/EmailCampaignsApi.md#getemailcampaignbyid) | **GET** /emails/{campaign_id} | GET Details About a Single Email Campaign |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**GetEmailCampaignXrefs**](docs/EmailCampaignsApi.md#getemailcampaignxrefs) | **GET** /emails/campaign_id_xrefs | GET a Collection of V2 and V3 API Email Campaign Identifiers |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**GetResendEmailCampaign**](docs/EmailCampaignsApi.md#getresendemailcampaign) | **GET** /emails/activities/{campaign_activity_id}/non_opener_resends | GET Details for a Resend to Non-openers Campaign Activity |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**PatchEmailCampaignName**](docs/EmailCampaignsApi.md#patchemailcampaignname) | **PATCH** /emails/{campaign_id} | PATCH (Update) an Email Campaign Name |
| [**EmailCampaignsApi**](docs/EmailCampaignsApi.md) | [**UpdateEmailCampaignActivity**](docs/EmailCampaignsApi.md#updateemailcampaignactivity) | **PUT** /emails/activities/{campaign_activity_id} | PUT (Update) An Email Campaign Activity |
| [**EmailCampaignsABTestsApi**](docs/EmailCampaignsABTestsApi.md) | [**CreateABTestEmailCampaign**](docs/EmailCampaignsABTestsApi.md#createabtestemailcampaign) | **POST** /emails/activities/{campaign_activity_id}/abtest | POST (Create) an A/B Test for an Email Campaign Activity |
| [**EmailCampaignsABTestsApi**](docs/EmailCampaignsABTestsApi.md) | [**DeleteABTestEmailCampaign**](docs/EmailCampaignsABTestsApi.md#deleteabtestemailcampaign) | **DELETE** /emails/activities/{campaign_activity_id}/abtest | DELETE an A/B Test for an Email Campaign Activity |
| [**EmailCampaignsABTestsApi**](docs/EmailCampaignsABTestsApi.md) | [**GetABTestEmailCampaign**](docs/EmailCampaignsABTestsApi.md#getabtestemailcampaign) | **GET** /emails/activities/{campaign_activity_id}/abtest | GET A/B Test Details for an Email Campaign Activity |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetBouncesReport**](docs/EmailReportingApi.md#getbouncesreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/bounces | GET an Email Bounces Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetCampaignActivityLinkReport**](docs/EmailReportingApi.md#getcampaignactivitylinkreport) | **GET** /reports/email_reports/{campaign_activity_id}/links | GET an Email Links Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetClicksReport**](docs/EmailReportingApi.md#getclicksreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/clicks | GET an Email Clicks Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetDidNotOpensReport**](docs/EmailReportingApi.md#getdidnotopensreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/didnotopens | GET an Email Did Not Opens Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetEmailCampaignActivityReport**](docs/EmailReportingApi.md#getemailcampaignactivityreport) | **GET** /reports/stats/email_campaign_activities/{campaign_activity_ids} | GET an Email Campaign Activity Stats Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetEmailCampaignReport**](docs/EmailReportingApi.md#getemailcampaignreport) | **GET** /reports/summary_reports/email_campaign_summaries | GET an Email Campaigns Summary Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetEmailOpensReport**](docs/EmailReportingApi.md#getemailopensreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/opens | GET an Email Opens Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetEmailSendsReport**](docs/EmailReportingApi.md#getemailsendsreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/sends | GET an Email Sends Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetEmailStatsReport**](docs/EmailReportingApi.md#getemailstatsreport) | **GET** /reports/stats/email_campaigns/{campaign_ids} | GET an Email Campaign Stats Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetForwardsReport**](docs/EmailReportingApi.md#getforwardsreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/forwards | GET an Email Forwards Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetOptoutsReport**](docs/EmailReportingApi.md#getoptoutsreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/optouts | GET an Email Opt-outs Report |
| [**EmailReportingApi**](docs/EmailReportingApi.md) | [**GetUniqueOpensReport**](docs/EmailReportingApi.md#getuniqueopensreport) | **GET** /reports/email_reports/{campaign_activity_id}/tracking/unique_opens | GET an Email Unique Opens Report |
| [**EmailSchedulingApi**](docs/EmailSchedulingApi.md) | [**GetEmailCampaignActivityPreview**](docs/EmailSchedulingApi.md#getemailcampaignactivitypreview) | **GET** /emails/activities/{campaign_activity_id}/previews | GET the HTML Preview of an Email Campaign Activity |
| [**EmailSchedulingApi**](docs/EmailSchedulingApi.md) | [**GetEmailCampaignActivitySchedule**](docs/EmailSchedulingApi.md#getemailcampaignactivityschedule) | **GET** /emails/activities/{campaign_activity_id}/schedules | GET an Email Campaign Activity Schedule |
| [**EmailSchedulingApi**](docs/EmailSchedulingApi.md) | [**GetEmailCampaignActivitySendHistory**](docs/EmailSchedulingApi.md#getemailcampaignactivitysendhistory) | **GET** /emails/activities/{campaign_activity_id}/send_history | GET the Send History of an Email Campaign Activity |
| [**EmailSchedulingApi**](docs/EmailSchedulingApi.md) | [**ScheduleEmailCampaignActivity**](docs/EmailSchedulingApi.md#scheduleemailcampaignactivity) | **POST** /emails/activities/{campaign_activity_id}/schedules | POST (Create) an Email Campaign Activity Schedule |
| [**EmailSchedulingApi**](docs/EmailSchedulingApi.md) | [**TestSendEmailCampaignActivity**](docs/EmailSchedulingApi.md#testsendemailcampaignactivity) | **POST** /emails/activities/{campaign_activity_id}/tests | POST Test Send an Email Campaign Activity |
| [**EmailSchedulingApi**](docs/EmailSchedulingApi.md) | [**UnscheduleEmailCampaignActivity**](docs/EmailSchedulingApi.md#unscheduleemailcampaignactivity) | **DELETE** /emails/activities/{campaign_activity_id}/schedules | DELETE an Email Campaign Activity Schedule |
| [**LandingPagesReportingApi**](docs/LandingPagesReportingApi.md) | [**GetContactAdds**](docs/LandingPagesReportingApi.md#getcontactadds) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_adds | GET a Unique Contacts Adds Landing Page Report |
| [**LandingPagesReportingApi**](docs/LandingPagesReportingApi.md) | [**GetContactOpens**](docs/LandingPagesReportingApi.md#getcontactopens) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_contact_opens | GET a Contacts Opens Landing Page Report |
| [**LandingPagesReportingApi**](docs/LandingPagesReportingApi.md) | [**GetUniqueContactClicks**](docs/LandingPagesReportingApi.md#getuniquecontactclicks) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_clicks | GET a Unique Contacts Clicks Landing Page Report |
| [**LandingPagesReportingApi**](docs/LandingPagesReportingApi.md) | [**GetUniqueContactOpens**](docs/LandingPagesReportingApi.md#getuniquecontactopens) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_opens | GET a Unique Contacts Opens Landing Page Report |
| [**LandingPagesReportingApi**](docs/LandingPagesReportingApi.md) | [**GetUniqueContactSMSOptIns**](docs/LandingPagesReportingApi.md#getuniquecontactsmsoptins) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_sms_optins | GET a Unique Contacts SMS Opt-In Landing Page Report |
| [**LandingPagesReportingApi**](docs/LandingPagesReportingApi.md) | [**GetUniqueContactUpdates**](docs/LandingPagesReportingApi.md#getuniquecontactupdates) | **GET** /reports/landing_pages/campaign_details/{campaign_activity_id}/p_unique_contact_updates | GET a Unique Contacts Updates Landing Page Report |
| [**SMSReportingApi**](docs/SMSReportingApi.md) | [**GetAllBulkSmsCampaignSummaries**](docs/SMSReportingApi.md#getallbulksmscampaignsummaries) | **GET** /reports/summary_reports/sms_campaign_summaries | GET an SMS Campaigns Summary Report |
| [**SegmentsApi**](docs/SegmentsApi.md) | [**CreateSegment**](docs/SegmentsApi.md#createsegment) | **POST** /segments | POST (create) a Segment |
| [**SegmentsApi**](docs/SegmentsApi.md) | [**DeleteSegment**](docs/SegmentsApi.md#deletesegment) | **DELETE** /segments/{segment_id} | DELETE a Segment |
| [**SegmentsApi**](docs/SegmentsApi.md) | [**GetAllSegments**](docs/SegmentsApi.md#getallsegments) | **GET** /segments | GET all Segments |
| [**SegmentsApi**](docs/SegmentsApi.md) | [**GetSegmentById**](docs/SegmentsApi.md#getsegmentbyid) | **GET** /segments/{segment_id} | GET a Segment's Details |
| [**SegmentsApi**](docs/SegmentsApi.md) | [**UpdateSegment**](docs/SegmentsApi.md#updatesegment) | **PUT** /segments/{segment_id} | PUT (update) a Segment |
| [**SegmentsApi**](docs/SegmentsApi.md) | [**UpdateSegmentName**](docs/SegmentsApi.md#updatesegmentname) | **PATCH** /segments/{segment_id}/name | PATCH (rename) a Segment |


## Documentation for Models

- [Model.ABTestData](docs/ABTestData.md)
- [Model.APIErrorSchemaInner](docs/APIErrorSchemaInner.md)
- [Model.AccessTokenResponse](docs/AccessTokenResponse.md)
- [Model.AccountCancellation](docs/AccountCancellation.md)
- [Model.AccountEmailCreateResponse](docs/AccountEmailCreateResponse.md)
- [Model.AccountEmailInput](docs/AccountEmailInput.md)
- [Model.AccountPhysicalAddress](docs/AccountPhysicalAddress.md)
- [Model.AccountSuspension](docs/AccountSuspension.md)
- [Model.Activities](docs/Activities.md)
- [Model.Activity](docs/Activity.md)
- [Model.ActivityDeleteCustomFields](docs/ActivityDeleteCustomFields.md)
- [Model.ActivityDeleteListResponse](docs/ActivityDeleteListResponse.md)
- [Model.ActivityDeleteListsResponse](docs/ActivityDeleteListsResponse.md)
- [Model.ActivityDeleteStatus](docs/ActivityDeleteStatus.md)
- [Model.ActivityErrors](docs/ActivityErrors.md)
- [Model.ActivityExportStatus](docs/ActivityExportStatus.md)
- [Model.ActivityGeneric](docs/ActivityGeneric.md)
- [Model.ActivityGenericStatus](docs/ActivityGenericStatus.md)
- [Model.ActivityImport](docs/ActivityImport.md)
- [Model.ActivityLinks](docs/ActivityLinks.md)
- [Model.ActivityListsMembership](docs/ActivityListsMembership.md)
- [Model.ActivityReference](docs/ActivityReference.md)
- [Model.ActivityStatus](docs/ActivityStatus.md)
- [Model.ActivityStatusExportLink](docs/ActivityStatusExportLink.md)
- [Model.ActivityStatusLink](docs/ActivityStatusLink.md)
- [Model.ActivityTagging](docs/ActivityTagging.md)
- [Model.ActivityTaggingStatus](docs/ActivityTaggingStatus.md)
- [Model.AddAccountEmailAddress201Response](docs/AddAccountEmailAddress201Response.md)
- [Model.AddAccountEmailAddressRequest](docs/AddAccountEmailAddressRequest.md)
- [Model.AuthorizationErrorSchema](docs/AuthorizationErrorSchema.md)
- [Model.BouncesTrackingActivitiesPage](docs/BouncesTrackingActivitiesPage.md)
- [Model.BouncesTrackingActivity](docs/BouncesTrackingActivity.md)
- [Model.BulkCampaignSummary](docs/BulkCampaignSummary.md)
- [Model.BulkEmailCampaignSummariesPage](docs/BulkEmailCampaignSummariesPage.md)
- [Model.BulkEmailCampaignSummariesPercents](docs/BulkEmailCampaignSummariesPercents.md)
- [Model.BulkEmailCampaignSummary](docs/BulkEmailCampaignSummary.md)
- [Model.BulkSmsCampaignSummariesPercents](docs/BulkSmsCampaignSummariesPercents.md)
- [Model.CampaignActivityStatsQueryResultEmail](docs/CampaignActivityStatsQueryResultEmail.md)
- [Model.CampaignActivityStatsResultGenericStatsEmailActivity](docs/CampaignActivityStatsResultGenericStatsEmailActivity.md)
- [Model.CampaignActivitySummary](docs/CampaignActivitySummary.md)
- [Model.CampaignStatsQueryResultEmail](docs/CampaignStatsQueryResultEmail.md)
- [Model.CampaignStatsResultGenericStatsEmailPercentsEmail](docs/CampaignStatsResultGenericStatsEmailPercentsEmail.md)
- [Model.ClicksTrackingActivitiesPage](docs/ClicksTrackingActivitiesPage.md)
- [Model.ClicksTrackingActivity](docs/ClicksTrackingActivity.md)
- [Model.CompanyLogo](docs/CompanyLogo.md)
- [Model.ContactCampaignActivitiesSummary](docs/ContactCampaignActivitiesSummary.md)
- [Model.ContactCreateOrUpdateInput](docs/ContactCreateOrUpdateInput.md)
- [Model.ContactCreateOrUpdateResponse](docs/ContactCreateOrUpdateResponse.md)
- [Model.ContactCustomField](docs/ContactCustomField.md)
- [Model.ContactDelete](docs/ContactDelete.md)
- [Model.ContactList](docs/ContactList.md)
- [Model.ContactListArray](docs/ContactListArray.md)
- [Model.ContactListPutPost](docs/ContactListPutPost.md)
- [Model.ContactOpenAndClickRates](docs/ContactOpenAndClickRates.md)
- [Model.ContactPostRequest](docs/ContactPostRequest.md)
- [Model.ContactPutRequest](docs/ContactPutRequest.md)
- [Model.ContactResource](docs/ContactResource.md)
- [Model.ContactResubscribeRequest](docs/ContactResubscribeRequest.md)
- [Model.ContactSmsChannel](docs/ContactSmsChannel.md)
- [Model.ContactSmsChannelConsents](docs/ContactSmsChannelConsents.md)
- [Model.ContactTrackingActivitiesPage](docs/ContactTrackingActivitiesPage.md)
- [Model.ContactTrackingActivity](docs/ContactTrackingActivity.md)
- [Model.ContactXref](docs/ContactXref.md)
- [Model.ContactXrefs](docs/ContactXrefs.md)
- [Model.Contacts](docs/Contacts.md)
- [Model.ContactsCounts](docs/ContactsCounts.md)
- [Model.ContactsExport](docs/ContactsExport.md)
- [Model.ContactsJsonImport](docs/ContactsJsonImport.md)
- [Model.CreateCSVImportActivity201Response](docs/CreateCSVImportActivity201Response.md)
- [Model.CreateCSVImportActivity201ResponseLinks](docs/CreateCSVImportActivity201ResponseLinks.md)
- [Model.CreateCSVImportActivity201ResponseStatus](docs/CreateCSVImportActivity201ResponseStatus.md)
- [Model.CreateContactRequest](docs/CreateContactRequest.md)
- [Model.CreateContactRequestEmailAddress](docs/CreateContactRequestEmailAddress.md)
- [Model.CreateDeleteActivity201Response](docs/CreateDeleteActivity201Response.md)
- [Model.CreateDeleteActivity201ResponseLinks](docs/CreateDeleteActivity201ResponseLinks.md)
- [Model.CreateDeleteActivity201ResponseLinksSelf](docs/CreateDeleteActivity201ResponseLinksSelf.md)
- [Model.CreateDeleteActivity201ResponseStatus](docs/CreateDeleteActivity201ResponseStatus.md)
- [Model.CreateDeleteActivityRequest](docs/CreateDeleteActivityRequest.md)
- [Model.CreateEmailCampaign200Response](docs/CreateEmailCampaign200Response.md)
- [Model.CreateEmailCampaign200ResponseCampaignActivitiesInner](docs/CreateEmailCampaign200ResponseCampaignActivitiesInner.md)
- [Model.CreateEmailCampaignRequest](docs/CreateEmailCampaignRequest.md)
- [Model.CreateEmailCampaignRequestEmailCampaignActivitiesInner](docs/CreateEmailCampaignRequestEmailCampaignActivitiesInner.md)
- [Model.CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter](docs/CreateEmailCampaignRequestEmailCampaignActivitiesInnerPhysicalAddressInFooter.md)
- [Model.CreateExportActivity201Response](docs/CreateExportActivity201Response.md)
- [Model.CreateExportActivity201ResponseStatus](docs/CreateExportActivity201ResponseStatus.md)
- [Model.CreateExportActivityRequest](docs/CreateExportActivityRequest.md)
- [Model.CreateExportActivityRequestExclude](docs/CreateExportActivityRequestExclude.md)
- [Model.CreateImportJSONActivityRequest](docs/CreateImportJSONActivityRequest.md)
- [Model.CreateImportJSONActivityRequestImportDataInner](docs/CreateImportJSONActivityRequestImportDataInner.md)
- [Model.CreateListAddActivityRequest](docs/CreateListAddActivityRequest.md)
- [Model.CreateListAddActivityRequestExclude](docs/CreateListAddActivityRequestExclude.md)
- [Model.CreateListAddActivityRequestSource](docs/CreateListAddActivityRequestSource.md)
- [Model.CreateListDeleteActivity201Response](docs/CreateListDeleteActivity201Response.md)
- [Model.CreateListDeleteActivity201ResponseLinks](docs/CreateListDeleteActivity201ResponseLinks.md)
- [Model.CreateListDeleteActivity201ResponseLinksSelf](docs/CreateListDeleteActivity201ResponseLinksSelf.md)
- [Model.CreateListDeleteActivity201ResponseStatus](docs/CreateListDeleteActivity201ResponseStatus.md)
- [Model.CreateListDeleteActivityRequest](docs/CreateListDeleteActivityRequest.md)
- [Model.CreateListRemoveActivity201Response](docs/CreateListRemoveActivity201Response.md)
- [Model.CreateListRemoveActivity201ResponseStatus](docs/CreateListRemoveActivity201ResponseStatus.md)
- [Model.CreateListRemoveActivityRequest](docs/CreateListRemoveActivityRequest.md)
- [Model.CreateListRemoveActivityRequestExclude](docs/CreateListRemoveActivityRequestExclude.md)
- [Model.CreateListRemoveActivityRequestSource](docs/CreateListRemoveActivityRequestSource.md)
- [Model.CreateOrUpdateContact200Response](docs/CreateOrUpdateContact200Response.md)
- [Model.CreateOrUpdateContactCustomField](docs/CreateOrUpdateContactCustomField.md)
- [Model.CreateOrUpdateContactRequest](docs/CreateOrUpdateContactRequest.md)
- [Model.CreateOrUpdateContactRequestCustomFieldsInner](docs/CreateOrUpdateContactRequestCustomFieldsInner.md)
- [Model.CreateOrUpdateContactRequestSmsChannel](docs/CreateOrUpdateContactRequestSmsChannel.md)
- [Model.CreateOrUpdateContactRequestSmsChannelSmsChannelConsentsInner](docs/CreateOrUpdateContactRequestSmsChannelSmsChannelConsentsInner.md)
- [Model.CreateOrUpdateContactRequestStreetAddress](docs/CreateOrUpdateContactRequestStreetAddress.md)
- [Model.CreateResendEmailCampaign201Response](docs/CreateResendEmailCampaign201Response.md)
- [Model.CreateResendEmailCampaignRequest](docs/CreateResendEmailCampaignRequest.md)
- [Model.CreateSegment201Response](docs/CreateSegment201Response.md)
- [Model.CreateSegmentRequest](docs/CreateSegmentRequest.md)
- [Model.CreateTagDeleteActivityRequest](docs/CreateTagDeleteActivityRequest.md)
- [Model.CreateTagRemoveActivity201Response](docs/CreateTagRemoveActivity201Response.md)
- [Model.CreateTagRemoveActivity201ResponseLinks](docs/CreateTagRemoveActivity201ResponseLinks.md)
- [Model.CreateTagRemoveActivity201ResponseLinksResults](docs/CreateTagRemoveActivity201ResponseLinksResults.md)
- [Model.CreateTagRemoveActivity201ResponseLinksSelf](docs/CreateTagRemoveActivity201ResponseLinksSelf.md)
- [Model.CreateTagRemoveActivity201ResponseStatus](docs/CreateTagRemoveActivity201ResponseStatus.md)
- [Model.CreateTagRemoveActivityRequest](docs/CreateTagRemoveActivityRequest.md)
- [Model.CreateTagRemoveActivityRequestExclude](docs/CreateTagRemoveActivityRequestExclude.md)
- [Model.CreateTagRemoveActivityRequestSource](docs/CreateTagRemoveActivityRequestSource.md)
- [Model.CrossReference](docs/CrossReference.md)
- [Model.CrossReferenceResponse](docs/CrossReferenceResponse.md)
- [Model.CustomFieldId100](docs/CustomFieldId100.md)
- [Model.CustomFieldInput](docs/CustomFieldInput.md)
- [Model.CustomFieldResource](docs/CustomFieldResource.md)
- [Model.CustomFields](docs/CustomFields.md)
- [Model.Customer](docs/Customer.md)
- [Model.CustomerPut](docs/CustomerPut.md)
- [Model.DeleteList202Response](docs/DeleteList202Response.md)
- [Model.DeleteTag202Response](docs/DeleteTag202Response.md)
- [Model.DeleteTag202ResponseActivityErrorsInner](docs/DeleteTag202ResponseActivityErrorsInner.md)
- [Model.DeleteTag202ResponseLinks](docs/DeleteTag202ResponseLinks.md)
- [Model.DeleteTag202ResponseLinksSelf](docs/DeleteTag202ResponseLinksSelf.md)
- [Model.DeleteTag202ResponseStatus](docs/DeleteTag202ResponseStatus.md)
- [Model.DeviceFlowResponse](docs/DeviceFlowResponse.md)
- [Model.DidNotOpensTrackingActivitiesPage](docs/DidNotOpensTrackingActivitiesPage.md)
- [Model.DidNotOpensTrackingActivity](docs/DidNotOpensTrackingActivity.md)
- [Model.EmailAddress](docs/EmailAddress.md)
- [Model.EmailAddressPost](docs/EmailAddressPost.md)
- [Model.EmailAddressPut](docs/EmailAddressPut.md)
- [Model.EmailCampaign](docs/EmailCampaign.md)
- [Model.EmailCampaignActivity](docs/EmailCampaignActivity.md)
- [Model.EmailCampaignActivityInput](docs/EmailCampaignActivityInput.md)
- [Model.EmailCampaignActivityPreview](docs/EmailCampaignActivityPreview.md)
- [Model.EmailCampaignComplete](docs/EmailCampaignComplete.md)
- [Model.EmailCampaignName](docs/EmailCampaignName.md)
- [Model.EmailCampaigns](docs/EmailCampaigns.md)
- [Model.EmailLinkClickCount](docs/EmailLinkClickCount.md)
- [Model.EmailLinks](docs/EmailLinks.md)
- [Model.EmailPhysicalAddress](docs/EmailPhysicalAddress.md)
- [Model.EmailScheduleInput](docs/EmailScheduleInput.md)
- [Model.EmailTestSendInput](docs/EmailTestSendInput.md)
- [Model.EmailsLink](docs/EmailsLink.md)
- [Model.EmailsPagingLinks](docs/EmailsPagingLinks.md)
- [Model.FileObject](docs/FileObject.md)
- [Model.FileStatusArrayInner](docs/FileStatusArrayInner.md)
- [Model.ForwardsTrackingActivitiesPage](docs/ForwardsTrackingActivitiesPage.md)
- [Model.ForwardsTrackingActivity](docs/ForwardsTrackingActivity.md)
- [Model.GetABTestEmailCampaign200Response](docs/GetABTestEmailCampaign200Response.md)
- [Model.GetAccountDetails200Response](docs/GetAccountDetails200Response.md)
- [Model.GetAccountDetails200ResponseCompanyLogo](docs/GetAccountDetails200ResponseCompanyLogo.md)
- [Model.GetAccountDetails200ResponsePhysicalAddress](docs/GetAccountDetails200ResponsePhysicalAddress.md)
- [Model.GetActivityById200Response](docs/GetActivityById200Response.md)
- [Model.GetAllAccountEmailAddresses200ResponseInner](docs/GetAllAccountEmailAddresses200ResponseInner.md)
- [Model.GetAllActivities200Response](docs/GetAllActivities200Response.md)
- [Model.GetAllActivities200ResponseActivitiesInner](docs/GetAllActivities200ResponseActivitiesInner.md)
- [Model.GetAllActivities200ResponseActivitiesInnerLinks](docs/GetAllActivities200ResponseActivitiesInnerLinks.md)
- [Model.GetAllActivities200ResponseActivitiesInnerLinksResults](docs/GetAllActivities200ResponseActivitiesInnerLinksResults.md)
- [Model.GetAllActivities200ResponseActivitiesInnerLinksSelf](docs/GetAllActivities200ResponseActivitiesInnerLinksSelf.md)
- [Model.GetAllActivities200ResponseActivitiesInnerStatus](docs/GetAllActivities200ResponseActivitiesInnerStatus.md)
- [Model.GetAllActivities200ResponseLinks](docs/GetAllActivities200ResponseLinks.md)
- [Model.GetAllActivities200ResponseLinksNext](docs/GetAllActivities200ResponseLinksNext.md)
- [Model.GetAllBulkSmsCampaignSummaries200Response](docs/GetAllBulkSmsCampaignSummaries200Response.md)
- [Model.GetAllBulkSmsCampaignSummaries200ResponseAggregatePercents](docs/GetAllBulkSmsCampaignSummaries200ResponseAggregatePercents.md)
- [Model.GetAllBulkSmsCampaignSummaries200ResponseBulkSmsCampaignSummariesInner](docs/GetAllBulkSmsCampaignSummaries200ResponseBulkSmsCampaignSummariesInner.md)
- [Model.GetAllBulkSmsCampaignSummaries200ResponseBulkSmsCampaignSummariesInnerUniqueCounts](docs/GetAllBulkSmsCampaignSummaries200ResponseBulkSmsCampaignSummariesInnerUniqueCounts.md)
- [Model.GetAllBulkSmsCampaignSummaries200ResponseLinks](docs/GetAllBulkSmsCampaignSummaries200ResponseLinks.md)
- [Model.GetAllBulkSmsCampaignSummaries200ResponseLinksNext](docs/GetAllBulkSmsCampaignSummaries200ResponseLinksNext.md)
- [Model.GetAllContacts200Response](docs/GetAllContacts200Response.md)
- [Model.GetAllCustomFields200Response](docs/GetAllCustomFields200Response.md)
- [Model.GetAllEmailCampaigns200Response](docs/GetAllEmailCampaigns200Response.md)
- [Model.GetAllEmailCampaigns200ResponseCampaignsInner](docs/GetAllEmailCampaigns200ResponseCampaignsInner.md)
- [Model.GetAllEmailCampaigns200ResponseLinks](docs/GetAllEmailCampaigns200ResponseLinks.md)
- [Model.GetAllLists200Response](docs/GetAllLists200Response.md)
- [Model.GetAllSegments200Response](docs/GetAllSegments200Response.md)
- [Model.GetAllSegments200ResponseLinks](docs/GetAllSegments200ResponseLinks.md)
- [Model.GetAllSegments200ResponseLinksNext](docs/GetAllSegments200ResponseLinksNext.md)
- [Model.GetAllSegments200ResponseSegmentsInner](docs/GetAllSegments200ResponseSegmentsInner.md)
- [Model.GetAllTags200Response](docs/GetAllTags200Response.md)
- [Model.GetAllTags200ResponseLinks](docs/GetAllTags200ResponseLinks.md)
- [Model.GetAllTags200ResponseLinksNext](docs/GetAllTags200ResponseLinksNext.md)
- [Model.GetAllTags200ResponseLinksNextNext](docs/GetAllTags200ResponseLinksNextNext.md)
- [Model.GetBouncesReport200Response](docs/GetBouncesReport200Response.md)
- [Model.GetBouncesReport200ResponseLinks](docs/GetBouncesReport200ResponseLinks.md)
- [Model.GetBouncesReport200ResponseTrackingActivitiesInner](docs/GetBouncesReport200ResponseTrackingActivitiesInner.md)
- [Model.GetCampaignActivityLinkReport200Response](docs/GetCampaignActivityLinkReport200Response.md)
- [Model.GetCampaignActivityLinkReport200ResponseLinkClickCountsInner](docs/GetCampaignActivityLinkReport200ResponseLinkClickCountsInner.md)
- [Model.GetClicksReport200Response](docs/GetClicksReport200Response.md)
- [Model.GetClicksReport200ResponseLinks](docs/GetClicksReport200ResponseLinks.md)
- [Model.GetClicksReport200ResponseTrackingActivitiesInner](docs/GetClicksReport200ResponseTrackingActivitiesInner.md)
- [Model.GetContactAdds200Response](docs/GetContactAdds200Response.md)
- [Model.GetContactAdds200ResponseTrackingActivitiesInner](docs/GetContactAdds200ResponseTrackingActivitiesInner.md)
- [Model.GetContactById200Response](docs/GetContactById200Response.md)
- [Model.GetContactById200ResponseCustomFieldsInner](docs/GetContactById200ResponseCustomFieldsInner.md)
- [Model.GetContactById200ResponseEmailAddress](docs/GetContactById200ResponseEmailAddress.md)
- [Model.GetContactById200ResponseNotesInner](docs/GetContactById200ResponseNotesInner.md)
- [Model.GetContactById200ResponsePhoneNumbersInner](docs/GetContactById200ResponsePhoneNumbersInner.md)
- [Model.GetContactById200ResponseSmsChannel](docs/GetContactById200ResponseSmsChannel.md)
- [Model.GetContactById200ResponseSmsChannelSmsChannelConsentsInner](docs/GetContactById200ResponseSmsChannelSmsChannelConsentsInner.md)
- [Model.GetContactById200ResponseStreetAddressesInner](docs/GetContactById200ResponseStreetAddressesInner.md)
- [Model.GetContactCounts200Response](docs/GetContactCounts200Response.md)
- [Model.GetContactIdXrefs200Response](docs/GetContactIdXrefs200Response.md)
- [Model.GetContactIdXrefs200ResponseXrefsInner](docs/GetContactIdXrefs200ResponseXrefsInner.md)
- [Model.GetContactOpenClickRateReport200Response](docs/GetContactOpenClickRateReport200Response.md)
- [Model.GetContactTrackingCountReport200Response](docs/GetContactTrackingCountReport200Response.md)
- [Model.GetContactTrackingCountReport200ResponseCampaignActivitiesInner](docs/GetContactTrackingCountReport200ResponseCampaignActivitiesInner.md)
- [Model.GetContactTrackingCountReport200ResponseLinks](docs/GetContactTrackingCountReport200ResponseLinks.md)
- [Model.GetContactTrackingReport200Response](docs/GetContactTrackingReport200Response.md)
- [Model.GetContactTrackingReport200ResponseLinks](docs/GetContactTrackingReport200ResponseLinks.md)
- [Model.GetContactTrackingReport200ResponseLinksNext](docs/GetContactTrackingReport200ResponseLinksNext.md)
- [Model.GetContactTrackingReport200ResponseTrackingActivitiesInner](docs/GetContactTrackingReport200ResponseTrackingActivitiesInner.md)
- [Model.GetCustomField200Response](docs/GetCustomField200Response.md)
- [Model.GetDidNotOpensReport200Response](docs/GetDidNotOpensReport200Response.md)
- [Model.GetDidNotOpensReport200ResponseTrackingActivitiesInner](docs/GetDidNotOpensReport200ResponseTrackingActivitiesInner.md)
- [Model.GetEmailCampaignActivity200Response](docs/GetEmailCampaignActivity200Response.md)
- [Model.GetEmailCampaignActivity200ResponseDocumentProperties](docs/GetEmailCampaignActivity200ResponseDocumentProperties.md)
- [Model.GetEmailCampaignActivity200ResponsePhysicalAddressInFooter](docs/GetEmailCampaignActivity200ResponsePhysicalAddressInFooter.md)
- [Model.GetEmailCampaignActivityPreview200Response](docs/GetEmailCampaignActivityPreview200Response.md)
- [Model.GetEmailCampaignActivityReport200Response](docs/GetEmailCampaignActivityReport200Response.md)
- [Model.GetEmailCampaignActivityReport200ResponseResultsInner](docs/GetEmailCampaignActivityReport200ResponseResultsInner.md)
- [Model.GetEmailCampaignActivityReport200ResponseResultsInnerStats](docs/GetEmailCampaignActivityReport200ResponseResultsInnerStats.md)
- [Model.GetEmailCampaignActivitySchedule200ResponseInner](docs/GetEmailCampaignActivitySchedule200ResponseInner.md)
- [Model.GetEmailCampaignActivitySendHistory200ResponseInner](docs/GetEmailCampaignActivitySendHistory200ResponseInner.md)
- [Model.GetEmailCampaignReport200Response](docs/GetEmailCampaignReport200Response.md)
- [Model.GetEmailCampaignReport200ResponseAggregatePercents](docs/GetEmailCampaignReport200ResponseAggregatePercents.md)
- [Model.GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInner](docs/GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInner.md)
- [Model.GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInnerUniqueCounts](docs/GetEmailCampaignReport200ResponseBulkEmailCampaignSummariesInnerUniqueCounts.md)
- [Model.GetEmailCampaignXrefs200Response](docs/GetEmailCampaignXrefs200Response.md)
- [Model.GetEmailCampaignXrefs200ResponseXrefsInner](docs/GetEmailCampaignXrefs200ResponseXrefsInner.md)
- [Model.GetEmailOpensReport200Response](docs/GetEmailOpensReport200Response.md)
- [Model.GetEmailOpensReport200ResponseTrackingActivitiesInner](docs/GetEmailOpensReport200ResponseTrackingActivitiesInner.md)
- [Model.GetEmailSendsReport200Response](docs/GetEmailSendsReport200Response.md)
- [Model.GetEmailSendsReport200ResponseLinks](docs/GetEmailSendsReport200ResponseLinks.md)
- [Model.GetEmailSendsReport200ResponseTrackingActivitiesInner](docs/GetEmailSendsReport200ResponseTrackingActivitiesInner.md)
- [Model.GetEmailStatsReport200Response](docs/GetEmailStatsReport200Response.md)
- [Model.GetEmailStatsReport200ResponseErrorsInner](docs/GetEmailStatsReport200ResponseErrorsInner.md)
- [Model.GetEmailStatsReport200ResponseResultsInner](docs/GetEmailStatsReport200ResponseResultsInner.md)
- [Model.GetEmailStatsReport200ResponseResultsInnerPercents](docs/GetEmailStatsReport200ResponseResultsInnerPercents.md)
- [Model.GetEmailStatsReport200ResponseResultsInnerStats](docs/GetEmailStatsReport200ResponseResultsInnerStats.md)
- [Model.GetForwardsReport200Response](docs/GetForwardsReport200Response.md)
- [Model.GetForwardsReport200ResponseTrackingActivitiesInner](docs/GetForwardsReport200ResponseTrackingActivitiesInner.md)
- [Model.GetList200Response](docs/GetList200Response.md)
- [Model.GetListIdXrefs200Response](docs/GetListIdXrefs200Response.md)
- [Model.GetListIdXrefs200ResponseXrefsInner](docs/GetListIdXrefs200ResponseXrefsInner.md)
- [Model.GetOptoutsReport200Response](docs/GetOptoutsReport200Response.md)
- [Model.GetOptoutsReport200ResponseTrackingActivitiesInner](docs/GetOptoutsReport200ResponseTrackingActivitiesInner.md)
- [Model.GetResendEmailCampaign200ResponseInner](docs/GetResendEmailCampaign200ResponseInner.md)
- [Model.GetSmsEngagementHistory200ResponseInner](docs/GetSmsEngagementHistory200ResponseInner.md)
- [Model.GetSmsEngagementHistory200ResponseInnerHistoryDetails](docs/GetSmsEngagementHistory200ResponseInnerHistoryDetails.md)
- [Model.GetTag200Response](docs/GetTag200Response.md)
- [Model.GetUniqueContactClicks200Response](docs/GetUniqueContactClicks200Response.md)
- [Model.GetUniqueContactClicks200ResponseLinks](docs/GetUniqueContactClicks200ResponseLinks.md)
- [Model.GetUniqueContactClicks200ResponseLinksNext](docs/GetUniqueContactClicks200ResponseLinksNext.md)
- [Model.GetUniqueContactClicks200ResponseTrackingActivitiesInner](docs/GetUniqueContactClicks200ResponseTrackingActivitiesInner.md)
- [Model.GetUniqueContactClicks200ResponseTrackingActivitiesInnerSmsChannel](docs/GetUniqueContactClicks200ResponseTrackingActivitiesInnerSmsChannel.md)
- [Model.GetUniqueContactOpens200Response](docs/GetUniqueContactOpens200Response.md)
- [Model.GetUniqueContactOpens200ResponseTrackingActivitiesInner](docs/GetUniqueContactOpens200ResponseTrackingActivitiesInner.md)
- [Model.GetUniqueContactSMSOptIns200Response](docs/GetUniqueContactSMSOptIns200Response.md)
- [Model.GetUniqueContactSMSOptIns200ResponseTrackingActivitiesInner](docs/GetUniqueContactSMSOptIns200ResponseTrackingActivitiesInner.md)
- [Model.GetUniqueContactUpdates200Response](docs/GetUniqueContactUpdates200Response.md)
- [Model.GetUniqueContactUpdates200ResponseTrackingActivitiesInner](docs/GetUniqueContactUpdates200ResponseTrackingActivitiesInner.md)
- [Model.GetUserPrivileges200ResponseInner](docs/GetUserPrivileges200ResponseInner.md)
- [Model.HeadersObject](docs/HeadersObject.md)
- [Model.HistoryDetails](docs/HistoryDetails.md)
- [Model.JmmlSmsChannel](docs/JmmlSmsChannel.md)
- [Model.JmmlSmsChannelConsents](docs/JmmlSmsChannelConsents.md)
- [Model.JsonImportContact](docs/JsonImportContact.md)
- [Model.Link](docs/Link.md)
- [Model.Links](docs/Links.md)
- [Model.ListActivityAddContacts](docs/ListActivityAddContacts.md)
- [Model.ListActivityRemoveContacts](docs/ListActivityRemoveContacts.md)
- [Model.ListIdList100](docs/ListIdList100.md)
- [Model.ListInput](docs/ListInput.md)
- [Model.ListXref](docs/ListXref.md)
- [Model.ListXrefs](docs/ListXrefs.md)
- [Model.LpreportingLinks](docs/LpreportingLinks.md)
- [Model.LpreportingNext](docs/LpreportingNext.md)
- [Model.MyLibraryFileCollectionInner](docs/MyLibraryFileCollectionInner.md)
- [Model.MyLibraryFileCollectionInnerThumbnail](docs/MyLibraryFileCollectionInnerThumbnail.md)
- [Model.Next](docs/Next.md)
- [Model.Note](docs/Note.md)
- [Model.OAuthError](docs/OAuthError.md)
- [Model.OpensTrackingActivitiesPage](docs/OpensTrackingActivitiesPage.md)
- [Model.OpensTrackingActivity](docs/OpensTrackingActivity.md)
- [Model.OptoutsTrackingActivitiesPage](docs/OptoutsTrackingActivitiesPage.md)
- [Model.OptoutsTrackingActivity](docs/OptoutsTrackingActivity.md)
- [Model.PContactAddTrackingActivitiesPage](docs/PContactAddTrackingActivitiesPage.md)
- [Model.PContactAddTrackingActivity](docs/PContactAddTrackingActivity.md)
- [Model.PContactClickTrackingActivitiesPage](docs/PContactClickTrackingActivitiesPage.md)
- [Model.PContactClickTrackingActivity](docs/PContactClickTrackingActivity.md)
- [Model.PContactOpenTrackingActivity](docs/PContactOpenTrackingActivity.md)
- [Model.PContactOpensTrackingActivitiesPage](docs/PContactOpensTrackingActivitiesPage.md)
- [Model.PContactSMSOptInTrackingActivitiesPage](docs/PContactSMSOptInTrackingActivitiesPage.md)
- [Model.PContactSMSOptInTrackingActivity](docs/PContactSMSOptInTrackingActivity.md)
- [Model.PContactUpdateTrackingActivitiesPage](docs/PContactUpdateTrackingActivitiesPage.md)
- [Model.PContactUpdateTrackingActivity](docs/PContactUpdateTrackingActivity.md)
- [Model.PagedEmailCampaignResponse](docs/PagedEmailCampaignResponse.md)
- [Model.PaginationLinks](docs/PaginationLinks.md)
- [Model.PaginationLinksNext](docs/PaginationLinksNext.md)
- [Model.PagingLinks](docs/PagingLinks.md)
- [Model.PartnerAccount](docs/PartnerAccount.md)
- [Model.PartnerAccountLinks](docs/PartnerAccountLinks.md)
- [Model.PartnerAccountOperationsRequest](docs/PartnerAccountOperationsRequest.md)
- [Model.PartnerAccountOperationsRequestAccountOperationHeadersInner](docs/PartnerAccountOperationsRequestAccountOperationHeadersInner.md)
- [Model.PartnerAccountOperationsRequestAccountOperationPathParametersInner](docs/PartnerAccountOperationsRequestAccountOperationPathParametersInner.md)
- [Model.PartnerAccountOperationsRequestAccountOperationQueryParametersInner](docs/PartnerAccountOperationsRequestAccountOperationQueryParametersInner.md)
- [Model.PartnerAccountSiteOwnerListInner](docs/PartnerAccountSiteOwnerListInner.md)
- [Model.PartnersLink](docs/PartnersLink.md)
- [Model.PatchEmailCampaignNameRequest](docs/PatchEmailCampaignNameRequest.md)
- [Model.PathParamObject](docs/PathParamObject.md)
- [Model.PercentsEmail](docs/PercentsEmail.md)
- [Model.PhoneNumber](docs/PhoneNumber.md)
- [Model.PhoneNumberPut](docs/PhoneNumberPut.md)
- [Model.PlanInfo](docs/PlanInfo.md)
- [Model.PlanTiersObject](docs/PlanTiersObject.md)
- [Model.PlanTiersObjectCurrentTiersInner](docs/PlanTiersObjectCurrentTiersInner.md)
- [Model.PostCustomFieldDelete201Response](docs/PostCustomFieldDelete201Response.md)
- [Model.PostCustomFieldDeleteRequest](docs/PostCustomFieldDeleteRequest.md)
- [Model.PostTagRequest](docs/PostTagRequest.md)
- [Model.Provision](docs/Provision.md)
- [Model.ProvisionResponse](docs/ProvisionResponse.md)
- [Model.PutTagRequest](docs/PutTagRequest.md)
- [Model.QueryParamObject](docs/QueryParamObject.md)
- [Model.ReportingLinks](docs/ReportingLinks.md)
- [Model.ReportingNext](docs/ReportingNext.md)
- [Model.ReportingsmsLinks](docs/ReportingsmsLinks.md)
- [Model.ReportingsmsNext](docs/ReportingsmsNext.md)
- [Model.ResendToNonOpenersInput](docs/ResendToNonOpenersInput.md)
- [Model.ResendToNonOpenersObject](docs/ResendToNonOpenersObject.md)
- [Model.ResubscribeContactRequest](docs/ResubscribeContactRequest.md)
- [Model.SSOUser](docs/SSOUser.md)
- [Model.ScheduleEmailCampaignActivityRequest](docs/ScheduleEmailCampaignActivityRequest.md)
- [Model.SegmentData](docs/SegmentData.md)
- [Model.SegmentDetail](docs/SegmentDetail.md)
- [Model.SegmentMaster](docs/SegmentMaster.md)
- [Model.SegmentName](docs/SegmentName.md)
- [Model.SegmentsDTO](docs/SegmentsDTO.md)
- [Model.SendsTrackingActivitiesPage](docs/SendsTrackingActivitiesPage.md)
- [Model.SendsTrackingActivity](docs/SendsTrackingActivity.md)
- [Model.SmsCampaignSummariesPage](docs/SmsCampaignSummariesPage.md)
- [Model.SmsChannelConsentDetails](docs/SmsChannelConsentDetails.md)
- [Model.StatsEmail](docs/StatsEmail.md)
- [Model.StatsEmailActivity](docs/StatsEmailActivity.md)
- [Model.StatsError](docs/StatsError.md)
- [Model.StreetAddress](docs/StreetAddress.md)
- [Model.StreetAddressPut](docs/StreetAddressPut.md)
- [Model.Tag](docs/Tag.md)
- [Model.TagAddRemoveContacts](docs/TagAddRemoveContacts.md)
- [Model.TagIdList500Limit](docs/TagIdList500Limit.md)
- [Model.TagPost](docs/TagPost.md)
- [Model.TagPut](docs/TagPut.md)
- [Model.Tags](docs/Tags.md)
- [Model.TagsActivityLinks](docs/TagsActivityLinks.md)
- [Model.TagsLinks](docs/TagsLinks.md)
- [Model.TagsPagingLinks](docs/TagsPagingLinks.md)
- [Model.TestSendEmailCampaignActivityRequest](docs/TestSendEmailCampaignActivityRequest.md)
- [Model.TierObject](docs/TierObject.md)
- [Model.TrackingActivitySmsChannelDTO](docs/TrackingActivitySmsChannelDTO.md)
- [Model.UniqueEmailCounts](docs/UniqueEmailCounts.md)
- [Model.UniqueSmsCounts](docs/UniqueSmsCounts.md)
- [Model.UpdateAccountRequest](docs/UpdateAccountRequest.md)
- [Model.UpdateContactRequest](docs/UpdateContactRequest.md)
- [Model.UpdateContactRequestEmailAddress](docs/UpdateContactRequestEmailAddress.md)
- [Model.UpdateContactRequestPhoneNumbersInner](docs/UpdateContactRequestPhoneNumbersInner.md)
- [Model.UpdateContactRequestSmsChannel](docs/UpdateContactRequestSmsChannel.md)
- [Model.UpdateContactRequestSmsChannelSmsChannelConsentsInner](docs/UpdateContactRequestSmsChannelSmsChannelConsentsInner.md)
- [Model.UpdateContactRequestStreetAddressesInner](docs/UpdateContactRequestStreetAddressesInner.md)
- [Model.UpdateCustomFieldRequest](docs/UpdateCustomFieldRequest.md)
- [Model.UpdateList200Response](docs/UpdateList200Response.md)
- [Model.UpdateListRequest](docs/UpdateListRequest.md)
- [Model.UpdateSegmentNameRequest](docs/UpdateSegmentNameRequest.md)
- [Model.WebhooksSubscriptionBody](docs/WebhooksSubscriptionBody.md)
- [Model.WebhooksSubscriptionCollectionInner](docs/WebhooksSubscriptionCollectionInner.md)
- [Model.WebhooksSubscriptionPutResp](docs/WebhooksSubscriptionPutResp.md)
- [Model.WebhooksSubscriptionResponse](docs/WebhooksSubscriptionResponse.md)
- [Model.WebhooksTestSend](docs/WebhooksTestSend.md)


## Documentation for Authorization


Authentication schemes defined for the API:
### oauth2_implicit

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://authz.constantcontact.com/oauth2/default/v1/token
- **Scopes**: 
  - contact_data: Read or modify contact data.
  - campaign_data: Read or modify email campaign data.
  - account_read: Read account data.
  - account_update: Modify account data.

### oauth2_access_code

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://authz.constantcontact.com/oauth2/default/v1/authorize
- **Scopes**: 
  - contact_data: Read or modify contact data.
  - campaign_data: Read or modify email campaign data.
  - account_read: Read account data.
  - account_update: Modify account data.

