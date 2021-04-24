using System;
using Lists.Math;
using System.Collections.Generic;


namespace Lists
{

    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
            /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
            /// </summary>

            Console.WriteLine("Please enter a time between 00:00 and 23:59: ");

            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }

            var time = input.Split(':');

            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
            }



        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public void Exercise1()
        {
            Console.WriteLine("Enter a string of numbers\nseperated by dashes\nex. 1-2-5-4-3");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var count = 0;


            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (Convert.ToInt32(numbers[i]) == Convert.ToInt32(numbers[i + 1]) - 1)
                    count++;
                else
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
                if (count == numbers.Count - 1)
                    Console.WriteLine("Consecutive");

            }
            //MOSH'S SOLUTION

            //Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //numbers.Sort();

            //var isConsecutive = true;
            //for (var i = 1; i < numbers.Count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}

        }
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public void Exercise2()
        {
            Console.Write("Write a few numbers seperated by a hyphen: ");
            var input = Console.ReadLine();
            if (input.Length == 0) return;

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var isDuplicated = false;

            foreach (var number in numbers)
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    isDuplicated = true;
                    Console.WriteLine("Duplicate");
                    break;
                }

            if (isDuplicated == false) Console.WriteLine("No Duplicates");

            //Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //    return;

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            //var uniques = new List<int>();
            //var includesDuplicates = false;
            //foreach (var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //    else
            //    {
            //        includesDuplicates = true;
            //        break;
            //    }
            //}

            //if (includesDuplicates)
            //    Console.WriteLine("Duplicate");
        }
    }
}