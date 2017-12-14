using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsPart2.Exercises.ArraysAndLists_VI_55_
{
    public class Lists
    {
        static void Main(string[] args)
        {
            /* Exercise 1: Continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
               Depending on the number of names provided, display a message.*/
            var names = new List<string>();
            Console.WriteLine("Enter as many names as you'd like. Press Enter after each name. When done, just press Enter");
            while (true)
            {
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                    break;
                names.Add(name);
            }

            if (names.Count == 1)
                Console.WriteLine(names[0] + " likes your post");
            else if (names.Count == 2)
                Console.WriteLine(names[0] + " and " + names[1] + " like your post");
            else
            {
                var others = names.Count - 2;
                Console.WriteLine(names[0] + ", " + names[1] + ", and " + others + " others like your post");
            }


            /* Exercise2 : Ask the user to enter their name.  Use an array to reverse the name and then store the result in a new string. 
            Display the reversed name on the console. */
            Console.WriteLine("Enter your name");
            var name2 = Console.ReadLine();
            char[] nameArray = name2.ToCharArray();
            Array.Reverse(nameArray);
            Console.WriteLine(nameArray);

            /* Exercise 3: User enters 5 numbers. 
             * If a number has been previously entered, display an error message and ask the user to re-try. 
             * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/
             var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {

                    Console.WriteLine("You already entered " + number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var number in numbers)
                Console.WriteLine("\n" + number);
            {
                
            }

        }
    }
}
