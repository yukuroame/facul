using System;

namespace execicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            double n1, n2, r;
            Console.WriteLine("Digite o primeiro número.");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual operação vai usar？");
            op = Console.ReadLine();
            if (op == "+")
            {
                r = n1 + n2;
                Console.WriteLine("Resultado: {0:0.00}", r);
            }
            else if (op == "-")
            {
                r = n1 - n2;
                Console.Write("Resultado: {0:0.00}", r);
            }
            else if (op == "*")
            {
                r = n1 * n2;
                Console.Write("Resultado: {0:0.00}", r);
            }
            else if (op == "/" && n2 != 0)
            {
                r = n1 / n2;
                Console.Write("Resultado: {0:0.00}", r);
            }
            else if (op == "/" && n2 == 0)
            {
                Console.Write("Erro de divisão por zero!");
            }
            else
            {
                Console.Write("Operação inválida!");
            }
            Console.Read();
        }
    }
}
