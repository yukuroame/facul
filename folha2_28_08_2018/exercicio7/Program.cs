using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;
            double d, pt;
            Console.WriteLine("Digite a quantidade de dias que deseja locar.");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor de selo do DVD dentre: verde, azul, branco ou rosa.");
            cor = Console.ReadLine();
            if (cor == "verde")
            {
                pt = d * 5.50;
                Console.Write("O valor total é R$: {0:0.00}", pt);
            }
            else if (cor == "azul")
            {
                pt = d * 5.70;
                Console.Write("O valor total é R$: {0:0.00}", pt);
            }
            else if (cor == "branco")
            {
                pt = d * 4.00;
                Console.Write("O valor total é R$: {0:0.00}", pt);
            }
            else if (cor == "rosa")
            {
                pt = d * 3.50;
                Console.Write("O valor total é R$: {0:0.00}", pt);
            }
            else
                Console.Write("Cor inválida!");
            Console.Read();
        }
    }
}
