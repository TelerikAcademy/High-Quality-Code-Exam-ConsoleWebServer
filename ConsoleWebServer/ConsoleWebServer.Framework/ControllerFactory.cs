namespace ConsoleWebServer.Framework
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class ControllerFactory
    {
        public Controller CreateController(HttpRequest request)
        {
            var controllerClassName = request.Action.ControllerName + "Controller";
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == controllerClassName);
            if (type == null || !typeof(Controller).IsAssignableFrom(type))
            {
                throw new HttpNotFoundException(
                    string.Format("Controller with name {0} not found!", controllerClassName));
            }

            var instance = (Controller)Activator.CreateInstance(type);
            instance.Request = request;

            return instance;
        }
    }
}
