namespace ConsoleWebServer.Framework.ActionResults
{
    using System;
    using System.Net;

    public class ViewActionResult : BaseActionResult
    {
        private readonly string name;
        private readonly object model;

        public ViewActionResult(HttpRequest request, string name, object model)
            : base (request)
        {
            this.name = name;
            this.model = model;
        }

        public override HttpResponse GetResponse()
        {
            return new HttpResponse(this.Request.ProtocolVersion, HttpStatusCode.OK, this.name + this.model);
        }
    }
}
