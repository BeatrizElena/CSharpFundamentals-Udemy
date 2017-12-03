using System;


namespace CSharpFundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 2, 14, 6};
            // Length (non-static method of the instance numbers)
            Console.WriteLine("Length: " + numbers.Length);

            // The follwng are static methods of Array
            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            /* outputs:
             Effect of Clear()
             0
             0
             9
             2
             14
             6
            */

            // Copy()
            // declare another array to copy into
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);
         
            /* outputs:
             Effect of Copy()
             0
             0
             9
            */

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            /* outputs:
            Effect of Sort()
            0
            0
            2
            6
            9
            14
            */

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            /* outputs:
            Effect of Reverse()
            14
            9
            6
            2
            0
            0
            */
        }
    }
}
/*Output:

*/
