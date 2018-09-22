using System;

namespace exerc4_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            float custo, convite, qtd;
            Console.WriteLine("Digite o custo do espetculo: ");

            custo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preco do convite: ");
            convite = float.Parse(Console.ReadLine());
            qtd = custo / convite;
            Console.WriteLine("Quantidade de convites necessaria: {0} ", qtd);
            Console.ReadKey();
        }
    }
}
