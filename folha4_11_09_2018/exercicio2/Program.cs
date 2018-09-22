using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, meio, menor;
            Console.WriteLine("Digite o valor do A.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do B.");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do C.");
            c = int.Parse(Console.ReadLine());
            //coisa nova. para ver maior
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
            // para ver menor
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
            //para ver o meio
            meio = (a + b + c - maior - menor);
            Console.WriteLine("menor: {0} \nmeio: {1} \nmaior: {2}", menor, meio, maior);
            Console.Read();
        }
    }
}
