using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Exercise
    {
        public bool RequiresWeights { get; set; } = true;
        public string Name { get; set; } = "Curls";

        public void BeefUp()
        {
            Console.WriteLine($"You do a lot of {Name} and turn beefy.");
        }
        public void Rest()
        {
            Console.WriteLine($"You take a break so you can do more {Name} soon.");
        }
    }
}
