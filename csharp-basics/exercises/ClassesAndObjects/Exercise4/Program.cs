using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie[] moviesArr ={ 
                new Movie("Casino Royal", "Eon Productions", "PG13"),
                new Movie("Glass", "Buena Vista International", "PG13"),
                new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG") };

            Movie.GetPG(moviesArr);
          
        }
    }
}
