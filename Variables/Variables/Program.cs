﻿using System;
using Variables.Math;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            //float price;

            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            //int hour = 10;

            //if
            //    (hour >= 0 && hour < 12) Console.WriteLine("It's morning.");
            //else if
            //    (hour >= 12 && hour < 18) Console.WriteLine("It's afternoon.");
            //else
            //    Console.WriteLine("It's afternoon.");
        }
    }
}