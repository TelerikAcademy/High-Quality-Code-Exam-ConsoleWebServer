namespace ConsoleWebServer.Framework
{
    public abstract class Controller
    {
        public HttpRequest Request { get; internal set; }

        protected IActionResult View(string name, object model)
        {
            // TODO
            return null;
        }

        protected IActionResult Json(object model)
        {
            // TODO
            return null;
        }
    }

    public interface IActionResult
    {
    }
}


/*



*/