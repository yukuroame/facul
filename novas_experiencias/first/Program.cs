using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, meio, menor;
            Console.WriteLine("Digite a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite c");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    maior = a;
                }
                else
                {
                    maior = c;
                }
            }
            else
            {
                if (b > c)
                {
                    maior = b;
                }
                else
                {
                    maior = c;
                }
            }
            if (a < b)
            {
                if (a < c)
                {
                    menor = a;
                }
                else
                {
                    menor = c;
                }
            }
            else
            {
                if (b < c)
                {
                    menor = b;
                }
                else
                {
                    menor = c;
                }
            }
            meio = a + b + c - maior - menor;
            Console.Write("maior: {0} \nmeio: {1} \nmenor: {2}", maior, meio, menor);
            Console.Read();
        }
    }
}
