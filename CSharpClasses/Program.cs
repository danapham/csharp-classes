using System;
using CSharpClasses.FavoriteThings;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie1 = new Movie("Arrival", "Sci-Fi", "Denis Villeneuve");
            movie1.Watch();

            var movie2 = new Movie("Grey Gardens", "Documentary", "Maysles Brothers");
            movie2.Rewind();

            var album1 = new Album("Geidi Primes", "Grimes");
            album1.Listen();
            album1.Discuss();
        }
    }
}
