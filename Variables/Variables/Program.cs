using System;
using Variables.Math;


namespace Variables
{
    public class Guy
    {
        public int Age;
    }

    class Program
    {
       
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            //prints 1

            var guy = new Guy() { Age = 20 };
            MakeOld(guy);
            Console.WriteLine(guy.Age);

            
        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Guy guy)
        {
            guy.Age += 10;
        }
    }
}