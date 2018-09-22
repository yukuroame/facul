using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float vf, vi, vd;
            Console.WriteLine("Digite o valor de fábrica do carro.");
            vf = float.Parse(Console.ReadLine());
            vi = vf + vf * 45 / 100;
            vd = vi + vi * 15 / 100;
            Console.Write("O valor de venda do carro fica R$ {0:0.00}", vd);
            Console.Read();
        }
    }
}
