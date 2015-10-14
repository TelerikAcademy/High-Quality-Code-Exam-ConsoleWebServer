using System;using System.Linq;

public class HttpNotFound : Exception
{
    public const string ClassName = "HttpNotFoundException";
    public HttpNotFound(string message)
        : base(message)
    {
    }
}