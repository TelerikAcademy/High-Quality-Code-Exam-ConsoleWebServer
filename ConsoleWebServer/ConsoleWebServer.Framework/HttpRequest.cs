namespace ConsoleWebServer.Framework
{
    using System;
    using System.Collections.Generic;

    public class HttpRequest
    {
        private const string HttpVersionPrefix = "HTTP/";

        public HttpRequest(string method, string uri, string httpVersion)
        {
            this.Method = method;
            this.Route = new RouteDescriptor(uri);
            this.ProtocolVersion = Version.Parse(httpVersion.Replace(HttpVersionPrefix, string.Empty));
            this.Headers = new Dictionary<string, ICollection<string>>();
        }

        public string Method { get; private set; }

        public RouteDescriptor Route { get; private set; }

        public Version ProtocolVersion { get; private set; }

        public IDictionary<string, ICollection<string>> Headers { get; private set; }

        public void AddHeader(string name, string value)
        {
            if (!this.Headers.ContainsKey(name))
            {
                this.Headers.Add(name, new HashSet<string>());
            }
            
            this.Headers[name].Add(value);
        }
    }
}
