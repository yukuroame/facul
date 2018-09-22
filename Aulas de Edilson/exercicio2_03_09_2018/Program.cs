using System;

namespace exercicio2_03_09_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            float ano;
            Console.WriteLine("Digite o ano.");
            ano = float.Parse(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.Write("Ano bissexto");
            }
            else
                Console.Write("Não é ano bissexto");
            Console.Read();
        }
    }
}
