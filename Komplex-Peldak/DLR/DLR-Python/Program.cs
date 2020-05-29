using DLRCommon;
using System;

namespace DLR_Python
{
    class Program
    {
        static void Main(string[] args)
        {
            using(IDLREvaluator python = new PythonEvaluator())
            {
                python.ConsoleWritten += Python_ConsoleWritten;
                python.ErrorWritten += Python_ErrorWritten;

                string program = "for i in range(0, 10):" +
                                 "  print \"IronPython rules\"";

                python.Evaluate(program);

                dynamic output = python.Evaluate("3 ** 3");
                Console.WriteLine(output);

                Console.ReadKey();
            }
        }

        private static void Python_ErrorWritten(object sender, string e)
        {
            Console.Write(e);
        }

        private static void Python_ConsoleWritten(object sender, string e)
        {
            Console.Write(e);
        }
    }
}
