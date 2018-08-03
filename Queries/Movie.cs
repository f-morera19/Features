using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        int _year;
        public int Year
        {    get
            {
                //throw new Exception("Error!");
                Console.WriteLine($"Accesing {_year} for {Title}");
                return _year;
            }
            set
            {
                this._year = value;
            }
        }
    }
}
