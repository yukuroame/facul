using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, par = 0, maior = 0, menor = 0, soma = 0, z = 0;
            float media, y = 0;
            while (x == 0)
            {
                Console.WriteLine("Digite o número.");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                else
                {
                    y++;
                    soma += x;
                    if (x % 2 == 0)
                    {
                        par++;
                    }
                    if (x < z)
                    {
                        menor = x;
                    }
                    else
                    {
                        maior = x;
                    }
                    z = x;
                }
            }
            media = soma / y;
            Console.WriteLine("números digitados:{0} \npares: {1} \nMaior valor: {2} \nmenor valor: {3} \nsoma: {4} \nmédia aritmética: {5:0.00}", y, par, maior, menor, soma, media);
            Console.ReadKey();
        }
    }
}
