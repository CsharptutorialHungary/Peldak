using DLRCommon;
using IronPython;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;

namespace DLR_Python
{
    public sealed class PythonEvaluator: IDLREvaluator
    {
        private ScriptEngine _engine;
        private EventRaisingTextWriter _errorWriter;
        private EventRaisingTextWriter _consoleWriter;
        private ScriptScope _scope;

        private MemoryStream _stream;


        public event EventHandler<string> ConsoleWritten;
        public event EventHandler<string> ErrorWritten;

        public PythonEvaluator()
        {
            var options = new Dictionary<string, object>
            {
                ["DivisionOptions"] = PythonDivisionOptions.New
            };
            _errorWriter = new EventRaisingTextWriter();
            _consoleWriter = new EventRaisingTextWriter();
            _consoleWriter.StreamWritten += _consoleWriter_StreamWritten;
            _errorWriter.StreamWritten += _errorWriter_StreamWritten;
            _stream = new MemoryStream();

            _engine = Python.CreateEngine(options);
            _engine.Runtime.IO.SetOutput(_stream, _consoleWriter);
            _engine.Runtime.IO.SetErrorOutput(_stream, _errorWriter);
            _scope = _engine.CreateScope();
        }

        private void _errorWriter_StreamWritten(object sender, string e)
        {
            ErrorWritten?.Invoke(this, e);
        }

        private void _consoleWriter_StreamWritten(object sender, string e)
        {
            ConsoleWritten?.Invoke(this, e);
        }

        public dynamic Evaluate(string expression)
        {
            ScriptSource source = _engine.CreateScriptSourceFromString(expression, SourceCodeKind.AutoDetect);
            return source.Execute(_scope);
        }

        public void Dispose()
        {
            if (_stream != null)
            {
                _stream.Dispose();
                _stream = null;
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
        }
    }
}
