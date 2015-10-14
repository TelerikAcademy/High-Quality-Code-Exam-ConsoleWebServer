namespace ConsoleWebServer.Framework.Handlers
{
    using System;
    using System.IO;
    using System.Linq;
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
            if (!File.Exists(filePath))
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, "File not found!");
            }

            var fileContents = File.ReadAllText(filePath);
            var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, fileContents);
            return response;
        }

        private bool FileExists(string path, string filePath, int depth)
        {
            if (depth <= 0)
            {
                return File.Exists(filePath);
            }
            try
            {
                var files = Directory.GetFiles(path);
                if (files.Contains(filePath))
                {
                    return true;
                }

                var directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    if (this.FileExists(directory, filePath, depth - 1))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}