namespace ConsoleWebServer.Framework.Handlers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using ConsoleWebServer.Framework.ActionResults;

    public class OptionsHandler : Handler
    {
        protected override bool CanHandle(HttpRequest request)
        {
            return request.Method.ToLower() == "options";
        }

        protected override HttpResponse Handle(HttpRequest request)
        {
            var controllerClassName = request.Action.ControllerName + "Controller"; // TODO: global constants or something

            var routes = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .Where(x => x.Name == controllerClassName && typeof(Controller).IsAssignableFrom(x))
                .Select(x => new
                {
                    Name = x.Name,
                    Methods = x.GetMethods().Where(m => m.ReturnType == typeof(IActionResult))
                })
                .SelectMany(x => x.Methods.Select(m => string.Format("/{0}/{1}/{{parameter}}", x.Name.Replace("Controller", string.Empty), m.Name)))
                .ToList();

            return new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, string.Join(Environment.NewLine, routes));
        }
    }
}
