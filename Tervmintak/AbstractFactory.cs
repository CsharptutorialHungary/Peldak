namespace Tervmintak
{
    interface IUiElement 
    {
        void Render();
    }

    interface IWindow : IUiElement
    {
        IList<IUiElement> Elements { get; }
    }

    class WindowsWindow : IWindow
    {
        public IList<IUiElement> Elements { get; }

        public WindowsWindow()
        {
            Elements = new List<IUiElement>();
        }

        public void Render()
        {
            Console.WriteLine("WindowsWindow Render");
            foreach (var element in Elements)
            {
                element.Render();
            }
        }
    }

    class LinuxWindow : IWindow
    {
        public IList<IUiElement> Elements { get; }

        public LinuxWindow()
        {
            Elements = new List<IUiElement>();
        }

        public void Render()
        {
            Console.WriteLine("LinuxWindow Render");
            foreach (var element in Elements)
            {
                element.Render();
            }
        }
    }

    interface IUiFactory
    {
        IWindow CreateWindow();
    }

    class WindowsUiFactory : IUiFactory
    {
        public IWindow CreateWindow()
        {
            return new WindowsWindow();
        }
    }

    class LinuxUiFactory : IUiFactory
    {
        public IWindow CreateWindow()
        {
            return new LinuxWindow();
        }
    }

    class Application
    {
        private readonly IUiFactory _factory;

        public Application(IUiFactory factory) 
        {
            _factory = factory;
        }

        public void Run()
        {
            var window = _factory.CreateWindow();
            window.Render();
        }
    }
}
