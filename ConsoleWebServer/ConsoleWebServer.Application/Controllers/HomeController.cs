namespace ConsoleWebServer.CLI.Controllers
{
    using System;

    using ConsoleWebServer.Framework;

    public class HomeController : Controller
    {
        public IActionResult Index(string str)
        {
            Console.WriteLine("I was invoked!!!" + str);
            return this.View("view", new { });
        }
    }
}
