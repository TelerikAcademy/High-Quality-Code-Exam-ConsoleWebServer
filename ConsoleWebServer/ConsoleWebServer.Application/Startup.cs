namespace ConsoleWebServer.CLI
{
    using System;
    using System.Net;
    using System.Text;

    using ConsoleWebServer.Framework;

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
                    HandleRequest(requestBuilder.ToString());
                    requestBuilder.Clear();
                    continue;
                }

                requestBuilder.AppendLine(inputLine);
            }
        }

        private static void HandleRequest(string requestAsString)
        {
            var requestParser = new RequestParser();
            var request = requestParser.Parse(requestAsString);

            HttpResponse response;
            try
            {
                var controllerFactory = new ControllerFactory();
                var controller = controllerFactory.CreateController(request);
                var actionInvoker = new ActionInvoker();
                var actionResult = actionInvoker.InvokeAction(controller, request.Action);
                response = actionResult.GetResponse();
            }
            catch (HttpNotFoundException exception)
            {
                response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, exception.Message);
            }
            catch (Exception exception)
            {
                response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.InternalServerError, exception.Message);
            }

            Console.WriteLine(response.ToString());
        }
    }
}
