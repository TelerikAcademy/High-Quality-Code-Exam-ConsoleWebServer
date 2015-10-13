namespace ConsoleWebServer.Framework
{
    using System;

    public class RouteDescriptor
    {
        public const string DefaultControllerName = "Home";

        public const string DefaultActionName = "Index";

        public RouteDescriptor(string uri)
        {
            uri = uri ?? string.Empty;

            var uriParts = uri.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            this.ControllerName = uriParts.Length > 0 ? uriParts[0] : DefaultControllerName;

            this.ActionName = uriParts.Length > 1 ? uriParts[1] : DefaultActionName;

            int id;
            if (uriParts.Length > 2 && int.TryParse(uriParts[2], out id))
            {
                this.Id = id;
            }
            else
            {
                this.Id = null;
            }
        }

        public string ControllerName { get; private set; }

        public string ActionName { get; private set; }

        public int? Id { get; private set; }
    }
}
