﻿using System;

namespace Conditionals
{

    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if(hour > 0 && hour < 12)
                Console.WriteLine("It's morning");
            else if(hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");

            bool isGoldCustomer = true;

            float price;
            /*if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            */

            price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("It's Spring");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter");
                    break;
                default:
                    Console.WriteLine("Oops something go wrong");
                    break;
            }
        }
    }
}
