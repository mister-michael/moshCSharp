using System;
using Lists.Math;
using System.Collections.Generic;


namespace Lists
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter five numbers seperated by commas: ");
            var input = Console.ReadLine().Split(',');
            var numberList = new List<int>();
            var smallests = new List<int>();

            foreach (var number in input)
                numberList.Add(Convert.ToInt32(number));

            if (numberList.Count != 5)
                Console.WriteLine("Try again, five numbers only");

            else
            {
                numberList.Sort();
                for (var i = 0; i < 3; i++)
                    smallests.Add(numberList[i]);
            }

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var input = Console.ReadLine();
                if (names.Contains(input))
                {
                    break;
                }
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} other people liked your post.", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} liked your post.", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} liked your post.", names[0]);
            else
                Console.WriteLine("No one likes your or your post.");
        }

        public void Exercise2()
        {
            Console.Write("What's your name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine(reversed);
        }

        public void Exercise3()
        {
            var newList = new List<int>();

            while (newList.Count < 5)
            {
                Console.Write("Enter a unique number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (newList.Contains(input))
                {
                    Console.WriteLine("You already entered" + input);
                    continue;
                }
                newList.Add(input);
            }
            newList.Sort();
            foreach (var number in newList)
                Console.WriteLine(number);
        }

        public void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                else
                    numbers.Add(Convert.ToInt32(input));
            }

            var unique = new List<int>();
            foreach (var number in numbers)
            {
                if (!unique.Contains(number))
                    unique.Add(number);
            }
            unique.Sort();
            foreach (var number in unique)
                Console.WriteLine(number);
        }
    }
}