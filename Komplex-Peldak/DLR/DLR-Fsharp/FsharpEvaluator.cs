using DLRCommon;
using FSharp.Compiler.Interactive;
using Microsoft.FSharp.Core;
using System;
using System.IO;

namespace DLR_Fsharp
{
    public sealed class FsharpEvaluator: IDLREvaluator
    {
        private EventRaisingTextWriter _errorWriter;
        private EventRaisingTextWriter _consoleWriter;
        private StringReader _instream;

        private Shell.FsiEvaluationSessionHostConfig config;
        private Shell.FsiEvaluationSession session;

        public FsharpEvaluator()
        {
            config = Shell.FsiEvaluationSession.GetDefaultConfiguration();
            var arguments = new string[] { "--noninteractive" };
            _instream = new StringReader("");
            _errorWriter = new EventRaisingTextWriter();
            _consoleWriter = new EventRaisingTextWriter();
            _consoleWriter.StreamWritten += _consoleWriter_StreamWritten;
            _errorWriter.StreamWritten += _errorWriter_StreamWritten;


            session = Shell.FsiEvaluationSession.Create(config, arguments, _instream, _consoleWriter, _errorWriter, null, null);
        }

        private void _errorWriter_StreamWritten(object sender, string e)
        {
            ErrorWritten?.Invoke(this, e);
        }

        private void _consoleWriter_StreamWritten(object sender, string e)
        {
            ConsoleWritten?.Invoke(this, e);
        }

        public event EventHandler<string> ConsoleWritten;

        public event EventHandler<string> ErrorWritten;

        public void Dispose()
        {
            if (session != null)
            {
                (session as IDisposable)?.Dispose();
                session = null;
            }
            if (_consoleWriter != null)
            {
                _consoleWriter.Dispose();
                _consoleWriter = null;
            }
            if (_errorWriter != null)
            {
                _errorWriter.Dispose();
                _errorWriter = null;
            }
            if (_instream != null)
            {
                _instream.Dispose();
                _instream = null;
            }
        }

        public dynamic Evaluate(string expression)
        {
            FSharpOption<Shell.FsiValue> result = session.EvalExpression(expression);
            if (result?.Value != null)
            {
                return result.Value.ReflectionValue;
            }
            return "No return";
        }
    }
}
