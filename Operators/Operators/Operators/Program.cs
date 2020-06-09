using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 10;
            var b = 3;
            var c = 2;

            Console.WriteLine(a + b);
            Console.WriteLine(a/b); //mostra treis (divisao enteira)
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c); //mostra dezesseis
            Console.WriteLine((a + b) * c); //mostra vinte e seis
            Console.WriteLine(a > b); //mostra true
            Console.WriteLine(a == b); //mostra false
            Console.WriteLine(!(a != b)); //mostra false
            Console.WriteLine(b > a && b > c); //mostra false
            Console.WriteLine(b > a || b > c); //mostra true
        }
    }
}
