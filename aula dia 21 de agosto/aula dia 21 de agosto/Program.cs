using System;

namespace aula_dia_21_de_agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, altura;
            Console.WriteLine("Digite o raio.");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura.");
            altura = double.Parse(Console.ReadLine());
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("volume={0}", volume);
            Console.Read();
        }
    }
}
