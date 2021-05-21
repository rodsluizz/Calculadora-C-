using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.WriteLine("Digite um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1. SOMAR | 2. SUBTRAIR | 3.MULTIPLICAR | 4.DIVIDIR");
            int operador = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(operador){
                case 1: Somar(v1, v2); break;
                case 2: Subtrair(v1, v2); break;
                case 3: Multiplicar(v1, v2); break;
                case 4: Dividir(v1, v2); break;
                default: Menu(); break;
            }
        }
        static void Somar(float n1, float n2){
            float resultado = n1 + n2;
            Console.WriteLine(resultado);
            Menu();
        }
        static void Subtrair(float n1, float n2){
            float resultado = n1 - n2;
            Console.WriteLine(resultado);
            Menu();
        }
        static void Multiplicar(float n1, float n2){
            float resultado = n1 * n2;
            Console.WriteLine(resultado);
            Menu();
        }
        static void Dividir(float n1, float n2){
            float resultado = n1 * n2;
            Console.WriteLine(resultado);
            Menu();
        }

    }
}
