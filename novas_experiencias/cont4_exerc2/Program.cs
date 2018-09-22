using System;

namespace cont4_exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, r1, r2;
            // Limpa a tela
            Console.Clear();
            Console.WriteLine("Digite um numero ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero ");
            num2 = Double.Parse(Console.ReadLine());
            r1 = Math.Pow(num2, num1);
            r2 = Math.Pow(num1, num2);
            Console.WriteLine("Resposta 1  = {0}", r1);
            Console.WriteLine("Resposta 2  = {0}", r2);
            // Parar o programa a espera de um ENTER
            Console.ReadKey();
        }
    }
}
