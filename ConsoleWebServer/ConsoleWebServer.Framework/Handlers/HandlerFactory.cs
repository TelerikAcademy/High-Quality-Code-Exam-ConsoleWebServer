namespace ConsoleWebServer.Framework.Handlers
{
    public class HandlerFactory : IHandlerFactory
    {
        public Handler CreateAndAttachHandlers()
        {
            var optionsHandler = new OptionsHandler();
            var fileHandler = new StaticFileHandler();
            var controllerHandler = new ControllerHandler();

            optionsHandler.SetSuccessor(fileHandler);
            fileHandler.SetSuccessor(controllerHandler);

            return optionsHandler;
        }
    }
}
