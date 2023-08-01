using Monads;

Maybe<int> Divide(int numerator, int denominator)
{
    if (denominator == 0)
        return Maybe<int>.None();

    return Maybe<int>.Some(numerator / denominator);
}

var invalidResult = Maybe<int>.Some(10)
    .Bind(num => Divide(num, 0))
    .Bind(num => Divide(num, 5));

//Nem lesz eredménye,
//mert a második osztás már null-ra viszi az eredményt
if (!invalidResult.HasValue)
    Console.WriteLine("Invalid division");



//-----------------------------------------------------------------------

Either<string, int> EitherDivide(int numerator, int denominator)
{
    if (denominator == 0)
        return Either<string, int>.Left("Division by zero");

    return Either<string, int>.Right(numerator / denominator);
}

var result = EitherDivide(10, 2)
    .Bind(num => EitherDivide(num, 5))
    .Select(num => num * 10);

if (result.IsRight)
    Console.WriteLine($"Result: {result.RightValue}");
else
    Console.WriteLine($"Error: {result.LeftValue}");

//-----------------------------------------------------------------------

State<int, int> Increment()
{
    return state => (state += 10, state);
}

State<int, int> GetCounter()
{
    return state => (state, state);
}

var incrementAndGetCounter = Increment()
    .Bind(_  => Increment())
    .Bind(_ => GetCounter());

var initialState = 0;
var (finalState, state) = incrementAndGetCounter.Invoke(initialState);


Console.WriteLine($"Initial State: {initialState}");
Console.WriteLine($"Final State: {finalState}");
Console.WriteLine($"State: {state}");


//-----------------------------------------------------------------------

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

List<int> multipliedNumbers = numbers.Bind(num => new List<int> { num * 2 });

Console.WriteLine(string.Join(", ", multipliedNumbers));

//-----------------------------------------------------------------------

Writer<List<string>, double> LogDivide(double dividend, double divisor)
{
    if (divisor == 0)
        return new Writer<List<string>, double>(new List<string> { "Error: Division by zero" }, 0);

    var result = dividend / divisor;
    return new Writer<List<string>, double>(new List<string>(), result);
}

Writer<List<string>, double> Multiply(double a, double b)
{
    var result = a * b;
    return new Writer<List<string>, double>(new List<string>(), result);
}

Writer<List<string>, T> Log<T>(string message, T value)
{
    return new Writer<List<string>, T>(new List<string> { message }, value);
}

var computation = LogDivide(10, 2)
    .Bind(result => Log($"Division Result: {result}", result))
    .Bind(result => Multiply(result, 5))
    .Bind(result => Log($"Multiplication Result: {result}", result));

Console.WriteLine($"Final Result: {computation.Value}");
Console.WriteLine($"Log Messages:");
Console.WriteLine(string.Join("\n", computation.Log));