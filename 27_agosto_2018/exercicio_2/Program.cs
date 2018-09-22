using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, media;
            Console.WriteLine("Digite a primeira nota.");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota.");
            n2 = float.Parse(Console.ReadLine());
            media = (n1 * 6 + n2 * 4) / 10;
            Console.Write("A média ponderada é {0}", media);
            Console.Read();
        }
    }
}
