using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;

namespace DLR_Csharp
{
    public class ScriptEngine
    {
        private static ScriptState<object> scriptState;
        public static object Execute(string code)
        {
            if (scriptState == null)
                scriptState = CSharpScript.RunAsync(code).Result;
            else
                scriptState = scriptState.ContinueWithAsync(code).Result;

            if (scriptState.ReturnValue != null && !string.IsNullOrEmpty(scriptState.ReturnValue.ToString()))
                return scriptState.ReturnValue;

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine.Execute(
                @"public class Demo
                {
                     public string HelloWorld {get;set;}
                     public Demo()
                     {
                        HelloWorld = ""Hello Roslyn!"";
                     }
                }");
            Console.WriteLine(ScriptEngine.Execute("new Demo().HelloWorld"));
            Console.ReadKey();
        }
    }
}
