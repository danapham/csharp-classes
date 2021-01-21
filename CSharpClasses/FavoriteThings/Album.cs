using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.FavoriteThings
{
    public class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public void Listen()
        {
            Console.WriteLine($"You listen to {Title}");
        }

        public void Discuss()
        {
            Console.WriteLine($"You have a deep discussion about {Artist}'s vision for {Title}");
        }
    }
}
