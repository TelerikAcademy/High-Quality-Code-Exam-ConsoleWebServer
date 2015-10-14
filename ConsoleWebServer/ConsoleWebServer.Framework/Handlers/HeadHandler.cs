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
            var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, string.Empty);
            return response;
        }
    }
}
