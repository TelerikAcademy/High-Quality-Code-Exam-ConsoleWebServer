namespace ConsoleWebServer.Framework
{
    using System;
    using System.Net;
    using System.Text;

    public class HttpResponse : HttpMessage
    {
        public const string DefaultContentType = "text/plain; charset=utf-8";

        private const string ServerEngineName = "ConsoleWebServer";

        public HttpResponse(
            Version httpVersion,
            HttpStatusCode statusCode,
            string body,
            string contentType = DefaultContentType)
            : base(httpVersion.ToString())
        {
            this.Body = body;
            this.StatusCode = statusCode;
            this.AddHeader("X-Powered-By", ServerEngineName);
            this.AddHeader("Server", ServerEngineName);
            this.AddHeader("Date", DateTime.Now.ToString("R"));
            this.AddHeader("Content-Length", body.Length.ToString());
            this.AddHeader("Content-Type", contentType);
        }

        public HttpStatusCode StatusCode { get; private set; }

        public string Body { get; private set; }

        public string StatusCodeAsString
        {
            get
            {
                return this.StatusCode.ToString();
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(
                string.Format(
                    "{0}{1} {2} {3}",
                    HttpVersionPrefix,
                    this.ProtocolVersion,
                    (int)this.StatusCode,
                    this.StatusCodeAsString));
            stringBuilder.AppendLine(base.ToString());
            if (!string.IsNullOrWhiteSpace(this.Body))
            {
                stringBuilder.AppendLine(this.Body);
            }

            return stringBuilder.ToString();
        }
    }
}
