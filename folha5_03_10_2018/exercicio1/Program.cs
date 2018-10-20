using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;
            Console.WriteLine("Digite um número para mostrar a sua tabuada.");
            n1 = int.Parse(Console.ReadLine());
            for (n2 = 0; n2 <= 10; n2++)
            {
                r = n1 * n2;
                Console.WriteLine("{0}x{1}={2}", n1, n2, r);
            }
            Console.Read();
        }
    }
}
