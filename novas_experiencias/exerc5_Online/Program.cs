using System;

namespace exerc5_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            float pes, polegadas, jardas, milhas;

            Console.WriteLine("Digite a medida em pés");
            pes = float.Parse(Console.ReadLine());
            polegadas = pes * 12;
            jardas = pes / 3;
            milhas = jardas / 1760;

            Console.WriteLine("Em podelgadas = {0} ", polegadas);
            Console.WriteLine("Em jardas = {0} ", jardas);
            Console.WriteLine("Em milhas = {0} ", milhas);

            Console.ReadKey();
        }
    }
}
