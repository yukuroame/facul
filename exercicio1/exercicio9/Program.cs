using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, a, b;
            Console.WriteLine("Digite o valor a.");
            A = Console.ReadLine();
            Console.WriteLine("Digite o valor b.");
            B = Console.ReadLine();
            b = A;
            a = B;
            Console.WriteLine("Troquei os valores do a e do b.");
            Console.Write("veja a: {0} \nveja b: {1}", a, b);
            Console.Read();
        }
    }
}
