using System;

namespace exercicio1_03_09_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Digite o valor de A.");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B.");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C.");
            c = double.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.Write("Equilátero.");
                }
                else if (a == b && b != c || a == c && c != b || b == c && c != a)
                {
                    Console.Write("Isósceles");
                }
                else 
                {
                    Console.Write("Escaleno");
                }
            }
            else 
            {
                Console.Write("Não é triângulo!");
            }
            
            Console.Read();
        }
    }
}
