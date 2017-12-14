using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// code that works with the console and code that works with the logic are both written inside the Program class
namespace CSharpFundamentals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);

            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
