using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public Movie(string title, string genre, string director)
        {
            Title = title;
            Genre = genre;
            Director = director;
        }

        public void Watch()
        {
            Console.WriteLine($"You get cozy on the couch and watch {Title}.");
        }

        public void Rewind()
        {
            Console.WriteLine($"You eject the VHS copy of {Title} and rewind it to the beginning.");
        }
    }
}
