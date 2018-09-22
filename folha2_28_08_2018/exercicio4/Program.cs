using System;

namespace exercicio4
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
            r = n1 * n2;
            if (r > 70 && r < 100)
            {
                Console.Write("O resultado é: {0:0.00}", r);
            }
            else
            {
                Console.Write("O resultado não é dentre 70 à 100.");
            }
            Console.Read();
        }
    }
}
