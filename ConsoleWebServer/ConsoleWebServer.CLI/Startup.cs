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
            Console.WriteLine(request.Method);
            Console.WriteLine(request.ProtocolVersion);
            Console.WriteLine(request.Route.ControllerName);
            Console.WriteLine(request.Route.ActionName);
            Console.WriteLine(request.Route.Id);
            foreach (var key in request.Headers.Keys)
            {
                Console.WriteLine("{0}: {1}", key, string.Join("; ", request.Headers[key]));
            }

            Console.WriteLine();
        }
    }
}
