using System;

namespace CSharpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new System.DateTime(2017, 1, 1);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            // DateTime objects are inmutable. To add/subtract days, use these methods:
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            // Convert to string methods
            Console.WriteLine("\r\nToLongDateString() method: " + now.ToLongDateString());
            Console.WriteLine("\nToShortDateString() method: " + now.ToShortDateString());
            Console.WriteLine("\nToLongTimeString() method: " + now.ToLongTimeString());
            Console.WriteLine("\nToShortTimeString() method: " + now.ToShortTimeString());
            Console.WriteLine("\nToString() method displays Date & Time: " + now.ToString());
            Console.WriteLine("\nToString() with format-specifier: " + now.ToString("yyyy-MM-dd"));
            Console.WriteLine("\nToString() with more format-specifiers: " + now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
