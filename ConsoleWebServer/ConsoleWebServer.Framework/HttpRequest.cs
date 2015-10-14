using System;using System.Linq;
using System.Collections.Generic;using System.Text;
using System.Text;

public class HttpRq
{
    public HttpRq(string method, string uri, string httpVersion)
    {
        this.ProtocolVersion = Version.Parse(httpVersion.ToLower().Replace("HTTP/".ToLower(), string.Empty));
        this.Headers = new SortedDictionary<string, ICollection<string>>();
        this.Uri = uri;
        this.Method = method;
        this.Action = new ActionDescriptor(uri);
    }

    public Version ProtocolVersion { get; protected set; }

    public IDictionary<string, ICollection<string>> Headers { get; protected set; }

    public void AddHeader(string name, string value)
    {
        if (!this.Headers.ContainsKey(name))
        {
            this.Headers.Add(name, new HashSet<string>());
        }

        this.Headers[name].Add(value);
    }

    public string Uri { get; private set; }

    public string Method { get; private set; }

    public ActionDescriptor Action { get; private set; }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(
            string.Format(
                "{0} {1} {2}{3}",
                this.Method,
                this.Action,
                "HTTP/",
                this.ProtocolVersion));
        var headerStringBuilder = new StringBuilder();
        foreach (var key in this.Headers.Keys)
        {
            headerStringBuilder.AppendLine(string.Format("{0}: {1}", key, string.Join("; ", this.Headers[key])));
        }
        stringBuilder.AppendLine(headerStringBuilder.ToString());
        return stringBuilder.ToString();
    }
}