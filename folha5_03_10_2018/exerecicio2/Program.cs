using System;

namespace exerecicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int par,n1, n2, ma;
            par = 0;
            n2 = 0;
            for (n1 = 13; n1 <= 73; n1++)
            {
                if (n1 % 2 == 0)
                {
                    n2++;
                    par = par + n1;
                }
            }
            ma = par / n2;
            Console.WriteLine("A média aritmética é: {0:0.00}", ma);
            Console.Read();
        }
    }
}
