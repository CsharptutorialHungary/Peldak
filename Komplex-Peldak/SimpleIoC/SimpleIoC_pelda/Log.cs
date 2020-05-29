using System;

namespace SimpleIoC_pelda
{
    public interface ILog
    {
        void Write(string format, params object[] parameters);
    }

    public class Log : ILog
    {
        public void Write(string format, params object[] parameters)
        {
            Console.WriteLine(format, parameters);
        }
    }
}
