using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Seja Bem Vindo a Calculadora .NET");
            Console.WriteLine("---------------------");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");
            Console.WriteLine("Escolha uma das opções abaixo:");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao) //CHAMANDO AS FUNÇÕES
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Saida(); break;
                default: Menu(); break;

            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("----Soma----");
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}"); //CIFRÃO PERMITE UTILIZAR CHAVES PARA INTERPORLAR VARIÁVEL AO TEXTO
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer Tecla para voltar ao Menu inicial");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("----Subtracao----");
            Console.WriteLine("");

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer Tecla para voltar ao Menu inicial");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("----Divisão----");
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer Tecla para voltar ao Menu inicial");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("----Multiplicação----");
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer Tecla para voltar ao Menu inicial");
            Console.ReadKey();
            Menu();
        }
        static void Saida()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Programa encerrado com Sucesso!");
            Console.WriteLine("---------------------");
            System.Environment.Exit(0);
        }
    }
}
