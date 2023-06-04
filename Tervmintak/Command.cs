using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tervmintak.CommandMinta;

internal interface ICommand
{
    string Name { get; }
    void Execute();
}

internal class ClearCommand : ICommand
{
    public string Name => "clear";

    public void Execute() => Console.Clear();
}

internal class HelloCommand : ICommand
{
    public string Name => "hello";

    public void Execute() => Console.WriteLine("Hello command!");
}

internal class ExitCommand : ICommand
{
    public string Name => "exit";

    public void Execute() => Environment.Exit(0);
}

public class CommandRunner
{
    private List<ICommand> _commands;

    public CommandRunner()
    {
        _commands = new List<ICommand>
        {
            new ClearCommand(),
            new HelloCommand(),
            new ExitCommand(),
        };
    }

    public void Run()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                continue;
            }
            var command = _commands.Where(cmd => cmd.Name == input).FirstOrDefault();
            if (command == null)
            {
                Console.Write($"Unknown command: {input}");
                continue;
            }
            command.Execute();
        }
    }
}
