using System;

namespace Exercise2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaUsuario;
            var continueProgram = true;
            var count = 0;

            while (true)
            {
                var number = 0;

                entradaUsuario = Console.ReadLine();



                if (entradaUsuario.ToUpper() == "Ok".ToUpper())
                {
                    break;
                }
                else
                {
                    number = Int32.Parse(entradaUsuario);
                }

                count = count + number;
                Console.WriteLine(count);

            }

            
        }
    }
}
