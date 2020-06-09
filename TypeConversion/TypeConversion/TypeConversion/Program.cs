using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            i = 1000;
            byte c = (byte)i;

            Console.WriteLine(c); //Shows 232 because overflow

            var number = "1234";
            int j = Convert.ToInt32(number);
            //byte k = Convert.ToByte(number); Lança uma exceção o número é muito grande para ser convertido em um byte

            Console.WriteLine(j);

            try
            {
                byte k = Convert.ToByte(number);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte");
            }

            

        }
    }
}
