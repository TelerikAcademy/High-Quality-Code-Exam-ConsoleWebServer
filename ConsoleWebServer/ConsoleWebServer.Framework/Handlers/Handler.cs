namespace ConsoleWebServer.Framework.Handlers
{
    using System.Net;

    public abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        protected abstract bool CanHandle(HttpRequest request);

        protected abstract HttpResponse Handle(HttpRequest request);

        public HttpResponse HandleRequest(HttpRequest request)
        {
            if (this.CanHandle(request))
            {
                return this.Handle(request);
            }
            else if (this.Successor != null)
            {
                return this.Successor.HandleRequest(request);
            }
            else
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotImplemented, "Request cannot be handled.");
            }
        }
    }
}
