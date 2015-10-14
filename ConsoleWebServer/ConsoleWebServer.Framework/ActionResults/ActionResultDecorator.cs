namespace ConsoleWebServer.Framework.ActionResults
{
    public abstract class ActionResultDecorator : IActionResult
    {
        private readonly IActionResult actionResult;

        protected ActionResultDecorator(IActionResult actionResult)
        {
            this.actionResult = actionResult;
        }

        protected abstract void UpdateResponse(HttpResponse response);

        public HttpResponse GetResponse()
        {
            var response = this.actionResult.GetResponse();
            this.UpdateResponse(response);
            return response;
        }
    }
}
