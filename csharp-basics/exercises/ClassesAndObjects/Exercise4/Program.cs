using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie("Casino Royal", "Eon Productions", "PG13");
            var movie2 = new Movie("Glass", "Buena Vista International", "PG13");
            var movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            Movie.GetPG(Movie[]);
        }
    }
}
