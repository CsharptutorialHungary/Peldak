using System;

namespace DLRCommon
{
    public interface IDLREvaluator : IDisposable
    {
        dynamic Evaluate(string expression);

        event EventHandler<string> ConsoleWritten;
        event EventHandler<string> ErrorWritten;
    }
}
