using System;

namespace exerc8_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            float sal, vendas, com, sal_final;
            Console.WriteLine("Digite o salario fixo: ");
            sal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor das vendas: ");
            vendas = float.Parse(Console.ReadLine());

            com = (float)(vendas * 0.04);
            sal_final = sal + com;

            Console.WriteLine("Salario final = {0} ", sal_final);
            Console.WriteLine("Comissao = {0} ", com);

            Console.ReadKey();
        }
    }
}
