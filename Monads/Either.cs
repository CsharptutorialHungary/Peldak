namespace Monads;

public class Either<TLeft, TRight>
{
    private readonly TLeft? left;
    private readonly TRight? right;
    private readonly bool isLeft;

    private Either(TLeft? left, TRight? right, bool isLeft)
    {
        this.left = left;
        this.right = right;
        this.isLeft = isLeft;
    }

    public static Either<TLeft, TRight> Left(TLeft left)
    {
        return new Either<TLeft, TRight>(left, default, true);
    }

    public static Either<TLeft, TRight> Right(TRight right)
    {
        return new Either<TLeft, TRight>(default, right, false);
    }

    public bool IsLeft => isLeft;
    public bool IsRight => !isLeft;

    public TLeft? LeftValue => IsLeft ? left : throw new InvalidOperationException("Either is not Left.");
    public TRight? RightValue => IsRight ? right : throw new InvalidOperationException("Either is not Right.");

    public Either<TLeft?, TResult?> Bind<TResult>(Func<TRight?, Either<TLeft?, TResult?>> func)
    {
        if (IsRight)
            return func(right);

        return Either<TLeft?, TResult?>.Left(left);
    }

    public Either<TLeft?, TResult?> Select<TResult>(Func<TRight?, TResult?> selector)
    {
        return Bind(value => Either<TLeft?, TResult?>.Right(selector(value)));
    }
}
