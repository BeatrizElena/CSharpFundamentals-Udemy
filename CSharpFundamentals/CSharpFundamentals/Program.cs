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
        // Main class will have only the code that works with the console.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            // call the method ReverseName
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }

        // public string class into which to put the code that deals with logic.
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            return reversed;
        }
    }
}
