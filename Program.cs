
namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            Subtracao();

        }
        static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O Resultado da SOMA é: " + resultado);
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O valor da SUBTRAÇÂO é: {resultado}");
        }


    }
}