using System;using System.Linq;

public class HttpNotFoundException : Exception
{
    public HttpNotFoundException(string message)
        : base(message)
    {
    }
}