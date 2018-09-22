using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cargo;
            double idade, sb, sl, rsb, gratis;
            Console.WriteLine("Digite o nome do funcionário.");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade.");
            idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o cargo.");
            cargo = Console.ReadLine();
            Console.WriteLine("Digite o salário bruto.");
            sb = double.Parse(Console.ReadLine());
            rsb = sb + sb * 0.38;
            gratis = rsb + rsb * 0.2;
            sl = gratis - rsb * 0.15;
            Console.Write("nome: {0} \nidade: {1} \ncargo: {2} \nsalário bruto: {3} \nsalário líquido: {4}", nome, idade, cargo, rsb, sl);
            Console.Read();
        }
    }
}
