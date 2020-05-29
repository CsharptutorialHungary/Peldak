using MEF.API;
using System.ComponentModel.Composition;

namespace MEF.Modulok
{
    [Export(typeof(IModule))]
    public class ModuleHello : IModule
    {
        [Import(typeof(IHost))]
        public IHost Host { get; set; }

        public string Name => "Hello";

        public void Run()
        {
             Host?.WriteLine("Hello");
        }
    }

    [Export(typeof(IModule))]
    public class ModuleCls : IModule
    {
        [Import(typeof(IHost))]
        public IHost Host { get; set; }

        public string Name => "Clear";

        public void Run()
        {
            Host?.Clear();
        }
    }

    [Export(typeof(IModule))]
    public class ModulePwd: IModule
    {
        [Import(typeof(IHost))]
        public IHost Host { get; set; }

        public string Name => "Pwd";

        public void Run()
        {
            Host?.WriteLine(Host?.WorkDirectory);
        }
    }
}
