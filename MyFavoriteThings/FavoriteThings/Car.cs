using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavoriteThings
{
    class Car
    {
        public string Color { get; set; } = "blue";
        public int HorsePower { get; set; } = 260;

        public void Admire()
        {
            Console.WriteLine($"You take a step back and admire your beautiful {Color} car.");
        }
        public void Speed()
        {
            Console.WriteLine($"You floor the pedal and the engine surges with all of its {HorsePower} horsepower!");
        }
    }
}
