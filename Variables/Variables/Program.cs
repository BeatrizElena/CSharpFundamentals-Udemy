using System;


namespace CSharpFundamentals
{
    class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //convert a given code to a corresponding shipping method
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString()); //.ToString() is not absolutely needed in this line

            // Parse a string into a shipping method. Or, converting from method name to shipping method enum: 
            // Using parsing (i.e. getting a string and converting it to a different type.)
            // Use .NET class Enum, defined in the System namespace, which has several methods, including 
            // .Parse(parameter1: Type enum Type, parameter2: string value that returns an object, not a shipping method)
            // to get the shipping method, we need to parse the object as (ShippingMethod) at the beginning of the line.
            // finally, we can store the value of the expression in a var, e.g. shippingMethod
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
/*Output:

*/