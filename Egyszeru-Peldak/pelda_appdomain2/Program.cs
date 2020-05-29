using System;

namespace pelda_appdomain2
{
    public class Code : MarshalByRefObject
    {
        public void Greet()
        {
            Console.WriteLine("Hello from App domain: " + AppDomain.CurrentDomain.FriendlyName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AppDomain isolated = AppDomain.CreateDomain("isolated");
            Type codeType = typeof(Code);

            Code peldany = (Code)isolated.CreateInstanceAndUnwrap(codeType.Assembly.FullName, codeType.FullName);

            peldany.Greet();

            AppDomain.Unload(isolated);

            Console.ReadKey();

        }
    }
}
