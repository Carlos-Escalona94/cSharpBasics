using System;

namespace IntroArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var booleans = new bool[3];
            booleans[0] = true;

            Console.WriteLine(booleans[0]);
            Console.WriteLine(booleans[1]);
            Console.WriteLine(booleans[2]);

            var names = new string[3] {"Jack", "John", "Mary"};
        }
    }
}
