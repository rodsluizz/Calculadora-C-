using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("1. SOMAR | 2. SUBTRAIR | 3.MULTIPLICAR | 4.DIVIDIR");
            int operador = int.Parse(Console.ReadLine());

            switch(operador){
                case 1: Console.WriteLine(v1 + v2); break;
                case 2: Console.WriteLine(v1 - v2); break;
                case 3: Console.WriteLine(v1 * v2); break;
                default: Console.WriteLine(v1 / v2); break;
            }

        }
    }
}
