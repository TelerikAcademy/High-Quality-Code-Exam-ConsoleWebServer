namespace ConsoleWebServer.CLI.Controllers
{
    using ConsoleWebServer.Framework;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View("view", new { });
        }
    }
}
