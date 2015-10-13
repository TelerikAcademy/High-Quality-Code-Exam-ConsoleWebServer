namespace ConsoleWebServer.CLI.Controllers
{
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.ActionResults;

    public class HomeController : Controller
    {
        public IActionResult Index(string str)
        {
            return this.View("view", new { });
        }
    }
}
