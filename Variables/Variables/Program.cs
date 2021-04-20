using System;
using Variables.Math;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3] { 2, 2, 3 };
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3] { true, true, false };
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            Console.WriteLine(names[1]);
        }
    }
}