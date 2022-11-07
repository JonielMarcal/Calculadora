
namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(" CALCULADORA ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Selecionae a Opção Desejada");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }



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
            Console.ReadKey();
            Menu();
        }
        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O valor da SUBTRAÇÂO é: {resultado}"); //Interpolação
            Console.ReadKey();
            Menu();
        }
        static void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da MULTIPLICAÇÂO é: {v1 * v2}");
            Console.ReadKey();
            Menu();


        }
        static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Informe o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O Resultado da Divisao é: {v1 / v2} ");
            Console.ReadKey();
            Menu();


        }


    }
}