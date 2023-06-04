namespace Tervmintak
{
    public interface IRequestHandler
    {
        string Handle();
    }

    public sealed class SomeRequestHandler
    {
        public string HandleRequest(string path)
        {
            return $"Handling request for {path}...";
        }
    }

    public class RequestHandlerAdapter : IRequestHandler
    {
        private readonly SomeRequestHandler _toBeAdapted;

        public RequestHandlerAdapter(SomeRequestHandler toBeAdapted) 
        {
            _toBeAdapted = toBeAdapted;
        }

        public string Handle()
        {
            return _toBeAdapted.HandleRequest("http://localhost");
        }
    }
}
