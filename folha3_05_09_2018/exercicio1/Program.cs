using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace folha3_05_09_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            float n1, n2, r;
            Console.WriteLine("Digite o primeiro número.");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora escolha um número de 1 a 4.");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    r = (n1 + n2) / 2;
                    Console.Write("resultado: {0:0.00}", r);
                    break;
                case 2:
                    if (n1 >= n2)
                    {
                        r = n1 - n2;
                    }
                    else
                        r = n2 - n1;
                    Console.Write("resultado: {0:0.00}", r);
                    break;
                case 3:
                    r = n1 * n2;
                    Console.Write("resultado: {0:0.00}", r);
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        r = n1 / n2;
                        Console.Write("resultado: {0:0.00}", r);
                    }
                    else
                        Console.Write("Error!");
                    break;
                default:
                    Console.Write("Error!");
                    break;
            }

            Console.Read();
        }
    }
}
