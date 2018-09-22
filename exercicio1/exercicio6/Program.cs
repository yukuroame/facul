using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, r, h;
            Console.WriteLine("Digite o raio do cilindro.");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura. ");
            h = double.Parse(Console.ReadLine());
            v = Math.PI * (r * r) * h;
            Console.Write("O volume do cilindro é {0:0.00}m³", v);
            Console.Read();
        }
    }
}
