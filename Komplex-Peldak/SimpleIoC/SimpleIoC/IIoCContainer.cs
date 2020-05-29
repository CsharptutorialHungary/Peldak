namespace SimpleIoC
{
    public interface IIoCContainer
    {
        void Register<TInterface, TClass>()
            where TInterface : class
            where TClass : class, TInterface;

        void RegisterSingleton<TInterface, TClass>()
            where TInterface : class
            where TClass : class, TInterface;

        TInterface Resolve<TInterface>()
            where TInterface : class;
    }
}
