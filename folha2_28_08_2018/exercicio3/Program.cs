using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, r;
            Console.WriteLine("Digite o primeiro número.");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            n2 = float.Parse(Console.ReadLine());
            r = n1 - n2;
            if (r < 0)
            {
                Console.Write("O resultado é negativo. {0:0.00}", r);
            }
            else
            {
                Console.Write("resultado: {0:0.00}", r);
            }
            Console.Read();
        }
    }
}
