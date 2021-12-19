using System;

namespace MockExample
{
    public interface INumberProvider
    {
        int GetRandomNumber(int minimum, int maximum);
    }

    public interface IConsole
    {
        void WriteLine(string message);
        int Width  { get; }
        event EventHandler<int> WidthChanged;
    }

    public class NumberConsumer
    {
        private readonly INumberProvider _numberProvider;
        private readonly IConsole _console;
        private int _currentConsoleWidth;

        public NumberConsumer(INumberProvider numberProvider, IConsole console)
        {
            _numberProvider = numberProvider;
            _console = console;
        }

        public void Initialize()
        {
            _console.WidthChanged += OnWithChange;
        }

        public void Deinitialize()
        {
            _console.WidthChanged -= OnWithChange;
        }

        private void OnWithChange(object? sender, int e)
        {
            _currentConsoleWidth = e;
        }

        public void DisplayNumber(int minimum, int maximum)
        {
            int number = _numberProvider.GetRandomNumber(minimum, maximum);
            string str = number.ToString().PadLeft(_currentConsoleWidth, ' ');
            _console.WriteLine(str);
        }
    }
}
