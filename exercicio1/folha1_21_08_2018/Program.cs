using System;

namespace folha1_21_08_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            float n1, n2, n3, media;
            Console.WriteLine("Digite o seu nome.");
            name = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota.");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota.");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota.");
            n3 = float.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.Write("Nome: {0} \nNota média: {1:0.00}", name, media);

            Console.Read();
        }
    }
}
