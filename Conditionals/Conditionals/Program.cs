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
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect weather to go to the beach");
                    break;

                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }
    }
}
