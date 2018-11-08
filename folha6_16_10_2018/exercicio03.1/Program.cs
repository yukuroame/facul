using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03._1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 1000;
            while (x <= 1999)
            {
                if (x % 11 == 0 || x % 11 == 5)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
            Console.ReadKey();
        }
    }
}
