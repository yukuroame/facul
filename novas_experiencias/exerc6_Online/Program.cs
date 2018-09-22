using System;

namespace exerc6_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 n1, n2, n3, mult;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            n3 = Int16.Parse(Console.ReadLine());
            mult = (Int16)(n1 * n2 * n3);
            Console.WriteLine("Resultado = {0} ", mult);
            Console.ReadKey();
        }
    }
}
