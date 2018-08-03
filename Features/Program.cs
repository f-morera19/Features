using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last paramenter corresponds with the return type, all other are the parameters' 
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) =>
            {
                int temp = x + y;
                return temp;
            };

            //Action methods always return a void, therefore <x> corresponds to the parameters
            Action<int> write = x => Console.WriteLine(x);

            write(square(add(3,5)));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"}
            };

            //This is an example for Implicit Typing
            //Use in local variables (imposible to use to define variables or fields in a class)
            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            //Method Syntax (Call Extension Methods)
            var query = developers.Where(e => e.Name.Length == 5)
                                  .OrderBy(e => e.Name);

            //Query Sintax (from...select...)
            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadKey();
        }
    }
}
