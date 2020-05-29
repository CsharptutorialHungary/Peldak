namespace MEF.API
{
    public interface IHost
    {
        void WriteLine(string format, params object[] parameters);
        void Write(string format, params object[] parameters);
        void Clear();
        string WorkDirectory { get; }
    }
}
