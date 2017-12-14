using System;
using System.Text;


namespace CSharpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('$', 10));
            Console.WriteLine("Insert(): " + builder);

            Console.WriteLine("First Char (builder[0]: " + builder[0]);
        }

    }
}
