# Clova CEK SDK C#

C# SDK for Clova Extension Kit

# Getting Started

1\. Instantiate Client

```csharp
client = new ClovaClient();
```

2\. Pass Signature Header and Body to client to get CEK Request.

```csharp
var request = await client.GetRequest(Request.Headers["SignatureCEK"], Request.Body);
```

3\. Create CEK response.

```csharp
var response = new CEKResponse();
```

4\. Add Reply. *Lang.Ja by default.

```csharp
response.AddText("こんにちは!");
response.AddUrl("https://dummy.domain/myaudio.mp3");
response.AddText("Hi!", Lang.En);
response.AddUrl("https://dummy.domain/myaudio.mp3", Lang.En);
```

5\. Add Brief/Verbose.

```csharp
response.AddBriefText("Brief explain.", Lang.En);
response.AddVerboseText("Detail explain 1.", Lang.En);
response.AddVerboseText("Detail explain 2.", Lang.En);
response.AddVerboseUrl("https://dummy.domain/myaudio.mp3");
```

6\. Add Reprompt.

```csharp
response.AddRepromptText("Tell me something, please", Lang.En);
response.AddRepromptUrl("https://dummy.domain/myaudio.mp3");
```
7\. Add session value.

```csharp
response.SetSession("mySessionKey", "mySessionValue");
```

8\. Get the session value. The default value returns if no session infromation exists.

```csharp
var mySessionValue = request.GetSessionAttribute("mySessionValue", "defaultValue");
```

# Sample
Following sample illustrate how to check incoming request type and handle appropriately.

```csharp
switch (request.Request.Type)
{
    case RequestType.LaunchRequest:
        // Single Text Reply
        response.AddText("Welcome to CEK", Lang.En);
        response.Response.ShouldEndSession = false;
        break;
    case RequestType.SessionEndedRequest:
        response.AddText("Good bye!", Lang.En);
        response.Response.ShouldEndSession = true;
        break;
    case RequestType.IntentRequest:
        switch (request.Request.Intent.Name)
        {
            case "Clova.YesIntent":
                // Add single URL Response and Text Reprompt
                response.AddUrl("https://dummy.domain/myaudio.mp3");
                response.AddRepromptText("Tell me something, please", Lang.En);
                response.Response.ShouldEndSession = false;
                break;
            case "Clova.NoIntent":
                // Add Brief and Verbose as SpeechSet
                response.AddBriefText("Brief explain.", Lang.En);
                response.AddVerboseText("Detail explain 1.", Lang.En);
                response.AddVerboseText("Detail explain 2.", Lang.En);
                response.AddVerboseUrl("https://dummy.domain/myaudio.mp3");
                response.Response.ShouldEndSession = false;
                break;
            case "Clova.GuideIntent":
                // Add multiple Reposonses and Reprompts
                response.AddText("Sure!", Lang.En);
                response.AddUrl("https://dummy.domain/myaudio.mp3");
                response.AddText("Let me explain how to use it!", Lang.En);
                response.AddRepromptText("Did you understand?", Lang.En);
                response.AddRepromptText("Now tell me what you want.", Lang.En);
                response.AddRepromptUrl("https://dummy.domain/myaudio.mp3");
                response.Response.ShouldEndSession = false;
                break;
        }
        break;
}
return new OkObjectResult(response);
```

# LISENCE

[MIT](./LICENSE)