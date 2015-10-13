namespace ConsoleWebServer.CLI
{
    using System;
    using System.Net;
    using System.Text;

    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.Handlers;

    public static class Startup
    {
        public static void Main()
        {
            // TODO: Request reader
            var requestBuilder = new StringBuilder();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    var response = GetResponse(requestBuilder.ToString());
                    Console.WriteLine(response);
                    requestBuilder.Clear();
                    continue;
                }

                requestBuilder.AppendLine(inputLine);
            }
        }

        private static HttpResponse GetResponse(string requestAsString)
        {
            var headHandler = new HeadHandler();
            var optionsHandler = new OptionsHandler();
            var fileHandler = new StaticFileHandler();
            var controllerHandler = new ControllerHandler();

            headHandler.SetSuccessor(optionsHandler);
            optionsHandler.SetSuccessor(fileHandler);
            fileHandler.SetSuccessor(controllerHandler);

            HttpRequest request;
            try
            {
                var requestParser = new RequestParser();
                request = requestParser.Parse(requestAsString);
            }
            catch (Exception ex)
            {
                return new HttpResponse(new Version(1, 1), HttpStatusCode.BadRequest, ex.Message);
            }

            var response = headHandler.HandleRequest(request);
            return response;
        }
    }
}
