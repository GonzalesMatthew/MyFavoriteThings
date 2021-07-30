using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Book
    {
        public string Name { get; set; } = "Great Expectations";
        public int Page { get; set; } = 97;

        public void ResumeReading()
        {
            Console.WriteLine($"You pick up your book and begin reading at page {Page}.");
        }
        public void Declare()
        {
            Console.WriteLine($"You stand on top of your chair and declare to the world {Name} is the greatest book ever written!.");
        }
    }
}
