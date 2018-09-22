using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite um número.");
            x = int.Parse(Console.ReadLine());
            if (x >= 0 && x < 100)
            {
                Console.Write("X entre 0 e 100!");
            }
            else if (x >= 100 && x < 1000)
            {
                Console.Write("X entre 100 e 1000!");
            }
            else if (x >= 1000)
            {
                Console.Write("X maior ou igual a 1000!");
            }
            else 
            {
                Console.Write("X menor que zero!");
            }
            Console.Read();
        }
    }
}
