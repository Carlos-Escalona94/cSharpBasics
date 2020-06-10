using System;

namespace Excercise1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteVelocidade;
            int velocidadeAtual;
            int demeritPoints; // Os "demerit points" será tomada como resultado da divisao enteira da diferenca de velocidade 
            string entradaDoUsuario;
            string resultadoValidacao;

            Console.WriteLine("Escreva o limite da velocidade:");
            entradaDoUsuario = Console.ReadLine();
            limiteVelocidade = Int32.Parse(entradaDoUsuario);

            Console.WriteLine("Escreva a velocidade atual:");
            entradaDoUsuario = Console.ReadLine();
            velocidadeAtual = Int32.Parse(entradaDoUsuario);

            if (velocidadeAtual <= limiteVelocidade)
            {
                resultadoValidacao = "Ok";
            }
            else
            {
                demeritPoints = (velocidadeAtual - limiteVelocidade) / 5;

                resultadoValidacao = (demeritPoints < 12) ? demeritPoints.ToString() : "License Suspended";
            }

            Console.WriteLine(string.Format("Messagen do radar: {0}", resultadoValidacao));
        }
    }
}
