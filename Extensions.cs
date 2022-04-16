using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    internal static class Extensions
    {
        public static string Stars(this int i) => new string('*', i);


        public static IEnumerable<int> OnlyEven(this IEnumerable<int> source)
        {
            foreach (var item in source)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }

        public static IEnumerable<T2> Transform<T1, T2>(this IEnumerable<T1> source, Func<T1, T2> fn)
        {
            foreach (var item in source)
            {
                var result = fn(item);
                yield return result;
            }
        }
    }
}
