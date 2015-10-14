namespace ConsoleWebServer.Framework.Handlers
{
    using System;
    using System.IO;
    using System.Net;

    public class StaticFileHandler : Handler
    {
        protected override bool CanHandle(HttpRequest request)
        {
            return request.Uri.LastIndexOf(".", StringComparison.Ordinal)
                   > request.Uri.LastIndexOf("/", StringComparison.Ordinal);
        }

        protected override HttpResponse Handle(HttpRequest request)
        {
            var fileName = request.Uri.TrimStart('/');
            if (!File.Exists(fileName))
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, "File not found!");
            }

            var fileContents = File.ReadAllText(fileName);
            var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, fileContents);
            return response;
        }
    }
}
