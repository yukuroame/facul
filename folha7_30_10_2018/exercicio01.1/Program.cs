using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int cont, maior, x;
            maior = 0;
            x = 0;
            for (cont = 0; cont <= 9; cont++)
            {
                Console.WriteLine("Digite o {0}º número.", cont + 1);
                numeros[cont] = int.Parse(Console.ReadLine());
                if (maior < numeros[cont])
                {
                    maior = numeros[cont];
                    x = cont;
                }
            }
            Console.WriteLine("O maior número é: {0}, e a posição é: {1}", maior, x);
            Console.Read();
        }
    }
}
