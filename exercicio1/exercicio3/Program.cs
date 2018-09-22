using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float d, c, r;
            Console.WriteLine("Digite o valor em dólar.");
            d = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação atual de dólar para real.");
            c = float.Parse(Console.ReadLine());
            r = d * c;
            Console.WriteLine("O valor convertido é de R$ {0:0.00}.", r);
            Console.Read();
        }
    }
}
