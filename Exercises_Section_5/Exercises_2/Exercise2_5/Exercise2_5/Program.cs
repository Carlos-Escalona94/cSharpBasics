using System;
using System.Net.NetworkInformation;

namespace Exercise2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int maxValue = 0;

            Console.WriteLine("Enter a list of numbers:");
            userInput = Console.ReadLine();

            foreach (var character in userInput)
            {
                if (character != ',')
                {
                    int number = Int32.Parse(character.ToString());
                    maxValue = (isGreater(number, maxValue)) ? number : maxValue; 
                }
            }

            Console.WriteLine(maxValue);
        }

        public static bool isGreater(int a, int b)
        {
            return a > b;
        }
    }
}
