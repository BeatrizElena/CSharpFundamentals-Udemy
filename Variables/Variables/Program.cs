using System;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types
            var a = 10; // value 10 is saved in a specific stack location
            // Copy a to b. A new location in stack is created to hold the value of b.
            var b = a; 
            // increment b by one, a does not change bc its value was copied
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // Reference types
            var array1 = new int[3] { 1, 2, 3 };
            // copy array1 to array 2
            var array2 = array1;
            // Modify array2. This will modify array1 bc both arrays are a REFERENCE to the memory address
            // The memory address is located in the heap.
            // Neither var, array1 nor array2, is referencing the actual values
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
/*Output:
a: 10, b: 11
array1[0]: 0, array2[0]: 0
*/
