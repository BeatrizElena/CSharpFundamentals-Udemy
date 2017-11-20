using System;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a / b); // will output 3
            Console.WriteLine((float)a / (float)b); // will output 3.33333...
        }
    }
}
