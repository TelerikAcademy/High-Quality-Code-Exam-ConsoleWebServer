namespace ConsoleWebServer.Application
{
    // TODO: Describe patterns, SOLID, bugs and bottleneck in Documentation.txt
    public static class Startup
    {
        public static void Main()
        {
            var webSever = new WebServerConsole();
            webSever.Start();
        }
    }
}
