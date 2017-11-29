using System;


namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
            {
                price = 29.95f;
            }

            // The same code above can be re-written using conditional operators ? (for if) and : (for else)
            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }
    }
}
