using System;

namespace Tipos_de_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5 ;
            int num2 = num1;
            int resultado = num1 + num2;
            num1 = 6;

            Console.WriteLine("Valor do num1 é: {0} e esta na stack",num1.ToString());
            Console.WriteLine("Valor do num2 é: {0} e esta na stack", num2.ToString());
           
          
            Console.WriteLine("Calculadora");
            Calculadora minhacalculadora = new Calculadora();
            minhacalculadora.somar();

            Console.WriteLine("Variaveis nula");
            int? altura = null;

        if (altura.HasValue)
            {
            Console.WriteLine("O valor é: {0}: ", altura);
            }
        else
            {
             Console.WriteLine("Altura está nullo ");
            }
            Console.WriteLine(altura.ToString());

            Console.ReadKey();
        }
        
    }
}
