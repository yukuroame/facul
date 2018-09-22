using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double s, rs, ns;
            Console.WriteLine("Digite o nome do funcionário.");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário.");
            s = double.Parse(Console.ReadLine());
            if (s < 500)
            {
                rs = s * 15 / 100;
                ns = s + rs;
                Console.Write("O novo salário é R$: {0:0.00}", ns);
            }
            else if (s >= 500 && s <= 1000)
            {
                rs = s * 10 / 100;
                ns = s + rs;
                Console.Write("O novo salário é R$: {0:0.00}", ns);
            }
            else
            {
                rs = s * 5 / 100;
                ns = s + rs;
                Console.Write("O novo salário é R$: {0:0.00}", ns);
            }
                
            Console.Read();
        }
    }
}
