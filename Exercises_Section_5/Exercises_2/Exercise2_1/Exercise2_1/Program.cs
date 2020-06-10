using System;

namespace Exercise2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MaxValue = 100;

            for (int i = 1; i < MaxValue; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
