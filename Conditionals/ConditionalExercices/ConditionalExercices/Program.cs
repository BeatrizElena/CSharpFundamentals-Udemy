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

            Console.WriteLine("Enter a number");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            var number2 = Convert.ToInt32(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max number is: {0}", max);
        }
    }
}
