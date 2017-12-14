using System;
using System.Text;


namespace CSharpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine("Replace() - with +: " + builder);

            builder.Remove(0, 10);
            Console.WriteLine("Remove()  10 chars: " + builder);

            builder.Insert(0, new string('$', 10));
            Console.WriteLine("Insert(): " + builder);

            Console.WriteLine("First Char (builder[0]: " + builder[0]);
        }

    }
}
