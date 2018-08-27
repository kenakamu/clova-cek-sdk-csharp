using CEK.CSharp;
using CEK.CSharp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace clova_cek_sdk_csharp_web.Controllers
{
    [Route("api/[controller]")]
    public class ClovaController : Controller
    {
        private ClovaClient client;
        public ClovaController()
        {
            client = new ClovaClient();
        }
        // POST api/clova
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var request = await client.GetRequest(Request.Headers["SignatureCEK"], Request.Body, true);
            var response = new CEKResponse();
            
            // get session information by specifying default value in case no session information
            var mySessionValue = request.GetSessionAttribute("mySessionKey", "defaultValue");
            // adding session information
            response.AddSession("mySessionKey", "mySessionValue");

            switch (request.Request.Type)
            {
                case RequestType.LaunchRequest:
                    // Single Text Reply
                    response.AddText("Welcome to CEK", Lang.En);
                    response.ShouldEndSession = false;
                    break;
                case RequestType.SessionEndedRequest:
                    response.AddText("Good bye!", Lang.En);
                    response.ShouldEndSession = true;
                    break;
                case RequestType.IntentRequest:
                    switch (request.Request.Intent.Name)
                    {
                        case "Clova.YesIntent":
                            // Add single URL Response and Text Reprompt
                            response.AddUrl("https://clova-common.line-scdn.net/dice/rolling_dice_sound.mp3");
                            response.AddRepromptText("Tell me something, please", Lang.En);                            
                            response.ShouldEndSession = false;
                            break;
                        case "Clova.NoIntent":
                            // Add Brief and Verbose as SpeechSet
                            response.AddBriefText("Brief explain.", Lang.En);
                            response.AddVerboseText("Detail explain 1.", Lang.En);
                            response.AddVerboseText("Detail explain 2.", Lang.En);
                            response.AddVerboseUrl("https://clova-common.line-scdn.net/dice/rolling_dice_sound.mp3");
                            response.ShouldEndSession = false;
                            break;
                        case "Clova.GuideIntent":
                            // Add multiple Reposonses and Reprompts
                            response.AddText("Sure!", Lang.En);
                            response.AddUrl("https://clova-common.line-scdn.net/dice/rolling_dice_sound.mp3");
                            response.AddText("Let me explain how to use it!", Lang.En);
                            response.AddRepromptText("Did you understand?", Lang.En);
                            response.AddRepromptText("Now tell me what you want.", Lang.En);
                            response.AddRepromptUrl("https://clova-common.line-scdn.net/dice/rolling_dice_sound.mp3");
                            response.ShouldEndSession = false;
                            break;
                    }
                    break;
            }
            return new OkObjectResult(response);
        }
    }
}
