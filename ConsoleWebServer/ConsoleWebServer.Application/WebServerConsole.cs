namespace ConsoleWebServer.CLI
{
    using System;
    using System.Text;

    using ConsoleWebServer.Framework;

    public class WebServerConsole
    {
        private readonly IResponseProvider responseProvider;

        public WebServerConsole(IResponseProvider responseProvider)
        {
            this.responseProvider = responseProvider;
        }

        public void Start()
        {
            // TODO: Request reader?
            var requestBuilder = new StringBuilder();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputLine))
                {
                    var response = this.responseProvider.GetResponse(requestBuilder.ToString());
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(response);
                    Console.ResetColor();
                    requestBuilder.Clear();
                    continue;
                }

                requestBuilder.AppendLine(inputLine);
            }
        }
    }
}
