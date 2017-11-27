using System;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bea";
            String lastName = "Ortiz";
            string myName = "Bea"; // string & String are the same but String needs System namespace on top.
            // concatenation ex.
            var fullName = firstName + " " + lastName;
            // string.Format ex.
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            //string.Join ex.
            var names = new string[3] { "John", "Jack", "Mary" };
            // combine with the string.Join() method where the 1st argument is a string
            // which represents a separator (using the comma as the separator)
            //and the 2nd argument is the name of the array.
            var formattedNames = string.Join(",", names);
            //display the results on the console
            Console.WriteLine(formattedNames);
            // using verbatim strings
            // messy look of normal string
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            //cleaned up look of verbatim string
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text2);

        }
    }
}
/*Output:

*/