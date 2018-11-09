using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 1;
            Console.WriteLine("Digite o número para calcular fatorial.");
            x = int.Parse(Console.ReadLine());
            while (x >= 1)
            {
                y *= x;
                Console.WriteLine("{0}x{1}={2}", x, y/x, y);
                x--;
            }
            Console.ReadKey();
        }
    }
}
