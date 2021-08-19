using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }
        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }
        public static Movie[] GetPG(Movie[] mov)
        {
            Movie[] pgMov = new Movie[mov.Length];

            pgMov = mov.Where(c => c._rating == "PG").ToArray();
            Console.WriteLine(string.Join(",", pgMov.Select(m => m._title)));
            return pgMov;
        }
    }
}
