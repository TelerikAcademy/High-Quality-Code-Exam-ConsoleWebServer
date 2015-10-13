namespace ConsoleWebServer.Framework
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class ControllerFactory
    {
        public Controller CreateController(HttpRequest request)
        {
            var controllerClassName = request.Route.ControllerName + "Controller";
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == controllerClassName);
            if (type == null || !typeof(Controller).IsAssignableFrom(type))
            {
                return null;
            }

            var instance = (Controller)Activator.CreateInstance(type);
            instance.Request = request;

            return instance;
        }
    }
}
