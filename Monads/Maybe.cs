using System.Diagnostics.CodeAnalysis;

namespace Monads;

public class Maybe<T>
{
    private readonly T? _value;
    
    private Maybe(T? value)
    { 
        _value = value;
    }

    public static Maybe<T> Some(T value)
    {
        return new Maybe<T>(value);
    }

    public static Maybe<T> None()
    {
        return new Maybe<T>(default);
    }

    [MemberNotNullWhen(true, nameof(_value))]
    public bool HasValue => !EqualityComparer<T>.Default.Equals(_value, default);

    public T Value => HasValue ? _value : throw new InvalidOperationException("Maybe does not have a value.");

    public Maybe<TResult> Bind<TResult>(Func<T, Maybe<TResult>> func)
    {
        if (HasValue)
            return func(_value);

        return Maybe<TResult>.None();
    }
}