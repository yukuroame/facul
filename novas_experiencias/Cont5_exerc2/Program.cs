using System;

namespace Cont5_exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = -1;
            y = 5;
            do
            {
                z = y++;
                x = ++x;
            } while (x > 0);
            Console.WriteLine("o valor de z é: " + z);
            Console.Read();
        }
    }
}
