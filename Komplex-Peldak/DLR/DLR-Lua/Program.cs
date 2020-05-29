using NLua;
using System;

namespace DLR_Lua
{
    class Program
    {
        static void Main(string[] args)
        {
            Lua state = new Lua();
            object[] results = state.DoString("return \"Hello Lua\"");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
