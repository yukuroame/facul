using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float v, p, vp;
            Console.WriteLine("Digite o valor da compra.");
            v = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de prestação que deseja pagar.");
            p = float.Parse(Console.ReadLine());
            vp = v / p;
            Console.WriteLine("valor da compra: {0:0.00} \nquantidade de prestação: {1} \nvalor da parela: {2:0.00}", v, p, vp);
            Console.Read();
        }
    }
}
