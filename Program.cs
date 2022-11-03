using System;

namespace calculadora
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja calcular?");
            Console.WriteLine("1 - SOMAR");
            Console.WriteLine("2 - SUBTRAIR");
            Console.WriteLine("3 - MULTIPLICAR");
            Console.WriteLine("4 - DIVIDIR");
            Console.WriteLine("5 - SAIR");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Vamos Somar dois numeros!!");

            Console.WriteLine("Primeiro valor; ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor; ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Vamos Subtrair dois numeros!");
            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor:  ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine("O valor da subtração é: " + resultado);
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Vamos Multiplicar dois numeros!");

            Console.WriteLine("Informe o Primeiro Numero: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Numero: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("O valor da multiplicação é: " + resultado);
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Vamos Dividir dois numeros!");

            Console.WriteLine("Informe o Primeiro Numero: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Numero: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("O valor da Divisao é: " + resultado);
            Console.ReadKey();
            Menu();

        }
    }
}