using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        private string Title;
        private string Studio;
        private string Rating;

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
        public static Movie[] GetPG(Movie[] movies)
        {          
          return movies.Where(c => c.Rating == "PG").ToArray();
        }
    }
}
