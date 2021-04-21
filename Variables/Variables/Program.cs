using System;
using Variables.Math;


namespace Variables
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the speed limit?\nAnswer: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("How fast are you going?\nAnswer: ");
            var speedOfCar = Convert.ToInt32(Console.ReadLine());

            var speedOver = speedOfCar - speedLimit;

            int mphPerDemerit = 5;

            var demeritPoints = speedOver / mphPerDemerit;

            if (speedOfCar < speedLimit) Console.WriteLine("Speed up slow poke!");
            else
            {
                if (demeritPoints < 12)
                    Console.WriteLine("You have " + demeritPoints + " points.");
                else
                    Console.WriteLine("Gimme dat license, you nutter.");

            }
        }

        public void Exercise1()
        {
            Console.WriteLine("Pick a number 1 to 10.");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Yeah boyeeeee.");
            else
                Console.WriteLine("Nawww dude.");
        }

        public void Exercise2()
        {
            Console.WriteLine("Pick a number: ");
            var n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number: ");
            var n2 = Convert.ToInt32(Console.ReadLine());

            var answer = (n1 > n2) ? n1 : n2;
            Console.WriteLine(answer + " is the bigger number.");
        }
        public void Exercise3()
        {
            Console.Write("Length in pixels: ");
            var length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width in pixels: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var answer = (length < width) ? "landscape" : "portrait";
            Console.WriteLine("The image is a " + answer);

            //MOSH'S ANSWER
            //Console.Write("Image width: ");
            //var width = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Image height: ");
            //var height = Convert.ToInt32(Console.ReadLine());

            //var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            //Console.WriteLine("Image orientation is " + orientation);
        }

        //public enum ImageOrientation
        //{
        //    Landscape,
        //    Portrait
        //}
    }
}