using System;
// TimeSpan()
namespace CSharpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("TimeSpan(1, 2, 3) : " + timeSpan);
            Console.WriteLine("TimeSpan(1, 0, 0) : " + timeSpan1);
            Console.WriteLine("TimeSpan.FromHours(1) : " + timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes Component of timeSpan Variable: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes adds all minutes in timeSpan Variable: " + timeSpan.TotalMinutes);

            // TimeSpan is inmutable
            // Add & Subtract methods
            Console.WriteLine("Add 8 minutes " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract 2 minutes: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString(): Converts TimeSpan to a string
            // Parse() converts a string to a TimeSpan
            Console.WriteLine("ToString() converts TimeSpan to a string: " + timeSpan.ToString());
            Console.WriteLine("Parse from string to TimeSpan: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
