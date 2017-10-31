# Getting started

message360 API version 3

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (Message360.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Message360 library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

### 3. Add reference of the library project

In order to use the Message360 library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Message360.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```Message360.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
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



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SharedShortCodeController](#shared_short_code_controller)
* [ConferenceController](#conference_controller)
* [TranscriptionController](#transcription_controller)
* [PhoneNumberController](#phone_number_controller)
* [UsageController](#usage_controller)
* [WebRTCController](#web_rtc_controller)
* [RecordingController](#recording_controller)
* [EmailController](#email_controller)
* [SMSController](#sms_controller)
* [CallController](#call_controller)
* [CarrierController](#carrier_controller)
* [AddressController](#address_controller)
* [SubAccountController](#sub_account_controller)
* [AccountController](#account_controller)
* [ShortCodeController](#short_code_controller)

## <a name="shared_short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.SharedShortCodeController") SharedShortCodeController

### Get singleton instance

The singleton instance of the ``` SharedShortCodeController ``` class can be accessed from the API Client.

```csharp
SharedShortCodeController sharedShortCode = client.SharedShortCode;
```

### <a name="view_template"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ViewTemplate") ViewTemplate

> View a Shared ShortCode Template


```csharp
Task<string> ViewTemplate(Models.ViewTemplateInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| templateid |  ``` Required ```  | The unique identifier for a template object |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewTemplateInput collect = new ViewTemplateInput();

Guid templateid = Guid.NewGuid();
collect.Templateid = templateid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sharedShortCode.ViewTemplate(collect);

```


### <a name="view_shared_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ViewSharedShortcodes") ViewSharedShortcodes

> View a ShortCode Message


```csharp
Task<string> ViewSharedShortcodes(Models.ViewSharedShortcodesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messagesid |  ``` Required ```  | Message sid |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewSharedShortcodesInput collect = new ViewSharedShortcodesInput();

string messagesid = "messagesid";
collect.Messagesid = messagesid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sharedShortCode.ViewSharedShortcodes(collect);

```


### <a name="list_outbound_shared_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ListOutboundSharedShortcodes") ListOutboundSharedShortcodes

> List ShortCode Messages


```csharp
Task<string> ListOutboundSharedShortcodes(Models.ListOutboundSharedShortcodesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Messages sent from this number |
| to |  ``` Optional ```  | Messages sent to this number |
| datesent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |


#### Example Usage

```csharp
ListOutboundSharedShortcodesInput collect = new ListOutboundSharedShortcodesInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string datesent = "datesent";
collect.Datesent = datesent;


string result = await sharedShortCode.ListOutboundSharedShortcodes(collect);

```


### <a name="list_inbound_shared_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ListInboundSharedShortcodes") ListInboundSharedShortcodes

> List All Inbound ShortCode


```csharp
Task<string> ListInboundSharedShortcodes(Models.ListInboundSharedShortcodesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound ShortCode |
| shortcode |  ``` Optional ```  | Only list messages sent to this Short Code |
| dateReceived |  ``` Optional ```  | Only list messages sent with the specified date |


#### Example Usage

```csharp
ListInboundSharedShortcodesInput collect = new ListInboundSharedShortcodesInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string dateReceived = "DateReceived";
collect.DateReceived = dateReceived;


string result = await sharedShortCode.ListInboundSharedShortcodes(collect);

```


### <a name="send_shared_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.SendSharedShortcode") SendSharedShortcode

> Send an SMS from a message360 ShortCode


```csharp
Task<string> SendSharedShortcode(Models.SendSharedShortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | The Short Code number that is the sender of this message |
| to |  ``` Required ```  | A valid 10-digit number that should receive the message |
| templateid |  ``` Required ```  | The unique identifier for the template used for the message |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| data |  ``` Required ```  | format of your data, example: {companyname}:test,{otpcode}:1234 |
| method |  ``` Optional ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |


#### Example Usage

```csharp
SendSharedShortcodeInput collect = new SendSharedShortcodeInput();

string shortcode = "shortcode";
collect.Shortcode = shortcode;

string to = "to";
collect.To = to;

Guid templateid = Guid.NewGuid();
collect.Templateid = templateid;

string responseType = "json";
collect.ResponseType = responseType;

string data = "data";
collect.Data = data;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string messageStatusCallback = "MessageStatusCallback";
collect.MessageStatusCallback = messageStatusCallback;


string result = await sharedShortCode.SendSharedShortcode(collect);

```


### <a name="list_templates"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ListTemplates") ListTemplates

> List Shortcode Templates by Type


```csharp
Task<string> ListTemplates(Models.ListTemplatesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| type |  ``` Optional ```  ``` DefaultValue ```  | The type (category) of template Valid values: marketing, authorization |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| shortcode |  ``` Optional ```  | Only list templates of type |


#### Example Usage

```csharp
ListTemplatesInput collect = new ListTemplatesInput();

string responseType = "json";
collect.ResponseType = responseType;

string type = "authorization";
collect.Type = type;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;


string result = await sharedShortCode.ListTemplates(collect);

```


### <a name="view_keyword"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ViewKeyword") ViewKeyword

> View a set of properties for a single keyword.


```csharp
Task<string> ViewKeyword(Models.ViewKeywordInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| keywordid |  ``` Required ```  | The unique identifier of each keyword |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewKeywordInput collect = new ViewKeywordInput();

string keywordid = "Keywordid";
collect.Keywordid = keywordid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sharedShortCode.ViewKeyword(collect);

```


### <a name="list_keyword"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ListKeyword") ListKeyword

> Retrieve a list of keywords associated with your message360 account.


```csharp
Task<string> ListKeyword(Models.ListKeywordInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| keyword |  ``` Optional ```  | Only list keywords of keyword |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
ListKeywordInput collect = new ListKeywordInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string keyword = "Keyword";
collect.Keyword = keyword;

int? shortcode = 47;
collect.Shortcode = shortcode;


string result = await sharedShortCode.ListKeyword(collect);

```


### <a name="view_assignement"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ViewAssignement") ViewAssignement

> The response returned here contains all resource properties associated with the given Shortcode.


```csharp
Task<string> ViewAssignement(Models.ViewAssignementInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Shortcode to your message360 account |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewAssignementInput collect = new ViewAssignementInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sharedShortCode.ViewAssignement(collect);

```


### <a name="list_assignment"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.ListAssignment") ListAssignment

> Retrieve a list of shortcode assignment associated with your message360 account.


```csharp
Task<string> ListAssignment(Models.ListAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
ListAssignmentInput collect = new ListAssignmentInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;


string result = await sharedShortCode.ListAssignment(collect);

```


### <a name="update_assignment"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SharedShortCodeController.UpdateAssignment") UpdateAssignment

> TODO: Add a method description


```csharp
Task<string> UpdateAssignment(Models.UpdateAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid shortcode to your message360 account |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| friendlyName |  ``` Optional ```  | User generated name of the shortcode |
| callbackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| callbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |
| fallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST. |
| fallbackUrlMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |


#### Example Usage

```csharp
UpdateAssignmentInput collect = new UpdateAssignmentInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string responseType = "json";
collect.ResponseType = responseType;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string callbackUrl = "CallbackUrl";
collect.CallbackUrl = callbackUrl;

var callbackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.CallbackMethod = callbackMethod;

string fallbackUrl = "FallbackUrl";
collect.FallbackUrl = fallbackUrl;

var fallbackUrlMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.FallbackUrlMethod = fallbackUrlMethod;


string result = await sharedShortCode.UpdateAssignment(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="conference_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.ConferenceController") ConferenceController

### Get singleton instance

The singleton instance of the ``` ConferenceController ``` class can be accessed from the API Client.

```csharp
ConferenceController conference = client.Conference;
```

### <a name="deaf_mute_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.DeafMuteParticipant") DeafMuteParticipant

> Deaf Mute Participant


```csharp
Task<string> DeafMuteParticipant(Models.DeafMuteParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | ID of the active conference |
| participantSid |  ``` Required ```  | ID of an active participant |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| muted |  ``` Optional ```  | Mute a participant |
| deaf |  ``` Optional ```  | Make it so a participant cant hear |


#### Example Usage

```csharp
DeafMuteParticipantInput collect = new DeafMuteParticipantInput();

string conferenceSid = "conferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

string responseType = "json";
collect.ResponseType = responseType;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.DeafMuteParticipant(collect);

```


### <a name="view_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.ViewParticipant") ViewParticipant

> View Participant


```csharp
Task<string> ViewParticipant(Models.ViewParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | unique conference sid |
| participantSid |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewParticipantInput collect = new ViewParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.ViewParticipant(collect);

```


### <a name="add_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.AddParticipant") AddParticipant

> Add Participant in conference 


```csharp
Task<string> AddParticipant(Models.AddParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferencesid |  ``` Required ```  | Unique Conference Sid |
| participantnumber |  ``` Required ```  | Particiant Number |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| muted |  ``` Optional ```  | add muted |
| deaf |  ``` Optional ```  | add without volume |


#### Example Usage

```csharp
AddParticipantInput collect = new AddParticipantInput();

string conferencesid = "conferencesid";
collect.Conferencesid = conferencesid;

string participantnumber = "participantnumber";
collect.Participantnumber = participantnumber;

string responseType = "json";
collect.ResponseType = responseType;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.AddParticipant(collect);

```


### <a name="view_conference"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.ViewConference") ViewConference

> View Conference


```csharp
Task<string> ViewConference(Models.ViewConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferencesid |  ``` Required ```  | The unique identifier of each conference resource |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewConferenceInput collect = new ViewConferenceInput();

string conferencesid = "conferencesid";
collect.Conferencesid = conferencesid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.ViewConference(collect);

```


### <a name="create_conference"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateConference") CreateConference

> Here you can experiment with initiating a conference call through message360 and view the request response generated when doing so.


```csharp
Task<string> CreateConference(Models.CreateConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
| method |  ``` Required ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once call connects. |
| recordCallbackUrl |  ``` Required ```  | Recording parameters will be sent here upon completion. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the conference is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| record |  ``` Optional ```  | Specifies if the conference should be recorded. |
| recordCallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once conference connects. |
| schdeuleTime |  ``` Optional ```  | Schedule conference in future. Schedule time must be greater than current time |
| timeout |  ``` Optional ```  | The number of seconds the call stays on the line while waiting for an answer. The max time limit is 999 and the default limit is 60 seconds but lower times can be set. |


#### Example Usage

```csharp
CreateConferenceInput collect = new CreateConferenceInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

var method = Models.HttpActionEnumHelper.ParseString("POST");
collect.Method = method;

string recordCallbackUrl = "RecordCallbackUrl";
collect.RecordCallbackUrl = recordCallbackUrl;

string responseType = "json";
collect.ResponseType = responseType;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statusCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

var fallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.FallBackMethod = fallBackMethod;

bool? record = true;
collect.Record = record;

var recordCallbackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.RecordCallbackMethod = recordCallbackMethod;

string schdeuleTime = "SchdeuleTime";
collect.SchdeuleTime = schdeuleTime;

int? timeout = 138;
collect.Timeout = timeout;


string result = await conference.CreateConference(collect);

```


### <a name="hangup_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.HangupParticipant") HangupParticipant

> Remove a participant from a conference.


```csharp
Task<string> HangupParticipant(Models.HangupParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
HangupParticipantInput collect = new HangupParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.HangupParticipant(collect);

```


### <a name="play_conference_audio"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.PlayConferenceAudio") PlayConferenceAudio

> Play an audio file during a conference.


```csharp
Task<string> PlayConferenceAudio(Models.PlayConferenceAudioInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |
| audioUrl |  ``` Required ```  | The URL for the audio file that is to be played during the conference. Multiple audio files can be chained by using a semicolon. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
PlayConferenceAudioInput collect = new PlayConferenceAudioInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

var audioUrl = Models.AudioFormatEnumHelper.ParseString("mp3");
collect.AudioUrl = audioUrl;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.PlayConferenceAudio(collect);

```


### <a name="list_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.ListParticipant") ListParticipant

> List Participant


```csharp
Task<string> ListParticipant(Models.ListParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | unique conference sid |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response format, xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | page number |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Amount of records to return per page |
| muted |  ``` Optional ```  | Participants that are muted |
| deaf |  ``` Optional ```  | Participants cant hear |


#### Example Usage

```csharp
ListParticipantInput collect = new ListParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

bool? muted = true;
collect.Muted = muted;

bool? deaf = true;
collect.Deaf = deaf;


string result = await conference.ListParticipant(collect);

```


### <a name="list_conference"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.ListConference") ListConference

> List Conference


```csharp
Task<string> ListConference(Models.ListConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| friendlyName |  ``` Optional ```  | Only return conferences with the specified FriendlyName |
| dateCreated |  ``` Optional ```  | Conference created date |


#### Example Usage

```csharp
ListConferenceInput collect = new ListConferenceInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;


string result = await conference.ListConference(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="transcription_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.TranscriptionController") TranscriptionController

### Get singleton instance

The singleton instance of the ``` TranscriptionController ``` class can be accessed from the API Client.

```csharp
TranscriptionController transcription = client.Transcription;
```

### <a name="list_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.ListTranscription") ListTranscription

> Get All transcriptions


```csharp
Task<string> ListTranscription(Models.ListTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | page number |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Amount of data per page |
| status |  ``` Optional ```  | Transcription status |
| dateTranscribed |  ``` Optional ```  | Transcription date |


#### Example Usage

```csharp
ListTranscriptionInput collect = new ListTranscriptionInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

var status = Models.StatusEnum?Helper.ParseString("INPROGRESS");
collect.Status = status;

string dateTranscribed = "DateTranscribed";
collect.DateTranscribed = dateTranscribed;


string result = await transcription.ListTranscription(collect);

```


### <a name="view_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.ViewTranscription") ViewTranscription

> View Specific Transcriptions


```csharp
Task<string> ViewTranscription(Models.ViewTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transcriptionSid |  ``` Required ```  | Unique Transcription ID |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewTranscriptionInput collect = new ViewTranscriptionInput();

string transcriptionSid = "TranscriptionSid";
collect.TranscriptionSid = transcriptionSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.ViewTranscription(collect);

```


### <a name="recording_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.RecordingTranscription") RecordingTranscription

> Recording Transcriptions


```csharp
Task<string> RecordingTranscription(Models.RecordingTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Unique Recording sid |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
RecordingTranscriptionInput collect = new RecordingTranscriptionInput();

string recordingSid = "RecordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.RecordingTranscription(collect);

```


### <a name="audio_url_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.AudioURLTranscription") AudioURLTranscription

> Audio URL Transcriptions


```csharp
Task<string> AudioURLTranscription(Models.AudioURLTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| audioUrl |  ``` Required ```  | Audio url |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
AudioURLTranscriptionInput collect = new AudioURLTranscriptionInput();

string audioUrl = "AudioUrl";
collect.AudioUrl = audioUrl;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.AudioURLTranscription(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="phone_number_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.PhoneNumberController") PhoneNumberController

### Get singleton instance

The singleton instance of the ``` PhoneNumberController ``` class can be accessed from the API Client.

```csharp
PhoneNumberController phoneNumber = client.PhoneNumber;
```

### <a name="available_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.AvailablePhoneNumber") AvailablePhoneNumber

> Available Phone Number


```csharp
Task<string> AvailablePhoneNumber(Models.AvailablePhoneNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numberType |  ``` Required ```  | Number type either SMS,Voice or all |
| areaCode |  ``` Required ```  | Phone Number Area Code |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Page Size |


#### Example Usage

```csharp
AvailablePhoneNumberInput collect = new AvailablePhoneNumberInput();

var numberType = Models.NumberTypeEnumHelper.ParseString("ALL");
collect.NumberType = numberType;

string areaCode = "AreaCode";
collect.AreaCode = areaCode;

string responseType = "json";
collect.ResponseType = responseType;

int? pageSize = 10;
collect.PageSize = pageSize;


string result = await phoneNumber.AvailablePhoneNumber(collect);

```


### <a name="list_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.ListNumber") ListNumber

> List Account's Phone number details


```csharp
Task<string> ListNumber(Models.ListNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| numberType |  ``` Optional ```  | SMS or Voice |
| friendlyName |  ``` Optional ```  | Friendly name of the number |


#### Example Usage

```csharp
ListNumberInput collect = new ListNumberInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

var numberType = Models.NumberTypeEnum?Helper.ParseString("ALL");
collect.NumberType = numberType;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;


string result = await phoneNumber.ListNumber(collect);

```


### <a name="view_number_details"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.ViewNumberDetails") ViewNumberDetails

> Get Phone Number Details


```csharp
Task<string> ViewNumberDetails(Models.ViewNumberDetailsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Get Phone number Detail |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewNumberDetailsInput collect = new ViewNumberDetailsInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.ViewNumberDetails(collect);

```


### <a name="release_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.ReleaseNumber") ReleaseNumber

> Release number from account


```csharp
Task<string> ReleaseNumber(Models.ReleaseNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Phone number to be relase |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ReleaseNumberInput collect = new ReleaseNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.ReleaseNumber(collect);

```


### <a name="buy_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.BuyNumber") BuyNumber

> Buy Phone Number 


```csharp
Task<string> BuyNumber(Models.BuyNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Phone number to be purchase |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
BuyNumberInput collect = new BuyNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.BuyNumber(collect);

```


### <a name="update_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.UpdatePhoneNumber") UpdatePhoneNumber

> Update Phone Number Details


```csharp
Task<string> UpdatePhoneNumber(Models.UpdatePhoneNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | The phone number to update |
| voiceUrl |  ``` Required ```  | URL requested once the call connects |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| friendlyName |  ``` Optional ```  | Phone number friendly name description |
| voiceMethod |  ``` Optional ```  | Post or Get |
| voiceFallbackUrl |  ``` Optional ```  | URL requested if the voice URL is not available |
| voiceFallbackMethod |  ``` Optional ```  | Post or Get |
| hangupCallback |  ``` Optional ```  | callback url after a hangup occurs |
| hangupCallbackMethod |  ``` Optional ```  | Post or Get |
| heartbeatUrl |  ``` Optional ```  | URL requested once the call connects |
| heartbeatMethod |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed time |
| smsUrl |  ``` Optional ```  | URL requested when an SMS is received |
| smsMethod |  ``` Optional ```  | Post or Get |
| smsFallbackUrl |  ``` Optional ```  | URL requested once the call connects |
| smsFallbackMethod |  ``` Optional ```  | URL requested if the sms URL is not available |


#### Example Usage

```csharp
UpdatePhoneNumberInput collect = new UpdatePhoneNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string voiceUrl = "VoiceUrl";
collect.VoiceUrl = voiceUrl;

string responseType = "json";
collect.ResponseType = responseType;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

var voiceMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.VoiceMethod = voiceMethod;

string voiceFallbackUrl = "VoiceFallbackUrl";
collect.VoiceFallbackUrl = voiceFallbackUrl;

var voiceFallbackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.VoiceFallbackMethod = voiceFallbackMethod;

string hangupCallback = "HangupCallback";
collect.HangupCallback = hangupCallback;

var hangupCallbackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.HangupCallbackMethod = hangupCallbackMethod;

string heartbeatUrl = "HeartbeatUrl";
collect.HeartbeatUrl = heartbeatUrl;

var heartbeatMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.HeartbeatMethod = heartbeatMethod;

string smsUrl = "SmsUrl";
collect.SmsUrl = smsUrl;

var smsMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.SmsMethod = smsMethod;

string smsFallbackUrl = "SmsFallbackUrl";
collect.SmsFallbackUrl = smsFallbackUrl;

var smsFallbackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.SmsFallbackMethod = smsFallbackMethod;


string result = await phoneNumber.UpdatePhoneNumber(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="usage_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.UsageController") UsageController

### Get singleton instance

The singleton instance of the ``` UsageController ``` class can be accessed from the API Client.

```csharp
UsageController usage = client.Usage;
```

### <a name="list_usage"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.UsageController.ListUsage") ListUsage

> Get all usage 


```csharp
Task<string> ListUsage(Models.ListUsageInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| productCode |  ``` Optional ```  ``` DefaultValue ```  | Product Code |
| startDate |  ``` Optional ```  ``` DefaultValue ```  | Start Usage Date |
| endDate |  ``` Optional ```  ``` DefaultValue ```  | End Usage Date |


#### Example Usage

```csharp
ListUsageInput collect = new ListUsageInput();

string responseType = "json";
collect.ResponseType = responseType;

var productCode = (Models.ProductCodeEnum?)0;
collect.ProductCode = productCode;

string startDate = "2016-09-06";
collect.StartDate = startDate;

string endDate = "2016-09-06";
collect.EndDate = endDate;


string result = await usage.ListUsage(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="web_rtc_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.WebRTCController") WebRTCController

### Get singleton instance

The singleton instance of the ``` WebRTCController ``` class can be accessed from the API Client.

```csharp
WebRTCController webRTC = client.WebRTC;
```

### <a name="check_funds"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.WebRTCController.CheckFunds") CheckFunds

> TODO: Add a method description


```csharp
Task<string> CheckFunds(Models.CheckFundsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountSid |  ``` Required ```  | Your message360 Account SID |
| authToken |  ``` Required ```  | Your message360 Token |


#### Example Usage

```csharp
CheckFundsInput collect = new CheckFundsInput();

string accountSid = "account_sid";
collect.AccountSid = accountSid;

string authToken = "auth_token";
collect.AuthToken = authToken;


string result = await webRTC.CheckFunds(collect);

```


### <a name="create_token"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.WebRTCController.CreateToken") CreateToken

> message360 webrtc


```csharp
Task<string> CreateToken(Models.CreateTokenInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountSid |  ``` Required ```  | Your message360 Account SID |
| authToken |  ``` Required ```  | Your message360 Token |
| username |  ``` Required ```  | WebRTC username authentication |
| password |  ``` Required ```  | WebRTC password authentication |


#### Example Usage

```csharp
CreateTokenInput collect = new CreateTokenInput();

string accountSid = "account_sid";
collect.AccountSid = accountSid;

string authToken = "auth_token";
collect.AuthToken = authToken;

string username = "username";
collect.Username = username;

string password = "password";
collect.Password = password;


string result = await webRTC.CreateToken(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="recording_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.RecordingController") RecordingController

### Get singleton instance

The singleton instance of the ``` RecordingController ``` class can be accessed from the API Client.

```csharp
RecordingController recording = client.Recording;
```

### <a name="view_recording"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.RecordingController.ViewRecording") ViewRecording

> View a specific Recording


```csharp
Task<string> ViewRecording(Models.ViewRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Search Recording sid |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewRecordingInput collect = new ViewRecordingInput();

string recordingSid = "RecordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.ViewRecording(collect);

```


### <a name="delete_recording"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.RecordingController.DeleteRecording") DeleteRecording

> Delete Recording Record


```csharp
Task<string> DeleteRecording(Models.DeleteRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Unique Recording Sid to be delete |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
DeleteRecordingInput collect = new DeleteRecordingInput();

string recordingSid = "RecordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.DeleteRecording(collect);

```


### <a name="list_recording"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.RecordingController.ListRecording") ListRecording

> List out Recordings


```csharp
Task<string> ListRecording(Models.ListRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| dateCreated |  ``` Optional ```  | Recording date |
| callSid |  ``` Optional ```  | Call ID |


#### Example Usage

```csharp
ListRecordingInput collect = new ListRecordingInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;

string callSid = "CallSid";
collect.CallSid = callSid;


string result = await recording.ListRecording(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="email_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.EmailController") EmailController

### Get singleton instance

The singleton instance of the ``` EmailController ``` class can be accessed from the API Client.

```csharp
EmailController email = client.Email;
```

### <a name="delete_spam"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.DeleteSpam") DeleteSpam

> Deletes a email address marked as spam from the spam list


```csharp
Task<string> DeleteSpam(Models.DeleteSpamInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| email |  ``` Required ```  | Email address |


#### Example Usage

```csharp
DeleteSpamInput collect = new DeleteSpamInput();

string responseType = "json";
collect.ResponseType = responseType;

string email = "email";
collect.Email = email;


string result = await email.DeleteSpam(collect);

```


### <a name="delete_block"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.DeleteBlock") DeleteBlock

> Deletes a blocked email


```csharp
Task<string> DeleteBlock(Models.DeleteBlockInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | Email address to remove from block list |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
DeleteBlockInput collect = new DeleteBlockInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.DeleteBlock(collect);

```


### <a name="add_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.AddUnsubscribes") AddUnsubscribes

> Add an email to the unsubscribe list


```csharp
Task<string> AddUnsubscribes(Models.AddUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email to add to the unsubscribe list |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
AddUnsubscribesInput collect = new AddUnsubscribesInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.AddUnsubscribes(collect);

```


### <a name="send_email"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.SendEmail") SendEmail

> Send out an email


```csharp
Task<string> SendEmail(Models.SendEmailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | The to email address |
| mfrom |  ``` Required ```  | The from email address |
| type |  ``` Required ```  ``` DefaultValue ```  | email format type, html or text |
| subject |  ``` Required ```  | Email subject |
| message |  ``` Required ```  | The body of the email message |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| cc |  ``` Optional ```  | CC Email address |
| bcc |  ``` Optional ```  | BCC Email address |
| attachment |  ``` Optional ```  | File to be attached.File must be less than 7MB. |


#### Example Usage

```csharp
SendEmailInput collect = new SendEmailInput();

string to = "to";
collect.To = to;

string mfrom = "from";
collect.Mfrom = mfrom;

var type = Models.SendEmailAsEnumHelper.ParseString("HTML");
collect.Type = type;

string subject = "subject";
collect.Subject = subject;

string message = "message";
collect.Message = message;

string responseType = "json";
collect.ResponseType = responseType;

string cc = "cc";
collect.Cc = cc;

string bcc = "bcc";
collect.Bcc = bcc;

string attachment = "attachment";
collect.Attachment = attachment;


string result = await email.SendEmail(collect);

```


### <a name="delete_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.DeleteUnsubscribes") DeleteUnsubscribes

> Delete emails from the unsubscribe list


```csharp
Task<string> DeleteUnsubscribes(Models.DeleteUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email to remove from the unsubscribe list |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
DeleteUnsubscribesInput collect = new DeleteUnsubscribesInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.DeleteUnsubscribes(collect);

```


### <a name="list_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.ListUnsubscribes") ListUnsubscribes

> List all unsubscribed email addresses


```csharp
Task<string> ListUnsubscribes(Models.ListUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | Starting record of the list |
| limit |  ``` Optional ```  | Maximum number of records to be returned |


#### Example Usage

```csharp
ListUnsubscribesInput collect = new ListUnsubscribesInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.ListUnsubscribes(collect);

```


### <a name="list_invalid"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.ListInvalid") ListInvalid

> List out all invalid email addresses


```csharp
Task<string> ListInvalid(Models.ListInvalidInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offet |  ``` Optional ```  | Starting record for listing out emails |
| limit |  ``` Optional ```  | Maximum number of records to return |


#### Example Usage

```csharp
ListInvalidInput collect = new ListInvalidInput();

string responseType = "json";
collect.ResponseType = responseType;

string offet = "offet";
collect.Offet = offet;

string limit = "limit";
collect.Limit = limit;


string result = await email.ListInvalid(collect);

```


### <a name="delete_bounces"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.DeleteBounces") DeleteBounces

> Delete an email address from the bounced address list


```csharp
Task<string> DeleteBounces(Models.DeleteBouncesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| email |  ``` Required ```  | The email address to remove from the bounce list |


#### Example Usage

```csharp
DeleteBouncesInput collect = new DeleteBouncesInput();

string responseType = "json";
collect.ResponseType = responseType;

string email = "email";
collect.Email = email;


string result = await email.DeleteBounces(collect);

```


### <a name="list_bounces"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.ListBounces") ListBounces

> List out all email addresses that have bounced


```csharp
Task<string> ListBounces(Models.ListBouncesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The record to start the list at |
| limit |  ``` Optional ```  | The maximum number of records to return |


#### Example Usage

```csharp
ListBouncesInput collect = new ListBouncesInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.ListBounces(collect);

```


### <a name="list_spam"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.ListSpam") ListSpam

> List out all email addresses marked as spam


```csharp
Task<string> ListSpam(Models.ListSpamInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The record number to start the list at |
| limit |  ``` Optional ```  | Maximum number of records to return |


#### Example Usage

```csharp
ListSpamInput collect = new ListSpamInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.ListSpam(collect);

```


### <a name="list_blocks"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.ListBlocks") ListBlocks

> Outputs email addresses on your blocklist


```csharp
Task<string> ListBlocks(Models.ListBlocksInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | Where to start in the output list |
| limit |  ``` Optional ```  | Maximum number of records to return |


#### Example Usage

```csharp
ListBlocksInput collect = new ListBlocksInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.ListBlocks(collect);

```


### <a name="delete_invalid"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.DeleteInvalid") DeleteInvalid

> This endpoint allows you to delete entries in the Invalid Emails list.


```csharp
Task<string> DeleteInvalid(Models.DeleteInvalidInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | Email that was marked invalid |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Json or xml |


#### Example Usage

```csharp
DeleteInvalidInput collect = new DeleteInvalidInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.DeleteInvalid(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sms_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.SMSController") SMSController

### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
SMSController sMS = client.SMS;
```

### <a name="send_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.SendSMS") SendSMS

> Send an SMS from a message360 number


```csharp
Task<string> SendSMS(Models.SendSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | SMS enabled Message360 number to send this message from |
| to |  ``` Required ```  | Number to send the SMS to |
| body |  ``` Required ```  | Text Message To Send |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once SMS sent. |
| messagestatuscallback |  ``` Optional ```  | URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished. |
| smartsms |  ``` Optional ```  ``` DefaultValue ```  | Check's 'to' number can receive sms or not using Carrier API, if wireless = true then text sms is sent, else wireless = false then call is recieved to end user with audible message. |


#### Example Usage

```csharp
SendSMSInput collect = new SendSMSInput();

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string body = "body";
collect.Body = body;

string responseType = "json";
collect.ResponseType = responseType;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string messagestatuscallback = "messagestatuscallback";
collect.Messagestatuscallback = messagestatuscallback;

bool? smartsms = false;
collect.Smartsms = smartsms;


string result = await sMS.SendSMS(collect);

```


### <a name="view_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.ViewSMS") ViewSMS

> View a Particular SMS


```csharp
Task<string> ViewSMS(Models.ViewSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messagesid |  ``` Required ```  | Message sid |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewSMSInput collect = new ViewSMSInput();

string messagesid = "messagesid";
collect.Messagesid = messagesid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.ViewSMS(collect);

```


### <a name="list_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.ListSMS") ListSMS

> List All SMS


```csharp
Task<string> ListSMS(Models.ListSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Messages sent from this number |
| to |  ``` Optional ```  | Messages sent to this number |
| datesent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |


#### Example Usage

```csharp
ListSMSInput collect = new ListSMSInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string datesent = "datesent";
collect.Datesent = datesent;


string result = await sMS.ListSMS(collect);

```


### <a name="list_inbound_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.ListInboundSMS") ListInboundSMS

> List All Inbound SMS


```csharp
Task<string> ListInboundSMS(Models.ListInboundSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound SMS |
| to |  ``` Optional ```  | To Number to get Inbound SMS |
| dateSent |  ``` Optional ```  | Filter sms message objects by this date. |


#### Example Usage

```csharp
ListInboundSMSInput collect = new ListInboundSMSInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string dateSent = "DateSent";
collect.DateSent = dateSent;


string result = await sMS.ListInboundSMS(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="call_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.CallController") CallController

### Get singleton instance

The singleton instance of the ``` CallController ``` class can be accessed from the API Client.

```csharp
CallController call = client.Call;
```

### <a name="make_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.MakeCall") MakeCall

> You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json


```csharp
Task<string> MakeCall(Models.MakeCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
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
| ifMachineUrl |  ``` Optional ```  | URL requested when IfMachine=continue |
| ifMachineMethod |  ``` Optional ```  | Method used to request the IfMachineUrl. |
| feedback |  ``` Optional ```  | Specify if survey should be enable or not |
| surveyId |  ``` Optional ```  | The unique identifier for the survey. |


#### Example Usage

```csharp
MakeCallInput collect = new MakeCallInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

string responseType = "json";
collect.ResponseType = responseType;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statusCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

var fallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.FallBackMethod = fallBackMethod;

string heartBeatUrl = "HeartBeatUrl";
collect.HeartBeatUrl = heartBeatUrl;

var heartBeatMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.HeartBeatMethod = heartBeatMethod;

int? timeout = 138;
collect.Timeout = timeout;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

bool? hideCallerId = true;
collect.HideCallerId = hideCallerId;

bool? record = true;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

var recordCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.RecordCallBackMethod = recordCallBackMethod;

bool? transcribe = true;
collect.Transcribe = transcribe;

string transcribeCallBackUrl = "TranscribeCallBackUrl";
collect.TranscribeCallBackUrl = transcribeCallBackUrl;

var ifMachine = Models.IfMachineEnum?Helper.ParseString("CONTINUE");
collect.IfMachine = ifMachine;

string ifMachineUrl = "IfMachineUrl";
collect.IfMachineUrl = ifMachineUrl;

var ifMachineMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.IfMachineMethod = ifMachineMethod;

bool? feedback = true;
collect.Feedback = feedback;

string surveyId = "SurveyId";
collect.SurveyId = surveyId;


string result = await call.MakeCall(collect);

```


### <a name="play_audio"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.PlayAudio") PlayAudio

> Play Dtmf and send the Digit


```csharp
Task<string> PlayAudio(Models.PlayAudioInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| audioUrl |  ``` Required ```  | URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav |
| sayText |  ``` Required ```  | Valid alphanumeric string that should be played to the In-progress call. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| length |  ``` Optional ```  | Time limit in seconds for audio play back |
| direction |  ``` Optional ```  | The leg of the call audio will be played to |
| mix |  ``` Optional ```  | If false, all other audio will be muted |


#### Example Usage

```csharp
PlayAudioInput collect = new PlayAudioInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string audioUrl = "AudioUrl";
collect.AudioUrl = audioUrl;

string sayText = "SayText";
collect.SayText = sayText;

string responseType = "json";
collect.ResponseType = responseType;

int? length = 138;
collect.Length = length;

var direction = Models.DirectionEnum?Helper.ParseString("IN");
collect.Direction = direction;

bool? mix = true;
collect.Mix = mix;


string result = await call.PlayAudio(collect);

```


### <a name="record_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.RecordCall") RecordCall

> Record a Call


```csharp
Task<string> RecordCall(Models.RecordCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| record |  ``` Required ```  | Set true to initiate recording or false to terminate recording |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response format, xml or json |
| direction |  ``` Optional ```  | The leg of the call to record |
| timeLimit |  ``` Optional ```  | Time in seconds the recording duration should not exceed |
| callBackUrl |  ``` Optional ```  | URL consulted after the recording completes |
| fileformat |  ``` Optional ```  | Format of the recording file. Can be .mp3 or .wav |


#### Example Usage

```csharp
RecordCallInput collect = new RecordCallInput();

string callSid = "CallSid";
collect.CallSid = callSid;

bool record = true;
collect.Record = record;

string responseType = "json";
collect.ResponseType = responseType;

var direction = Models.DirectionEnum?Helper.ParseString("IN");
collect.Direction = direction;

int? timeLimit = 138;
collect.TimeLimit = timeLimit;

string callBackUrl = "CallBackUrl";
collect.CallBackUrl = callBackUrl;

var fileformat = Models.AudioFormatEnum?Helper.ParseString("mp3");
collect.Fileformat = fileformat;


string result = await call.RecordCall(collect);

```


### <a name="voice_effect"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.VoiceEffect") VoiceEffect

> Voice Effect


```csharp
Task<string> VoiceEffect(Models.VoiceEffectInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the in-progress voice call. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| audioDirection |  ``` Optional ```  | The direction the audio effect should be placed on. If IN, the effects will occur on the incoming audio stream. If OUT, the effects will occur on the outgoing audio stream. |
| pitchSemiTones |  ``` Optional ```  | value between -14 and 14 |
| pitchOctaves |  ``` Optional ```  | value between -1 and 1 |
| pitch |  ``` Optional ```  | value greater than 0 |
| rate |  ``` Optional ```  | value greater than 0 |
| tempo |  ``` Optional ```  | value greater than 0 |


#### Example Usage

```csharp
VoiceEffectInput collect = new VoiceEffectInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string responseType = "json";
collect.ResponseType = responseType;

var audioDirection = Models.AudioDirectionEnum?Helper.ParseString("IN");
collect.AudioDirection = audioDirection;

double? pitchSemiTones = 138.971774137566;
collect.PitchSemiTones = pitchSemiTones;

double? pitchOctaves = 138.971774137566;
collect.PitchOctaves = pitchOctaves;

double? pitch = 138.971774137566;
collect.Pitch = pitch;

double? rate = 138.971774137566;
collect.Rate = rate;

double? tempo = 138.971774137566;
collect.Tempo = tempo;


string result = await call.VoiceEffect(collect);

```


### <a name="send_digit"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.SendDigit") SendDigit

> Play Dtmf and send the Digit


```csharp
Task<string> SendDigit(Models.SendDigitInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| playDtmf |  ``` Required ```  | DTMF digits to play to the call. 0-9, #, *, W, or w |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| playDtmfDirection |  ``` Optional ```  | The leg of the call DTMF digits should be sent to |


#### Example Usage

```csharp
SendDigitInput collect = new SendDigitInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

string responseType = "json";
collect.ResponseType = responseType;

var playDtmfDirection = Models.DirectionEnum?Helper.ParseString("IN");
collect.PlayDtmfDirection = playDtmfDirection;


string result = await call.SendDigit(collect);

```


### <a name="interrupted_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.InterruptedCall") InterruptedCall

> Interrupt the Call by Call Sid


```csharp
Task<string> InterruptedCall(Models.InterruptedCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | Call SId |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| url |  ``` Optional ```  | URL the in-progress call will be redirected to |
| method |  ``` Optional ```  | The method used to request the above Url parameter |
| status |  ``` Optional ```  | Status to set the in-progress call to |


#### Example Usage

```csharp
InterruptedCallInput collect = new InterruptedCallInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string responseType = "json";
collect.ResponseType = responseType;

string url = "Url";
collect.Url = url;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

var status = Models.InterruptedCallStatusEnum?Helper.ParseString("CANCELED");
collect.Status = status;


string result = await call.InterruptedCall(collect);

```


### <a name="group_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.GroupCall") GroupCall

> Group Call


```csharp
Task<string> GroupCall(Models.GroupCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| to |  ``` Required ```  | Please enter multiple E164 number. You can add max 10 numbers. Add numbers separated with comma. e.g : 1111111111,2222222222 |
| url |  ``` Required ```  | URL requested once the call connects |
| responseType |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| groupConfirmKey |  ``` Required ```  | Define the DTMF that the called party should send to bridge the call. Allowed Values : 0-9, #, * |
| groupConfirmFile |  ``` Required ```  | Specify the audio file you want to play when the called party picks up the call |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
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


#### Example Usage

```csharp
GroupCallInput collect = new GroupCallInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

string responseType = "json";
collect.ResponseType = responseType;

string groupConfirmKey = "GroupConfirmKey";
collect.GroupConfirmKey = groupConfirmKey;

var groupConfirmFile = Models.AudioFormatEnumHelper.ParseString("mp3");
collect.GroupConfirmFile = groupConfirmFile;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statusCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

var fallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.FallBackMethod = fallBackMethod;

string heartBeatUrl = "HeartBeatUrl";
collect.HeartBeatUrl = heartBeatUrl;

var heartBeatMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.HeartBeatMethod = heartBeatMethod;

int? timeout = 230;
collect.Timeout = timeout;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

string hideCallerId = "HideCallerId";
collect.HideCallerId = hideCallerId;

bool? record = true;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

var recordCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.RecordCallBackMethod = recordCallBackMethod;

bool? transcribe = true;
collect.Transcribe = transcribe;

string transcribeCallBackUrl = "TranscribeCallBackUrl";
collect.TranscribeCallBackUrl = transcribeCallBackUrl;


string result = await call.GroupCall(collect);

```


### <a name="list_calls"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.ListCalls") ListCalls

> A list of calls associated with your Message360 account


```csharp
Task<string> ListCalls(Models.ListCallsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| to |  ``` Optional ```  | Only list calls to this number |
| mfrom |  ``` Optional ```  | Only list calls from this number |
| dateCreated |  ``` Optional ```  | Only list calls starting within the specified date range |


#### Example Usage

```csharp
ListCallsInput collect = new ListCallsInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string to = "To";
collect.To = to;

string mfrom = "From";
collect.Mfrom = mfrom;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;


string result = await call.ListCalls(collect);

```


### <a name="send_ringless_vm"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.SendRinglessVM") SendRinglessVM

> API endpoint used to send a Ringless Voicemail


```csharp
Task<string> SendRinglessVM(Models.SendRinglessVMInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| rVMCallerId |  ``` Required ```  | Alternate caller ID required for RVM |
| to |  ``` Required ```  | To number |
| voiceMailURL |  ``` Required ```  | URL to an audio file |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  ``` DefaultValue ```  | Not currently used in this version |
| statusCallBackUrl |  ``` Optional ```  | URL to post the status of the Ringless request |
| statsCallBackMethod |  ``` Optional ```  | POST or GET |


#### Example Usage

```csharp
SendRinglessVMInput collect = new SendRinglessVMInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string rVMCallerId = "RVMCallerId";
collect.RVMCallerId = rVMCallerId;

string to = "To";
collect.To = to;

string voiceMailURL = "VoiceMailURL";
collect.VoiceMailURL = voiceMailURL;

string responseType = "json";
collect.ResponseType = responseType;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statsCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.StatsCallBackMethod = statsCallBackMethod;


string result = await call.SendRinglessVM(collect);

```


### <a name="view_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.ViewCall") ViewCall

> View Call Response


```csharp
Task<string> ViewCall(Models.ViewCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callsid |  ``` Required ```  | Call Sid id for particular Call |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewCallInput collect = new ViewCallInput();

string callsid = "callsid";
collect.Callsid = callsid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.ViewCall(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="carrier_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.CarrierController") CarrierController

### Get singleton instance

The singleton instance of the ``` CarrierController ``` class can be accessed from the API Client.

```csharp
CarrierController carrier = client.Carrier;
```

### <a name="carrier_lookup_list"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CarrierController.CarrierLookupList") CarrierLookupList

> Get the All Purchase Number's Carrier lookup


```csharp
Task<string> CarrierLookupList(Models.CarrierLookupListInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Page Number |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Page Size |


#### Example Usage

```csharp
CarrierLookupListInput collect = new CarrierLookupListInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;


string result = await carrier.CarrierLookupList(collect);

```


### <a name="carrier_lookup"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CarrierController.CarrierLookup") CarrierLookup

> Get the Carrier Lookup


```csharp
Task<string> CarrierLookup(Models.CarrierLookupInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | The number to lookup |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CarrierLookupInput collect = new CarrierLookupInput();

string phonenumber = "phonenumber";
collect.Phonenumber = phonenumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await carrier.CarrierLookup(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="address_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.AddressController") AddressController

### Get singleton instance

The singleton instance of the ``` AddressController ``` class can be accessed from the API Client.

```csharp
AddressController address = client.Address;
```

### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.CreateAddress") CreateAddress

> To add an address to your address book, you create a new address object. You can retrieve and delete individual addresses as well as get a list of addresses. Addresses are identified by a unique random ID.


```csharp
Task<string> CreateAddress(Models.CreateAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | Name of user |
| address |  ``` Required ```  | Address of user. |
| country |  ``` Required ```  | Must be a 2 letter country short-name code (ISO 3166) |
| state |  ``` Required ```  | Must be a 2 letter State eg. CA for US. For Some Countries it can be greater than 2 letters. |
| city |  ``` Required ```  | City Name. |
| zip |  ``` Required ```  | Zip code of city. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type either json or xml |
| description |  ``` Optional ```  | Description of addresses. |
| email |  ``` Optional ```  | Email Id of user. |
| phone |  ``` Optional ```  | Phone number of user. |


#### Example Usage

```csharp
CreateAddressInput collect = new CreateAddressInput();

string name = "Name";
collect.Name = name;

string address = "Address";
collect.Address = address;

string country = "Country";
collect.Country = country;

string state = "State";
collect.State = state;

string city = "City";
collect.City = city;

string zip = "Zip";
collect.Zip = zip;

string responseType = "json";
collect.ResponseType = responseType;

string description = "Description";
collect.Description = description;

string email = "email";
collect.Email = email;

string phone = "Phone";
collect.Phone = phone;


string result = await address.CreateAddress(collect);

```


### <a name="view_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.ViewAddress") ViewAddress

> View Address Specific address Book by providing the address id


```csharp
Task<string> ViewAddress(Models.ViewAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressSID |  ``` Required ```  | The identifier of the address to be retrieved. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
ViewAddressInput collect = new ViewAddressInput();

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.ViewAddress(collect);

```


### <a name="list_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.ListAddress") ListAddress

> List All Address 


```csharp
Task<string> ListAddress(Models.ListAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| page |  ``` Optional ```  ``` DefaultValue ```  | Return requested # of items starting the value, default=0, must be an integer |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | How many results to return, default is 10, max is 100, must be an integer |
| addressSID |  ``` Optional ```  | addresses Sid |
| dateCreated |  ``` Optional ```  | date created address. |


#### Example Usage

```csharp
ListAddressInput collect = new ListAddressInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;


string result = await address.ListAddress(collect);

```


### <a name="verify_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.VerifyAddress") VerifyAddress

> Validates an address given.


```csharp
Task<string> VerifyAddress(Models.VerifyAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressSID |  ``` Required ```  | The identifier of the address to be verified. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
VerifyAddressInput collect = new VerifyAddressInput();

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.VerifyAddress(collect);

```


### <a name="delete_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.DeleteAddress") DeleteAddress

> To delete Address to your address book


```csharp
Task<string> DeleteAddress(Models.DeleteAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressSID |  ``` Required ```  | The identifier of the address to be deleted. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
DeleteAddressInput collect = new DeleteAddressInput();

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.DeleteAddress(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sub_account_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.SubAccountController") SubAccountController

### Get singleton instance

The singleton instance of the ``` SubAccountController ``` class can be accessed from the API Client.

```csharp
SubAccountController subAccount = client.SubAccount;
```

### <a name="delete_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SubAccountController.DeleteSubAccount") DeleteSubAccount

> Delete sub account or merge numbers into parent


```csharp
Task<string> DeleteSubAccount(Models.DeleteSubAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be deleted |
| mergeNumber |  ``` Required ```  ``` DefaultValue ```  | 0 to delete or 1 to merge numbers to parent account. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
DeleteSubAccountInput collect = new DeleteSubAccountInput();

string subAccountSID = "SubAccountSID";
collect.SubAccountSID = subAccountSID;

var mergeNumber = (Models.MergeNumberStatusEnum)0;
collect.MergeNumber = mergeNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await subAccount.DeleteSubAccount(collect);

```


### <a name="suspend_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SubAccountController.SuspendSubAccount") SuspendSubAccount

> Suspend or unsuspend


```csharp
Task<string> SuspendSubAccount(Models.SuspendSubAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be activated or suspended |
| activate |  ``` Required ```  ``` DefaultValue ```  | 0 to suspend or 1 to activate |
| responseType |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
SuspendSubAccountInput collect = new SuspendSubAccountInput();

string subAccountSID = "SubAccountSID";
collect.SubAccountSID = subAccountSID;

var activate = (Models.ActivateStatusEnum)0;
collect.Activate = activate;

string responseType = "json";
collect.ResponseType = responseType;


string result = await subAccount.SuspendSubAccount(collect);

```


### <a name="create_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SubAccountController.CreateSubAccount") CreateSubAccount

> Create a sub user account under the parent account


```csharp
Task<string> CreateSubAccount(Models.CreateSubAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| firstName |  ``` Required ```  | Sub account user first name |
| lastName |  ``` Required ```  | sub account user last name |
| email |  ``` Required ```  | Sub account email address |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateSubAccountInput collect = new CreateSubAccountInput();

string firstName = "FirstName";
collect.FirstName = firstName;

string lastName = "LastName";
collect.LastName = lastName;

string email = "Email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await subAccount.CreateSubAccount(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="account_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.AccountController") AccountController

### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

### <a name="view_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AccountController.ViewAccount") ViewAccount

> Display Account Description


```csharp
Task<string> ViewAccount(Models.ViewAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewAccountInput collect = new ViewAccountInput();

string date = "Date";
collect.Date = date;

string responseType = "json";
collect.ResponseType = responseType;


string result = await account.ViewAccount(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.ShortCodeController") ShortCodeController

### Get singleton instance

The singleton instance of the ``` ShortCodeController ``` class can be accessed from the API Client.

```csharp
ShortCodeController shortCode = client.ShortCode;
```

### <a name="send_dedicated_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.SendDedicatedShortcode") SendDedicatedShortcode

> TODO: Add a method description


```csharp
Task<string> SendDedicatedShortcode(Models.SendDedicatedShortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | Your dedicated shortcode |
| to |  ``` Required ```  | The number to send your SMS to |
| body |  ``` Required ```  | The body of your message |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  | Callback status method, POST or GET |
| messagestatuscallback |  ``` Optional ```  | Callback url for SMS status |


#### Example Usage

```csharp
SendDedicatedShortcodeInput collect = new SendDedicatedShortcodeInput();

int shortcode = 230;
collect.Shortcode = shortcode;

double to = 230.467056029228;
collect.To = to;

string body = "body";
collect.Body = body;

string responseType = "json";
collect.ResponseType = responseType;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string messagestatuscallback = "messagestatuscallback";
collect.Messagestatuscallback = messagestatuscallback;


string result = await shortCode.SendDedicatedShortcode(collect);

```


### <a name="view_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.ViewShortcode") ViewShortcode

> View a single Sms Short Code message.


```csharp
Task<string> ViewShortcode(Models.ViewShortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for the sms resource |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewShortcodeInput collect = new ViewShortcodeInput();

string messageSid = "MessageSid";
collect.MessageSid = messageSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.ViewShortcode(collect);

```


### <a name="list_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.ListShortcode") ListShortcode

> Retrieve a list of Short Code message objects.


```csharp
Task<string> ListShortcode(Models.ListShortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| shortcode |  ``` Optional ```  | Only list messages sent from this Short Code |
| to |  ``` Optional ```  | Only list messages sent to this number |
| dateSent |  ``` Optional ```  | Only list messages sent with the specified date |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |


#### Example Usage

```csharp
ListShortcodeInput collect = new ListShortcodeInput();

string responseType = "json";
collect.ResponseType = responseType;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string to = "To";
collect.To = to;

DateTime? dateSent = DateTime.Now();
collect.DateSent = dateSent;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;


string result = await shortCode.ListShortcode(collect);

```


### <a name="list_inbound_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.ListInboundShortcode") ListInboundShortcode

> Retrive a list of inbound Sms Short Code messages associated with your message360 account.


```csharp
Task<string> ListInboundShortcode(Models.ListInboundShortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Only list SMS messages sent from this number |
| shortcode |  ``` Optional ```  | Only list SMS messages sent to Shortcode |
| dateReceived |  ``` Optional ```  | Only list SMS messages sent in the specified date MAKE REQUEST |


#### Example Usage

```csharp
ListInboundShortcodeInput collect = new ListInboundShortcodeInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string mfrom = "From";
collect.Mfrom = mfrom;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string dateReceived = "DateReceived";
collect.DateReceived = dateReceived;


string result = await shortCode.ListInboundShortcode(collect);

```


[Back to List of Controllers](#list_of_controllers)



