# Getting Started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (Message360.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Message360 library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

### 3. Add reference of the library project

In order to use the Message360 library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Message360.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```Message360.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication and Initialization
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

Message360Client client = new Message360Client(basicAuthUserName, basicAuthPassword);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [ConferenceController](#conference_controller)
* [TranscriptionController](#transcription_controller)
* [PhoneNumberController](#phone_number_controller)
* [UsageController](#usage_controller)
* [SMSController](#sms_controller)
* [AccountController](#account_controller)
* [RecordingController](#recording_controller)
* [CallController](#call_controller)
* [CarrierController](#carrier_controller)

### <a name="conference_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.ConferenceController") ConferenceController

#### Get singleton instance

The singleton instance of the ``` ConferenceController ``` class can be accessed from the API Client.

```csharp
IConferenceController conference = client.Conference;
```

#### <a name="create_view_participant"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateViewParticipant") CreateViewParticipant

> View Participant


```csharp
Task<string> CreateViewParticipant(string conferenceSid, string participantSid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | unique conference sid |
| participantSid |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";
string participantSid = "ParticipantSid";
string responseType = "json";

string result = await conference.CreateViewParticipant(conferenceSid, participantSid, responseType);

```


#### <a name="create_list_participant"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateListParticipant") CreateListParticipant

> List Participant


```csharp
Task<string> CreateListParticipant(
        string conferenceSid,
        int? page = null,
        int? pagesize = null,
        bool? muted = null,
        bool? deaf = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | unique conference sid |
| page |  ``` Optional ```  | page number |
| pagesize |  ``` Optional ```  | TODO: Add a parameter description |
| muted |  ``` Optional ```  | TODO: Add a parameter description |
| deaf |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";
int? page = 228;
int? pagesize = 228;
bool? muted = true;
bool? deaf = true;
string responseType = "json";

string result = await conference.CreateListParticipant(conferenceSid, page, pagesize, muted, deaf, responseType);

```


#### <a name="add_participant"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.ConferenceController.AddParticipant") AddParticipant

> Add Participant in conference 


```csharp
Task<string> AddParticipant(
        string conferencesid,
        string participantnumber,
        int tocountrycode,
        bool? muted = null,
        bool? deaf = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferencesid |  ``` Required ```  | Unique Conference Sid |
| participantnumber |  ``` Required ```  | Particiant Number |
| tocountrycode |  ``` Required ```  | TODO: Add a parameter description |
| muted |  ``` Optional ```  | TODO: Add a parameter description |
| deaf |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string conferencesid = "conferencesid";
string participantnumber = "participantnumber";
int tocountrycode = 228;
bool? muted = true;
bool? deaf = true;
string responseType = "json";

string result = await conference.AddParticipant(conferencesid, participantnumber, tocountrycode, muted, deaf, responseType);

```


#### <a name="create_view_conference"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateViewConference") CreateViewConference

> View Conference


```csharp
Task<string> CreateViewConference(string conferencesid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferencesid |  ``` Required ```  | The unique identifier of each conference resource |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string conferencesid = "conferencesid";
string responseType = "json";

string result = await conference.CreateViewConference(conferencesid, responseType);

```


#### <a name="create_list_conference"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateListConference") CreateListConference

> List Conference


```csharp
Task<string> CreateListConference(
        int? page = null,
        int? pageSize = null,
        string friendlyName = null,
        InterruptedCallStatusEnum? status = null,
        string dateCreated = null,
        string dateUpdated = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| friendlyName |  ``` Optional ```  | Only return conferences with the specified FriendlyName |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| dateCreated |  ``` Optional ```  | TODO: Add a parameter description |
| dateUpdated |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int? page = 228;
int? pageSize = 228;
string friendlyName = "FriendlyName";
var status = InterruptedCallStatusEnum?Helper.ParseString("CANCELED");
string dateCreated = "DateCreated";
string dateUpdated = "DateUpdated";
string responseType = "json";

string result = await conference.CreateListConference(page, pageSize, friendlyName, status, dateCreated, dateUpdated, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="transcription_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.TranscriptionController") TranscriptionController

#### Get singleton instance

The singleton instance of the ``` TranscriptionController ``` class can be accessed from the API Client.

```csharp
ITranscriptionController transcription = client.Transcription;
```

#### <a name="create_list_transcription"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateListTranscription") CreateListTranscription

> Get All transcriptions


```csharp
Task<string> CreateListTranscription(
        int? page = null,
        int? pageSize = null,
        StatusEnum? status = null,
        string dateTranscribed = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | TODO: Add a parameter description |
| pageSize |  ``` Optional ```  | TODO: Add a parameter description |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| dateTranscribed |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int? page = 228;
int? pageSize = 228;
var status = StatusEnum?Helper.ParseString("INPROGRESS");
string dateTranscribed = "DateTranscribed";
string responseType = "json";

string result = await transcription.CreateListTranscription(page, pageSize, status, dateTranscribed, responseType);

```


#### <a name="create_recording_transcription"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateRecordingTranscription") CreateRecordingTranscription

> Recording Transcriptions


```csharp
Task<string> CreateRecordingTranscription(string recordingSid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Unique Recording sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string recordingSid = "RecordingSid";
string responseType = "json";

string result = await transcription.CreateRecordingTranscription(recordingSid, responseType);

```


#### <a name="create_view_transcription"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateViewTranscription") CreateViewTranscription

> View Specific Transcriptions


```csharp
Task<string> CreateViewTranscription(string transcriptionSid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transcriptionSid |  ``` Required ```  | Unique Transcription ID |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string transcriptionSid = "TranscriptionSid";
string responseType = "json";

string result = await transcription.CreateViewTranscription(transcriptionSid, responseType);

```


#### <a name="create_audio_url_transcription"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateAudioURLTranscription") CreateAudioURLTranscription

> Audio URL Transcriptions


```csharp
Task<string> CreateAudioURLTranscription(string audioUrl, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| audioUrl |  ``` Required ```  | Audio url |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string audioUrl = "AudioUrl";
string responseType = "json";

string result = await transcription.CreateAudioURLTranscription(audioUrl, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="phone_number_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.PhoneNumberController") PhoneNumberController

#### Get singleton instance

The singleton instance of the ``` PhoneNumberController ``` class can be accessed from the API Client.

```csharp
IPhoneNumberController phoneNumber = client.PhoneNumber;
```

#### <a name="create_available_phone_number"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateAvailablePhoneNumber") CreateAvailablePhoneNumber

> Available Phone Number


```csharp
Task<string> CreateAvailablePhoneNumber(
        string numberType,
        string areaCode,
        int? pageSize = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numberType |  ``` Required ```  | Number type either SMS,Voice or all |
| areaCode |  ``` Required ```  | Phone Number Area Code |
| pageSize |  ``` Optional ```  | Page Size |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string numberType = "NumberType";
string areaCode = "AreaCode";
int? pageSize = 228;
string responseType = "json";

string result = await phoneNumber.CreateAvailablePhoneNumber(numberType, areaCode, pageSize, responseType);

```


#### <a name="create_list_number"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateListNumber") CreateListNumber

> List Account's Phone number details


```csharp
Task<string> CreateListNumber(
        int? page = null,
        int? pageSize = null,
        string numberType = null,
        string friendlyName = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| numberType |  ``` Optional ```  | TODO: Add a parameter description |
| friendlyName |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int? page = 228;
int? pageSize = 228;
string numberType = "NumberType";
string friendlyName = "FriendlyName";
string responseType = "json";

string result = await phoneNumber.CreateListNumber(page, pageSize, numberType, friendlyName, responseType);

```


#### <a name="create_release_number"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateReleaseNumber") CreateReleaseNumber

> Release number from account


```csharp
Task<string> CreateReleaseNumber(string phoneNumber, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Phone number to be relase |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";
string responseType = "json";

string result = await phoneNumber.CreateReleaseNumber(phoneNumber, responseType);

```


#### <a name="create_buy_number"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateBuyNumber") CreateBuyNumber

> Buy Phone Number 


```csharp
Task<string> CreateBuyNumber(string phoneNumber, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Phone number to be purchase |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";
string responseType = "json";

string result = await phoneNumber.CreateBuyNumber(phoneNumber, responseType);

```


#### <a name="create_view_number_details"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateViewNumberDetails") CreateViewNumberDetails

> Get Phone Number Details


```csharp
Task<string> CreateViewNumberDetails(string phoneNumber, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Get Phone number Detail |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";
string responseType = "json";

string result = await phoneNumber.CreateViewNumberDetails(phoneNumber, responseType);

```


#### <a name="update_phone_number"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.UpdatePhoneNumber") UpdatePhoneNumber

> Update Phone Number Details


```csharp
Task<string> UpdatePhoneNumber(
        string phoneNumber,
        string friendlyName = null,
        string voiceUrl = null,
        HttpMethodEnum? voiceMethod = null,
        string voiceFallbackUrl = null,
        HttpMethodEnum? voiceFallbackMethod = null,
        string hangupCallback = null,
        HttpMethodEnum? hangupCallbackMethod = null,
        string heartbeatUrl = null,
        HttpMethodEnum? heartbeatMethod = null,
        string smsUrl = null,
        HttpMethodEnum? smsMethod = null,
        string smsFallbackUrl = null,
        HttpMethodEnum? smsFallbackMethod = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | TODO: Add a parameter description |
| friendlyName |  ``` Optional ```  | TODO: Add a parameter description |
| voiceUrl |  ``` Optional ```  | URL requested once the call connects |
| voiceMethod |  ``` Optional ```  | TODO: Add a parameter description |
| voiceFallbackUrl |  ``` Optional ```  | URL requested if the voice URL is not available |
| voiceFallbackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| hangupCallback |  ``` Optional ```  | TODO: Add a parameter description |
| hangupCallbackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| heartbeatUrl |  ``` Optional ```  | URL requested once the call connects |
| heartbeatMethod |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed time |
| smsUrl |  ``` Optional ```  | URL requested when an SMS is received |
| smsMethod |  ``` Optional ```  | TODO: Add a parameter description |
| smsFallbackUrl |  ``` Optional ```  | URL requested once the call connects |
| smsFallbackMethod |  ``` Optional ```  | URL requested if the sms URL is not available |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";
string friendlyName = "FriendlyName";
string voiceUrl = "VoiceUrl";
var voiceMethod = HttpMethodEnum?Helper.ParseString("GET");
string voiceFallbackUrl = "VoiceFallbackUrl";
var voiceFallbackMethod = HttpMethodEnum?Helper.ParseString("GET");
string hangupCallback = "HangupCallback";
var hangupCallbackMethod = HttpMethodEnum?Helper.ParseString("GET");
string heartbeatUrl = "HeartbeatUrl";
var heartbeatMethod = HttpMethodEnum?Helper.ParseString("GET");
string smsUrl = "SmsUrl";
var smsMethod = HttpMethodEnum?Helper.ParseString("GET");
string smsFallbackUrl = "SmsFallbackUrl";
var smsFallbackMethod = HttpMethodEnum?Helper.ParseString("GET");
string responseType = "json";

string result = await phoneNumber.UpdatePhoneNumber(phoneNumber, friendlyName, voiceUrl, voiceMethod, voiceFallbackUrl, voiceFallbackMethod, hangupCallback, hangupCallbackMethod, heartbeatUrl, heartbeatMethod, smsUrl, smsMethod, smsFallbackUrl, smsFallbackMethod, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="usage_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.UsageController") UsageController

#### Get singleton instance

The singleton instance of the ``` UsageController ``` class can be accessed from the API Client.

```csharp
IUsageController usage = client.Usage;
```

#### <a name="create_list_usage"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.UsageController.CreateListUsage") CreateListUsage

> Get all usage 


```csharp
Task<string> CreateListUsage(
        string productCode,
        string startDate,
        string endDate,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| productCode |  ``` Required ```  ``` DefaultValue ```  | Product Code |
| startDate |  ``` Required ```  ``` DefaultValue ```  | Start Usage Date |
| endDate |  ``` Required ```  ``` DefaultValue ```  | End Usage Date |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string productCode = "0";
string startDate = "2016-09-06";
string endDate = "2016-09-06";
string responseType = "json";

string result = await usage.CreateListUsage(productCode, startDate, endDate, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="sms_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.SMSController") SMSController

#### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
ISMSController sMS = client.SMS;
```

#### <a name="create_send_sms"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateSendSMS") CreateSendSMS

> Send an SMS from a message360 number


```csharp
Task<string> CreateSendSMS(
        int fromcountrycode,
        string mfrom,
        int tocountrycode,
        string to,
        string body,
        HttpMethodEnum? method = null,
        string messagestatuscallback = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromcountrycode |  ``` Required ```  ``` DefaultValue ```  | From Country Code |
| mfrom |  ``` Required ```  | SMS enabled Message360 number to send this message from |
| tocountrycode |  ``` Required ```  ``` DefaultValue ```  | To country code |
| to |  ``` Required ```  | Number to send the SMS to |
| body |  ``` Required ```  | Text Message To Send |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once SMS sent. |
| messagestatuscallback |  ``` Optional ```  | URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int fromcountrycode = 1;
string mfrom = "from";
int tocountrycode = 1;
string to = "to";
string body = "body";
var method = HttpMethodEnum?Helper.ParseString("GET");
string messagestatuscallback = "messagestatuscallback";
string responseType = "json";

string result = await sMS.CreateSendSMS(fromcountrycode, mfrom, tocountrycode, to, body, method, messagestatuscallback, responseType);

```


#### <a name="create_view_sms"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateViewSMS") CreateViewSMS

> View Particular SMS


```csharp
Task<string> CreateViewSMS(string messagesid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messagesid |  ``` Required ```  | Message sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string messagesid = "messagesid";
string responseType = "json";

string result = await sMS.CreateViewSMS(messagesid, responseType);

```


#### <a name="create_list_sms"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateListSMS") CreateListSMS

> List All SMS


```csharp
Task<string> CreateListSMS(
        int? page = null,
        int? pagesize = null,
        string mfrom = null,
        string to = null,
        string datesent = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Messages sent from this number |
| to |  ``` Optional ```  | Messages sent to this number |
| datesent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int? page = 228;
int? pagesize = 228;
string mfrom = "from";
string to = "to";
string datesent = "datesent";
string responseType = "json";

string result = await sMS.CreateListSMS(page, pagesize, mfrom, to, datesent, responseType);

```


#### <a name="create_list_inbound_sms"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateListInboundSMS") CreateListInboundSMS

> List All Inbound SMS


```csharp
Task<string> CreateListInboundSMS(
        int? page = null,
        string pagesize = null,
        string mfrom = null,
        string to = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound SMS |
| to |  ``` Optional ```  | To Number to get Inbound SMS |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int? page = 228;
string pagesize = "pagesize";
string mfrom = "from";
string to = "to";
string responseType = "json";

string result = await sMS.CreateListInboundSMS(page, pagesize, mfrom, to, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="account_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.AccountController") AccountController

#### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
IAccountController account = client.Account;
```

#### <a name="create_view_account"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.AccountController.CreateViewAccount") CreateViewAccount

> Display Account Description


```csharp
Task<string> CreateViewAccount(string date, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
string date = "date";
string responseType = "json";

string result = await account.CreateViewAccount(date, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="recording_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.RecordingController") RecordingController

#### Get singleton instance

The singleton instance of the ``` RecordingController ``` class can be accessed from the API Client.

```csharp
IRecordingController recording = client.Recording;
```

#### <a name="create_delete_recording"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.RecordingController.CreateDeleteRecording") CreateDeleteRecording

> Delete Recording Record


```csharp
Task<string> CreateDeleteRecording(string recordingSid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Unique Recording Sid to be delete |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string recordingSid = "RecordingSid";
string responseType = "json";

string result = await recording.CreateDeleteRecording(recordingSid, responseType);

```


#### <a name="create_view_recording"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.RecordingController.CreateViewRecording") CreateViewRecording

> View a specific Recording


```csharp
Task<string> CreateViewRecording(string recordingSid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Search Recording sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string recordingSid = "RecordingSid";
string responseType = "json";

string result = await recording.CreateViewRecording(recordingSid, responseType);

```


#### <a name="create_list_recording"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.RecordingController.CreateListRecording") CreateListRecording

> List out Recordings


```csharp
Task<string> CreateListRecording(
        int? page = null,
        int? pageSize = null,
        string dateCreated = null,
        string callSid = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| dateCreated |  ``` Optional ```  | TODO: Add a parameter description |
| callSid |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int? page = 228;
int? pageSize = 228;
string dateCreated = "DateCreated";
string callSid = "CallSid";
string responseType = "json";

string result = await recording.CreateListRecording(page, pageSize, dateCreated, callSid, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="call_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.CallController") CallController

#### Get singleton instance

The singleton instance of the ``` CallController ``` class can be accessed from the API Client.

```csharp
ICallController call = client.Call;
```

#### <a name="create_view_call"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateViewCall") CreateViewCall

> View Call Response


```csharp
Task<string> CreateViewCall(string callsid, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callsid |  ``` Required ```  | Call Sid id for particular Call |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string callsid = "callsid";
string responseType = "json";

string result = await call.CreateViewCall(callsid, responseType);

```


#### <a name="create_make_call"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateMakeCall") CreateMakeCall

> You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json


```csharp
Task<string> CreateMakeCall(
        string fromCountryCode,
        string mfrom,
        string toCountryCode,
        string to,
        string url,
        HttpMethodEnum? method = null,
        string statusCallBackUrl = null,
        HttpMethodEnum? statusCallBackMethod = null,
        string fallBackUrl = null,
        HttpMethodEnum? fallBackMethod = null,
        string heartBeatUrl = null,
        bool? heartBeatMethod = null,
        int? timeout = null,
        string playDtmf = null,
        bool? hideCallerId = null,
        bool? record = null,
        string recordCallBackUrl = null,
        HttpMethodEnum? recordCallBackMethod = null,
        bool? transcribe = null,
        string transcribeCallBackUrl = null,
        IfMachineEnum? ifMachine = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromCountryCode |  ``` Required ```  | from country code |
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| toCountryCode |  ``` Required ```  | To cuntry code number |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| heartBeatUrl |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed tim |
| heartBeatMethod |  ``` Optional ```  | Specifies the HTTP method used to request HeartbeatUrl. |
| timeout |  ``` Optional ```  | Time (in seconds) Message360 should wait while the call is ringing before canceling the call |
| playDtmf |  ``` Optional ```  | DTMF Digits to play to the call once it connects. 0-9, #, or * |
| hideCallerId |  ``` Optional ```  | Specifies if the caller id will be hidden |
| record |  ``` Optional ```  | Specifies if the call should be recorded |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion |
| recordCallBackMethod |  ``` Optional ```  | Method used to request the RecordCallback URL. |
| transcribe |  ``` Optional ```  | Specifies if the call recording should be transcribed |
| transcribeCallBackUrl |  ``` Optional ```  | Transcription parameters will be sent here upon completion |
| ifMachine |  ``` Optional ```  | How Message360 should handle the receiving numbers voicemail machine |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string fromCountryCode = "FromCountryCode";
string mfrom = "From";
string toCountryCode = "ToCountryCode";
string to = "To";
string url = "Url";
var method = HttpMethodEnum?Helper.ParseString("GET");
string statusCallBackUrl = "StatusCallBackUrl";
var statusCallBackMethod = HttpMethodEnum?Helper.ParseString("GET");
string fallBackUrl = "FallBackUrl";
var fallBackMethod = HttpMethodEnum?Helper.ParseString("GET");
string heartBeatUrl = "HeartBeatUrl";
bool? heartBeatMethod = true;
int? timeout = 228;
string playDtmf = "PlayDtmf";
bool? hideCallerId = true;
bool? record = true;
string recordCallBackUrl = "RecordCallBackUrl";
var recordCallBackMethod = HttpMethodEnum?Helper.ParseString("GET");
bool? transcribe = true;
string transcribeCallBackUrl = "TranscribeCallBackUrl";
var ifMachine = IfMachineEnum?Helper.ParseString("CONTINUE");
string responseType = "json";

string result = await call.CreateMakeCall(fromCountryCode, mfrom, toCountryCode, to, url, method, statusCallBackUrl, statusCallBackMethod, fallBackUrl, fallBackMethod, heartBeatUrl, heartBeatMethod, timeout, playDtmf, hideCallerId, record, recordCallBackUrl, recordCallBackMethod, transcribe, transcribeCallBackUrl, ifMachine, responseType);

```


#### <a name="create_play_audio"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreatePlayAudio") CreatePlayAudio

> Play Dtmf and send the Digit


```csharp
Task<string> CreatePlayAudio(
        int length,
        DirectionEnum direction,
        bool loop,
        bool mix,
        string callSid = null,
        string audioUrl = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| length |  ``` Required ```  | Time limit in seconds for audio play back |
| direction |  ``` Required ```  | The leg of the call audio will be played to |
| loop |  ``` Required ```  | Repeat audio playback indefinitely |
| mix |  ``` Required ```  | If false, all other audio will be muted |
| callSid |  ``` Optional ```  | The unique identifier of each call resource |
| audioUrl |  ``` Optional ```  | URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
int length = 228;
var direction = DirectionEnumHelper.ParseString("IN");
bool loop = true;
bool mix = true;
string callSid = "CallSid";
string audioUrl = "AudioUrl";
string responseType = "json";

string result = await call.CreatePlayAudio(length, direction, loop, mix, callSid, audioUrl, responseType);

```


#### <a name="create_record_call"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateRecordCall") CreateRecordCall

> Record a Call


```csharp
Task<string> CreateRecordCall(
        string callSid,
        bool record,
        DirectionEnum? direction = null,
        int? timeLimit = null,
        string callBackUrl = null,
        AudioFormatEnum? fileformat = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| record |  ``` Required ```  | Set true to initiate recording or false to terminate recording |
| direction |  ``` Optional ```  | The leg of the call to record |
| timeLimit |  ``` Optional ```  | Time in seconds the recording duration should not exceed |
| callBackUrl |  ``` Optional ```  | URL consulted after the recording completes |
| fileformat |  ``` Optional ```  | Format of the recording file. Can be .mp3 or .wav |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string callSid = "CallSid";
bool record = true;
var direction = DirectionEnum?Helper.ParseString("IN");
int? timeLimit = 228;
string callBackUrl = "CallBackUrl";
var fileformat = AudioFormatEnum?Helper.ParseString("mp3");
string responseType = "json";

string result = await call.CreateRecordCall(callSid, record, direction, timeLimit, callBackUrl, fileformat, responseType);

```


#### <a name="create_voice_effect"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateVoiceEffect") CreateVoiceEffect

> Voice Effect


```csharp
Task<string> CreateVoiceEffect(
        string callSid,
        AudioDirectionEnum? audioDirection = null,
        double? pitchSemiTones = null,
        double? pitchOctaves = null,
        double? pitch = null,
        double? rate = null,
        double? tempo = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | TODO: Add a parameter description |
| audioDirection |  ``` Optional ```  | TODO: Add a parameter description |
| pitchSemiTones |  ``` Optional ```  | value between -14 and 14 |
| pitchOctaves |  ``` Optional ```  | value between -1 and 1 |
| pitch |  ``` Optional ```  | value greater than 0 |
| rate |  ``` Optional ```  | value greater than 0 |
| tempo |  ``` Optional ```  | value greater than 0 |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string callSid = "CallSid";
var audioDirection = AudioDirectionEnum?Helper.ParseString("IN");
double? pitchSemiTones = 228.786753774056;
double? pitchOctaves = 228.786753774056;
double? pitch = 228.786753774056;
double? rate = 228.786753774056;
double? tempo = 228.786753774056;
string responseType = "json";

string result = await call.CreateVoiceEffect(callSid, audioDirection, pitchSemiTones, pitchOctaves, pitch, rate, tempo, responseType);

```


#### <a name="create_send_digit"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateSendDigit") CreateSendDigit

> Play Dtmf and send the Digit


```csharp
Task<string> CreateSendDigit(
        string callSid,
        string playDtmf,
        DirectionEnum? playDtmfDirection = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| playDtmf |  ``` Required ```  | DTMF digits to play to the call. 0-9, #, *, W, or w |
| playDtmfDirection |  ``` Optional ```  | The leg of the call DTMF digits should be sent to |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string callSid = "CallSid";
string playDtmf = "PlayDtmf";
var playDtmfDirection = DirectionEnum?Helper.ParseString("IN");
string responseType = "json";

string result = await call.CreateSendDigit(callSid, playDtmf, playDtmfDirection, responseType);

```


#### <a name="create_interrupted_call"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateInterruptedCall") CreateInterruptedCall

> Interrupt the Call by Call Sid


```csharp
Task<string> CreateInterruptedCall(
        string callSid,
        string url = null,
        HttpMethodEnum? method = null,
        InterruptedCallStatusEnum? status = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | Call SId |
| url |  ``` Optional ```  | URL the in-progress call will be redirected to |
| method |  ``` Optional ```  | The method used to request the above Url parameter |
| status |  ``` Optional ```  | Status to set the in-progress call to |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string callSid = "CallSid";
string url = "Url";
var method = HttpMethodEnum?Helper.ParseString("GET");
var status = InterruptedCallStatusEnum?Helper.ParseString("CANCELED");
string responseType = "json";

string result = await call.CreateInterruptedCall(callSid, url, method, status, responseType);

```


#### <a name="create_list_calls"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CallController.CreateListCalls") CreateListCalls

> A list of calls associated with your Message360 account


```csharp
Task CreateListCalls(
        string page = null,
        string pageSize = null,
        string to = null,
        string mfrom = null,
        string dateCreated = null,
        string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| to |  ``` Optional ```  | Only list calls to this number |
| mfrom |  ``` Optional ```  | Only list calls from this number |
| dateCreated |  ``` Optional ```  | Only list calls starting within the specified date range |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string page = "Page";
string pageSize = "PageSize";
string to = "To";
string mfrom = "From";
string dateCreated = "DateCreated";
string responseType = "json";

await call.CreateListCalls(page, pageSize, to, mfrom, dateCreated, responseType);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="carrier_controller"></a>![Class: ](http://apidocs.io/img/class.png "message360.Controllers.CarrierController") CarrierController

#### Get singleton instance

The singleton instance of the ``` CarrierController ``` class can be accessed from the API Client.

```csharp
ICarrierController carrier = client.Carrier;
```

#### <a name="create_carrier_lookup"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CarrierController.CreateCarrierLookup") CreateCarrierLookup

> Get the Carrier Lookup


```csharp
Task<string> CreateCarrierLookup(string phonenumber, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | The number to lookup |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string phonenumber = "phonenumber";
string responseType = "json";

string result = await carrier.CreateCarrierLookup(phonenumber, responseType);

```


#### <a name="create_carrier_lookup_list"></a>![Method: ](http://apidocs.io/img/method.png "message360.Controllers.CarrierController.CreateCarrierLookupList") CreateCarrierLookupList

> Get the All Purchase Number's Carrier lookup


```csharp
Task<string> CreateCarrierLookupList(string page = null, string pagesize = null, string responseType = "json")
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page Number |
| pagesize |  ``` Optional ```  | Page Size |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
string page = "page";
string pagesize = "pagesize";
string responseType = "json";

string result = await carrier.CreateCarrierLookupList(page, pagesize, responseType);

```


[Back to List of Controllers](#list_of_controllers)



