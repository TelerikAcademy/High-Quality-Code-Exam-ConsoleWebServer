namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Net;
    using Newtonsoft.Json;

    public class JsonViewResult : BaseActionResult
    {
        private readonly object model;

        public JsonViewResult(HttpRequest request, object model)
            : base (request)
        {
            this.model = model;
        }

        public override HttpResponse GetResponse()
        {
            return new HttpResponse(
                this.Request.ProtocolVersion,
                HttpStatusCode.OK,
                JsonConvert.SerializeObject(this.model),
                "application/json");
        }
    }
}
