using System;
using System.IO;
using System.Text;

namespace DLRCommon
{
    public class EventRaisingTextWriter : TextWriter
    {
        public event EventHandler<string> StreamWritten;

        public override Encoding Encoding => Encoding.UTF8;

        public override void Write(string value)
        {
            StreamWritten.Invoke(this, value);
        }

        public override void Write(string format, object arg0)
        {
            StreamWritten.Invoke(this, string.Format(format, arg0));
        }

        public override void Write(string format, object arg0, object arg1)
        {
            StreamWritten.Invoke(this, string.Format(format, arg0, arg1));
        }

        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            StreamWritten.Invoke(this, string.Format(format, arg0, arg1, arg2));
        }

        public override void Write(string format, params object[] arg)
        {
            StreamWritten.Invoke(this, string.Format(format, arg));
        }

        public override void Write(char value)
        {
            StreamWritten.Invoke(this, new string(new char[] { value }));
        }

        public override void Write(char[] buffer)
        {
            StreamWritten.Invoke(this, new string(buffer));
        }

        public override void Write(char[] buffer, int index, int count)
        {
            StreamWritten.Invoke(this, new string(buffer, index, count));
        }

        public override void WriteLine()
        {
            StreamWritten.Invoke(this, "\n");
        }

        public override void WriteLine(string value)
        {
            StreamWritten.Invoke(this, value + "\n");
        }

        public override void WriteLine(string format, object arg0)
        {
            StreamWritten.Invoke(this, string.Format(format, arg0) + "\n");
        }

        public override void WriteLine(string format, object arg0, object arg1)
        {
            StreamWritten.Invoke(this, string.Format(format, arg0, arg1) + "\n");
        }

        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            StreamWritten.Invoke(this, string.Format(format, arg0, arg1, arg2) + "\n");
        }

        public override void WriteLine(string format, params object[] arg)
        {
            StreamWritten.Invoke(this, string.Format(format, arg) + "\n");
        }

        public override void WriteLine(char value)
        {
            StreamWritten.Invoke(this, new string(new char[] { value, '\n' }));
        }

        public override void WriteLine(char[] buffer)
        {
            StreamWritten.Invoke(this, new string(buffer) + "\n");
        }

        public override void WriteLine(char[] buffer, int index, int count)
        {
            StreamWritten.Invoke(this, new string(buffer, index, count) + "\n");
        }
    }
}
