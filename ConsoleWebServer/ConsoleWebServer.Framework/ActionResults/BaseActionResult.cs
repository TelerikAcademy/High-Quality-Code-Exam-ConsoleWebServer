namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using System.Net;

    public abstract class BaseActionResult : IActionResult
    {
        protected BaseActionResult(HttpRequest request)
        {
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRequest Request { get; private set; }

        protected List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

        protected virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        protected virtual string GetContent()
        {
            return string.Empty;
        }

        protected virtual string GetContentType()
        {
            return HttpResponse.DefaultContentType;
        }

        public HttpResponse GetResponse()
        {
            var response = new HttpResponse(this.Request.ProtocolVersion, this.GetStatusCode(), this.GetContentType());
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}
