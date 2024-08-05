using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTest
{
    static class WhereNot
    {
        public static IEnumerable<T> WhereNotEqualsByHarsh<T>(this IEnumerable<T> enumerable, Predicate<T> compareMethod)
        {
            foreach (T item in enumerable)
            {
                if (compareMethod(item))
                {
                    continue;
                }
                yield return item;
            }
        }
    }
}
