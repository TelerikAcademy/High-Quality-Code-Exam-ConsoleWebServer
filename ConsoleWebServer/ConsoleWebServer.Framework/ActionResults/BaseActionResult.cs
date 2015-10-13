namespace ConsoleWebServer.Framework.ActionResults
{
    public abstract class BaseActionResult : IActionResult
    {
        protected BaseActionResult(HttpRequest request)
        {
            this.Request = request;
        }

        protected HttpRequest Request { get; private set; }

        public abstract HttpResponse GetResponse();
    }
}
