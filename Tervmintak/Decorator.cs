using System.Text;

namespace Tervmintak;

internal interface IDataSource
{
    void WriteData(string data);
    string ReadData();
}

internal class FileDataSoruce : IDataSource
{
    private readonly string _fileName;

    public FileDataSoruce()
    {
        _fileName = Path.Combine(AppContext.BaseDirectory, "data.txt");
    }

    public string ReadData()
    {
        return File.ReadAllText(_fileName);
    }

    public void WriteData(string data)
    {
        File.WriteAllText(_fileName, data);
    }
}


internal class DataSourceDecorator : IDataSource
{
    private readonly IDataSource _decorated;

    public DataSourceDecorator(IDataSource decorated)
    {
        _decorated = decorated;
    }

    public virtual string ReadData()
    {
        return _decorated.ReadData();
    }

    public virtual void WriteData(string data)
    {
        _decorated.WriteData(data);
    }
}

internal class Base64DataSourceDecorator : DataSourceDecorator
{
    public Base64DataSourceDecorator(IDataSource decorated) : base(decorated)
    {
    }

    public override string ReadData()
    {
        byte[] bytes = Convert.FromBase64String(base.ReadData());
        return Encoding.UTF8.GetString(bytes);
    }

    public override void WriteData(string data)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(data);
        base.WriteData(Convert.ToBase64String(bytes));
    }
}