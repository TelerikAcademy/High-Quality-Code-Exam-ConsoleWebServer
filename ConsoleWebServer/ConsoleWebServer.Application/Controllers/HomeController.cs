namespace ConsoleWebServer.Application.Controllers
{
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.ActionResults;

    public class HomeController : Controller
    {
        public HomeController(HttpRequest request)
            : base(request)
        {
        }

        public IActionResult Index(string param)
        {
            return this.Content("Home page :)");
        }

        public IActionResult LivePage(string param)
        {
            return
                new ActionResultWithNoCachingDecorator(
                    new ContentActionResult(this.Request, "Live page with no caching"));
        }

        public IActionResult LivePageForAjax(string param)
        {
            return new ActionResultWithCorsDecorator(
                "*",
                new ActionResultWithNoCachingDecorator(
                    new ContentActionResult(this.Request, "Live page with no caching and CORS")));
        }
    }
}
