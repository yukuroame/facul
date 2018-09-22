using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, f;
            Console.WriteLine("Digite a temperatura em ºC.");
            c = float.Parse(Console.ReadLine());
            f = (9 * c + 160) / 5;
            Console.Write("A temperatura em Fahrenheit é de {0} graus.", f);
            Console.Read();
        }
    }
}
