using System;

namespace SimpleIoC
{
    [Serializable]
    public class ResolveException : Exception
    {
        public ResolveException(Type t) :
            base($"Can't resolve type: {t.FullName}") { }

        public ResolveException() : base() { }

        public ResolveException(string message) :
            base(message) { }

        public ResolveException(string message, Exception innerException) : 
            base(message, innerException) { }
    }
}
