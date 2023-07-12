using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine(v1);
            Console.WriteLine(v1 + 1);
        }
    }
}
