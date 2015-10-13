namespace ConsoleWebServer.Framework.Handlers
{
    using System.Net;

    public class HeadHandler : Handler
    {
        protected override bool CanHandle(HttpRequest request)
        {
            return request.Method.ToLower() == "head";
        }

        protected override HttpResponse Handle(HttpRequest request)
        {
            // http://stackoverflow.com/q/19718927/1862812
            var statusCode = HttpStatusCode.OK;
            var response = new HttpResponse(request.ProtocolVersion, statusCode, string.Empty);
            return response;
        }
    }
}
