using System;

namespace exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 h;
            float hora, conversao, m;
            Console.WriteLine("Digite a hora: ");

            hora = float.Parse(Console.ReadLine());
            h = (Int16)hora;
            m = hora - h;
            conversao = h * 60 + m * 100;
            Console.WriteLine("Hora convertida para minutos: {0}", conversao);
            Console.ReadKey();
        }
    }
}
