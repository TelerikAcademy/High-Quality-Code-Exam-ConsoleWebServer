namespace ConsoleWebServer.CLI.Controllers
{
    using System;

    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.ActionResults;

    public class ApiController : Controller
    {
        public IActionResult Sample(string param)
        {
            return this.Json(new { param });
        }

        public IActionResult SampleWithCors(string param)
        {
            return new ActionResultWithCorsDecorator(
                "https://telerikacademy.com",
                new JsonActionResult(
                    this.Request,
                    new { time = DateTime.Now, param, moreInfo = "Data available for http://telerikacademy.com" }));
        }
    }
}
