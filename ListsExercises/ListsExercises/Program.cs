using System;
using System.Collections.Generic;

namespace ListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1: Continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            // Depending on the number of names provided, display a message.
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

            // 2-Ask the user to enter their name. 
            // Use an array to reverse the name and then store the result in a new string. 
            // Display the reversed name on the console.
            Console.WriteLine("Enter your name");
            var userName = Console.ReadLine();
            var nameArray = new char[userName.Length];
            Console.WriteLine(nameArray);

            //foreach (var i in nameArray)
            //{
            //    nameArray[userName.Length - i] = userName[i - 1];
            //}
            //var reverseArray = new string(nameArray);
            //Console.WriteLine("Reversed name: " + reverseArray);
            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //Console.WriteLine();
            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            //Console.WriteLine("Count: " + numbers.Count);

            //numbers.Remove(1);
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            // in c#, we're not allowed to modify the collection usinf a foreach loop
            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //        // the follwng line will throw an exception if inside a foreach loop. 
            //        // We need a for loop instead.
            //        numbers.Remove(number);
            //}
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //for (var i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 1)
            //        numbers.Remove(numbers[i]);
            //}
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //numbers.Clear();
            //Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
