namespace ConsoleWebServer.Framework.Handlers
{
    public interface IControllerFactory
    {
        Controller CreateController(HttpRequest request);
    }
}
