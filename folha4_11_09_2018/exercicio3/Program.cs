using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Digite A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite C");
            c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.Write("A não pode ser zero!!");
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta >= 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (a * 2);
                    x2 = (-b - Math.Sqrt(delta)) / (a * 2);
                    Console.Write("delta: {0:0.00} \nx1:{1:0.00} \nx2:{2:0.00}", delta, x1, x2);
                }
                else
                {
                    Console.Write("Delta é menor que o zero!!");
                }
            }
            Console.Read();
        }
    }
}
