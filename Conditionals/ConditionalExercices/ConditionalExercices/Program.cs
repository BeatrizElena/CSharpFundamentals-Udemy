using System;


namespace ConditionalExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var number = Convert.ToInt32(Console.ReadLine());
            var intake = (number >= 1 && number <= 10) ? "Valid" : "Invalid";
            Console.WriteLine(intake);
        }
    }
}
