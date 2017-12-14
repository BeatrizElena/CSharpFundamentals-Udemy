using System;
using System.Collections.Generic;

namespace CSharp1ExercisesVI.ArraysAndLists
{
    public class Lists
    {
        public void Exercise1()
        {
            /* Continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
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
        }

        //public void Exercise2()
        //{
        //    /* Ask the user to enter their name.  Use an array to reverse the name and then store the result in a new string. 
        //    Display the reversed name on the console. */
        //    Console.WriteLine("Enter your name");
        //    var userName = Console.ReadLine();
        //    var nameArray = new char[userName.Length];
        //    Console.WriteLine(nameArray);
        //}
    }
}
