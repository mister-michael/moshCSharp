using System;
using Variables.Math;


namespace Variables
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers seperated by commas.");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var final = 0;
            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > final)
                    final = number;
            }
            Console.WriteLine(final);
        }

        public void Exercise1()
        {
            var count = 0;
            for (var i = 0; i < 100; i++)
                if (i % 2 == 0)
                    count++;
            Console.WriteLine("There are {0} even numbers", count);
        }

        public void Exercise2()
        {
            var total = 0;
            while (true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                total += Convert.ToInt32(input);
            }
            Console.WriteLine("The sum is {0}", total);
        }

        public void Exercise3()
        {
            Console.Write("Enter a number to compute: ");
            var input = Convert.ToInt32(Console.ReadLine());
            for (var i = input - 1; i > 0; i--)
                input *= i;
            Console.WriteLine(input);
        }

        public void Exercise4()
        {
            var number = new Random().Next(1, 10);
            Console.WriteLine("The number is " + number);

            for (var i = 4; i > 0; i--)
            {
                Console.Write("Guess a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }

            Console.WriteLine("The number is {0}", number);
        }
    }
}