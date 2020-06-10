using System;

namespace Exercise2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int number;
            var count = 1;

            userInput = Console.ReadLine();
            number = Int32.Parse(userInput);

            for (int i = 1; i <= number; i++)
            {
                count = count * i;
            }

            Console.WriteLine(count);
        }
    }
}
