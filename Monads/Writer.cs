using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monads;

public class Writer<TLog, TValue>
{
    public TLog Log { get; }
    public TValue Value { get; }

    public Writer(TLog log, TValue value)
    {
        Log = log;
        Value = value;
    }

    public Writer<TLog, TResult> Bind<TResult>(Func<TValue, Writer<TLog, TResult>> func)
    {
        var result = func(Value);
        return new Writer<TLog, TResult>(CombineLogs(Log, result.Log), result.Value);
    }

    public Writer<TLog, TResult> Select<TResult>(Func<TValue, TResult> selector)
    {
        return new Writer<TLog, TResult>(Log, selector(Value));
    }

    private static TLog CombineLogs(TLog log1, TLog log2)
    {
        if (log1 == null)
            return log2;
        if (log2 == null)
            return log1;

        if (log1 is ICollection<string> collection1 && log2 is ICollection<string> collection2)
        {
            var combinedLogs = new List<string>(collection1);
            combinedLogs.AddRange(collection2);
            return (TLog)(object)combinedLogs;
        }
        throw new InvalidOperationException("Combining logs is not supported for the given type.");
    }
}