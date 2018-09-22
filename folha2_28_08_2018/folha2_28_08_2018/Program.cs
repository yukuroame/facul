using System;

namespace folha2_28_08_2018
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
            media = (n1 + n2) / 2;
            if (media >= 7)
            {
                Console.WriteLine("nota: {0:0.00} \nParabéns você foi aprovado!", media);
            }
            else {
                Console.WriteLine("nota: {0:0.00} \nVocê foi reprovado!", media);
            } 
            Console.Read();
        }
    }
}
