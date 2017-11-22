using System;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); // defaults to 0 if not initialized
            Console.WriteLine(numbers[2]); // defaults to 0 if not initialized

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); // defaults to False if not initialized
            Console.WriteLine(flags[2]); // defaults to False if not initialized

            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
/*Output:
1
0
0
True
False
False
*/