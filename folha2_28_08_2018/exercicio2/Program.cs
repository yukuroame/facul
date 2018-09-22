using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, soma;
            Console.WriteLine("Digite o primeiro número.");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            n2 = float.Parse(Console.ReadLine());
            soma = n1 + n2;
            if (soma <15)
            {
                Console.Write("Resultado: {0:0.00}", soma);
            }
            else
            {
                Console.Write("O resultado é menor ou igual a 15.");
            }
            Console.Read();
        }
    }
}
