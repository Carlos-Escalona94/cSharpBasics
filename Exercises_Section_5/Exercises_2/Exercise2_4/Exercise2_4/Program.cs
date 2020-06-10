using System;

namespace Exercise2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxTries = 4;
            var ramdonNumber = new Random().Next(1, 11);
            bool success = false;
            string result;

            Console.WriteLine(ramdonNumber);

            for (int i = 0; i < maxTries; i++)
            {
                string userInput;
                int number;
                

                Console.WriteLine("Digite um número de um a dez:");
                userInput = Console.ReadLine();
                number = Int32.Parse(userInput);

                if (number == ramdonNumber)
                {
                    success = true;
                    break;
                }
            }

            result = success ? "You Win" : "You Lose";

            Console.WriteLine(result);

        }
    }
}
