using System;

namespace Exercises1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;
            string entradaDoUsuario;
            string resultadoValidacao;
            
            Console.WriteLine("Escreva a largura da imagem:");
            entradaDoUsuario = Console.ReadLine();
            width = Int32.Parse(entradaDoUsuario);

            Console.WriteLine("Escreva a altura da imagem:");
            entradaDoUsuario = Console.ReadLine();
            height = Int32.Parse(entradaDoUsuario);

            if (width > height)
            {
                resultadoValidacao = "landscape";
            }
            else if (width < height)
            {
                resultadoValidacao = "potrait";
            }
            else
            {
                resultadoValidacao = "even";
            }

            Console.WriteLine(string.Format("A imagem é do tipo: {0}", resultadoValidacao));

        }
    }
}
