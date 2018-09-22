using System;

namespace Aulas_de_Edilson
{
    class  Bb 
    {
        static void Main(string[] args)
        {
            float bas, alt, area;
            Console.WriteLine("digite a base.");
            bas = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura.");
            alt = float.Parse(Console.ReadLine());
            area = bas * alt;
            Console.Write("area={0}", area);
            
            Console.ReadKey();
        }
    }
}
