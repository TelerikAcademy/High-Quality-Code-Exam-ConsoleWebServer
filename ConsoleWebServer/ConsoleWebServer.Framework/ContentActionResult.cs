using System.Collections.Generic;
using System.Net;


public class ContentActionResult : IActionResult
{
    public readonly object model;

    public ContentActionResult(HttpRequest request, object model)
    {
        this.model = model;
        this.Request = request;
        this.ResponseHeaders = new List<KeyValuePair<string, string>>();
    }

    public HttpRequest Request { get; private set; }

    public List<KeyValuePair<string, string>> ResponseHeaders { get; private set; }

    public string GetContent()
    {
        return this.model.ToString();
    }

    public string GetContentType()
    {
        return HttpResponse.DefaultContentType;
    }

    public HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.OK;
    }

    public HttpResponse GetResponse()
    {
        var response = new HttpResponse(this.Request.ProtocolVersion, this.GetStatusCode(), this.GetContent(), this.GetContentType());
        foreach (var responseHeader in this.ResponseHeaders)
        {
            response.AddHeader(responseHeader.Key, responseHeader.Value);
        }

        return response;
    }
}

public class ContentActionResultWithCors : ContentActionResult
{
    public ContentActionResultWithCors(HttpRequest request, object model, string corsSettings)
        : base(request, model)
    {
        this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
    }
}

public class ContentActionResultWithoutCaching : ContentActionResult
{
    public ContentActionResultWithoutCaching(HttpRequest request, object model)
        : base(request, model)
    {
        this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
    }
}

public class ContentActionResultWithCorsWithoutCaching : ContentActionResult
{
    public ContentActionResultWithCorsWithoutCaching(HttpRequest request, object model, string corsSettings)
        : base(request, model)
    {
        this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
        this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
    }
}
