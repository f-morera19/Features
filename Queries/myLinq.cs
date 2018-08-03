using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    public static class myLinq
    {
        //Extension Method
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                               Func<T,bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    //return each statement one at a time
                    yield return item;
                }
            }
        }
    }
}
