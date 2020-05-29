using DLRCommon;
using System;

namespace DLR_Fsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IDLREvaluator fsharp = new FsharpEvaluator())
            {
                fsharp.ConsoleWritten += Fsharp_ConsoleWritten;
                fsharp.ErrorWritten += Fsharp_ErrorWritten;
                dynamic output = fsharp.Evaluate("1 + 41 * 2");
                if (output != null)
                {
                    Console.WriteLine("Result: {0}", output);
                }
                fsharp.Evaluate("printfn \"Hello World from F#!\"");

            }

            Console.ReadKey();
        }

        private static void Fsharp_ErrorWritten(object sender, string e)
        {
            Console.Write(e);
        }

        private static void Fsharp_ConsoleWritten(object sender, string e)
        {
            Console.Write(e);
        }
    }

}
