using ClovaCEKCsharp;
using ClovaCEKCsharp.Models;
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
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var request = await client.GetRequest(Request.Headers["SignatureCEK"], Request.Body);
            var response = new CEKResponse();

            switch (request.Request.Type)
            {
                case RequestType.LaunchRequest:
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
                            response.AddText("Yes!", Lang.En);
                            response.Response.ShouldEndSession = false;
                            break;
                        case "Clova.NoIntent":
                            response.AddText("No...", Lang.En);
                            response.Response.ShouldEndSession = false;
                            break;
                        case "Clova.GuideIntent":
                            response.AddText("Sure!", Lang.En);
                            response.AddText("Let me explain how to use it!", Lang.En);
                            response.Response.ShouldEndSession = false;
                            break;
                    }
                    break;
            }
            return new OkObjectResult(response);
        }
    }
}
