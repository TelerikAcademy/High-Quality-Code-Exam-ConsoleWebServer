namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework.ActionResults;

    public abstract class Controller
    {
        public HttpRequest Request { get; internal set; }

        protected IActionResult Content(object model)
        {
            return new ContentActionResult(this.Request, model);
        }

        protected IActionResult Json(object model)
        {
            return new JsonActionResult(this.Request, model);
        }

        protected IActionResult Redirect(string location)
        {
            return new RedirectActionResult(this.Request, location);
        }
    }
}
