using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monads;

public static class ListMonadExtensions
{
    public static List<TResult> Bind<TSource, TResult>(this IEnumerable<TSource> source, 
                                                       Func<TSource, IEnumerable<TResult>> func)
    {
        var result = new List<TResult>();
        foreach (var item in source)
        {
            result.AddRange(func(item));
        }
        return result;
    }
}
