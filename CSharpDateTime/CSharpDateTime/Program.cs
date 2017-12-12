using System;

namespace CSharpDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Bea Ortiz ";
            Console.WriteLine("Trim(): '{0}'", fullName.Trim());
            Console.WriteLine("Trim().ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var name = fullName.Split(' ');
            Console.WriteLine("First Name: " + name[0]);
            Console.WriteLine("Last Name: " + name[1]);

            Console.WriteLine(fullName.Replace("Bea", "Beatriz"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte((str));
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
