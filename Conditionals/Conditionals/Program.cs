using System;


namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                // same code will be ran for the 2 cases below
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We're running a promotion.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
