using System;
using Variables.Math;


namespace Variables
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            //prints 3

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            //prints Express

            Console.WriteLine(method.ToString());
            //prints Express

            Console.WriteLine(method);
            //prints Express, default of Cons.WrLine is toString()

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            //prints Express


        }
    }
}