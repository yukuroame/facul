using System;

namespace _27_agosto_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            double SN, AU, SA;
            Console.WriteLine("Digite o valor do salário.");
            SN = double.Parse(Console.ReadLine());
            AU = SN * 7.5 / 100;
            SA = SN + AU;
            Console.Write("O aumento de 7,5% do seu salário é de R$ {0}, e você vai receber R$ {1}.", AU, SA);
            Console.Read();
        }
    }
}
