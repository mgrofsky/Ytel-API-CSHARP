# Getting started

Ytel API version 3

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (Ytel.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Ytel library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

### 3. Add reference of the library project

In order to use the Ytel library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Ytel.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```Ytel.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Ytel-CSharp&workspaceName=Ytel&projectName=Ytel.PCL)

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

YtelClient client = new YtelClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [WebRTCController](#web_rtc_controller)
* [SharedShortCodeController](#shared_short_code_controller)
* [ConferenceController](#conference_controller)
* [PhoneNumberController](#phone_number_controller)
* [TranscriptionController](#transcription_controller)
* [RecordingController](#recording_controller)
* [EmailController](#email_controller)
* [SMSController](#sms_controller)
* [CallController](#call_controller)
* [CarrierController](#carrier_controller)
* [AddressController](#address_controller)
* [SubAccountController](#sub_account_controller)
* [AccountController](#account_controller)
* [UsageController](#usage_controller)
* [ShortCodeController](#short_code_controller)
* [PostCardController](#post_card_controller)
* [LetterController](#letter_controller)
* [AreaMailController](#area_mail_controller)

## <a name="web_rtc_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.WebRTCController") WebRTCController

### Get singleton instance

The singleton instance of the ``` WebRTCController ``` class can be accessed from the API Client.

```csharp
WebRTCController webRTC = client.WebRTC;
```

### <a name="create_token"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.WebRTCController.CreateToken") CreateToken

> Ytel webrtc


```csharp
Task<string> CreateToken(Models.CreateTokenInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountSid |  ``` Required ```  | Your Ytel Account SID |
| authToken |  ``` Required ```  | Your Ytel Token |
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


### <a name="check_funds"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.WebRTCController.CheckFunds") CheckFunds

> TODO: Add a method description


```csharp
Task<string> CheckFunds(Models.CheckFundsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountSid |  ``` Required ```  | Your Ytel Account SID |
| authToken |  ``` Required ```  | Your Ytel Token |


#### Example Usage

```csharp
CheckFundsInput collect = new CheckFundsInput();

string accountSid = "account_sid";
collect.AccountSid = accountSid;

string authToken = "auth_token";
collect.AuthToken = authToken;


string result = await webRTC.CheckFunds(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="shared_short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.SharedShortCodeController") SharedShortCodeController

### Get singleton instance

The singleton instance of the ``` SharedShortCodeController ``` class can be accessed from the API Client.

```csharp
SharedShortCodeController sharedShortCode = client.SharedShortCode;
```

### <a name="view_template"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ViewTemplate") ViewTemplate

> View a Shared ShortCode Template


```csharp
Task<string> ViewTemplate(Models.ViewTemplateInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| templateId |  ``` Required ```  | The unique identifier for a template object |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewTemplateInput collect = new ViewTemplateInput();

Guid templateId = Guid.NewGuid();
collect.TemplateId = templateId;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sharedShortCode.ViewTemplate(collect);

```


### <a name="view_shared_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ViewSharedShortcodes") ViewSharedShortcodes

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


### <a name="list_outbound_shared_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ListOutboundSharedShortcodes") ListOutboundSharedShortcodes

> List ShortCode Messages


```csharp
Task<string> ListOutboundSharedShortcodes(Models.ListOutboundSharedShortcodesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| shortcode |  ``` Optional ```  | Only list messages sent from this Short Code |
| to |  ``` Optional ```  | Only list messages sent to this number |
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

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string to = "to";
collect.To = to;

string datesent = "datesent";
collect.Datesent = datesent;


string result = await sharedShortCode.ListOutboundSharedShortcodes(collect);

```


### <a name="list_inbound_shared_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ListInboundSharedShortcodes") ListInboundSharedShortcodes

> List All Inbound ShortCode


```csharp
Task<string> ListInboundSharedShortcodes(Models.ListInboundSharedShortcodesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound ShortCode |
| shortcode |  ``` Optional ```  | Only list messages sent to this Short Code |
| datecreated |  ``` Optional ```  | Only list messages sent with the specified date |


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

string datecreated = "Datecreated";
collect.Datecreated = datecreated;


string result = await sharedShortCode.ListInboundSharedShortcodes(collect);

```


### <a name="send_shared_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.SendSharedShortcode") SendSharedShortcode

> Send an SMS from a Ytel ShortCode


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


### <a name="list_templates"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ListTemplates") ListTemplates

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


### <a name="view_keyword"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ViewKeyword") ViewKeyword

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


### <a name="list_keyword"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ListKeyword") ListKeyword

> Retrieve a list of keywords associated with your Ytel account.


```csharp
Task<string> ListKeyword(Models.ListKeywordInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| keyword |  ``` Optional ```  | Only list keywords of keyword |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
ListKeywordInput collect = new ListKeywordInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string keyword = "Keyword";
collect.Keyword = keyword;

int? shortcode = 101;
collect.Shortcode = shortcode;


string result = await sharedShortCode.ListKeyword(collect);

```


### <a name="view_assignement"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ViewAssignement") ViewAssignement

> The response returned here contains all resource properties associated with the given Shortcode.


```csharp
Task<string> ViewAssignement(Models.ViewAssignementInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Shortcode to your Ytel account |
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


### <a name="list_assignment"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.ListAssignment") ListAssignment

> Retrieve a list of shortcode assignment associated with your Ytel account.


```csharp
Task<string> ListAssignment(Models.ListAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
ListAssignmentInput collect = new ListAssignmentInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;


string result = await sharedShortCode.ListAssignment(collect);

```


### <a name="update_assignment"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SharedShortCodeController.UpdateAssignment") UpdateAssignment

> TODO: Add a method description


```csharp
Task<string> UpdateAssignment(Models.UpdateAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid shortcode to your Ytel account |
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

## <a name="conference_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.ConferenceController") ConferenceController

### Get singleton instance

The singleton instance of the ``` ConferenceController ``` class can be accessed from the API Client.

```csharp
ConferenceController conference = client.Conference;
```

### <a name="deaf_mute_participant"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.DeafMuteParticipant") DeafMuteParticipant

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


### <a name="view_participant"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.ViewParticipant") ViewParticipant

> Retrieve information about a participant by its ParticipantSid.


```csharp
Task<string> ViewParticipant(Models.ViewParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |
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


### <a name="view_conference"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.ViewConference") ViewConference

> Retrieve information about a conference by its ConferenceSid.


```csharp
Task<string> ViewConference(Models.ViewConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier of each conference resource |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewConferenceInput collect = new ViewConferenceInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.ViewConference(collect);

```


### <a name="add_participant"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.AddParticipant") AddParticipant

> Add Participant in conference 


```csharp
Task<string> AddParticipant(Models.AddParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantNumber |  ``` Required ```  | The phone number of the participant to be added. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| muted |  ``` Optional ```  | Specifies if participant should be muted. |
| deaf |  ``` Optional ```  | Specifies if the participant should hear audio in the conference. |


#### Example Usage

```csharp
AddParticipantInput collect = new AddParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantNumber = "ParticipantNumber";
collect.ParticipantNumber = participantNumber;

string responseType = "json";
collect.ResponseType = responseType;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.AddParticipant(collect);

```


### <a name="create_conference"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.CreateConference") CreateConference

> Here you can experiment with initiating a conference call through Ytel and view the request response generated when doing so.


```csharp
Task<string> CreateConference(Models.CreateConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid 10-digit number (E.164 format) that will be initiating the conference call. |
| to |  ``` Required ```  | A valid 10-digit number (E.164 format) that is to receive the conference call. |
| url |  ``` Required ```  | URL requested once the conference connects |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the conference is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallbackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| record |  ``` Optional ```  | Specifies if the conference should be recorded. |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion. |
| recordCallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once conference connects. |
| scheduleTime |  ``` Optional ```  | Schedule conference in future. Schedule time must be greater than current time |
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

string responseType = "json";
collect.ResponseType = responseType;

var method = Models.HttpActionEnum?Helper.ParseString("POST");
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statusCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.StatusCallBackMethod = statusCallBackMethod;

string fallbackUrl = "FallbackUrl";
collect.FallbackUrl = fallbackUrl;

var fallbackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.FallbackMethod = fallbackMethod;

bool? record = false;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

var recordCallBackMethod = Models.HttpActionEnum?Helper.ParseString("GET");
collect.RecordCallBackMethod = recordCallBackMethod;

string scheduleTime = "ScheduleTime";
collect.ScheduleTime = scheduleTime;

int? timeout = 101;
collect.Timeout = timeout;


string result = await conference.CreateConference(collect);

```


### <a name="hangup_participant"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.HangupParticipant") HangupParticipant

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


### <a name="play_conference_audio"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.PlayConferenceAudio") PlayConferenceAudio

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


### <a name="list_participant"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.ListParticipant") ListParticipant

> Retrieve a list of participants for an in-progress conference.


```csharp
Task<string> ListParticipant(Models.ListParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response format, xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| muted |  ``` Optional ```  | Specifies if participant should be muted. |
| deaf |  ``` Optional ```  | Specifies if the participant should hear audio in the conference. |


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

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.ListParticipant(collect);

```


### <a name="list_conference"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ConferenceController.ListConference") ListConference

> Retrieve a list of conference objects.


```csharp
Task<string> ListConference(Models.ListConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| friendlyName |  ``` Optional ```  | Only return conferences with the specified FriendlyName |
| dateCreated |  ``` Optional ```  | Conference created date |


#### Example Usage

```csharp
ListConferenceInput collect = new ListConferenceInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;


string result = await conference.ListConference(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="phone_number_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.PhoneNumberController") PhoneNumberController

### Get singleton instance

The singleton instance of the ``` PhoneNumberController ``` class can be accessed from the API Client.

```csharp
PhoneNumberController phoneNumber = client.PhoneNumber;
```

### <a name="available_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.AvailablePhoneNumber") AvailablePhoneNumber

> Retrieve a list of available phone numbers that can be purchased and used for your Ytel account.


```csharp
Task<string> AvailablePhoneNumber(Models.AvailablePhoneNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numbertype |  ``` Required ```  | Number type either SMS,Voice or all |
| areacode |  ``` Required ```  | Specifies the area code for the returned list of available numbers. Only available for North American numbers. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return. |


#### Example Usage

```csharp
AvailablePhoneNumberInput collect = new AvailablePhoneNumberInput();

var numbertype = Models.NumberTypeEnumHelper.ParseString("ALL");
collect.Numbertype = numbertype;

string areacode = "areacode";
collect.Areacode = areacode;

string responseType = "json";
collect.ResponseType = responseType;

int? pagesize = 10;
collect.Pagesize = pagesize;


string result = await phoneNumber.AvailablePhoneNumber(collect);

```


### <a name="mass_release_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.MassReleaseNumber") MassReleaseNumber

> Remove a purchased Ytel number from your account.


```csharp
Task<string> MassReleaseNumber(Models.MassReleaseNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel comma separated numbers (E.164 format). |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
MassReleaseNumberInput collect = new MassReleaseNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.MassReleaseNumber(collect);

```


### <a name="view_number_details"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.ViewNumberDetails") ViewNumberDetails

> Retrieve the details for a phone number by its number.


```csharp
Task<string> ViewNumberDetails(Models.ViewNumberDetailsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel 10-digit phone number (E.164 format). |
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


### <a name="release_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.ReleaseNumber") ReleaseNumber

> Remove a purchased Ytel number from your account.


```csharp
Task<string> ReleaseNumber(Models.ReleaseNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |
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


### <a name="buy_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.BuyNumber") BuyNumber

> Purchase a phone number to be used with your Ytel account


```csharp
Task<string> BuyNumber(Models.BuyNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |
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


### <a name="update_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.UpdatePhoneNumber") UpdatePhoneNumber

> Update properties for a Ytel number that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.


```csharp
Task<string> UpdatePhoneNumber(Models.UpdatePhoneNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel number (E.164 format). |
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
| smsFallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML from an SMS or at initial request of the SmsUrl. |
| smsFallbackMethod |  ``` Optional ```  | The HTTP method Ytel will use when URL requested if the SmsUrl is not available. |


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


### <a name="transfer_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.TransferNumber") TransferNumber

> Transfer phone number that has been purchased for from one account to another account.


```csharp
Task<string> TransferNumber(Models.TransferNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |
| fromaccountsid |  ``` Required ```  | A specific Accountsid from where Number is getting transfer. |
| toaccountsid |  ``` Required ```  | A specific Accountsid to which Number is getting transfer. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
TransferNumberInput collect = new TransferNumberInput();

string phonenumber = "phonenumber";
collect.Phonenumber = phonenumber;

string fromaccountsid = "fromaccountsid";
collect.Fromaccountsid = fromaccountsid;

string toaccountsid = "toaccountsid";
collect.Toaccountsid = toaccountsid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.TransferNumber(collect);

```


### <a name="list_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.ListNumber") ListNumber

> Retrieve a list of purchased phones numbers associated with your Ytel account.


```csharp
Task<string> ListNumber(Models.ListNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| numberType |  ``` Optional ```  | The capability supported by the number.Number type either SMS,Voice or all |
| friendlyName |  ``` Optional ```  | A human-readable label added to the number object. |


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


### <a name="mass_update_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.MassUpdateNumber") MassUpdateNumber

> Update properties for a Ytel numbers that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.


```csharp
Task<string> MassUpdateNumber(Models.MassUpdateNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid comma(,) separated Ytel numbers. (E.164 format). |
| voiceUrl |  ``` Required ```  | The URL returning InboundXML incoming calls should execute when connected. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| friendlyName |  ``` Optional ```  | A human-readable value for labeling the number. |
| voiceMethod |  ``` Optional ```  | Specifies the HTTP method used to request the VoiceUrl once incoming call connects. |
| voiceFallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML on a call or at initial request of the voice url |
| voiceFallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the VoiceFallbackUrl once incoming call connects. |
| hangupCallback |  ``` Optional ```  | URL that can be requested to receive notification when and how incoming call has ended. |
| hangupCallbackMethod |  ``` Optional ```  | The HTTP method Ytel will use when requesting the HangupCallback URL. |
| heartbeatUrl |  ``` Optional ```  | URL that can be used to monitor the phone number. |
| heartbeatMethod |  ``` Optional ```  | The HTTP method Ytel will use when requesting the HeartbeatUrl. |
| smsUrl |  ``` Optional ```  | URL requested when an SMS is received. |
| smsMethod |  ``` Optional ```  | The HTTP method Ytel will use when requesting the SmsUrl. |
| smsFallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML from an SMS or at initial request of the SmsUrl. |
| smsFallbackMethod |  ``` Optional ```  | The HTTP method Ytel will use when URL requested if the SmsUrl is not available. |


#### Example Usage

```csharp
MassUpdateNumberInput collect = new MassUpdateNumberInput();

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


string result = await phoneNumber.MassUpdateNumber(collect);

```


### <a name="get_did_score_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.GetDIDScoreNumber") GetDIDScoreNumber

> Get DID Score Number


```csharp
Task<string> GetDIDScoreNumber(Models.GetDIDScoreNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | Specifies the multiple phone numbers for check updated spamscore . |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
GetDIDScoreNumberInput collect = new GetDIDScoreNumberInput();

string phonenumber = "Phonenumber";
collect.Phonenumber = phonenumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.GetDIDScoreNumber(collect);

```


### <a name="bulk_buy_number"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PhoneNumberController.BulkBuyNumber") BulkBuyNumber

> Purchase a selected number of DID's from specific area codes to be used with your Ytel account.


```csharp
Task<string> BulkBuyNumber(Models.BulkBuyNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numberType |  ``` Required ```  | The capability the number supports. |
| areaCode |  ``` Required ```  | Specifies the area code for the returned list of available numbers. Only available for North American numbers. |
| quantity |  ``` Required ```  | A positive integer that tells how many number you want to buy at a time. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| leftover |  ``` Optional ```  | If desired quantity is unavailable purchase what is available . |


#### Example Usage

```csharp
BulkBuyNumberInput collect = new BulkBuyNumberInput();

var numberType = Models.NumberTypeEnumHelper.ParseString("ALL");
collect.NumberType = numberType;

string areaCode = "AreaCode";
collect.AreaCode = areaCode;

string quantity = "Quantity";
collect.Quantity = quantity;

string responseType = "json";
collect.ResponseType = responseType;

string leftover = "Leftover";
collect.Leftover = leftover;


string result = await phoneNumber.BulkBuyNumber(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="transcription_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.TranscriptionController") TranscriptionController

### Get singleton instance

The singleton instance of the ``` TranscriptionController ``` class can be accessed from the API Client.

```csharp
TranscriptionController transcription = client.Transcription;
```

### <a name="view_transcription"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.TranscriptionController.ViewTranscription") ViewTranscription

> Retrieve information about a transaction by its TranscriptionSid.


```csharp
Task<string> ViewTranscription(Models.ViewTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transcriptionsid |  ``` Required ```  | The unique identifier for a transcription object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewTranscriptionInput collect = new ViewTranscriptionInput();

string transcriptionsid = "transcriptionsid";
collect.Transcriptionsid = transcriptionsid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.ViewTranscription(collect);

```


### <a name="recording_transcription"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.TranscriptionController.RecordingTranscription") RecordingTranscription

> Transcribe a message360 recording by its RecordingSid.


```csharp
Task<string> RecordingTranscription(Models.RecordingTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | The unique identifier for a recording object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
RecordingTranscriptionInput collect = new RecordingTranscriptionInput();

string recordingSid = "recordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.RecordingTranscription(collect);

```


### <a name="audio_url_transcription"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.TranscriptionController.AudioURLTranscription") AudioURLTranscription

> Transcribe an audio recording from a file.


```csharp
Task<string> AudioURLTranscription(Models.AudioURLTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| audiourl |  ``` Required ```  | URL pointing to the location of the audio file that is to be transcribed. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
AudioURLTranscriptionInput collect = new AudioURLTranscriptionInput();

string audiourl = "audiourl";
collect.Audiourl = audiourl;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.AudioURLTranscription(collect);

```


### <a name="list_transcription"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.TranscriptionController.ListTranscription") ListTranscription

> Retrieve a list of transcription objects for your Ytel account.


```csharp
Task<string> ListTranscription(Models.ListTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| status |  ``` Optional ```  | The state of the transcription. |
| dateTranscribed |  ``` Optional ```  | The date the transcription took place. |


#### Example Usage

```csharp
ListTranscriptionInput collect = new ListTranscriptionInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

var status = Models.StatusEnum?Helper.ParseString("INPROGRESS");
collect.Status = status;

string dateTranscribed = "dateTranscribed";
collect.DateTranscribed = dateTranscribed;


string result = await transcription.ListTranscription(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="recording_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.RecordingController") RecordingController

### Get singleton instance

The singleton instance of the ``` RecordingController ``` class can be accessed from the API Client.

```csharp
RecordingController recording = client.Recording;
```

### <a name="view_recording"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.RecordingController.ViewRecording") ViewRecording

> Retrieve the recording of a call by its RecordingSid. This resource will return information regarding the call such as start time, end time, duration, and so forth.


```csharp
Task<string> ViewRecording(Models.ViewRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingsid |  ``` Required ```  | The unique identifier for the recording. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewRecordingInput collect = new ViewRecordingInput();

string recordingsid = "recordingsid";
collect.Recordingsid = recordingsid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.ViewRecording(collect);

```


### <a name="delete_recording"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.RecordingController.DeleteRecording") DeleteRecording

> Remove a recording from your Ytel account.


```csharp
Task<string> DeleteRecording(Models.DeleteRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingsid |  ``` Required ```  | The unique identifier for a recording. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
DeleteRecordingInput collect = new DeleteRecordingInput();

string recordingsid = "recordingsid";
collect.Recordingsid = recordingsid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.DeleteRecording(collect);

```


### <a name="list_recording"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.RecordingController.ListRecording") ListRecording

> Retrieve a list of recording objects.


```csharp
Task<string> ListRecording(Models.ListRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| datecreated |  ``` Optional ```  | Filter results by creation date |
| callsid |  ``` Optional ```  | The unique identifier for a call. |


#### Example Usage

```csharp
ListRecordingInput collect = new ListRecordingInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string datecreated = "Datecreated";
collect.Datecreated = datecreated;

string callsid = "callsid";
collect.Callsid = callsid;


string result = await recording.ListRecording(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="email_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.EmailController") EmailController

### Get singleton instance

The singleton instance of the ``` EmailController ``` class can be accessed from the API Client.

```csharp
EmailController email = client.Email;
```

### <a name="delete_spam"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.DeleteSpam") DeleteSpam

> Remove an email from the spam email list.


```csharp
Task<string> DeleteSpam(Models.DeleteSpamInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| email |  ``` Required ```  | A valid email address that is to be remove from the spam list. |


#### Example Usage

```csharp
DeleteSpamInput collect = new DeleteSpamInput();

string responseType = "json";
collect.ResponseType = responseType;

string email = "Email";
collect.Email = email;


string result = await email.DeleteSpam(collect);

```


### <a name="delete_block"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.DeleteBlock") DeleteBlock

> Remove an email from blocked emails list.


```csharp
Task<string> DeleteBlock(Models.DeleteBlockInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address to be remove from the blocked list. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
DeleteBlockInput collect = new DeleteBlockInput();

string email = "Email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.DeleteBlock(collect);

```


### <a name="add_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.AddUnsubscribes") AddUnsubscribes

> Add an email to the unsubscribe list


```csharp
Task<string> AddUnsubscribes(Models.AddUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be added to the unsubscribe list |
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


### <a name="send_email"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.SendEmail") SendEmail

> Create and submit an email message to one or more email addresses.


```csharp
Task<string> SendEmail(Models.SendEmailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| type |  ``` Required ```  ``` DefaultValue ```  | Specifies the type of email to be sent |
| subject |  ``` Required ```  | The subject of the mail. Must be a valid string. |
| message |  ``` Required ```  | The email message that is to be sent in the text. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| mfrom |  ``` Optional ```  | A valid address that will send the email. |
| cc |  ``` Optional ```  | Carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| bcc |  ``` Optional ```  | Blind carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| attachment |  ``` Optional ```  | A file that is attached to the email. Must be less than 7 MB in size. |


#### Example Usage

```csharp
SendEmailInput collect = new SendEmailInput();

string to = "To";
collect.To = to;

var type = Models.SendEmailAsEnumHelper.ParseString("HTML");
collect.Type = type;

string subject = "Subject";
collect.Subject = subject;

string message = "Message";
collect.Message = message;

string responseType = "json";
collect.ResponseType = responseType;

string mfrom = "From";
collect.Mfrom = mfrom;

string cc = "Cc";
collect.Cc = cc;

string bcc = "Bcc";
collect.Bcc = bcc;

string attachment = "Attachment";
collect.Attachment = attachment;


string result = await email.SendEmail(collect);

```


### <a name="delete_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.DeleteUnsubscribes") DeleteUnsubscribes

> Remove an email address from the list of unsubscribed emails.


```csharp
Task<string> DeleteUnsubscribes(Models.DeleteUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the unsubscribe list. |
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


### <a name="list_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.ListUnsubscribes") ListUnsubscribes

> Retrieve a list of email addresses from the unsubscribe list.


```csharp
Task<string> ListUnsubscribes(Models.ListUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The starting point of the list of unsubscribed emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
ListUnsubscribesInput collect = new ListUnsubscribesInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.ListUnsubscribes(collect);

```


### <a name="list_invalid"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.ListInvalid") ListInvalid

> Retrieve a list of invalid email addresses.


```csharp
Task<string> ListInvalid(Models.ListInvalidInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The starting point of the list of invalid emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
ListInvalidInput collect = new ListInvalidInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.ListInvalid(collect);

```


### <a name="delete_bounces"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.DeleteBounces") DeleteBounces

> Remove an email address from the bounced list.


```csharp
Task<string> DeleteBounces(Models.DeleteBouncesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| email |  ``` Required ```  | The email address to be remove from the bounced email list. |


#### Example Usage

```csharp
DeleteBouncesInput collect = new DeleteBouncesInput();

string responseType = "json";
collect.ResponseType = responseType;

string email = "Email";
collect.Email = email;


string result = await email.DeleteBounces(collect);

```


### <a name="list_bounces"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.ListBounces") ListBounces

> Retrieve a list of emails that have bounced.


```csharp
Task<string> ListBounces(Models.ListBouncesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The starting point of the list of bounced emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
ListBouncesInput collect = new ListBouncesInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.ListBounces(collect);

```


### <a name="list_spam"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.ListSpam") ListSpam

> Retrieve a list of emails that are on the spam list.


```csharp
Task<string> ListSpam(Models.ListSpamInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The starting point of the list of spam emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
ListSpamInput collect = new ListSpamInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.ListSpam(collect);

```


### <a name="list_blocks"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.ListBlocks") ListBlocks

> Retrieve a list of emails that have been blocked.


```csharp
Task<string> ListBlocks(Models.ListBlocksInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The starting point of the list of blocked emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
ListBlocksInput collect = new ListBlocksInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.ListBlocks(collect);

```


### <a name="delete_invalid"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.EmailController.DeleteInvalid") DeleteInvalid

> Remove an email from the invalid email list.


```csharp
Task<string> DeleteInvalid(Models.DeleteInvalidInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the invalid email list. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
DeleteInvalidInput collect = new DeleteInvalidInput();

string email = "Email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.DeleteInvalid(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sms_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.SMSController") SMSController

### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
SMSController sMS = client.SMS;
```

### <a name="send_sms"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SMSController.SendSMS") SendSMS

> Send an SMS from a Ytel number


```csharp
Task<string> SendSMS(Models.SendSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | The 10-digit SMS-enabled Ytel number (E.164 format) in which the message is sent. |
| to |  ``` Required ```  | The 10-digit phone number (E.164 format) that will receive the message. |
| body |  ``` Required ```  | The body message that is to be sent in the text. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once SMS sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished. |
| smartsms |  ``` Optional ```  ``` DefaultValue ```  | Check's 'to' number can receive sms or not using Carrier API, if wireless = true then text sms is sent, else wireless = false then call is recieved to end user with audible message. |
| deliveryStatus |  ``` Optional ```  ``` DefaultValue ```  | Delivery reports are a method to tell your system if the message has arrived on the destination phone. |


#### Example Usage

```csharp
SendSMSInput collect = new SendSMSInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string body = "Body";
collect.Body = body;

string responseType = "json";
collect.ResponseType = responseType;

var method = Models.HttpActionEnum?Helper.ParseString("GET");
collect.Method = method;

string messageStatusCallback = "MessageStatusCallback";
collect.MessageStatusCallback = messageStatusCallback;

bool? smartsms = false;
collect.Smartsms = smartsms;

bool? deliveryStatus = false;
collect.DeliveryStatus = deliveryStatus;


string result = await sMS.SendSMS(collect);

```


### <a name="view_sms"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SMSController.ViewSMS") ViewSMS

> Retrieve a single SMS message object by its SmsSid.


```csharp
Task<string> ViewSMS(Models.ViewSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for a sms message. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewSMSInput collect = new ViewSMSInput();

string messageSid = "MessageSid";
collect.MessageSid = messageSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.ViewSMS(collect);

```


### <a name="list_sms"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SMSController.ListSMS") ListSMS

> Retrieve a list of Outbound SMS message objects.


```csharp
Task<string> ListSMS(Models.ListSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Filter SMS message objects from this valid 10-digit phone number (E.164 format). |
| to |  ``` Optional ```  | Filter SMS message objects to this valid 10-digit phone number (E.164 format). |
| dateSent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |


#### Example Usage

```csharp
ListSMSInput collect = new ListSMSInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string dateSent = "DateSent";
collect.DateSent = dateSent;


string result = await sMS.ListSMS(collect);

```


### <a name="list_inbound_sms"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SMSController.ListInboundSMS") ListInboundSMS

> Retrieve a list of Inbound SMS message objects.


```csharp
Task<string> ListInboundSMS(Models.ListInboundSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| mfrom |  ``` Optional ```  | Filter SMS message objects from this valid 10-digit phone number (E.164 format). |
| to |  ``` Optional ```  | Filter SMS message objects to this valid 10-digit phone number (E.164 format). |
| dateSent |  ``` Optional ```  | Filter sms message objects by this date. |


#### Example Usage

```csharp
ListInboundSMSInput collect = new ListInboundSMSInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string dateSent = "DateSent";
collect.DateSent = dateSent;


string result = await sMS.ListInboundSMS(collect);

```


### <a name="view_detail_sms"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SMSController.ViewDetailSMS") ViewDetailSMS

> Retrieve a single SMS message object with details by its SmsSid.


```csharp
Task<string> ViewDetailSMS(Models.ViewDetailSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for a sms message. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewDetailSMSInput collect = new ViewDetailSMSInput();

string messageSid = "MessageSid";
collect.MessageSid = messageSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.ViewDetailSMS(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="call_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.CallController") CallController

### Get singleton instance

The singleton instance of the ``` CallController ``` class can be accessed from the API Client.

```csharp
CallController call = client.Call;
```

### <a name="make_call"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.MakeCall") MakeCall

> You can experiment with initiating a call through Ytel and view the request response generated when doing so and get the response in json


```csharp
Task<string> MakeCall(Models.MakeCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| heartBeatUrl |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed tim |
| heartBeatMethod |  ``` Optional ```  | Specifies the HTTP method used to request HeartbeatUrl. |
| timeout |  ``` Optional ```  | Time (in seconds) Ytel should wait while the call is ringing before canceling the call |
| playDtmf |  ``` Optional ```  | DTMF Digits to play to the call once it connects. 0-9, #, or * |
| hideCallerId |  ``` Optional ```  | Specifies if the caller id will be hidden |
| record |  ``` Optional ```  | Specifies if the call should be recorded |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion |
| recordCallBackMethod |  ``` Optional ```  | Method used to request the RecordCallback URL. |
| transcribe |  ``` Optional ```  | Specifies if the call recording should be transcribed |
| transcribeCallBackUrl |  ``` Optional ```  | Transcription parameters will be sent here upon completion |
| ifMachine |  ``` Optional ```  | How Ytel should handle the receiving numbers voicemail machine |
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

int? timeout = 192;
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


### <a name="play_audio"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.PlayAudio") PlayAudio

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

int? length = 192;
collect.Length = length;

var direction = Models.DirectionEnum?Helper.ParseString("IN");
collect.Direction = direction;

bool? mix = true;
collect.Mix = mix;


string result = await call.PlayAudio(collect);

```


### <a name="record_call"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.RecordCall") RecordCall

> Start or stop recording of an in-progress voice call.


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

int? timeLimit = 192;
collect.TimeLimit = timeLimit;

string callBackUrl = "CallBackUrl";
collect.CallBackUrl = callBackUrl;

var fileformat = Models.AudioFormatEnum?Helper.ParseString("mp3");
collect.Fileformat = fileformat;


string result = await call.RecordCall(collect);

```


### <a name="voice_effect"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.VoiceEffect") VoiceEffect

> Add audio voice effects to the an in-progress voice call.


```csharp
Task<string> VoiceEffect(Models.VoiceEffectInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the in-progress voice call. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| audioDirection |  ``` Optional ```  | The direction the audio effect should be placed on. If IN, the effects will occur on the incoming audio stream. If OUT, the effects will occur on the outgoing audio stream. |
| pitchSemiTones |  ``` Optional ```  | Set the pitch in semitone (half-step) intervals. Value between -14 and 14 |
| pitchOctaves |  ``` Optional ```  | Set the pitch in octave intervals.. Value between -1 and 1 |
| pitch |  ``` Optional ```  | Set the pitch (lowness/highness) of the audio. The higher the value, the higher the pitch. Value greater than 0 |
| rate |  ``` Optional ```  | Set the rate for audio. The lower the value, the lower the rate. value greater than 0 |
| tempo |  ``` Optional ```  | Set the tempo (speed) of the audio. A higher value denotes a faster tempo. Value greater than 0 |


#### Example Usage

```csharp
VoiceEffectInput collect = new VoiceEffectInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string responseType = "json";
collect.ResponseType = responseType;

var audioDirection = Models.AudioDirectionEnum?Helper.ParseString("IN");
collect.AudioDirection = audioDirection;

double? pitchSemiTones = 192.673578382318;
collect.PitchSemiTones = pitchSemiTones;

double? pitchOctaves = 192.673578382318;
collect.PitchOctaves = pitchOctaves;

double? pitch = 192.673578382318;
collect.Pitch = pitch;

double? rate = 192.673578382318;
collect.Rate = rate;

double? tempo = 192.673578382318;
collect.Tempo = tempo;


string result = await call.VoiceEffect(collect);

```


### <a name="send_digit"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.SendDigit") SendDigit

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


### <a name="interrupted_call"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.InterruptedCall") InterruptedCall

> Interrupt the Call by Call Sid


```csharp
Task<string> InterruptedCall(Models.InterruptedCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for voice call that is in progress. |
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


### <a name="list_calls"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.ListCalls") ListCalls

> A list of calls associated with your Ytel account


```csharp
Task<string> ListCalls(Models.ListCallsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| to |  ``` Optional ```  | Filter calls that were sent to this 10-digit number (E.164 format). |
| mfrom |  ``` Optional ```  | Filter calls that were sent from this 10-digit number (E.164 format). |
| dateCreated |  ``` Optional ```  | Return calls that are from a specified date. |


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


### <a name="send_ringless_vm"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.SendRinglessVM") SendRinglessVM

> Initiate an outbound Ringless Voicemail through Ytel.


```csharp
Task<string> SendRinglessVM(Models.SendRinglessVMInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| rVMCallerId |  ``` Required ```  | A required secondary Caller ID for RVM to work. |
| to |  ``` Required ```  | A valid number (E.164 format) that will receive the phone call. |
| voiceMailURL |  ``` Required ```  | The URL requested once the RVM connects. A set of default parameters will be sent here. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| method |  ``` Optional ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statsCallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |


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


### <a name="view_call"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.ViewCall") ViewCall

> Retrieve a single voice call’s information by its CallSid.


```csharp
Task<string> ViewCall(Models.ViewCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callsid |  ``` Required ```  | The unique identifier for the voice call. |
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


### <a name="view_call_detail"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.ViewCallDetail") ViewCallDetail

> Retrieve a single voice call’s information by its CallSid.


```csharp
Task<string> ViewCallDetail(string callSid, string responseType)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the voice call. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
string callSid = "callSid";
string responseType = "json";

string result = await call.ViewCallDetail(callSid, responseType);

```


### <a name="group_call"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CallController.GroupCall") GroupCall

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
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| heartBeatUrl |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed time and pass other general information. |
| heartBeatMethod |  ``` Optional ```  | Specifies the HTTP method used to request HeartbeatUrl. |
| timeout |  ``` Optional ```  | Time (in seconds) we should wait while the call is ringing before canceling the call |
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

int? timeout = 192;
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


[Back to List of Controllers](#list_of_controllers)

## <a name="carrier_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.CarrierController") CarrierController

### Get singleton instance

The singleton instance of the ``` CarrierController ``` class can be accessed from the API Client.

```csharp
CarrierController carrier = client.Carrier;
```

### <a name="carrier_lookup_list"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CarrierController.CarrierLookupList") CarrierLookupList

> Retrieve a list of carrier lookup objects.


```csharp
Task<string> CarrierLookupList(Models.CarrierLookupListInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |


#### Example Usage

```csharp
CarrierLookupListInput collect = new CarrierLookupListInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;


string result = await carrier.CarrierLookupList(collect);

```


### <a name="carrier_lookup"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.CarrierController.CarrierLookup") CarrierLookup

> Get the Carrier Lookup


```csharp
Task<string> CarrierLookup(Models.CarrierLookupInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit number (E.164 format). |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CarrierLookupInput collect = new CarrierLookupInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await carrier.CarrierLookup(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="address_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.AddressController") AddressController

### Get singleton instance

The singleton instance of the ``` AddressController ``` class can be accessed from the API Client.

```csharp
AddressController address = client.Address;
```

### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AddressController.CreateAddress") CreateAddress

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


### <a name="view_address"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AddressController.ViewAddress") ViewAddress

> View Address Specific address Book by providing the address id


```csharp
Task<string> ViewAddress(Models.ViewAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressid |  ``` Required ```  | The identifier of the address to be retrieved. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
ViewAddressInput collect = new ViewAddressInput();

string addressid = "addressid";
collect.Addressid = addressid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.ViewAddress(collect);

```


### <a name="list_address"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AddressController.ListAddress") ListAddress

> List All Address 


```csharp
Task<string> ListAddress(Models.ListAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | How many results to return, default is 10, max is 100, must be an integer |
| addressid |  ``` Optional ```  | addresses Sid |
| dateCreated |  ``` Optional ```  | date created address. |


#### Example Usage

```csharp
ListAddressInput collect = new ListAddressInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string addressid = "addressid";
collect.Addressid = addressid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await address.ListAddress(collect);

```


### <a name="verify_address"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AddressController.VerifyAddress") VerifyAddress

> Validates an address given.


```csharp
Task<string> VerifyAddress(Models.VerifyAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressid |  ``` Required ```  | The identifier of the address to be verified. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
VerifyAddressInput collect = new VerifyAddressInput();

string addressid = "addressid";
collect.Addressid = addressid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.VerifyAddress(collect);

```


### <a name="delete_address"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AddressController.DeleteAddress") DeleteAddress

> To delete Address to your address book


```csharp
Task<string> DeleteAddress(Models.DeleteAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressid |  ``` Required ```  | The identifier of the address to be deleted. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
DeleteAddressInput collect = new DeleteAddressInput();

string addressid = "addressid";
collect.Addressid = addressid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.DeleteAddress(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sub_account_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.SubAccountController") SubAccountController

### Get singleton instance

The singleton instance of the ``` SubAccountController ``` class can be accessed from the API Client.

```csharp
SubAccountController subAccount = client.SubAccount;
```

### <a name="delete_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SubAccountController.DeleteSubAccount") DeleteSubAccount

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


### <a name="suspend_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SubAccountController.SuspendSubAccount") SuspendSubAccount

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


### <a name="create_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.SubAccountController.CreateSubAccount") CreateSubAccount

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
| friendlyName |  ``` Required ```  | Descriptive name of the sub account |
| password |  ``` Required ```  | The password of the sub account.  Please make sure to make as password that is at least 8 characters long, contain a symbol, uppercase and a number. |
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

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string password = "Password";
collect.Password = password;

string responseType = "json";
collect.ResponseType = responseType;


string result = await subAccount.CreateSubAccount(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="account_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.AccountController") AccountController

### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

### <a name="view_account"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AccountController.ViewAccount") ViewAccount

> Retrieve information regarding your Ytel account by a specific date. The response object will contain data such as account status, balance, and account usage totals.


```csharp
Task<string> ViewAccount(Models.ViewAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Required ```  | Filter account information based on date. |
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

## <a name="usage_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.UsageController") UsageController

### Get singleton instance

The singleton instance of the ``` UsageController ``` class can be accessed from the API Client.

```csharp
UsageController usage = client.Usage;
```

### <a name="list_usage"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.UsageController.ListUsage") ListUsage

> Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests.


```csharp
Task<string> ListUsage(Models.ListUsageInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| productCode |  ``` Optional ```  ``` DefaultValue ```  | Filter usage results by product type. |
| startDate |  ``` Optional ```  ``` DefaultValue ```  | Filter usage objects by start date. |
| endDate |  ``` Optional ```  ``` DefaultValue ```  | Filter usage objects by end date. |
| includeSubAccounts |  ``` Optional ```  | Will include all subaccount usage data |


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

string includeSubAccounts = "IncludeSubAccounts";
collect.IncludeSubAccounts = includeSubAccounts;


string result = await usage.ListUsage(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.ShortCodeController") ShortCodeController

### Get singleton instance

The singleton instance of the ``` ShortCodeController ``` class can be accessed from the API Client.

```csharp
ShortCodeController shortCode = client.ShortCode;
```

### <a name="send_dedicated_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.SendDedicatedShortcode") SendDedicatedShortcode

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
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent.GET or POST |
| messagestatuscallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |


#### Example Usage

```csharp
SendDedicatedShortcodeInput collect = new SendDedicatedShortcodeInput();

int shortcode = 192;
collect.Shortcode = shortcode;

double to = 192.673578382318;
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


### <a name="view_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.ViewShortcode") ViewShortcode

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


### <a name="list_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.ListShortcode") ListShortcode

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

string dateSent = "DateSent";
collect.DateSent = dateSent;

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;


string result = await shortCode.ListShortcode(collect);

```


### <a name="list_inbound_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.ListInboundShortcode") ListInboundShortcode

> Retrive a list of inbound Sms Short Code messages associated with your Ytel account.


```csharp
Task<string> ListInboundShortcode(Models.ListInboundShortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Only list SMS messages sent from this number |
| shortcode |  ``` Optional ```  | Only list SMS messages sent to Shortcode |
| datecreated |  ``` Optional ```  | Only list SMS messages sent in the specified date MAKE REQUEST |


#### Example Usage

```csharp
ListInboundShortcodeInput collect = new ListInboundShortcodeInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "From";
collect.Mfrom = mfrom;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string datecreated = "Datecreated";
collect.Datecreated = datecreated;


string result = await shortCode.ListInboundShortcode(collect);

```


### <a name="view_dedicated_shortcode_assignment"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.ViewDedicatedShortcodeAssignment") ViewDedicatedShortcodeAssignment

> Retrieve a single Short Code object by its shortcode assignment.


```csharp
Task<string> ViewDedicatedShortcodeAssignment(Models.ViewDedicatedShortcodeAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Dedicated Short Code to your Ytel account |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
ViewDedicatedShortcodeAssignmentInput collect = new ViewDedicatedShortcodeAssignmentInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.ViewDedicatedShortcodeAssignment(collect);

```


### <a name="update_dedicated_short_code_assignment"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.UpdateDedicatedShortCodeAssignment") UpdateDedicatedShortCodeAssignment

> Update a dedicated shortcode.


```csharp
Task<string> UpdateDedicatedShortCodeAssignment(Models.UpdateDedicatedShortCodeAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid dedicated shortcode to your Ytel account. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| friendlyName |  ``` Optional ```  | User generated name of the dedicated shortcode. |
| callbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |
| callbackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| fallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| fallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST. |


#### Example Usage

```csharp
UpdateDedicatedShortCodeAssignmentInput collect = new UpdateDedicatedShortCodeAssignmentInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string responseType = "json";
collect.ResponseType = responseType;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string callbackMethod = "CallbackMethod";
collect.CallbackMethod = callbackMethod;

string callbackUrl = "CallbackUrl";
collect.CallbackUrl = callbackUrl;

string fallbackMethod = "FallbackMethod";
collect.FallbackMethod = fallbackMethod;

string fallbackUrl = "FallbackUrl";
collect.FallbackUrl = fallbackUrl;


string result = await shortCode.UpdateDedicatedShortCodeAssignment(collect);

```


### <a name="list_short_code_assignment"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.ShortCodeController.ListShortCodeAssignment") ListShortCodeAssignment

> Retrieve a list of Short Code assignment associated with your Ytel account.


```csharp
Task<string> ListShortCodeAssignment(Models.ListShortCodeAssignmentInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |
| shortcode |  ``` Optional ```  | Only list Short Code Assignment sent from this Short Code |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |


#### Example Usage

```csharp
ListShortCodeAssignmentInput collect = new ListShortCodeAssignmentInput();

string responseType = "json";
collect.ResponseType = responseType;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string page = "page";
collect.Page = page;

string pagesize = "pagesize";
collect.Pagesize = pagesize;


string result = await shortCode.ListShortCodeAssignment(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="post_card_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.PostCardController") PostCardController

### Get singleton instance

The singleton instance of the ``` PostCardController ``` class can be accessed from the API Client.

```csharp
PostCardController postCard = client.PostCard;
```

### <a name="view_postcard"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PostCardController.ViewPostcard") ViewPostcard

> Retrieve a postcard object by its PostcardId.


```csharp
Task<string> ViewPostcard(Models.ViewPostcardInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| postcardid |  ``` Required ```  | The unique identifier for a postcard object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
ViewPostcardInput collect = new ViewPostcardInput();

string postcardid = "postcardid";
collect.Postcardid = postcardid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await postCard.ViewPostcard(collect);

```


### <a name="create_postcard"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PostCardController.CreatePostcard") CreatePostcard

> Create, print, and mail a postcard to an address. The postcard front must be supplied as a PDF, image, or an HTML string. The back can be a PDF, image, HTML string, or it can be automatically generated by supplying a custom message.


```csharp
Task<string> CreatePostcard(Models.CreatePostcardInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | The AddressId or an object structured when creating an address by addresses/Create. |
| mfrom |  ``` Required ```  | The AddressId or an object structured when creating an address by addresses/Create. |
| attachbyid |  ``` Required ```  | Set an existing postcard by attaching its PostcardId. |
| front |  ``` Required ```  | A 4.25"x6.25" or 6.25"x11.25" image to use as the front of the postcard.  This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG. |
| back |  ``` Required ```  | A 4.25"x6.25" or 6.25"x11.25" image to use as the back of the postcard, supplied as a URL, local file, or HTML string.  This allows you to customize your back design, but we will still insert the recipient address for you. |
| message |  ``` Required ```  | The message for the back of the postcard with a maximum of 350 characters. |
| setting |  ``` Required ```  | Code for the dimensions of the media to be printed. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| description |  ``` Optional ```  | A description for the postcard. |
| htmldata |  ``` Optional ```  | A string value that contains HTML markup. |


#### Example Usage

```csharp
CreatePostcardInput collect = new CreatePostcardInput();

string to = "to";
collect.To = to;

string mfrom = "from";
collect.Mfrom = mfrom;

string attachbyid = "attachbyid";
collect.Attachbyid = attachbyid;

string front = "front";
collect.Front = front;

string back = "back";
collect.Back = back;

string message = "message";
collect.Message = message;

string setting = "setting";
collect.Setting = setting;

string responseType = "json";
collect.ResponseType = responseType;

string description = "description";
collect.Description = description;

string htmldata = "htmldata";
collect.Htmldata = htmldata;


string result = await postCard.CreatePostcard(collect);

```


### <a name="list_postcards"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PostCardController.ListPostcards") ListPostcards

> Retrieve a list of postcard objects. The postcards objects are sorted by creation date, with the most recently created postcards appearing first.


```csharp
Task<string> ListPostcards(Models.ListPostcardsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| postcardid |  ``` Optional ```  | The unique identifier for a postcard object. |
| dateCreated |  ``` Optional ```  | The date the postcard was created. |


#### Example Usage

```csharp
ListPostcardsInput collect = new ListPostcardsInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string postcardid = "postcardid";
collect.Postcardid = postcardid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await postCard.ListPostcards(collect);

```


### <a name="delete_postcard"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.PostCardController.DeletePostcard") DeletePostcard

> Remove a postcard object.


```csharp
Task<string> DeletePostcard(Models.DeletePostcardInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| postcardid |  ``` Required ```  | The unique identifier of a postcard object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
DeletePostcardInput collect = new DeletePostcardInput();

string postcardid = "postcardid";
collect.Postcardid = postcardid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await postCard.DeletePostcard(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="letter_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.LetterController") LetterController

### Get singleton instance

The singleton instance of the ``` LetterController ``` class can be accessed from the API Client.

```csharp
LetterController letter = client.Letter;
```

### <a name="view_letter"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.LetterController.ViewLetter") ViewLetter

> Retrieve a letter object by its LetterSid.


```csharp
Task<string> ViewLetter(Models.ViewLetterInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lettersid |  ``` Required ```  | The unique identifier for a letter object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
ViewLetterInput collect = new ViewLetterInput();

string lettersid = "lettersid";
collect.Lettersid = lettersid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await letter.ViewLetter(collect);

```


### <a name="create_letter"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.LetterController.CreateLetter") CreateLetter

> Create, print, and mail a letter to an address. The letter file must be supplied as a PDF or an HTML string.


```csharp
Task<string> CreateLetter(Models.CreateLetterInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | The AddressId or an object structured when creating an address by addresses/Create. |
| mfrom |  ``` Required ```  | The AddressId or an object structured when creating an address by addresses/Create. |
| attachbyid |  ``` Required ```  | Set an existing letter by attaching its LetterId. |
| file |  ``` Required ```  | File can be a 8.5"x11" PDF uploaded file or URL that links to a file. |
| color |  ``` Required ```  | Specify if letter should be printed in color. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| description |  ``` Optional ```  | A description for the letter. |
| extraservice |  ``` Optional ```  | Add an extra service to your letter. Options are "certified" or "registered". Certified provides tracking and delivery confirmation for domestic destinations and is an additional $5.00. Registered provides tracking and confirmation for international addresses and is an additional $16.50. |
| doublesided |  ``` Optional ```  | Specify if letter should be printed on both sides. |
| template |  ``` Optional ```  | Boolean that defaults to true. When set to false, this specifies that your letter does not follow the m360 address template. In this case, a blank address page will be inserted at the beginning of your file and you will be charged for the extra page. |
| htmldata |  ``` Optional ```  | A string value that contains HTML markup. |


#### Example Usage

```csharp
CreateLetterInput collect = new CreateLetterInput();

string to = "to";
collect.To = to;

string mfrom = "from";
collect.Mfrom = mfrom;

string attachbyid = "attachbyid";
collect.Attachbyid = attachbyid;

string file = "file";
collect.File = file;

string color = "color";
collect.Color = color;

string responseType = "json";
collect.ResponseType = responseType;

string description = "description";
collect.Description = description;

string extraservice = "extraservice";
collect.Extraservice = extraservice;

string doublesided = "doublesided";
collect.Doublesided = doublesided;

string template = "template";
collect.Template = template;

string htmldata = "htmldata";
collect.Htmldata = htmldata;


string result = await letter.CreateLetter(collect);

```


### <a name="list_letters"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.LetterController.ListLetters") ListLetters

> Retrieve a list of letter objects. The letter objects are sorted by creation date, with the most recently created letters appearing first.


```csharp
Task<string> ListLetters(Models.ListLettersInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| lettersid |  ``` Optional ```  | The unique identifier for a letter object. |
| dateCreated |  ``` Optional ```  | The date the letter was created. |


#### Example Usage

```csharp
ListLettersInput collect = new ListLettersInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string lettersid = "lettersid";
collect.Lettersid = lettersid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await letter.ListLetters(collect);

```


### <a name="delete_letter"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.LetterController.DeleteLetter") DeleteLetter

> Remove a letter object by its LetterId.


```csharp
Task<string> DeleteLetter(Models.DeleteLetterInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lettersid |  ``` Required ```  | The unique identifier for a letter object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
DeleteLetterInput collect = new DeleteLetterInput();

string lettersid = "lettersid";
collect.Lettersid = lettersid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await letter.DeleteLetter(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="area_mail_controller"></a>![Class: ](https://apidocs.io/img/class.png "ytel.Controllers.AreaMailController") AreaMailController

### Get singleton instance

The singleton instance of the ``` AreaMailController ``` class can be accessed from the API Client.

```csharp
AreaMailController areaMail = client.AreaMail;
```

### <a name="create_area_mail"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AreaMailController.CreateAreaMail") CreateAreaMail

> Create a new AreaMail object.


```csharp
Task<string> CreateAreaMail(Models.CreateAreaMailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| routes |  ``` Required ```  | List of routes that AreaMail should be delivered to.  A single route can be either a zipcode or a carrier route.List of routes that AreaMail should be delivered to.  A single route can be either a zipcode or a carrier route. A carrier route is in the form of 92610-C043 where the carrier route is composed of 5 numbers for zipcode, 1 letter for carrier route type, and 3 numbers for carrier route code. Delivery can be sent to mutliple routes by separating them with a commas. Valid Values: 92656, 92610-C043 |
| attachbyid |  ``` Required ```  | Set an existing areamail by attaching its AreamailId. |
| front |  ``` Required ```  | The front of the AreaMail item to be created. This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG. Back required |
| back |  ``` Required ```  | The back of the AreaMail item to be created. This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| description |  ``` Optional ```  | A string value to use as a description for this AreaMail item. |
| targettype |  ``` Optional ```  | The delivery location type. |
| htmldata |  ``` Optional ```  | A string value that contains HTML markup. |


#### Example Usage

```csharp
CreateAreaMailInput collect = new CreateAreaMailInput();

string routes = "routes";
collect.Routes = routes;

string attachbyid = "attachbyid";
collect.Attachbyid = attachbyid;

string front = "front";
collect.Front = front;

string back = "back";
collect.Back = back;

string responseType = "json";
collect.ResponseType = responseType;

string description = "description";
collect.Description = description;

string targettype = "targettype";
collect.Targettype = targettype;

string htmldata = "htmldata";
collect.Htmldata = htmldata;


string result = await areaMail.CreateAreaMail(collect);

```


### <a name="view_area_mail"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AreaMailController.ViewAreaMail") ViewAreaMail

> Retrieve an AreaMail object by its AreaMailId.


```csharp
Task<string> ViewAreaMail(Models.ViewAreaMailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| areamailid |  ``` Required ```  | The unique identifier for an AreaMail object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
ViewAreaMailInput collect = new ViewAreaMailInput();

string areamailid = "areamailid";
collect.Areamailid = areamailid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await areaMail.ViewAreaMail(collect);

```


### <a name="list_area_mail"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AreaMailController.ListAreaMail") ListAreaMail

> Retrieve a list of AreaMail objects.


```csharp
Task<string> ListAreaMail(Models.ListAreaMailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| areamailsid |  ``` Optional ```  | The unique identifier for an AreaMail object. |
| dateCreated |  ``` Optional ```  | The date the AreaMail was created. |


#### Example Usage

```csharp
ListAreaMailInput collect = new ListAreaMailInput();

string responseType = "json";
collect.ResponseType = responseType;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string areamailsid = "areamailsid";
collect.Areamailsid = areamailsid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await areaMail.ListAreaMail(collect);

```


### <a name="delete_area_mail"></a>![Method: ](https://apidocs.io/img/method.png "ytel.Controllers.AreaMailController.DeleteAreaMail") DeleteAreaMail

> Remove an AreaMail object by its AreaMailId.


```csharp
Task<string> DeleteAreaMail(Models.DeleteAreaMailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| areamailid |  ``` Required ```  | The unique identifier for an AreaMail object. |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
DeleteAreaMailInput collect = new DeleteAreaMailInput();

string areamailid = "areamailid";
collect.Areamailid = areamailid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await areaMail.DeleteAreaMail(collect);

```


[Back to List of Controllers](#list_of_controllers)



