using System;

namespace aula_sexta
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;
            Console.WriteLine("digite o a");
            a = int.Parse(Console.ReadLine());
            b = 2147483647;
            r = a + b;
            Console.Write("Resultado: {0}", r);
            Console.Read();
        }
    }
}
