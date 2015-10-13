namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework.ActionResults;

    public abstract class Controller
    {
        public HttpRequest Request { get; internal set; }

        protected IActionResult View(string name, object model)
        {
            return new ViewActionResult(this.Request, name, model);
        }

        protected IActionResult Json(object model)
        {
            // TODO
            return null;
        }
    }
}
