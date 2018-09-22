using System;

namespace exerc7_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, mp;
            float p1 = 2, p2 = 3;
            Console.WriteLine("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            mp = (n1 * p1 + n2 * p2) / (p1 + p2);
            Console.WriteLine("Resultado = {0} ", mp);
            Console.ReadKey();
        }
    }
}
