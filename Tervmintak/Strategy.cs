namespace Tervmintak.Strategy;

internal interface IOperationStrategy
{
    double Calculatge(double x, double y);
}

internal class AddStrategy : IOperationStrategy
{
    public double Calculatge(double x, double y)
    {
        return x + y;
    }
}

internal class SubtractStrategy : IOperationStrategy
{
    public double Calculatge(double x, double y)
    {
        return x - y;
    }
}

internal class MultiplyStrategy : IOperationStrategy
{
    public double Calculatge(double x, double y)
    {
        return x * y;
    }
}

internal class DivideStrategy : IOperationStrategy
{
    public double Calculatge(double x, double y)
    {
        return x / y;
    }
}

public class CalculatorContext
{
    private IOperationStrategy? _strategy;

    public void SetStrategy(char @operator)
    {
        switch (@operator)
        {
            case '+':
                _strategy = new AddStrategy();
                break;
            case '-':
                _strategy = new SubtractStrategy();
                break;
            case '*':
                _strategy = new MultiplyStrategy();
                break;
            case '/':
                _strategy = new DivideStrategy();
                break;
            default:
                throw new InvalidOperationException($"Invalid operator: {@operator}");
        }
    }

    public double Calculate(double x, double y) 
    {
        if (_strategy == null)
            throw new InvalidOperationException("No strategy has been set");

        return _strategy.Calculatge(x, y);
    }
}