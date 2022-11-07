
namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            Multiplicacao();

        }
        static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O Resultado da SOMA é: " + resultado); //Concatenação
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O valor da SUBTRAÇÂO é: {resultado}"); //Interpolação
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da MULTIPLICAÇÂO é: {v1 * v2}");


        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da Divisao é: {v1 / v2} ");


        }


    }
}