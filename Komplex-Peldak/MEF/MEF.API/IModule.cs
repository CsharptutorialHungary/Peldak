namespace MEF.API
{
    public interface IModule
    {
        IHost Host { get; set; }
        string Name { get; }
        void Run();
    }
}
