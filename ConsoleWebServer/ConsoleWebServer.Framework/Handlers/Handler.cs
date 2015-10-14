namespace ConsoleWebServer.Framework.Handlers
{
    using System.Net;

    public abstract class Handler
    {
        protected Handler Successor { get; private set; }

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        public HttpResponse HandleRequest(HttpRequest request)
        {
            if (this.CanHandle(request))
            {
                return this.Handle(request);
            }
            
            if (this.Successor != null)
            {
                return this.Successor.HandleRequest(request);
            }

            return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotImplemented, "Request cannot be handled.");
        }

        protected abstract bool CanHandle(HttpRequest request);

        protected abstract HttpResponse Handle(HttpRequest request);
    }
}
