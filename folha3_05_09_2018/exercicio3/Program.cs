using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float IMC, peso, altura;
            Console.WriteLine("Digite a altura.");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso.");
            peso = float.Parse(Console.ReadLine());
            IMC = peso / (altura * altura);
            if (IMC < 18.5)
            {
                Console.Write("Você está abaixo do peso.");
            }
            else if (IMC >= 18.5 && IMC <= 25)
            {
                Console.Write("Você está no peso normal.");
            }
            else if (IMC > 25 && IMC <= 30)
            {
                Console.Write("Você está acima do peso.");
            }
            else
                Console.Write("Você está muito acima do peso!");

            Console.Read();
        }
    }
}
