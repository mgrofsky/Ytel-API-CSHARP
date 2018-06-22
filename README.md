# Getting started

Ytel API version 3

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (YtelAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the YtelAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

### 3. Add reference of the library project

In order to use the YtelAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` YtelAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```YtelAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Standard)

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

YtelAPIClient client = new YtelAPIClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [ShortCodeController](#short_code_controller)
* [AreaMailController](#area_mail_controller)
* [PostCardController](#post_card_controller)
* [LetterController](#letter_controller)
* [CallController](#call_controller)
* [PhoneNumberController](#phone_number_controller)
* [SMSController](#sms_controller)
* [SharedShortCodeController](#shared_short_code_controller)
* [ConferenceController](#conference_controller)
* [CarrierController](#carrier_controller)
* [EmailController](#email_controller)
* [AccountController](#account_controller)
* [SubAccountController](#sub_account_controller)
* [AddressController](#address_controller)
* [RecordingController](#recording_controller)
* [TranscriptionController](#transcription_controller)
* [UsageController](#usage_controller)

## <a name="short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.ShortCodeController") ShortCodeController

### Get singleton instance

The singleton instance of the ``` ShortCodeController ``` class can be accessed from the API Client.

```csharp
ShortCodeController shortCode = client.ShortCode;
```

### <a name="create_dedicatedshortcode_listshortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateDedicatedshortcodeListshortcode") CreateDedicatedshortcodeListshortcode

> Retrieve a list of Short Code assignment associated with your Ytel account.


```csharp
Task<string> CreateDedicatedshortcodeListshortcode(Models.CreateDedicatedshortcodeListshortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Optional ```  | Only list Short Code Assignment sent from this Short Code |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |


#### Example Usage

```csharp
CreateDedicatedshortcodeListshortcodeInput collect = new CreateDedicatedshortcodeListshortcodeInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string page = "page";
collect.Page = page;

string pagesize = "pagesize";
collect.Pagesize = pagesize;


string result = await shortCode.CreateDedicatedshortcodeListshortcode(collect);

```


### <a name="create_dedicatedshortcode_updateshortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateDedicatedshortcodeUpdateshortcode") CreateDedicatedshortcodeUpdateshortcode

> Update a dedicated shortcode.


```csharp
Task<string> CreateDedicatedshortcodeUpdateshortcode(Models.CreateDedicatedshortcodeUpdateshortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid dedicated shortcode to your Ytel account. |
| friendlyName |  ``` Optional ```  | User generated name of the dedicated shortcode. |
| callbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |
| callbackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| fallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| fallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST. |


#### Example Usage

```csharp
CreateDedicatedshortcodeUpdateshortcodeInput collect = new CreateDedicatedshortcodeUpdateshortcodeInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

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


string result = await shortCode.CreateDedicatedshortcodeUpdateshortcode(collect);

```


### <a name="create_dedicatedshortcode_viewshortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateDedicatedshortcodeViewshortcode") CreateDedicatedshortcodeViewshortcode

> Retrieve a single Short Code object by its shortcode assignment.


```csharp
Task<string> CreateDedicatedshortcodeViewshortcode(string shortcode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Dedicated Short Code to your Ytel account |


#### Example Usage

```csharp
string shortcode = "Shortcode";

string result = await shortCode.CreateDedicatedshortcodeViewshortcode(shortcode);

```


### <a name="create_shortcode_viewsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateShortcodeViewsms") CreateShortcodeViewsms

> View a single Sms Short Code message.


```csharp
Task<string> CreateShortcodeViewsms(string messageSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for the sms resource |


#### Example Usage

```csharp
string messageSid = "MessageSid";

string result = await shortCode.CreateShortcodeViewsms(messageSid);

```


### <a name="create_dedicatedshortcode_getinboundsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateDedicatedshortcodeGetinboundsms") CreateDedicatedshortcodeGetinboundsms

> Retrive a list of inbound Sms Short Code messages associated with your Ytel account.


```csharp
Task<string> CreateDedicatedshortcodeGetinboundsms(Models.CreateDedicatedshortcodeGetinboundsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Only list SMS messages sent from this number |
| shortcode |  ``` Optional ```  | Only list SMS messages sent to Shortcode |
| datecreated |  ``` Optional ```  | Only list SMS messages sent in the specified date MAKE REQUEST |


#### Example Usage

```csharp
CreateDedicatedshortcodeGetinboundsmsInput collect = new CreateDedicatedshortcodeGetinboundsmsInput();

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


string result = await shortCode.CreateDedicatedshortcodeGetinboundsms(collect);

```


### <a name="create_dedicatedshortcode_sendsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateDedicatedshortcodeSendsms") CreateDedicatedshortcodeSendsms

> Send Dedicated Shortcode


```csharp
Task<string> CreateDedicatedshortcodeSendsms(Models.CreateDedicatedshortcodeSendsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | Your dedicated shortcode |
| to |  ``` Required ```  | The number to send your SMS to |
| body |  ``` Required ```  | The body of your message |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent.GET or POST |
| messagestatuscallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |


#### Example Usage

```csharp
CreateDedicatedshortcodeSendsmsInput collect = new CreateDedicatedshortcodeSendsmsInput();

int shortcode = 198;
collect.Shortcode = shortcode;

double to = 198.601868394111;
collect.To = to;

string body = "body";
collect.Body = body;

string method = "method";
collect.Method = method;

string messagestatuscallback = "messagestatuscallback";
collect.Messagestatuscallback = messagestatuscallback;


string result = await shortCode.CreateDedicatedshortcodeSendsms(collect);

```


### <a name="create_shortcode_listsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ShortCodeController.CreateShortcodeListsms") CreateShortcodeListsms

> Retrieve a list of Short Code messages.


```csharp
Task<string> CreateShortcodeListsms(Models.CreateShortcodeListsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Optional ```  | Only list messages sent from this Short Code |
| to |  ``` Optional ```  | Only list messages sent to this number |
| dateSent |  ``` Optional ```  | Only list messages sent with the specified date |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |


#### Example Usage

```csharp
CreateShortcodeListsmsInput collect = new CreateShortcodeListsmsInput();

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


string result = await shortCode.CreateShortcodeListsms(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="area_mail_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.AreaMailController") AreaMailController

### Get singleton instance

The singleton instance of the ``` AreaMailController ``` class can be accessed from the API Client.

```csharp
AreaMailController areaMail = client.AreaMail;
```

### <a name="create_areamail_delete"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AreaMailController.CreateAreamailDelete") CreateAreamailDelete

> Remove an AreaMail object by its AreaMailId.


```csharp
Task<string> CreateAreamailDelete(string areamailid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| areamailid |  ``` Required ```  | The unique identifier for an AreaMail object. |


#### Example Usage

```csharp
string areamailid = "areamailid";

string result = await areaMail.CreateAreamailDelete(areamailid);

```


### <a name="create_areamail_create"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AreaMailController.CreateAreamailCreate") CreateAreamailCreate

> Create a new AreaMail object.


```csharp
Task<string> CreateAreamailCreate(Models.CreateAreamailCreateInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| routes |  ``` Required ```  | List of routes that AreaMail should be delivered to.  A single route can be either a zipcode or a carrier route.List of routes that AreaMail should be delivered to.  A single route can be either a zipcode or a carrier route. A carrier route is in the form of 92610-C043 where the carrier route is composed of 5 numbers for zipcode, 1 letter for carrier route type, and 3 numbers for carrier route code. Delivery can be sent to mutliple routes by separating them with a commas. Valid Values: 92656, 92610-C043 |
| attachbyid |  ``` Required ```  | Set an existing areamail by attaching its AreamailId. |
| front |  ``` Required ```  | The front of the AreaMail item to be created. This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG. Back required |
| back |  ``` Required ```  | The back of the AreaMail item to be created. This can be a URL, local file, or an HTML string. Supported file types are PDF, PNG, and JPEG. |
| description |  ``` Optional ```  | A string value to use as a description for this AreaMail item. |
| targettype |  ``` Optional ```  | The delivery location type. |
| htmldata |  ``` Optional ```  | A string value that contains HTML markup. |


#### Example Usage

```csharp
CreateAreamailCreateInput collect = new CreateAreamailCreateInput();

string routes = "routes";
collect.Routes = routes;

string attachbyid = "attachbyid";
collect.Attachbyid = attachbyid;

string front = "front";
collect.Front = front;

string back = "back";
collect.Back = back;

string description = "description";
collect.Description = description;

string targettype = "targettype";
collect.Targettype = targettype;

string htmldata = "htmldata";
collect.Htmldata = htmldata;


string result = await areaMail.CreateAreamailCreate(collect);

```


### <a name="create_areamail_view"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AreaMailController.CreateAreamailView") CreateAreamailView

> Retrieve an AreaMail object by its AreaMailId.


```csharp
Task<string> CreateAreamailView(string areamailid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| areamailid |  ``` Required ```  | The unique identifier for an AreaMail object. |


#### Example Usage

```csharp
string areamailid = "areamailid";

string result = await areaMail.CreateAreamailView(areamailid);

```


### <a name="create_areamail_lists"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AreaMailController.CreateAreamailLists") CreateAreamailLists

> Retrieve a list of AreaMail objects.


```csharp
Task<string> CreateAreamailLists(Models.CreateAreamailListsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| areamailsid |  ``` Optional ```  | The unique identifier for an AreaMail object. |
| dateCreated |  ``` Optional ```  | The date the AreaMail was created. |


#### Example Usage

```csharp
CreateAreamailListsInput collect = new CreateAreamailListsInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string areamailsid = "areamailsid";
collect.Areamailsid = areamailsid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await areaMail.CreateAreamailLists(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="post_card_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.PostCardController") PostCardController

### Get singleton instance

The singleton instance of the ``` PostCardController ``` class can be accessed from the API Client.

```csharp
PostCardController postCard = client.PostCard;
```

### <a name="postcard_deletepostcard"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PostCardController.PostcardDeletepostcard") PostcardDeletepostcard

> Remove a postcard object.


```csharp
Task<string> PostcardDeletepostcard(string postcardid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| postcardid |  ``` Required ```  | The unique identifier of a postcard object. |


#### Example Usage

```csharp
string postcardid = "postcardid";

string result = await postCard.PostcardDeletepostcard(postcardid);

```


### <a name="postcard_viewpostcard"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PostCardController.PostcardViewpostcard") PostcardViewpostcard

> Retrieve a postcard object by its PostcardId.


```csharp
Task<string> PostcardViewpostcard(string postcardid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| postcardid |  ``` Required ```  | The unique identifier for a postcard object. |


#### Example Usage

```csharp
string postcardid = "postcardid";

string result = await postCard.PostcardViewpostcard(postcardid);

```


### <a name="postcard_listpostcard"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PostCardController.PostcardListpostcard") PostcardListpostcard

> Retrieve a list of postcard objects. The postcards objects are sorted by creation date, with the most recently created postcards appearing first.


```csharp
Task<string> PostcardListpostcard(Models.PostcardListpostcardInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| postcardid |  ``` Optional ```  | The unique identifier for a postcard object. |
| dateCreated |  ``` Optional ```  | The date the postcard was created. |


#### Example Usage

```csharp
PostcardListpostcardInput collect = new PostcardListpostcardInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string postcardid = "postcardid";
collect.Postcardid = postcardid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await postCard.PostcardListpostcard(collect);

```


### <a name="postcard_createpostcard"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PostCardController.PostcardCreatepostcard") PostcardCreatepostcard

> Create, print, and mail a postcard to an address. The postcard front must be supplied as a PDF, image, or an HTML string. The back can be a PDF, image, HTML string, or it can be automatically generated by supplying a custom message.


```csharp
Task<string> PostcardCreatepostcard(Models.PostcardCreatepostcardInput input)
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
| description |  ``` Optional ```  | A description for the postcard. |
| htmldata |  ``` Optional ```  | A string value that contains HTML markup. |


#### Example Usage

```csharp
PostcardCreatepostcardInput collect = new PostcardCreatepostcardInput();

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

string description = "description";
collect.Description = description;

string htmldata = "htmldata";
collect.Htmldata = htmldata;


string result = await postCard.PostcardCreatepostcard(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="letter_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.LetterController") LetterController

### Get singleton instance

The singleton instance of the ``` LetterController ``` class can be accessed from the API Client.

```csharp
LetterController letter = client.Letter;
```

### <a name="create_letter_delete"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.LetterController.CreateLetterDelete") CreateLetterDelete

> Remove a letter object by its LetterId.


```csharp
Task<string> CreateLetterDelete(string lettersid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lettersid |  ``` Required ```  | The unique identifier for a letter object. |


#### Example Usage

```csharp
string lettersid = "lettersid";

string result = await letter.CreateLetterDelete(lettersid);

```


### <a name="create_letter_viewletter"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.LetterController.CreateLetterViewletter") CreateLetterViewletter

> Retrieve a letter object by its LetterSid.


```csharp
Task<string> CreateLetterViewletter(string lettersid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| lettersid |  ``` Required ```  | The unique identifier for a letter object. |


#### Example Usage

```csharp
string lettersid = "lettersid";

string result = await letter.CreateLetterViewletter(lettersid);

```


### <a name="create_letter_listsletter"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.LetterController.CreateLetterListsletter") CreateLetterListsletter

> Retrieve a list of letter objects. The letter objects are sorted by creation date, with the most recently created letters appearing first.


```csharp
Task<string> CreateLetterListsletter(Models.CreateLetterListsletterInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| lettersid |  ``` Optional ```  | The unique identifier for a letter object. |
| dateCreated |  ``` Optional ```  | The date the letter was created. |


#### Example Usage

```csharp
CreateLetterListsletterInput collect = new CreateLetterListsletterInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string lettersid = "lettersid";
collect.Lettersid = lettersid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await letter.CreateLetterListsletter(collect);

```


### <a name="create_letter_create"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.LetterController.CreateLetterCreate") CreateLetterCreate

> Create, print, and mail a letter to an address. The letter file must be supplied as a PDF or an HTML string.


```csharp
Task<string> CreateLetterCreate(Models.CreateLetterCreateInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | The AddressId or an object structured when creating an address by addresses/Create. |
| mfrom |  ``` Required ```  | The AddressId or an object structured when creating an address by addresses/Create. |
| attachbyid |  ``` Required ```  | Set an existing letter by attaching its LetterId. |
| file |  ``` Required ```  | File can be a 8.5"x11" PDF uploaded file or URL that links to a file. |
| color |  ``` Required ```  | Specify if letter should be printed in color. |
| description |  ``` Optional ```  | A description for the letter. |
| extraservice |  ``` Optional ```  | Add an extra service to your letter. Options are "certified" or "registered". Certified provides tracking and delivery confirmation for domestic destinations and is an additional $5.00. Registered provides tracking and confirmation for international addresses and is an additional $16.50. |
| doublesided |  ``` Optional ```  | Specify if letter should be printed on both sides. |
| template |  ``` Optional ```  | Boolean that defaults to true. When set to false, this specifies that your letter does not follow the m360 address template. In this case, a blank address page will be inserted at the beginning of your file and you will be charged for the extra page. |
| htmldata |  ``` Optional ```  | A string value that contains HTML markup. |


#### Example Usage

```csharp
CreateLetterCreateInput collect = new CreateLetterCreateInput();

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


string result = await letter.CreateLetterCreate(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="call_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.CallController") CallController

### Get singleton instance

The singleton instance of the ``` CallController ``` class can be accessed from the API Client.

```csharp
CallController call = client.Call;
```

### <a name="create_calls_viewcalldetail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsViewcalldetail") CreateCallsViewcalldetail

> Retrieve a single voice call’s information by its CallSid.


```csharp
Task<string> CreateCallsViewcalldetail(string callSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the voice call. |


#### Example Usage

```csharp
string callSid = "callSid";

string result = await call.CreateCallsViewcalldetail(callSid);

```


### <a name="create_calls_viewcalls"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsViewcalls") CreateCallsViewcalls

> Retrieve a single voice call’s information by its CallSid.


```csharp
Task<string> CreateCallsViewcalls(string callsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callsid |  ``` Required ```  | The unique identifier for the voice call. |


#### Example Usage

```csharp
string callsid = "callsid";

string result = await call.CreateCallsViewcalls(callsid);

```


### <a name="create_calls_senddigits"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsSenddigits") CreateCallsSenddigits

> Play Dtmf and send the Digit


```csharp
Task<string> CreateCallsSenddigits(Models.CreateCallsSenddigitsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| playDtmf |  ``` Required ```  | DTMF digits to play to the call. 0-9, #, *, W, or w |
| playDtmfDirection |  ``` Optional ```  | The leg of the call DTMF digits should be sent to |


#### Example Usage

```csharp
CreateCallsSenddigitsInput collect = new CreateCallsSenddigitsInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

var playDtmfDirection = Models.PlayDtmfDirectionEnum?Helper.ParseString("IN");
collect.PlayDtmfDirection = playDtmfDirection;


string result = await call.CreateCallsSenddigits(collect);

```


### <a name="create_calls_makervm"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsMakervm") CreateCallsMakervm

> Initiate an outbound Ringless Voicemail through Ytel.


```csharp
Task<string> CreateCallsMakervm(Models.CreateCallsMakervmInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| rVMCallerId |  ``` Required ```  | A required secondary Caller ID for RVM to work. |
| to |  ``` Required ```  | A valid number (E.164 format) that will receive the phone call. |
| voiceMailURL |  ``` Required ```  | The URL requested once the RVM connects. A set of default parameters will be sent here. |
| method |  ``` Optional ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statsCallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |


#### Example Usage

```csharp
CreateCallsMakervmInput collect = new CreateCallsMakervmInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string rVMCallerId = "RVMCallerId";
collect.RVMCallerId = rVMCallerId;

string to = "To";
collect.To = to;

string voiceMailURL = "VoiceMailURL";
collect.VoiceMailURL = voiceMailURL;

string method = "GET";
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

string statsCallBackMethod = "StatsCallBackMethod";
collect.StatsCallBackMethod = statsCallBackMethod;


string result = await call.CreateCallsMakervm(collect);

```


### <a name="create_calls_listcalls"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsListcalls") CreateCallsListcalls

> A list of calls associated with your Ytel account


```csharp
Task<string> CreateCallsListcalls(Models.CreateCallsListcallsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| to |  ``` Optional ```  | Filter calls that were sent to this 10-digit number (E.164 format). |
| mfrom |  ``` Optional ```  | Filter calls that were sent from this 10-digit number (E.164 format). |
| dateCreated |  ``` Optional ```  | Return calls that are from a specified date. |


#### Example Usage

```csharp
CreateCallsListcallsInput collect = new CreateCallsListcallsInput();

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


string result = await call.CreateCallsListcalls(collect);

```


### <a name="create_calls_interruptcalls"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsInterruptcalls") CreateCallsInterruptcalls

> Interrupt the Call by Call Sid


```csharp
Task<string> CreateCallsInterruptcalls(Models.CreateCallsInterruptcallsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for voice call that is in progress. |
| url |  ``` Optional ```  | URL the in-progress call will be redirected to |
| method |  ``` Optional ```  | The method used to request the above Url parameter |
| status |  ``` Optional ```  | Status to set the in-progress call to |


#### Example Usage

```csharp
CreateCallsInterruptcallsInput collect = new CreateCallsInterruptcallsInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string url = "Url";
collect.Url = url;

string method = "Method";
collect.Method = method;

var status = Models.Status24Enum?Helper.ParseString("CANCELED");
collect.Status = status;


string result = await call.CreateCallsInterruptcalls(collect);

```


### <a name="create_calls_recordcalls"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsRecordcalls") CreateCallsRecordcalls

> Start or stop recording of an in-progress voice call.


```csharp
Task<string> CreateCallsRecordcalls(Models.CreateCallsRecordcallsInput input)
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


#### Example Usage

```csharp
CreateCallsRecordcallsInput collect = new CreateCallsRecordcallsInput();

string callSid = "CallSid";
collect.CallSid = callSid;

bool record = false;
collect.Record = record;

var direction = Models.DirectionEnum?Helper.ParseString("IN");
collect.Direction = direction;

int? timeLimit = 35;
collect.TimeLimit = timeLimit;

string callBackUrl = "CallBackUrl";
collect.CallBackUrl = callBackUrl;

var fileformat = Models.FileformatEnum?Helper.ParseString("mp3");
collect.Fileformat = fileformat;


string result = await call.CreateCallsRecordcalls(collect);

```


### <a name="create_calls_playaudios"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsPlayaudios") CreateCallsPlayaudios

> Play Audio from a url


```csharp
Task<string> CreateCallsPlayaudios(Models.CreateCallsPlayaudiosInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| audioUrl |  ``` Required ```  | URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav |
| sayText |  ``` Required ```  | Valid alphanumeric string that should be played to the In-progress call. |
| length |  ``` Optional ```  | Time limit in seconds for audio play back |
| direction |  ``` Optional ```  | The leg of the call audio will be played to |
| mix |  ``` Optional ```  | If false, all other audio will be muted |


#### Example Usage

```csharp
CreateCallsPlayaudiosInput collect = new CreateCallsPlayaudiosInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string audioUrl = "AudioUrl";
collect.AudioUrl = audioUrl;

string sayText = "SayText";
collect.SayText = sayText;

int? length = 35;
collect.Length = length;

var direction = Models.DirectionEnum?Helper.ParseString("IN");
collect.Direction = direction;

bool? mix = false;
collect.Mix = mix;


string result = await call.CreateCallsPlayaudios(collect);

```


### <a name="create_calls_voiceeffect"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsVoiceeffect") CreateCallsVoiceeffect

> Add audio voice effects to the an in-progress voice call.


```csharp
Task<string> CreateCallsVoiceeffect(Models.CreateCallsVoiceeffectInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the in-progress voice call. |
| audioDirection |  ``` Optional ```  | The direction the audio effect should be placed on. If IN, the effects will occur on the incoming audio stream. If OUT, the effects will occur on the outgoing audio stream. |
| pitchSemiTones |  ``` Optional ```  | Set the pitch in semitone (half-step) intervals. Value between -14 and 14 |
| pitchOctaves |  ``` Optional ```  | Set the pitch in octave intervals.. Value between -1 and 1 |
| pitch |  ``` Optional ```  | Set the pitch (lowness/highness) of the audio. The higher the value, the higher the pitch. Value greater than 0 |
| rate |  ``` Optional ```  | Set the rate for audio. The lower the value, the lower the rate. value greater than 0 |
| tempo |  ``` Optional ```  | Set the tempo (speed) of the audio. A higher value denotes a faster tempo. Value greater than 0 |


#### Example Usage

```csharp
CreateCallsVoiceeffectInput collect = new CreateCallsVoiceeffectInput();

string callSid = "CallSid";
collect.CallSid = callSid;

var audioDirection = Models.AudioDirectionEnum?Helper.ParseString("IN");
collect.AudioDirection = audioDirection;

double? pitchSemiTones = 35.0971502857735;
collect.PitchSemiTones = pitchSemiTones;

double? pitchOctaves = 35.0971502857735;
collect.PitchOctaves = pitchOctaves;

double? pitch = 35.0971502857735;
collect.Pitch = pitch;

double? rate = 35.0971502857735;
collect.Rate = rate;

double? tempo = 35.0971502857735;
collect.Tempo = tempo;


string result = await call.CreateCallsVoiceeffect(collect);

```


### <a name="create_calls_groupcall"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsGroupcall") CreateCallsGroupcall

> Group Call


```csharp
Task<string> CreateCallsGroupcall(Models.CreateCallsGroupcallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| to |  ``` Required ```  | Please enter multiple E164 number. You can add max 10 numbers. Add numbers separated with comma. e.g : 1111111111,2222222222 |
| url |  ``` Required ```  | URL requested once the call connects |
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
CreateCallsGroupcallInput collect = new CreateCallsGroupcallInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

string groupConfirmKey = "GroupConfirmKey";
collect.GroupConfirmKey = groupConfirmKey;

var groupConfirmFile = Models.GroupConfirmFileEnumHelper.ParseString("mp3");
collect.GroupConfirmFile = groupConfirmFile;

string method = "Method";
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

string statusCallBackMethod = "StatusCallBackMethod";
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

string fallBackMethod = "FallBackMethod";
collect.FallBackMethod = fallBackMethod;

string heartBeatUrl = "HeartBeatUrl";
collect.HeartBeatUrl = heartBeatUrl;

string heartBeatMethod = "HeartBeatMethod";
collect.HeartBeatMethod = heartBeatMethod;

int? timeout = 35;
collect.Timeout = timeout;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

string hideCallerId = "HideCallerId";
collect.HideCallerId = hideCallerId;

bool? record = false;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

string recordCallBackMethod = "RecordCallBackMethod";
collect.RecordCallBackMethod = recordCallBackMethod;

bool? transcribe = false;
collect.Transcribe = transcribe;

string transcribeCallBackUrl = "TranscribeCallBackUrl";
collect.TranscribeCallBackUrl = transcribeCallBackUrl;


string result = await call.CreateCallsGroupcall(collect);

```


### <a name="create_calls_makecall"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CallController.CreateCallsMakecall") CreateCallsMakecall

> You can experiment with initiating a call through Ytel and view the request response generated when doing so and get the response in json


```csharp
Task<string> CreateCallsMakecall(Models.CreateCallsMakecallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
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
CreateCallsMakecallInput collect = new CreateCallsMakecallInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

string method = "Method";
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

string statusCallBackMethod = "StatusCallBackMethod";
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

string fallBackMethod = "FallBackMethod";
collect.FallBackMethod = fallBackMethod;

string heartBeatUrl = "HeartBeatUrl";
collect.HeartBeatUrl = heartBeatUrl;

string heartBeatMethod = "HeartBeatMethod";
collect.HeartBeatMethod = heartBeatMethod;

int? timeout = 35;
collect.Timeout = timeout;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

bool? hideCallerId = false;
collect.HideCallerId = hideCallerId;

bool? record = false;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

string recordCallBackMethod = "RecordCallBackMethod";
collect.RecordCallBackMethod = recordCallBackMethod;

bool? transcribe = false;
collect.Transcribe = transcribe;

string transcribeCallBackUrl = "TranscribeCallBackUrl";
collect.TranscribeCallBackUrl = transcribeCallBackUrl;

var ifMachine = Models.IfMachineEnum?Helper.ParseString("CONTINUE");
collect.IfMachine = ifMachine;

string ifMachineUrl = "IfMachineUrl";
collect.IfMachineUrl = ifMachineUrl;

string ifMachineMethod = "IfMachineMethod";
collect.IfMachineMethod = ifMachineMethod;

bool? feedback = false;
collect.Feedback = feedback;

string surveyId = "SurveyId";
collect.SurveyId = surveyId;


string result = await call.CreateCallsMakecall(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="phone_number_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.PhoneNumberController") PhoneNumberController

### Get singleton instance

The singleton instance of the ``` PhoneNumberController ``` class can be accessed from the API Client.

```csharp
PhoneNumberController phoneNumber = client.PhoneNumber;
```

### <a name="create_incomingphone_getdidscore"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneGetdidscore") CreateIncomingphoneGetdidscore

> Get DID Score Number


```csharp
Task<string> CreateIncomingphoneGetdidscore(string phonenumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | Specifies the multiple phone numbers for check updated spamscore . |


#### Example Usage

```csharp
string phonenumber = "Phonenumber";

string result = await phoneNumber.CreateIncomingphoneGetdidscore(phonenumber);

```


### <a name="create_incomingphone_bulkbuy"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneBulkbuy") CreateIncomingphoneBulkbuy

> Purchase a selected number of DID's from specific area codes to be used with your Ytel account.


```csharp
Task<string> CreateIncomingphoneBulkbuy(Models.CreateIncomingphoneBulkbuyInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numberType |  ``` Required ```  | The capability the number supports. |
| areaCode |  ``` Required ```  | Specifies the area code for the returned list of available numbers. Only available for North American numbers. |
| quantity |  ``` Required ```  | A positive integer that tells how many number you want to buy at a time. |
| leftover |  ``` Optional ```  | If desired quantity is unavailable purchase what is available . |


#### Example Usage

```csharp
CreateIncomingphoneBulkbuyInput collect = new CreateIncomingphoneBulkbuyInput();

var numberType = Models.Numbertype16EnumHelper.ParseString("ALL");
collect.NumberType = numberType;

string areaCode = "AreaCode";
collect.AreaCode = areaCode;

string quantity = "Quantity";
collect.Quantity = quantity;

string leftover = "Leftover";
collect.Leftover = leftover;


string result = await phoneNumber.CreateIncomingphoneBulkbuy(collect);

```


### <a name="create_incomingphone_listnumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneListnumber") CreateIncomingphoneListnumber

> Retrieve a list of purchased phones numbers associated with your Ytel account.


```csharp
Task<string> CreateIncomingphoneListnumber(Models.CreateIncomingphoneListnumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | Which page of the overall response will be returned. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| numberType |  ``` Optional ```  | The capability supported by the number.Number type either SMS,Voice or all |
| friendlyName |  ``` Optional ```  | A human-readable label added to the number object. |


#### Example Usage

```csharp
CreateIncomingphoneListnumberInput collect = new CreateIncomingphoneListnumberInput();

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

var numberType = Models.Numbertype16Enum?Helper.ParseString("ALL");
collect.NumberType = numberType;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;


string result = await phoneNumber.CreateIncomingphoneListnumber(collect);

```


### <a name="create_incomingphone_buynumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneBuynumber") CreateIncomingphoneBuynumber

> Purchase a phone number to be used with your Ytel account


```csharp
Task<string> CreateIncomingphoneBuynumber(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreateIncomingphoneBuynumber(phoneNumber);

```


### <a name="create_incomingphone_releasenumber_by_response_type_post"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneReleasenumberByResponseTypePost") CreateIncomingphoneReleasenumberByResponseTypePost

> Remove a purchased Ytel number from your account.


```csharp
Task<string> CreateIncomingphoneReleasenumberByResponseTypePost(Models.CreateIncomingphoneReleasenumberByResponseTypePostInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |
| responseType |  ``` Required ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateIncomingphoneReleasenumberByResponseTypePostInput collect = new CreateIncomingphoneReleasenumberByResponseTypePostInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "ResponseType";
collect.ResponseType = responseType;


string result = await phoneNumber.CreateIncomingphoneReleasenumberByResponseTypePost(collect);

```


### <a name="create_incomingphone_viewnumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneViewnumber") CreateIncomingphoneViewnumber

> Retrieve the details for a phone number by its number.


```csharp
Task<string> CreateIncomingphoneViewnumber(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel 10-digit phone number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreateIncomingphoneViewnumber(phoneNumber);

```


### <a name="create_incomingphone_transferphonenumbers"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneTransferphonenumbers") CreateIncomingphoneTransferphonenumbers

> Transfer phone number that has been purchased for from one account to another account.


```csharp
Task<string> CreateIncomingphoneTransferphonenumbers(Models.CreateIncomingphoneTransferphonenumbersInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |
| fromaccountsid |  ``` Required ```  | A specific Accountsid from where Number is getting transfer. |
| toaccountsid |  ``` Required ```  | A specific Accountsid to which Number is getting transfer. |


#### Example Usage

```csharp
CreateIncomingphoneTransferphonenumbersInput collect = new CreateIncomingphoneTransferphonenumbersInput();

string phonenumber = "phonenumber";
collect.Phonenumber = phonenumber;

string fromaccountsid = "fromaccountsid";
collect.Fromaccountsid = fromaccountsid;

string toaccountsid = "toaccountsid";
collect.Toaccountsid = toaccountsid;


string result = await phoneNumber.CreateIncomingphoneTransferphonenumbers(collect);

```


### <a name="create_incomingphone_massreleasenumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneMassreleasenumber") CreateIncomingphoneMassreleasenumber

> Remove a purchased Ytel number from your account.


```csharp
Task<string> CreateIncomingphoneMassreleasenumber(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel comma separated numbers (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreateIncomingphoneMassreleasenumber(phoneNumber);

```


### <a name="create_incomingphone_massupdatenumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneMassupdatenumber") CreateIncomingphoneMassupdatenumber

> Update properties for a Ytel numbers that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.


```csharp
Task<string> CreateIncomingphoneMassupdatenumber(Models.CreateIncomingphoneMassupdatenumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid comma(,) separated Ytel numbers. (E.164 format). |
| voiceUrl |  ``` Required ```  | The URL returning InboundXML incoming calls should execute when connected. |
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
CreateIncomingphoneMassupdatenumberInput collect = new CreateIncomingphoneMassupdatenumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string voiceUrl = "VoiceUrl";
collect.VoiceUrl = voiceUrl;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string voiceMethod = "VoiceMethod";
collect.VoiceMethod = voiceMethod;

string voiceFallbackUrl = "VoiceFallbackUrl";
collect.VoiceFallbackUrl = voiceFallbackUrl;

string voiceFallbackMethod = "VoiceFallbackMethod";
collect.VoiceFallbackMethod = voiceFallbackMethod;

string hangupCallback = "HangupCallback";
collect.HangupCallback = hangupCallback;

string hangupCallbackMethod = "HangupCallbackMethod";
collect.HangupCallbackMethod = hangupCallbackMethod;

string heartbeatUrl = "HeartbeatUrl";
collect.HeartbeatUrl = heartbeatUrl;

string heartbeatMethod = "HeartbeatMethod";
collect.HeartbeatMethod = heartbeatMethod;

string smsUrl = "SmsUrl";
collect.SmsUrl = smsUrl;

string smsMethod = "SmsMethod";
collect.SmsMethod = smsMethod;

string smsFallbackUrl = "SmsFallbackUrl";
collect.SmsFallbackUrl = smsFallbackUrl;

string smsFallbackMethod = "SmsFallbackMethod";
collect.SmsFallbackMethod = smsFallbackMethod;


string result = await phoneNumber.CreateIncomingphoneMassupdatenumber(collect);

```


### <a name="create_incomingphone_updatenumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneUpdatenumber") CreateIncomingphoneUpdatenumber

> Update properties for a Ytel number that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.


```csharp
Task<string> CreateIncomingphoneUpdatenumber(Models.CreateIncomingphoneUpdatenumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel number (E.164 format). |
| voiceUrl |  ``` Required ```  | URL requested once the call connects |
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
CreateIncomingphoneUpdatenumberInput collect = new CreateIncomingphoneUpdatenumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string voiceUrl = "VoiceUrl";
collect.VoiceUrl = voiceUrl;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string voiceMethod = "VoiceMethod";
collect.VoiceMethod = voiceMethod;

string voiceFallbackUrl = "VoiceFallbackUrl";
collect.VoiceFallbackUrl = voiceFallbackUrl;

string voiceFallbackMethod = "VoiceFallbackMethod";
collect.VoiceFallbackMethod = voiceFallbackMethod;

string hangupCallback = "HangupCallback";
collect.HangupCallback = hangupCallback;

string hangupCallbackMethod = "HangupCallbackMethod";
collect.HangupCallbackMethod = hangupCallbackMethod;

string heartbeatUrl = "HeartbeatUrl";
collect.HeartbeatUrl = heartbeatUrl;

string heartbeatMethod = "HeartbeatMethod";
collect.HeartbeatMethod = heartbeatMethod;

string smsUrl = "SmsUrl";
collect.SmsUrl = smsUrl;

string smsMethod = "SmsMethod";
collect.SmsMethod = smsMethod;

string smsFallbackUrl = "SmsFallbackUrl";
collect.SmsFallbackUrl = smsFallbackUrl;

string smsFallbackMethod = "SmsFallbackMethod";
collect.SmsFallbackMethod = smsFallbackMethod;


string result = await phoneNumber.CreateIncomingphoneUpdatenumber(collect);

```


### <a name="create_incomingphone_availablenumber"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.PhoneNumberController.CreateIncomingphoneAvailablenumber") CreateIncomingphoneAvailablenumber

> Retrieve a list of available phone numbers that can be purchased and used for your Ytel account.


```csharp
Task<string> CreateIncomingphoneAvailablenumber(Models.CreateIncomingphoneAvailablenumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numbertype |  ``` Required ```  | Number type either SMS,Voice or all |
| areacode |  ``` Required ```  | Specifies the area code for the returned list of available numbers. Only available for North American numbers. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return. |


#### Example Usage

```csharp
CreateIncomingphoneAvailablenumberInput collect = new CreateIncomingphoneAvailablenumberInput();

var numbertype = Models.Numbertype16EnumHelper.ParseString("ALL");
collect.Numbertype = numbertype;

string areacode = "areacode";
collect.Areacode = areacode;

int? pagesize = 10;
collect.Pagesize = pagesize;


string result = await phoneNumber.CreateIncomingphoneAvailablenumber(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sms_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.SMSController") SMSController

### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
SMSController sMS = client.SMS;
```

### <a name="create_sms_viewdetailsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SMSController.CreateSmsViewdetailsms") CreateSmsViewdetailsms

> Retrieve a single SMS message object with details by its SmsSid.


```csharp
Task<string> CreateSmsViewdetailsms(string messageSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for a sms message. |


#### Example Usage

```csharp
string messageSid = "MessageSid";

string result = await sMS.CreateSmsViewdetailsms(messageSid);

```


### <a name="create_sms_viewsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SMSController.CreateSmsViewsms") CreateSmsViewsms

> Retrieve a single SMS message object by its SmsSid.


```csharp
Task<string> CreateSmsViewsms(string messageSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for a sms message. |


#### Example Usage

```csharp
string messageSid = "MessageSid";

string result = await sMS.CreateSmsViewsms(messageSid);

```


### <a name="create_sms_getinboundsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SMSController.CreateSmsGetinboundsms") CreateSmsGetinboundsms

> Retrieve a list of Inbound SMS message objects.


```csharp
Task<string> CreateSmsGetinboundsms(Models.CreateSmsGetinboundsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| mfrom |  ``` Optional ```  | Filter SMS message objects from this valid 10-digit phone number (E.164 format). |
| to |  ``` Optional ```  | Filter SMS message objects to this valid 10-digit phone number (E.164 format). |
| dateSent |  ``` Optional ```  | Filter sms message objects by this date. |


#### Example Usage

```csharp
CreateSmsGetinboundsmsInput collect = new CreateSmsGetinboundsmsInput();

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


string result = await sMS.CreateSmsGetinboundsms(collect);

```


### <a name="create_sms_listsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SMSController.CreateSmsListsms") CreateSmsListsms

> Retrieve a list of Outbound SMS message objects.


```csharp
Task<string> CreateSmsListsms(Models.CreateSmsListsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Filter SMS message objects from this valid 10-digit phone number (E.164 format). |
| to |  ``` Optional ```  | Filter SMS message objects to this valid 10-digit phone number (E.164 format). |
| dateSent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |


#### Example Usage

```csharp
CreateSmsListsmsInput collect = new CreateSmsListsmsInput();

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


string result = await sMS.CreateSmsListsms(collect);

```


### <a name="create_sms_sendsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SMSController.CreateSmsSendsms") CreateSmsSendsms

> Send an SMS from a Ytel number


```csharp
Task<string> CreateSmsSendsms(Models.CreateSmsSendsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | The 10-digit SMS-enabled Ytel number (E.164 format) in which the message is sent. |
| to |  ``` Required ```  | The 10-digit phone number (E.164 format) that will receive the message. |
| body |  ``` Required ```  | The body message that is to be sent in the text. |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once SMS sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished. |
| smartsms |  ``` Optional ```  ``` DefaultValue ```  | Check's 'to' number can receive sms or not using Carrier API, if wireless = true then text sms is sent, else wireless = false then call is recieved to end user with audible message. |
| deliveryStatus |  ``` Optional ```  ``` DefaultValue ```  | Delivery reports are a method to tell your system if the message has arrived on the destination phone. |


#### Example Usage

```csharp
CreateSmsSendsmsInput collect = new CreateSmsSendsmsInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string body = "Body";
collect.Body = body;

string method = "Method";
collect.Method = method;

string messageStatusCallback = "MessageStatusCallback";
collect.MessageStatusCallback = messageStatusCallback;

bool? smartsms = false;
collect.Smartsms = smartsms;

bool? deliveryStatus = false;
collect.DeliveryStatus = deliveryStatus;


string result = await sMS.CreateSmsSendsms(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="shared_short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.SharedShortCodeController") SharedShortCodeController

### Get singleton instance

The singleton instance of the ``` SharedShortCodeController ``` class can be accessed from the API Client.

```csharp
SharedShortCodeController sharedShortCode = client.SharedShortCode;
```

### <a name="create_shortcode_viewshortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateShortcodeViewshortcode") CreateShortcodeViewshortcode

> The response returned here contains all resource properties associated with the given Shortcode.


```csharp
Task<string> CreateShortcodeViewshortcode(string shortcode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Shortcode to your Ytel account |


#### Example Usage

```csharp
string shortcode = "Shortcode";

string result = await sharedShortCode.CreateShortcodeViewshortcode(shortcode);

```


### <a name="create_keyword_view"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateKeywordView") CreateKeywordView

> View a set of properties for a single keyword.


```csharp
Task<string> CreateKeywordView(string keywordid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| keywordid |  ``` Required ```  | The unique identifier of each keyword |


#### Example Usage

```csharp
string keywordid = "Keywordid";

string result = await sharedShortCode.CreateKeywordView(keywordid);

```


### <a name="create_shortcode_updateshortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateShortcodeUpdateshortcode") CreateShortcodeUpdateshortcode

> Update Assignment


```csharp
Task<string> CreateShortcodeUpdateshortcode(Models.CreateShortcodeUpdateshortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid shortcode to your Ytel account |
| friendlyName |  ``` Optional ```  | User generated name of the shortcode |
| callbackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| callbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |
| fallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST. |
| fallbackUrlMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |


#### Example Usage

```csharp
CreateShortcodeUpdateshortcodeInput collect = new CreateShortcodeUpdateshortcodeInput();

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string callbackUrl = "CallbackUrl";
collect.CallbackUrl = callbackUrl;

string callbackMethod = "CallbackMethod";
collect.CallbackMethod = callbackMethod;

string fallbackUrl = "FallbackUrl";
collect.FallbackUrl = fallbackUrl;

string fallbackUrlMethod = "FallbackUrlMethod";
collect.FallbackUrlMethod = fallbackUrlMethod;


string result = await sharedShortCode.CreateShortcodeUpdateshortcode(collect);

```


### <a name="create_template_view"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateTemplateView") CreateTemplateView

> View a Shared ShortCode Template


```csharp
Task<string> CreateTemplateView(Guid templateId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| templateId |  ``` Required ```  | The unique identifier for a template object |


#### Example Usage

```csharp
Guid templateId = Guid.NewGuid();

string result = await sharedShortCode.CreateTemplateView(templateId);

```


### <a name="create_shortcode_listshortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateShortcodeListshortcode") CreateShortcodeListshortcode

> Retrieve a list of shortcode assignment associated with your Ytel account.


```csharp
Task<string> CreateShortcodeListshortcode(Models.CreateShortcodeListshortcodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
CreateShortcodeListshortcodeInput collect = new CreateShortcodeListshortcodeInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;


string result = await sharedShortCode.CreateShortcodeListshortcode(collect);

```


### <a name="create_keyword_lists"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateKeywordLists") CreateKeywordLists

> Retrieve a list of keywords associated with your Ytel account.


```csharp
Task<string> CreateKeywordLists(Models.CreateKeywordListsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| keyword |  ``` Optional ```  | Only list keywords of keyword |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
CreateKeywordListsInput collect = new CreateKeywordListsInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string keyword = "Keyword";
collect.Keyword = keyword;

int? shortcode = 35;
collect.Shortcode = shortcode;


string result = await sharedShortCode.CreateKeywordLists(collect);

```


### <a name="create_template_lists"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateTemplateLists") CreateTemplateLists

> List Shortcode Templates by Type


```csharp
Task<string> CreateTemplateLists(Models.CreateTemplateListsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Optional ```  ``` DefaultValue ```  | The type (category) of template Valid values: marketing, authorization |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| shortcode |  ``` Optional ```  | Only list templates of type |


#### Example Usage

```csharp
CreateTemplateListsInput collect = new CreateTemplateListsInput();

string type = "authorization";
collect.Type = type;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;


string result = await sharedShortCode.CreateTemplateLists(collect);

```


### <a name="create_shortcode_sendsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateShortcodeSendsms") CreateShortcodeSendsms

> Send an SMS from a Ytel ShortCode


```csharp
Task<string> CreateShortcodeSendsms(Models.CreateShortcodeSendsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | The Short Code number that is the sender of this message |
| to |  ``` Required ```  | A valid 10-digit number that should receive the message |
| templateid |  ``` Required ```  | The unique identifier for the template used for the message |
| data |  ``` Required ```  | format of your data, example: {companyname}:test,{otpcode}:1234 |
| method |  ``` Optional ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |


#### Example Usage

```csharp
CreateShortcodeSendsmsInput collect = new CreateShortcodeSendsmsInput();

string shortcode = "shortcode";
collect.Shortcode = shortcode;

string to = "to";
collect.To = to;

Guid templateid = Guid.NewGuid();
collect.Templateid = templateid;

string data = "data";
collect.Data = data;

string method = "GET";
collect.Method = method;

string messageStatusCallback = "MessageStatusCallback";
collect.MessageStatusCallback = messageStatusCallback;


string result = await sharedShortCode.CreateShortcodeSendsms(collect);

```


### <a name="create_shortcode_getinboundsms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SharedShortCodeController.CreateShortcodeGetinboundsms") CreateShortcodeGetinboundsms

> List All Inbound ShortCode


```csharp
Task<string> CreateShortcodeGetinboundsms(Models.CreateShortcodeGetinboundsmsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound ShortCode |
| shortcode |  ``` Optional ```  | Only list messages sent to this Short Code |
| datecreated |  ``` Optional ```  | Only list messages sent with the specified date |


#### Example Usage

```csharp
CreateShortcodeGetinboundsmsInput collect = new CreateShortcodeGetinboundsmsInput();

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


string result = await sharedShortCode.CreateShortcodeGetinboundsms(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="conference_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.ConferenceController") ConferenceController

### Get singleton instance

The singleton instance of the ``` ConferenceController ``` class can be accessed from the API Client.

```csharp
ConferenceController conference = client.Conference;
```

### <a name="create_conferences_play_audio"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesPlayAudio") CreateConferencesPlayAudio

> Play an audio file during a conference.


```csharp
Task<string> CreateConferencesPlayAudio(Models.CreateConferencesPlayAudioInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |
| audioUrl |  ``` Required ```  | The URL for the audio file that is to be played during the conference. Multiple audio files can be chained by using a semicolon. |


#### Example Usage

```csharp
CreateConferencesPlayAudioInput collect = new CreateConferencesPlayAudioInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

var audioUrl = Models.AudioUrlEnumHelper.ParseString("mp3");
collect.AudioUrl = audioUrl;


string result = await conference.CreateConferencesPlayAudio(collect);

```


### <a name="create_conferences_hangup_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesHangupParticipant") CreateConferencesHangupParticipant

> Remove a participant from a conference.


```csharp
Task<string> CreateConferencesHangupParticipant(Models.CreateConferencesHangupParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |


#### Example Usage

```csharp
CreateConferencesHangupParticipantInput collect = new CreateConferencesHangupParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;


string result = await conference.CreateConferencesHangupParticipant(collect);

```


### <a name="create_conferences_viewconference"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesViewconference") CreateConferencesViewconference

> Retrieve information about a conference by its ConferenceSid.


```csharp
Task<string> CreateConferencesViewconference(string conferenceSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier of each conference resource |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";

string result = await conference.CreateConferencesViewconference(conferenceSid);

```


### <a name="create_conferences_listconference"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesListconference") CreateConferencesListconference

> Retrieve a list of conference objects.


```csharp
Task<string> CreateConferencesListconference(Models.CreateConferencesListconferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| friendlyName |  ``` Optional ```  | Only return conferences with the specified FriendlyName |
| dateCreated |  ``` Optional ```  | Conference created date |


#### Example Usage

```csharp
CreateConferencesListconferenceInput collect = new CreateConferencesListconferenceInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;


string result = await conference.CreateConferencesListconference(collect);

```


### <a name="create_conferences_list_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesListParticipant") CreateConferencesListParticipant

> Retrieve a list of participants for an in-progress conference.


```csharp
Task<string> CreateConferencesListParticipant(Models.CreateConferencesListParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference. |
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| muted |  ``` Optional ```  | Specifies if participant should be muted. |
| deaf |  ``` Optional ```  | Specifies if the participant should hear audio in the conference. |


#### Example Usage

```csharp
CreateConferencesListParticipantInput collect = new CreateConferencesListParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.CreateConferencesListParticipant(collect);

```


### <a name="create_conferences_view_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesViewParticipant") CreateConferencesViewParticipant

> Retrieve information about a participant by its ParticipantSid.


```csharp
Task<string> CreateConferencesViewParticipant(Models.CreateConferencesViewParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |


#### Example Usage

```csharp
CreateConferencesViewParticipantInput collect = new CreateConferencesViewParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;


string result = await conference.CreateConferencesViewParticipant(collect);

```


### <a name="create_conferences_add_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesAddParticipant") CreateConferencesAddParticipant

> Add Participant in conference 


```csharp
Task<string> CreateConferencesAddParticipant(Models.CreateConferencesAddParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantNumber |  ``` Required ```  | The phone number of the participant to be added. |
| muted |  ``` Optional ```  | Specifies if participant should be muted. |
| deaf |  ``` Optional ```  | Specifies if the participant should hear audio in the conference. |


#### Example Usage

```csharp
CreateConferencesAddParticipantInput collect = new CreateConferencesAddParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantNumber = "ParticipantNumber";
collect.ParticipantNumber = participantNumber;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.CreateConferencesAddParticipant(collect);

```


### <a name="create_conferences_create_conference"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesCreateConference") CreateConferencesCreateConference

> Here you can experiment with initiating a conference call through Ytel and view the request response generated when doing so.


```csharp
Task<string> CreateConferencesCreateConference(Models.CreateConferencesCreateConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid 10-digit number (E.164 format) that will be initiating the conference call. |
| to |  ``` Required ```  | A valid 10-digit number (E.164 format) that is to receive the conference call. |
| url |  ``` Required ```  | URL requested once the conference connects |
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
CreateConferencesCreateConferenceInput collect = new CreateConferencesCreateConferenceInput();

string mfrom = "From";
collect.Mfrom = mfrom;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

string method = "POST";
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

string statusCallBackMethod = "StatusCallBackMethod";
collect.StatusCallBackMethod = statusCallBackMethod;

string fallbackUrl = "FallbackUrl";
collect.FallbackUrl = fallbackUrl;

string fallbackMethod = "FallbackMethod";
collect.FallbackMethod = fallbackMethod;

bool? record = false;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

string recordCallBackMethod = "RecordCallBackMethod";
collect.RecordCallBackMethod = recordCallBackMethod;

string scheduleTime = "ScheduleTime";
collect.ScheduleTime = scheduleTime;

int? timeout = 35;
collect.Timeout = timeout;


string result = await conference.CreateConferencesCreateConference(collect);

```


### <a name="create_conferences_deaf_mute_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.ConferenceController.CreateConferencesDeafMuteParticipant") CreateConferencesDeafMuteParticipant

> Deaf Mute Participant


```csharp
Task<string> CreateConferencesDeafMuteParticipant(Models.CreateConferencesDeafMuteParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | ID of the active conference |
| participantSid |  ``` Required ```  | ID of an active participant |
| muted |  ``` Optional ```  | Mute a participant |
| deaf |  ``` Optional ```  | Make it so a participant cant hear |


#### Example Usage

```csharp
CreateConferencesDeafMuteParticipantInput collect = new CreateConferencesDeafMuteParticipantInput();

string conferenceSid = "conferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;


string result = await conference.CreateConferencesDeafMuteParticipant(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="carrier_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.CarrierController") CarrierController

### Get singleton instance

The singleton instance of the ``` CarrierController ``` class can be accessed from the API Client.

```csharp
CarrierController carrier = client.Carrier;
```

### <a name="create_carrier_lookup"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CarrierController.CreateCarrierLookup") CreateCarrierLookup

> Get the Carrier Lookup


```csharp
Task<string> CreateCarrierLookup(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await carrier.CreateCarrierLookup(phoneNumber);

```


### <a name="create_carrier_lookuplist"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.CarrierController.CreateCarrierLookuplist") CreateCarrierLookuplist

> Retrieve a list of carrier lookup objects.


```csharp
Task<string> CreateCarrierLookuplist(Models.CreateCarrierLookuplistInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |


#### Example Usage

```csharp
CreateCarrierLookuplistInput collect = new CreateCarrierLookuplistInput();

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;


string result = await carrier.CreateCarrierLookuplist(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="email_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.EmailController") EmailController

### Get singleton instance

The singleton instance of the ``` EmailController ``` class can be accessed from the API Client.

```csharp
EmailController email = client.Email;
```

### <a name="create_email_deleteinvalidemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailDeleteinvalidemail") CreateEmailDeleteinvalidemail

> Remove an email from the invalid email list.


```csharp
Task<string> CreateEmailDeleteinvalidemail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the invalid email list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateEmailDeleteinvalidemail(email);

```


### <a name="create_email_listblockemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailListblockemail") CreateEmailListblockemail

> Retrieve a list of emails that have been blocked.


```csharp
Task<string> CreateEmailListblockemail(Models.CreateEmailListblockemailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of blocked emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
CreateEmailListblockemailInput collect = new CreateEmailListblockemailInput();

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.CreateEmailListblockemail(collect);

```


### <a name="create_email_listspamemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailListspamemail") CreateEmailListspamemail

> Retrieve a list of emails that are on the spam list.


```csharp
Task<string> CreateEmailListspamemail(Models.CreateEmailListspamemailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of spam emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
CreateEmailListspamemailInput collect = new CreateEmailListspamemailInput();

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.CreateEmailListspamemail(collect);

```


### <a name="create_email_listbounceemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailListbounceemail") CreateEmailListbounceemail

> Retrieve a list of emails that have bounced.


```csharp
Task<string> CreateEmailListbounceemail(Models.CreateEmailListbounceemailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of bounced emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
CreateEmailListbounceemailInput collect = new CreateEmailListbounceemailInput();

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.CreateEmailListbounceemail(collect);

```


### <a name="create_email_deletebouncesemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailDeletebouncesemail") CreateEmailDeletebouncesemail

> Remove an email address from the bounced list.


```csharp
Task<string> CreateEmailDeletebouncesemail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address to be remove from the bounced email list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateEmailDeletebouncesemail(email);

```


### <a name="create_email_listinvalidemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailListinvalidemail") CreateEmailListinvalidemail

> Retrieve a list of invalid email addresses.


```csharp
Task<string> CreateEmailListinvalidemail(Models.CreateEmailListinvalidemailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of invalid emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
CreateEmailListinvalidemailInput collect = new CreateEmailListinvalidemailInput();

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.CreateEmailListinvalidemail(collect);

```


### <a name="create_email_listunsubscribedemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailListunsubscribedemail") CreateEmailListunsubscribedemail

> Retrieve a list of email addresses from the unsubscribe list.


```csharp
Task<string> CreateEmailListunsubscribedemail(Models.CreateEmailListunsubscribedemailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of unsubscribed emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
CreateEmailListunsubscribedemailInput collect = new CreateEmailListunsubscribedemailInput();

string offset = "Offset";
collect.Offset = offset;

string limit = "Limit";
collect.Limit = limit;


string result = await email.CreateEmailListunsubscribedemail(collect);

```


### <a name="create_email_deleteunsubscribedemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailDeleteunsubscribedemail") CreateEmailDeleteunsubscribedemail

> Remove an email address from the list of unsubscribed emails.


```csharp
Task<string> CreateEmailDeleteunsubscribedemail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the unsubscribe list. |


#### Example Usage

```csharp
string email = "email";

string result = await email.CreateEmailDeleteunsubscribedemail(email);

```


### <a name="create_email_addunsubscribesemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailAddunsubscribesemail") CreateEmailAddunsubscribesemail

> Add an email to the unsubscribe list


```csharp
Task<string> CreateEmailAddunsubscribesemail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be added to the unsubscribe list |


#### Example Usage

```csharp
string email = "email";

string result = await email.CreateEmailAddunsubscribesemail(email);

```


### <a name="create_email_deleteblocksemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailDeleteblocksemail") CreateEmailDeleteblocksemail

> Remove an email from blocked emails list.


```csharp
Task<string> CreateEmailDeleteblocksemail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address to be remove from the blocked list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateEmailDeleteblocksemail(email);

```


### <a name="create_email_deletespamemail"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailDeletespamemail") CreateEmailDeletespamemail

> Remove an email from the spam email list.


```csharp
Task<string> CreateEmailDeletespamemail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the spam list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateEmailDeletespamemail(email);

```


### <a name="create_email_sendemails"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.EmailController.CreateEmailSendemails") CreateEmailSendemails

> Create and submit an email message to one or more email addresses.


```csharp
Task<string> CreateEmailSendemails(Models.CreateEmailSendemailsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| type |  ``` Required ```  | Specifies the type of email to be sent |
| subject |  ``` Required ```  | The subject of the mail. Must be a valid string. |
| message |  ``` Required ```  | The email message that is to be sent in the text. |
| mfrom |  ``` Optional ```  | A valid address that will send the email. |
| cc |  ``` Optional ```  | Carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| bcc |  ``` Optional ```  | Blind carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| attachment |  ``` Optional ```  | A file that is attached to the email. Must be less than 7 MB in size. |


#### Example Usage

```csharp
CreateEmailSendemailsInput collect = new CreateEmailSendemailsInput();

string to = "To";
collect.To = to;

var type = Models.TypeEnumHelper.ParseString("TEXT");
collect.Type = type;

string subject = "Subject";
collect.Subject = subject;

string message = "Message";
collect.Message = message;

string mfrom = "From";
collect.Mfrom = mfrom;

string cc = "Cc";
collect.Cc = cc;

string bcc = "Bcc";
collect.Bcc = bcc;

string attachment = "Attachment";
collect.Attachment = attachment;


string result = await email.CreateEmailSendemails(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="account_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.AccountController") AccountController

### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

### <a name="create_accounts_viewaccount"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AccountController.CreateAccountsViewaccount") CreateAccountsViewaccount

> Retrieve information regarding your Ytel account by a specific date. The response object will contain data such as account status, balance, and account usage totals.


```csharp
Task<string> CreateAccountsViewaccount(string date)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Required ```  | Filter account information based on date. |


#### Example Usage

```csharp
string date = "Date";

string result = await account.CreateAccountsViewaccount(date);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sub_account_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.SubAccountController") SubAccountController

### Get singleton instance

The singleton instance of the ``` SubAccountController ``` class can be accessed from the API Client.

```csharp
SubAccountController subAccount = client.SubAccount;
```

### <a name="create_user_subaccountactivation"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SubAccountController.CreateUserSubaccountactivation") CreateUserSubaccountactivation

> Suspend or unsuspend


```csharp
Task<string> CreateUserSubaccountactivation(Models.CreateUserSubaccountactivationInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be activated or suspended |
| mActivate |  ``` Required ```  | 0 to suspend or 1 to activate |


#### Example Usage

```csharp
CreateUserSubaccountactivationInput collect = new CreateUserSubaccountactivationInput();

string subAccountSID = "SubAccountSID";
collect.SubAccountSID = subAccountSID;

var mActivate = (Models.MActivateEnum)1;
collect.MActivate = mActivate;


string result = await subAccount.CreateUserSubaccountactivation(collect);

```


### <a name="create_user_deletesubaccount"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SubAccountController.CreateUserDeletesubaccount") CreateUserDeletesubaccount

> Delete sub account or merge numbers into parent


```csharp
Task<string> CreateUserDeletesubaccount(Models.CreateUserDeletesubaccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be deleted |
| mergeNumber |  ``` Required ```  | 0 to delete or 1 to merge numbers to parent account. |


#### Example Usage

```csharp
CreateUserDeletesubaccountInput collect = new CreateUserDeletesubaccountInput();

string subAccountSID = "SubAccountSID";
collect.SubAccountSID = subAccountSID;

var mergeNumber = (Models.MergeNumberEnum)0;
collect.MergeNumber = mergeNumber;


string result = await subAccount.CreateUserDeletesubaccount(collect);

```


### <a name="create_user_createsubaccount"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.SubAccountController.CreateUserCreatesubaccount") CreateUserCreatesubaccount

> Create a sub user account under the parent account


```csharp
Task<string> CreateUserCreatesubaccount(Models.CreateUserCreatesubaccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| firstName |  ``` Required ```  | Sub account user first name |
| lastName |  ``` Required ```  | sub account user last name |
| email |  ``` Required ```  | Sub account email address |
| friendlyName |  ``` Required ```  | Descriptive name of the sub account |
| password |  ``` Required ```  | The password of the sub account.  Please make sure to make as password that is at least 8 characters long, contain a symbol, uppercase and a number. |


#### Example Usage

```csharp
CreateUserCreatesubaccountInput collect = new CreateUserCreatesubaccountInput();

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


string result = await subAccount.CreateUserCreatesubaccount(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="address_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.AddressController") AddressController

### Get singleton instance

The singleton instance of the ``` AddressController ``` class can be accessed from the API Client.

```csharp
AddressController address = client.Address;
```

### <a name="address_deleteaddress"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AddressController.AddressDeleteaddress") AddressDeleteaddress

> To delete Address to your address book


```csharp
Task<string> AddressDeleteaddress(string addressid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressid |  ``` Required ```  | The identifier of the address to be deleted. |


#### Example Usage

```csharp
string addressid = "addressid";

string result = await address.AddressDeleteaddress(addressid);

```


### <a name="address_verifyaddress"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AddressController.AddressVerifyaddress") AddressVerifyaddress

> Validates an address given.


```csharp
Task<string> AddressVerifyaddress(string addressid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressid |  ``` Required ```  | The identifier of the address to be verified. |


#### Example Usage

```csharp
string addressid = "addressid";

string result = await address.AddressVerifyaddress(addressid);

```


### <a name="address_viewaddress"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AddressController.AddressViewaddress") AddressViewaddress

> View Address Specific address Book by providing the address id


```csharp
Task<string> AddressViewaddress(string addressid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressid |  ``` Required ```  | The identifier of the address to be retrieved. |


#### Example Usage

```csharp
string addressid = "addressid";

string result = await address.AddressViewaddress(addressid);

```


### <a name="address_createaddress"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AddressController.AddressCreateaddress") AddressCreateaddress

> To add an address to your address book, you create a new address object. You can retrieve and delete individual addresses as well as get a list of addresses. Addresses are identified by a unique random ID.


```csharp
Task<string> AddressCreateaddress(Models.AddressCreateaddressInput input)
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
| description |  ``` Optional ```  | Description of addresses. |
| email |  ``` Optional ```  | Email Id of user. |
| phone |  ``` Optional ```  | Phone number of user. |


#### Example Usage

```csharp
AddressCreateaddressInput collect = new AddressCreateaddressInput();

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

string description = "Description";
collect.Description = description;

string email = "email";
collect.Email = email;

string phone = "Phone";
collect.Phone = phone;


string result = await address.AddressCreateaddress(collect);

```


### <a name="address_listaddress"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.AddressController.AddressListaddress") AddressListaddress

> List All Address 


```csharp
Task<string> AddressListaddress(Models.AddressListaddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | How many results to return, default is 10, max is 100, must be an integer |
| addressid |  ``` Optional ```  | addresses Sid |
| dateCreated |  ``` Optional ```  | date created address. |


#### Example Usage

```csharp
AddressListaddressInput collect = new AddressListaddressInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string addressid = "addressid";
collect.Addressid = addressid;

string dateCreated = "dateCreated";
collect.DateCreated = dateCreated;


string result = await address.AddressListaddress(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="recording_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.RecordingController") RecordingController

### Get singleton instance

The singleton instance of the ``` RecordingController ``` class can be accessed from the API Client.

```csharp
RecordingController recording = client.Recording;
```

### <a name="create_recording_deleterecording"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.RecordingController.CreateRecordingDeleterecording") CreateRecordingDeleterecording

> Remove a recording from your Ytel account.


```csharp
Task<string> CreateRecordingDeleterecording(string recordingsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingsid |  ``` Required ```  | The unique identifier for a recording. |


#### Example Usage

```csharp
string recordingsid = "recordingsid";

string result = await recording.CreateRecordingDeleterecording(recordingsid);

```


### <a name="create_recording_viewrecording"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.RecordingController.CreateRecordingViewrecording") CreateRecordingViewrecording

> Retrieve the recording of a call by its RecordingSid. This resource will return information regarding the call such as start time, end time, duration, and so forth.


```csharp
Task<string> CreateRecordingViewrecording(string recordingsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingsid |  ``` Required ```  | The unique identifier for the recording. |


#### Example Usage

```csharp
string recordingsid = "recordingsid";

string result = await recording.CreateRecordingViewrecording(recordingsid);

```


### <a name="create_recording_listrecording"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.RecordingController.CreateRecordingListrecording") CreateRecordingListrecording

> Retrieve a list of recording objects.


```csharp
Task<string> CreateRecordingListrecording(Models.CreateRecordingListrecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| datecreated |  ``` Optional ```  | Filter results by creation date |
| callsid |  ``` Optional ```  | The unique identifier for a call. |


#### Example Usage

```csharp
CreateRecordingListrecordingInput collect = new CreateRecordingListrecordingInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string datecreated = "Datecreated";
collect.Datecreated = datecreated;

string callsid = "callsid";
collect.Callsid = callsid;


string result = await recording.CreateRecordingListrecording(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="transcription_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.TranscriptionController") TranscriptionController

### Get singleton instance

The singleton instance of the ``` TranscriptionController ``` class can be accessed from the API Client.

```csharp
TranscriptionController transcription = client.Transcription;
```

### <a name="create_transcriptions_audiourltranscription"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.TranscriptionController.CreateTranscriptionsAudiourltranscription") CreateTranscriptionsAudiourltranscription

> Transcribe an audio recording from a file.


```csharp
Task<string> CreateTranscriptionsAudiourltranscription(string audiourl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| audiourl |  ``` Required ```  | URL pointing to the location of the audio file that is to be transcribed. |


#### Example Usage

```csharp
string audiourl = "audiourl";

string result = await transcription.CreateTranscriptionsAudiourltranscription(audiourl);

```


### <a name="create_transcriptions_recordingtranscription"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.TranscriptionController.CreateTranscriptionsRecordingtranscription") CreateTranscriptionsRecordingtranscription

> Transcribe a recording by its RecordingSid.


```csharp
Task<string> CreateTranscriptionsRecordingtranscription(string recordingSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | The unique identifier for a recording object. |


#### Example Usage

```csharp
string recordingSid = "recordingSid";

string result = await transcription.CreateTranscriptionsRecordingtranscription(recordingSid);

```


### <a name="create_transcriptions_viewtranscription"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.TranscriptionController.CreateTranscriptionsViewtranscription") CreateTranscriptionsViewtranscription

> Retrieve information about a transaction by its TranscriptionSid.


```csharp
Task<string> CreateTranscriptionsViewtranscription(string transcriptionsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transcriptionsid |  ``` Required ```  | The unique identifier for a transcription object. |


#### Example Usage

```csharp
string transcriptionsid = "transcriptionsid";

string result = await transcription.CreateTranscriptionsViewtranscription(transcriptionsid);

```


### <a name="create_transcriptions_listtranscription"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.TranscriptionController.CreateTranscriptionsListtranscription") CreateTranscriptionsListtranscription

> Retrieve a list of transcription objects for your Ytel account.


```csharp
Task<string> CreateTranscriptionsListtranscription(Models.CreateTranscriptionsListtranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| status |  ``` Optional ```  | The state of the transcription. |
| dateTranscribed |  ``` Optional ```  | The date the transcription took place. |


#### Example Usage

```csharp
CreateTranscriptionsListtranscriptionInput collect = new CreateTranscriptionsListtranscriptionInput();

int? page = 1;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

var status = Models.StatusEnum?Helper.ParseString("INPROGRESS");
collect.Status = status;

string dateTranscribed = "dateTranscribed";
collect.DateTranscribed = dateTranscribed;


string result = await transcription.CreateTranscriptionsListtranscription(collect);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="usage_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Standard.Controllers.UsageController") UsageController

### Get singleton instance

The singleton instance of the ``` UsageController ``` class can be accessed from the API Client.

```csharp
UsageController usage = client.Usage;
```

### <a name="create_usage_listusage"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Standard.Controllers.UsageController.CreateUsageListusage") CreateUsageListusage

> Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests.


```csharp
Task<string> CreateUsageListusage(Models.CreateUsageListusageInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| productCode |  ``` Optional ```  ``` DefaultValue ```  | Filter usage results by product type. |
| startDate |  ``` Optional ```  ``` DefaultValue ```  | Filter usage objects by start date. |
| endDate |  ``` Optional ```  ``` DefaultValue ```  | Filter usage objects by end date. |
| includeSubAccounts |  ``` Optional ```  | Will include all subaccount usage data |


#### Example Usage

```csharp
CreateUsageListusageInput collect = new CreateUsageListusageInput();

var productCode = (Models.ProductCode27Enum?)0;
collect.ProductCode = productCode;

string startDate = "2016-09-06";
collect.StartDate = startDate;

string endDate = "2016-09-06";
collect.EndDate = endDate;

string includeSubAccounts = "IncludeSubAccounts";
collect.IncludeSubAccounts = includeSubAccounts;


string result = await usage.CreateUsageListusage(collect);

```


[Back to List of Controllers](#list_of_controllers)



