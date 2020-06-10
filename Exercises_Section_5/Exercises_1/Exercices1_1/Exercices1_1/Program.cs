using System;

namespace Exercices1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaDoUsuario;
            int valorNumericoEntrada;
            string resultadoValidacion;
            
            Console.WriteLine("Escreva um numero:");
            entradaDoUsuario = Console.ReadLine();
            valorNumericoEntrada = Int32.Parse(entradaDoUsuario);

            resultadoValidacion = (valorNumericoEntrada >= 1 && valorNumericoEntrada <= 10) ? "Valid":"Invalid";

            Console.WriteLine(resultadoValidacion);
        }
    }
}
