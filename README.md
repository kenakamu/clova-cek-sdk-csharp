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
response.AddUri("https://line.me");
response.AddText("Hi!", Lang.En);
response.AddUri("https://line.me", Lang.En);
```

5\. Check request type and handle appropriately.

```csharp
switch (request.Request.Type)
{
    case RequestType.LaunchRequest:
        response.AddText("Welcome to CEK!", Lang.En);
        response.Response.ShouldEndSession = false;
        break;
    case RequestType.IntentRequest:
        switch (request.Request.Intent.Name)
        {
            case "Clova.YesIntent":
                response.AddText("Yes!", Lang.En);
                break;
            case "Clova.NoIntent":
                response.AddText("No...", Lang.En);
                break;
            case "Clova.GuideIntent":
                response.AddText("Let me explain how to use it!", Lang.En);
                break;
        }
        break;
}
return new OkObjectResult(response);
```

# LISENCE

[MIT](./LICENSE)