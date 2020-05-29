using System;

namespace pelda_reflection2
{
    public class ModuleHello : IModule
    {
        public string Name => "Hello";

        public void Run()
        {
            Console.WriteLine("Hello");
        }
    }

    public class ModuleCls : IModule
    {
        public string Name => "Clear";

        public void Run()
        {
            Console.Clear();
        }
    }
}
