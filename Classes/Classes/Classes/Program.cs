using Classes.Math;
using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {

            var john = new Person();
            john.firtsName = "John";
            john.lastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            var result = calculator.add(1, 2);

            Console.WriteLine(result);

        }
    }
}
