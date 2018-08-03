using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie {Title = "The Dark Knight", Rating = 8.9f, Year = 2008},
                new Movie {Title = "Blade Runer 2049", Rating = 9.8f, Year = 2018 },
                new Movie {Title = "Schindler's List", Rating = 9.2f, Year = 1993},
                new Movie {Title = "Casablanca", Rating = 9.5f, Year = 1942},
                new Movie {Title = "Star Wars", Rating = 8.7f, Year = 1977}
            };

            /*
             Streaming operators: Visits one item at a time. Eg. "Where"
             No streaming operators: Must visit ALL items. Eg. "OrderBy"
             */

            //Contrary to deferred Queries, Methods like ToList force inmediate excetion of the query
            var query = movies.Where(m => m.Year > 2000)
                              //.Take(2)
                              .OrderByDescending(m => m.Rating);//.ToList();

            //var query2 = movies.Filter(m => m.Year > 2000);

            var enumerator = query.GetEnumerator();
            Console.WriteLine("****");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }
            Console.ReadKey();
        }
    }
}
