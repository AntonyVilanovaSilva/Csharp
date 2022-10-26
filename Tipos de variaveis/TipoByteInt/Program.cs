using System;

namespace TipoByteInt
{
    class Program
    {
        static void Main(string[] args)
        {
            byte v1 = 10;
            Console.WriteLine("O valor de V1 é : {0}", v1);
            Console.WriteLine("O tipo é: {0}", v1.GetType());

            Console.WriteLine("Digite um valor na faixa de 0 a 225");

            try
            {
                byte vdigitado = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("O valor digitado é byte");

            }
            catch (OverflowException)
            {
                Console.WriteLine();
                var vdigitado = Convert.ToByte(Console.ReadLine());
                if (vdigitado <= 255)
                {
                    Console.WriteLine("O valor digitado é byte");
                }
                else
                {
                    Console.WriteLine("O valor digitado não é  byte");
                }
                Console.WriteLine("O valor digital é; {0}", vdigitado);
            }
        }
    }
}
