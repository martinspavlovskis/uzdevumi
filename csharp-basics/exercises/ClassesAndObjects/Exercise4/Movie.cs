using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        public string Title;
        public string Studio;
        public string Rating;

        public Movie(string title, string studio, string rating)
        {
            this.Title = title;
            this.Studio = studio;
            this.Rating = rating;
        }
        public Movie(string title, string studio)
        {
            this.Title = title;
            this.Studio = studio;
            this.Rating = "PG";
        }
        public static Movie[] GetPG(Movie[] mov)
        {
            Movie[] pgMov = new Movie[mov.Length];

            pgMov = mov.Where(c => c.Rating == "PG").ToArray();
            Console.WriteLine(string.Join(",", pgMov.Select(m => m.Title)));
            return pgMov;

        }
    }
}
