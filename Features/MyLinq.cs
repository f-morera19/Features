using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    //Definition of Extesion methods
    public static class MyLinq
    {
        //We can call this method using the static method sintax or anywhere where implementing IEnumerable<T>
        //eg. IEnumerable<T> X.Count()
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            //We can use implicit typing as long as we initialize the varible (Not null)
            var count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
