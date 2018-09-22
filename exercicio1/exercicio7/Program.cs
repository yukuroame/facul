using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            float dt, l, cmc;
            Console.WriteLine("Digite a distância percorrida por seu carro.");
            dt = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o litro de gasolina consumida.");
            l = float.Parse(Console.ReadLine());
            cmc = dt / l;
            Console.WriteLine("O consumo do seu carro é de {0} km/litro.", cmc);
            Console.Read();
        }
    }
}
