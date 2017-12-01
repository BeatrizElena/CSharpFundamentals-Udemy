using System;


namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
>>>>>>> parent of 6708482... Conditionals: If/Else Operators ? and :
            }
        }
    }
}
