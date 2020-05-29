using MEF.API;
using System;
using System.ComponentModel.Composition;

namespace MEF
{
    [Export(typeof(IHost))]
    public class Host : IHost
    {
        public string WorkDirectory
        {
            get { return Environment.CurrentDirectory; }
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Write(string format, params object[] parameters)
        {
            Console.Write(format, parameters);
        }

        public void WriteLine(string format, params object[] parameters)
        {
            Console.WriteLine(format, parameters);
        }
    }
}
