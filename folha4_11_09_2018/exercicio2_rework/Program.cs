using System;

namespace exercicio2_rework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, meio, menor;
            Console.WriteLine("Digite A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite C");
            c = int.Parse(Console.ReadLine());
            maior = a;
            //Para ver o número maior.
            if (b > a && b > c) {
                maior = b;
            } else if (c > a && c > b) {
                maior = c;
            } //Para ver o número menor.
            menor = a;
            if ( b < a && b < c) {
                menor = b;
            } else if ( c < a && c < b) {
                menor = c;
            } //Para ver o meio.
            meio = (a + b + c) - maior - menor;
            Console.Read();
        }
    }
}
