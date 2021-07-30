using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Music
    {
        public string Genre { get; set; } = "Ambient";
        public int Duration { get; set; } = 57;

        public void Listen()
        {
            Console.WriteLine($"You sit and listen to {Genre} music for {Duration} minutes.");
        }
        public void Concentrate()
        {
            Console.WriteLine($"You turn on {Genre} and begin to meditate.");
        }
    }
}
