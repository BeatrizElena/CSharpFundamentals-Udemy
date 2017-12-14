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

            // take two numbers from console and display the max. of the two.
            Console.WriteLine("Enter a number");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            var number2 = Convert.ToInt32(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max number is: {0}", max);

            // user inputs width and height. Display if the image is landscape or portrait.
            Console.WriteLine("Enter the width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height");
            var height = Convert.ToInt32(Console.ReadLine());
            var position = (width > height) ? "Landscape" : "Portrait";
            Console.WriteLine(position);

            // give 1 demerit for every 5MPH/hr over speed limit. If demerits go above 12, suspend license
            Console.WriteLine("What's the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the speed of the car?");
            var currentSpeed = Convert.ToInt32(Console.ReadLine());
            const int speedAbove = 5;
            var demerits = (currentSpeed - speedLimit) / speedAbove;
            if (currentSpeed < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else if ( demerits > 12)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                Console.WriteLine("Demerit Points: {0}", demerits);
            }
        }
    }
}
