namespace Monads;

public delegate (TState, TResult) State<TState, TResult>(TState state);

public static class StateMonadExtensions
{
    public static State<TState, TResult> ToState<TState, TResult>(this TResult value)
    {
        return state => (state, value);
    }

    public static State<TState, TResult> Bind<TState, TIntermediate, TResult>(
        this State<TState, TIntermediate> state,
        Func<TIntermediate, State<TState, TResult>> func)
    {
        return initialState =>
        {
            var (intermediateState, intermediateResult) = state(initialState);
            return func(intermediateResult)(intermediateState);
        };
    }

    public static State<TState, TResult> Select<TState, TSource, TResult>(
        this State<TState, TSource> state,
        Func<TSource, TResult> selector)
    {
        return state.Bind(value => selector(value).ToState<TState, TResult>());
    }

    public static State<TState, TResult> SelectMany<TState, TSource, TIntermediate, TResult>(
        this State<TState, TSource> state,
        Func<TSource, State<TState, TIntermediate>> intermediateSelector,
        Func<TSource, TIntermediate, TResult> resultSelector)
    {
        return state.Bind(value => intermediateSelector(value).Bind(intermediateValue =>
            resultSelector(value, intermediateValue).ToState<TState, TResult>()));
    }
}