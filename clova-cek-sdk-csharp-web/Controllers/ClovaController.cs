using ClovaCEKCsharp;
using ClovaCEKCsharp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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
                    response.AddText("Welcome to CEK!");
                    response.Response.ShouldEndSession = false;
                    break;
                case RequestType.IntentRequest:
                    switch (request.Request.Intent.Name)
                    {
                        case "Clova.YesIntent":
                            response.AddText("Yes!");
                            break;
                        case "Clova.NoIntent":
                            response.AddText("No...");
                            break;
                        case "Clova.GuideIntent":
                            response.AddText("Let me explain how to use it!");
                            break;
                    }
                    break;
            }
            return new OkObjectResult(response);
        }
    }
}
