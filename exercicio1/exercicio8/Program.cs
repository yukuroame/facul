using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double sh, h, sl, sb;
            Console.WriteLine("Digite o nome do funcionário");
            name = Console.ReadLine();
            Console.WriteLine("Digite o salário por hora do funcionário.");
            sh = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora trabalhada pelo funcionário.");
            h = double.Parse(Console.ReadLine());
            sb = sh * h;
            sl = sb - (sb * 0.095);
            Console.Write("nome: {0} \nsalário bruto: {1:0.00} \nsalário líquido: {2:0.00}", name, sb, sl);
            Console.Read();
        }
    }
}
