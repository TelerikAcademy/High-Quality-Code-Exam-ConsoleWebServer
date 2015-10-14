namespace ConsoleWebServer.Application
{
    using ConsoleWebServer.Framework;
    using ConsoleWebServer.Framework.Handlers;

    // TODO: Describe patterns, SOLID, bugs and bottleneck in Documentation.txt
    public static class Startup
    {
        public static void Main()
        {
            IHandlerFactory handlerFactory = new HandlerFactory();
            IResponseProvider responseProvider = new ResponseProvider(handlerFactory);
            var webSever = new WebServerConsole(responseProvider);
            webSever.Start();
        }
    }
}
