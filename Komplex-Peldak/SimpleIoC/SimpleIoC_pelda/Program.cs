using SimpleIoC;
using System;

namespace SimpleIoC_pelda
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IIoCContainer container = new IoCContainer();
                container.RegisterSingleton<IRandomProvider, RandomProvider>();
                container.RegisterSingleton<ILog, Log>();

                container.Register<IRandomInstance, RandomInstance>();

                for (int i = 0; i < 10; i++)
                {
                    IRandomInstance instance = container.Resolve<IRandomInstance>();
                    instance.Print();
                }
            }
            catch (ResolveException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
