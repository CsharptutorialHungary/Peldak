using System;
using System.Collections.Generic;

namespace pelda_tervminta_cor
{
    interface ICommand<T>
    {
        bool CanExecute(T context);
        void Execute(T Context);
    }

    class Command1 : ICommand<List<string>>
    {
        public bool CanExecute(List<string> context)
        {
            return context != null;
        }

        public void Execute(List<string> Context)
        {
            Context.Add("Command1");
        }
    }

     class Command2 : ICommand<List<string>>
    {
        public bool CanExecute(List<string> context)
        {
            return context != null && 
                   context.Count > 0;
        }

        public void Execute(List<string> Context)
        {
            Context.Add("Command2");
        }
    }

    class Runner
    {
        List<ICommand<List<string>>> _commands;
        List<string> _context;


        public Runner(params ICommand<List<string>>[] commands)
        {
            _context = new List<string>();
            _commands = new List<ICommand<List<string>>>(commands);
        }

        public void Run()
        {
            foreach (var command in _commands)
            {
                if (!command.CanExecute(_context)) break;
                command.Execute(_context);
            }

            foreach (var item in _context)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Runner r = new Runner(new Command1(), new Command2());
            r.Run();
            Console.ReadKey();
        }
    }
}
