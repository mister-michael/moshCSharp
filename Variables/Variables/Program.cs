using System;
using Variables.Math;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int is a Value Type, a's value is copied to b
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a,b));
            //prints a: 10, b:11

            //Arrays are a Reference Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //array1's value is stored in memory in the heap at an "address"
            //array1 is defined in the stack as having the value of that "address"
            //array2's value is array1's value is the same as the "address" value
            //they REFERENCE the address
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


        }
    }
}