using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08._1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 1;
            float soma = 0, y = 1;
            while (x <= 20)
            {
                soma += (1 / y);
                y *= 2;
                x++;
            }
            Console.WriteLine("Soma: {0}", soma);
            Console.Read();
        }
    }
}
