using System;


namespace CSharpFundamentals
{
    public class Person2
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            // pass Increment() method def'd below
            Increment(number); // value of number is still 1 bc it is a value type and the var number 
            // is only def'd within the method Main
            Console.WriteLine(number);

            var person = new Person2() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person2 person)
        {
            person.Age += 10;
        }
    }
}
/*Output:

*/
