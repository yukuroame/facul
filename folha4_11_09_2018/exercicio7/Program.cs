using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            Console.WriteLine("Digite um número entre 0 a 9.");
            n = uint.Parse(Console.ReadLine());
            if (n < 0 || n >= 10)
            {
                Console.Write("Número fora do intervalo!");
            }
            else if (n % 2 == 0)
            {
                Console.Write("Número par menor que dez.");
            }
            else
            {
                Console.Write("Número ímpar menor que dez.");
            }
            Console.Read();
        }
    }
}
