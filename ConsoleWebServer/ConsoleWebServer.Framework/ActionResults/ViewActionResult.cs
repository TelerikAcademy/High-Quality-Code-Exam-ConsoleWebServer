namespace ConsoleWebServer.Framework.ActionResults
{
    using System;
    using System.Net;

    public class ViewActionResult : IActionResult
    {
        private readonly HttpRequest request;

        private readonly string name;

        private readonly object model;

        public ViewActionResult(HttpRequest request, string name, object model)
        {
            this.request = request;
            this.name = name;
            this.model = model;
        }

        public HttpResponse GetResponse()
        {
            return new HttpResponse(this.request.ProtocolVersion, HttpStatusCode.OK, this.name + this.model);
        }
    }
}
