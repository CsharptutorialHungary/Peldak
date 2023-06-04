using System.Text;

namespace Tervmintak.Composite;

internal interface IEmployee
{
    string GetDetails();
}

internal class Developer : IEmployee
{
    public string Name { get; }
    public string Project { get; }
    public long Id { get; }

    public Developer(long id, string name, string project)
    {
        Name = name;
        Project = project;
        Id = id;
    }

    public string GetDetails()
    {
        return $"Name: {Name}, Project: {Project}, Id: {Id}";
    }
}

internal class Manager : IEmployee
{
    public string Name { get; }
    public long Id { get; }
    public IList<IEmployee> Employees { get;}

    public Manager(long id, string name)
    {
        Name = name;
        Id = id;
        Employees = new List<IEmployee>();
    }

    public string GetDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Manager: {Name}, Id: {Id}");
        sb.AppendLine("Employees:");
        foreach (var employee in Employees)
        {
            sb.AppendLine(employee.GetDetails());
        }
        return sb.ToString();
    }
}
