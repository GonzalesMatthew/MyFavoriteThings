using System;
using MyFavoriteThings.FavoriteThings;
namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book()
            {
                Name = "Dark Tower",
                Page = 100
            };
            var anotherBook = new Book();
            var car = new Car()
            { 
                Color = "red",
                HorsePower = 600
            };
            var anotherCar = new Car();
            var exercise = new Exercise()
            {
                RequiresWeights = false,
                Name = "crunches",
            };
            var anotherExercise = new Exercise();
            var music = new Music()
            { 
                Genre = "Metal",
                Duration = 100,
            };
            var moreMusic = new Music();

            book.ResumeReading();
            anotherBook.Declare();
            car.Admire();
            anotherCar.Speed();
            music.Concentrate();
            moreMusic.Listen();
            exercise.BeefUp();
            anotherExercise.Rest();


        }
    }
}
