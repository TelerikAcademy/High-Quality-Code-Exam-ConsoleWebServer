namespace ConsoleWebServer.CLI
{
    using System;
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
            var controllerFactory = new ControllerFactory();
            var controller = controllerFactory.CreateController(request);
            var actionInvoker = new ActionInvoker();
            actionInvoker.InvokeAction(controller, request.Action);
        }
    }
}
