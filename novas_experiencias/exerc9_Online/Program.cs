using System;

namespace exerc9_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, gramas;
            Console.WriteLine("Digite o peso: ");
            peso = float.Parse(Console.ReadLine());
            gramas = peso * 1000;
            Console.WriteLine("O valor em gramas é = {0} ", gramas);
            Console.ReadKey();
        }
    }
}
