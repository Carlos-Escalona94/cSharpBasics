using System;

namespace Exercises1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaDoUsuario1; 
            string entradaDoUsuario2; 
            int valorNumericoEntrada1;
            int valorNumericoEntrada2;
            string resultadoValidacion;

            Console.WriteLine("Escreva o primeiro numero:");
            entradaDoUsuario1 = Console.ReadLine();
            Console.WriteLine("Escreva o segundo numero:");
            entradaDoUsuario2 = Console.ReadLine();

            valorNumericoEntrada1 = Int32.Parse(entradaDoUsuario1);
            valorNumericoEntrada2 = Int32.Parse(entradaDoUsuario2);

            if (valorNumericoEntrada1 == valorNumericoEntrada2)
            {
                resultadoValidacion = "Los valores son iguales";
            }
            else if (valorNumericoEntrada1 > valorNumericoEntrada2)
            {
                resultadoValidacion = valorNumericoEntrada1.ToString();
            }
            else
            {
                resultadoValidacion = valorNumericoEntrada2.ToString();
            }

            Console.WriteLine(string.Format("O valor mais alto é: {0}", resultadoValidacion));
        }
    }
}
